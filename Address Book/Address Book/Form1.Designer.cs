namespace Address_Book
{
    partial class addressBookForm
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
            this.tcAddressBook = new System.Windows.Forms.TabControl();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddInsta = new System.Windows.Forms.TextBox();
            this.dtpAddBD = new System.Windows.Forms.DateTimePicker();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNum = new System.Windows.Forms.TextBox();
            this.txtAddLName = new System.Windows.Forms.TextBox();
            this.txtAddFName = new System.Windows.Forms.TextBox();
            this.lblAddInsta = new System.Windows.Forms.Label();
            this.lblAddBirthday = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddPhoneNum = new System.Windows.Forms.Label();
            this.lblAddLName = new System.Windows.Forms.Label();
            this.lblAddFName = new System.Windows.Forms.Label();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.txtSearchInsta = new System.Windows.Forms.TextBox();
            this.dtpShowBD = new System.Windows.Forms.DateTimePicker();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.txtSearchPhoneNum = new System.Windows.Forms.TextBox();
            this.lblSearchInsta = new System.Windows.Forms.Label();
            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.lblSearchPhoneNum = new System.Windows.Forms.Label();
            this.btnShowBirthday = new System.Windows.Forms.Button();
            this.btnShowContact = new System.Windows.Forms.Button();
            this.txtSearchLName = new System.Windows.Forms.TextBox();
            this.txtSearchFName = new System.Windows.Forms.TextBox();
            this.lblSearchLName = new System.Windows.Forms.Label();
            this.lblSearchFName = new System.Windows.Forms.Label();
            this.tpTodayBD = new System.Windows.Forms.TabPage();
            this.lbTodayBD = new System.Windows.Forms.ListBox();
            this.btnShowTodayBD = new System.Windows.Forms.Button();
            this.tpEditDelete = new System.Windows.Forms.TabPage();
            this.dtpEditBD = new System.Windows.Forms.DateTimePicker();
            this.lblEditBD = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEditInfo = new System.Windows.Forms.Label();
            this.txtEditInsta = new System.Windows.Forms.TextBox();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditPhoneNum = new System.Windows.Forms.TextBox();
            this.lblEditInsta = new System.Windows.Forms.Label();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.lblEditPhoneNum = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtEditDelLName = new System.Windows.Forms.TextBox();
            this.txtEditDelFName = new System.Windows.Forms.TextBox();
            this.lblEditDelLName = new System.Windows.Forms.Label();
            this.lblEditDelFName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.tcAddressBook.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.tpTodayBD.SuspendLayout();
            this.tpEditDelete.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAddressBook
            // 
            this.tcAddressBook.Controls.Add(this.tpAdd);
            this.tcAddressBook.Controls.Add(this.tpSearch);
            this.tcAddressBook.Controls.Add(this.tpTodayBD);
            this.tcAddressBook.Controls.Add(this.tpEditDelete);
            this.tcAddressBook.Location = new System.Drawing.Point(0, 43);
            this.tcAddressBook.Name = "tcAddressBook";
            this.tcAddressBook.SelectedIndex = 0;
            this.tcAddressBook.Size = new System.Drawing.Size(898, 487);
            this.tcAddressBook.TabIndex = 0;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.btnAdd);
            this.tpAdd.Controls.Add(this.txtAddInsta);
            this.tpAdd.Controls.Add(this.dtpAddBD);
            this.tpAdd.Controls.Add(this.txtAddEmail);
            this.tpAdd.Controls.Add(this.txtAddPhoneNum);
            this.tpAdd.Controls.Add(this.txtAddLName);
            this.tpAdd.Controls.Add(this.txtAddFName);
            this.tpAdd.Controls.Add(this.lblAddInsta);
            this.tpAdd.Controls.Add(this.lblAddBirthday);
            this.tpAdd.Controls.Add(this.lblAddEmail);
            this.tpAdd.Controls.Add(this.lblAddPhoneNum);
            this.tpAdd.Controls.Add(this.lblAddLName);
            this.tpAdd.Controls.Add(this.lblAddFName);
            this.tpAdd.Location = new System.Drawing.Point(4, 34);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(890, 449);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(356, 43);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddInsta
            // 
            this.txtAddInsta.Location = new System.Drawing.Point(330, 305);
            this.txtAddInsta.Name = "txtAddInsta";
            this.txtAddInsta.Size = new System.Drawing.Size(356, 31);
            this.txtAddInsta.TabIndex = 11;
            // 
            // dtpAddBD
            // 
            this.dtpAddBD.Location = new System.Drawing.Point(330, 244);
            this.dtpAddBD.Name = "dtpAddBD";
            this.dtpAddBD.Size = new System.Drawing.Size(356, 31);
            this.dtpAddBD.TabIndex = 10;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(330, 183);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(356, 31);
            this.txtAddEmail.TabIndex = 9;
            // 
            // txtAddPhoneNum
            // 
            this.txtAddPhoneNum.Location = new System.Drawing.Point(330, 128);
            this.txtAddPhoneNum.Name = "txtAddPhoneNum";
            this.txtAddPhoneNum.Size = new System.Drawing.Size(356, 31);
            this.txtAddPhoneNum.TabIndex = 8;
            // 
            // txtAddLName
            // 
            this.txtAddLName.Location = new System.Drawing.Point(330, 77);
            this.txtAddLName.Name = "txtAddLName";
            this.txtAddLName.Size = new System.Drawing.Size(356, 31);
            this.txtAddLName.TabIndex = 7;
            // 
            // txtAddFName
            // 
            this.txtAddFName.Location = new System.Drawing.Point(330, 24);
            this.txtAddFName.Name = "txtAddFName";
            this.txtAddFName.Size = new System.Drawing.Size(356, 31);
            this.txtAddFName.TabIndex = 6;
            // 
            // lblAddInsta
            // 
            this.lblAddInsta.AutoSize = true;
            this.lblAddInsta.Location = new System.Drawing.Point(113, 308);
            this.lblAddInsta.Name = "lblAddInsta";
            this.lblAddInsta.Size = new System.Drawing.Size(180, 25);
            this.lblAddInsta.TabIndex = 5;
            this.lblAddInsta.Text = "Instagram Handle";
            // 
            // lblAddBirthday
            // 
            this.lblAddBirthday.AutoSize = true;
            this.lblAddBirthday.Location = new System.Drawing.Point(202, 249);
            this.lblAddBirthday.Name = "lblAddBirthday";
            this.lblAddBirthday.Size = new System.Drawing.Size(91, 25);
            this.lblAddBirthday.TabIndex = 4;
            this.lblAddBirthday.Text = "Birthday";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(143, 186);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(150, 25);
            this.lblAddEmail.TabIndex = 3;
            this.lblAddEmail.Text = "Email Address";
            // 
            // lblAddPhoneNum
            // 
            this.lblAddPhoneNum.AutoSize = true;
            this.lblAddPhoneNum.Location = new System.Drawing.Point(138, 131);
            this.lblAddPhoneNum.Name = "lblAddPhoneNum";
            this.lblAddPhoneNum.Size = new System.Drawing.Size(155, 25);
            this.lblAddPhoneNum.TabIndex = 2;
            this.lblAddPhoneNum.Text = "Phone Number";
            // 
            // lblAddLName
            // 
            this.lblAddLName.AutoSize = true;
            this.lblAddLName.Location = new System.Drawing.Point(178, 80);
            this.lblAddLName.Name = "lblAddLName";
            this.lblAddLName.Size = new System.Drawing.Size(115, 25);
            this.lblAddLName.TabIndex = 1;
            this.lblAddLName.Text = "Last Name";
            // 
            // lblAddFName
            // 
            this.lblAddFName.AutoSize = true;
            this.lblAddFName.Location = new System.Drawing.Point(177, 27);
            this.lblAddFName.Name = "lblAddFName";
            this.lblAddFName.Size = new System.Drawing.Size(116, 25);
            this.lblAddFName.TabIndex = 0;
            this.lblAddFName.Text = "First Name";
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.lblTip);
            this.tpSearch.Controls.Add(this.btnSearchClear);
            this.tpSearch.Controls.Add(this.txtSearchInsta);
            this.tpSearch.Controls.Add(this.dtpShowBD);
            this.tpSearch.Controls.Add(this.txtSearchEmail);
            this.tpSearch.Controls.Add(this.txtSearchPhoneNum);
            this.tpSearch.Controls.Add(this.lblSearchInsta);
            this.tpSearch.Controls.Add(this.lblSearchEmail);
            this.tpSearch.Controls.Add(this.lblSearchPhoneNum);
            this.tpSearch.Controls.Add(this.btnShowBirthday);
            this.tpSearch.Controls.Add(this.btnShowContact);
            this.tpSearch.Controls.Add(this.txtSearchLName);
            this.tpSearch.Controls.Add(this.txtSearchFName);
            this.tpSearch.Controls.Add(this.lblSearchLName);
            this.tpSearch.Controls.Add(this.lblSearchFName);
            this.tpSearch.Location = new System.Drawing.Point(4, 34);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(890, 449);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Text = "Search";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchInsta
            // 
            this.txtSearchInsta.Location = new System.Drawing.Point(228, 340);
            this.txtSearchInsta.Name = "txtSearchInsta";
            this.txtSearchInsta.ReadOnly = true;
            this.txtSearchInsta.Size = new System.Drawing.Size(158, 31);
            this.txtSearchInsta.TabIndex = 18;
            this.txtSearchInsta.TabStop = false;
            // 
            // dtpShowBD
            // 
            this.dtpShowBD.Enabled = false;
            this.dtpShowBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShowBD.Location = new System.Drawing.Point(410, 228);
            this.dtpShowBD.Name = "dtpShowBD";
            this.dtpShowBD.Size = new System.Drawing.Size(466, 24);
            this.dtpShowBD.TabIndex = 20;
            this.dtpShowBD.TabStop = false;
            this.dtpShowBD.Visible = false;
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(227, 289);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.ReadOnly = true;
            this.txtSearchEmail.Size = new System.Drawing.Size(158, 31);
            this.txtSearchEmail.TabIndex = 16;
            this.txtSearchEmail.TabStop = false;
            // 
            // txtSearchPhoneNum
            // 
            this.txtSearchPhoneNum.Location = new System.Drawing.Point(227, 237);
            this.txtSearchPhoneNum.Name = "txtSearchPhoneNum";
            this.txtSearchPhoneNum.ReadOnly = true;
            this.txtSearchPhoneNum.Size = new System.Drawing.Size(158, 31);
            this.txtSearchPhoneNum.TabIndex = 14;
            this.txtSearchPhoneNum.TabStop = false;
            // 
            // lblSearchInsta
            // 
            this.lblSearchInsta.AutoSize = true;
            this.lblSearchInsta.Location = new System.Drawing.Point(35, 343);
            this.lblSearchInsta.Name = "lblSearchInsta";
            this.lblSearchInsta.Size = new System.Drawing.Size(180, 25);
            this.lblSearchInsta.TabIndex = 17;
            this.lblSearchInsta.Text = "Instagram Handle";
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.AutoSize = true;
            this.lblSearchEmail.Location = new System.Drawing.Point(35, 295);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(150, 25);
            this.lblSearchEmail.TabIndex = 15;
            this.lblSearchEmail.Text = "Email Address";
            // 
            // lblSearchPhoneNum
            // 
            this.lblSearchPhoneNum.AutoSize = true;
            this.lblSearchPhoneNum.Location = new System.Drawing.Point(35, 240);
            this.lblSearchPhoneNum.Name = "lblSearchPhoneNum";
            this.lblSearchPhoneNum.Size = new System.Drawing.Size(155, 25);
            this.lblSearchPhoneNum.TabIndex = 13;
            this.lblSearchPhoneNum.Text = "Phone Number";
            // 
            // btnShowBirthday
            // 
            this.btnShowBirthday.Location = new System.Drawing.Point(533, 160);
            this.btnShowBirthday.Name = "btnShowBirthday";
            this.btnShowBirthday.Size = new System.Drawing.Size(237, 57);
            this.btnShowBirthday.TabIndex = 19;
            this.btnShowBirthday.Text = "Show Birthday";
            this.btnShowBirthday.UseVisualStyleBackColor = true;
            this.btnShowBirthday.Click += new System.EventHandler(this.btnShowBirthday_Click);
            // 
            // btnShowContact
            // 
            this.btnShowContact.Location = new System.Drawing.Point(29, 160);
            this.btnShowContact.Name = "btnShowContact";
            this.btnShowContact.Size = new System.Drawing.Size(357, 57);
            this.btnShowContact.TabIndex = 12;
            this.btnShowContact.Text = "Show Contact Info";
            this.btnShowContact.UseVisualStyleBackColor = true;
            this.btnShowContact.Click += new System.EventHandler(this.btnShowContact_Click);
            // 
            // txtSearchLName
            // 
            this.txtSearchLName.Location = new System.Drawing.Point(375, 82);
            this.txtSearchLName.Name = "txtSearchLName";
            this.txtSearchLName.Size = new System.Drawing.Size(228, 31);
            this.txtSearchLName.TabIndex = 11;
            // 
            // txtSearchFName
            // 
            this.txtSearchFName.Location = new System.Drawing.Point(375, 29);
            this.txtSearchFName.Name = "txtSearchFName";
            this.txtSearchFName.Size = new System.Drawing.Size(228, 31);
            this.txtSearchFName.TabIndex = 10;
            // 
            // lblSearchLName
            // 
            this.lblSearchLName.AutoSize = true;
            this.lblSearchLName.Location = new System.Drawing.Point(223, 85);
            this.lblSearchLName.Name = "lblSearchLName";
            this.lblSearchLName.Size = new System.Drawing.Size(115, 25);
            this.lblSearchLName.TabIndex = 9;
            this.lblSearchLName.Text = "Last Name";
            // 
            // lblSearchFName
            // 
            this.lblSearchFName.AutoSize = true;
            this.lblSearchFName.Location = new System.Drawing.Point(222, 32);
            this.lblSearchFName.Name = "lblSearchFName";
            this.lblSearchFName.Size = new System.Drawing.Size(116, 25);
            this.lblSearchFName.TabIndex = 8;
            this.lblSearchFName.Text = "First Name";
            // 
            // tpTodayBD
            // 
            this.tpTodayBD.Controls.Add(this.lbTodayBD);
            this.tpTodayBD.Controls.Add(this.btnShowTodayBD);
            this.tpTodayBD.Location = new System.Drawing.Point(4, 34);
            this.tpTodayBD.Name = "tpTodayBD";
            this.tpTodayBD.Size = new System.Drawing.Size(890, 449);
            this.tpTodayBD.TabIndex = 3;
            this.tpTodayBD.Text = "Today\'s Birthdays";
            this.tpTodayBD.UseVisualStyleBackColor = true;
            // 
            // lbTodayBD
            // 
            this.lbTodayBD.FormattingEnabled = true;
            this.lbTodayBD.ItemHeight = 25;
            this.lbTodayBD.Location = new System.Drawing.Point(133, 135);
            this.lbTodayBD.Name = "lbTodayBD";
            this.lbTodayBD.Size = new System.Drawing.Size(615, 279);
            this.lbTodayBD.TabIndex = 1;
            // 
            // btnShowTodayBD
            // 
            this.btnShowTodayBD.Location = new System.Drawing.Point(248, 36);
            this.btnShowTodayBD.Name = "btnShowTodayBD";
            this.btnShowTodayBD.Size = new System.Drawing.Size(415, 54);
            this.btnShowTodayBD.TabIndex = 0;
            this.btnShowTodayBD.Text = "Show Today\'s Birthdays";
            this.btnShowTodayBD.UseVisualStyleBackColor = true;
            this.btnShowTodayBD.Click += new System.EventHandler(this.btnShowTodayBD_Click);
            // 
            // tpEditDelete
            // 
            this.tpEditDelete.Controls.Add(this.dtpEditBD);
            this.tpEditDelete.Controls.Add(this.lblEditBD);
            this.tpEditDelete.Controls.Add(this.btnSave);
            this.tpEditDelete.Controls.Add(this.btnCancel);
            this.tpEditDelete.Controls.Add(this.lblEditInfo);
            this.tpEditDelete.Controls.Add(this.txtEditInsta);
            this.tpEditDelete.Controls.Add(this.txtEditEmail);
            this.tpEditDelete.Controls.Add(this.txtEditPhoneNum);
            this.tpEditDelete.Controls.Add(this.lblEditInsta);
            this.tpEditDelete.Controls.Add(this.lblEditEmail);
            this.tpEditDelete.Controls.Add(this.lblEditPhoneNum);
            this.tpEditDelete.Controls.Add(this.btnDelete);
            this.tpEditDelete.Controls.Add(this.btnEdit);
            this.tpEditDelete.Controls.Add(this.txtEditDelLName);
            this.tpEditDelete.Controls.Add(this.txtEditDelFName);
            this.tpEditDelete.Controls.Add(this.lblEditDelLName);
            this.tpEditDelete.Controls.Add(this.lblEditDelFName);
            this.tpEditDelete.Location = new System.Drawing.Point(4, 34);
            this.tpEditDelete.Name = "tpEditDelete";
            this.tpEditDelete.Size = new System.Drawing.Size(890, 449);
            this.tpEditDelete.TabIndex = 4;
            this.tpEditDelete.Text = "Edit/Delete";
            this.tpEditDelete.UseVisualStyleBackColor = true;
            // 
            // dtpEditBD
            // 
            this.dtpEditBD.Location = new System.Drawing.Point(250, 329);
            this.dtpEditBD.Name = "dtpEditBD";
            this.dtpEditBD.Size = new System.Drawing.Size(356, 31);
            this.dtpEditBD.TabIndex = 27;
            this.dtpEditBD.TabStop = false;
            // 
            // lblEditBD
            // 
            this.lblEditBD.AutoSize = true;
            this.lblEditBD.Location = new System.Drawing.Point(64, 334);
            this.lblEditBD.Name = "lblEditBD";
            this.lblEditBD.Size = new System.Drawing.Size(91, 25);
            this.lblEditBD.TabIndex = 26;
            this.lblEditBD.Text = "Birthday";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(622, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(230, 49);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(622, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(230, 49);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEditInfo
            // 
            this.lblEditInfo.AutoSize = true;
            this.lblEditInfo.Location = new System.Drawing.Point(401, 161);
            this.lblEditInfo.Name = "lblEditInfo";
            this.lblEditInfo.Size = new System.Drawing.Size(90, 25);
            this.lblEditInfo.TabIndex = 21;
            this.lblEditInfo.Text = "Edit Info";
            // 
            // txtEditInsta
            // 
            this.txtEditInsta.Location = new System.Drawing.Point(250, 376);
            this.txtEditInsta.Name = "txtEditInsta";
            this.txtEditInsta.ReadOnly = true;
            this.txtEditInsta.Size = new System.Drawing.Size(356, 31);
            this.txtEditInsta.TabIndex = 29;
            this.txtEditInsta.TabStop = false;
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(250, 272);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.ReadOnly = true;
            this.txtEditEmail.Size = new System.Drawing.Size(356, 31);
            this.txtEditEmail.TabIndex = 25;
            this.txtEditEmail.TabStop = false;
            // 
            // txtEditPhoneNum
            // 
            this.txtEditPhoneNum.Location = new System.Drawing.Point(250, 213);
            this.txtEditPhoneNum.Name = "txtEditPhoneNum";
            this.txtEditPhoneNum.ReadOnly = true;
            this.txtEditPhoneNum.Size = new System.Drawing.Size(356, 31);
            this.txtEditPhoneNum.TabIndex = 23;
            this.txtEditPhoneNum.TabStop = false;
            // 
            // lblEditInsta
            // 
            this.lblEditInsta.AutoSize = true;
            this.lblEditInsta.Location = new System.Drawing.Point(64, 379);
            this.lblEditInsta.Name = "lblEditInsta";
            this.lblEditInsta.Size = new System.Drawing.Size(180, 25);
            this.lblEditInsta.TabIndex = 28;
            this.lblEditInsta.Text = "Instagram Handle";
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Location = new System.Drawing.Point(64, 275);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(150, 25);
            this.lblEditEmail.TabIndex = 24;
            this.lblEditEmail.Text = "Email Address";
            // 
            // lblEditPhoneNum
            // 
            this.lblEditPhoneNum.AutoSize = true;
            this.lblEditPhoneNum.Location = new System.Drawing.Point(64, 213);
            this.lblEditPhoneNum.Name = "lblEditPhoneNum";
            this.lblEditPhoneNum.Size = new System.Drawing.Size(155, 25);
            this.lblEditPhoneNum.TabIndex = 22;
            this.lblEditPhoneNum.Text = "Phone Number";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(698, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 84);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(565, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 84);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtEditDelLName
            // 
            this.txtEditDelLName.Location = new System.Drawing.Point(305, 87);
            this.txtEditDelLName.Name = "txtEditDelLName";
            this.txtEditDelLName.Size = new System.Drawing.Size(228, 31);
            this.txtEditDelLName.TabIndex = 18;
            // 
            // txtEditDelFName
            // 
            this.txtEditDelFName.Location = new System.Drawing.Point(305, 34);
            this.txtEditDelFName.Name = "txtEditDelFName";
            this.txtEditDelFName.Size = new System.Drawing.Size(228, 31);
            this.txtEditDelFName.TabIndex = 16;
            // 
            // lblEditDelLName
            // 
            this.lblEditDelLName.AutoSize = true;
            this.lblEditDelLName.Location = new System.Drawing.Point(153, 90);
            this.lblEditDelLName.Name = "lblEditDelLName";
            this.lblEditDelLName.Size = new System.Drawing.Size(115, 25);
            this.lblEditDelLName.TabIndex = 17;
            this.lblEditDelLName.Text = "Last Name";
            // 
            // lblEditDelFName
            // 
            this.lblEditDelFName.AutoSize = true;
            this.lblEditDelFName.Location = new System.Drawing.Point(152, 37);
            this.lblEditDelFName.Name = "lblEditDelFName";
            this.lblEditDelFName.Size = new System.Drawing.Size(116, 25);
            this.lblEditDelFName.TabIndex = 15;
            this.lblEditDelFName.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSaveText,
            this.menuItemOpenText,
            this.menuItemSaveBinary,
            this.menuItemOpenBinary});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
            // 
            // miSaveText
            // 
            this.miSaveText.Name = "miSaveText";
            this.miSaveText.Size = new System.Drawing.Size(139, 22);
            this.miSaveText.Text = "Save Text";
            this.miSaveText.Click += new System.EventHandler(this.saveTextToolStripMenuItem1_Click);
            // 
            // menuItemOpenText
            // 
            this.menuItemOpenText.Name = "menuItemOpenText";
            this.menuItemOpenText.Size = new System.Drawing.Size(139, 22);
            this.menuItemOpenText.Text = "Open Text";
            this.menuItemOpenText.Click += new System.EventHandler(this.menuItemOpenText_Click);
            // 
            // menuItemSaveBinary
            // 
            this.menuItemSaveBinary.Name = "menuItemSaveBinary";
            this.menuItemSaveBinary.Size = new System.Drawing.Size(139, 22);
            this.menuItemSaveBinary.Text = "Save Binary";
            this.menuItemSaveBinary.Click += new System.EventHandler(this.menuItemSaveBinary_Click);
            // 
            // menuItemOpenBinary
            // 
            this.menuItemOpenBinary.Name = "menuItemOpenBinary";
            this.menuItemOpenBinary.Size = new System.Drawing.Size(139, 22);
            this.menuItemOpenBinary.Text = "Open Binary";
            this.menuItemOpenBinary.Click += new System.EventHandler(this.menuItemOpenBinary_Click);
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Location = new System.Drawing.Point(487, 311);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(341, 57);
            this.btnSearchClear.TabIndex = 21;
            this.btnSearchClear.Text = "Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(155, 420);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(653, 25);
            this.lblTip.TabIndex = 22;
            this.lblTip.Text = "*You can only search a new contact once you clear the old search*";
            // 
            // addressBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 531);
            this.Controls.Add(this.tcAddressBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "addressBookForm";
            this.Text = "Address Book";
            this.tcAddressBook.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.tpTodayBD.ResumeLayout(false);
            this.tpEditDelete.ResumeLayout(false);
            this.tpEditDelete.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcAddressBook;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddInsta;
        private System.Windows.Forms.DateTimePicker dtpAddBD;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPhoneNum;
        private System.Windows.Forms.TextBox txtAddLName;
        private System.Windows.Forms.TextBox txtAddFName;
        private System.Windows.Forms.Label lblAddInsta;
        private System.Windows.Forms.Label lblAddBirthday;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddPhoneNum;
        private System.Windows.Forms.Label lblAddLName;
        private System.Windows.Forms.Label lblAddFName;
        private System.Windows.Forms.TextBox txtSearchInsta;
        private System.Windows.Forms.DateTimePicker dtpShowBD;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.TextBox txtSearchPhoneNum;
        private System.Windows.Forms.Label lblSearchInsta;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.Label lblSearchPhoneNum;
        private System.Windows.Forms.Button btnShowBirthday;
        private System.Windows.Forms.Button btnShowContact;
        private System.Windows.Forms.TextBox txtSearchLName;
        private System.Windows.Forms.TextBox txtSearchFName;
        private System.Windows.Forms.Label lblSearchLName;
        private System.Windows.Forms.Label lblSearchFName;
        private System.Windows.Forms.TabPage tpTodayBD;
        private System.Windows.Forms.Button btnShowTodayBD;
        private System.Windows.Forms.ListBox lbTodayBD;
        private System.Windows.Forms.TabPage tpEditDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEditInfo;
        private System.Windows.Forms.TextBox txtEditInsta;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditPhoneNum;
        private System.Windows.Forms.Label lblEditInsta;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.Label lblEditPhoneNum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtEditDelLName;
        private System.Windows.Forms.TextBox txtEditDelFName;
        private System.Windows.Forms.Label lblEditDelLName;
        private System.Windows.Forms.Label lblEditDelFName;
        private System.Windows.Forms.DateTimePicker dtpEditBD;
        private System.Windows.Forms.Label lblEditBD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem miSaveText;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenText;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveBinary;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenBinary;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Label lblTip;
    }
}

