<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBinaryClock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBinaryClock))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.timeClock = New System.Windows.Forms.Timer(Me.components)
        Me.picHour5 = New System.Windows.Forms.PictureBox()
        Me.picHour6 = New System.Windows.Forms.PictureBox()
        Me.picHour1 = New System.Windows.Forms.PictureBox()
        Me.picHour2 = New System.Windows.Forms.PictureBox()
        Me.picHour3 = New System.Windows.Forms.PictureBox()
        Me.picHour4 = New System.Windows.Forms.PictureBox()
        Me.picMin5 = New System.Windows.Forms.PictureBox()
        Me.picMin6 = New System.Windows.Forms.PictureBox()
        Me.picMin7 = New System.Windows.Forms.PictureBox()
        Me.picSec5 = New System.Windows.Forms.PictureBox()
        Me.picSec6 = New System.Windows.Forms.PictureBox()
        Me.picSec7 = New System.Windows.Forms.PictureBox()
        Me.picSec1 = New System.Windows.Forms.PictureBox()
        Me.picSec2 = New System.Windows.Forms.PictureBox()
        Me.picSec3 = New System.Windows.Forms.PictureBox()
        Me.picSec4 = New System.Windows.Forms.PictureBox()
        Me.picMin1 = New System.Windows.Forms.PictureBox()
        Me.picMin2 = New System.Windows.Forms.PictureBox()
        Me.picMin3 = New System.Windows.Forms.PictureBox()
        Me.picMin4 = New System.Windows.Forms.PictureBox()
        Me.lblClock = New System.Windows.Forms.Label()
        CType(Me.picHour5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHour6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHour1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHour2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHour3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHour4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSec4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMin4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(40, 72)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1734, 135)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Binary Clock: 12-Hour Format"
        '
        'timeClock
        '
        '
        'picHour5
        '
        Me.picHour5.Image = CType(resources.GetObject("picHour5.Image"), System.Drawing.Image)
        Me.picHour5.Location = New System.Drawing.Point(194, 1047)
        Me.picHour5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picHour5.Name = "picHour5"
        Me.picHour5.Size = New System.Drawing.Size(183, 185)
        Me.picHour5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHour5.TabIndex = 19
        Me.picHour5.TabStop = False
        '
        'picHour6
        '
        Me.picHour6.Image = CType(resources.GetObject("picHour6.Image"), System.Drawing.Image)
        Me.picHour6.Location = New System.Drawing.Point(194, 825)
        Me.picHour6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picHour6.Name = "picHour6"
        Me.picHour6.Size = New System.Drawing.Size(183, 185)
        Me.picHour6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHour6.TabIndex = 18
        Me.picHour6.TabStop = False
        '
        'picHour1
        '
        Me.picHour1.Image = CType(resources.GetObject("picHour1.Image"), System.Drawing.Image)
        Me.picHour1.Location = New System.Drawing.Point(453, 1047)
        Me.picHour1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picHour1.Name = "picHour1"
        Me.picHour1.Size = New System.Drawing.Size(183, 185)
        Me.picHour1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHour1.TabIndex = 17
        Me.picHour1.TabStop = False
        '
        'picHour2
        '
        Me.picHour2.Image = CType(resources.GetObject("picHour2.Image"), System.Drawing.Image)
        Me.picHour2.Location = New System.Drawing.Point(453, 825)
        Me.picHour2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picHour2.Name = "picHour2"
        Me.picHour2.Size = New System.Drawing.Size(183, 185)
        Me.picHour2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHour2.TabIndex = 16
        Me.picHour2.TabStop = False
        '
        'picHour3
        '
        Me.picHour3.Image = CType(resources.GetObject("picHour3.Image"), System.Drawing.Image)
        Me.picHour3.Location = New System.Drawing.Point(453, 604)
        Me.picHour3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picHour3.Name = "picHour3"
        Me.picHour3.Size = New System.Drawing.Size(183, 185)
        Me.picHour3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHour3.TabIndex = 15
        Me.picHour3.TabStop = False
        '
        'picHour4
        '
        Me.picHour4.Image = CType(resources.GetObject("picHour4.Image"), System.Drawing.Image)
        Me.picHour4.Location = New System.Drawing.Point(453, 382)
        Me.picHour4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picHour4.Name = "picHour4"
        Me.picHour4.Size = New System.Drawing.Size(183, 185)
        Me.picHour4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHour4.TabIndex = 14
        Me.picHour4.TabStop = False
        '
        'picMin5
        '
        Me.picMin5.Image = CType(resources.GetObject("picMin5.Image"), System.Drawing.Image)
        Me.picMin5.Location = New System.Drawing.Point(711, 1047)
        Me.picMin5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picMin5.Name = "picMin5"
        Me.picMin5.Size = New System.Drawing.Size(183, 185)
        Me.picMin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMin5.TabIndex = 13
        Me.picMin5.TabStop = False
        '
        'picMin6
        '
        Me.picMin6.Image = CType(resources.GetObject("picMin6.Image"), System.Drawing.Image)
        Me.picMin6.Location = New System.Drawing.Point(711, 825)
        Me.picMin6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picMin6.Name = "picMin6"
        Me.picMin6.Size = New System.Drawing.Size(183, 185)
        Me.picMin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMin6.TabIndex = 12
        Me.picMin6.TabStop = False
        '
        'picMin7
        '
        Me.picMin7.Image = CType(resources.GetObject("picMin7.Image"), System.Drawing.Image)
        Me.picMin7.Location = New System.Drawing.Point(711, 604)
        Me.picMin7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picMin7.Name = "picMin7"
        Me.picMin7.Size = New System.Drawing.Size(183, 185)
        Me.picMin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMin7.TabIndex = 11
        Me.picMin7.TabStop = False
        '
        'picSec5
        '
        Me.picSec5.Image = CType(resources.GetObject("picSec5.Image"), System.Drawing.Image)
        Me.picSec5.Location = New System.Drawing.Point(1228, 1047)
        Me.picSec5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picSec5.Name = "picSec5"
        Me.picSec5.Size = New System.Drawing.Size(183, 185)
        Me.picSec5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSec5.TabIndex = 10
        Me.picSec5.TabStop = False
        '
        'picSec6
        '
        Me.picSec6.Image = CType(resources.GetObject("picSec6.Image"), System.Drawing.Image)
        Me.picSec6.Location = New System.Drawing.Point(1228, 825)
        Me.picSec6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picSec6.Name = "picSec6"
        Me.picSec6.Size = New System.Drawing.Size(183, 185)
        Me.picSec6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSec6.TabIndex = 9
        Me.picSec6.TabStop = False
        '
        'picSec7
        '
        Me.picSec7.Image = CType(resources.GetObject("picSec7.Image"), System.Drawing.Image)
        Me.picSec7.Location = New System.Drawing.Point(1228, 604)
        Me.picSec7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picSec7.Name = "picSec7"
        Me.picSec7.Size = New System.Drawing.Size(183, 185)
        Me.picSec7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSec7.TabIndex = 8
        Me.picSec7.TabStop = False
        '
        'picSec1
        '
        Me.picSec1.Image = CType(resources.GetObject("picSec1.Image"), System.Drawing.Image)
        Me.picSec1.Location = New System.Drawing.Point(1487, 1047)
        Me.picSec1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picSec1.Name = "picSec1"
        Me.picSec1.Size = New System.Drawing.Size(183, 185)
        Me.picSec1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSec1.TabIndex = 7
        Me.picSec1.TabStop = False
        '
        'picSec2
        '
        Me.picSec2.Image = CType(resources.GetObject("picSec2.Image"), System.Drawing.Image)
        Me.picSec2.Location = New System.Drawing.Point(1487, 825)
        Me.picSec2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picSec2.Name = "picSec2"
        Me.picSec2.Size = New System.Drawing.Size(183, 185)
        Me.picSec2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSec2.TabIndex = 6
        Me.picSec2.TabStop = False
        '
        'picSec3
        '
        Me.picSec3.Image = CType(resources.GetObject("picSec3.Image"), System.Drawing.Image)
        Me.picSec3.Location = New System.Drawing.Point(1487, 604)
        Me.picSec3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picSec3.Name = "picSec3"
        Me.picSec3.Size = New System.Drawing.Size(183, 185)
        Me.picSec3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSec3.TabIndex = 5
        Me.picSec3.TabStop = False
        '
        'picSec4
        '
        Me.picSec4.Image = CType(resources.GetObject("picSec4.Image"), System.Drawing.Image)
        Me.picSec4.Location = New System.Drawing.Point(1487, 382)
        Me.picSec4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picSec4.Name = "picSec4"
        Me.picSec4.Size = New System.Drawing.Size(183, 185)
        Me.picSec4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSec4.TabIndex = 4
        Me.picSec4.TabStop = False
        '
        'picMin1
        '
        Me.picMin1.Image = CType(resources.GetObject("picMin1.Image"), System.Drawing.Image)
        Me.picMin1.Location = New System.Drawing.Point(970, 1047)
        Me.picMin1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picMin1.Name = "picMin1"
        Me.picMin1.Size = New System.Drawing.Size(183, 185)
        Me.picMin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMin1.TabIndex = 3
        Me.picMin1.TabStop = False
        '
        'picMin2
        '
        Me.picMin2.Image = CType(resources.GetObject("picMin2.Image"), System.Drawing.Image)
        Me.picMin2.Location = New System.Drawing.Point(970, 825)
        Me.picMin2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picMin2.Name = "picMin2"
        Me.picMin2.Size = New System.Drawing.Size(183, 185)
        Me.picMin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMin2.TabIndex = 2
        Me.picMin2.TabStop = False
        '
        'picMin3
        '
        Me.picMin3.Image = CType(resources.GetObject("picMin3.Image"), System.Drawing.Image)
        Me.picMin3.Location = New System.Drawing.Point(970, 604)
        Me.picMin3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picMin3.Name = "picMin3"
        Me.picMin3.Size = New System.Drawing.Size(183, 185)
        Me.picMin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMin3.TabIndex = 1
        Me.picMin3.TabStop = False
        '
        'picMin4
        '
        Me.picMin4.Image = CType(resources.GetObject("picMin4.Image"), System.Drawing.Image)
        Me.picMin4.Location = New System.Drawing.Point(970, 382)
        Me.picMin4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picMin4.Name = "picMin4"
        Me.picMin4.Size = New System.Drawing.Size(183, 185)
        Me.picMin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMin4.TabIndex = 0
        Me.picMin4.TabStop = False
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(663, 1293)
        Me.lblClock.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(0, 101)
        Me.lblClock.TabIndex = 21
        '
        'frmBinaryClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1903, 1632)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picHour5)
        Me.Controls.Add(Me.picHour6)
        Me.Controls.Add(Me.picHour1)
        Me.Controls.Add(Me.picHour2)
        Me.Controls.Add(Me.picHour3)
        Me.Controls.Add(Me.picHour4)
        Me.Controls.Add(Me.picMin5)
        Me.Controls.Add(Me.picMin6)
        Me.Controls.Add(Me.picMin7)
        Me.Controls.Add(Me.picSec5)
        Me.Controls.Add(Me.picSec6)
        Me.Controls.Add(Me.picSec7)
        Me.Controls.Add(Me.picSec1)
        Me.Controls.Add(Me.picSec2)
        Me.Controls.Add(Me.picSec3)
        Me.Controls.Add(Me.picSec4)
        Me.Controls.Add(Me.picMin1)
        Me.Controls.Add(Me.picMin2)
        Me.Controls.Add(Me.picMin3)
        Me.Controls.Add(Me.picMin4)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmBinaryClock"
        Me.Text = "Binary Clock"
        CType(Me.picHour5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHour6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHour1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHour2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHour3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHour4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSec4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMin4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMin4 As PictureBox
    Friend WithEvents picMin3 As PictureBox
    Friend WithEvents picMin2 As PictureBox
    Friend WithEvents picMin1 As PictureBox
    Friend WithEvents picSec1 As PictureBox
    Friend WithEvents picSec2 As PictureBox
    Friend WithEvents picSec3 As PictureBox
    Friend WithEvents picSec4 As PictureBox
    Friend WithEvents picSec5 As PictureBox
    Friend WithEvents picSec6 As PictureBox
    Friend WithEvents picSec7 As PictureBox
    Friend WithEvents picMin5 As PictureBox
    Friend WithEvents picMin6 As PictureBox
    Friend WithEvents picMin7 As PictureBox
    Friend WithEvents picHour1 As PictureBox
    Friend WithEvents picHour2 As PictureBox
    Friend WithEvents picHour3 As PictureBox
    Friend WithEvents picHour4 As PictureBox
    Friend WithEvents picHour5 As PictureBox
    Friend WithEvents picHour6 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents timeClock As Timer
    Friend WithEvents lblClock As Label
End Class
