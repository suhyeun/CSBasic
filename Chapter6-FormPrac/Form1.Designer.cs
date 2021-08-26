
namespace Chapter6_FormPrac
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMeaageBox1 = new System.Windows.Forms.Button();
            this.btnMeaageBox2 = new System.Windows.Forms.Button();
            this.btnMeaageBox3 = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMeaageBox1
            // 
            this.btnMeaageBox1.Location = new System.Drawing.Point(12, 65);
            this.btnMeaageBox1.Name = "btnMeaageBox1";
            this.btnMeaageBox1.Size = new System.Drawing.Size(279, 66);
            this.btnMeaageBox1.TabIndex = 0;
            this.btnMeaageBox1.Text = "메세지 박스 보기";
            this.btnMeaageBox1.UseVisualStyleBackColor = true;
            this.btnMeaageBox1.Click += new System.EventHandler(this.btnMeaageBox1_Click);
            // 
            // btnMeaageBox2
            // 
            this.btnMeaageBox2.Location = new System.Drawing.Point(12, 137);
            this.btnMeaageBox2.Name = "btnMeaageBox2";
            this.btnMeaageBox2.Size = new System.Drawing.Size(279, 66);
            this.btnMeaageBox2.TabIndex = 1;
            this.btnMeaageBox2.Text = "메세지 박스 보기";
            this.btnMeaageBox2.UseVisualStyleBackColor = true;
            this.btnMeaageBox2.Click += new System.EventHandler(this.btnMeaageBox1_Click);
            // 
            // btnMeaageBox3
            // 
            this.btnMeaageBox3.Location = new System.Drawing.Point(12, 209);
            this.btnMeaageBox3.Name = "btnMeaageBox3";
            this.btnMeaageBox3.Size = new System.Drawing.Size(279, 66);
            this.btnMeaageBox3.TabIndex = 2;
            this.btnMeaageBox3.Text = "메세지 박스 보기\r\n";
            this.btnMeaageBox3.UseVisualStyleBackColor = true;
            this.btnMeaageBox3.Click += new System.EventHandler(this.btnMeaageBox1_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(297, 174);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(262, 101);
            this.btnModal.TabIndex = 4;
            this.btnModal.Text = "모달 창 열기\r\n";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModaless1_Click);
            // 
            // btnModaless1
            // 
            this.btnModaless1.Location = new System.Drawing.Point(297, 65);
            this.btnModaless1.Name = "btnModaless1";
            this.btnModaless1.Size = new System.Drawing.Size(262, 101);
            this.btnModaless1.TabIndex = 5;
            this.btnModaless1.Text = "모달리스 창 열기";
            this.btnModaless1.UseVisualStyleBackColor = true;
            this.btnModaless1.Click += new System.EventHandler(this.btnModaless1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 352);
            this.Controls.Add(this.btnModaless1);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.btnMeaageBox3);
            this.Controls.Add(this.btnMeaageBox2);
            this.Controls.Add(this.btnMeaageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMeaageBox1;
        private System.Windows.Forms.Button btnMeaageBox2;
        private System.Windows.Forms.Button btnMeaageBox3;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModaless1;
    }
}

