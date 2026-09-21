namespace ApiNaruto.WinForms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtNombre = new TextBox();
        txtTipoChakra = new TextBox();
        txtAldea = new TextBox();
        txtClan = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        btnGuardar = new Button();
        btnActualizar = new Button();
        dvgPersonajes = new DataGridView();
        lblEstado = new Label();
        ((System.ComponentModel.ISupportInitialize)dvgPersonajes).BeginInit();
        SuspendLayout();
        // 
        // txtNombre
        // 
        txtNombre.AcceptsReturn = true;
        txtNombre.Location = new Point(64, 40);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(100, 23);
        txtNombre.TabIndex = 4;
        // 
        // txtTipoChakra
        // 
        txtTipoChakra.Location = new Point(64, 246);
        txtTipoChakra.Name = "txtTipoChakra";
        txtTipoChakra.Size = new Size(100, 23);
        txtTipoChakra.TabIndex = 5;
        // 
        // txtAldea
        // 
        txtAldea.Location = new Point(64, 169);
        txtAldea.Name = "txtAldea";
        txtAldea.Size = new Size(100, 23);
        txtAldea.TabIndex = 6;
        // 
        // txtClan
        // 
        txtClan.Location = new Point(64, 103);
        txtClan.Name = "txtClan";
        txtClan.Size = new Size(100, 23);
        txtClan.TabIndex = 7;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(64, 9);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 8;
        label1.Text = "Nombre";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(64, 76);
        label2.Name = "label2";
        label2.Size = new Size(31, 15);
        label2.TabIndex = 9;
        label2.Text = "Clan";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(64, 141);
        label3.Name = "label3";
        label3.Size = new Size(37, 15);
        label3.TabIndex = 10;
        label3.Text = "Aldea";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(64, 212);
        label4.Name = "label4";
        label4.Size = new Size(85, 15);
        label4.TabIndex = 11;
        label4.Text = "TIpo de chakra";
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(53, 305);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(75, 23);
        btnGuardar.TabIndex = 12;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new Point(153, 305);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(75, 23);
        btnActualizar.TabIndex = 13;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = true;
        btnActualizar.Click += btnActualizar_Click;
        // 
        // dvgPersonajes
        // 
        dvgPersonajes.AllowUserToAddRows = false;
        dvgPersonajes.AllowUserToDeleteRows = false;
        dvgPersonajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dvgPersonajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dvgPersonajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dvgPersonajes.Location = new Point(321, 40);
        dvgPersonajes.Name = "dvgPersonajes";
        dvgPersonajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dvgPersonajes.Size = new Size(359, 209);
        dvgPersonajes.TabIndex = 14;
        // 
        // lblEstado
        // 
        lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblEstado.AutoSize = true;
        lblEstado.Location = new Point(258, 313);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(32, 15);
        lblEstado.TabIndex = 15;
        lblEstado.Text = "Listo";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblEstado);
        Controls.Add(dvgPersonajes);
        Controls.Add(btnActualizar);
        Controls.Add(btnGuardar);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtClan);
        Controls.Add(txtAldea);
        Controls.Add(txtTipoChakra);
        Controls.Add(txtNombre);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Personajes de Naruto ";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dvgPersonajes).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion
    private TextBox txtNombre;
    private TextBox txtTipoChakra;
    private TextBox txtAldea;
    private TextBox txtClan;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button btnGuardar;
    private Button btnActualizar;
    private DataGridView dvgPersonajes;
    private Label lblEstado;
}
