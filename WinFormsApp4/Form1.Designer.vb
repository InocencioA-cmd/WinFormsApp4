<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        chkReading = New CheckBox()
        chkSports = New CheckBox()
        chkMusic = New CheckBox()
        lblCourseResult = New Label()
        lblHobbiesResult = New Label()
        lblGenderResult = New Label()
        cmbCourse = New ComboBox()
        grpGender = New GroupBox()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        btnShowResult = New Button()
        grpGender.SuspendLayout()
        SuspendLayout()
        ' 
        ' chkReading
        ' 
        chkReading.AutoSize = True
        chkReading.Location = New Point(227, 136)
        chkReading.Margin = New Padding(3, 2, 3, 2)
        chkReading.Name = "chkReading"
        chkReading.Size = New Size(69, 19)
        chkReading.TabIndex = 0
        chkReading.Text = "Reading"
        chkReading.UseVisualStyleBackColor = True
        ' 
        ' chkSports
        ' 
        chkSports.AutoSize = True
        chkSports.Location = New Point(339, 136)
        chkSports.Margin = New Padding(3, 2, 3, 2)
        chkSports.Name = "chkSports"
        chkSports.Size = New Size(59, 19)
        chkSports.TabIndex = 1
        chkSports.Text = "Sports"
        chkSports.UseVisualStyleBackColor = True
        ' 
        ' chkMusic
        ' 
        chkMusic.AutoSize = True
        chkMusic.Location = New Point(461, 136)
        chkMusic.Margin = New Padding(3, 2, 3, 2)
        chkMusic.Name = "chkMusic"
        chkMusic.Size = New Size(58, 19)
        chkMusic.TabIndex = 2
        chkMusic.Text = "Music"
        chkMusic.UseVisualStyleBackColor = True
        ' 
        ' lblCourseResult
        ' 
        lblCourseResult.AutoSize = True
        lblCourseResult.BorderStyle = BorderStyle.Fixed3D
        lblCourseResult.Location = New Point(227, 218)
        lblCourseResult.Name = "lblCourseResult"
        lblCourseResult.Size = New Size(49, 17)
        lblCourseResult.TabIndex = 3
        lblCourseResult.Text = "Course:"
        ' 
        ' lblHobbiesResult
        ' 
        lblHobbiesResult.AutoSize = True
        lblHobbiesResult.BorderStyle = BorderStyle.Fixed3D
        lblHobbiesResult.Location = New Point(227, 294)
        lblHobbiesResult.Name = "lblHobbiesResult"
        lblHobbiesResult.Size = New Size(56, 17)
        lblHobbiesResult.TabIndex = 4
        lblHobbiesResult.Text = "Hobbies:"
        ' 
        ' lblGenderResult
        ' 
        lblGenderResult.AutoSize = True
        lblGenderResult.BorderStyle = BorderStyle.Fixed3D
        lblGenderResult.Location = New Point(227, 259)
        lblGenderResult.Name = "lblGenderResult"
        lblGenderResult.Size = New Size(50, 17)
        lblGenderResult.TabIndex = 5
        lblGenderResult.Text = "Gender:"
        ' 
        ' cmbCourse
        ' 
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"Bachelor of Science in Information Technology", "Bachelor of Science in Hotel and Restaurant Management", "Bachelor of Science in Accountancy", "Bachelor of Elementary Education", "Bachelor of Secondary Education", "Bachelor of Science in Business Administration", "Bachelor of Science in Marine Transportation", "Bachelor of Science in Civil Engineering"})
        cmbCourse.Location = New Point(227, 11)
        cmbCourse.Margin = New Padding(3, 2, 3, 2)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(292, 23)
        cmbCourse.TabIndex = 6
        ' 
        ' grpGender
        ' 
        grpGender.Controls.Add(rdoFemale)
        grpGender.Controls.Add(rdoMale)
        grpGender.Location = New Point(282, 47)
        grpGender.Margin = New Padding(3, 2, 3, 2)
        grpGender.Name = "grpGender"
        grpGender.Padding = New Padding(3, 2, 3, 2)
        grpGender.Size = New Size(162, 85)
        grpGender.TabIndex = 7
        grpGender.TabStop = False
        grpGender.Text = "Gender"
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Location = New Point(51, 48)
        rdoFemale.Margin = New Padding(3, 2, 3, 2)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(63, 19)
        rdoFemale.TabIndex = 1
        rdoFemale.TabStop = True
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(51, 25)
        rdoMale.Margin = New Padding(3, 2, 3, 2)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(51, 19)
        rdoMale.TabIndex = 0
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' btnShowResult
        ' 
        btnShowResult.Location = New Point(311, 169)
        btnShowResult.Margin = New Padding(3, 2, 3, 2)
        btnShowResult.Name = "btnShowResult"
        btnShowResult.Size = New Size(133, 34)
        btnShowResult.TabIndex = 8
        btnShowResult.Text = "Show Result"
        btnShowResult.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(btnShowResult)
        Controls.Add(grpGender)
        Controls.Add(cmbCourse)
        Controls.Add(lblGenderResult)
        Controls.Add(lblHobbiesResult)
        Controls.Add(lblCourseResult)
        Controls.Add(chkMusic)
        Controls.Add(chkSports)
        Controls.Add(chkReading)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chkReading As CheckBox
    Friend WithEvents chkSports As CheckBox
    Friend WithEvents chkMusic As CheckBox
    Friend WithEvents lblCourseResult As Label
    Friend WithEvents lblHobbiesResult As Label
    Friend WithEvents lblGenderResult As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents btnShowResult As Button

End Class
