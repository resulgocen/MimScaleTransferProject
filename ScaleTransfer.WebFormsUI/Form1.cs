using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScaleTransfer.Business.Abstract;
using ScaleTransfer.Business.DependencyResolvers.Ninject;
using ScaleTransfer.Entities.Concrete;

namespace ScaleTransfer.WebFormsUI
{
    public partial class Form1 : Form
    {
        private ISabitService _sabitService = InstanceFactory.GetInstance<ISabitService>();
        private IYevmiyeService _yevmiyeService = InstanceFactory.GetInstance<IYevmiyeService>();
        private string databasePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectAccess()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Access veritabanı dosyasını seçiniz..!";
            openFileDialog.Filter = "Access Dosyası |*.mdb";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            databasePath = openFileDialog.FileName;
            cbxMaasAciklama.DataSource = _sabitService.GetAll(openFileDialog.FileName);
            cbxMaasAciklama.ValueMember = "Id";
            cbxMaasAciklama.DisplayMember = "MaasAciklamasi";

            btnExcelPath.Enabled = true;
        }

        private async void SelectExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Excel dosyasını seçiniz..!";
            openFileDialog.Filter = "Excel Dosyası |*.xls; *.xlsx";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            tbxExcelPath.Text = openFileDialog.FileName;
            lblStatus.Text = "Excel dosyasından veriler getiriliyor. Lütfen bekleyin...";
            dgwScale.DataSource = await Task.Run(()=>_yevmiyeService.GetAll(openFileDialog.FileName));
            lblStatus.Text = "Hazır";

            btnStartTransfer.Enabled = true;
        }

        private async void UpdateScale()
        {
            DialogResult dialogResult =
                MessageBox.Show("Skala '"+ cbxMaasAciklama.Text +"' adlı dosyaya aktarılacak. Onaylıyor musunuz?",
                    "Skala Aktar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            lblStatus.Text = "Skala aktarılıyor. Lütfen Bekleyiniz...";
            int sabitId = Convert.ToInt32(cbxMaasAciklama.SelectedValue);
            for (int i = -1; i < 31; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    await Task.Run(() => _yevmiyeService.Update(new Yevmiye()
                    {
                        GunlukCalismaBedeli = Convert.ToDouble(dgwScale.Rows[i + 1].Cells[j - 1].Value),
                        SabitId = sabitId,
                        GrupNo = j,
                        HizmetYili = i
                    }, databasePath));
                }
            }
            lblStatus.Text = "Hazır";
            MessageBox.Show("Tebrikler... Skala başarılı bir şekilde aktarıldı.", "Skala Aktar", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnGetDatabasePath_Click(object sender, EventArgs e)
        {
            SelectAccess();
        }

        private void btnExcelPath_Click(object sender, EventArgs e)
        {
            SelectExcel();
        }

        private void btnStartTransfer_Click(object sender, EventArgs e)
        {
            UpdateScale();
        }
    }
}
