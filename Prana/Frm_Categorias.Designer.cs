﻿namespace Prana
{
    partial class Frm_Categorias
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
            this.tbp_Principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Dgv_principal = new System.Windows.Forms.DataGridView();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descipcion_ca = new System.Windows.Forms.TextBox();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.tbp_Principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbp_Principal
            // 
            this.tbp_Principal.Controls.Add(this.tabPage1);
            this.tbp_Principal.Controls.Add(this.tabPage2);
            this.tbp_Principal.Location = new System.Drawing.Point(12, 12);
            this.tbp_Principal.Name = "tbp_Principal";
            this.tbp_Principal.SelectedIndex = 0;
            this.tbp_Principal.Size = new System.Drawing.Size(740, 260);
            this.tbp_Principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_principal);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.txt_buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_guardar);
            this.tabPage2.Controls.Add(this.Btn_cancelar);
            this.tabPage2.Controls.Add(this.txt_descipcion_ca);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(95, 27);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(232, 20);
            this.txt_buscar.TabIndex = 1;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(343, 27);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar.TabIndex = 2;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Dgv_principal
            // 
            this.Dgv_principal.AllowUserToAddRows = false;
            this.Dgv_principal.AllowUserToDeleteRows = false;
            this.Dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_principal.Location = new System.Drawing.Point(28, 53);
            this.Dgv_principal.Name = "Dgv_principal";
            this.Dgv_principal.ReadOnly = true;
            this.Dgv_principal.Size = new System.Drawing.Size(515, 136);
            this.Dgv_principal.TabIndex = 3;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.Location = new System.Drawing.Point(26, 290);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(88, 59);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Location = new System.Drawing.Point(131, 290);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(88, 59);
            this.Btn_actualizar.TabIndex = 2;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(239, 290);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(88, 59);
            this.Btn_eliminar.TabIndex = 3;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Location = new System.Drawing.Point(346, 290);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(88, 59);
            this.Btn_reporte.TabIndex = 4;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(454, 290);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(88, 59);
            this.Btn_salir.TabIndex = 5;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria:";
            // 
            // txt_descipcion_ca
            // 
            this.txt_descipcion_ca.Location = new System.Drawing.Point(90, 48);
            this.txt_descipcion_ca.Name = "txt_descipcion_ca";
            this.txt_descipcion_ca.Size = new System.Drawing.Size(221, 20);
            this.txt_descipcion_ca.TabIndex = 1;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(208, 92);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 2;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(115, 92);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Frm_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.tbp_Principal);
            this.Name = "Frm_Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Frm_Categorias_Load);
            this.tbp_Principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbp_Principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_principal;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.TextBox txt_descipcion_ca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
    }
}