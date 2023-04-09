Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        optButton1.Checked = True
    End Sub

    Private Sub optButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optButton1.CheckedChanged
        PictureBox1.Image = My.Resources.REDMI6A_FRP
    End Sub

    Private Sub optButton2_CheckedChanged(sender As Object, e As EventArgs) Handles optButton2.CheckedChanged
        PictureBox1.Image = My.Resources.samsun_j701f_reset
    End Sub

    Private Sub optButton3_CheckedChanged(sender As Object, e As EventArgs) Handles optButton3.CheckedChanged
        PictureBox1.Image = My.Resources.redmi_8a_pro
    End Sub

    Private Sub optButton4_CheckedChanged(sender As Object, e As EventArgs) Handles optButton4.CheckedChanged
        PictureBox1.Image = My.Resources.redmi_9a_frp
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = My.Resources.smj260_frp_remove_by_unlock_tool
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = My.Resources.samsung_j2_ace_sm_g532g_u1_root_download_mode
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = My.Resources.realme_7i_frp
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox1.Image = My.Resources.samsung_j2_core_sm_j260g_frp_remove_new_trick
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RadioButton9_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        PictureBox1.Image = My.Resources.tecno_spark_ke6
    End Sub

    Private Sub RadioButton10_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        PictureBox1.Image = My.Resources.redmi_note_7_pro_mi_account_unlock

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        PictureBox1.Image = My.Resources.realme_7i_frp

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        PictureBox1.Image = My.Resources._122
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub FONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FONTToolStripMenuItem.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub COLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLORToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub CUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CUTToolStripMenuItem1.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub COPYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles COPYToolStripMenuItem1.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PASTEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PASTEToolStripMenuItem1.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs) Handles ToolStripProgressBar1.Click

    End Sub

    Private Sub PRINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        PictureBox1.Image = My.Resources.samsun_j701f_reset
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        PictureBox1.Image = My.Resources.redmi_9a_frp
    End Sub

    Private Sub ToolStripComboBox5_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox5.Click

    End Sub
End Class
