﻿namespace ModalModalessForm
{
    partial class FormMain
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
            this.btmModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmModal
            // 
            this.btmModal.Location = new System.Drawing.Point(10, 22);
            this.btmModal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmModal.Name = "btmModal";
            this.btmModal.Size = new System.Drawing.Size(195, 113);
            this.btmModal.TabIndex = 1;
            this.btmModal.Text = "모달창 띄우기";
            this.btmModal.UseVisualStyleBackColor = true;
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(211, 22);
            this.btnModaless.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(201, 113);
            this.btnModaless.TabIndex = 4;
            this.btnModaless.Text = "모달리스창 띄우기";
            this.btnModaless.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 161);
            this.Controls.Add(this.btnModaless);
            this.Controls.Add(this.btmModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Modal & Modaless 창 띄우기 by 3617 홍은빈";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmModal;
        private System.Windows.Forms.Button btnModaless;
    }
}

