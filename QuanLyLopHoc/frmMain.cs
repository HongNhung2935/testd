using DevExpress.XtraEditors;
using QuanLyLopHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyLopHoc
{
    public partial class frmMain : DevExpress.XtraBars.ToolbarForm.ToolbarForm {
        private Form currenFormChild;
        public frmMain()
        {
            InitializeComponent();
            ownCtrl.Text = "Xin chao " + "username"; // ko biet lay tu dau
        }

        private void OpenChildForm(Form childForm)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }

            // Test truyền dữ liệu
            lbTestTrangThai.Text = childForm.Text;
            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(currenFormChild);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void accTongQuan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTongQuan());
        }

        private void accQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyHocSinh());
        }

        private void accQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyGiaoVien());
        }

        private void accQuanLyLichDay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyLichDay());
        }

        private void accNhapDiemHocSinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapDiemHocSinh());
        }

        private void accThongKeBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeBaoCao());
        }

        private void accQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyTaiKhoan());
        }
        private void accThongBao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongBao());
        }

        private void accHuongDanSuDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHuongDanSuDung());
        }

        private void accGioiThieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGioiThieu());
        }

        private void btnThongBao_Click (object sender, EventArgs e) {
            OpenChildForm (new frmThongBao());
        }

        private void ownProfile_Click (object sender, EventArgs e) {
            // handle the the activity: opening and viewing the own profile
            OpenChildForm (new frmQuanLyTaiKhoan ());
        }

        private void changeMyPassword_Click (object sender, EventArgs e) {
            // handle the activity: change or reset the password
        }

        private void log_out_Click (object sender, EventArgs e) {
            // handle the activity: signing out
        }

        private void ownCtrl_Click_1 (object sender, EventArgs e) {
            popupOwnControl.Appearance.BackColor = Color.White;
            Point popupPosition = ownCtrl.PointToScreen (new Point (0, ownCtrl.Height + 15));
            popupOwnControl.ShowPopup (popupPosition);
        }
    }
}
