namespace QuanLyLopHoc
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel_control = new DevExpress.XtraEditors.PanelControl();
            this.ownCtrl = new DevExpress.XtraEditors.SimpleButton();
            this.ownControl = new DevExpress.XtraEditors.LabelControl();
            this.btnThongBao = new DevExpress.XtraEditors.LabelControl();
            this.lbTestTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.toolbarFormManager2 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.profile = new DevExpress.XtraBars.BarButtonItem();
            this.changePass = new DevExpress.XtraBars.BarButtonItem();
            this.logOut = new DevExpress.XtraBars.BarButtonItem();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            this.popupOwnControl = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.log_out = new DevExpress.XtraEditors.SimpleButton();
            this.changeMyPassword = new DevExpress.XtraEditors.SimpleButton();
            this.ownProfile = new DevExpress.XtraEditors.SimpleButton();
            this.accGioiThieu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accHuongDanSuDung = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accThongBao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQuanLyTaiKhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accThongKeBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accNhapDiemHocSinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQuanLyLichDay = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQuanLyGiaoVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accQuanLyHocSinh = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accTongQuan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.myProfile = new DevExpress.XtraBars.BarButtonItem();
            this.changePassword = new DevExpress.XtraBars.BarButtonItem();
            this.signOut = new DevExpress.XtraBars.BarButtonItem();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel_control)).BeginInit();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupOwnControl)).BeginInit();
            this.popupOwnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_control.Appearance.Options.UseBackColor = true;
            this.panel_control.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_control.Controls.Add(this.ownCtrl);
            this.panel_control.Controls.Add(this.ownControl);
            this.panel_control.Controls.Add(this.btnThongBao);
            this.panel_control.Controls.Add(this.lbTestTrangThai);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(206, 53);
            this.panel_control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(756, 44);
            this.panel_control.TabIndex = 1;
            // 
            // ownCtrl
            // 
            this.ownCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownCtrl.Appearance.Font = new System.Drawing.Font("Tahoma", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownCtrl.Appearance.Options.UseFont = true;
            this.ownCtrl.Location = new System.Drawing.Point(563, 5);
            this.ownCtrl.Name = "ownCtrl";
            this.ownCtrl.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ownCtrl.Size = new System.Drawing.Size(181, 36);
            this.ownCtrl.TabIndex = 4;
            this.ownCtrl.Text = "Xin chào username";
            this.ownCtrl.Click += new System.EventHandler(this.ownCtrl_Click_1);
            // 
            // ownControl
            // 
            this.ownControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ownControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownControl.Appearance.Options.UseFont = true;
            this.ownControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.ownControl.Location = new System.Drawing.Point(624, 14);
            this.ownControl.Name = "ownControl";
            this.ownControl.Size = new System.Drawing.Size(0, 17);
            this.ownControl.TabIndex = 3;
            // 
            // btnThongBao
            // 
            this.btnThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongBao.Appearance.Font = new System.Drawing.Font("Tahoma", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnThongBao.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThongBao.Appearance.Options.UseFont = true;
            this.btnThongBao.Appearance.Options.UseForeColor = true;
            this.btnThongBao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongBao.ImageOptions.SvgImage")));
            this.btnThongBao.Location = new System.Drawing.Point(514, 5);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(34, 34);
            this.btnThongBao.TabIndex = 2;
            this.btnThongBao.Text = " ";
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // lbTestTrangThai
            // 
            this.lbTestTrangThai.Appearance.Font = new System.Drawing.Font("Tahoma", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTrangThai.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.lbTestTrangThai.Appearance.Options.UseFont = true;
            this.lbTestTrangThai.Appearance.Options.UseForeColor = true;
            this.lbTestTrangThai.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink;
            this.lbTestTrangThai.AppearanceHovered.Options.UseForeColor = true;
            this.lbTestTrangThai.Location = new System.Drawing.Point(4, 9);
            this.lbTestTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTestTrangThai.Name = "lbTestTrangThai";
            this.lbTestTrangThai.Size = new System.Drawing.Size(226, 21);
            this.lbTestTrangThai.TabIndex = 1;
            this.lbTestTrangThai.Text = "Phần mềm quản lý lớp học";
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.profile,
            this.changePass,
            this.logOut});
            this.toolbarFormManager1.MainMenu = this.bar1;
            this.toolbarFormManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 33);
            this.barDockControlTop.Manager = this.toolbarFormManager2;
            this.barDockControlTop.Size = new System.Drawing.Size(962, 20);
            // 
            // toolbarFormManager2
            // 
            this.toolbarFormManager2.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager2.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager2.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager2.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager2.Form = this;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 570);
            this.barDockControlBottom.Manager = this.toolbarFormManager2;
            this.barDockControlBottom.Size = new System.Drawing.Size(962, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Manager = this.toolbarFormManager2;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 517);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(962, 53);
            this.barDockControlRight.Manager = this.toolbarFormManager2;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 517);
            // 
            // profile
            // 
            this.profile.Caption = "Hồ sơ của tôi";
            this.profile.Id = 1;
            this.profile.Name = "profile";
            // 
            // changePass
            // 
            this.changePass.Caption = "Đổi mật khẩu";
            this.changePass.Id = 2;
            this.changePass.Name = "changePass";
            // 
            // logOut
            // 
            this.logOut.Caption = "Đăng xuất";
            this.logOut.Id = 3;
            this.logOut.Name = "logOut";
            // 
            // panelBody
            // 
            this.panelBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBody.Controls.Add(this.popupOwnControl);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(206, 97);
            this.panelBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(756, 473);
            this.panelBody.TabIndex = 2;
            // 
            // popupOwnControl
            // 
            this.popupOwnControl.AutoSize = true;
            this.popupOwnControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupOwnControl.Controls.Add(this.log_out);
            this.popupOwnControl.Controls.Add(this.changeMyPassword);
            this.popupOwnControl.Controls.Add(this.ownProfile);
            this.popupOwnControl.Location = new System.Drawing.Point(439, 5);
            this.popupOwnControl.Manager = this.toolbarFormManager1;
            this.popupOwnControl.Name = "popupOwnControl";
            this.popupOwnControl.Size = new System.Drawing.Size(317, 232);
            this.popupOwnControl.TabIndex = 0;
            this.popupOwnControl.Visible = false;
            // 
            // log_out
            // 
            this.log_out.Appearance.Font = new System.Drawing.Font("Tahoma", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out.Appearance.Options.UseFont = true;
            this.log_out.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("log_out.ImageOptions.SvgImage")));
            this.log_out.Location = new System.Drawing.Point(38, 154);
            this.log_out.Name = "log_out";
            this.log_out.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.log_out.Size = new System.Drawing.Size(239, 47);
            this.log_out.TabIndex = 2;
            this.log_out.Text = "Đăng xuất";
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // changeMyPassword
            // 
            this.changeMyPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeMyPassword.Appearance.Options.UseFont = true;
            this.changeMyPassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("changeMyPassword.ImageOptions.SvgImage")));
            this.changeMyPassword.Location = new System.Drawing.Point(38, 80);
            this.changeMyPassword.Name = "changeMyPassword";
            this.changeMyPassword.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.changeMyPassword.Size = new System.Drawing.Size(239, 47);
            this.changeMyPassword.TabIndex = 1;
            this.changeMyPassword.Text = "Đổi mật khẩu";
            this.changeMyPassword.Click += new System.EventHandler(this.changeMyPassword_Click);
            // 
            // ownProfile
            // 
            this.ownProfile.Appearance.Font = new System.Drawing.Font("Tahoma", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownProfile.Appearance.Options.UseFont = true;
            this.ownProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ownProfile.ImageOptions.SvgImage")));
            this.ownProfile.Location = new System.Drawing.Point(38, 16);
            this.ownProfile.Name = "ownProfile";
            this.ownProfile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.ownProfile.Size = new System.Drawing.Size(239, 47);
            this.ownProfile.TabIndex = 0;
            this.ownProfile.Text = "Hồ sơ của tôi";
            this.ownProfile.Click += new System.EventHandler(this.ownProfile_Click);
            // 
            // accGioiThieu
            // 
            this.accGioiThieu.Name = "accGioiThieu";
            this.accGioiThieu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accGioiThieu.Text = "Giới thiệu";
            this.accGioiThieu.Click += new System.EventHandler(this.accGioiThieu_Click);
            // 
            // accHuongDanSuDung
            // 
            this.accHuongDanSuDung.Name = "accHuongDanSuDung";
            this.accHuongDanSuDung.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            this.accHuongDanSuDung.Click += new System.EventHandler(this.accHuongDanSuDung_Click);
            // 
            // accThongBao
            // 
            this.accThongBao.Name = "accThongBao";
            this.accThongBao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accThongBao.Text = "Thông báo";
            this.accThongBao.Click += new System.EventHandler(this.accThongBao_Click);
            // 
            // accQuanLyTaiKhoan
            // 
            this.accQuanLyTaiKhoan.Name = "accQuanLyTaiKhoan";
            this.accQuanLyTaiKhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.accQuanLyTaiKhoan.Click += new System.EventHandler(this.accQuanLyTaiKhoan_Click);
            // 
            // accThongKeBaoCao
            // 
            this.accThongKeBaoCao.Name = "accThongKeBaoCao";
            this.accThongKeBaoCao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accThongKeBaoCao.Text = "Thống kê - báo cáo";
            this.accThongKeBaoCao.Click += new System.EventHandler(this.accThongKeBaoCao_Click);
            // 
            // accNhapDiemHocSinh
            // 
            this.accNhapDiemHocSinh.Name = "accNhapDiemHocSinh";
            this.accNhapDiemHocSinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accNhapDiemHocSinh.Text = "Nhập điểm học sinh";
            this.accNhapDiemHocSinh.Click += new System.EventHandler(this.accNhapDiemHocSinh_Click);
            // 
            // accQuanLyLichDay
            // 
            this.accQuanLyLichDay.Name = "accQuanLyLichDay";
            this.accQuanLyLichDay.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyLichDay.Text = "Quản lý lịch dạy";
            this.accQuanLyLichDay.Click += new System.EventHandler(this.accQuanLyLichDay_Click);
            // 
            // accQuanLyGiaoVien
            // 
            this.accQuanLyGiaoVien.Name = "accQuanLyGiaoVien";
            this.accQuanLyGiaoVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyGiaoVien.Text = "Quản lý giáo viên";
            this.accQuanLyGiaoVien.Click += new System.EventHandler(this.accQuanLyGiaoVien_Click);
            // 
            // accQuanLyHocSinh
            // 
            this.accQuanLyHocSinh.Name = "accQuanLyHocSinh";
            this.accQuanLyHocSinh.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accQuanLyHocSinh.Text = "Quản lý học sinh";
            this.accQuanLyHocSinh.Click += new System.EventHandler(this.accQuanLyHocSinh_Click);
            // 
            // accTongQuan
            // 
            this.accTongQuan.Name = "accTongQuan";
            this.accTongQuan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accTongQuan.Text = "Tổng quan";
            this.accTongQuan.Click += new System.EventHandler(this.accTongQuan_Click);
            // 
            // accMenu
            // 
            this.accMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.accMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accTongQuan,
            this.accQuanLyHocSinh,
            this.accQuanLyLichDay,
            this.accQuanLyGiaoVien,
            this.accNhapDiemHocSinh,
            this.accThongKeBaoCao,
            this.accQuanLyTaiKhoan,
            this.accThongBao,
            this.accHuongDanSuDung,
            this.accGioiThieu});
            this.accMenu.Location = new System.Drawing.Point(0, 53);
            this.accMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accMenu.Name = "accMenu";
            this.accMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accMenu.Size = new System.Drawing.Size(206, 517);
            this.accMenu.TabIndex = 0;
            this.accMenu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // myProfile
            // 
            this.myProfile.Caption = "Hồ sơ của tôi";
            this.myProfile.Id = 0;
            this.myProfile.Name = "myProfile";
            // 
            // changePassword
            // 
            this.changePassword.Caption = "Đổi mật khẩu";
            this.changePassword.Id = 1;
            this.changePassword.Name = "changePassword";
            // 
            // signOut
            // 
            this.signOut.Caption = "Đăng xuất";
            this.signOut.Id = 2;
            this.signOut.Name = "signOut";
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager2;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(962, 33);
            this.toolbarFormControl1.TabIndex = 5;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.profile),
            new DevExpress.XtraBars.LinkPersistInfo(this.changePass),
            new DevExpress.XtraBars.LinkPersistInfo(this.logOut)});
            this.popupMenu1.Manager = this.toolbarFormManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 570);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.accMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.Name = "frmMain";
            this.Text = "Quản lý lớp học";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panel_control)).EndInit();
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupOwnControl)).EndInit();
            this.popupOwnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panel_control;
        private DevExpress.XtraEditors.PanelControl panelBody;
        private DevExpress.XtraEditors.LabelControl lbTestTrangThai;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accGioiThieu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accHuongDanSuDung;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accThongBao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyTaiKhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accThongKeBaoCao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accNhapDiemHocSinh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyLichDay;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyGiaoVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accQuanLyHocSinh;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accTongQuan;
        private DevExpress.XtraBars.Navigation.AccordionControl accMenu;
        private DevExpress.XtraEditors.LabelControl btnThongBao;
        private DevExpress.XtraBars.BarButtonItem myProfile;
        private DevExpress.XtraBars.BarButtonItem changePassword;
        private DevExpress.XtraBars.BarButtonItem signOut;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem profile;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem changePass;
        private DevExpress.XtraBars.BarButtonItem logOut;
        private DevExpress.XtraEditors.LabelControl ownControl;
        private DevExpress.XtraBars.PopupControlContainer popupOwnControl;
        private DevExpress.XtraEditors.SimpleButton changeMyPassword;
        private DevExpress.XtraEditors.SimpleButton ownProfile;
        public DevExpress.XtraEditors.SimpleButton log_out;
        private DevExpress.XtraEditors.SimpleButton ownCtrl;
    }
}

