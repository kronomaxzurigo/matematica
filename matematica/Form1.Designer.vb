<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_operazione = New System.Windows.Forms.Label()
        Me.Lbl_num1 = New System.Windows.Forms.Label()
        Me.Lbl_num2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_risultato = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Opt_moltiplicazione = New System.Windows.Forms.RadioButton()
        Me.Opt_divisione = New System.Windows.Forms.RadioButton()
        Me.Opt_sottrazione = New System.Windows.Forms.RadioButton()
        Me.Opt_somma = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Opt_10000 = New System.Windows.Forms.RadioButton()
        Me.Opt_1000 = New System.Windows.Forms.RadioButton()
        Me.Opt_100 = New System.Windows.Forms.RadioButton()
        Me.Opt_50 = New System.Windows.Forms.RadioButton()
        Me.Opt_10 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmd_help = New System.Windows.Forms.Button()
        Me.Cmd_ok = New System.Windows.Forms.Button()
        Me.Cmd_nuovo = New System.Windows.Forms.Button()
        Me.Txt_ultimo = New System.Windows.Forms.Label()
        Me.Grd_operazioni = New System.Windows.Forms.DataGridView()
        Me.Ora_ins = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Risultato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Pic_help = New System.Windows.Forms.PictureBox()
        Me.Pic_attesa = New System.Windows.Forms.PictureBox()
        Me.Pic_no = New System.Windows.Forms.PictureBox()
        Me.Pic_ok = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbl_ok = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Lbl_no = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Lbl_help = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Lista_img = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grd_operazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Pic_help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_attesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.03352!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.96648!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 393.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_operazione, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_num1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_num2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_risultato, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_ultimo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Grd_operazioni, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 3, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(843, 611)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Lbl_operazione
        '
        Me.Lbl_operazione.AutoSize = True
        Me.Lbl_operazione.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_operazione.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_operazione.Location = New System.Drawing.Point(292, 0)
        Me.Lbl_operazione.Name = "Lbl_operazione"
        Me.Lbl_operazione.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_operazione.Size = New System.Drawing.Size(41, 68)
        Me.Lbl_operazione.TabIndex = 3
        Me.Lbl_operazione.Text = "+"
        Me.Lbl_operazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_num1
        '
        Me.Lbl_num1.AutoSize = True
        Me.Lbl_num1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_num1.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_num1.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_num1.Name = "Lbl_num1"
        Me.Lbl_num1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_num1.Size = New System.Drawing.Size(283, 68)
        Me.Lbl_num1.TabIndex = 1
        Me.Lbl_num1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_num2
        '
        Me.Lbl_num2.AutoSize = True
        Me.Lbl_num2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl_num2.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_num2.Location = New System.Drawing.Point(3, 68)
        Me.Lbl_num2.Name = "Lbl_num2"
        Me.Lbl_num2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_num2.Size = New System.Drawing.Size(283, 68)
        Me.Lbl_num2.TabIndex = 2
        Me.Lbl_num2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(292, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(41, 68)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_risultato
        '
        Me.Txt_risultato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt_risultato.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_risultato.Location = New System.Drawing.Point(3, 139)
        Me.Txt_risultato.Name = "Txt_risultato"
        Me.Txt_risultato.Size = New System.Drawing.Size(283, 44)
        Me.Txt_risultato.TabIndex = 6
        Me.Txt_risultato.Text = "0"
        Me.Txt_risultato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 344)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 165)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Opt_moltiplicazione)
        Me.GroupBox2.Controls.Add(Me.Opt_divisione)
        Me.GroupBox2.Controls.Add(Me.Opt_sottrazione)
        Me.GroupBox2.Controls.Add(Me.Opt_somma)
        Me.GroupBox2.Location = New System.Drawing.Point(104, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(50, 150)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Opt_moltiplicazione
        '
        Me.Opt_moltiplicazione.AutoSize = True
        Me.Opt_moltiplicazione.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_moltiplicazione.Location = New System.Drawing.Point(6, 90)
        Me.Opt_moltiplicazione.Name = "Opt_moltiplicazione"
        Me.Opt_moltiplicazione.Size = New System.Drawing.Size(35, 25)
        Me.Opt_moltiplicazione.TabIndex = 3
        Me.Opt_moltiplicazione.Text = "*"
        Me.Opt_moltiplicazione.UseVisualStyleBackColor = True
        '
        'Opt_divisione
        '
        Me.Opt_divisione.AutoSize = True
        Me.Opt_divisione.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_divisione.Location = New System.Drawing.Point(6, 65)
        Me.Opt_divisione.Name = "Opt_divisione"
        Me.Opt_divisione.Size = New System.Drawing.Size(35, 25)
        Me.Opt_divisione.TabIndex = 2
        Me.Opt_divisione.Text = "/"
        Me.Opt_divisione.UseVisualStyleBackColor = True
        '
        'Opt_sottrazione
        '
        Me.Opt_sottrazione.AutoSize = True
        Me.Opt_sottrazione.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_sottrazione.Location = New System.Drawing.Point(7, 40)
        Me.Opt_sottrazione.Name = "Opt_sottrazione"
        Me.Opt_sottrazione.Size = New System.Drawing.Size(34, 25)
        Me.Opt_sottrazione.TabIndex = 1
        Me.Opt_sottrazione.Text = "-"
        Me.Opt_sottrazione.UseVisualStyleBackColor = True
        '
        'Opt_somma
        '
        Me.Opt_somma.AutoSize = True
        Me.Opt_somma.Checked = True
        Me.Opt_somma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_somma.Location = New System.Drawing.Point(7, 15)
        Me.Opt_somma.Name = "Opt_somma"
        Me.Opt_somma.Size = New System.Drawing.Size(39, 25)
        Me.Opt_somma.TabIndex = 0
        Me.Opt_somma.TabStop = True
        Me.Opt_somma.Text = "+"
        Me.Opt_somma.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Opt_10000)
        Me.GroupBox1.Controls.Add(Me.Opt_1000)
        Me.GroupBox1.Controls.Add(Me.Opt_100)
        Me.GroupBox1.Controls.Add(Me.Opt_50)
        Me.GroupBox1.Controls.Add(Me.Opt_10)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 150)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Opt_10000
        '
        Me.Opt_10000.AutoSize = True
        Me.Opt_10000.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_10000.Location = New System.Drawing.Point(6, 115)
        Me.Opt_10000.Name = "Opt_10000"
        Me.Opt_10000.Size = New System.Drawing.Size(77, 25)
        Me.Opt_10000.TabIndex = 4
        Me.Opt_10000.Text = "10.000"
        Me.Opt_10000.UseVisualStyleBackColor = True
        '
        'Opt_1000
        '
        Me.Opt_1000.AutoSize = True
        Me.Opt_1000.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_1000.Location = New System.Drawing.Point(6, 90)
        Me.Opt_1000.Name = "Opt_1000"
        Me.Opt_1000.Size = New System.Drawing.Size(68, 25)
        Me.Opt_1000.TabIndex = 3
        Me.Opt_1000.Text = "1.000"
        Me.Opt_1000.UseVisualStyleBackColor = True
        '
        'Opt_100
        '
        Me.Opt_100.AutoSize = True
        Me.Opt_100.Checked = True
        Me.Opt_100.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_100.Location = New System.Drawing.Point(6, 65)
        Me.Opt_100.Name = "Opt_100"
        Me.Opt_100.Size = New System.Drawing.Size(55, 25)
        Me.Opt_100.TabIndex = 2
        Me.Opt_100.TabStop = True
        Me.Opt_100.Text = "100"
        Me.Opt_100.UseVisualStyleBackColor = True
        '
        'Opt_50
        '
        Me.Opt_50.AutoSize = True
        Me.Opt_50.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_50.Location = New System.Drawing.Point(7, 40)
        Me.Opt_50.Name = "Opt_50"
        Me.Opt_50.Size = New System.Drawing.Size(46, 25)
        Me.Opt_50.TabIndex = 1
        Me.Opt_50.Text = "50"
        Me.Opt_50.UseVisualStyleBackColor = True
        '
        'Opt_10
        '
        Me.Opt_10.AutoSize = True
        Me.Opt_10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Opt_10.Location = New System.Drawing.Point(7, 15)
        Me.Opt_10.Name = "Opt_10"
        Me.Opt_10.Size = New System.Drawing.Size(46, 25)
        Me.Opt_10.TabIndex = 0
        Me.Opt_10.Text = "10"
        Me.Opt_10.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Cmd_help)
        Me.Panel2.Controls.Add(Me.Cmd_ok)
        Me.Panel2.Controls.Add(Me.Cmd_nuovo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 61)
        Me.Panel2.TabIndex = 5
        '
        'Cmd_help
        '
        Me.Cmd_help.Image = CType(resources.GetObject("Cmd_help.Image"), System.Drawing.Image)
        Me.Cmd_help.Location = New System.Drawing.Point(109, 0)
        Me.Cmd_help.Name = "Cmd_help"
        Me.Cmd_help.Size = New System.Drawing.Size(75, 61)
        Me.Cmd_help.TabIndex = 2
        Me.Cmd_help.Text = "."
        Me.Cmd_help.UseVisualStyleBackColor = True
        '
        'Cmd_ok
        '
        Me.Cmd_ok.Image = CType(resources.GetObject("Cmd_ok.Image"), System.Drawing.Image)
        Me.Cmd_ok.Location = New System.Drawing.Point(205, 0)
        Me.Cmd_ok.Name = "Cmd_ok"
        Me.Cmd_ok.Size = New System.Drawing.Size(75, 61)
        Me.Cmd_ok.TabIndex = 1
        Me.Cmd_ok.Text = "."
        Me.Cmd_ok.UseVisualStyleBackColor = True
        '
        'Cmd_nuovo
        '
        Me.Cmd_nuovo.Image = CType(resources.GetObject("Cmd_nuovo.Image"), System.Drawing.Image)
        Me.Cmd_nuovo.Location = New System.Drawing.Point(12, 0)
        Me.Cmd_nuovo.Name = "Cmd_nuovo"
        Me.Cmd_nuovo.Size = New System.Drawing.Size(75, 61)
        Me.Cmd_nuovo.TabIndex = 0
        Me.Cmd_nuovo.Text = "."
        Me.Cmd_nuovo.UseVisualStyleBackColor = True
        '
        'Txt_ultimo
        '
        Me.Txt_ultimo.AutoSize = True
        Me.Txt_ultimo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt_ultimo.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_ultimo.Location = New System.Drawing.Point(3, 208)
        Me.Txt_ultimo.Name = "Txt_ultimo"
        Me.Txt_ultimo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ultimo.Size = New System.Drawing.Size(283, 66)
        Me.Txt_ultimo.TabIndex = 7
        Me.Txt_ultimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Grd_operazioni
        '
        Me.Grd_operazioni.AllowUserToAddRows = False
        Me.Grd_operazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grd_operazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grd_operazioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ora_ins, Me.Operazione, Me.Risultato, Me.Stato})
        Me.Grd_operazioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grd_operazioni.Location = New System.Drawing.Point(339, 3)
        Me.Grd_operazioni.Name = "Grd_operazioni"
        Me.TableLayoutPanel1.SetRowSpan(Me.Grd_operazioni, 6)
        Me.Grd_operazioni.RowTemplate.Height = 25
        Me.Grd_operazioni.Size = New System.Drawing.Size(387, 510)
        Me.Grd_operazioni.TabIndex = 8
        '
        'Ora_ins
        '
        Me.Ora_ins.HeaderText = "Ora"
        Me.Ora_ins.Name = "Ora_ins"
        Me.Ora_ins.Width = 51
        '
        'Operazione
        '
        Me.Operazione.HeaderText = "Operazione"
        Me.Operazione.Name = "Operazione"
        Me.Operazione.Width = 92
        '
        'Risultato
        '
        Me.Risultato.HeaderText = "Risultato"
        Me.Risultato.Name = "Risultato"
        Me.Risultato.Width = 78
        '
        'Stato
        '
        Me.Stato.HeaderText = "Stato"
        Me.Stato.Name = "Stato"
        Me.Stato.Width = 59
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Pic_help)
        Me.Panel3.Controls.Add(Me.Pic_attesa)
        Me.Panel3.Controls.Add(Me.Pic_no)
        Me.Panel3.Controls.Add(Me.Pic_ok)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 519)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(283, 89)
        Me.Panel3.TabIndex = 9
        '
        'Pic_help
        '
        Me.Pic_help.Image = CType(resources.GetObject("Pic_help.Image"), System.Drawing.Image)
        Me.Pic_help.Location = New System.Drawing.Point(104, 39)
        Me.Pic_help.Name = "Pic_help"
        Me.Pic_help.Size = New System.Drawing.Size(100, 50)
        Me.Pic_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_help.TabIndex = 3
        Me.Pic_help.TabStop = False
        Me.Pic_help.Visible = False
        '
        'Pic_attesa
        '
        Me.Pic_attesa.Image = CType(resources.GetObject("Pic_attesa.Image"), System.Drawing.Image)
        Me.Pic_attesa.Location = New System.Drawing.Point(0, 39)
        Me.Pic_attesa.Name = "Pic_attesa"
        Me.Pic_attesa.Size = New System.Drawing.Size(100, 50)
        Me.Pic_attesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_attesa.TabIndex = 2
        Me.Pic_attesa.TabStop = False
        Me.Pic_attesa.Visible = False
        '
        'Pic_no
        '
        Me.Pic_no.Image = CType(resources.GetObject("Pic_no.Image"), System.Drawing.Image)
        Me.Pic_no.Location = New System.Drawing.Point(104, 0)
        Me.Pic_no.Name = "Pic_no"
        Me.Pic_no.Size = New System.Drawing.Size(100, 50)
        Me.Pic_no.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_no.TabIndex = 1
        Me.Pic_no.TabStop = False
        Me.Pic_no.Visible = False
        '
        'Pic_ok
        '
        Me.Pic_ok.Image = CType(resources.GetObject("Pic_ok.Image"), System.Drawing.Image)
        Me.Pic_ok.Location = New System.Drawing.Point(0, 0)
        Me.Pic_ok.Name = "Pic_ok"
        Me.Pic_ok.Size = New System.Drawing.Size(100, 50)
        Me.Pic_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_ok.TabIndex = 0
        Me.Pic_ok.TabStop = False
        Me.Pic_ok.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Lbl_ok)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(732, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(107, 62)
        Me.Panel4.TabIndex = 10
        '
        'Lbl_ok
        '
        Me.Lbl_ok.AutoSize = True
        Me.Lbl_ok.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_ok.Location = New System.Drawing.Point(74, 22)
        Me.Lbl_ok.Name = "Lbl_ok"
        Me.Lbl_ok.Size = New System.Drawing.Size(19, 21)
        Me.Lbl_ok.TabIndex = 2
        Me.Lbl_ok.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Lbl_no)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Location = New System.Drawing.Point(732, 71)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(107, 62)
        Me.Panel5.TabIndex = 11
        '
        'Lbl_no
        '
        Me.Lbl_no.AutoSize = True
        Me.Lbl_no.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_no.Location = New System.Drawing.Point(74, 22)
        Me.Lbl_no.Name = "Lbl_no"
        Me.Lbl_no.Size = New System.Drawing.Size(19, 21)
        Me.Lbl_no.TabIndex = 3
        Me.Lbl_no.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Lbl_help)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Location = New System.Drawing.Point(732, 139)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(107, 66)
        Me.Panel6.TabIndex = 12
        '
        'Lbl_help
        '
        Me.Lbl_help.AutoSize = True
        Me.Lbl_help.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_help.Location = New System.Drawing.Point(74, 21)
        Me.Lbl_help.Name = "Lbl_help"
        Me.Lbl_help.Size = New System.Drawing.Size(19, 21)
        Me.Lbl_help.TabIndex = 5
        Me.Lbl_help.Text = "0"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Lista_img
        '
        Me.Lista_img.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.Lista_img.ImageSize = New System.Drawing.Size(16, 16)
        Me.Lista_img.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 635)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Matematica"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grd_operazioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Pic_help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_attesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Opt_1000 As RadioButton
    Friend WithEvents Opt_100 As RadioButton
    Friend WithEvents Opt_50 As RadioButton
    Friend WithEvents Opt_10 As RadioButton
    Friend WithEvents Lbl_operazione As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Opt_moltiplicazione As RadioButton
    Friend WithEvents Opt_divisione As RadioButton
    Friend WithEvents Opt_sottrazione As RadioButton
    Friend WithEvents Opt_somma As RadioButton
    Friend WithEvents Opt_10000 As RadioButton
    Friend WithEvents Lbl_num1 As Label
    Friend WithEvents Lbl_num2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cmd_nuovo As Button
    Friend WithEvents Cmd_ok As Button
    Friend WithEvents Txt_risultato As TextBox
    Friend WithEvents Txt_ultimo As Label
    Friend WithEvents Grd_operazioni As DataGridView
    Friend WithEvents Ora_ins As DataGridViewTextBoxColumn
    Friend WithEvents Operazione As DataGridViewTextBoxColumn
    Friend WithEvents Risultato As DataGridViewTextBoxColumn
    Friend WithEvents Stato As DataGridViewTextBoxColumn
    Friend WithEvents Lista_img As ImageList
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Pic_no As PictureBox
    Friend WithEvents Pic_ok As PictureBox
    Friend WithEvents Pic_attesa As PictureBox
    Friend WithEvents Cmd_help As Button
    Friend WithEvents Pic_help As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lbl_ok As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Lbl_no As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Lbl_help As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
