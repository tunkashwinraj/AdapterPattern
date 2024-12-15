namespace AdapterPattern_1262774
{
    partial class Form1
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
            this.btnAdapterMath = new System.Windows.Forms.Button();
            this.btnAdapterMath2 = new System.Windows.Forms.Button();
            this.btnObjectAdapter = new System.Windows.Forms.Button();
            this.btnAdapter2Way = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdapterMath
            // 
            this.btnAdapterMath.Location = new System.Drawing.Point(76, 59);
            this.btnAdapterMath.Name = "btnAdapterMath";
            this.btnAdapterMath.Size = new System.Drawing.Size(156, 23);
            this.btnAdapterMath.TabIndex = 0;
            this.btnAdapterMath.Text = "btnAdapterMath";
            this.btnAdapterMath.UseVisualStyleBackColor = true;
            this.btnAdapterMath.Click += new System.EventHandler(this.btnAdapterMath_Click);
            // 
            // btnAdapterMath2
            // 
            this.btnAdapterMath2.Location = new System.Drawing.Point(348, 59);
            this.btnAdapterMath2.Name = "btnAdapterMath2";
            this.btnAdapterMath2.Size = new System.Drawing.Size(157, 23);
            this.btnAdapterMath2.TabIndex = 1;
            this.btnAdapterMath2.Text = "btnAdapterMath2";
            this.btnAdapterMath2.UseVisualStyleBackColor = true;
            this.btnAdapterMath2.Click += new System.EventHandler(this.btnAdapterMath2_Click);
            // 
            // btnObjectAdapter
            // 
            this.btnObjectAdapter.Location = new System.Drawing.Point(76, 156);
            this.btnObjectAdapter.Name = "btnObjectAdapter";
            this.btnObjectAdapter.Size = new System.Drawing.Size(163, 23);
            this.btnObjectAdapter.TabIndex = 2;
            this.btnObjectAdapter.Text = "btnObjectAdapter";
            this.btnObjectAdapter.UseVisualStyleBackColor = true;
            this.btnObjectAdapter.Click += new System.EventHandler(this.btnObjectAdapter_Click);
            // 
            // btnAdapter2Way
            // 
            this.btnAdapter2Way.Location = new System.Drawing.Point(362, 156);
            this.btnAdapter2Way.Name = "btnAdapter2Way";
            this.btnAdapter2Way.Size = new System.Drawing.Size(143, 23);
            this.btnAdapter2Way.TabIndex = 3;
            this.btnAdapter2Way.Text = "btnAdapter2Way";
            this.btnAdapter2Way.UseVisualStyleBackColor = true;
            this.btnAdapter2Way.Click += new System.EventHandler(this.btnAdapter2Way_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdapter2Way);
            this.Controls.Add(this.btnObjectAdapter);
            this.Controls.Add(this.btnAdapterMath2);
            this.Controls.Add(this.btnAdapterMath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdapterMath;
        private System.Windows.Forms.Button btnAdapterMath2;
        private System.Windows.Forms.Button btnObjectAdapter;
        private System.Windows.Forms.Button btnAdapter2Way;
    }
}

