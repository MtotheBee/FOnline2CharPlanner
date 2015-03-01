<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"First Aid Book", "10"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Outdoorsman Book", "10"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Repair Book", "10"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Science Book", "10"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Small Guns Book", "10"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Black, Nothing)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Accuracy Implant")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Chem Control Implant")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Defense Implant")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Enhancement Implant")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Enviromental Implant")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Marksmanship Implant")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Medical Implant")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Scouting Implant")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Speed Implant")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Survival Implant")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mary Ann - JT")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Pete Quest - JT")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Albert the Abberation")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Awareness")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Engineering Implant")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Heave Ho!")
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mother of God")
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Pack Rat")
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Pathfinder")
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Pyromaniac")
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("+1 to FOV, +5% HitChance")
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("+10HP, +4 Healing Rate")
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("+3 to Crit Chance")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblStatsST = New System.Windows.Forms.Label()
        Me.LblStatsPE = New System.Windows.Forms.Label()
        Me.LblStatsEN = New System.Windows.Forms.Label()
        Me.LblStatsCH = New System.Windows.Forms.Label()
        Me.LblStatsIN = New System.Windows.Forms.Label()
        Me.LblStatsAG = New System.Windows.Forms.Label()
        Me.LblStatsLK = New System.Windows.Forms.Label()
        Me.PanStats = New System.Windows.Forms.Panel()
        Me.BtnStatsLKDown = New System.Windows.Forms.Button()
        Me.BtnStatsLKUp = New System.Windows.Forms.Button()
        Me.BtnStatsAGDown = New System.Windows.Forms.Button()
        Me.BtnStatsAGUp = New System.Windows.Forms.Button()
        Me.BtnStatsINDown = New System.Windows.Forms.Button()
        Me.BtnStatsINUp = New System.Windows.Forms.Button()
        Me.BtnStatsCHDown = New System.Windows.Forms.Button()
        Me.BtnStatsCHUp = New System.Windows.Forms.Button()
        Me.BtnStatsENDown = New System.Windows.Forms.Button()
        Me.BtnStatsENUp = New System.Windows.Forms.Button()
        Me.BtnStatsPEDown = New System.Windows.Forms.Button()
        Me.BtnStatsPEUp = New System.Windows.Forms.Button()
        Me.BtnStatsSTDown = New System.Windows.Forms.Button()
        Me.BtnStatsSTUp = New System.Windows.Forms.Button()
        Me.LblStatsLKVal = New System.Windows.Forms.Label()
        Me.LblStatsAGVal = New System.Windows.Forms.Label()
        Me.LblStatsINVal = New System.Windows.Forms.Label()
        Me.LblStatsCHVal = New System.Windows.Forms.Label()
        Me.LblStatsENVal = New System.Windows.Forms.Label()
        Me.LblStatsPEVal = New System.Windows.Forms.Label()
        Me.LblStatsSTVal = New System.Windows.Forms.Label()
        Me.LblStatsHead = New System.Windows.Forms.Label()
        Me.CPointsPan = New System.Windows.Forms.Panel()
        Me.LblCPointsHead = New System.Windows.Forms.Label()
        Me.LblCPoints = New System.Windows.Forms.Label()
        Me.PanTraits = New System.Windows.Forms.Panel()
        Me.LblTraitsEvader = New System.Windows.Forms.Label()
        Me.LblTraitsMutant = New System.Windows.Forms.Label()
        Me.LblTraitsBHead = New System.Windows.Forms.Label()
        Me.LblTraitsCRes = New System.Windows.Forms.Label()
        Me.LblTraitsCRel = New System.Windows.Forms.Label()
        Me.LblTraitsGNatured = New System.Windows.Forms.Label()
        Me.LblTraitsJinxed = New System.Windows.Forms.Label()
        Me.LblTraitsBlMess = New System.Windows.Forms.Label()
        Me.LblTraitsFShot = New System.Windows.Forms.Label()
        Me.LblTraitsHHanded = New System.Windows.Forms.Label()
        Me.LblTraitsKamikaze = New System.Windows.Forms.Label()
        Me.LblTraitsFinesse = New System.Windows.Forms.Label()
        Me.LblTraitsOHanded = New System.Windows.Forms.Label()
        Me.LblTraitsSFrame = New System.Windows.Forms.Label()
        Me.LblTraitsFastMeta = New System.Windows.Forms.Label()
        Me.LblTraitsBruiser = New System.Windows.Forms.Label()
        Me.PicDesc = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblHitPoints = New System.Windows.Forms.Label()
        Me.PanStatistics = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblCritChVal = New System.Windows.Forms.Label()
        Me.LblHealRVal = New System.Windows.Forms.Label()
        Me.LblSeqVal = New System.Windows.Forms.Label()
        Me.LblRadResVal = New System.Windows.Forms.Label()
        Me.LblPoisonResVal = New System.Windows.Forms.Label()
        Me.LblDmgResVal = New System.Windows.Forms.Label()
        Me.LblMDmgVal = New System.Windows.Forms.Label()
        Me.LblCWVal = New System.Windows.Forms.Label()
        Me.LblAPointsVal = New System.Windows.Forms.Label()
        Me.LblAClassVal = New System.Windows.Forms.Label()
        Me.LblCritCh = New System.Windows.Forms.Label()
        Me.LblHealingR = New System.Windows.Forms.Label()
        Me.LblSequence = New System.Windows.Forms.Label()
        Me.LblMeleeDmg = New System.Windows.Forms.Label()
        Me.LblRadRes = New System.Windows.Forms.Label()
        Me.LblActionP = New System.Windows.Forms.Label()
        Me.LblPoisonRes = New System.Windows.Forms.Label()
        Me.LblAClass = New System.Windows.Forms.Label()
        Me.LblDmgRes = New System.Windows.Forms.Label()
        Me.LblCWeight = New System.Windows.Forms.Label()
        Me.LblSpecial = New System.Windows.Forms.Label()
        Me.PanSkills = New System.Windows.Forms.Panel()
        Me.LblODVal = New System.Windows.Forms.Label()
        Me.LblGamblVal = New System.Windows.Forms.Label()
        Me.LblBarterVal = New System.Windows.Forms.Label()
        Me.LblSpeechVal = New System.Windows.Forms.Label()
        Me.LblRepairVal = New System.Windows.Forms.Label()
        Me.LblScienceVal = New System.Windows.Forms.Label()
        Me.LblTrapsVal = New System.Windows.Forms.Label()
        Me.LblStealVal = New System.Windows.Forms.Label()
        Me.LblLPickVal = New System.Windows.Forms.Label()
        Me.LblSneakVal = New System.Windows.Forms.Label()
        Me.LblDocVal = New System.Windows.Forms.Label()
        Me.LblFaidVal = New System.Windows.Forms.Label()
        Me.LblThrowVal = New System.Windows.Forms.Label()
        Me.LblScavenVal = New System.Windows.Forms.Label()
        Me.LblCCombVal = New System.Windows.Forms.Label()
        Me.LblEWeaponsVal = New System.Windows.Forms.Label()
        Me.LblBGunsVal = New System.Windows.Forms.Label()
        Me.LblSGunsVal = New System.Windows.Forms.Label()
        Me.LblRepair = New System.Windows.Forms.Label()
        Me.LblGambling = New System.Windows.Forms.Label()
        Me.LblLPick = New System.Windows.Forms.Label()
        Me.LblSneak = New System.Windows.Forms.Label()
        Me.LblDoctor = New System.Windows.Forms.Label()
        Me.LblScavenge = New System.Windows.Forms.Label()
        Me.LblBGuns = New System.Windows.Forms.Label()
        Me.LblSGuns = New System.Windows.Forms.Label()
        Me.LblEWeapons = New System.Windows.Forms.Label()
        Me.LblCCombat = New System.Windows.Forms.Label()
        Me.LblThrow = New System.Windows.Forms.Label()
        Me.LblFAid = New System.Windows.Forms.Label()
        Me.LblSteal = New System.Windows.Forms.Label()
        Me.LblTraps = New System.Windows.Forms.Label()
        Me.LblScience = New System.Windows.Forms.Label()
        Me.LblSpeech = New System.Windows.Forms.Label()
        Me.LblBarter = New System.Windows.Forms.Label()
        Me.LblODMan = New System.Windows.Forms.Label()
        Me.LblSkills = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblTagSkills = New System.Windows.Forms.Label()
        Me.LblSkPoints = New System.Windows.Forms.Label()
        Me.LblSkPointsVal = New System.Windows.Forms.Label()
        Me.PanLvlInfo = New System.Windows.Forms.Panel()
        Me.LblLevelVal = New System.Windows.Forms.Label()
        Me.LblLvl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblGenDescr = New System.Windows.Forms.Label()
        Me.PanDetDesc = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanNormDesc = New System.Windows.Forms.Panel()
        Me.LstBoxPerks = New System.Windows.Forms.ListBox()
        Me.BtnLvlUp = New System.Windows.Forms.Button()
        Me.CBoxBooks = New System.Windows.Forms.ComboBox()
        Me.PanDetText = New System.Windows.Forms.Panel()
        Me.LblDetDescrText = New System.Windows.Forms.Label()
        Me.LblDetDesc = New System.Windows.Forms.Label()
        Me.PanStatsSightACrit = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblACritVal = New System.Windows.Forms.Label()
        Me.LblAntiCrit = New System.Windows.Forms.Label()
        Me.LblSightVal = New System.Windows.Forms.Label()
        Me.LblSight = New System.Windows.Forms.Label()
        Me.BtnLvlFastUp = New System.Windows.Forms.Button()
        Me.BtnLvlFastDwn = New System.Windows.Forms.Button()
        Me.BtnLvlDwn = New System.Windows.Forms.Button()
        Me.BtnMusicVolDown = New System.Windows.Forms.Button()
        Me.BtnMusicVolUp = New System.Windows.Forms.Button()
        Me.BtnDrugsCigs = New System.Windows.Forms.Button()
        Me.BtnDrugsNuka = New System.Windows.Forms.Button()
        Me.BtnDrugsPsycho = New System.Windows.Forms.Button()
        Me.BtnDrugsBuff = New System.Windows.Forms.Button()
        Me.BtnDrugsJet = New System.Windows.Forms.Button()
        Me.BtnAllDrugs = New System.Windows.Forms.Button()
        Me.BtnMscStop = New System.Windows.Forms.Button()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.LstVPerks = New System.Windows.Forms.ListView()
        Me.LblLevel = New System.Windows.Forms.Label()
        Me.LblCBoxBooks = New System.Windows.Forms.Label()
        Me.LblPTraitsTaken = New System.Windows.Forms.Label()
        Me.LblPerks = New System.Windows.Forms.Label()
        Me.BtnSkUp = New System.Windows.Forms.Button()
        Me.BtnSkDown = New System.Windows.Forms.Button()
        Me.PanSkUpDown = New System.Windows.Forms.Panel()
        Me.BtnPerkLater = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveBuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadBuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicToolStrMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBooks = New System.Windows.Forms.Button()
        Me.BtnImpl = New System.Windows.Forms.Button()
        Me.BtnQuests = New System.Windows.Forms.Button()
        Me.BtnAchievem = New System.Windows.Forms.Button()
        Me.LstVBooks = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBookValDown = New System.Windows.Forms.Button()
        Me.BtnBookValUp = New System.Windows.Forms.Button()
        Me.LblBookAmVal = New System.Windows.Forms.Label()
        Me.LblBookAmount = New System.Windows.Forms.Label()
        Me.BtnBookDone = New System.Windows.Forms.Button()
        Me.LblBooks = New System.Windows.Forms.Label()
        Me.PanBookValEdit = New System.Windows.Forms.Panel()
        Me.LblDetailedDesc = New System.Windows.Forms.Label()
        Me.LblBMentats = New System.Windows.Forms.Label()
        Me.LblImpl = New System.Windows.Forms.Label()
        Me.LstVImpl = New System.Windows.Forms.ListView()
        Me.LstVQuests = New System.Windows.Forms.ListView()
        Me.LblQuests = New System.Windows.Forms.Label()
        Me.LstVAchiev = New System.Windows.Forms.ListView()
        Me.LblAchieve = New System.Windows.Forms.Label()
        Me.LstVChess = New System.Windows.Forms.ListView()
        Me.LblChessRew = New System.Windows.Forms.Label()
        Me.BtnBooksAll = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnMscPlay = New System.Windows.Forms.Button()
        Me.BtnMscSkip = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblTODocVal = New System.Windows.Forms.Label()
        Me.LblTOFAVal = New System.Windows.Forms.Label()
        Me.LblTODoc = New System.Windows.Forms.Label()
        Me.LblTOFA = New System.Windows.Forms.Label()
        Me.LblTimeouts = New System.Windows.Forms.Label()
        Me.LblMusicLenghtSec = New System.Windows.Forms.Label()
        Me.LblMusicLenghtMin = New System.Windows.Forms.Label()
        Me.LblMusicNPlay = New System.Windows.Forms.Label()
        Me.LblMusicTElap = New System.Windows.Forms.Label()
        Me.TxtBMusicText = New System.Windows.Forms.TextBox()
        Me.PicBoxMusicVol = New System.Windows.Forms.PictureBox()
        Me.PanDrugs = New System.Windows.Forms.Panel()
        Me.LblDrugs = New System.Windows.Forms.Label()
        Me.PanStats.SuspendLayout()
        Me.CPointsPan.SuspendLayout()
        Me.PanTraits.SuspendLayout()
        CType(Me.PicDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanStatistics.SuspendLayout()
        Me.PanSkills.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanLvlInfo.SuspendLayout()
        Me.PanDetText.SuspendLayout()
        Me.PanStatsSightACrit.SuspendLayout()
        Me.PanSkUpDown.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.PanBookValEdit.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PicBoxMusicVol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanDrugs.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblStatsST
        '
        Me.LblStatsST.AutoSize = True
        Me.LblStatsST.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsST.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStatsST.Location = New System.Drawing.Point(10, 13)
        Me.LblStatsST.Name = "LblStatsST"
        Me.LblStatsST.Size = New System.Drawing.Size(30, 19)
        Me.LblStatsST.TabIndex = 0
        Me.LblStatsST.Text = "ST"
        '
        'LblStatsPE
        '
        Me.LblStatsPE.AutoSize = True
        Me.LblStatsPE.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsPE.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsPE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStatsPE.Location = New System.Drawing.Point(10, 41)
        Me.LblStatsPE.Name = "LblStatsPE"
        Me.LblStatsPE.Size = New System.Drawing.Size(30, 19)
        Me.LblStatsPE.TabIndex = 1
        Me.LblStatsPE.Text = "PE"
        '
        'LblStatsEN
        '
        Me.LblStatsEN.AutoSize = True
        Me.LblStatsEN.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsEN.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsEN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStatsEN.Location = New System.Drawing.Point(10, 69)
        Me.LblStatsEN.Name = "LblStatsEN"
        Me.LblStatsEN.Size = New System.Drawing.Size(31, 19)
        Me.LblStatsEN.TabIndex = 2
        Me.LblStatsEN.Text = "EN"
        '
        'LblStatsCH
        '
        Me.LblStatsCH.AutoSize = True
        Me.LblStatsCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsCH.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStatsCH.Location = New System.Drawing.Point(10, 97)
        Me.LblStatsCH.Name = "LblStatsCH"
        Me.LblStatsCH.Size = New System.Drawing.Size(32, 19)
        Me.LblStatsCH.TabIndex = 3
        Me.LblStatsCH.Text = "CH"
        '
        'LblStatsIN
        '
        Me.LblStatsIN.AutoSize = True
        Me.LblStatsIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsIN.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStatsIN.Location = New System.Drawing.Point(10, 125)
        Me.LblStatsIN.Name = "LblStatsIN"
        Me.LblStatsIN.Size = New System.Drawing.Size(28, 19)
        Me.LblStatsIN.TabIndex = 4
        Me.LblStatsIN.Text = "IN"
        '
        'LblStatsAG
        '
        Me.LblStatsAG.AutoSize = True
        Me.LblStatsAG.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsAG.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsAG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStatsAG.Location = New System.Drawing.Point(10, 153)
        Me.LblStatsAG.Name = "LblStatsAG"
        Me.LblStatsAG.Size = New System.Drawing.Size(33, 19)
        Me.LblStatsAG.TabIndex = 5
        Me.LblStatsAG.Text = "AG"
        '
        'LblStatsLK
        '
        Me.LblStatsLK.AutoSize = True
        Me.LblStatsLK.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsLK.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsLK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStatsLK.Location = New System.Drawing.Point(10, 181)
        Me.LblStatsLK.Name = "LblStatsLK"
        Me.LblStatsLK.Size = New System.Drawing.Size(29, 19)
        Me.LblStatsLK.TabIndex = 6
        Me.LblStatsLK.Text = "LK"
        '
        'PanStats
        '
        Me.PanStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanStats.Controls.Add(Me.BtnStatsLKDown)
        Me.PanStats.Controls.Add(Me.BtnStatsLKUp)
        Me.PanStats.Controls.Add(Me.BtnStatsAGDown)
        Me.PanStats.Controls.Add(Me.BtnStatsAGUp)
        Me.PanStats.Controls.Add(Me.BtnStatsINDown)
        Me.PanStats.Controls.Add(Me.BtnStatsINUp)
        Me.PanStats.Controls.Add(Me.BtnStatsCHDown)
        Me.PanStats.Controls.Add(Me.BtnStatsCHUp)
        Me.PanStats.Controls.Add(Me.BtnStatsENDown)
        Me.PanStats.Controls.Add(Me.BtnStatsENUp)
        Me.PanStats.Controls.Add(Me.BtnStatsPEDown)
        Me.PanStats.Controls.Add(Me.BtnStatsPEUp)
        Me.PanStats.Controls.Add(Me.BtnStatsSTDown)
        Me.PanStats.Controls.Add(Me.BtnStatsSTUp)
        Me.PanStats.Controls.Add(Me.LblStatsLKVal)
        Me.PanStats.Controls.Add(Me.LblStatsAGVal)
        Me.PanStats.Controls.Add(Me.LblStatsINVal)
        Me.PanStats.Controls.Add(Me.LblStatsCHVal)
        Me.PanStats.Controls.Add(Me.LblStatsENVal)
        Me.PanStats.Controls.Add(Me.LblStatsPEVal)
        Me.PanStats.Controls.Add(Me.LblStatsSTVal)
        Me.PanStats.Controls.Add(Me.LblStatsST)
        Me.PanStats.Controls.Add(Me.LblStatsEN)
        Me.PanStats.Controls.Add(Me.LblStatsLK)
        Me.PanStats.Controls.Add(Me.LblStatsCH)
        Me.PanStats.Controls.Add(Me.LblStatsAG)
        Me.PanStats.Controls.Add(Me.LblStatsIN)
        Me.PanStats.Controls.Add(Me.LblStatsPE)
        Me.PanStats.ForeColor = System.Drawing.Color.Black
        Me.PanStats.Location = New System.Drawing.Point(17, 57)
        Me.PanStats.Name = "PanStats"
        Me.PanStats.Size = New System.Drawing.Size(117, 218)
        Me.PanStats.TabIndex = 16
        '
        'BtnStatsLKDown
        '
        Me.BtnStatsLKDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsLKDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsLKDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsLKDown.FlatAppearance.BorderSize = 0
        Me.BtnStatsLKDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsLKDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsLKDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsLKDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsLKDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsLKDown.Location = New System.Drawing.Point(70, 184)
        Me.BtnStatsLKDown.Name = "BtnStatsLKDown"
        Me.BtnStatsLKDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsLKDown.TabIndex = 43
        Me.BtnStatsLKDown.Text = "-"
        Me.BtnStatsLKDown.UseCompatibleTextRendering = True
        Me.BtnStatsLKDown.UseVisualStyleBackColor = False
        '
        'BtnStatsLKUp
        '
        Me.BtnStatsLKUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsLKUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsLKUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsLKUp.FlatAppearance.BorderSize = 0
        Me.BtnStatsLKUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsLKUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsLKUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsLKUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsLKUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsLKUp.Location = New System.Drawing.Point(88, 184)
        Me.BtnStatsLKUp.Name = "BtnStatsLKUp"
        Me.BtnStatsLKUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsLKUp.TabIndex = 42
        Me.BtnStatsLKUp.Text = "+"
        Me.BtnStatsLKUp.UseCompatibleTextRendering = True
        Me.BtnStatsLKUp.UseVisualStyleBackColor = False
        '
        'BtnStatsAGDown
        '
        Me.BtnStatsAGDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsAGDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsAGDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsAGDown.FlatAppearance.BorderSize = 0
        Me.BtnStatsAGDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsAGDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsAGDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsAGDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsAGDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsAGDown.Location = New System.Drawing.Point(70, 156)
        Me.BtnStatsAGDown.Name = "BtnStatsAGDown"
        Me.BtnStatsAGDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsAGDown.TabIndex = 41
        Me.BtnStatsAGDown.Text = "-"
        Me.BtnStatsAGDown.UseCompatibleTextRendering = True
        Me.BtnStatsAGDown.UseVisualStyleBackColor = False
        '
        'BtnStatsAGUp
        '
        Me.BtnStatsAGUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsAGUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsAGUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsAGUp.FlatAppearance.BorderSize = 0
        Me.BtnStatsAGUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsAGUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsAGUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsAGUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsAGUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsAGUp.Location = New System.Drawing.Point(88, 156)
        Me.BtnStatsAGUp.Name = "BtnStatsAGUp"
        Me.BtnStatsAGUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsAGUp.TabIndex = 40
        Me.BtnStatsAGUp.Text = "+"
        Me.BtnStatsAGUp.UseCompatibleTextRendering = True
        Me.BtnStatsAGUp.UseVisualStyleBackColor = False
        '
        'BtnStatsINDown
        '
        Me.BtnStatsINDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsINDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsINDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsINDown.FlatAppearance.BorderSize = 0
        Me.BtnStatsINDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsINDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsINDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsINDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsINDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsINDown.Location = New System.Drawing.Point(70, 128)
        Me.BtnStatsINDown.Name = "BtnStatsINDown"
        Me.BtnStatsINDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsINDown.TabIndex = 39
        Me.BtnStatsINDown.Text = "-"
        Me.BtnStatsINDown.UseCompatibleTextRendering = True
        Me.BtnStatsINDown.UseVisualStyleBackColor = False
        '
        'BtnStatsINUp
        '
        Me.BtnStatsINUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsINUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsINUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsINUp.FlatAppearance.BorderSize = 0
        Me.BtnStatsINUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsINUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsINUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsINUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsINUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsINUp.Location = New System.Drawing.Point(88, 128)
        Me.BtnStatsINUp.Name = "BtnStatsINUp"
        Me.BtnStatsINUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsINUp.TabIndex = 38
        Me.BtnStatsINUp.Text = "+"
        Me.BtnStatsINUp.UseCompatibleTextRendering = True
        Me.BtnStatsINUp.UseVisualStyleBackColor = False
        '
        'BtnStatsCHDown
        '
        Me.BtnStatsCHDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsCHDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsCHDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsCHDown.FlatAppearance.BorderSize = 0
        Me.BtnStatsCHDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsCHDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsCHDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsCHDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsCHDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsCHDown.Location = New System.Drawing.Point(70, 100)
        Me.BtnStatsCHDown.Name = "BtnStatsCHDown"
        Me.BtnStatsCHDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsCHDown.TabIndex = 37
        Me.BtnStatsCHDown.Text = "-"
        Me.BtnStatsCHDown.UseCompatibleTextRendering = True
        Me.BtnStatsCHDown.UseVisualStyleBackColor = False
        '
        'BtnStatsCHUp
        '
        Me.BtnStatsCHUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsCHUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsCHUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsCHUp.FlatAppearance.BorderSize = 0
        Me.BtnStatsCHUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsCHUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsCHUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsCHUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsCHUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsCHUp.Location = New System.Drawing.Point(88, 100)
        Me.BtnStatsCHUp.Name = "BtnStatsCHUp"
        Me.BtnStatsCHUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsCHUp.TabIndex = 36
        Me.BtnStatsCHUp.Text = "+"
        Me.BtnStatsCHUp.UseCompatibleTextRendering = True
        Me.BtnStatsCHUp.UseVisualStyleBackColor = False
        '
        'BtnStatsENDown
        '
        Me.BtnStatsENDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsENDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsENDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsENDown.FlatAppearance.BorderSize = 0
        Me.BtnStatsENDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsENDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsENDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsENDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsENDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsENDown.Location = New System.Drawing.Point(70, 72)
        Me.BtnStatsENDown.Name = "BtnStatsENDown"
        Me.BtnStatsENDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsENDown.TabIndex = 35
        Me.BtnStatsENDown.Text = "-"
        Me.BtnStatsENDown.UseCompatibleTextRendering = True
        Me.BtnStatsENDown.UseVisualStyleBackColor = False
        '
        'BtnStatsENUp
        '
        Me.BtnStatsENUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsENUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsENUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsENUp.FlatAppearance.BorderSize = 0
        Me.BtnStatsENUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsENUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsENUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsENUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsENUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsENUp.Location = New System.Drawing.Point(88, 72)
        Me.BtnStatsENUp.Name = "BtnStatsENUp"
        Me.BtnStatsENUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsENUp.TabIndex = 34
        Me.BtnStatsENUp.Text = "+"
        Me.BtnStatsENUp.UseCompatibleTextRendering = True
        Me.BtnStatsENUp.UseVisualStyleBackColor = False
        '
        'BtnStatsPEDown
        '
        Me.BtnStatsPEDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsPEDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsPEDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsPEDown.FlatAppearance.BorderSize = 0
        Me.BtnStatsPEDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsPEDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsPEDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsPEDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsPEDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsPEDown.Location = New System.Drawing.Point(70, 44)
        Me.BtnStatsPEDown.Name = "BtnStatsPEDown"
        Me.BtnStatsPEDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsPEDown.TabIndex = 33
        Me.BtnStatsPEDown.Text = "-"
        Me.BtnStatsPEDown.UseCompatibleTextRendering = True
        Me.BtnStatsPEDown.UseVisualStyleBackColor = False
        '
        'BtnStatsPEUp
        '
        Me.BtnStatsPEUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsPEUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsPEUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsPEUp.FlatAppearance.BorderSize = 0
        Me.BtnStatsPEUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsPEUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsPEUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsPEUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsPEUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsPEUp.Location = New System.Drawing.Point(88, 44)
        Me.BtnStatsPEUp.Name = "BtnStatsPEUp"
        Me.BtnStatsPEUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsPEUp.TabIndex = 32
        Me.BtnStatsPEUp.Text = "+"
        Me.BtnStatsPEUp.UseCompatibleTextRendering = True
        Me.BtnStatsPEUp.UseVisualStyleBackColor = False
        '
        'BtnStatsSTDown
        '
        Me.BtnStatsSTDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsSTDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsSTDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsSTDown.FlatAppearance.BorderSize = 0
        Me.BtnStatsSTDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsSTDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsSTDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsSTDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsSTDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsSTDown.Location = New System.Drawing.Point(70, 16)
        Me.BtnStatsSTDown.Name = "BtnStatsSTDown"
        Me.BtnStatsSTDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsSTDown.TabIndex = 31
        Me.BtnStatsSTDown.Text = "-"
        Me.BtnStatsSTDown.UseCompatibleTextRendering = True
        Me.BtnStatsSTDown.UseVisualStyleBackColor = False
        '
        'BtnStatsSTUp
        '
        Me.BtnStatsSTUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnStatsSTUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatsSTUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnStatsSTUp.FlatAppearance.BorderSize = 0
        Me.BtnStatsSTUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnStatsSTUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnStatsSTUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatsSTUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatsSTUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnStatsSTUp.Location = New System.Drawing.Point(88, 16)
        Me.BtnStatsSTUp.Name = "BtnStatsSTUp"
        Me.BtnStatsSTUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnStatsSTUp.TabIndex = 30
        Me.BtnStatsSTUp.Text = "+"
        Me.BtnStatsSTUp.UseCompatibleTextRendering = True
        Me.BtnStatsSTUp.UseVisualStyleBackColor = False
        '
        'LblStatsLKVal
        '
        Me.LblStatsLKVal.AutoSize = True
        Me.LblStatsLKVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsLKVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsLKVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStatsLKVal.Location = New System.Drawing.Point(45, 182)
        Me.LblStatsLKVal.Name = "LblStatsLKVal"
        Me.LblStatsLKVal.Size = New System.Drawing.Size(18, 18)
        Me.LblStatsLKVal.TabIndex = 28
        Me.LblStatsLKVal.Text = "5"
        '
        'LblStatsAGVal
        '
        Me.LblStatsAGVal.AutoSize = True
        Me.LblStatsAGVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsAGVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsAGVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStatsAGVal.Location = New System.Drawing.Point(46, 154)
        Me.LblStatsAGVal.Name = "LblStatsAGVal"
        Me.LblStatsAGVal.Size = New System.Drawing.Size(18, 18)
        Me.LblStatsAGVal.TabIndex = 27
        Me.LblStatsAGVal.Text = "5"
        '
        'LblStatsINVal
        '
        Me.LblStatsINVal.AutoSize = True
        Me.LblStatsINVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsINVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsINVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStatsINVal.Location = New System.Drawing.Point(46, 126)
        Me.LblStatsINVal.Name = "LblStatsINVal"
        Me.LblStatsINVal.Size = New System.Drawing.Size(18, 18)
        Me.LblStatsINVal.TabIndex = 26
        Me.LblStatsINVal.Text = "5"
        '
        'LblStatsCHVal
        '
        Me.LblStatsCHVal.AutoSize = True
        Me.LblStatsCHVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsCHVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsCHVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStatsCHVal.Location = New System.Drawing.Point(46, 98)
        Me.LblStatsCHVal.Name = "LblStatsCHVal"
        Me.LblStatsCHVal.Size = New System.Drawing.Size(18, 18)
        Me.LblStatsCHVal.TabIndex = 25
        Me.LblStatsCHVal.Text = "5"
        '
        'LblStatsENVal
        '
        Me.LblStatsENVal.AutoSize = True
        Me.LblStatsENVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsENVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsENVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStatsENVal.Location = New System.Drawing.Point(46, 70)
        Me.LblStatsENVal.Name = "LblStatsENVal"
        Me.LblStatsENVal.Size = New System.Drawing.Size(18, 18)
        Me.LblStatsENVal.TabIndex = 24
        Me.LblStatsENVal.Text = "5"
        '
        'LblStatsPEVal
        '
        Me.LblStatsPEVal.AutoSize = True
        Me.LblStatsPEVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsPEVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsPEVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStatsPEVal.Location = New System.Drawing.Point(46, 42)
        Me.LblStatsPEVal.Name = "LblStatsPEVal"
        Me.LblStatsPEVal.Size = New System.Drawing.Size(18, 18)
        Me.LblStatsPEVal.TabIndex = 23
        Me.LblStatsPEVal.Text = "5"
        '
        'LblStatsSTVal
        '
        Me.LblStatsSTVal.AutoSize = True
        Me.LblStatsSTVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblStatsSTVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsSTVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStatsSTVal.Location = New System.Drawing.Point(46, 14)
        Me.LblStatsSTVal.Name = "LblStatsSTVal"
        Me.LblStatsSTVal.Size = New System.Drawing.Size(18, 18)
        Me.LblStatsSTVal.TabIndex = 22
        Me.LblStatsSTVal.Text = "5"
        '
        'LblStatsHead
        '
        Me.LblStatsHead.AutoSize = True
        Me.LblStatsHead.BackColor = System.Drawing.Color.Transparent
        Me.LblStatsHead.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatsHead.ForeColor = System.Drawing.Color.Gold
        Me.LblStatsHead.Location = New System.Drawing.Point(143, 38)
        Me.LblStatsHead.Name = "LblStatsHead"
        Me.LblStatsHead.Size = New System.Drawing.Size(43, 16)
        Me.LblStatsHead.TabIndex = 17
        Me.LblStatsHead.Text = "Stats"
        '
        'CPointsPan
        '
        Me.CPointsPan.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.CPointsPan.Controls.Add(Me.LblCPointsHead)
        Me.CPointsPan.Controls.Add(Me.LblCPoints)
        Me.CPointsPan.ForeColor = System.Drawing.Color.Black
        Me.CPointsPan.Location = New System.Drawing.Point(17, 281)
        Me.CPointsPan.Name = "CPointsPan"
        Me.CPointsPan.Size = New System.Drawing.Size(117, 56)
        Me.CPointsPan.TabIndex = 20
        '
        'LblCPointsHead
        '
        Me.LblCPointsHead.AutoSize = True
        Me.LblCPointsHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblCPointsHead.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCPointsHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblCPointsHead.Location = New System.Drawing.Point(15, 8)
        Me.LblCPointsHead.Name = "LblCPointsHead"
        Me.LblCPointsHead.Size = New System.Drawing.Size(89, 16)
        Me.LblCPointsHead.TabIndex = 21
        Me.LblCPointsHead.Text = "CHARPOINTS"
        '
        'LblCPoints
        '
        Me.LblCPoints.AutoSize = True
        Me.LblCPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblCPoints.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCPoints.ForeColor = System.Drawing.Color.DarkOrange
        Me.LblCPoints.Location = New System.Drawing.Point(46, 29)
        Me.LblCPoints.Name = "LblCPoints"
        Me.LblCPoints.Size = New System.Drawing.Size(18, 18)
        Me.LblCPoints.TabIndex = 21
        Me.LblCPoints.Text = "5"
        '
        'PanTraits
        '
        Me.PanTraits.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanTraits.Controls.Add(Me.LblTraitsEvader)
        Me.PanTraits.Controls.Add(Me.LblTraitsMutant)
        Me.PanTraits.Controls.Add(Me.LblTraitsBHead)
        Me.PanTraits.Controls.Add(Me.LblTraitsCRes)
        Me.PanTraits.Controls.Add(Me.LblTraitsCRel)
        Me.PanTraits.Controls.Add(Me.LblTraitsGNatured)
        Me.PanTraits.Controls.Add(Me.LblTraitsJinxed)
        Me.PanTraits.Controls.Add(Me.LblTraitsBlMess)
        Me.PanTraits.Controls.Add(Me.LblTraitsFShot)
        Me.PanTraits.Controls.Add(Me.LblTraitsHHanded)
        Me.PanTraits.Controls.Add(Me.LblTraitsKamikaze)
        Me.PanTraits.Controls.Add(Me.LblTraitsFinesse)
        Me.PanTraits.Controls.Add(Me.LblTraitsOHanded)
        Me.PanTraits.Controls.Add(Me.LblTraitsSFrame)
        Me.PanTraits.Controls.Add(Me.LblTraitsFastMeta)
        Me.PanTraits.Controls.Add(Me.LblTraitsBruiser)
        Me.PanTraits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanTraits.ForeColor = System.Drawing.Color.Black
        Me.PanTraits.Location = New System.Drawing.Point(17, 425)
        Me.PanTraits.Name = "PanTraits"
        Me.PanTraits.Size = New System.Drawing.Size(213, 130)
        Me.PanTraits.TabIndex = 22
        '
        'LblTraitsEvader
        '
        Me.LblTraitsEvader.AutoSize = True
        Me.LblTraitsEvader.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsEvader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsEvader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsEvader.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsEvader.Location = New System.Drawing.Point(111, 109)
        Me.LblTraitsEvader.Name = "LblTraitsEvader"
        Me.LblTraitsEvader.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsEvader.Size = New System.Drawing.Size(50, 15)
        Me.LblTraitsEvader.TabIndex = 39
        Me.LblTraitsEvader.Text = "Evader"
        '
        'LblTraitsMutant
        '
        Me.LblTraitsMutant.AutoSize = True
        Me.LblTraitsMutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsMutant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsMutant.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsMutant.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsMutant.Location = New System.Drawing.Point(111, 94)
        Me.LblTraitsMutant.Name = "LblTraitsMutant"
        Me.LblTraitsMutant.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsMutant.Size = New System.Drawing.Size(52, 15)
        Me.LblTraitsMutant.TabIndex = 38
        Me.LblTraitsMutant.Text = "Mutant"
        '
        'LblTraitsBHead
        '
        Me.LblTraitsBHead.AutoSize = True
        Me.LblTraitsBHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsBHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsBHead.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsBHead.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsBHead.Location = New System.Drawing.Point(111, 79)
        Me.LblTraitsBHead.Name = "LblTraitsBHead"
        Me.LblTraitsBHead.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsBHead.Size = New System.Drawing.Size(67, 15)
        Me.LblTraitsBHead.TabIndex = 37
        Me.LblTraitsBHead.Text = "Bonehead"
        '
        'LblTraitsCRes
        '
        Me.LblTraitsCRes.AutoSize = True
        Me.LblTraitsCRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsCRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsCRes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsCRes.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsCRes.Location = New System.Drawing.Point(111, 64)
        Me.LblTraitsCRes.Name = "LblTraitsCRes"
        Me.LblTraitsCRes.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsCRes.Size = New System.Drawing.Size(100, 15)
        Me.LblTraitsCRes.TabIndex = 36
        Me.LblTraitsCRes.Text = "Chem Resistant"
        '
        'LblTraitsCRel
        '
        Me.LblTraitsCRel.AutoSize = True
        Me.LblTraitsCRel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsCRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsCRel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsCRel.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsCRel.Location = New System.Drawing.Point(111, 49)
        Me.LblTraitsCRel.Name = "LblTraitsCRel"
        Me.LblTraitsCRel.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsCRel.Size = New System.Drawing.Size(86, 15)
        Me.LblTraitsCRel.TabIndex = 35
        Me.LblTraitsCRel.Text = "Chem Reliant"
        '
        'LblTraitsGNatured
        '
        Me.LblTraitsGNatured.AutoSize = True
        Me.LblTraitsGNatured.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsGNatured.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsGNatured.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsGNatured.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsGNatured.Location = New System.Drawing.Point(111, 34)
        Me.LblTraitsGNatured.Name = "LblTraitsGNatured"
        Me.LblTraitsGNatured.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsGNatured.Size = New System.Drawing.Size(88, 15)
        Me.LblTraitsGNatured.TabIndex = 34
        Me.LblTraitsGNatured.Text = "Good Natured"
        '
        'LblTraitsJinxed
        '
        Me.LblTraitsJinxed.AutoSize = True
        Me.LblTraitsJinxed.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsJinxed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsJinxed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsJinxed.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsJinxed.Location = New System.Drawing.Point(111, 19)
        Me.LblTraitsJinxed.Name = "LblTraitsJinxed"
        Me.LblTraitsJinxed.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsJinxed.Size = New System.Drawing.Size(48, 15)
        Me.LblTraitsJinxed.TabIndex = 33
        Me.LblTraitsJinxed.Text = "Jinxed"
        '
        'LblTraitsBlMess
        '
        Me.LblTraitsBlMess.AutoSize = True
        Me.LblTraitsBlMess.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsBlMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsBlMess.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsBlMess.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsBlMess.Location = New System.Drawing.Point(111, 4)
        Me.LblTraitsBlMess.Name = "LblTraitsBlMess"
        Me.LblTraitsBlMess.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsBlMess.Size = New System.Drawing.Size(81, 15)
        Me.LblTraitsBlMess.TabIndex = 32
        Me.LblTraitsBlMess.Text = "Bloody Mess"
        '
        'LblTraitsFShot
        '
        Me.LblTraitsFShot.AutoSize = True
        Me.LblTraitsFShot.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsFShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsFShot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsFShot.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsFShot.Location = New System.Drawing.Point(3, 109)
        Me.LblTraitsFShot.Name = "LblTraitsFShot"
        Me.LblTraitsFShot.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsFShot.Size = New System.Drawing.Size(64, 15)
        Me.LblTraitsFShot.TabIndex = 31
        Me.LblTraitsFShot.Text = "Fast Shot"
        '
        'LblTraitsHHanded
        '
        Me.LblTraitsHHanded.AutoSize = True
        Me.LblTraitsHHanded.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsHHanded.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsHHanded.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsHHanded.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsHHanded.Location = New System.Drawing.Point(3, 94)
        Me.LblTraitsHHanded.Name = "LblTraitsHHanded"
        Me.LblTraitsHHanded.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsHHanded.Size = New System.Drawing.Size(93, 15)
        Me.LblTraitsHHanded.TabIndex = 30
        Me.LblTraitsHHanded.Text = "Heavy Handed"
        '
        'LblTraitsKamikaze
        '
        Me.LblTraitsKamikaze.AutoSize = True
        Me.LblTraitsKamikaze.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsKamikaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsKamikaze.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsKamikaze.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsKamikaze.Location = New System.Drawing.Point(3, 79)
        Me.LblTraitsKamikaze.Name = "LblTraitsKamikaze"
        Me.LblTraitsKamikaze.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsKamikaze.Size = New System.Drawing.Size(66, 15)
        Me.LblTraitsKamikaze.TabIndex = 29
        Me.LblTraitsKamikaze.Text = "Kamikaze"
        '
        'LblTraitsFinesse
        '
        Me.LblTraitsFinesse.AutoSize = True
        Me.LblTraitsFinesse.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsFinesse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsFinesse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsFinesse.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsFinesse.Location = New System.Drawing.Point(3, 64)
        Me.LblTraitsFinesse.Name = "LblTraitsFinesse"
        Me.LblTraitsFinesse.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsFinesse.Size = New System.Drawing.Size(53, 15)
        Me.LblTraitsFinesse.TabIndex = 28
        Me.LblTraitsFinesse.Text = "Finesse"
        '
        'LblTraitsOHanded
        '
        Me.LblTraitsOHanded.AutoSize = True
        Me.LblTraitsOHanded.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsOHanded.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsOHanded.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsOHanded.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsOHanded.Location = New System.Drawing.Point(3, 49)
        Me.LblTraitsOHanded.Name = "LblTraitsOHanded"
        Me.LblTraitsOHanded.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsOHanded.Size = New System.Drawing.Size(78, 15)
        Me.LblTraitsOHanded.TabIndex = 27
        Me.LblTraitsOHanded.Text = "One handed"
        '
        'LblTraitsSFrame
        '
        Me.LblTraitsSFrame.AutoSize = True
        Me.LblTraitsSFrame.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsSFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsSFrame.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsSFrame.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsSFrame.Location = New System.Drawing.Point(3, 34)
        Me.LblTraitsSFrame.Name = "LblTraitsSFrame"
        Me.LblTraitsSFrame.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsSFrame.Size = New System.Drawing.Size(81, 15)
        Me.LblTraitsSFrame.TabIndex = 26
        Me.LblTraitsSFrame.Text = "Small Frame"
        '
        'LblTraitsFastMeta
        '
        Me.LblTraitsFastMeta.AutoSize = True
        Me.LblTraitsFastMeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsFastMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsFastMeta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsFastMeta.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsFastMeta.Location = New System.Drawing.Point(3, 4)
        Me.LblTraitsFastMeta.Name = "LblTraitsFastMeta"
        Me.LblTraitsFastMeta.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsFastMeta.Size = New System.Drawing.Size(104, 15)
        Me.LblTraitsFastMeta.TabIndex = 24
        Me.LblTraitsFastMeta.Text = "Fast Metabolism"
        '
        'LblTraitsBruiser
        '
        Me.LblTraitsBruiser.AutoSize = True
        Me.LblTraitsBruiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraitsBruiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraitsBruiser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraitsBruiser.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraitsBruiser.Location = New System.Drawing.Point(3, 19)
        Me.LblTraitsBruiser.Name = "LblTraitsBruiser"
        Me.LblTraitsBruiser.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraitsBruiser.Size = New System.Drawing.Size(51, 15)
        Me.LblTraitsBruiser.TabIndex = 25
        Me.LblTraitsBruiser.Text = "Bruiser"
        '
        'PicDesc
        '
        Me.PicDesc.BackColor = System.Drawing.Color.Transparent
        Me.PicDesc.ErrorImage = Global.FOnline_2_Char_Planner.My.Resources.Resources.Standby
        Me.PicDesc.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.NeutralDesc
        Me.PicDesc.InitialImage = Global.FOnline_2_Char_Planner.My.Resources.Resources.NeutralDesc
        Me.PicDesc.Location = New System.Drawing.Point(0, 0)
        Me.PicDesc.Name = "PicDesc"
        Me.PicDesc.Size = New System.Drawing.Size(282, 172)
        Me.PicDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicDesc.TabIndex = 23
        Me.PicDesc.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicDesc, "Description")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblHitPoints)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(141, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 25)
        Me.Panel1.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Panel1, "The Maximum HitPoints")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(4, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Hit Points"
        '
        'LblHitPoints
        '
        Me.LblHitPoints.AutoSize = True
        Me.LblHitPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblHitPoints.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHitPoints.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblHitPoints.Location = New System.Drawing.Point(92, 3)
        Me.LblHitPoints.Name = "LblHitPoints"
        Me.LblHitPoints.Size = New System.Drawing.Size(24, 16)
        Me.LblHitPoints.TabIndex = 44
        Me.LblHitPoints.Text = "70"
        '
        'PanStatistics
        '
        Me.PanStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanStatistics.Controls.Add(Me.Label6)
        Me.PanStatistics.Controls.Add(Me.Label5)
        Me.PanStatistics.Controls.Add(Me.LblCritChVal)
        Me.PanStatistics.Controls.Add(Me.LblHealRVal)
        Me.PanStatistics.Controls.Add(Me.LblSeqVal)
        Me.PanStatistics.Controls.Add(Me.LblRadResVal)
        Me.PanStatistics.Controls.Add(Me.LblPoisonResVal)
        Me.PanStatistics.Controls.Add(Me.LblDmgResVal)
        Me.PanStatistics.Controls.Add(Me.LblMDmgVal)
        Me.PanStatistics.Controls.Add(Me.LblCWVal)
        Me.PanStatistics.Controls.Add(Me.LblAPointsVal)
        Me.PanStatistics.Controls.Add(Me.LblAClassVal)
        Me.PanStatistics.Controls.Add(Me.LblCritCh)
        Me.PanStatistics.Controls.Add(Me.LblHealingR)
        Me.PanStatistics.Controls.Add(Me.LblSequence)
        Me.PanStatistics.Controls.Add(Me.LblMeleeDmg)
        Me.PanStatistics.Controls.Add(Me.LblRadRes)
        Me.PanStatistics.Controls.Add(Me.LblActionP)
        Me.PanStatistics.Controls.Add(Me.LblPoisonRes)
        Me.PanStatistics.Controls.Add(Me.LblAClass)
        Me.PanStatistics.Controls.Add(Me.LblDmgRes)
        Me.PanStatistics.Controls.Add(Me.LblCWeight)
        Me.PanStatistics.ForeColor = System.Drawing.Color.Black
        Me.PanStatistics.Location = New System.Drawing.Point(140, 134)
        Me.PanStatistics.Name = "PanStatistics"
        Me.PanStatistics.Size = New System.Drawing.Size(132, 160)
        Me.PanStatistics.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label6.Location = New System.Drawing.Point(116, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label5.Location = New System.Drawing.Point(116, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "%"
        '
        'LblCritChVal
        '
        Me.LblCritChVal.AutoSize = True
        Me.LblCritChVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblCritChVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCritChVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCritChVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblCritChVal.Location = New System.Drawing.Point(96, 138)
        Me.LblCritChVal.Name = "LblCritChVal"
        Me.LblCritChVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblCritChVal.Size = New System.Drawing.Size(17, 15)
        Me.LblCritChVal.TabIndex = 59
        Me.LblCritChVal.Text = "5"
        '
        'LblHealRVal
        '
        Me.LblHealRVal.AutoSize = True
        Me.LblHealRVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblHealRVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblHealRVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHealRVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblHealRVal.Location = New System.Drawing.Point(96, 123)
        Me.LblHealRVal.Name = "LblHealRVal"
        Me.LblHealRVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblHealRVal.Size = New System.Drawing.Size(17, 15)
        Me.LblHealRVal.TabIndex = 58
        Me.LblHealRVal.Text = "1"
        '
        'LblSeqVal
        '
        Me.LblSeqVal.AutoSize = True
        Me.LblSeqVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSeqVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSeqVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeqVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSeqVal.Location = New System.Drawing.Point(96, 108)
        Me.LblSeqVal.Name = "LblSeqVal"
        Me.LblSeqVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSeqVal.Size = New System.Drawing.Size(23, 15)
        Me.LblSeqVal.TabIndex = 57
        Me.LblSeqVal.Text = "10"
        '
        'LblRadResVal
        '
        Me.LblRadResVal.AutoSize = True
        Me.LblRadResVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblRadResVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblRadResVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRadResVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblRadResVal.Location = New System.Drawing.Point(96, 93)
        Me.LblRadResVal.Name = "LblRadResVal"
        Me.LblRadResVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblRadResVal.Size = New System.Drawing.Size(23, 15)
        Me.LblRadResVal.TabIndex = 56
        Me.LblRadResVal.Text = "10"
        '
        'LblPoisonResVal
        '
        Me.LblPoisonResVal.AutoSize = True
        Me.LblPoisonResVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblPoisonResVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPoisonResVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPoisonResVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblPoisonResVal.Location = New System.Drawing.Point(96, 78)
        Me.LblPoisonResVal.Name = "LblPoisonResVal"
        Me.LblPoisonResVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblPoisonResVal.Size = New System.Drawing.Size(23, 15)
        Me.LblPoisonResVal.TabIndex = 55
        Me.LblPoisonResVal.Text = "25"
        '
        'LblDmgResVal
        '
        Me.LblDmgResVal.AutoSize = True
        Me.LblDmgResVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblDmgResVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDmgResVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDmgResVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblDmgResVal.Location = New System.Drawing.Point(96, 63)
        Me.LblDmgResVal.Name = "LblDmgResVal"
        Me.LblDmgResVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblDmgResVal.Size = New System.Drawing.Size(17, 15)
        Me.LblDmgResVal.TabIndex = 54
        Me.LblDmgResVal.Text = "0"
        '
        'LblMDmgVal
        '
        Me.LblMDmgVal.AutoSize = True
        Me.LblMDmgVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblMDmgVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblMDmgVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDmgVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblMDmgVal.Location = New System.Drawing.Point(96, 48)
        Me.LblMDmgVal.Name = "LblMDmgVal"
        Me.LblMDmgVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblMDmgVal.Size = New System.Drawing.Size(17, 15)
        Me.LblMDmgVal.TabIndex = 53
        Me.LblMDmgVal.Text = "5"
        '
        'LblCWVal
        '
        Me.LblCWVal.AutoSize = True
        Me.LblCWVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblCWVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCWVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCWVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblCWVal.Location = New System.Drawing.Point(96, 33)
        Me.LblCWVal.Name = "LblCWVal"
        Me.LblCWVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblCWVal.Size = New System.Drawing.Size(23, 15)
        Me.LblCWVal.TabIndex = 52
        Me.LblCWVal.Text = "77"
        '
        'LblAPointsVal
        '
        Me.LblAPointsVal.AutoSize = True
        Me.LblAPointsVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblAPointsVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblAPointsVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAPointsVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblAPointsVal.Location = New System.Drawing.Point(96, 18)
        Me.LblAPointsVal.Name = "LblAPointsVal"
        Me.LblAPointsVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblAPointsVal.Size = New System.Drawing.Size(17, 15)
        Me.LblAPointsVal.TabIndex = 51
        Me.LblAPointsVal.Text = "7"
        '
        'LblAClassVal
        '
        Me.LblAClassVal.AutoSize = True
        Me.LblAClassVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblAClassVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblAClassVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAClassVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblAClassVal.Location = New System.Drawing.Point(96, 3)
        Me.LblAClassVal.Name = "LblAClassVal"
        Me.LblAClassVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblAClassVal.Size = New System.Drawing.Size(17, 15)
        Me.LblAClassVal.TabIndex = 50
        Me.LblAClassVal.Text = "5"
        '
        'LblCritCh
        '
        Me.LblCritCh.AutoSize = True
        Me.LblCritCh.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblCritCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCritCh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCritCh.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblCritCh.Location = New System.Drawing.Point(3, 138)
        Me.LblCritCh.Name = "LblCritCh"
        Me.LblCritCh.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblCritCh.Size = New System.Drawing.Size(82, 15)
        Me.LblCritCh.TabIndex = 49
        Me.LblCritCh.Text = "Critical Chance"
        '
        'LblHealingR
        '
        Me.LblHealingR.AutoSize = True
        Me.LblHealingR.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblHealingR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblHealingR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHealingR.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblHealingR.Location = New System.Drawing.Point(3, 123)
        Me.LblHealingR.Name = "LblHealingR"
        Me.LblHealingR.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblHealingR.Size = New System.Drawing.Size(72, 15)
        Me.LblHealingR.TabIndex = 48
        Me.LblHealingR.Text = "Healing Rate"
        '
        'LblSequence
        '
        Me.LblSequence.AutoSize = True
        Me.LblSequence.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSequence.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSequence.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSequence.Location = New System.Drawing.Point(3, 108)
        Me.LblSequence.Name = "LblSequence"
        Me.LblSequence.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSequence.Size = New System.Drawing.Size(58, 15)
        Me.LblSequence.TabIndex = 47
        Me.LblSequence.Text = "Sequence"
        '
        'LblMeleeDmg
        '
        Me.LblMeleeDmg.AutoSize = True
        Me.LblMeleeDmg.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblMeleeDmg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblMeleeDmg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMeleeDmg.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblMeleeDmg.Location = New System.Drawing.Point(3, 48)
        Me.LblMeleeDmg.Name = "LblMeleeDmg"
        Me.LblMeleeDmg.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblMeleeDmg.Size = New System.Drawing.Size(81, 15)
        Me.LblMeleeDmg.TabIndex = 43
        Me.LblMeleeDmg.Text = "Melee Damage"
        '
        'LblRadRes
        '
        Me.LblRadRes.AutoSize = True
        Me.LblRadRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblRadRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblRadRes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRadRes.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblRadRes.Location = New System.Drawing.Point(3, 93)
        Me.LblRadRes.Name = "LblRadRes"
        Me.LblRadRes.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblRadRes.Size = New System.Drawing.Size(81, 15)
        Me.LblRadRes.TabIndex = 46
        Me.LblRadRes.Text = "Radiation Res."
        '
        'LblActionP
        '
        Me.LblActionP.AutoSize = True
        Me.LblActionP.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblActionP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblActionP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActionP.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblActionP.Location = New System.Drawing.Point(3, 18)
        Me.LblActionP.Name = "LblActionP"
        Me.LblActionP.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblActionP.Size = New System.Drawing.Size(73, 15)
        Me.LblActionP.TabIndex = 41
        Me.LblActionP.Text = "Action Points"
        '
        'LblPoisonRes
        '
        Me.LblPoisonRes.AutoSize = True
        Me.LblPoisonRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblPoisonRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPoisonRes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPoisonRes.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblPoisonRes.Location = New System.Drawing.Point(3, 78)
        Me.LblPoisonRes.Name = "LblPoisonRes"
        Me.LblPoisonRes.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblPoisonRes.Size = New System.Drawing.Size(67, 15)
        Me.LblPoisonRes.TabIndex = 45
        Me.LblPoisonRes.Text = "Poison Res."
        '
        'LblAClass
        '
        Me.LblAClass.AutoSize = True
        Me.LblAClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblAClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblAClass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAClass.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblAClass.Location = New System.Drawing.Point(3, 3)
        Me.LblAClass.Name = "LblAClass"
        Me.LblAClass.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblAClass.Size = New System.Drawing.Size(68, 15)
        Me.LblAClass.TabIndex = 40
        Me.LblAClass.Text = "Armor Class"
        '
        'LblDmgRes
        '
        Me.LblDmgRes.AutoSize = True
        Me.LblDmgRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblDmgRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDmgRes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDmgRes.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblDmgRes.Location = New System.Drawing.Point(3, 63)
        Me.LblDmgRes.Name = "LblDmgRes"
        Me.LblDmgRes.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblDmgRes.Size = New System.Drawing.Size(75, 15)
        Me.LblDmgRes.TabIndex = 44
        Me.LblDmgRes.Text = "Damage Res."
        '
        'LblCWeight
        '
        Me.LblCWeight.AutoSize = True
        Me.LblCWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblCWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCWeight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCWeight.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblCWeight.Location = New System.Drawing.Point(3, 33)
        Me.LblCWeight.Name = "LblCWeight"
        Me.LblCWeight.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblCWeight.Size = New System.Drawing.Size(75, 15)
        Me.LblCWeight.TabIndex = 42
        Me.LblCWeight.Text = "Carry Weight"
        '
        'LblSpecial
        '
        Me.LblSpecial.AutoSize = True
        Me.LblSpecial.BackColor = System.Drawing.Color.Transparent
        Me.LblSpecial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpecial.ForeColor = System.Drawing.Color.Gold
        Me.LblSpecial.Location = New System.Drawing.Point(29, 38)
        Me.LblSpecial.Name = "LblSpecial"
        Me.LblSpecial.Size = New System.Drawing.Size(89, 16)
        Me.LblSpecial.TabIndex = 24
        Me.LblSpecial.Text = "S.P.E.C.I.A.L."
        '
        'PanSkills
        '
        Me.PanSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanSkills.Controls.Add(Me.LblODVal)
        Me.PanSkills.Controls.Add(Me.LblGamblVal)
        Me.PanSkills.Controls.Add(Me.LblBarterVal)
        Me.PanSkills.Controls.Add(Me.LblSpeechVal)
        Me.PanSkills.Controls.Add(Me.LblRepairVal)
        Me.PanSkills.Controls.Add(Me.LblScienceVal)
        Me.PanSkills.Controls.Add(Me.LblTrapsVal)
        Me.PanSkills.Controls.Add(Me.LblStealVal)
        Me.PanSkills.Controls.Add(Me.LblLPickVal)
        Me.PanSkills.Controls.Add(Me.LblSneakVal)
        Me.PanSkills.Controls.Add(Me.LblDocVal)
        Me.PanSkills.Controls.Add(Me.LblFaidVal)
        Me.PanSkills.Controls.Add(Me.LblThrowVal)
        Me.PanSkills.Controls.Add(Me.LblScavenVal)
        Me.PanSkills.Controls.Add(Me.LblCCombVal)
        Me.PanSkills.Controls.Add(Me.LblEWeaponsVal)
        Me.PanSkills.Controls.Add(Me.LblBGunsVal)
        Me.PanSkills.Controls.Add(Me.LblSGunsVal)
        Me.PanSkills.Controls.Add(Me.LblRepair)
        Me.PanSkills.Controls.Add(Me.LblGambling)
        Me.PanSkills.Controls.Add(Me.LblLPick)
        Me.PanSkills.Controls.Add(Me.LblSneak)
        Me.PanSkills.Controls.Add(Me.LblDoctor)
        Me.PanSkills.Controls.Add(Me.LblScavenge)
        Me.PanSkills.Controls.Add(Me.LblBGuns)
        Me.PanSkills.Controls.Add(Me.LblSGuns)
        Me.PanSkills.Controls.Add(Me.LblEWeapons)
        Me.PanSkills.Controls.Add(Me.LblCCombat)
        Me.PanSkills.Controls.Add(Me.LblThrow)
        Me.PanSkills.Controls.Add(Me.LblFAid)
        Me.PanSkills.Controls.Add(Me.LblSteal)
        Me.PanSkills.Controls.Add(Me.LblTraps)
        Me.PanSkills.Controls.Add(Me.LblScience)
        Me.PanSkills.Controls.Add(Me.LblSpeech)
        Me.PanSkills.Controls.Add(Me.LblBarter)
        Me.PanSkills.Controls.Add(Me.LblODMan)
        Me.PanSkills.ForeColor = System.Drawing.Color.Black
        Me.PanSkills.Location = New System.Drawing.Point(279, 57)
        Me.PanSkills.Name = "PanSkills"
        Me.PanSkills.Size = New System.Drawing.Size(174, 237)
        Me.PanSkills.TabIndex = 22
        '
        'LblODVal
        '
        Me.LblODVal.AutoSize = True
        Me.LblODVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblODVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblODVal.Location = New System.Drawing.Point(140, 222)
        Me.LblODVal.Name = "LblODVal"
        Me.LblODVal.Size = New System.Drawing.Size(27, 13)
        Me.LblODVal.TabIndex = 97
        Me.LblODVal.Text = "20%"
        Me.LblODVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblGamblVal
        '
        Me.LblGamblVal.AutoSize = True
        Me.LblGamblVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblGamblVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblGamblVal.Location = New System.Drawing.Point(140, 209)
        Me.LblGamblVal.Name = "LblGamblVal"
        Me.LblGamblVal.Size = New System.Drawing.Size(27, 13)
        Me.LblGamblVal.TabIndex = 96
        Me.LblGamblVal.Text = "25%"
        Me.LblGamblVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBarterVal
        '
        Me.LblBarterVal.AutoSize = True
        Me.LblBarterVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBarterVal.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblBarterVal.Location = New System.Drawing.Point(140, 196)
        Me.LblBarterVal.Name = "LblBarterVal"
        Me.LblBarterVal.Size = New System.Drawing.Size(27, 13)
        Me.LblBarterVal.TabIndex = 95
        Me.LblBarterVal.Text = "20%"
        Me.LblBarterVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSpeechVal
        '
        Me.LblSpeechVal.AutoSize = True
        Me.LblSpeechVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSpeechVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSpeechVal.Location = New System.Drawing.Point(140, 183)
        Me.LblSpeechVal.Name = "LblSpeechVal"
        Me.LblSpeechVal.Size = New System.Drawing.Size(27, 13)
        Me.LblSpeechVal.TabIndex = 94
        Me.LblSpeechVal.Text = "25%"
        Me.LblSpeechVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRepairVal
        '
        Me.LblRepairVal.AutoSize = True
        Me.LblRepairVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblRepairVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblRepairVal.Location = New System.Drawing.Point(140, 170)
        Me.LblRepairVal.Name = "LblRepairVal"
        Me.LblRepairVal.Size = New System.Drawing.Size(27, 13)
        Me.LblRepairVal.TabIndex = 93
        Me.LblRepairVal.Text = "15%"
        Me.LblRepairVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblScienceVal
        '
        Me.LblScienceVal.AutoSize = True
        Me.LblScienceVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblScienceVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblScienceVal.Location = New System.Drawing.Point(140, 157)
        Me.LblScienceVal.Name = "LblScienceVal"
        Me.LblScienceVal.Size = New System.Drawing.Size(27, 13)
        Me.LblScienceVal.TabIndex = 92
        Me.LblScienceVal.Text = "20%"
        Me.LblScienceVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTrapsVal
        '
        Me.LblTrapsVal.AutoSize = True
        Me.LblTrapsVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblTrapsVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTrapsVal.Location = New System.Drawing.Point(140, 144)
        Me.LblTrapsVal.Name = "LblTrapsVal"
        Me.LblTrapsVal.Size = New System.Drawing.Size(27, 13)
        Me.LblTrapsVal.TabIndex = 91
        Me.LblTrapsVal.Text = "20%"
        Me.LblTrapsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStealVal
        '
        Me.LblStealVal.AutoSize = True
        Me.LblStealVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblStealVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblStealVal.Location = New System.Drawing.Point(140, 131)
        Me.LblStealVal.Name = "LblStealVal"
        Me.LblStealVal.Size = New System.Drawing.Size(27, 13)
        Me.LblStealVal.TabIndex = 90
        Me.LblStealVal.Text = "15%"
        Me.LblStealVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLPickVal
        '
        Me.LblLPickVal.AutoSize = True
        Me.LblLPickVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblLPickVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblLPickVal.Location = New System.Drawing.Point(140, 118)
        Me.LblLPickVal.Name = "LblLPickVal"
        Me.LblLPickVal.Size = New System.Drawing.Size(27, 13)
        Me.LblLPickVal.TabIndex = 89
        Me.LblLPickVal.Text = "20%"
        Me.LblLPickVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSneakVal
        '
        Me.LblSneakVal.AutoSize = True
        Me.LblSneakVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSneakVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSneakVal.Location = New System.Drawing.Point(140, 105)
        Me.LblSneakVal.Name = "LblSneakVal"
        Me.LblSneakVal.Size = New System.Drawing.Size(27, 13)
        Me.LblSneakVal.TabIndex = 88
        Me.LblSneakVal.Text = "20%"
        Me.LblSneakVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDocVal
        '
        Me.LblDocVal.AutoSize = True
        Me.LblDocVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDocVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblDocVal.Location = New System.Drawing.Point(140, 92)
        Me.LblDocVal.Name = "LblDocVal"
        Me.LblDocVal.Size = New System.Drawing.Size(27, 13)
        Me.LblDocVal.TabIndex = 87
        Me.LblDocVal.Text = "15%"
        Me.LblDocVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFaidVal
        '
        Me.LblFaidVal.AutoSize = True
        Me.LblFaidVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblFaidVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblFaidVal.Location = New System.Drawing.Point(140, 79)
        Me.LblFaidVal.Name = "LblFaidVal"
        Me.LblFaidVal.Size = New System.Drawing.Size(27, 13)
        Me.LblFaidVal.TabIndex = 86
        Me.LblFaidVal.Text = "20%"
        Me.LblFaidVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblThrowVal
        '
        Me.LblThrowVal.AutoSize = True
        Me.LblThrowVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblThrowVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblThrowVal.Location = New System.Drawing.Point(140, 66)
        Me.LblThrowVal.Name = "LblThrowVal"
        Me.LblThrowVal.Size = New System.Drawing.Size(27, 13)
        Me.LblThrowVal.TabIndex = 85
        Me.LblThrowVal.Text = "20%"
        Me.LblThrowVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblScavenVal
        '
        Me.LblScavenVal.AutoSize = True
        Me.LblScavenVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblScavenVal.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblScavenVal.Location = New System.Drawing.Point(140, 53)
        Me.LblScavenVal.Name = "LblScavenVal"
        Me.LblScavenVal.Size = New System.Drawing.Size(21, 13)
        Me.LblScavenVal.TabIndex = 84
        Me.LblScavenVal.Text = "0%"
        Me.LblScavenVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCCombVal
        '
        Me.LblCCombVal.AutoSize = True
        Me.LblCCombVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCCombVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblCCombVal.Location = New System.Drawing.Point(140, 41)
        Me.LblCCombVal.Name = "LblCCombVal"
        Me.LblCCombVal.Size = New System.Drawing.Size(27, 13)
        Me.LblCCombVal.TabIndex = 83
        Me.LblCCombVal.Text = "50%"
        Me.LblCCombVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEWeaponsVal
        '
        Me.LblEWeaponsVal.AutoSize = True
        Me.LblEWeaponsVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblEWeaponsVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblEWeaponsVal.Location = New System.Drawing.Point(140, 28)
        Me.LblEWeaponsVal.Name = "LblEWeaponsVal"
        Me.LblEWeaponsVal.Size = New System.Drawing.Size(27, 13)
        Me.LblEWeaponsVal.TabIndex = 82
        Me.LblEWeaponsVal.Text = "10%"
        Me.LblEWeaponsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBGunsVal
        '
        Me.LblBGunsVal.AutoSize = True
        Me.LblBGunsVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBGunsVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblBGunsVal.Location = New System.Drawing.Point(140, 15)
        Me.LblBGunsVal.Name = "LblBGunsVal"
        Me.LblBGunsVal.Size = New System.Drawing.Size(27, 13)
        Me.LblBGunsVal.TabIndex = 81
        Me.LblBGunsVal.Text = "10%"
        Me.LblBGunsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSGunsVal
        '
        Me.LblSGunsVal.AutoSize = True
        Me.LblSGunsVal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSGunsVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSGunsVal.Location = New System.Drawing.Point(140, 2)
        Me.LblSGunsVal.Name = "LblSGunsVal"
        Me.LblSGunsVal.Size = New System.Drawing.Size(27, 13)
        Me.LblSGunsVal.TabIndex = 80
        Me.LblSGunsVal.Text = "25%"
        Me.LblSGunsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRepair
        '
        Me.LblRepair.AutoSize = True
        Me.LblRepair.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblRepair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblRepair.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepair.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblRepair.Location = New System.Drawing.Point(3, 170)
        Me.LblRepair.Name = "LblRepair"
        Me.LblRepair.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblRepair.Size = New System.Drawing.Size(42, 15)
        Me.LblRepair.TabIndex = 75
        Me.LblRepair.Text = "Repair"
        '
        'LblGambling
        '
        Me.LblGambling.AutoSize = True
        Me.LblGambling.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblGambling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblGambling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblGambling.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGambling.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblGambling.Location = New System.Drawing.Point(3, 209)
        Me.LblGambling.Name = "LblGambling"
        Me.LblGambling.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblGambling.Size = New System.Drawing.Size(54, 15)
        Me.LblGambling.TabIndex = 78
        Me.LblGambling.Text = "Gambling"
        '
        'LblLPick
        '
        Me.LblLPick.AutoSize = True
        Me.LblLPick.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblLPick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblLPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLPick.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLPick.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblLPick.Location = New System.Drawing.Point(3, 118)
        Me.LblLPick.Name = "LblLPick"
        Me.LblLPick.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblLPick.Size = New System.Drawing.Size(50, 15)
        Me.LblLPick.TabIndex = 71
        Me.LblLPick.Text = "Lockpick"
        '
        'LblSneak
        '
        Me.LblSneak.AutoSize = True
        Me.LblSneak.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSneak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSneak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSneak.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSneak.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSneak.Location = New System.Drawing.Point(3, 105)
        Me.LblSneak.Name = "LblSneak"
        Me.LblSneak.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSneak.Size = New System.Drawing.Size(40, 15)
        Me.LblSneak.TabIndex = 70
        Me.LblSneak.Text = "Sneak"
        '
        'LblDoctor
        '
        Me.LblDoctor.AutoSize = True
        Me.LblDoctor.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDoctor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoctor.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblDoctor.Location = New System.Drawing.Point(3, 92)
        Me.LblDoctor.Name = "LblDoctor"
        Me.LblDoctor.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblDoctor.Size = New System.Drawing.Size(43, 15)
        Me.LblDoctor.TabIndex = 69
        Me.LblDoctor.Text = "Doctor"
        '
        'LblScavenge
        '
        Me.LblScavenge.AutoSize = True
        Me.LblScavenge.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblScavenge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblScavenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblScavenge.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScavenge.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblScavenge.Location = New System.Drawing.Point(3, 53)
        Me.LblScavenge.Name = "LblScavenge"
        Me.LblScavenge.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblScavenge.Size = New System.Drawing.Size(66, 15)
        Me.LblScavenge.TabIndex = 66
        Me.LblScavenge.Text = "Scavenging"
        Me.ToolTip1.SetToolTip(Me.LblScavenge, "This skill can't be raised by using SP. It will raise by scavenging ingame.")
        '
        'LblBGuns
        '
        Me.LblBGuns.AutoSize = True
        Me.LblBGuns.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblBGuns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBGuns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblBGuns.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBGuns.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblBGuns.Location = New System.Drawing.Point(3, 15)
        Me.LblBGuns.Name = "LblBGuns"
        Me.LblBGuns.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblBGuns.Size = New System.Drawing.Size(52, 15)
        Me.LblBGuns.TabIndex = 63
        Me.LblBGuns.Text = "Big Guns"
        '
        'LblSGuns
        '
        Me.LblSGuns.AutoSize = True
        Me.LblSGuns.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSGuns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSGuns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSGuns.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSGuns.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSGuns.Location = New System.Drawing.Point(3, 2)
        Me.LblSGuns.Name = "LblSGuns"
        Me.LblSGuns.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSGuns.Size = New System.Drawing.Size(62, 15)
        Me.LblSGuns.TabIndex = 62
        Me.LblSGuns.Text = "Small Guns"
        '
        'LblEWeapons
        '
        Me.LblEWeapons.AutoSize = True
        Me.LblEWeapons.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblEWeapons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblEWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblEWeapons.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEWeapons.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblEWeapons.Location = New System.Drawing.Point(3, 28)
        Me.LblEWeapons.Name = "LblEWeapons"
        Me.LblEWeapons.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblEWeapons.Size = New System.Drawing.Size(93, 15)
        Me.LblEWeapons.TabIndex = 64
        Me.LblEWeapons.Text = "Energy Weapons"
        '
        'LblCCombat
        '
        Me.LblCCombat.AutoSize = True
        Me.LblCCombat.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblCCombat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCCombat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCCombat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCCombat.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblCCombat.Location = New System.Drawing.Point(3, 41)
        Me.LblCCombat.Name = "LblCCombat"
        Me.LblCCombat.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblCCombat.Size = New System.Drawing.Size(77, 15)
        Me.LblCCombat.TabIndex = 65
        Me.LblCCombat.Text = "Close Combat"
        '
        'LblThrow
        '
        Me.LblThrow.AutoSize = True
        Me.LblThrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblThrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblThrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblThrow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblThrow.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblThrow.Location = New System.Drawing.Point(3, 66)
        Me.LblThrow.Name = "LblThrow"
        Me.LblThrow.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblThrow.Size = New System.Drawing.Size(55, 15)
        Me.LblThrow.TabIndex = 67
        Me.LblThrow.Text = "Throwing"
        '
        'LblFAid
        '
        Me.LblFAid.AutoSize = True
        Me.LblFAid.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblFAid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblFAid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblFAid.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFAid.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblFAid.Location = New System.Drawing.Point(3, 79)
        Me.LblFAid.Name = "LblFAid"
        Me.LblFAid.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblFAid.Size = New System.Drawing.Size(50, 15)
        Me.LblFAid.TabIndex = 68
        Me.LblFAid.Text = "First Aid"
        '
        'LblSteal
        '
        Me.LblSteal.AutoSize = True
        Me.LblSteal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSteal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSteal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSteal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSteal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSteal.Location = New System.Drawing.Point(3, 131)
        Me.LblSteal.Name = "LblSteal"
        Me.LblSteal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSteal.Size = New System.Drawing.Size(35, 15)
        Me.LblSteal.TabIndex = 72
        Me.LblSteal.Text = "Steal"
        '
        'LblTraps
        '
        Me.LblTraps.AutoSize = True
        Me.LblTraps.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTraps.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblTraps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTraps.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTraps.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTraps.Location = New System.Drawing.Point(3, 144)
        Me.LblTraps.Name = "LblTraps"
        Me.LblTraps.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTraps.Size = New System.Drawing.Size(38, 15)
        Me.LblTraps.TabIndex = 73
        Me.LblTraps.Text = "Traps"
        '
        'LblScience
        '
        Me.LblScience.AutoSize = True
        Me.LblScience.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblScience.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblScience.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblScience.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScience.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblScience.Location = New System.Drawing.Point(3, 157)
        Me.LblScience.Name = "LblScience"
        Me.LblScience.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblScience.Size = New System.Drawing.Size(47, 15)
        Me.LblScience.TabIndex = 74
        Me.LblScience.Text = "Science"
        '
        'LblSpeech
        '
        Me.LblSpeech.AutoSize = True
        Me.LblSpeech.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSpeech.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblSpeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSpeech.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpeech.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSpeech.Location = New System.Drawing.Point(3, 183)
        Me.LblSpeech.Name = "LblSpeech"
        Me.LblSpeech.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSpeech.Size = New System.Drawing.Size(46, 15)
        Me.LblSpeech.TabIndex = 76
        Me.LblSpeech.Text = "Speech"
        '
        'LblBarter
        '
        Me.LblBarter.AutoSize = True
        Me.LblBarter.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblBarter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblBarter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarter.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblBarter.Location = New System.Drawing.Point(3, 196)
        Me.LblBarter.Name = "LblBarter"
        Me.LblBarter.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblBarter.Size = New System.Drawing.Size(41, 15)
        Me.LblBarter.TabIndex = 77
        Me.LblBarter.Text = "Barter"
        Me.ToolTip1.SetToolTip(Me.LblBarter, "This skill can't be raised by using SP. It will raise by barter ingame.")
        '
        'LblODMan
        '
        Me.LblODMan.AutoSize = True
        Me.LblODMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblODMan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblODMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblODMan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblODMan.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblODMan.Location = New System.Drawing.Point(3, 222)
        Me.LblODMan.Name = "LblODMan"
        Me.LblODMan.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblODMan.Size = New System.Drawing.Size(76, 15)
        Me.LblODMan.TabIndex = 79
        Me.LblODMan.Text = "Outdoorsman"
        '
        'LblSkills
        '
        Me.LblSkills.AutoSize = True
        Me.LblSkills.BackColor = System.Drawing.Color.Transparent
        Me.LblSkills.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSkills.ForeColor = System.Drawing.Color.Gold
        Me.LblSkills.Location = New System.Drawing.Point(283, 38)
        Me.LblSkills.Name = "LblSkills"
        Me.LblSkills.Size = New System.Drawing.Size(39, 16)
        Me.LblSkills.TabIndex = 25
        Me.LblSkills.Text = "Skills"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LblTagSkills)
        Me.Panel4.Controls.Add(Me.LblSkPoints)
        Me.Panel4.Controls.Add(Me.LblSkPointsVal)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(279, 300)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(174, 37)
        Me.Panel4.TabIndex = 22
        '
        'LblTagSkills
        '
        Me.LblTagSkills.AutoSize = True
        Me.LblTagSkills.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTagSkills.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTagSkills.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTagSkills.Location = New System.Drawing.Point(34, 10)
        Me.LblTagSkills.Name = "LblTagSkills"
        Me.LblTagSkills.Size = New System.Drawing.Size(80, 16)
        Me.LblTagSkills.TabIndex = 22
        Me.LblTagSkills.Text = "TAG SKILLS"
        '
        'LblSkPoints
        '
        Me.LblSkPoints.AutoSize = True
        Me.LblSkPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSkPoints.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSkPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSkPoints.Location = New System.Drawing.Point(12, 10)
        Me.LblSkPoints.Name = "LblSkPoints"
        Me.LblSkPoints.Size = New System.Drawing.Size(88, 16)
        Me.LblSkPoints.TabIndex = 21
        Me.LblSkPoints.Text = "SKILLPOINTS"
        Me.LblSkPoints.Visible = False
        '
        'LblSkPointsVal
        '
        Me.LblSkPointsVal.AutoSize = True
        Me.LblSkPointsVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSkPointsVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSkPointsVal.ForeColor = System.Drawing.Color.SeaShell
        Me.LblSkPointsVal.Location = New System.Drawing.Point(128, 8)
        Me.LblSkPointsVal.Name = "LblSkPointsVal"
        Me.LblSkPointsVal.Size = New System.Drawing.Size(18, 18)
        Me.LblSkPointsVal.TabIndex = 21
        Me.LblSkPointsVal.Text = "3"
        '
        'PanLvlInfo
        '
        Me.PanLvlInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanLvlInfo.Controls.Add(Me.LblLevelVal)
        Me.PanLvlInfo.Controls.Add(Me.LblLvl)
        Me.PanLvlInfo.ForeColor = System.Drawing.Color.Black
        Me.PanLvlInfo.Location = New System.Drawing.Point(141, 300)
        Me.PanLvlInfo.Name = "PanLvlInfo"
        Me.PanLvlInfo.Size = New System.Drawing.Size(132, 37)
        Me.PanLvlInfo.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.PanLvlInfo, "The actual Level of the character.")
        '
        'LblLevelVal
        '
        Me.LblLevelVal.AutoSize = True
        Me.LblLevelVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblLevelVal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevelVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblLevelVal.Location = New System.Drawing.Point(97, 9)
        Me.LblLevelVal.Name = "LblLevelVal"
        Me.LblLevelVal.Size = New System.Drawing.Size(16, 16)
        Me.LblLevelVal.TabIndex = 45
        Me.LblLevelVal.Text = "1"
        '
        'LblLvl
        '
        Me.LblLvl.AutoSize = True
        Me.LblLvl.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblLvl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLvl.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblLvl.Location = New System.Drawing.Point(18, 10)
        Me.LblLvl.Name = "LblLvl"
        Me.LblLvl.Size = New System.Drawing.Size(42, 16)
        Me.LblLvl.TabIndex = 22
        Me.LblLvl.Text = "Level"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(21, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Traits"
        '
        'LblGenDescr
        '
        Me.LblGenDescr.AutoSize = True
        Me.LblGenDescr.BackColor = System.Drawing.Color.Transparent
        Me.LblGenDescr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblGenDescr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGenDescr.ForeColor = System.Drawing.Color.LightCyan
        Me.LblGenDescr.Location = New System.Drawing.Point(487, 367)
        Me.LblGenDescr.Name = "LblGenDescr"
        Me.LblGenDescr.Size = New System.Drawing.Size(118, 13)
        Me.LblGenDescr.TabIndex = 30
        Me.LblGenDescr.Text = "General Description"
        '
        'PanDetDesc
        '
        Me.PanDetDesc.BackColor = System.Drawing.Color.Brown
        Me.PanDetDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanDetDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanDetDesc.Location = New System.Drawing.Point(757, 368)
        Me.PanDetDesc.Name = "PanDetDesc"
        Me.PanDetDesc.Size = New System.Drawing.Size(12, 12)
        Me.PanDetDesc.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.PanDetDesc, "Detailed Description")
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Black
        Me.ToolTip1.ForeColor = System.Drawing.Color.LimeGreen
        '
        'PanNormDesc
        '
        Me.PanNormDesc.BackColor = System.Drawing.Color.ForestGreen
        Me.PanNormDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanNormDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanNormDesc.Location = New System.Drawing.Point(611, 368)
        Me.PanNormDesc.Name = "PanNormDesc"
        Me.PanNormDesc.Size = New System.Drawing.Size(12, 12)
        Me.PanNormDesc.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.PanNormDesc, "Normal Description")
        '
        'LstBoxPerks
        '
        Me.LstBoxPerks.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LstBoxPerks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstBoxPerks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstBoxPerks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.LstBoxPerks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxPerks.ForeColor = System.Drawing.Color.Chartreuse
        Me.LstBoxPerks.FormattingEnabled = True
        Me.LstBoxPerks.Location = New System.Drawing.Point(236, 425)
        Me.LstBoxPerks.Name = "LstBoxPerks"
        Me.LstBoxPerks.Size = New System.Drawing.Size(219, 130)
        Me.LstBoxPerks.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.LstBoxPerks, "Perks you took already.")
        '
        'BtnLvlUp
        '
        Me.BtnLvlUp.BackColor = System.Drawing.Color.Transparent
        Me.BtnLvlUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLvlUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnLvlUp.FlatAppearance.BorderSize = 0
        Me.BtnLvlUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnLvlUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnLvlUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLvlUp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLvlUp.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnLvlUp.Location = New System.Drawing.Point(697, 313)
        Me.BtnLvlUp.Name = "BtnLvlUp"
        Me.BtnLvlUp.Size = New System.Drawing.Size(25, 20)
        Me.BtnLvlUp.TabIndex = 44
        Me.BtnLvlUp.Text = ">"
        Me.ToolTip1.SetToolTip(Me.BtnLvlUp, "Go 1 Level up")
        Me.BtnLvlUp.UseCompatibleTextRendering = True
        Me.BtnLvlUp.UseVisualStyleBackColor = False
        Me.BtnLvlUp.Visible = False
        '
        'CBoxBooks
        '
        Me.CBoxBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.CBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBoxBooks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxBooks.ForeColor = System.Drawing.Color.MintCream
        Me.CBoxBooks.FormattingEnabled = True
        Me.CBoxBooks.Location = New System.Drawing.Point(757, 88)
        Me.CBoxBooks.Name = "CBoxBooks"
        Me.CBoxBooks.Size = New System.Drawing.Size(111, 21)
        Me.CBoxBooks.TabIndex = 50
        Me.CBoxBooks.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CBoxBooks, "WIP!")
        Me.CBoxBooks.Visible = False
        '
        'PanDetText
        '
        Me.PanDetText.BackColor = System.Drawing.Color.Transparent
        Me.PanDetText.Controls.Add(Me.LblDetDescrText)
        Me.PanDetText.Controls.Add(Me.LblDetDesc)
        Me.PanDetText.Controls.Add(Me.PicDesc)
        Me.PanDetText.Location = New System.Drawing.Point(487, 383)
        Me.PanDetText.Name = "PanDetText"
        Me.PanDetText.Size = New System.Drawing.Size(282, 172)
        Me.PanDetText.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.PanDetText, "Detailed Description")
        '
        'LblDetDescrText
        '
        Me.LblDetDescrText.AutoSize = True
        Me.LblDetDescrText.BackColor = System.Drawing.Color.Transparent
        Me.LblDetDescrText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetDescrText.ForeColor = System.Drawing.Color.LightYellow
        Me.LblDetDescrText.Location = New System.Drawing.Point(13, 60)
        Me.LblDetDescrText.Name = "LblDetDescrText"
        Me.LblDetDescrText.Size = New System.Drawing.Size(53, 14)
        Me.LblDetDescrText.TabIndex = 61
        Me.LblDetDescrText.Text = "DetText"
        '
        'LblDetDesc
        '
        Me.LblDetDesc.AutoSize = True
        Me.LblDetDesc.BackColor = System.Drawing.Color.Transparent
        Me.LblDetDesc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetDesc.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LblDetDesc.Location = New System.Drawing.Point(13, 23)
        Me.LblDetDesc.Name = "LblDetDesc"
        Me.LblDetDesc.Size = New System.Drawing.Size(130, 14)
        Me.LblDetDesc.TabIndex = 37
        Me.LblDetDesc.Text = "Detailed Descritpion"
        '
        'PanStatsSightACrit
        '
        Me.PanStatsSightACrit.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanStatsSightACrit.Controls.Add(Me.Label9)
        Me.PanStatsSightACrit.Controls.Add(Me.LblACritVal)
        Me.PanStatsSightACrit.Controls.Add(Me.LblAntiCrit)
        Me.PanStatsSightACrit.Controls.Add(Me.LblSightVal)
        Me.PanStatsSightACrit.Controls.Add(Me.LblSight)
        Me.PanStatsSightACrit.ForeColor = System.Drawing.Color.Black
        Me.PanStatsSightACrit.Location = New System.Drawing.Point(141, 88)
        Me.PanStatsSightACrit.Name = "PanStatsSightACrit"
        Me.PanStatsSightACrit.Size = New System.Drawing.Size(132, 40)
        Me.PanStatsSightACrit.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.PanStatsSightACrit, "The actual Level of the character.")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label9.Location = New System.Drawing.Point(115, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "%"
        '
        'LblACritVal
        '
        Me.LblACritVal.AutoSize = True
        Me.LblACritVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblACritVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblACritVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblACritVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblACritVal.Location = New System.Drawing.Point(95, 20)
        Me.LblACritVal.Name = "LblACritVal"
        Me.LblACritVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblACritVal.Size = New System.Drawing.Size(17, 15)
        Me.LblACritVal.TabIndex = 65
        Me.LblACritVal.Text = "0"
        '
        'LblAntiCrit
        '
        Me.LblAntiCrit.AutoSize = True
        Me.LblAntiCrit.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblAntiCrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblAntiCrit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAntiCrit.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblAntiCrit.Location = New System.Drawing.Point(2, 20)
        Me.LblAntiCrit.Name = "LblAntiCrit"
        Me.LblAntiCrit.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblAntiCrit.Size = New System.Drawing.Size(60, 15)
        Me.LblAntiCrit.TabIndex = 64
        Me.LblAntiCrit.Text = "Anticritical"
        '
        'LblSightVal
        '
        Me.LblSightVal.AutoSize = True
        Me.LblSightVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSightVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSightVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSightVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSightVal.Location = New System.Drawing.Point(95, 5)
        Me.LblSightVal.Name = "LblSightVal"
        Me.LblSightVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSightVal.Size = New System.Drawing.Size(23, 15)
        Me.LblSightVal.TabIndex = 63
        Me.LblSightVal.Text = "35"
        '
        'LblSight
        '
        Me.LblSight.AutoSize = True
        Me.LblSight.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblSight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSight.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblSight.Location = New System.Drawing.Point(2, 5)
        Me.LblSight.Name = "LblSight"
        Me.LblSight.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblSight.Size = New System.Drawing.Size(35, 15)
        Me.LblSight.TabIndex = 62
        Me.LblSight.Text = "Sight"
        '
        'BtnLvlFastUp
        '
        Me.BtnLvlFastUp.BackColor = System.Drawing.Color.Transparent
        Me.BtnLvlFastUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLvlFastUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnLvlFastUp.FlatAppearance.BorderSize = 0
        Me.BtnLvlFastUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnLvlFastUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnLvlFastUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLvlFastUp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLvlFastUp.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnLvlFastUp.Location = New System.Drawing.Point(728, 313)
        Me.BtnLvlFastUp.Name = "BtnLvlFastUp"
        Me.BtnLvlFastUp.Size = New System.Drawing.Size(41, 20)
        Me.BtnLvlFastUp.TabIndex = 102
        Me.BtnLvlFastUp.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.BtnLvlFastUp, "Go Up to Level 99")
        Me.BtnLvlFastUp.UseCompatibleTextRendering = True
        Me.BtnLvlFastUp.UseVisualStyleBackColor = False
        Me.BtnLvlFastUp.Visible = False
        '
        'BtnLvlFastDwn
        '
        Me.BtnLvlFastDwn.BackColor = System.Drawing.Color.Transparent
        Me.BtnLvlFastDwn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLvlFastDwn.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnLvlFastDwn.FlatAppearance.BorderSize = 0
        Me.BtnLvlFastDwn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnLvlFastDwn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnLvlFastDwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLvlFastDwn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLvlFastDwn.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnLvlFastDwn.Location = New System.Drawing.Point(581, 313)
        Me.BtnLvlFastDwn.Name = "BtnLvlFastDwn"
        Me.BtnLvlFastDwn.Size = New System.Drawing.Size(41, 20)
        Me.BtnLvlFastDwn.TabIndex = 103
        Me.BtnLvlFastDwn.Text = "<<"
        Me.ToolTip1.SetToolTip(Me.BtnLvlFastDwn, "Go back to last Level before Fast Level Up")
        Me.BtnLvlFastDwn.UseCompatibleTextRendering = True
        Me.BtnLvlFastDwn.UseVisualStyleBackColor = False
        Me.BtnLvlFastDwn.Visible = False
        '
        'BtnLvlDwn
        '
        Me.BtnLvlDwn.BackColor = System.Drawing.Color.Transparent
        Me.BtnLvlDwn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLvlDwn.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnLvlDwn.FlatAppearance.BorderSize = 0
        Me.BtnLvlDwn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnLvlDwn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnLvlDwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLvlDwn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLvlDwn.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnLvlDwn.Location = New System.Drawing.Point(628, 313)
        Me.BtnLvlDwn.Name = "BtnLvlDwn"
        Me.BtnLvlDwn.Size = New System.Drawing.Size(25, 20)
        Me.BtnLvlDwn.TabIndex = 47
        Me.BtnLvlDwn.Text = "<"
        Me.ToolTip1.SetToolTip(Me.BtnLvlDwn, "Go 1 Level down")
        Me.BtnLvlDwn.UseCompatibleTextRendering = True
        Me.BtnLvlDwn.UseVisualStyleBackColor = False
        Me.BtnLvlDwn.Visible = False
        '
        'BtnMusicVolDown
        '
        Me.BtnMusicVolDown.BackColor = System.Drawing.Color.Black
        Me.BtnMusicVolDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMusicVolDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnMusicVolDown.FlatAppearance.BorderSize = 0
        Me.BtnMusicVolDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnMusicVolDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnMusicVolDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMusicVolDown.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMusicVolDown.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnMusicVolDown.Location = New System.Drawing.Point(708, 4)
        Me.BtnMusicVolDown.Name = "BtnMusicVolDown"
        Me.BtnMusicVolDown.Size = New System.Drawing.Size(15, 15)
        Me.BtnMusicVolDown.TabIndex = 112
        Me.BtnMusicVolDown.Text = "-"
        Me.ToolTip1.SetToolTip(Me.BtnMusicVolDown, "Go 1 Level down")
        Me.BtnMusicVolDown.UseCompatibleTextRendering = True
        Me.BtnMusicVolDown.UseVisualStyleBackColor = False
        Me.BtnMusicVolDown.Visible = False
        '
        'BtnMusicVolUp
        '
        Me.BtnMusicVolUp.BackColor = System.Drawing.Color.Black
        Me.BtnMusicVolUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMusicVolUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnMusicVolUp.FlatAppearance.BorderSize = 0
        Me.BtnMusicVolUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnMusicVolUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnMusicVolUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMusicVolUp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMusicVolUp.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnMusicVolUp.Location = New System.Drawing.Point(772, 3)
        Me.BtnMusicVolUp.Name = "BtnMusicVolUp"
        Me.BtnMusicVolUp.Size = New System.Drawing.Size(15, 15)
        Me.BtnMusicVolUp.TabIndex = 113
        Me.BtnMusicVolUp.Text = "+"
        Me.ToolTip1.SetToolTip(Me.BtnMusicVolUp, "Go 1 Level down")
        Me.BtnMusicVolUp.UseCompatibleTextRendering = True
        Me.BtnMusicVolUp.UseVisualStyleBackColor = False
        Me.BtnMusicVolUp.Visible = False
        '
        'BtnDrugsCigs
        '
        Me.BtnDrugsCigs.BackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsCigs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDrugsCigs.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDrugsCigs.FlatAppearance.BorderSize = 0
        Me.BtnDrugsCigs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnDrugsCigs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsCigs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDrugsCigs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrugsCigs.ForeColor = System.Drawing.Color.White
        Me.BtnDrugsCigs.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.CigarettesNew
        Me.BtnDrugsCigs.Location = New System.Drawing.Point(142, -2)
        Me.BtnDrugsCigs.Name = "BtnDrugsCigs"
        Me.BtnDrugsCigs.Size = New System.Drawing.Size(32, 30)
        Me.BtnDrugsCigs.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.BtnDrugsCigs, "Cigarettes")
        Me.BtnDrugsCigs.UseCompatibleTextRendering = True
        Me.BtnDrugsCigs.UseVisualStyleBackColor = False
        '
        'BtnDrugsNuka
        '
        Me.BtnDrugsNuka.BackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsNuka.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDrugsNuka.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDrugsNuka.FlatAppearance.BorderSize = 0
        Me.BtnDrugsNuka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnDrugsNuka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsNuka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDrugsNuka.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrugsNuka.ForeColor = System.Drawing.Color.White
        Me.BtnDrugsNuka.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.Nuka
        Me.BtnDrugsNuka.Location = New System.Drawing.Point(107, -1)
        Me.BtnDrugsNuka.Name = "BtnDrugsNuka"
        Me.BtnDrugsNuka.Size = New System.Drawing.Size(30, 29)
        Me.BtnDrugsNuka.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.BtnDrugsNuka, "Nuka Cola")
        Me.BtnDrugsNuka.UseCompatibleTextRendering = True
        Me.BtnDrugsNuka.UseVisualStyleBackColor = False
        '
        'BtnDrugsPsycho
        '
        Me.BtnDrugsPsycho.BackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsPsycho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDrugsPsycho.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDrugsPsycho.FlatAppearance.BorderSize = 0
        Me.BtnDrugsPsycho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnDrugsPsycho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsPsycho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDrugsPsycho.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrugsPsycho.ForeColor = System.Drawing.Color.White
        Me.BtnDrugsPsycho.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.Psycho
        Me.BtnDrugsPsycho.Location = New System.Drawing.Point(73, -1)
        Me.BtnDrugsPsycho.Name = "BtnDrugsPsycho"
        Me.BtnDrugsPsycho.Size = New System.Drawing.Size(34, 28)
        Me.BtnDrugsPsycho.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.BtnDrugsPsycho, "Psycho")
        Me.BtnDrugsPsycho.UseCompatibleTextRendering = True
        Me.BtnDrugsPsycho.UseVisualStyleBackColor = False
        '
        'BtnDrugsBuff
        '
        Me.BtnDrugsBuff.BackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsBuff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDrugsBuff.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDrugsBuff.FlatAppearance.BorderSize = 0
        Me.BtnDrugsBuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnDrugsBuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDrugsBuff.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrugsBuff.ForeColor = System.Drawing.Color.White
        Me.BtnDrugsBuff.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.BuffoutNew
        Me.BtnDrugsBuff.Location = New System.Drawing.Point(37, 0)
        Me.BtnDrugsBuff.Name = "BtnDrugsBuff"
        Me.BtnDrugsBuff.Size = New System.Drawing.Size(32, 29)
        Me.BtnDrugsBuff.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.BtnDrugsBuff, "Buffout")
        Me.BtnDrugsBuff.UseCompatibleTextRendering = True
        Me.BtnDrugsBuff.UseVisualStyleBackColor = False
        '
        'BtnDrugsJet
        '
        Me.BtnDrugsJet.BackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsJet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDrugsJet.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDrugsJet.FlatAppearance.BorderSize = 0
        Me.BtnDrugsJet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnDrugsJet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDrugsJet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDrugsJet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrugsJet.ForeColor = System.Drawing.Color.White
        Me.BtnDrugsJet.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.Jet
        Me.BtnDrugsJet.Location = New System.Drawing.Point(0, 0)
        Me.BtnDrugsJet.Name = "BtnDrugsJet"
        Me.BtnDrugsJet.Size = New System.Drawing.Size(31, 29)
        Me.BtnDrugsJet.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.BtnDrugsJet, "Jet")
        Me.BtnDrugsJet.UseCompatibleTextRendering = True
        Me.BtnDrugsJet.UseVisualStyleBackColor = False
        '
        'BtnAllDrugs
        '
        Me.BtnAllDrugs.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnAllDrugs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAllDrugs.Enabled = False
        Me.BtnAllDrugs.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnAllDrugs.FlatAppearance.BorderSize = 0
        Me.BtnAllDrugs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnAllDrugs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnAllDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAllDrugs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAllDrugs.ForeColor = System.Drawing.Color.Tomato
        Me.BtnAllDrugs.Location = New System.Drawing.Point(241, 363)
        Me.BtnAllDrugs.Name = "BtnAllDrugs"
        Me.BtnAllDrugs.Size = New System.Drawing.Size(34, 25)
        Me.BtnAllDrugs.TabIndex = 118
        Me.BtnAllDrugs.Text = "All"
        Me.ToolTip1.SetToolTip(Me.BtnAllDrugs, "Take all Drugs at once")
        Me.BtnAllDrugs.UseCompatibleTextRendering = True
        Me.BtnAllDrugs.UseVisualStyleBackColor = False
        '
        'BtnMscStop
        '
        Me.BtnMscStop.BackColor = System.Drawing.Color.Black
        Me.BtnMscStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMscStop.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnMscStop.FlatAppearance.BorderSize = 0
        Me.BtnMscStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnMscStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnMscStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMscStop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMscStop.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnMscStop.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources._Stop
        Me.BtnMscStop.Location = New System.Drawing.Point(143, 0)
        Me.BtnMscStop.Name = "BtnMscStop"
        Me.BtnMscStop.Size = New System.Drawing.Size(18, 20)
        Me.BtnMscStop.TabIndex = 99
        Me.BtnMscStop.UseCompatibleTextRendering = True
        Me.BtnMscStop.UseVisualStyleBackColor = False
        Me.BtnMscStop.Visible = False
        '
        'BtnDone
        '
        Me.BtnDone.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDone.Enabled = False
        Me.BtnDone.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDone.FlatAppearance.BorderSize = 0
        Me.BtnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDone.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnDone.Location = New System.Drawing.Point(512, 309)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(96, 28)
        Me.BtnDone.TabIndex = 44
        Me.BtnDone.Text = "Done"
        Me.BtnDone.UseCompatibleTextRendering = True
        Me.BtnDone.UseVisualStyleBackColor = False
        '
        'LstVPerks
        '
        Me.LstVPerks.BackColor = System.Drawing.Color.Black
        Me.LstVPerks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstVPerks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstVPerks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVPerks.ForeColor = System.Drawing.Color.Chartreuse
        Me.LstVPerks.LabelWrap = False
        Me.LstVPerks.Location = New System.Drawing.Point(512, 132)
        Me.LstVPerks.MultiSelect = False
        Me.LstVPerks.Name = "LstVPerks"
        Me.LstVPerks.OwnerDraw = True
        Me.LstVPerks.ShowItemToolTips = True
        Me.LstVPerks.Size = New System.Drawing.Size(213, 143)
        Me.LstVPerks.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVPerks.TabIndex = 45
        Me.LstVPerks.TabStop = False
        Me.LstVPerks.TileSize = New System.Drawing.Size(168, 15)
        Me.LstVPerks.UseCompatibleStateImageBehavior = False
        Me.LstVPerks.View = System.Windows.Forms.View.Tile
        '
        'LblLevel
        '
        Me.LblLevel.AutoSize = True
        Me.LblLevel.BackColor = System.Drawing.Color.Transparent
        Me.LblLevel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevel.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblLevel.Location = New System.Drawing.Point(655, 315)
        Me.LblLevel.Name = "LblLevel"
        Me.LblLevel.Size = New System.Drawing.Size(42, 16)
        Me.LblLevel.TabIndex = 48
        Me.LblLevel.Text = "Level"
        Me.LblLevel.Visible = False
        '
        'LblCBoxBooks
        '
        Me.LblCBoxBooks.AutoSize = True
        Me.LblCBoxBooks.BackColor = System.Drawing.Color.Transparent
        Me.LblCBoxBooks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCBoxBooks.ForeColor = System.Drawing.Color.LawnGreen
        Me.LblCBoxBooks.Location = New System.Drawing.Point(754, 75)
        Me.LblCBoxBooks.Name = "LblCBoxBooks"
        Me.LblCBoxBooks.Size = New System.Drawing.Size(35, 13)
        Me.LblCBoxBooks.TabIndex = 51
        Me.LblCBoxBooks.Text = "Books"
        Me.LblCBoxBooks.Visible = False
        '
        'LblPTraitsTaken
        '
        Me.LblPTraitsTaken.AutoSize = True
        Me.LblPTraitsTaken.BackColor = System.Drawing.Color.Transparent
        Me.LblPTraitsTaken.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPTraitsTaken.ForeColor = System.Drawing.Color.Gold
        Me.LblPTraitsTaken.Location = New System.Drawing.Point(237, 406)
        Me.LblPTraitsTaken.Name = "LblPTraitsTaken"
        Me.LblPTraitsTaken.Size = New System.Drawing.Size(131, 16)
        Me.LblPTraitsTaken.TabIndex = 53
        Me.LblPTraitsTaken.Text = "Perks/Traits Taken"
        '
        'LblPerks
        '
        Me.LblPerks.AutoSize = True
        Me.LblPerks.BackColor = System.Drawing.Color.Transparent
        Me.LblPerks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPerks.ForeColor = System.Drawing.Color.Gold
        Me.LblPerks.Location = New System.Drawing.Point(509, 113)
        Me.LblPerks.Name = "LblPerks"
        Me.LblPerks.Size = New System.Drawing.Size(44, 16)
        Me.LblPerks.TabIndex = 57
        Me.LblPerks.Text = "Perks"
        '
        'BtnSkUp
        '
        Me.BtnSkUp.BackColor = System.Drawing.Color.Transparent
        Me.BtnSkUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSkUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnSkUp.FlatAppearance.BorderSize = 0
        Me.BtnSkUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnSkUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnSkUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSkUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSkUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnSkUp.Location = New System.Drawing.Point(1, 3)
        Me.BtnSkUp.Name = "BtnSkUp"
        Me.BtnSkUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnSkUp.TabIndex = 44
        Me.BtnSkUp.Text = "+"
        Me.BtnSkUp.UseCompatibleTextRendering = True
        Me.BtnSkUp.UseVisualStyleBackColor = False
        '
        'BtnSkDown
        '
        Me.BtnSkDown.BackColor = System.Drawing.Color.Transparent
        Me.BtnSkDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSkDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnSkDown.FlatAppearance.BorderSize = 0
        Me.BtnSkDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnSkDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnSkDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSkDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSkDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnSkDown.Location = New System.Drawing.Point(1, 23)
        Me.BtnSkDown.Name = "BtnSkDown"
        Me.BtnSkDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnSkDown.TabIndex = 44
        Me.BtnSkDown.Text = "-"
        Me.BtnSkDown.UseCompatibleTextRendering = True
        Me.BtnSkDown.UseVisualStyleBackColor = False
        '
        'PanSkUpDown
        '
        Me.PanSkUpDown.BackColor = System.Drawing.Color.Transparent
        Me.PanSkUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanSkUpDown.Controls.Add(Me.BtnSkUp)
        Me.PanSkUpDown.Controls.Add(Me.BtnSkDown)
        Me.PanSkUpDown.Location = New System.Drawing.Point(459, 48)
        Me.PanSkUpDown.Name = "PanSkUpDown"
        Me.PanSkUpDown.Size = New System.Drawing.Size(20, 42)
        Me.PanSkUpDown.TabIndex = 60
        '
        'BtnPerkLater
        '
        Me.BtnPerkLater.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnPerkLater.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPerkLater.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnPerkLater.FlatAppearance.BorderSize = 0
        Me.BtnPerkLater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnPerkLater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnPerkLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPerkLater.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPerkLater.ForeColor = System.Drawing.Color.Tomato
        Me.BtnPerkLater.Location = New System.Drawing.Point(512, 279)
        Me.BtnPerkLater.Name = "BtnPerkLater"
        Me.BtnPerkLater.Size = New System.Drawing.Size(96, 23)
        Me.BtnPerkLater.TabIndex = 62
        Me.BtnPerkLater.Text = "Take Later"
        Me.BtnPerkLater.UseCompatibleTextRendering = True
        Me.BtnPerkLater.UseVisualStyleBackColor = False
        Me.BtnPerkLater.Visible = False
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.Black
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem1, Me.MusicToolStrMenu})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(789, 24)
        Me.MainMenu.TabIndex = 65
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveBuildToolStripMenuItem, Me.LoadBuildToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Coral
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveBuildToolStripMenuItem
        '
        Me.SaveBuildToolStripMenuItem.Enabled = False
        Me.SaveBuildToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBuildToolStripMenuItem.Name = "SaveBuildToolStripMenuItem"
        Me.SaveBuildToolStripMenuItem.ShowShortcutKeys = False
        Me.SaveBuildToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SaveBuildToolStripMenuItem.Text = "Save Build"
        '
        'LoadBuildToolStripMenuItem
        '
        Me.LoadBuildToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBuildToolStripMenuItem.Name = "LoadBuildToolStripMenuItem"
        Me.LoadBuildToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LoadBuildToolStripMenuItem.Text = "Load Build"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsImageToolStripMenuItem})
        Me.ExportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'AsImageToolStripMenuItem
        '
        Me.AsImageToolStripMenuItem.Name = "AsImageToolStripMenuItem"
        Me.AsImageToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AsImageToolStripMenuItem.Text = "As Image"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Coral
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeyDisplayString = "I"
        Me.ToolStripMenuItem1.ShowShortcutKeys = False
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(42, 20)
        Me.ToolStripMenuItem1.Text = "Info"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.ShowShortcutKeys = False
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem2.Text = "About"
        '
        'MusicToolStrMenu
        '
        Me.MusicToolStrMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MusicToolStrMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MOnToolStripMenuItem, Me.MOffToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MusicToolStrMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicToolStrMenu.ForeColor = System.Drawing.Color.Coral
        Me.MusicToolStrMenu.Name = "MusicToolStrMenu"
        Me.MusicToolStrMenu.ShortcutKeyDisplayString = "I"
        Me.MusicToolStrMenu.ShowShortcutKeys = False
        Me.MusicToolStrMenu.Size = New System.Drawing.Size(51, 20)
        Me.MusicToolStrMenu.Text = "Music"
        '
        'MOnToolStripMenuItem
        '
        Me.MOnToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOnToolStripMenuItem.Name = "MOnToolStripMenuItem"
        Me.MOnToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MOnToolStripMenuItem.ShowShortcutKeys = False
        Me.MOnToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.MOnToolStripMenuItem.Text = "On"
        '
        'MOffToolStripMenuItem
        '
        Me.MOffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOffToolStripMenuItem.Name = "MOffToolStripMenuItem"
        Me.MOffToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.MOffToolStripMenuItem.Text = "Off"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'BtnBooks
        '
        Me.BtnBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnBooks.FlatAppearance.BorderSize = 0
        Me.BtnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBooks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBooks.ForeColor = System.Drawing.Color.LightGray
        Me.BtnBooks.Location = New System.Drawing.Point(512, 52)
        Me.BtnBooks.Name = "BtnBooks"
        Me.BtnBooks.Size = New System.Drawing.Size(93, 23)
        Me.BtnBooks.TabIndex = 67
        Me.BtnBooks.Text = "Books"
        Me.BtnBooks.UseCompatibleTextRendering = True
        Me.BtnBooks.UseVisualStyleBackColor = False
        Me.BtnBooks.Visible = False
        '
        'BtnImpl
        '
        Me.BtnImpl.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.BtnImpl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImpl.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnImpl.FlatAppearance.BorderSize = 0
        Me.BtnImpl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnImpl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnImpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImpl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImpl.ForeColor = System.Drawing.Color.LightGray
        Me.BtnImpl.Location = New System.Drawing.Point(629, 52)
        Me.BtnImpl.Name = "BtnImpl"
        Me.BtnImpl.Size = New System.Drawing.Size(93, 23)
        Me.BtnImpl.TabIndex = 68
        Me.BtnImpl.Text = "Implants"
        Me.BtnImpl.UseCompatibleTextRendering = True
        Me.BtnImpl.UseVisualStyleBackColor = False
        Me.BtnImpl.Visible = False
        '
        'BtnQuests
        '
        Me.BtnQuests.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.BtnQuests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuests.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnQuests.FlatAppearance.BorderSize = 0
        Me.BtnQuests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnQuests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuests.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuests.ForeColor = System.Drawing.Color.LightGray
        Me.BtnQuests.Location = New System.Drawing.Point(512, 80)
        Me.BtnQuests.Name = "BtnQuests"
        Me.BtnQuests.Size = New System.Drawing.Size(93, 23)
        Me.BtnQuests.TabIndex = 69
        Me.BtnQuests.Text = "Quests"
        Me.BtnQuests.UseCompatibleTextRendering = True
        Me.BtnQuests.UseVisualStyleBackColor = False
        Me.BtnQuests.Visible = False
        '
        'BtnAchievem
        '
        Me.BtnAchievem.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.BtnAchievem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAchievem.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnAchievem.FlatAppearance.BorderSize = 0
        Me.BtnAchievem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnAchievem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BtnAchievem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAchievem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAchievem.ForeColor = System.Drawing.Color.LightGray
        Me.BtnAchievem.Location = New System.Drawing.Point(629, 80)
        Me.BtnAchievem.Name = "BtnAchievem"
        Me.BtnAchievem.Size = New System.Drawing.Size(93, 23)
        Me.BtnAchievem.TabIndex = 70
        Me.BtnAchievem.Text = "Achievements"
        Me.BtnAchievem.UseCompatibleTextRendering = True
        Me.BtnAchievem.UseVisualStyleBackColor = False
        Me.BtnAchievem.Visible = False
        '
        'LstVBooks
        '
        Me.LstVBooks.BackColor = System.Drawing.Color.Black
        Me.LstVBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstVBooks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LstVBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstVBooks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVBooks.ForeColor = System.Drawing.Color.Chartreuse
        Me.LstVBooks.FullRowSelect = True
        Me.LstVBooks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LstVBooks.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.LstVBooks.LabelWrap = False
        Me.LstVBooks.Location = New System.Drawing.Point(512, 132)
        Me.LstVBooks.MultiSelect = False
        Me.LstVBooks.Name = "LstVBooks"
        Me.LstVBooks.OwnerDraw = True
        Me.LstVBooks.ShowItemToolTips = True
        Me.LstVBooks.Size = New System.Drawing.Size(213, 107)
        Me.LstVBooks.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVBooks.TabIndex = 71
        Me.LstVBooks.TabStop = False
        Me.LstVBooks.TileSize = New System.Drawing.Size(168, 15)
        Me.LstVBooks.UseCompatibleStateImageBehavior = False
        Me.LstVBooks.View = System.Windows.Forms.View.Details
        Me.LstVBooks.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Book Type"
        Me.ColumnHeader1.Width = 136
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.Width = 69
        '
        'BtnBookValDown
        '
        Me.BtnBookValDown.BackColor = System.Drawing.Color.Black
        Me.BtnBookValDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBookValDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnBookValDown.FlatAppearance.BorderSize = 0
        Me.BtnBookValDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnBookValDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.BtnBookValDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBookValDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookValDown.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnBookValDown.Location = New System.Drawing.Point(112, 12)
        Me.BtnBookValDown.Name = "BtnBookValDown"
        Me.BtnBookValDown.Size = New System.Drawing.Size(16, 16)
        Me.BtnBookValDown.TabIndex = 47
        Me.BtnBookValDown.Text = "-"
        Me.BtnBookValDown.UseCompatibleTextRendering = True
        Me.BtnBookValDown.UseVisualStyleBackColor = False
        '
        'BtnBookValUp
        '
        Me.BtnBookValUp.BackColor = System.Drawing.Color.Black
        Me.BtnBookValUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBookValUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnBookValUp.FlatAppearance.BorderSize = 0
        Me.BtnBookValUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnBookValUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.BtnBookValUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBookValUp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookValUp.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnBookValUp.Location = New System.Drawing.Point(130, 12)
        Me.BtnBookValUp.Name = "BtnBookValUp"
        Me.BtnBookValUp.Size = New System.Drawing.Size(16, 16)
        Me.BtnBookValUp.TabIndex = 46
        Me.BtnBookValUp.Text = "+"
        Me.BtnBookValUp.UseCompatibleTextRendering = True
        Me.BtnBookValUp.UseVisualStyleBackColor = False
        '
        'LblBookAmVal
        '
        Me.LblBookAmVal.AutoSize = True
        Me.LblBookAmVal.BackColor = System.Drawing.Color.Black
        Me.LblBookAmVal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookAmVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblBookAmVal.Location = New System.Drawing.Point(88, 10)
        Me.LblBookAmVal.Name = "LblBookAmVal"
        Me.LblBookAmVal.Size = New System.Drawing.Size(18, 18)
        Me.LblBookAmVal.TabIndex = 45
        Me.LblBookAmVal.Text = "1"
        '
        'LblBookAmount
        '
        Me.LblBookAmount.AutoSize = True
        Me.LblBookAmount.BackColor = System.Drawing.Color.Black
        Me.LblBookAmount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblBookAmount.Location = New System.Drawing.Point(8, 10)
        Me.LblBookAmount.Name = "LblBookAmount"
        Me.LblBookAmount.Size = New System.Drawing.Size(64, 18)
        Me.LblBookAmount.TabIndex = 44
        Me.LblBookAmount.Text = "Amount"
        '
        'BtnBookDone
        '
        Me.BtnBookDone.BackColor = System.Drawing.Color.Black
        Me.BtnBookDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBookDone.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnBookDone.FlatAppearance.BorderSize = 0
        Me.BtnBookDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnBookDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.BtnBookDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBookDone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBookDone.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnBookDone.Location = New System.Drawing.Point(155, 7)
        Me.BtnBookDone.Name = "BtnBookDone"
        Me.BtnBookDone.Size = New System.Drawing.Size(55, 21)
        Me.BtnBookDone.TabIndex = 72
        Me.BtnBookDone.Text = "Take"
        Me.BtnBookDone.UseCompatibleTextRendering = True
        Me.BtnBookDone.UseVisualStyleBackColor = False
        '
        'LblBooks
        '
        Me.LblBooks.AutoSize = True
        Me.LblBooks.BackColor = System.Drawing.Color.Transparent
        Me.LblBooks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBooks.ForeColor = System.Drawing.Color.Gold
        Me.LblBooks.Location = New System.Drawing.Point(509, 113)
        Me.LblBooks.Name = "LblBooks"
        Me.LblBooks.Size = New System.Drawing.Size(46, 16)
        Me.LblBooks.TabIndex = 73
        Me.LblBooks.Text = "Books"
        Me.LblBooks.Visible = False
        '
        'PanBookValEdit
        '
        Me.PanBookValEdit.BackColor = System.Drawing.Color.Black
        Me.PanBookValEdit.Controls.Add(Me.LblBookAmount)
        Me.PanBookValEdit.Controls.Add(Me.LblBookAmVal)
        Me.PanBookValEdit.Controls.Add(Me.BtnBookDone)
        Me.PanBookValEdit.Controls.Add(Me.BtnBookValUp)
        Me.PanBookValEdit.Controls.Add(Me.BtnBookValDown)
        Me.PanBookValEdit.Location = New System.Drawing.Point(512, 238)
        Me.PanBookValEdit.Name = "PanBookValEdit"
        Me.PanBookValEdit.Size = New System.Drawing.Size(213, 37)
        Me.PanBookValEdit.TabIndex = 74
        Me.PanBookValEdit.Visible = False
        '
        'LblDetailedDesc
        '
        Me.LblDetailedDesc.AutoSize = True
        Me.LblDetailedDesc.BackColor = System.Drawing.Color.Transparent
        Me.LblDetailedDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblDetailedDesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetailedDesc.ForeColor = System.Drawing.Color.LightCyan
        Me.LblDetailedDesc.Location = New System.Drawing.Point(633, 367)
        Me.LblDetailedDesc.Name = "LblDetailedDesc"
        Me.LblDetailedDesc.Size = New System.Drawing.Size(121, 13)
        Me.LblDetailedDesc.TabIndex = 75
        Me.LblDetailedDesc.Text = "Detailed Description"
        '
        'LblBMentats
        '
        Me.LblBMentats.AutoSize = True
        Me.LblBMentats.BackColor = System.Drawing.Color.Transparent
        Me.LblBMentats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblBMentats.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBMentats.ForeColor = System.Drawing.Color.LightSalmon
        Me.LblBMentats.Location = New System.Drawing.Point(628, 281)
        Me.LblBMentats.Name = "LblBMentats"
        Me.LblBMentats.Size = New System.Drawing.Size(97, 16)
        Me.LblBMentats.TabIndex = 77
        Me.LblBMentats.Text = "+2 (Mentats)"
        Me.LblBMentats.Visible = False
        '
        'LblImpl
        '
        Me.LblImpl.AutoSize = True
        Me.LblImpl.BackColor = System.Drawing.Color.Transparent
        Me.LblImpl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblImpl.ForeColor = System.Drawing.Color.Gold
        Me.LblImpl.Location = New System.Drawing.Point(509, 110)
        Me.LblImpl.Name = "LblImpl"
        Me.LblImpl.Size = New System.Drawing.Size(64, 16)
        Me.LblImpl.TabIndex = 78
        Me.LblImpl.Text = "Implants"
        Me.LblImpl.Visible = False
        '
        'LstVImpl
        '
        Me.LstVImpl.BackColor = System.Drawing.Color.Black
        Me.LstVImpl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstVImpl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstVImpl.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVImpl.ForeColor = System.Drawing.Color.Chartreuse
        Me.LstVImpl.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15})
        Me.LstVImpl.LabelWrap = False
        Me.LstVImpl.Location = New System.Drawing.Point(512, 132)
        Me.LstVImpl.MultiSelect = False
        Me.LstVImpl.Name = "LstVImpl"
        Me.LstVImpl.OwnerDraw = True
        Me.LstVImpl.ShowItemToolTips = True
        Me.LstVImpl.Size = New System.Drawing.Size(213, 143)
        Me.LstVImpl.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVImpl.TabIndex = 79
        Me.LstVImpl.TabStop = False
        Me.LstVImpl.TileSize = New System.Drawing.Size(168, 15)
        Me.LstVImpl.UseCompatibleStateImageBehavior = False
        Me.LstVImpl.View = System.Windows.Forms.View.Tile
        Me.LstVImpl.Visible = False
        '
        'LstVQuests
        '
        Me.LstVQuests.BackColor = System.Drawing.Color.Black
        Me.LstVQuests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstVQuests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstVQuests.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVQuests.ForeColor = System.Drawing.Color.Chartreuse
        Me.LstVQuests.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem16, ListViewItem17})
        Me.LstVQuests.LabelWrap = False
        Me.LstVQuests.Location = New System.Drawing.Point(512, 132)
        Me.LstVQuests.MultiSelect = False
        Me.LstVQuests.Name = "LstVQuests"
        Me.LstVQuests.OwnerDraw = True
        Me.LstVQuests.ShowItemToolTips = True
        Me.LstVQuests.Size = New System.Drawing.Size(213, 143)
        Me.LstVQuests.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVQuests.TabIndex = 81
        Me.LstVQuests.TabStop = False
        Me.LstVQuests.TileSize = New System.Drawing.Size(168, 15)
        Me.LstVQuests.UseCompatibleStateImageBehavior = False
        Me.LstVQuests.View = System.Windows.Forms.View.Tile
        Me.LstVQuests.Visible = False
        '
        'LblQuests
        '
        Me.LblQuests.AutoSize = True
        Me.LblQuests.BackColor = System.Drawing.Color.Transparent
        Me.LblQuests.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuests.ForeColor = System.Drawing.Color.Gold
        Me.LblQuests.Location = New System.Drawing.Point(509, 110)
        Me.LblQuests.Name = "LblQuests"
        Me.LblQuests.Size = New System.Drawing.Size(53, 16)
        Me.LblQuests.TabIndex = 82
        Me.LblQuests.Text = "Quests"
        Me.LblQuests.Visible = False
        '
        'LstVAchiev
        '
        Me.LstVAchiev.BackColor = System.Drawing.Color.Black
        Me.LstVAchiev.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstVAchiev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstVAchiev.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVAchiev.ForeColor = System.Drawing.Color.Chartreuse
        Me.LstVAchiev.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25})
        Me.LstVAchiev.LabelWrap = False
        Me.LstVAchiev.Location = New System.Drawing.Point(512, 132)
        Me.LstVAchiev.MultiSelect = False
        Me.LstVAchiev.Name = "LstVAchiev"
        Me.LstVAchiev.OwnerDraw = True
        Me.LstVAchiev.ShowItemToolTips = True
        Me.LstVAchiev.Size = New System.Drawing.Size(213, 143)
        Me.LstVAchiev.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVAchiev.TabIndex = 84
        Me.LstVAchiev.TabStop = False
        Me.LstVAchiev.TileSize = New System.Drawing.Size(168, 15)
        Me.LstVAchiev.UseCompatibleStateImageBehavior = False
        Me.LstVAchiev.View = System.Windows.Forms.View.Tile
        Me.LstVAchiev.Visible = False
        '
        'LblAchieve
        '
        Me.LblAchieve.AutoSize = True
        Me.LblAchieve.BackColor = System.Drawing.Color.Transparent
        Me.LblAchieve.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAchieve.ForeColor = System.Drawing.Color.Gold
        Me.LblAchieve.Location = New System.Drawing.Point(510, 114)
        Me.LblAchieve.Name = "LblAchieve"
        Me.LblAchieve.Size = New System.Drawing.Size(100, 16)
        Me.LblAchieve.TabIndex = 85
        Me.LblAchieve.Text = "Achievements"
        Me.LblAchieve.Visible = False
        '
        'LstVChess
        '
        Me.LstVChess.BackColor = System.Drawing.Color.Black
        Me.LstVChess.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstVChess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstVChess.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstVChess.ForeColor = System.Drawing.Color.Chartreuse
        Me.LstVChess.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem26, ListViewItem27, ListViewItem28})
        Me.LstVChess.LabelWrap = False
        Me.LstVChess.Location = New System.Drawing.Point(512, 132)
        Me.LstVChess.MultiSelect = False
        Me.LstVChess.Name = "LstVChess"
        Me.LstVChess.OwnerDraw = True
        Me.LstVChess.ShowItemToolTips = True
        Me.LstVChess.Size = New System.Drawing.Size(213, 143)
        Me.LstVChess.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.LstVChess.TabIndex = 86
        Me.LstVChess.TabStop = False
        Me.LstVChess.TileSize = New System.Drawing.Size(168, 15)
        Me.LstVChess.UseCompatibleStateImageBehavior = False
        Me.LstVChess.View = System.Windows.Forms.View.Tile
        Me.LstVChess.Visible = False
        '
        'LblChessRew
        '
        Me.LblChessRew.AutoSize = True
        Me.LblChessRew.BackColor = System.Drawing.Color.Transparent
        Me.LblChessRew.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChessRew.ForeColor = System.Drawing.Color.Gold
        Me.LblChessRew.Location = New System.Drawing.Point(511, 115)
        Me.LblChessRew.Name = "LblChessRew"
        Me.LblChessRew.Size = New System.Drawing.Size(121, 16)
        Me.LblChessRew.TabIndex = 87
        Me.LblChessRew.Text = "Choose a Reward"
        Me.LblChessRew.Visible = False
        '
        'BtnBooksAll
        '
        Me.BtnBooksAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnBooksAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBooksAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnBooksAll.FlatAppearance.BorderSize = 0
        Me.BtnBooksAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnBooksAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnBooksAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBooksAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBooksAll.ForeColor = System.Drawing.Color.Tomato
        Me.BtnBooksAll.Location = New System.Drawing.Point(512, 282)
        Me.BtnBooksAll.Name = "BtnBooksAll"
        Me.BtnBooksAll.Size = New System.Drawing.Size(96, 23)
        Me.BtnBooksAll.TabIndex = 88
        Me.BtnBooksAll.Text = "Take All"
        Me.BtnBooksAll.UseCompatibleTextRendering = True
        Me.BtnBooksAll.UseVisualStyleBackColor = False
        Me.BtnBooksAll.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.LightGreen
        Me.Label3.Location = New System.Drawing.Point(456, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(456, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.LightGreen
        Me.Label2.Location = New System.Drawing.Point(459, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.LightGreen
        Me.Label8.Location = New System.Drawing.Point(34, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Label8"
        Me.Label8.Visible = False
        '
        'BtnMscPlay
        '
        Me.BtnMscPlay.BackColor = System.Drawing.Color.Black
        Me.BtnMscPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMscPlay.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnMscPlay.FlatAppearance.BorderSize = 0
        Me.BtnMscPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnMscPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnMscPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMscPlay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMscPlay.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnMscPlay.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.Play
        Me.BtnMscPlay.Location = New System.Drawing.Point(140, 0)
        Me.BtnMscPlay.Name = "BtnMscPlay"
        Me.BtnMscPlay.Size = New System.Drawing.Size(25, 20)
        Me.BtnMscPlay.TabIndex = 100
        Me.BtnMscPlay.UseCompatibleTextRendering = True
        Me.BtnMscPlay.UseVisualStyleBackColor = False
        Me.BtnMscPlay.Visible = False
        '
        'BtnMscSkip
        '
        Me.BtnMscSkip.BackColor = System.Drawing.Color.Black
        Me.BtnMscSkip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMscSkip.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnMscSkip.FlatAppearance.BorderSize = 0
        Me.BtnMscSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnMscSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnMscSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMscSkip.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMscSkip.ForeColor = System.Drawing.Color.YellowGreen
        Me.BtnMscSkip.Image = Global.FOnline_2_Char_Planner.My.Resources.Resources.Skip
        Me.BtnMscSkip.Location = New System.Drawing.Point(160, -1)
        Me.BtnMscSkip.Name = "BtnMscSkip"
        Me.BtnMscSkip.Size = New System.Drawing.Size(26, 22)
        Me.BtnMscSkip.TabIndex = 101
        Me.BtnMscSkip.UseCompatibleTextRendering = True
        Me.BtnMscSkip.UseVisualStyleBackColor = False
        Me.BtnMscSkip.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LblTODocVal)
        Me.Panel2.Controls.Add(Me.LblTOFAVal)
        Me.Panel2.Controls.Add(Me.LblTODoc)
        Me.Panel2.Controls.Add(Me.LblTOFA)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(17, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(117, 37)
        Me.Panel2.TabIndex = 22
        '
        'LblTODocVal
        '
        Me.LblTODocVal.AutoSize = True
        Me.LblTODocVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTODocVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTODocVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTODocVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTODocVal.Location = New System.Drawing.Point(76, 18)
        Me.LblTODocVal.Name = "LblTODocVal"
        Me.LblTODocVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTODocVal.Size = New System.Drawing.Size(39, 15)
        Me.LblTODocVal.TabIndex = 67
        Me.LblTODocVal.Tag = "dim iSecond as double = 0 'Total number of seconds"
        Me.LblTODocVal.Text = "10:00"
        '
        'LblTOFAVal
        '
        Me.LblTOFAVal.AutoSize = True
        Me.LblTOFAVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTOFAVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTOFAVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTOFAVal.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTOFAVal.Location = New System.Drawing.Point(76, 3)
        Me.LblTOFAVal.Name = "LblTOFAVal"
        Me.LblTOFAVal.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTOFAVal.Size = New System.Drawing.Size(39, 15)
        Me.LblTOFAVal.TabIndex = 66
        Me.LblTOFAVal.Tag = "dim iSecond as double = 0 'Total number of seconds"
        Me.LblTOFAVal.Text = "07:30"
        '
        'LblTODoc
        '
        Me.LblTODoc.AutoSize = True
        Me.LblTODoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTODoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTODoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTODoc.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTODoc.Location = New System.Drawing.Point(3, 18)
        Me.LblTODoc.Name = "LblTODoc"
        Me.LblTODoc.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTODoc.Size = New System.Drawing.Size(57, 15)
        Me.LblTODoc.TabIndex = 64
        Me.LblTODoc.Text = "Doctor cd"
        '
        'LblTOFA
        '
        Me.LblTOFA.AutoSize = True
        Me.LblTOFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.LblTOFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTOFA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTOFA.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblTOFA.Location = New System.Drawing.Point(3, 3)
        Me.LblTOFA.Name = "LblTOFA"
        Me.LblTOFA.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblTOFA.Size = New System.Drawing.Size(64, 15)
        Me.LblTOFA.TabIndex = 62
        Me.LblTOFA.Text = "First Aid cd"
        '
        'LblTimeouts
        '
        Me.LblTimeouts.AutoSize = True
        Me.LblTimeouts.BackColor = System.Drawing.Color.Transparent
        Me.LblTimeouts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeouts.ForeColor = System.Drawing.Color.Gold
        Me.LblTimeouts.Location = New System.Drawing.Point(21, 345)
        Me.LblTimeouts.Name = "LblTimeouts"
        Me.LblTimeouts.Size = New System.Drawing.Size(66, 16)
        Me.LblTimeouts.TabIndex = 104
        Me.LblTimeouts.Text = "Timeouts"
        '
        'LblMusicLenghtSec
        '
        Me.LblMusicLenghtSec.AutoSize = True
        Me.LblMusicLenghtSec.BackColor = System.Drawing.Color.Black
        Me.LblMusicLenghtSec.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblMusicLenghtSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblMusicLenghtSec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMusicLenghtSec.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblMusicLenghtSec.Location = New System.Drawing.Point(687, 5)
        Me.LblMusicLenghtSec.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.LblMusicLenghtSec.Name = "LblMusicLenghtSec"
        Me.LblMusicLenghtSec.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LblMusicLenghtSec.Size = New System.Drawing.Size(23, 15)
        Me.LblMusicLenghtSec.TabIndex = 98
        Me.LblMusicLenghtSec.Text = "00"
        Me.LblMusicLenghtSec.Visible = False
        '
        'LblMusicLenghtMin
        '
        Me.LblMusicLenghtMin.AutoSize = True
        Me.LblMusicLenghtMin.BackColor = System.Drawing.Color.Black
        Me.LblMusicLenghtMin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblMusicLenghtMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblMusicLenghtMin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMusicLenghtMin.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblMusicLenghtMin.Location = New System.Drawing.Point(673, 5)
        Me.LblMusicLenghtMin.Name = "LblMusicLenghtMin"
        Me.LblMusicLenghtMin.Padding = New System.Windows.Forms.Padding(2, 1, 0, 1)
        Me.LblMusicLenghtMin.Size = New System.Drawing.Size(15, 15)
        Me.LblMusicLenghtMin.TabIndex = 105
        Me.LblMusicLenghtMin.Text = "0"
        Me.LblMusicLenghtMin.Visible = False
        '
        'LblMusicNPlay
        '
        Me.LblMusicNPlay.AutoSize = True
        Me.LblMusicNPlay.BackColor = System.Drawing.Color.Black
        Me.LblMusicNPlay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMusicNPlay.ForeColor = System.Drawing.Color.LemonChiffon
        Me.LblMusicNPlay.Location = New System.Drawing.Point(200, 6)
        Me.LblMusicNPlay.Name = "LblMusicNPlay"
        Me.LblMusicNPlay.Size = New System.Drawing.Size(69, 13)
        Me.LblMusicNPlay.TabIndex = 107
        Me.LblMusicNPlay.Text = "Now Playing:"
        Me.LblMusicNPlay.Visible = False
        '
        'LblMusicTElap
        '
        Me.LblMusicTElap.AutoSize = True
        Me.LblMusicTElap.BackColor = System.Drawing.Color.Black
        Me.LblMusicTElap.ForeColor = System.Drawing.Color.LemonChiffon
        Me.LblMusicTElap.Location = New System.Drawing.Point(610, 5)
        Me.LblMusicTElap.Name = "LblMusicTElap"
        Me.LblMusicTElap.Size = New System.Drawing.Size(61, 13)
        Me.LblMusicTElap.TabIndex = 108
        Me.LblMusicTElap.Text = "Song Time:"
        Me.LblMusicTElap.Visible = False
        '
        'TxtBMusicText
        '
        Me.TxtBMusicText.BackColor = System.Drawing.Color.Black
        Me.TxtBMusicText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBMusicText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtBMusicText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBMusicText.ForeColor = System.Drawing.Color.GreenYellow
        Me.TxtBMusicText.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TxtBMusicText.Location = New System.Drawing.Point(272, 6)
        Me.TxtBMusicText.Name = "TxtBMusicText"
        Me.TxtBMusicText.ReadOnly = True
        Me.TxtBMusicText.Size = New System.Drawing.Size(340, 14)
        Me.TxtBMusicText.TabIndex = 111
        '
        'PicBoxMusicVol
        '
        Me.PicBoxMusicVol.BackColor = System.Drawing.Color.Black
        Me.PicBoxMusicVol.BackgroundImage = Global.FOnline_2_Char_Planner.My.Resources.Resources.Volume0
        Me.PicBoxMusicVol.Location = New System.Drawing.Point(722, 3)
        Me.PicBoxMusicVol.Name = "PicBoxMusicVol"
        Me.PicBoxMusicVol.Size = New System.Drawing.Size(45, 15)
        Me.PicBoxMusicVol.TabIndex = 116
        Me.PicBoxMusicVol.TabStop = False
        Me.PicBoxMusicVol.Visible = False
        '
        'PanDrugs
        '
        Me.PanDrugs.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.PanDrugs.Controls.Add(Me.BtnDrugsCigs)
        Me.PanDrugs.Controls.Add(Me.BtnDrugsNuka)
        Me.PanDrugs.Controls.Add(Me.BtnDrugsPsycho)
        Me.PanDrugs.Controls.Add(Me.BtnDrugsBuff)
        Me.PanDrugs.Controls.Add(Me.BtnDrugsJet)
        Me.PanDrugs.Enabled = False
        Me.PanDrugs.ForeColor = System.Drawing.Color.Black
        Me.PanDrugs.Location = New System.Drawing.Point(279, 364)
        Me.PanDrugs.Name = "PanDrugs"
        Me.PanDrugs.Size = New System.Drawing.Size(174, 28)
        Me.PanDrugs.TabIndex = 68
        '
        'LblDrugs
        '
        Me.LblDrugs.AutoSize = True
        Me.LblDrugs.BackColor = System.Drawing.Color.Transparent
        Me.LblDrugs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrugs.ForeColor = System.Drawing.Color.Gold
        Me.LblDrugs.Location = New System.Drawing.Point(283, 345)
        Me.LblDrugs.Name = "LblDrugs"
        Me.LblDrugs.Size = New System.Drawing.Size(46, 16)
        Me.LblDrugs.TabIndex = 117
        Me.LblDrugs.Text = "Drugs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.FOnline_2_Char_Planner.My.Resources.Resources.Hintergrund
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(789, 572)
        Me.Controls.Add(Me.BtnAllDrugs)
        Me.Controls.Add(Me.LblDrugs)
        Me.Controls.Add(Me.PanDrugs)
        Me.Controls.Add(Me.PicBoxMusicVol)
        Me.Controls.Add(Me.BtnMusicVolUp)
        Me.Controls.Add(Me.BtnMusicVolDown)
        Me.Controls.Add(Me.TxtBMusicText)
        Me.Controls.Add(Me.LblMusicLenghtSec)
        Me.Controls.Add(Me.LblMusicTElap)
        Me.Controls.Add(Me.LblMusicNPlay)
        Me.Controls.Add(Me.LblMusicLenghtMin)
        Me.Controls.Add(Me.LblTimeouts)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnLvlFastDwn)
        Me.Controls.Add(Me.BtnLvlFastUp)
        Me.Controls.Add(Me.BtnMscSkip)
        Me.Controls.Add(Me.BtnMscPlay)
        Me.Controls.Add(Me.BtnMscStop)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnBooksAll)
        Me.Controls.Add(Me.LblChessRew)
        Me.Controls.Add(Me.LstVChess)
        Me.Controls.Add(Me.LblAchieve)
        Me.Controls.Add(Me.LstVAchiev)
        Me.Controls.Add(Me.LblQuests)
        Me.Controls.Add(Me.LstVQuests)
        Me.Controls.Add(Me.LstVImpl)
        Me.Controls.Add(Me.LblImpl)
        Me.Controls.Add(Me.LblBMentats)
        Me.Controls.Add(Me.LblDetailedDesc)
        Me.Controls.Add(Me.PanBookValEdit)
        Me.Controls.Add(Me.LstVBooks)
        Me.Controls.Add(Me.LblBooks)
        Me.Controls.Add(Me.BtnAchievem)
        Me.Controls.Add(Me.BtnQuests)
        Me.Controls.Add(Me.BtnImpl)
        Me.Controls.Add(Me.BtnBooks)
        Me.Controls.Add(Me.PanStatsSightACrit)
        Me.Controls.Add(Me.BtnPerkLater)
        Me.Controls.Add(Me.PanSkUpDown)
        Me.Controls.Add(Me.LblPerks)
        Me.Controls.Add(Me.LblPTraitsTaken)
        Me.Controls.Add(Me.LblCBoxBooks)
        Me.Controls.Add(Me.CBoxBooks)
        Me.Controls.Add(Me.LblLevel)
        Me.Controls.Add(Me.BtnLvlDwn)
        Me.Controls.Add(Me.BtnLvlUp)
        Me.Controls.Add(Me.LstBoxPerks)
        Me.Controls.Add(Me.LstVPerks)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.PanNormDesc)
        Me.Controls.Add(Me.PanDetDesc)
        Me.Controls.Add(Me.LblGenDescr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PanLvlInfo)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.LblSkills)
        Me.Controls.Add(Me.PanSkills)
        Me.Controls.Add(Me.LblSpecial)
        Me.Controls.Add(Me.PanStatistics)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanTraits)
        Me.Controls.Add(Me.CPointsPan)
        Me.Controls.Add(Me.LblStatsHead)
        Me.Controls.Add(Me.PanStats)
        Me.Controls.Add(Me.PanDetText)
        Me.Controls.Add(Me.MainMenu)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "FOnline 2 Character Planner"
        Me.PanStats.ResumeLayout(False)
        Me.PanStats.PerformLayout()
        Me.CPointsPan.ResumeLayout(False)
        Me.CPointsPan.PerformLayout()
        Me.PanTraits.ResumeLayout(False)
        Me.PanTraits.PerformLayout()
        CType(Me.PicDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanStatistics.ResumeLayout(False)
        Me.PanStatistics.PerformLayout()
        Me.PanSkills.ResumeLayout(False)
        Me.PanSkills.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanLvlInfo.ResumeLayout(False)
        Me.PanLvlInfo.PerformLayout()
        Me.PanDetText.ResumeLayout(False)
        Me.PanDetText.PerformLayout()
        Me.PanStatsSightACrit.ResumeLayout(False)
        Me.PanStatsSightACrit.PerformLayout()
        Me.PanSkUpDown.ResumeLayout(False)
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.PanBookValEdit.ResumeLayout(False)
        Me.PanBookValEdit.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PicBoxMusicVol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanDrugs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblStatsST As System.Windows.Forms.Label
    Friend WithEvents LblStatsPE As System.Windows.Forms.Label
    Friend WithEvents LblStatsEN As System.Windows.Forms.Label
    Friend WithEvents LblStatsCH As System.Windows.Forms.Label
    Friend WithEvents LblStatsIN As System.Windows.Forms.Label
    Friend WithEvents LblStatsAG As System.Windows.Forms.Label
    Friend WithEvents LblStatsLK As System.Windows.Forms.Label
    Friend WithEvents PanStats As System.Windows.Forms.Panel
    Friend WithEvents LblStatsHead As System.Windows.Forms.Label
    Friend WithEvents CPointsPan As System.Windows.Forms.Panel
    Friend WithEvents LblCPointsHead As System.Windows.Forms.Label
    Friend WithEvents LblCPoints As System.Windows.Forms.Label
    Friend WithEvents LblStatsLKVal As System.Windows.Forms.Label
    Friend WithEvents LblStatsAGVal As System.Windows.Forms.Label
    Friend WithEvents LblStatsINVal As System.Windows.Forms.Label
    Friend WithEvents LblStatsCHVal As System.Windows.Forms.Label
    Friend WithEvents LblStatsENVal As System.Windows.Forms.Label
    Friend WithEvents LblStatsPEVal As System.Windows.Forms.Label
    Friend WithEvents LblStatsSTVal As System.Windows.Forms.Label
    Friend WithEvents BtnStatsSTUp As System.Windows.Forms.Button
    Friend WithEvents BtnStatsSTDown As System.Windows.Forms.Button
    Friend WithEvents BtnStatsLKDown As System.Windows.Forms.Button
    Friend WithEvents BtnStatsLKUp As System.Windows.Forms.Button
    Friend WithEvents BtnStatsAGDown As System.Windows.Forms.Button
    Friend WithEvents BtnStatsAGUp As System.Windows.Forms.Button
    Friend WithEvents BtnStatsINDown As System.Windows.Forms.Button
    Friend WithEvents BtnStatsINUp As System.Windows.Forms.Button
    Friend WithEvents BtnStatsCHDown As System.Windows.Forms.Button
    Friend WithEvents BtnStatsCHUp As System.Windows.Forms.Button
    Friend WithEvents BtnStatsENDown As System.Windows.Forms.Button
    Friend WithEvents BtnStatsENUp As System.Windows.Forms.Button
    Friend WithEvents BtnStatsPEDown As System.Windows.Forms.Button
    Friend WithEvents BtnStatsPEUp As System.Windows.Forms.Button
    Friend WithEvents PanTraits As System.Windows.Forms.Panel
    Friend WithEvents PicDesc As System.Windows.Forms.PictureBox
    Friend WithEvents LblTraitsFastMeta As System.Windows.Forms.Label
    Friend WithEvents LblTraitsBruiser As System.Windows.Forms.Label
    Friend WithEvents LblTraitsSFrame As System.Windows.Forms.Label
    Friend WithEvents LblTraitsFShot As System.Windows.Forms.Label
    Friend WithEvents LblTraitsHHanded As System.Windows.Forms.Label
    Friend WithEvents LblTraitsKamikaze As System.Windows.Forms.Label
    Friend WithEvents LblTraitsFinesse As System.Windows.Forms.Label
    Friend WithEvents LblTraitsOHanded As System.Windows.Forms.Label
    Friend WithEvents LblTraitsBlMess As System.Windows.Forms.Label
    Friend WithEvents LblTraitsJinxed As System.Windows.Forms.Label
    Friend WithEvents LblTraitsEvader As System.Windows.Forms.Label
    Friend WithEvents LblTraitsMutant As System.Windows.Forms.Label
    Friend WithEvents LblTraitsBHead As System.Windows.Forms.Label
    Friend WithEvents LblTraitsCRes As System.Windows.Forms.Label
    Friend WithEvents LblTraitsCRel As System.Windows.Forms.Label
    Friend WithEvents LblTraitsGNatured As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblHitPoints As System.Windows.Forms.Label
    Friend WithEvents PanStatistics As System.Windows.Forms.Panel
    Friend WithEvents LblCritChVal As System.Windows.Forms.Label
    Friend WithEvents LblHealRVal As System.Windows.Forms.Label
    Friend WithEvents LblSeqVal As System.Windows.Forms.Label
    Friend WithEvents LblRadResVal As System.Windows.Forms.Label
    Friend WithEvents LblPoisonResVal As System.Windows.Forms.Label
    Friend WithEvents LblDmgResVal As System.Windows.Forms.Label
    Friend WithEvents LblMDmgVal As System.Windows.Forms.Label
    Friend WithEvents LblCWVal As System.Windows.Forms.Label
    Friend WithEvents LblAPointsVal As System.Windows.Forms.Label
    Friend WithEvents LblAClassVal As System.Windows.Forms.Label
    Friend WithEvents LblCritCh As System.Windows.Forms.Label
    Friend WithEvents LblHealingR As System.Windows.Forms.Label
    Friend WithEvents LblSequence As System.Windows.Forms.Label
    Friend WithEvents LblMeleeDmg As System.Windows.Forms.Label
    Friend WithEvents LblRadRes As System.Windows.Forms.Label
    Friend WithEvents LblActionP As System.Windows.Forms.Label
    Friend WithEvents LblPoisonRes As System.Windows.Forms.Label
    Friend WithEvents LblAClass As System.Windows.Forms.Label
    Friend WithEvents LblDmgRes As System.Windows.Forms.Label
    Friend WithEvents LblCWeight As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblSpecial As System.Windows.Forms.Label
    Friend WithEvents PanSkills As System.Windows.Forms.Panel
    Friend WithEvents LblSkills As System.Windows.Forms.Label
    Friend WithEvents LblRepair As System.Windows.Forms.Label
    Friend WithEvents LblGambling As System.Windows.Forms.Label
    Friend WithEvents LblLPick As System.Windows.Forms.Label
    Friend WithEvents LblSneak As System.Windows.Forms.Label
    Friend WithEvents LblDoctor As System.Windows.Forms.Label
    Friend WithEvents LblScavenge As System.Windows.Forms.Label
    Friend WithEvents LblBGuns As System.Windows.Forms.Label
    Friend WithEvents LblSGuns As System.Windows.Forms.Label
    Friend WithEvents LblEWeapons As System.Windows.Forms.Label
    Friend WithEvents LblCCombat As System.Windows.Forms.Label
    Friend WithEvents LblThrow As System.Windows.Forms.Label
    Friend WithEvents LblFAid As System.Windows.Forms.Label
    Friend WithEvents LblSteal As System.Windows.Forms.Label
    Friend WithEvents LblTraps As System.Windows.Forms.Label
    Friend WithEvents LblScience As System.Windows.Forms.Label
    Friend WithEvents LblSpeech As System.Windows.Forms.Label
    Friend WithEvents LblBarter As System.Windows.Forms.Label
    Friend WithEvents LblODMan As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LblSkPoints As System.Windows.Forms.Label
    Friend WithEvents LblSkPointsVal As System.Windows.Forms.Label
    Friend WithEvents LblTagSkills As System.Windows.Forms.Label
    Friend WithEvents LblSGunsVal As System.Windows.Forms.Label
    Friend WithEvents PanLvlInfo As System.Windows.Forms.Panel
    Friend WithEvents LblODVal As System.Windows.Forms.Label
    Friend WithEvents LblGamblVal As System.Windows.Forms.Label
    Friend WithEvents LblBarterVal As System.Windows.Forms.Label
    Friend WithEvents LblSpeechVal As System.Windows.Forms.Label
    Friend WithEvents LblRepairVal As System.Windows.Forms.Label
    Friend WithEvents LblScienceVal As System.Windows.Forms.Label
    Friend WithEvents LblTrapsVal As System.Windows.Forms.Label
    Friend WithEvents LblStealVal As System.Windows.Forms.Label
    Friend WithEvents LblLPickVal As System.Windows.Forms.Label
    Friend WithEvents LblSneakVal As System.Windows.Forms.Label
    Friend WithEvents LblDocVal As System.Windows.Forms.Label
    Friend WithEvents LblFaidVal As System.Windows.Forms.Label
    Friend WithEvents LblThrowVal As System.Windows.Forms.Label
    Friend WithEvents LblScavenVal As System.Windows.Forms.Label
    Friend WithEvents LblCCombVal As System.Windows.Forms.Label
    Friend WithEvents LblEWeaponsVal As System.Windows.Forms.Label
    Friend WithEvents LblBGunsVal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblGenDescr As System.Windows.Forms.Label
    Friend WithEvents PanDetDesc As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PanNormDesc As System.Windows.Forms.Panel
    Friend WithEvents LblDetDesc As System.Windows.Forms.Label
    Friend WithEvents LblLevelVal As System.Windows.Forms.Label
    Friend WithEvents LblLvl As System.Windows.Forms.Label
    Friend WithEvents BtnDone As System.Windows.Forms.Button
    Friend WithEvents LstVPerks As System.Windows.Forms.ListView
    Friend WithEvents LstBoxPerks As System.Windows.Forms.ListBox
    Friend WithEvents BtnLvlUp As System.Windows.Forms.Button
    Friend WithEvents BtnLvlDwn As System.Windows.Forms.Button
    Friend WithEvents LblLevel As System.Windows.Forms.Label
    Friend WithEvents CBoxBooks As System.Windows.Forms.ComboBox
    Friend WithEvents LblCBoxBooks As System.Windows.Forms.Label
    Friend WithEvents LblPTraitsTaken As System.Windows.Forms.Label
    Friend WithEvents LblPerks As System.Windows.Forms.Label
    Friend WithEvents BtnSkUp As System.Windows.Forms.Button
    Friend WithEvents BtnSkDown As System.Windows.Forms.Button
    Friend WithEvents PanSkUpDown As System.Windows.Forms.Panel
    Friend WithEvents LblDetDescrText As System.Windows.Forms.Label
    Friend WithEvents BtnPerkLater As System.Windows.Forms.Button
    Friend WithEvents PanDetText As System.Windows.Forms.Panel
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveBuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadBuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MusicToolStrMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanStatsSightACrit As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblACritVal As System.Windows.Forms.Label
    Friend WithEvents LblAntiCrit As System.Windows.Forms.Label
    Friend WithEvents LblSightVal As System.Windows.Forms.Label
    Friend WithEvents LblSight As System.Windows.Forms.Label
    Friend WithEvents BtnBooks As System.Windows.Forms.Button
    Friend WithEvents BtnImpl As System.Windows.Forms.Button
    Friend WithEvents BtnQuests As System.Windows.Forms.Button
    Friend WithEvents BtnAchievem As System.Windows.Forms.Button
    Friend WithEvents LstVBooks As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnBookValDown As System.Windows.Forms.Button
    Friend WithEvents BtnBookValUp As System.Windows.Forms.Button
    Friend WithEvents LblBookAmVal As System.Windows.Forms.Label
    Friend WithEvents LblBookAmount As System.Windows.Forms.Label
    Friend WithEvents BtnBookDone As System.Windows.Forms.Button
    Friend WithEvents LblBooks As System.Windows.Forms.Label
    Friend WithEvents PanBookValEdit As System.Windows.Forms.Panel
    Friend WithEvents LblDetailedDesc As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblBMentats As System.Windows.Forms.Label
    Friend WithEvents LblImpl As System.Windows.Forms.Label
    Friend WithEvents LstVImpl As System.Windows.Forms.ListView
    Friend WithEvents LstVQuests As System.Windows.Forms.ListView
    Friend WithEvents LblQuests As System.Windows.Forms.Label
    Friend WithEvents LstVAchiev As System.Windows.Forms.ListView
    Friend WithEvents LblAchieve As System.Windows.Forms.Label
    Friend WithEvents LstVChess As System.Windows.Forms.ListView
    Friend WithEvents LblChessRew As System.Windows.Forms.Label
    Friend WithEvents BtnBooksAll As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnMscStop As System.Windows.Forms.Button
    Friend WithEvents BtnMscPlay As System.Windows.Forms.Button
    Friend WithEvents BtnMscSkip As System.Windows.Forms.Button
    Friend WithEvents BtnLvlFastUp As System.Windows.Forms.Button
    Friend WithEvents BtnLvlFastDwn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblTODoc As System.Windows.Forms.Label
    Friend WithEvents LblTOFA As System.Windows.Forms.Label
    Friend WithEvents LblTimeouts As System.Windows.Forms.Label
    Friend WithEvents LblTODocVal As System.Windows.Forms.Label
    Friend WithEvents LblTOFAVal As System.Windows.Forms.Label
    Friend WithEvents LblMusicLenghtSec As System.Windows.Forms.Label
    Friend WithEvents LblMusicLenghtMin As System.Windows.Forms.Label
    Friend WithEvents LblMusicNPlay As System.Windows.Forms.Label
    Friend WithEvents LblMusicTElap As System.Windows.Forms.Label
    Friend WithEvents TxtBMusicText As System.Windows.Forms.TextBox
    Friend WithEvents BtnMusicVolDown As System.Windows.Forms.Button
    Friend WithEvents BtnMusicVolUp As System.Windows.Forms.Button
    Friend WithEvents PicBoxMusicVol As System.Windows.Forms.PictureBox
    Friend WithEvents PanDrugs As System.Windows.Forms.Panel
    Friend WithEvents BtnDrugsJet As System.Windows.Forms.Button
    Friend WithEvents BtnDrugsCigs As System.Windows.Forms.Button
    Friend WithEvents BtnDrugsNuka As System.Windows.Forms.Button
    Friend WithEvents BtnDrugsPsycho As System.Windows.Forms.Button
    Friend WithEvents BtnDrugsBuff As System.Windows.Forms.Button
    Friend WithEvents LblDrugs As System.Windows.Forms.Label
    Friend WithEvents BtnAllDrugs As System.Windows.Forms.Button

End Class
