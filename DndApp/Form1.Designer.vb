<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class characterSheetForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.nameTextField = New System.Windows.Forms.TextBox()
        Me.nameSubmitButton = New System.Windows.Forms.Button()
        Me.humanRadioButton = New System.Windows.Forms.RadioButton()
        Me.elfRadioButton = New System.Windows.Forms.RadioButton()
        Me.tieflingRadioButton = New System.Windows.Forms.RadioButton()
        Me.raceSubmitButton = New System.Windows.Forms.Button()
        Me.fighterRadioButton = New System.Windows.Forms.RadioButton()
        Me.barbarianRadioButton = New System.Windows.Forms.RadioButton()
        Me.monkRadioButton = New System.Windows.Forms.RadioButton()
        Me.classSubmitButton = New System.Windows.Forms.Button()
        Me.highElfRadioButton = New System.Windows.Forms.RadioButton()
        Me.woodElfRadioButton = New System.Windows.Forms.RadioButton()
        Me.subraceSubmitButton = New System.Windows.Forms.Button()
        Me.subrace = New System.Windows.Forms.Label()
        Me.raceLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.classLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dndLabel = New System.Windows.Forms.Label()
        Me.statRollLabel = New System.Windows.Forms.Label()
        Me.rollOneTextField = New System.Windows.Forms.TextBox()
        Me.rollTwoTextField = New System.Windows.Forms.TextBox()
        Me.rollThreeTextField = New System.Windows.Forms.TextBox()
        Me.rollDiceButton = New System.Windows.Forms.Button()
        Me.rollValueSubmitButton = New System.Windows.Forms.Button()
        Me.attributeAllocationLabel = New System.Windows.Forms.Label()
        Me.attributeListBox = New System.Windows.Forms.ListBox()
        Me.rollListBox = New System.Windows.Forms.ListBox()
        Me.allocateAttributeButton = New System.Windows.Forms.Button()
        Me.finalizeAttributeButton = New System.Windows.Forms.Button()
        Me.undoAttributeButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelStr = New System.Windows.Forms.Label()
        Me.labelDex = New System.Windows.Forms.Label()
        Me.labelCon = New System.Windows.Forms.Label()
        Me.labelInt = New System.Windows.Forms.Label()
        Me.labelWis = New System.Windows.Forms.Label()
        Me.labelCha = New System.Windows.Forms.Label()
        Me.labelStrValue = New System.Windows.Forms.Label()
        Me.labelDexValue = New System.Windows.Forms.Label()
        Me.labelConValue = New System.Windows.Forms.Label()
        Me.labelIntValue = New System.Windows.Forms.Label()
        Me.labelWisValue = New System.Windows.Forms.Label()
        Me.labelChaValue = New System.Windows.Forms.Label()
        Me.attributeHelpIconBox = New System.Windows.Forms.PictureBox()
        Me.raceGroupBox = New System.Windows.Forms.GroupBox()
        Me.subraceGroupBox = New System.Windows.Forms.GroupBox()
        Me.classGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.skillsListBox = New System.Windows.Forms.ListBox()
        Me.assignedSkillsListBox = New System.Windows.Forms.ListBox()
        Me.undoSkillsButton = New System.Windows.Forms.Button()
        Me.finalizeSkillsButton = New System.Windows.Forms.Button()
        Me.allocateSkillsButton = New System.Windows.Forms.Button()
        Me.skillHelpIconBox = New System.Windows.Forms.PictureBox()
        Me.attributeAllocationHelpIconBox = New System.Windows.Forms.PictureBox()
        Me.statRollHelpIconBox = New System.Windows.Forms.PictureBox()
        Me.nameHelpIconBox = New System.Windows.Forms.PictureBox()
        Me.raceHelpIconBox = New System.Windows.Forms.PictureBox()
        Me.subraceHelpIconBox = New System.Windows.Forms.PictureBox()
        Me.classHelpIconBox = New System.Windows.Forms.PictureBox()
        CType(Me.attributeHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.raceGroupBox.SuspendLayout()
        Me.subraceGroupBox.SuspendLayout()
        Me.classGroupBox.SuspendLayout()
        CType(Me.skillHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.attributeAllocationHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statRollHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raceHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subraceHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.classHelpIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameTextField
        '
        Me.nameTextField.Location = New System.Drawing.Point(12, 113)
        Me.nameTextField.Name = "nameTextField"
        Me.nameTextField.PlaceholderText = "Insert Name Here"
        Me.nameTextField.Size = New System.Drawing.Size(208, 23)
        Me.nameTextField.TabIndex = 0
        '
        'nameSubmitButton
        '
        Me.nameSubmitButton.Location = New System.Drawing.Point(264, 112)
        Me.nameSubmitButton.Name = "nameSubmitButton"
        Me.nameSubmitButton.Size = New System.Drawing.Size(75, 22)
        Me.nameSubmitButton.TabIndex = 1
        Me.nameSubmitButton.Text = "Submit"
        Me.nameSubmitButton.UseVisualStyleBackColor = True
        '
        'humanRadioButton
        '
        Me.humanRadioButton.AutoSize = True
        Me.humanRadioButton.Location = New System.Drawing.Point(5, 20)
        Me.humanRadioButton.Name = "humanRadioButton"
        Me.humanRadioButton.Size = New System.Drawing.Size(68, 19)
        Me.humanRadioButton.TabIndex = 2
        Me.humanRadioButton.TabStop = True
        Me.humanRadioButton.Text = "Human "
        Me.humanRadioButton.UseVisualStyleBackColor = True
        '
        'elfRadioButton
        '
        Me.elfRadioButton.AutoSize = True
        Me.elfRadioButton.Location = New System.Drawing.Point(82, 20)
        Me.elfRadioButton.Name = "elfRadioButton"
        Me.elfRadioButton.Size = New System.Drawing.Size(38, 19)
        Me.elfRadioButton.TabIndex = 3
        Me.elfRadioButton.TabStop = True
        Me.elfRadioButton.Text = "Elf"
        Me.elfRadioButton.UseVisualStyleBackColor = True
        '
        'tieflingRadioButton
        '
        Me.tieflingRadioButton.AutoSize = True
        Me.tieflingRadioButton.Location = New System.Drawing.Point(129, 20)
        Me.tieflingRadioButton.Name = "tieflingRadioButton"
        Me.tieflingRadioButton.Size = New System.Drawing.Size(64, 19)
        Me.tieflingRadioButton.TabIndex = 4
        Me.tieflingRadioButton.TabStop = True
        Me.tieflingRadioButton.Text = "Tiefling"
        Me.tieflingRadioButton.UseVisualStyleBackColor = True
        '
        'raceSubmitButton
        '
        Me.raceSubmitButton.Location = New System.Drawing.Point(264, 206)
        Me.raceSubmitButton.Name = "raceSubmitButton"
        Me.raceSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.raceSubmitButton.TabIndex = 5
        Me.raceSubmitButton.Text = "Submit"
        Me.raceSubmitButton.UseVisualStyleBackColor = True
        '
        'fighterRadioButton
        '
        Me.fighterRadioButton.AutoSize = True
        Me.fighterRadioButton.Location = New System.Drawing.Point(157, 20)
        Me.fighterRadioButton.Name = "fighterRadioButton"
        Me.fighterRadioButton.Size = New System.Drawing.Size(62, 19)
        Me.fighterRadioButton.TabIndex = 6
        Me.fighterRadioButton.TabStop = True
        Me.fighterRadioButton.Text = "Fighter"
        Me.fighterRadioButton.UseVisualStyleBackColor = True
        '
        'barbarianRadioButton
        '
        Me.barbarianRadioButton.AutoSize = True
        Me.barbarianRadioButton.Location = New System.Drawing.Point(5, 20)
        Me.barbarianRadioButton.Name = "barbarianRadioButton"
        Me.barbarianRadioButton.Size = New System.Drawing.Size(75, 19)
        Me.barbarianRadioButton.TabIndex = 7
        Me.barbarianRadioButton.TabStop = True
        Me.barbarianRadioButton.Text = "Barbarian"
        Me.barbarianRadioButton.UseVisualStyleBackColor = True
        '
        'monkRadioButton
        '
        Me.monkRadioButton.AutoSize = True
        Me.monkRadioButton.Location = New System.Drawing.Point(93, 20)
        Me.monkRadioButton.Name = "monkRadioButton"
        Me.monkRadioButton.Size = New System.Drawing.Size(56, 19)
        Me.monkRadioButton.TabIndex = 8
        Me.monkRadioButton.TabStop = True
        Me.monkRadioButton.Text = "Monk"
        Me.monkRadioButton.UseVisualStyleBackColor = True
        '
        'classSubmitButton
        '
        Me.classSubmitButton.Location = New System.Drawing.Point(264, 421)
        Me.classSubmitButton.Name = "classSubmitButton"
        Me.classSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.classSubmitButton.TabIndex = 9
        Me.classSubmitButton.Text = "Submit"
        Me.classSubmitButton.UseVisualStyleBackColor = True
        '
        'highElfRadioButton
        '
        Me.highElfRadioButton.AutoSize = True
        Me.highElfRadioButton.Location = New System.Drawing.Point(5, 20)
        Me.highElfRadioButton.Name = "highElfRadioButton"
        Me.highElfRadioButton.Size = New System.Drawing.Size(67, 19)
        Me.highElfRadioButton.TabIndex = 10
        Me.highElfRadioButton.TabStop = True
        Me.highElfRadioButton.Text = "High Elf"
        Me.highElfRadioButton.UseVisualStyleBackColor = True
        '
        'woodElfRadioButton
        '
        Me.woodElfRadioButton.AutoSize = True
        Me.woodElfRadioButton.Location = New System.Drawing.Point(83, 20)
        Me.woodElfRadioButton.Name = "woodElfRadioButton"
        Me.woodElfRadioButton.Size = New System.Drawing.Size(73, 19)
        Me.woodElfRadioButton.TabIndex = 11
        Me.woodElfRadioButton.TabStop = True
        Me.woodElfRadioButton.Text = "Wood Elf"
        Me.woodElfRadioButton.UseVisualStyleBackColor = True
        '
        'subraceSubmitButton
        '
        Me.subraceSubmitButton.Location = New System.Drawing.Point(264, 315)
        Me.subraceSubmitButton.Name = "subraceSubmitButton"
        Me.subraceSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.subraceSubmitButton.TabIndex = 12
        Me.subraceSubmitButton.Text = "Submit"
        Me.subraceSubmitButton.UseVisualStyleBackColor = True
        '
        'subrace
        '
        Me.subrace.AutoSize = True
        Me.subrace.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.subrace.Location = New System.Drawing.Point(64, 266)
        Me.subrace.Name = "subrace"
        Me.subrace.Size = New System.Drawing.Size(120, 32)
        Me.subrace.TabIndex = 13
        Me.subrace.Text = "Subrace"
        '
        'raceLabel
        '
        Me.raceLabel.AutoSize = True
        Me.raceLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.raceLabel.Location = New System.Drawing.Point(88, 157)
        Me.raceLabel.Name = "raceLabel"
        Me.raceLabel.Size = New System.Drawing.Size(78, 32)
        Me.raceLabel.TabIndex = 14
        Me.raceLabel.Text = "Race"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.nameLabel.Location = New System.Drawing.Point(77, 69)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(89, 32)
        Me.nameLabel.TabIndex = 15
        Me.nameLabel.Text = "Name"
        '
        'classLabel
        '
        Me.classLabel.AutoSize = True
        Me.classLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.classLabel.Location = New System.Drawing.Point(77, 372)
        Me.classLabel.Name = "classLabel"
        Me.classLabel.Size = New System.Drawing.Size(85, 32)
        Me.classLabel.TabIndex = 16
        Me.classLabel.Text = "Class"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 17
        '
        'dndLabel
        '
        Me.dndLabel.AutoSize = True
        Me.dndLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.dndLabel.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.dndLabel.Location = New System.Drawing.Point(5, 9)
        Me.dndLabel.Name = "dndLabel"
        Me.dndLabel.Size = New System.Drawing.Size(207, 19)
        Me.dndLabel.TabIndex = 18
        Me.dndLabel.Text = "Dungeons And Dragons"
        '
        'statRollLabel
        '
        Me.statRollLabel.AutoSize = True
        Me.statRollLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.statRollLabel.Location = New System.Drawing.Point(464, 37)
        Me.statRollLabel.Name = "statRollLabel"
        Me.statRollLabel.Size = New System.Drawing.Size(122, 32)
        Me.statRollLabel.TabIndex = 19
        Me.statRollLabel.Text = "Stat Roll"
        '
        'rollOneTextField
        '
        Me.rollOneTextField.Location = New System.Drawing.Point(425, 94)
        Me.rollOneTextField.Name = "rollOneTextField"
        Me.rollOneTextField.PlaceholderText = "Roll 1"
        Me.rollOneTextField.Size = New System.Drawing.Size(58, 23)
        Me.rollOneTextField.TabIndex = 20
        '
        'rollTwoTextField
        '
        Me.rollTwoTextField.Location = New System.Drawing.Point(489, 94)
        Me.rollTwoTextField.Name = "rollTwoTextField"
        Me.rollTwoTextField.PlaceholderText = "Roll 2"
        Me.rollTwoTextField.Size = New System.Drawing.Size(58, 23)
        Me.rollTwoTextField.TabIndex = 21
        '
        'rollThreeTextField
        '
        Me.rollThreeTextField.Location = New System.Drawing.Point(553, 94)
        Me.rollThreeTextField.Name = "rollThreeTextField"
        Me.rollThreeTextField.PlaceholderText = "Roll 3"
        Me.rollThreeTextField.Size = New System.Drawing.Size(58, 23)
        Me.rollThreeTextField.TabIndex = 22
        '
        'rollDiceButton
        '
        Me.rollDiceButton.Location = New System.Drawing.Point(621, 94)
        Me.rollDiceButton.Name = "rollDiceButton"
        Me.rollDiceButton.Size = New System.Drawing.Size(58, 23)
        Me.rollDiceButton.TabIndex = 23
        Me.rollDiceButton.Text = "Roll"
        Me.rollDiceButton.UseVisualStyleBackColor = True
        '
        'rollValueSubmitButton
        '
        Me.rollValueSubmitButton.Location = New System.Drawing.Point(480, 130)
        Me.rollValueSubmitButton.Name = "rollValueSubmitButton"
        Me.rollValueSubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.rollValueSubmitButton.TabIndex = 24
        Me.rollValueSubmitButton.Text = "Submit"
        Me.rollValueSubmitButton.UseVisualStyleBackColor = True
        '
        'attributeAllocationLabel
        '
        Me.attributeAllocationLabel.AutoSize = True
        Me.attributeAllocationLabel.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.attributeAllocationLabel.Location = New System.Drawing.Point(398, 197)
        Me.attributeAllocationLabel.Name = "attributeAllocationLabel"
        Me.attributeAllocationLabel.Size = New System.Drawing.Size(260, 32)
        Me.attributeAllocationLabel.TabIndex = 25
        Me.attributeAllocationLabel.Text = "Attribute Allocation"
        '
        'attributeListBox
        '
        Me.attributeListBox.FormattingEnabled = True
        Me.attributeListBox.ItemHeight = 15
        Me.attributeListBox.Items.AddRange(New Object() {"Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"})
        Me.attributeListBox.Location = New System.Drawing.Point(513, 250)
        Me.attributeListBox.Name = "attributeListBox"
        Me.attributeListBox.Size = New System.Drawing.Size(97, 154)
        Me.attributeListBox.TabIndex = 26
        '
        'rollListBox
        '
        Me.rollListBox.FormattingEnabled = True
        Me.rollListBox.ItemHeight = 15
        Me.rollListBox.Location = New System.Drawing.Point(410, 250)
        Me.rollListBox.Name = "rollListBox"
        Me.rollListBox.Size = New System.Drawing.Size(98, 154)
        Me.rollListBox.TabIndex = 27
        '
        'allocateAttributeButton
        '
        Me.allocateAttributeButton.Location = New System.Drawing.Point(621, 259)
        Me.allocateAttributeButton.Name = "allocateAttributeButton"
        Me.allocateAttributeButton.Size = New System.Drawing.Size(75, 23)
        Me.allocateAttributeButton.TabIndex = 28
        Me.allocateAttributeButton.Text = "Allocate"
        Me.allocateAttributeButton.UseVisualStyleBackColor = True
        '
        'finalizeAttributeButton
        '
        Me.finalizeAttributeButton.Location = New System.Drawing.Point(621, 365)
        Me.finalizeAttributeButton.Name = "finalizeAttributeButton"
        Me.finalizeAttributeButton.Size = New System.Drawing.Size(75, 23)
        Me.finalizeAttributeButton.TabIndex = 29
        Me.finalizeAttributeButton.Text = "Finalize"
        Me.finalizeAttributeButton.UseVisualStyleBackColor = True
        '
        'undoAttributeButton
        '
        Me.undoAttributeButton.Location = New System.Drawing.Point(621, 314)
        Me.undoAttributeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.undoAttributeButton.Name = "undoAttributeButton"
        Me.undoAttributeButton.Size = New System.Drawing.Size(75, 22)
        Me.undoAttributeButton.TabIndex = 30
        Me.undoAttributeButton.Text = "Undo"
        Me.undoAttributeButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(752, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 32)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Character Attributes"
        '
        'labelStr
        '
        Me.labelStr.AutoSize = True
        Me.labelStr.Location = New System.Drawing.Point(752, 84)
        Me.labelStr.Name = "labelStr"
        Me.labelStr.Size = New System.Drawing.Size(52, 15)
        Me.labelStr.TabIndex = 32
        Me.labelStr.Text = "Strength"
        '
        'labelDex
        '
        Me.labelDex.AutoSize = True
        Me.labelDex.Location = New System.Drawing.Point(879, 84)
        Me.labelDex.Name = "labelDex"
        Me.labelDex.Size = New System.Drawing.Size(54, 15)
        Me.labelDex.TabIndex = 33
        Me.labelDex.Text = "Dexterity"
        '
        'labelCon
        '
        Me.labelCon.AutoSize = True
        Me.labelCon.Location = New System.Drawing.Point(1005, 84)
        Me.labelCon.Name = "labelCon"
        Me.labelCon.Size = New System.Drawing.Size(73, 15)
        Me.labelCon.TabIndex = 34
        Me.labelCon.Text = "Constitution"
        '
        'labelInt
        '
        Me.labelInt.AutoSize = True
        Me.labelInt.Location = New System.Drawing.Point(752, 150)
        Me.labelInt.Name = "labelInt"
        Me.labelInt.Size = New System.Drawing.Size(68, 15)
        Me.labelInt.TabIndex = 35
        Me.labelInt.Text = "Intelligence"
        '
        'labelWis
        '
        Me.labelWis.AutoSize = True
        Me.labelWis.Location = New System.Drawing.Point(879, 150)
        Me.labelWis.Name = "labelWis"
        Me.labelWis.Size = New System.Drawing.Size(51, 15)
        Me.labelWis.TabIndex = 36
        Me.labelWis.Text = "Wisdom"
        '
        'labelCha
        '
        Me.labelCha.AutoSize = True
        Me.labelCha.Location = New System.Drawing.Point(1005, 150)
        Me.labelCha.Name = "labelCha"
        Me.labelCha.Size = New System.Drawing.Size(57, 15)
        Me.labelCha.TabIndex = 37
        Me.labelCha.Text = "Charisma"
        '
        'labelStrValue
        '
        Me.labelStrValue.AutoSize = True
        Me.labelStrValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelStrValue.Location = New System.Drawing.Point(752, 114)
        Me.labelStrValue.Name = "labelStrValue"
        Me.labelStrValue.Size = New System.Drawing.Size(19, 21)
        Me.labelStrValue.TabIndex = 38
        Me.labelStrValue.Text = "0"
        '
        'labelDexValue
        '
        Me.labelDexValue.AutoSize = True
        Me.labelDexValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDexValue.Location = New System.Drawing.Point(879, 115)
        Me.labelDexValue.Name = "labelDexValue"
        Me.labelDexValue.Size = New System.Drawing.Size(19, 21)
        Me.labelDexValue.TabIndex = 39
        Me.labelDexValue.Text = "0"
        '
        'labelConValue
        '
        Me.labelConValue.AutoSize = True
        Me.labelConValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelConValue.Location = New System.Drawing.Point(1005, 117)
        Me.labelConValue.Name = "labelConValue"
        Me.labelConValue.Size = New System.Drawing.Size(19, 21)
        Me.labelConValue.TabIndex = 40
        Me.labelConValue.Text = "0"
        '
        'labelIntValue
        '
        Me.labelIntValue.AutoSize = True
        Me.labelIntValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelIntValue.Location = New System.Drawing.Point(752, 184)
        Me.labelIntValue.Name = "labelIntValue"
        Me.labelIntValue.Size = New System.Drawing.Size(19, 21)
        Me.labelIntValue.TabIndex = 41
        Me.labelIntValue.Text = "0"
        '
        'labelWisValue
        '
        Me.labelWisValue.AutoSize = True
        Me.labelWisValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelWisValue.Location = New System.Drawing.Point(879, 184)
        Me.labelWisValue.Name = "labelWisValue"
        Me.labelWisValue.Size = New System.Drawing.Size(19, 21)
        Me.labelWisValue.TabIndex = 42
        Me.labelWisValue.Text = "0"
        '
        'labelChaValue
        '
        Me.labelChaValue.AutoSize = True
        Me.labelChaValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelChaValue.Location = New System.Drawing.Point(1005, 184)
        Me.labelChaValue.Name = "labelChaValue"
        Me.labelChaValue.Size = New System.Drawing.Size(19, 21)
        Me.labelChaValue.TabIndex = 43
        Me.labelChaValue.Text = "0"
        '
        'attributeHelpIconBox
        '
        Me.attributeHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.attributeHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.attributeHelpIconBox.Location = New System.Drawing.Point(1036, 37)
        Me.attributeHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.attributeHelpIconBox.Name = "attributeHelpIconBox"
        Me.attributeHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.attributeHelpIconBox.TabIndex = 44
        Me.attributeHelpIconBox.TabStop = False
        '
        'raceGroupBox
        '
        Me.raceGroupBox.Controls.Add(Me.humanRadioButton)
        Me.raceGroupBox.Controls.Add(Me.elfRadioButton)
        Me.raceGroupBox.Controls.Add(Me.tieflingRadioButton)
        Me.raceGroupBox.Location = New System.Drawing.Point(12, 188)
        Me.raceGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.raceGroupBox.Name = "raceGroupBox"
        Me.raceGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.raceGroupBox.Size = New System.Drawing.Size(219, 53)
        Me.raceGroupBox.TabIndex = 45
        Me.raceGroupBox.TabStop = False
        '
        'subraceGroupBox
        '
        Me.subraceGroupBox.Controls.Add(Me.highElfRadioButton)
        Me.subraceGroupBox.Controls.Add(Me.woodElfRadioButton)
        Me.subraceGroupBox.Location = New System.Drawing.Point(45, 297)
        Me.subraceGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subraceGroupBox.Name = "subraceGroupBox"
        Me.subraceGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subraceGroupBox.Size = New System.Drawing.Size(166, 46)
        Me.subraceGroupBox.TabIndex = 46
        Me.subraceGroupBox.TabStop = False
        '
        'classGroupBox
        '
        Me.classGroupBox.Controls.Add(Me.barbarianRadioButton)
        Me.classGroupBox.Controls.Add(Me.monkRadioButton)
        Me.classGroupBox.Controls.Add(Me.fighterRadioButton)
        Me.classGroupBox.Location = New System.Drawing.Point(10, 403)
        Me.classGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.classGroupBox.Name = "classGroupBox"
        Me.classGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.classGroupBox.Size = New System.Drawing.Size(230, 48)
        Me.classGroupBox.TabIndex = 47
        Me.classGroupBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(794, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 32)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Proficient Skills"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(863, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "(Choose Two)"
        '
        'skillsListBox
        '
        Me.skillsListBox.FormattingEnabled = True
        Me.skillsListBox.ItemHeight = 15
        Me.skillsListBox.Location = New System.Drawing.Point(794, 297)
        Me.skillsListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.skillsListBox.Name = "skillsListBox"
        Me.skillsListBox.Size = New System.Drawing.Size(97, 124)
        Me.skillsListBox.TabIndex = 50
        '
        'assignedSkillsListBox
        '
        Me.assignedSkillsListBox.FormattingEnabled = True
        Me.assignedSkillsListBox.ItemHeight = 15
        Me.assignedSkillsListBox.Location = New System.Drawing.Point(896, 297)
        Me.assignedSkillsListBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.assignedSkillsListBox.Name = "assignedSkillsListBox"
        Me.assignedSkillsListBox.Size = New System.Drawing.Size(97, 124)
        Me.assignedSkillsListBox.TabIndex = 51
        '
        'undoSkillsButton
        '
        Me.undoSkillsButton.Location = New System.Drawing.Point(1005, 350)
        Me.undoSkillsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.undoSkillsButton.Name = "undoSkillsButton"
        Me.undoSkillsButton.Size = New System.Drawing.Size(75, 22)
        Me.undoSkillsButton.TabIndex = 54
        Me.undoSkillsButton.Text = "Undo"
        Me.undoSkillsButton.UseVisualStyleBackColor = True
        '
        'finalizeSkillsButton
        '
        Me.finalizeSkillsButton.Location = New System.Drawing.Point(1005, 386)
        Me.finalizeSkillsButton.Name = "finalizeSkillsButton"
        Me.finalizeSkillsButton.Size = New System.Drawing.Size(75, 23)
        Me.finalizeSkillsButton.TabIndex = 53
        Me.finalizeSkillsButton.Text = "Finalize"
        Me.finalizeSkillsButton.UseVisualStyleBackColor = True
        '
        'allocateSkillsButton
        '
        Me.allocateSkillsButton.Location = New System.Drawing.Point(1005, 312)
        Me.allocateSkillsButton.Name = "allocateSkillsButton"
        Me.allocateSkillsButton.Size = New System.Drawing.Size(75, 23)
        Me.allocateSkillsButton.TabIndex = 52
        Me.allocateSkillsButton.Text = "Allocate"
        Me.allocateSkillsButton.UseVisualStyleBackColor = True
        '
        'skillHelpIconBox
        '
        Me.skillHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.skillHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.skillHelpIconBox.Location = New System.Drawing.Point(1011, 226)
        Me.skillHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.skillHelpIconBox.Name = "skillHelpIconBox"
        Me.skillHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.skillHelpIconBox.TabIndex = 55
        Me.skillHelpIconBox.TabStop = False
        '
        'attributeAllocationHelpIconBox
        '
        Me.attributeAllocationHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.attributeAllocationHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.attributeAllocationHelpIconBox.Location = New System.Drawing.Point(664, 198)
        Me.attributeAllocationHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.attributeAllocationHelpIconBox.Name = "attributeAllocationHelpIconBox"
        Me.attributeAllocationHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.attributeAllocationHelpIconBox.TabIndex = 56
        Me.attributeAllocationHelpIconBox.TabStop = False
        '
        'statRollHelpIconBox
        '
        Me.statRollHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.statRollHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.statRollHelpIconBox.Location = New System.Drawing.Point(592, 37)
        Me.statRollHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.statRollHelpIconBox.Name = "statRollHelpIconBox"
        Me.statRollHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.statRollHelpIconBox.TabIndex = 57
        Me.statRollHelpIconBox.TabStop = False
        '
        'nameHelpIconBox
        '
        Me.nameHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.nameHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.nameHelpIconBox.Location = New System.Drawing.Point(172, 72)
        Me.nameHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nameHelpIconBox.Name = "nameHelpIconBox"
        Me.nameHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.nameHelpIconBox.TabIndex = 58
        Me.nameHelpIconBox.TabStop = False
        '
        'raceHelpIconBox
        '
        Me.raceHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.raceHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.raceHelpIconBox.Location = New System.Drawing.Point(172, 157)
        Me.raceHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.raceHelpIconBox.Name = "raceHelpIconBox"
        Me.raceHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.raceHelpIconBox.TabIndex = 59
        Me.raceHelpIconBox.TabStop = False
        '
        'subraceHelpIconBox
        '
        Me.subraceHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.subraceHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.subraceHelpIconBox.Location = New System.Drawing.Point(190, 269)
        Me.subraceHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subraceHelpIconBox.Name = "subraceHelpIconBox"
        Me.subraceHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.subraceHelpIconBox.TabIndex = 60
        Me.subraceHelpIconBox.TabStop = False
        '
        'classHelpIconBox
        '
        Me.classHelpIconBox.BackgroundImage = Global.DndApp.My.Resources.Resources.dndhelpicon
        Me.classHelpIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.classHelpIconBox.Location = New System.Drawing.Point(168, 375)
        Me.classHelpIconBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.classHelpIconBox.Name = "classHelpIconBox"
        Me.classHelpIconBox.Size = New System.Drawing.Size(26, 29)
        Me.classHelpIconBox.TabIndex = 61
        Me.classHelpIconBox.TabStop = False
        '
        'characterSheetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 478)
        Me.Controls.Add(Me.classHelpIconBox)
        Me.Controls.Add(Me.subraceHelpIconBox)
        Me.Controls.Add(Me.raceHelpIconBox)
        Me.Controls.Add(Me.nameHelpIconBox)
        Me.Controls.Add(Me.statRollHelpIconBox)
        Me.Controls.Add(Me.attributeAllocationHelpIconBox)
        Me.Controls.Add(Me.skillHelpIconBox)
        Me.Controls.Add(Me.undoSkillsButton)
        Me.Controls.Add(Me.finalizeSkillsButton)
        Me.Controls.Add(Me.allocateSkillsButton)
        Me.Controls.Add(Me.assignedSkillsListBox)
        Me.Controls.Add(Me.skillsListBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.classGroupBox)
        Me.Controls.Add(Me.subraceGroupBox)
        Me.Controls.Add(Me.raceGroupBox)
        Me.Controls.Add(Me.attributeHelpIconBox)
        Me.Controls.Add(Me.labelChaValue)
        Me.Controls.Add(Me.labelWisValue)
        Me.Controls.Add(Me.labelIntValue)
        Me.Controls.Add(Me.labelConValue)
        Me.Controls.Add(Me.labelDexValue)
        Me.Controls.Add(Me.labelStrValue)
        Me.Controls.Add(Me.labelCha)
        Me.Controls.Add(Me.labelWis)
        Me.Controls.Add(Me.labelInt)
        Me.Controls.Add(Me.labelCon)
        Me.Controls.Add(Me.labelDex)
        Me.Controls.Add(Me.labelStr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.undoAttributeButton)
        Me.Controls.Add(Me.finalizeAttributeButton)
        Me.Controls.Add(Me.allocateAttributeButton)
        Me.Controls.Add(Me.rollListBox)
        Me.Controls.Add(Me.attributeListBox)
        Me.Controls.Add(Me.attributeAllocationLabel)
        Me.Controls.Add(Me.rollValueSubmitButton)
        Me.Controls.Add(Me.rollDiceButton)
        Me.Controls.Add(Me.rollThreeTextField)
        Me.Controls.Add(Me.rollTwoTextField)
        Me.Controls.Add(Me.rollOneTextField)
        Me.Controls.Add(Me.statRollLabel)
        Me.Controls.Add(Me.dndLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.classLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.raceLabel)
        Me.Controls.Add(Me.subrace)
        Me.Controls.Add(Me.subraceSubmitButton)
        Me.Controls.Add(Me.classSubmitButton)
        Me.Controls.Add(Me.raceSubmitButton)
        Me.Controls.Add(Me.nameSubmitButton)
        Me.Controls.Add(Me.nameTextField)
        Me.Name = "characterSheetForm"
        Me.Text = "Character Attributes"
        CType(Me.attributeHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.raceGroupBox.ResumeLayout(False)
        Me.raceGroupBox.PerformLayout()
        Me.subraceGroupBox.ResumeLayout(False)
        Me.subraceGroupBox.PerformLayout()
        Me.classGroupBox.ResumeLayout(False)
        Me.classGroupBox.PerformLayout()
        CType(Me.skillHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.attributeAllocationHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statRollHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raceHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subraceHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.classHelpIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameTextField As TextBox
    Friend WithEvents nameSubmitButton As Button
    Friend WithEvents humanRadioButton As RadioButton
    Friend WithEvents elfRadioButton As RadioButton
    Friend WithEvents tieflingRadioButton As RadioButton
    Friend WithEvents raceSubmitButton As Button
    Friend WithEvents fighterRadioButton As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents barbarianRadioButton As RadioButton
    Friend WithEvents monkRadioButton As RadioButton
    Friend WithEvents classSubmitButton As Button
    Friend WithEvents highElfRadioButton As RadioButton
    Friend WithEvents woodElfRadioButton As RadioButton
    Friend WithEvents subraceSubmitButton As Button
    Friend WithEvents subrace As Label
    Friend WithEvents raceLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents classLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dndLabel As Label
    Friend WithEvents statRollLabel As Label
    Friend WithEvents rollOneTextField As TextBox
    Friend WithEvents rollTwoTextField As TextBox
    Friend WithEvents rollThreeTextField As TextBox
    Friend WithEvents rollDiceButton As Button
    Friend WithEvents rollValueSubmitButton As Button
    Friend WithEvents attributeAllocationLabel As Label
    Friend WithEvents attributeListBox As ListBox
    Friend WithEvents rollListBox As ListBox
    Friend WithEvents allocateAttributeButton As Button
    Friend WithEvents finalizeAttributeButton As Button
    Friend WithEvents undoAttributeButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents labelStr As Label
    Friend WithEvents labelDex As Label
    Friend WithEvents labelCon As Label
    Friend WithEvents labelInt As Label
    Friend WithEvents labelWis As Label
    Friend WithEvents labelCha As Label
    Friend WithEvents labelStrValue As Label
    Friend WithEvents labelDexValue As Label
    Friend WithEvents labelConValue As Label
    Friend WithEvents labelIntValue As Label
    Friend WithEvents labelWisValue As Label
    Friend WithEvents labelChaValue As Label
    Friend WithEvents attributeHelpIconBox As PictureBox
    Friend WithEvents raceGroupBox As GroupBox
    Friend WithEvents subraceGroupBox As GroupBox
    Friend WithEvents classGroupBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents skillsListBox As ListBox
    Friend WithEvents assignedSkillsListBox As ListBox
    Friend WithEvents undoSkillsButton As Button
    Friend WithEvents finalizeSkillsButton As Button
    Friend WithEvents allocateSkillsButton As Button
    Friend WithEvents skillHelpIconBox As PictureBox
    Friend WithEvents attributeAllocationHelpIconBox As PictureBox
    Friend WithEvents statRollHelpIconBox As PictureBox
    Friend WithEvents nameHelpIconBox As PictureBox
    Friend WithEvents raceHelpIconBox As PictureBox
    Friend WithEvents subraceHelpIconBox As PictureBox
    Friend WithEvents classHelpIconBox As PictureBox
End Class
