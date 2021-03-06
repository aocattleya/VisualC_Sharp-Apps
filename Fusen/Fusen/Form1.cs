﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fusen
{
    public partial class FormFusen : Form
    {
        private int mouseX; // マウスの横位置（x座標）
        private int mouseY; // マウスの縦位置（y座標）

        public FormFusen()
        {
            InitializeComponent();
        }

        private void textFusenMemo_KeyDown(object sender, KeyEventArgs e)
        {
            // <判定>押されたキーがエスケープキー？
            if (e.KeyCode == Keys.Escape)
            {
                // Yesの場合
                // アプリケーションを終了
                this.Close();
            }
        }

        private void textFusenMemo_MouseDown(object sender, MouseEventArgs e)
        {
            // <判定>押されたボタンがマウスの左ボタン？
            if (e.Button == MouseButtons.Left)
            {
                // Yesの場合
                this.mouseX = e.X; // マウスの横位置（x座標）を記憶
                this.mouseY = e.Y; // マウスの縦位置（y座標）を記憶
            }
        }

        private void textFusenMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 色の設定ダイアログを表示する
            colorDialogFusen.ShowDialog();
            // テキストボックスの背景色を色の設定ダイアログで選んで色に設定する
            textFusenMemo.BackColor = colorDialogFusen.Color;
        }

        private void textFusenMemo_MouseMove(object sender, MouseEventArgs e)
        {
            // <判定>押されたボタンがマウスの左ボタン？
            if (e.Button == MouseButtons.Left)
            {
                // Yseの場合
                this.Left += e.X - mouseX; // フォームの横位置を更新
                this.Top += e.Y - mouseY; // フォームの縦位置を更新
            }
        }
    }
}
