﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TextEntryDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.TextEnteredUpper = New System.Windows.Forms.TextBox()
        Me.MsgTextLower = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.MsgTextUpper = New System.Windows.Forms.Label()
        Me.TextEnteredLower = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextEnteredUpper
        '
        Me.TextEnteredUpper.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEnteredUpper.Location = New System.Drawing.Point(24, 56)
        Me.TextEnteredUpper.Name = "TextEnteredUpper"
        Me.TextEnteredUpper.Size = New System.Drawing.Size(361, 20)
        Me.TextEnteredUpper.TabIndex = 0
        '
        'MsgTextLower
        '
        Me.MsgTextLower.AutoSize = True
        Me.MsgTextLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgTextLower.Location = New System.Drawing.Point(21, 35)
        Me.MsgTextLower.Name = "MsgTextLower"
        Me.MsgTextLower.Size = New System.Drawing.Size(45, 18)
        Me.MsgTextLower.TabIndex = 5
        Me.MsgTextLower.Text = "Msg:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(295, 103)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(199, 103)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 28)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'MsgTextUpper
        '
        Me.MsgTextUpper.AutoSize = True
        Me.MsgTextUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgTextUpper.Location = New System.Drawing.Point(21, 9)
        Me.MsgTextUpper.Name = "MsgTextUpper"
        Me.MsgTextUpper.Size = New System.Drawing.Size(45, 18)
        Me.MsgTextUpper.TabIndex = 4
        Me.MsgTextUpper.Text = "Msg:"
        '
        'TextEnteredLower
        '
        Me.TextEnteredLower.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEnteredLower.Location = New System.Drawing.Point(24, 79)
        Me.TextEnteredLower.Name = "TextEnteredLower"
        Me.TextEnteredLower.Size = New System.Drawing.Size(361, 20)
        Me.TextEnteredLower.TabIndex = 1
        '
        'TextEntryDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 143)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.MsgTextUpper)
        Me.Controls.Add(Me.MsgTextLower)
        Me.Controls.Add(Me.TextEnteredLower)
        Me.Controls.Add(Me.TextEnteredUpper)
        Me.Name = "TextEntryDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextEnteredUpper As System.Windows.Forms.TextBox
    Friend WithEvents MsgTextLower As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents MsgTextUpper As System.Windows.Forms.Label
    Friend WithEvents TextEnteredLower As System.Windows.Forms.TextBox
End Class