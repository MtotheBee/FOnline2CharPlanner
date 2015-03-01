Imports Microsoft.VisualBasic.PowerPacks
Imports System.Runtime.InteropServices
Imports System.IO
Public Class Form1

    'Instanzieren der (Eigenschafts-)Klassen
    Dim Stats As New CharBaseStats
    Dim Traits As New CharTraits
    Dim Skills As New CharSkills
    Dim Statistics As New CharStatistics
    Dim Perks As New CharPerks
    Dim NUDPos As Integer
    Dim SkillsMinVal(19) As Integer
    Dim SkillsName(19) As String
    Dim skillVal As Integer
    Dim skillMin As Integer
    Dim skillMax As Integer
    Dim incr As Integer
    Dim neededSP As Integer
    Dim isSamePos As Boolean

    Dim oldVal As Integer
    Dim isDonefirstTime As Boolean
    Dim lvlUp As Boolean
    Dim skillPoints As Integer
    Dim panPos As Integer
    Public isEnabled As Boolean = True

    'Description Labels for DetailDesc
    Dim DetDescrName(200) As String
    Dim DetDescrText(200) As String
    Dim DescPicIndex(200) As String

    'Declare Booleans for Traits-Status
    Friend isBruiser As Boolean
    Friend isFastMeta As Boolean
    Friend isSFrame As Boolean
    Friend isOHanded As Boolean
    Friend isFinesse As Boolean
    Friend isKamikaze As Boolean
    Friend isHHanded As Boolean
    Friend isFShot As Boolean
    Friend isBlMess As Boolean
    Friend isJinxed As Boolean
    Friend isGNatured As Boolean
    Friend isCRel As Boolean
    Friend isCRes As Boolean
    Friend isBHead As Boolean
    Friend isMutant As Boolean
    Friend isEvader As Boolean

    'Same for Skill-Tags
    Friend isSGtag As Boolean
    Friend isBGtag As Boolean
    Friend isEWtag As Boolean
    Friend isCCtag As Boolean
    Friend isScavtag As Boolean
    Friend isThrowtag As Boolean
    Friend isFAtag As Boolean
    Friend isDoctag As Boolean
    Friend isSneaktag As Boolean
    Friend isLPtag As Boolean
    Friend isStealtag As Boolean
    Friend isTrapstag As Boolean
    Friend isSciencetag As Boolean
    Friend isReptag As Boolean
    Friend isSpeechtag As Boolean
    Friend isBartertag As Boolean
    Friend isGambtag As Boolean
    Friend isODtag As Boolean

    'Check for next step after initial Stats are taken
    Friend isDone As Boolean

    Private bMouseDown As Boolean
    Private Counter As Long

    'Counter for selected Perks
    Friend Perkstaken As Integer
    Friend isPerklater As Boolean

    'Educated taken
    Friend EducatedAtLvl As Boolean
    'Books
    Friend isBookListVis As Boolean
    Friend isBookactive As Boolean
    Friend isBookMentats As Boolean

    'Timeouts
    Friend DocCoolSecInitial As Double
    Friend FACoolSecInitial As Double
    Friend isMedic As Boolean

    'Implants
    Friend isImplantActive As Boolean

    'Quests
    Friend isQuestsActive As Boolean

    'Achievements
    Friend isAchieveActive As Boolean

    Friend myFontNormal As Font
    Friend myFontBold As Font
    Friend myFontStatsNormal As Font
    Friend myFontStatsBold As Font
    Friend myFontAll As Font

    'Colors for panel borders
    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        Dim z As Graphics
        Dim stift As New Pen(Color.LightGray, 1)
        Dim ctl As Control

        ' Holt Grafik-Objekt zum Zeichnen
        z = e.Graphics
        ' Rechteck, Text
        For Each ctl In Me.Controls
            'check if ctl is Panel and paint unfilled rectangle around it aka white line
            If ctl.GetType() Is GetType(System.Windows.Forms.Panel) Then
                If Not ctl.Name = "PanSkUpDown" And Not ctl.Name = "PanBookValEdit" Then
                    z.DrawRectangle(stift, ctl.Left - 1, ctl.Top - 1, ctl.Width + 1, ctl.Height + 1)
                End If
            End If

            If ctl.GetType() Is GetType(System.Windows.Forms.ListView) Then
                If Not ctl.Name = "LstVBooks" Then
                    z.DrawRectangle(stift, ctl.Left - 1, ctl.Top - 1, ctl.Width + 1, ctl.Height + 1)
                End If
            End If

            If ctl.GetType() Is GetType(System.Windows.Forms.ListBox) Then
                z.DrawRectangle(stift, ctl.Left - 1, ctl.Top - 1, ctl.Width + 1, ctl.Height + 1)
            End If

        Next

        'z.DrawRectangle(stift, PicDesc.Left - 1, PicDesc.Top - 1, PicDesc.Width + 1, PicDesc.Height + 1)


    End Sub

    Private Sub Form1_Paint2(ByVal sender As System.Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        Dim z As Graphics
        Dim stift As New Pen(Color.LightGray, 1)
        Dim ctl As Control
        If isBookListVis = True Then
            ' Holt Grafik-Objekt zum Zeichnen
            z = e.Graphics
            ' Rechteck, Text
            For Each ctl In Me.Controls
                'check if ctl is Panel and paint unfilled rectangle around it aka white line
                If ctl.GetType() Is GetType(System.Windows.Forms.Panel) Then
                    If ctl.Name = "PanBookValEdit" Then
                        z.DrawRectangle(stift, ctl.Left - 1, ctl.Top - 1, ctl.Width + 1, ctl.Height + 1)
                    End If
                End If

                If ctl.GetType() Is GetType(System.Windows.Forms.ListView) Then
                    If ctl.Name = "LstVBooks" Then
                        z.DrawRectangle(stift, ctl.Left - 1, ctl.Top - 1, ctl.Width + 1, ctl.Height + 1)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PanSK_Paint(ByVal sender As System.Object, ByVal e As PaintEventArgs) Handles PanSkUpDown.Paint
        Dim z As Graphics
        Dim stift As New Pen(Color.LightGray, 1)
        'Dim ctl As Control

        z = e.Graphics

        With PanSkUpDown
            z.DrawRectangle(stift, .Left - 1, .Top - 1, .Width + 1, .Height + 1)
        End With

    End Sub


    '*********************************************
    '* Get/SetStats when +/- Buttons are clicked *
    '* Plus additional checks                    *
    '*********************************************
    Private Sub BtnStatsSTUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsSTUp.Click

        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)

        PicDesc.Image = My.Resources.STDesc
        Stats.GetStats()

        If Not Stats.Strenght >= 10 And Not Stats.CharPoints <= 0 Then
            Stats.Strenght += 1
            Stats.CharPoints -= 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()

        If Stats.Strenght >= 0 Then
            LblStatsSTVal.ForeColor = Color.LimeGreen
        End If
        DetDescrChange(128, 128)
    End Sub

    Private Sub BtnStatsSTDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsSTDown.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)

        PicDesc.Image = My.Resources.STDesc
        Stats.GetStats()

        If Not Stats.Strenght <= 1 Then
            Stats.Strenght -= 1
            Stats.CharPoints += 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()

        If Stats.Strenght = 10 Then
            LblStatsSTVal.ForeColor = Color.LimeGreen
        End If

        DetDescrChange(128, 128)
    End Sub

    Private Sub BtnStatsPEUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsPEUp.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.PEDesc

        Stats.GetStats()

        If Not Stats.Perception >= 10 And Not Stats.CharPoints <= 0 Then
            Stats.Perception += 1
            Stats.CharPoints -= 1
            Stats.SetStats()
        End If

        Statistics.SetStatistics()
        Skills.setSkillValues()

        DocCoolSecInitial = 9000 / Skills.Doctor
        Dim DocCoolSpanIn As TimeSpan = TimeSpan.FromSeconds(DocCoolSecInitial)
        Label2.Text = DocCoolSecInitial
        LblTODocVal.Text = DocCoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    DocCoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        FACoolSecInitial = 9000 / Skills.FAid
        Dim FACoolSpanIn As TimeSpan = TimeSpan.FromSeconds(FACoolSecInitial)
        LblTOFAVal.Text = FACoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    FACoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        DetDescrChange(129, 129)

    End Sub

    Private Sub BtnStatsPEDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsPEDown.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.PEDesc

        Stats.GetStats()

        If Not Stats.Perception <= 1 Then
            Stats.Perception -= 1
            Stats.CharPoints += 1
            Stats.SetStats()
        End If

        Statistics.SetStatistics()
        Skills.setSkillValues()

        DocCoolSecInitial = 9000 / Skills.Doctor
        Dim DocCoolSpanIn As TimeSpan = TimeSpan.FromSeconds(DocCoolSecInitial)
        Label2.Text = DocCoolSecInitial
        LblTODocVal.Text = DocCoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    DocCoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        FACoolSecInitial = 9000 / Skills.FAid
        Dim FACoolSpanIn As TimeSpan = TimeSpan.FromSeconds(FACoolSecInitial)
        LblTOFAVal.Text = FACoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    FACoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        DetDescrChange(129, 129)
    End Sub

    Private Sub BtnStatsENUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsENUp.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.ENDesc

        Stats.GetStats()

        If Not Stats.Endurance >= 10 And Not Stats.CharPoints <= 0 Then
            Stats.Endurance += 1
            Stats.CharPoints -= 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()

        If Stats.Endurance >= 0 Then
            LblStatsENVal.ForeColor = Color.LimeGreen
        End If

        DetDescrChange(130, 130)
    End Sub

    Private Sub BtnStatsENDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsENDown.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.ENDesc

        Stats.GetStats()

        If Not Stats.Endurance <= 1 Then
            Stats.Endurance -= 1
            Stats.CharPoints += 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()
        DetDescrChange(130, 130)
    End Sub

    Private Sub BtnStatsCHUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsCHUp.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.CHDesc

        Stats.GetStats()

        If Not Stats.Charisma >= 10 And Not Stats.CharPoints <= 0 Then
            Stats.Charisma += 1
            Stats.CharPoints -= 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()

        DetDescrChange(131, 131)
    End Sub

    Private Sub BtnStatsCHDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsCHDown.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.CHDesc

        Stats.GetStats()
        If Not Stats.Charisma <= 1 Then
            Stats.Charisma -= 1
            Stats.CharPoints += 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()
        DetDescrChange(131, 131)
    End Sub

    Private Sub BtnStatsINUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsINUp.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.INDesc

        Stats.GetStats()
        If Not Stats.Intelligence >= 10 And Not Stats.CharPoints <= 0 Then
            Stats.Intelligence += 1
            Stats.CharPoints -= 1
            Stats.SetStats()
        End If

        Statistics.SetStatistics()
        Skills.setSkillValues()

        DocCoolSecInitial = 9000 / Skills.Doctor
        Dim DocCoolSpanIn As TimeSpan = TimeSpan.FromSeconds(DocCoolSecInitial)
        Label2.Text = DocCoolSecInitial
        LblTODocVal.Text = DocCoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    DocCoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        FACoolSecInitial = 9000 / Skills.FAid
        Dim FACoolSpanIn As TimeSpan = TimeSpan.FromSeconds(FACoolSecInitial)
        LblTOFAVal.Text = FACoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    FACoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        If Stats.Intelligence >= 0 Then
            LblStatsINVal.ForeColor = Color.LimeGreen
        End If

        DetDescrChange(132, 132)

    End Sub

    Private Sub BtnStatsINDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsINDown.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.INDesc

        Stats.GetStats()
        If Not Stats.Intelligence <= 1 Then
            Stats.Intelligence -= 1
            Stats.CharPoints += 1
            Stats.SetStats()
        End If

        If Stats.Intelligence = 10 Then
            LblStatsINVal.ForeColor = Color.LimeGreen
        End If

        Statistics.SetStatistics()
        Skills.setSkillValues()

        DocCoolSecInitial = 9000 / Skills.Doctor
        Dim DocCoolSpanIn As TimeSpan = TimeSpan.FromSeconds(DocCoolSecInitial)
        Label2.Text = DocCoolSecInitial
        LblTODocVal.Text = DocCoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    DocCoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        FACoolSecInitial = 9000 / Skills.FAid
        Dim FACoolSpanIn As TimeSpan = TimeSpan.FromSeconds(FACoolSecInitial)
        LblTOFAVal.Text = FACoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                    FACoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)

        DetDescrChange(132, 132)
    End Sub

    Private Sub BtnStatsAGUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsAGUp.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.AGDesc

        Stats.GetStats()
        If Not Stats.Agility >= 10 And Not Stats.CharPoints <= 0 Then
            Stats.Agility += 1
            Stats.CharPoints -= 1
            Stats.SetStats()
        End If

        If Stats.Agility >= 0 Then
            LblStatsAGVal.ForeColor = Color.LimeGreen
        End If

        Statistics.SetStatistics()
        Skills.setSkillValues()
        DetDescrChange(133, 133)
    End Sub

    Private Sub BtnStatsAGDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsAGDown.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.AGDesc

        Stats.GetStats()
        If Not Stats.Agility <= 1 Then
            Stats.Agility -= 1
            Stats.CharPoints += 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()
        DetDescrChange(133, 133)
    End Sub

    Private Sub BtnStatsLKUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsLKUp.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.LKDesc

        Stats.GetStats()
        If Not Stats.Luck >= 10 And Not Stats.CharPoints <= 0 Then
            Stats.Luck += 1
            Stats.CharPoints -= 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()
        DetDescrChange(134, 134)
    End Sub

    Private Sub BtnStatsLKDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatsLKDown.Click
        My.Computer.Audio.Play(My.Resources.button_46, AudioPlayMode.Background)
        PicDesc.Image = My.Resources.LKDesc

        Stats.GetStats()
        If Not Stats.Luck <= 1 Then
            Stats.Luck -= 1
            Stats.CharPoints += 1
            Stats.SetStats()
        End If
        Statistics.SetStatistics()
        Skills.setSkillValues()
        DetDescrChange(134, 134)
    End Sub

    '*******************
    '* PicDesc Updates *
    '*******************
    Private Sub LblStatsST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatsST.Click
        PicDesc.Image = My.Resources.STDesc
        DetDescrChange(128, 128)
    End Sub

    Private Sub LblStatsPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatsPE.Click
        PicDesc.Image = My.Resources.PEDesc
        DetDescrChange(129, 129)
    End Sub

    Private Sub LblStatsEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatsEN.Click
        PicDesc.Image = My.Resources.ENDesc
        DetDescrChange(130, 130)
    End Sub

    Private Sub LblStatsCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatsCH.Click
        PicDesc.Image = My.Resources.CHDesc
        DetDescrChange(131, 131)
    End Sub

    Private Sub LblStatsIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatsIN.Click
        PicDesc.Image = My.Resources.INDesc
        DetDescrChange(132, 132)
    End Sub

    Private Sub LblStatsAG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatsAG.Click
        PicDesc.Image = My.Resources.AGDesc
        DetDescrChange(133, 133)
    End Sub

    Private Sub LblStatsLK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStatsLK.Click
        PicDesc.Image = My.Resources.LKDesc
        DetDescrChange(134, 134)
    End Sub

    Private Sub LblAClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblAClass.Click
        PicDesc.Image = My.Resources.AClassDesc
        DetDescrChange(118, 118)
    End Sub

    Private Sub LblActionP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblActionP.Click
        PicDesc.Image = My.Resources.MaxAPDesc
        DetDescrChange(119, 119)
    End Sub

    Private Sub LblCWeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCWeight.Click
        PicDesc.Image = My.Resources.CWeightDesc
        DetDescrChange(120, 120)
    End Sub

    Private Sub LblMeleeDmg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMeleeDmg.Click
        PicDesc.Image = My.Resources.MeleeDmgDesc
        DetDescrChange(121, 121)
    End Sub

    Private Sub LblDmgRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDmgRes.Click
        PicDesc.Image = My.Resources.DResistDesc
        DetDescrChange(122, 122)
    End Sub

    Private Sub LblPoisonRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblPoisonRes.Click
        PicDesc.Image = My.Resources.PoisonResDesc
        DetDescrChange(123, 123)
    End Sub

    Private Sub LblRadRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblRadRes.Click
        PicDesc.Image = My.Resources.RadResDesc
        DetDescrChange(124, 124)
    End Sub

    Private Sub LblSequence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSequence.Click
        PicDesc.Image = My.Resources.SequenceDesc
        DetDescrChange(125, 125)
    End Sub

    Private Sub LblHealingR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblHealingR.Click
        PicDesc.Image = My.Resources.HealRateDesc
        DetDescrChange(117, 117)
    End Sub

    Private Sub LblCritCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCritCh.Click
        PicDesc.Image = My.Resources.CritChanceDesc
        DetDescrChange(126, 126)
    End Sub

    'HitPoints Label
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        PicDesc.Image = My.Resources.MaxHPDesc
        DetDescrChange(127, 127)
    End Sub

    Private Sub LblSight_Click(sender As System.Object, e As System.EventArgs) Handles LblSight.Click
        PicDesc.Image = My.Resources.SightDescr
        DetDescrChange(135, 135)
    End Sub

    Private Sub LblAntiCrit_Click(sender As System.Object, e As System.EventArgs) Handles LblAntiCrit.Click
        PicDesc.Image = My.Resources.AnticriticalDescNeu
        DetDescrChange(136, 136)
    End Sub

    '***********************************
    '* Traits Click/Behaviour Routines *
    '***********************************

    Private Sub LblTraitsBruiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsBruiser.Click
        Stats.GetStats()
        Dim isMaxST As Boolean

        PicDesc.Image = My.Resources.BruiserDesc
        DetDescrChange(91, 91)
        If isBruiser = True Then
            isBruiser = False
        Else
            isBruiser = True
        End If

        If isBruiser = True Then
            If Not Stats.Strenght >= 9 Then
                isMaxST = False
                Stats.Strenght = Stats.Strenght + 2

                Statistics.addBruiser = 8
                Statistics.APoints = Statistics.APoints - 2
                If Stats.Strenght <= 2 Then
                    LblStatsSTVal.ForeColor = Color.LimeGreen
                End If
            Else
                isMaxST = True
                Stats.Strenght = Stats.Strenght + 2
                Statistics.addBruiser = 8
                Statistics.APoints = Statistics.APoints - 2
                LblStatsSTVal.ForeColor = Color.Red
            End If
        Else
            If isBruiser = False And isMaxST = False Then
                If Stats.Strenght <= 2 Then
                    LblStatsSTVal.ForeColor = Color.Red
                    Stats.Strenght = Stats.Strenght - 2
                    Statistics.APoints = Statistics.APoints + 2
                    Statistics.addBruiser = 0
                Else
                    Stats.Strenght = Stats.Strenght - 2
                    Statistics.APoints = Statistics.APoints + 2
                    Statistics.addBruiser = 0
                    LblStatsSTVal.ForeColor = Color.LimeGreen
                End If

            ElseIf isBruiser = False And isMaxST = True Then
                Stats.Strenght = Stats.Strenght - 2
                Statistics.APoints = Statistics.APoints + 2
                Statistics.addBruiser = 0
                LblStatsSTVal.ForeColor = Color.LimeGreen
            End If
        End If

        Stats.SetStats()
        Traits.TraitsCheck(sender, isBruiser, sender.ToString)
        Statistics.SetStatistics()
        Skills.setSkillValues()

    End Sub

    Private Sub LblTraitsFastMeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsFastMeta.Click
        PicDesc.Image = My.Resources.FMetaDesc
        DetDescrChange(90, 90)
        If isFastMeta = True Then
            isFastMeta = False
            Statistics.addHRate = -10
        Else
            isFastMeta = True
            Statistics.addHRate = 10
        End If
        Traits.TraitsCheck(sender, isFastMeta, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsSFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsSFrame.Click
        PicDesc.Image = My.Resources.SFrameDesc
        DetDescrChange(92, 92)
        If isSFrame = True Then
            isSFrame = False
        Else
            isSFrame = True
        End If

        'Agility Calc
        Stats.GetStats()
        If isSFrame = True Then
            Stats.Agility = Stats.Agility + 1
            LblStatsAGVal.ForeColor = Color.LimeGreen
        Else
            If Stats.Agility = 1 Then
                LblStatsAGVal.ForeColor = Color.Red
            End If
            Stats.Agility = Stats.Agility - 1
        End If
        Stats.SetStats()
        Traits.TraitsCheck(sender, isSFrame, sender.ToString)
        Statistics.SetStatistics()
        Skills.setSkillValues()
    End Sub

    Private Sub LblTraitsOHanded_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsOHanded.Click
        PicDesc.Image = My.Resources.OneHanderDesc
        DetDescrChange(93, 93)
        If isOHanded = True Then
            isOHanded = False
        Else
            isOHanded = True
        End If
        Traits.TraitsCheck(sender, isOHanded, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsFinesse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsFinesse.Click
        PicDesc.Image = My.Resources.FinesseDesc
        DetDescrChange(94, 94)
        If isFinesse = True Then
            isFinesse = False
            Statistics.addCritChance = Statistics.addCritChance - 10
        Else
            isFinesse = True
            Statistics.addCritChance = Statistics.addCritChance + 10
        End If
        Traits.TraitsCheck(sender, isFinesse, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsKamikaze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsKamikaze.Click
        PicDesc.Image = My.Resources.KamikazeDesc
        DetDescrChange(95, 95)
        If isKamikaze = True Then
            isKamikaze = False
            Statistics.addKamikaze = 0
        Else
            isKamikaze = True
            Statistics.addKamikaze = -10
        End If
        Traits.TraitsCheck(sender, isKamikaze, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsHHanded_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsHHanded.Click
        PicDesc.Image = My.Resources.HHandedDesc
        DetDescrChange(96, 96)
        If isHHanded = True Then
            isHHanded = False
            Statistics.addHHanded = 0
        Else
            isHHanded = True
            Statistics.addHHanded = 4
        End If
        Traits.TraitsCheck(sender, isHHanded, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsFShot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsFShot.Click
        PicDesc.Image = My.Resources.FShotDesc
        DetDescrChange(97, 97)
        If isFShot = True Then
            isFShot = False
        Else
            isFShot = True
        End If
        Traits.TraitsCheck(sender, isFShot, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsBlMess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsBlMess.Click
        PicDesc.Image = My.Resources.BlMessDesc
        DetDescrChange(98, 98)
        If isBlMess = True Then
            isBlMess = False
        Else
            isBlMess = True
        End If
        Traits.TraitsCheck(sender, isBlMess, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsJinxed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsJinxed.Click
        PicDesc.Image = My.Resources.JinxedDesc
        DetDescrChange(99, 99)
        If isJinxed = True Then
            isJinxed = False
        Else
            isJinxed = True
        End If
        Traits.TraitsCheck(sender, isJinxed, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    Private Sub LblTraitsGNatured_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsGNatured.Click
        PicDesc.Image = My.Resources.GNaturedDesc
        DetDescrChange(100, 100)
        If isGNatured = True Then
            isGNatured = False
        Else
            isGNatured = True

        End If
        Traits.TraitsCheck(sender, isGNatured, sender.ToString)
        Statistics.SetStatistics()
        Skills.setSkillValues()
    End Sub

    Private Sub LblTraitsCRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsCRel.Click
        PicDesc.Image = My.Resources.CReliantDesc
        DetDescrChange(101, 101)
        If isCRel = True Then
            isCRel = False
        Else
            If Not isCRes = True Then
                isCRel = True
            End If
        End If

        If Not isCRes = True Then
            Traits.TraitsCheck(sender, isCRel, sender.ToString)
            Statistics.SetStatistics()
        End If

    End Sub

    Private Sub LblTraitsCRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsCRes.Click
        PicDesc.Image = My.Resources.CResistDesc
        DetDescrChange(102, 102)
        If isCRes = True Then
            isCRes = False
        Else
            If Not isCRel = True Then
                isCRes = True
            End If
        End If

        If Not isCRel = True Then
            Traits.TraitsCheck(sender, isCRes, sender.ToString)
            Statistics.SetStatistics()
        End If

    End Sub

    Private Sub LblTraitsBHead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsBHead.Click
        Stats.GetStats()
        PicDesc.Image = My.Resources.BHeadDesc
        DetDescrChange(103, 103)
        If isBHead = True Then
            isBHead = False
            Skills.addBHead = 0
        Else
            isBHead = True
            Skills.addBHead = 0
        End If

        'Intelligence Calc
        'Stats.GetStats()
        If isBHead = True Then
            Stats.Intelligence = Stats.Intelligence - 1
        Else
            LblStatsINVal.ForeColor = Color.LimeGreen
            Stats.Intelligence = Stats.Intelligence + 1
        End If
        Stats.SetStats()
        Traits.TraitsCheck(sender, isBHead, sender.ToString)
        'Statistics.SetStatistics()
        Skills.setSkillValues()
    End Sub

    Private Sub LblTraitsMutant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsMutant.Click
        PicDesc.Image = My.Resources.MutantDesc
        DetDescrChange(104, 104)
        If isMutant = True Then
            isMutant = False
            Statistics.addHP = Statistics.addHP - 100
            Skills.addMutant = 0
            Statistics.addMutantDR = 0
            Statistics.addMutantMDmg = 0
        Else
            Statistics.addHP = Statistics.addHP + 100
            Skills.addMutant = 100
            Statistics.addMutantDR = 5
            Statistics.addMutantMDmg = 10
            isMutant = True
        End If
        Traits.TraitsCheck(sender, isMutant, sender.ToString)
        Statistics.SetStatistics()
        Skills.setSkillValues()
    End Sub

    Private Sub LblTraitsEvader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraitsEvader.Click
        PicDesc.Image = My.Resources.EvaderDesc
        DetDescrChange(105, 105)
        Stats.GetStats()
        If isEvader = True Then
            isEvader = False
            Skills.addEvade = 0
            Stats.Endurance = Stats.Endurance + 2
        Else
            isEvader = True
            Skills.addEvade = 2
            Stats.Endurance = Stats.Endurance - 2
        End If

        If isEvader = True Then
            If Stats.Endurance <= 2 Then
                LblStatsENVal.ForeColor = Color.Red
            Else
                LblStatsENVal.ForeColor = Color.LimeGreen
            End If

        Else
            LblStatsENVal.ForeColor = Color.LimeGreen

        End If

        Stats.SetStats()
        Traits.TraitsCheck(sender, isEvader, sender.ToString)
        Statistics.SetStatistics()
    End Sub

    'Handles all MouseEnter Events for Traits (Labels)
    '--> Todo (maybe): write EventHandler to catch all .MouseEnter events, listed below
    Private Sub LblTraits_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        LblTraitsFastMeta.MouseEnter, LblTraitsBruiser.MouseEnter, LblTraitsSFrame.MouseEnter, LblTraitsOHanded.MouseEnter, LblTraitsFinesse.MouseEnter, _
        LblTraitsKamikaze.MouseEnter, LblTraitsHHanded.MouseEnter, LblTraitsFShot.MouseEnter, LblTraitsBlMess.MouseEnter, LblTraitsJinxed.MouseEnter, _
        LblTraitsGNatured.MouseEnter, LblTraitsCRel.MouseEnter, LblTraitsCRes.MouseEnter, LblTraitsBHead.MouseEnter, LblTraitsMutant.MouseEnter, _
        LblTraitsEvader.MouseEnter
        Traits.senderColor = sender.ForeColor

        TraitsMouseEnter(sender)

    End Sub

    Private Sub TraitsMouseEnter(ByVal sender As System.Object)
        sender.ForeColor = Color.White
    End Sub

    'Handles all MouseLeave Events for Traits (Labels)
    Private Sub LblTraits_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        LblTraitsFastMeta.MouseLeave, LblTraitsBruiser.MouseLeave, LblTraitsSFrame.MouseLeave, LblTraitsOHanded.MouseLeave, LblTraitsFinesse.MouseLeave, _
        LblTraitsKamikaze.MouseLeave, LblTraitsHHanded.MouseLeave, LblTraitsFShot.MouseLeave, LblTraitsBlMess.MouseLeave, LblTraitsJinxed.MouseLeave, _
        LblTraitsGNatured.MouseLeave, LblTraitsCRel.MouseLeave, LblTraitsCRes.MouseLeave, LblTraitsBHead.MouseLeave, LblTraitsMutant.MouseLeave, _
        LblTraitsEvader.MouseLeave
        Traits.TraitsMLeave(sender, sender.ToString)
    End Sub

    '*******************
    '* On Load Actions *
    '*******************
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim zaehler As Integer

        'Check if Visual Styles should be visible 
        'todo --> maybe fine tuning of visual appearance when styles are disabled
        'If System.Environment.OSVersion.Platform.ToString <> "Win32NT" Then
        '   Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled
        'End If
        'Label9.Text = "Dein System: " & System.Environment.OSVersion.Platform.ToString
        Me.DoubleBuffered = True

        MOffToolStripMenuItem.Enabled = False
        NextToolStripMenuItem.Enabled = False

        LblDetDesc.Visible = False
        LblDetDescrText.Visible = False
        'LblPerks.Visible = False
        PanSkUpDown.Visible = False

        myFontNormal = New Font(LblAPointsVal.Font, FontStyle.Regular)
        myFontBold = New Font(LblAPointsVal.Font, FontStyle.Bold)
        myFontStatsNormal = New Font(LblStatsENVal.Font, FontStyle.Regular)
        myFontStatsBold = New Font(LblStatsENVal.Font, FontStyle.Bold)
        myFontAll = New Font(BtnAllDrugs.Font, FontStyle.Bold)

        LstVPerks.Items.Add("Action Boy")
        LstVPerks.Items.Add("Adrenaline Rush")
        LstVPerks.Items.Add("Anticritical")
        LstVPerks.Items.Add("Better Criticals")
        LstVPerks.Items.Add("Bonus HtH Attacks")
        LstVPerks.Items.Add("Bonus HtH Damage")
        LstVPerks.Items.Add("Bonus Ranged Damage")
        LstVPerks.Items.Add("Bonus Rate of Fire")
        LstVPerks.Items.Add("Cautious Nature")
        LstVPerks.Items.Add("Dodger")
        LstVPerks.Items.Add("Earlier Sequence")
        LstVPerks.Items.Add("Educated")
        LstVPerks.Items.Add("Gain Agility")
        LstVPerks.Items.Add("Gain Charisma")
        LstVPerks.Items.Add("Gain Endurance")
        LstVPerks.Items.Add("Gain Intelligence")
        LstVPerks.Items.Add("Gain Luck")
        LstVPerks.Items.Add("Gain Perception")
        LstVPerks.Items.Add("Gain Strenght")
        LstVPerks.Items.Add("Ghost")
        LstVPerks.Items.Add("Harmless")
        LstVPerks.Items.Add("Healer")
        LstVPerks.Items.Add("Heave Ho!")
        LstVPerks.Items.Add("HtH Evade")
        LstVPerks.Items.Add("Lifegiver")
        LstVPerks.Items.Add("Light Step")
        LstVPerks.Items.Add("Living Anatomy")
        LstVPerks.Items.Add("Magnetic Personality")
        LstVPerks.Items.Add("Master Thief")
        LstVPerks.Items.Add("Medic")
        LstVPerks.Items.Add("More Critical")
        LstVPerks.Items.Add("Mr. Fixit")
        'LstVPerks.Items.Add("Pathfinder")
        LstVPerks.Items.Add("Pickpocket")
        LstVPerks.Items.Add("Pyromaniac")
        LstVPerks.Items.Add("Quick Hands")
        LstVPerks.Items.Add("Quick Recovery")
        LstVPerks.Items.Add("Sharpshooter")
        LstVPerks.Items.Add("Silent Death")
        LstVPerks.Items.Add("Silent Running")
        LstVPerks.Items.Add("Stonewall")
        'LstVPerks.Items.Add("Strong Back")
        LstVPerks.Items.Add("Thief")
        LstVPerks.Items.Add("Toughness")
        LstVPerks.Items.Add("Weapon Handling")

        LstVPerks.Visible = False

        Perkstaken = 0

        CBoxBooks.Items.Add("First Aid B.")
        CBoxBooks.Items.Add("Outdoorsman B.")
        CBoxBooks.Items.Add("Repair B.")
        CBoxBooks.Items.Add("Science B.")
        CBoxBooks.Items.Add("Small Guns B.")

        CBoxBooks.Enabled = False

        zaehler = 46
        'DetDescTitles for Skills
        For Each item As Control In PanSkills.Controls
            If Len(item.Text) > 4 Then
                DetDescrName(zaehler) = item.Text
                Debug.Print(zaehler & " : " & DetDescrName(zaehler))
                zaehler = zaehler + 1
            End If

        Next


        DetDescrText(46) = "Needed for Profession Armorer and Gunsmith.  Maximum amount needed to repair items is     160%."
        DetDescrText(47) = "Roll the dices! Roll em! Up to now, this     skill isn't really needed in-game."
        DetDescrText(48) = "Most lockers can be opened with a value of   100% in this skill. To pick cars you need    more then 100%. However, values above 200%   won't get you better results."
        DetDescrText(49) = "Even with 300% the use of sneak characters   needs some experience. Can be boosted by     Stealth Boys, Hubologist Robes  and Scouting Implants."
        DetDescrText(50) = "Good choice for PvP characters. Note: To use Doctor skill in TB-mode you have to spend    your full turn + you need to have a doctor   bag in any of your hand slots."
        DetDescrText(51) = "Increases your chances to obtain resources   while collecting them. Can't be raised       manually but by collecting resources."
        DetDescrText(52) = "Don't underestimate the power of flamers. If you plan to use (Avenger) Miniguns a lot,    keep in mind, that you'll need huge amounts  of 5mm rounds."
        DetDescrText(53) = "Good choice for beginners. Tier I Small Gun  weapons and ammunition are easy to find,     compared to other weapon types. "
        DetDescrText(54) = "EW can be pretty powerful in the hand of an  experienced player with a decent build.      It's also a good choice for TB-spammers."
        DetDescrText(55) = "Increases your running speed. The bonus      starts after 100% and tops with 200%.        Your max bonus to speed is 25%. Also. This   skill is caped at 200%."
        DetDescrText(56) = "Can be pretty effective while using plasma   grenades as weapon. Note: The Achievement    'Heave Ho!' can increase your throwing range."
        DetDescrText(57) = "Outside of combat every use of FA heals as   much hp as the value of your skill level.    In combat, when used on yourself you can't   heal more than 150 HP."
        DetDescrText(58) = "Good chances to steal from players starts    with a value above 200%. At NPCs it's        much harder. In protected towns you can get  problems for stealing, see Wiki for details."
        DetDescrText(59) = "It is not increasing the amount of damage    you can deal with explosives. Increasing     this skill will only help in spotting traps  and disarming them."
        DetDescrText(60) = "The maximum needed skill for disassembling   items is 160%. For hacking computers its     about 130%. You also need Science for        Scientist and Chemist professions."
        DetDescrText(61) = "Don't tag it! Don't skill it! Hell! Dont     even look at it! It does: Nothing."
        DetDescrText(62) = "The more Barter the better the prices at     NPC-shopkeepers. This skill can't be         raised manually but will increase by         bartering with NPCs."
        DetDescrText(63) = "Since ODMan won't increase your traveling    speed and at the same time your maximum      chance to evade an encounter is 95%,         increasing this skill over 95% is pointless."


        'Quests Descriptions
        DetDescrName(110) = "Chess Game"
        DetDescrText(110) = "At least 8 IN are needed. Chances to win     raise with more IN. Possible rewards:        a) +3 Crit Chance, b) +1 to Sight and +5%    Hit Chance, c) +10 HP & +4 Healing Rate."
        DescPicIndex(110) = "GlowQuestDesc"
        DetDescrName(111) = "Mary Ann - JT"
        DetDescrText(111) = "Talk to Mike in the Casino (Gizmos).         If you have a white flower in your           inventory you'll get additional dialog       options. See wiki for details."
        DescPicIndex(111) = "JTQuestMaryDesc"
        DetDescrName(112) = "Pete Quest - JT"
        DetDescrText(112) = "If you bring Pete a Super Tool Kit you       will get +20% to your Repair-Skill.          Note: This only works for skill values       below 80%!"
        DescPicIndex(112) = "JTQuestPeteDesc"

        DetDescrName(113) = "Chess Game - +3 CChance"
        DetDescrName(114) = "Chess Game - +1 FOV, +5% HitC."
        DetDescrName(115) = "Chess Game - +10HP, +4 HRate"

        DetDescrText(113) = DetDescrText(110)
        DetDescrText(114) = DetDescrText(110)
        DetDescrText(115) = DetDescrText(110)
        DescPicIndex(113) = "GlowQuestDesc"
        DescPicIndex(114) = "GlowQuestDesc"
        DescPicIndex(115) = "GlowQuestDesc"

        'Traits Descriptions
        DetDescrName(90) = "Fast Metabolism"
        DescPicIndex(90) = "FMetaDescPic"
        DetDescrText(90) = "+ Healing Rate +10                           + You heal HP every 15 seconds.              - Base values for Radiation- and Poison-      Resistances are 0."
        DetDescrName(91) = "Bruiser"
        DescPicIndex(91) = "BruiserDesc"
        DetDescrText(91) = "+ Strength +2                                + Meele Damage +8                            - Action Points -2"
        DetDescrName(92) = "Small Frame"
        DescPicIndex(92) = "SFrameDesc"
        DetDescrText(92) = "+ 1 to Agility                               - You have less carry weight.                - Every critical hit can have an aditional    effect besides the damage coming from hit."
        DetDescrName(93) = "One handed"
        DescPicIndex(93) = "OneHanderDesc"
        DetDescrText(93) = "+5 Bonus flat damage to every attack.        + 10% chance to avoid crippling when         wielding a one-handed weapon. - 20% chance    to get crippled with a two-handed weapon."
        DetDescrName(94) = "Finesse"
        DescPicIndex(94) = "FinesseDesc"
        DetDescrText(94) = "+ 10% to critical chance.                    - Your target's Damage Resistance is         raised by + 30%."
        DetDescrName(95) = "Kamikaze"
        DescPicIndex(95) = "KamikazeDesc"
        DetDescrText(95) = "+ You deal 10% more damage.                  - Your damage resistances(all kinds) are     lowered by 10%."
        DetDescrName(96) = "Heavy Handed"
        DescPicIndex(96) = "HHandedDesc"
        DetDescrText(96) = "+ 4 to your Meele Damage. HtH attacks have   a chance to knockdown your opponent,         wether he has Stonewall or not.               - 30% to your crit roll."
        DetDescrName(97) = "Fast Shot"
        DescPicIndex(97) = "FShotDesc"
        DetDescrText(97) = "+ 5 Bonus flat damage to every attack.       + It -1 AP cost to attack with every         aimable weapon in game.                       - You can't perform aimed attacks."
        DetDescrName(98) = "Bloody Mess"
        DescPicIndex(98) = "BlMessDesc"
        DetDescrText(98) = "+ You always get extreme death animations.   + Lowering enemy's HP below 0 kills them     instantly.   - Armors of killed enemies are badly damaged."
        DetDescrName(99) = "Jinxed"
        DescPicIndex(99) = "JinxedDesc"
        DetDescrText(99) = "Every time a person or an animal targeting   you misses, there is a 50% chance for a      critical miss. Unfortunately, the same        applies to your own unsuccessful attacks."
        DetDescrName(100) = "Good Natured"
        DescPicIndex(100) = "GNaturedDesc"
        DetDescrText(100) = "+ 15% to First Aid, Doctor, Speech and       Barter skills.                               - Start values of SGuns-, BGuns-, EWeap.-,   CCombat- and Throwing-Skills lowered by 10%."
        DetDescrName(101) = "Chem Reliant"
        DescPicIndex(101) = "CReliantDesc"
        DetDescrText(101) = "+ Duration of drugs is now 60 minutes.       - Your chance to be addicted is doubled.     Note: If you use drugs a lot, taking this    Trait can be pretty useful."
        DetDescrName(102) = "Chem Resistant"
        DescPicIndex(102) = "CResistDesc"
        DetDescrText(102) = "+ Your chance to become addicted is halfed.  - Duration of drugs is now only 15 minutes."
        DetDescrName(103) = "Bonehead"
        DescPicIndex(103) = "BHeadDesc"
        DetDescrText(103) = "+ Protection of -10 to critical hit roll on  eye and head shots. - Intelligence -1.       - You can't have more than 9 Intelligence     points."
        DetDescrName(104) = "Mutant"
        DescPicIndex(104) = "MutantDesc"
        DetDescrText(104) = "+100 HP, +100% ODMan, Bonus to resistances.  - No running. Only some weapons and armors   are usable (see wiki for details)."
        DetDescrName(105) = "Evader"
        DescPicIndex(105) = "EvaderDesc"
        DetDescrText(105) = "+ The max chance to hit you is now 85%.      - Endurance - 2                              - You can't have more then 8 Endurance."

        'Statistics
        DetDescrText(117) = "HR is a measure telling you how quick you    can regenerate HPs withouth use of FA or     Stimpaks. The bigger your healing rate       the quicker you heal."
        DetDescrName(117) = "Healing Rate"
        DetDescrText(118) = "The higher your AC is, the better your       chances are that your opponent will miss     while trying to shoot or hit you.            You can't have more than 90 armor class."
        DetDescrName(118) = "Armor Class"
        DetDescrText(119) = "One of the most important character abilities- certain AP are needed to for each weapon   - especially for Turnbased Combat you        should have a high amount of AP."
        DetDescrName(119) = "Action Points"
        DetDescrName(120) = "Carry Weight"
        DetDescrText(120) = "The maximum amount of CW is 254kg            (+max 20CW  from Armors with Stats). You can get the PackRat Achievement to get           additional CW."
        DetDescrName(121) = "Melee Damage"
        DetDescrText(121) = "Describes how much extra damage you deal     with close combat weapons. The damage        output is added both to the min and max      amount of damage your character can deal."
        DetDescrName(122) = "Damage Resistance"
        DetDescrText(122) = "Any damage taken is reduced by this %.       For example, if you wear an armor with       20 DR the damage taken will be reduced       by 20%."
        DetDescrName(123) = "Poison Resistance"
        DetDescrText(123) = "Poison resistance is a parameter describing  how resistant your character is to           poison. Can be increased by wearing armors   with crafting bonus."
        DetDescrName(124) = "Radiation Resistance"
        DetDescrText(124) = "Is a parameter describing how resistant      your character is to radiation. Don't        forget to take Rad-X befor entering Glow."
        DetDescrName(125) = "Sequence"
        DetDescrText(125) = "Sequence is a parameter which determines     how soon your character will be able to      react in turn-based combat mode. See wiki    for details."
        DetDescrName(126) = "Critical Chance"
        DetDescrText(126) = "Tells you how big your chances are to hit    critically using unaimed or burst attacks    For the whole crit table see wiki."
        DetDescrName(127) = "Hit Points"
        DetDescrText(127) = "Important character statistic. While         leveling up you gain additional HP           according to your SPECIAL. After Level 26    you gain 1HP each second level."
        DetDescrName(128) = "Strenght"
        DetDescrText(128) = "Modifies: starting HP, Melee Damage and      Carry Weight. Check ST requirements for      certain weapons to avoid malus for critical  hits."
        DetDescrName(129) = "Perception"
        DetDescrText(129) = "Modifies: Field of View (Sight), Sequence    and Hit Chance. 6 points of PE are often     required for a variety of useful perks"
        DetDescrName(130) = "Endurance"
        DetDescrText(130) = "Modifies: HP, Healing Rate, Resistance       to Knockdown & Knockout, Poison Resistance   and Radiation Resistance. 10,9,8 are the     most common numbers here. "
        DetDescrName(131) = "Charisma"
        DetDescrText(131) = "Modifies: Number of Player who can travel    with you. Beside that it's a pretty useless  statistic. You can gain +1CH via the Mary    Ann Quest."
        DetDescrName(132) = "Intelligence"
        DetDescrText(132) = "Modifies: Initial % of some skills,          Dialogue options and the number of new skill points per level. Note: The Bonus Rate       of Fire perk requires 6 IN!"
        DetDescrName(133) = "Agility"
        DetDescrText(133) = "Modifies: Action Points and Armor Class.     A large number of perks require AG >= 6.     In addition, it's better to have an even     number in agility."
        DetDescrName(134) = "Luck"
        DetDescrText(134) = "Modifies: Critical Chance, Aimed Critical    Chance, Evading bad effects of being         critically hit. Crucial for snipers."
        DetDescrName(135) = "Sight (Field of View)"
        DetDescrText(135) = "Determines how far character can see and     therefore your weapon's effective range.     You can only shoot what your character can   see (except for Rocket Launcher)."
        DetDescrName(136) = "Anticritical"
        DetDescrText(136) = "The value you get when taking the            Anticritical Perk."
        DetDescrName(137) = "Jet"
        DetDescrText(137) = "Effect: +3 Action Points.                    Addiction: -1 Action Point."
        DescPicIndex(137) = "JetDescPic"
        DetDescrName(138) = "Buffout"
        DetDescrText(138) = "Effect: +2 Strenght, +1 Endurance.           Addiction: -1 Strenght , -1 Endurance."
        DescPicIndex(138) = "BuffoutDescPic"
        DetDescrName(139) = "Psycho"
        DetDescrText(139) = "Effect: +20% to normal dmg. res,             -7 to PE, -2 to IN .                         Addiction: -10% Damage Resistance."
        DescPicIndex(139) = "PsychoDescPic"
        DetDescrName(140) = "Nuka Cola"
        DetDescrText(140) = "Effect: +1 Action Point.                     Addiction: None."
        DescPicIndex(140) = "NukaDescPic"
        DetDescrName(141) = "Cigarettes"
        DetDescrText(141) = "Effect: +3 to Field of view.                 Addiction: None."
        DescPicIndex(141) = "CigsDescPic"

        Perks.readPerks()

    End Sub

    Sub PanChangePos(ByVal sender As System.Object, ByVal istagged As Boolean)
        Dim ctl As Control
        Dim s As String
        Static oldPos As Integer

        PanSkUpDown.Top = sender.top + 43
        panPos = sender.top + 43

        If oldPos = panPos Then
            isSamePos = True
        Else
            isSamePos = False
        End If

        For Each ctl In PanSkills.Controls
            If ctl.Text Like "*%" Then
                If ctl.Top = panPos - 43 Then
                    s = ctl.Text
                    skillVal = s.Substring(0, (Len(ctl.Text) - 1))

                    For i = 0 To UBound(SkillsName)
                        If SkillsName(i) = ctl.Name Then
                            skillMin = SkillsMinVal(i)
                        End If
                    Next
                End If
            End If
        Next

        Select Case skillVal
            '0% - 100% : 1% further costs 1 skill point
            '101% - 125% : 1% further costs 2 skill points
            '126% - 150% : 1% further costs 3 skill points
            '151% - 175% : 1% further costs 4 skill points
            '176% - 200% : 1% further costs 5 skill points
            '201% - 300% : 1% further costs 6 skill points

            'when tagged
            '0% - 100% : 2% further costs 1 skill point
            '101% - 125% : 2% further costs 2 skill points
            '126% - 150% : 2% further costs 3 skill points
            '151% - 175% : 2% further costs 4 skill points
            '176% - 200% : 2% further costs 5 skill points
            '201% - 300% : 2% further costs 6 skill points

            Case 0 To 100
                If istagged = True Then
                    skillMax = skillVal + (Skills.SkillP * 2)
                    incr = 2
                    neededSP = 1
                Else
                    skillMax = skillVal + Skills.SkillP
                    incr = 1
                    neededSP = 1
                End If
            Case 101 To 125
                If istagged = True Then
                    skillMax = skillVal + Skills.SkillP
                    incr = 2
                    neededSP = 2
                Else
                    skillMax = skillVal + (Skills.SkillP / 2)
                    incr = 1
                    neededSP = 2
                End If
            Case 126 To 150
                If istagged = True Then
                    skillMax = skillVal + (Skills.SkillP / 1.5)
                    incr = 2
                    neededSP = 3
                Else
                    skillMax = skillVal + (Skills.SkillP / 3)
                    incr = 1
                    neededSP = 3
                End If

            Case 151 To 175
                If istagged = True Then
                    skillMax = skillVal + (Skills.SkillP / 2)
                    incr = 2
                    neededSP = 4
                Else
                    skillMax = skillVal + (Skills.SkillP / 4)
                    incr = 1
                    neededSP = 4
                End If
            Case 176 To 200
                If istagged = True Then
                    skillMax = skillVal + (Skills.SkillP / 2.5)
                    incr = 2
                    neededSP = 5
                Else
                    skillMax = skillVal + (Skills.SkillP / 5)
                    incr = 1
                    neededSP = 5
                End If
            Case 201 To 300
                If istagged = True Then
                    skillMax = skillVal + (Skills.SkillP / 3)
                    incr = 2
                    neededSP = 6

                Else
                    skillMax = skillVal + (Skills.SkillP / 6)
                    incr = 2
                    neededSP = 6

                End If
        End Select

        'adds +2 SPoints immediatly after taking Educated
        If EducatedAtLvl = True Then
            Skills.SkillP = Skills.SkillP + 2
            EducatedAtLvl = False
        End If
        oldPos = panPos

    End Sub

    '************************
    '* Skills-Click Actions *
    '************************
    Private Sub LblEWeapons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblEWeapons.Click, LblEWeaponsVal.Click
        PanChangePos(sender, isEWtag)
        PicDesc.Image = My.Resources.EWDesc
        DetDescrChange(54, 54)

        If Not isDone = True Then


            If isEWtag = True Then
                isEWtag = False
                LblEWeapons.ForeColor = Color.LimeGreen
                LblEWeaponsVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.EWTagBonus = 0
            ElseIf isEWtag = False And Skills.TagSkillsVal > 0 Then
                isEWtag = True
                LblEWeapons.ForeColor = Color.WhiteSmoke
                LblEWeaponsVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.EWTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblSGuns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSGuns.Click, LblSGunsVal.Click
        PanChangePos(sender, isSGtag)
        PicDesc.Image = My.Resources.SGunsDesc
        DetDescrChange(53, 53)

        If Not isDone = True Then

            If isSGtag = True Then
                isSGtag = False
                LblSGuns.ForeColor = Color.LimeGreen
                LblSGunsVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.SGTagBonus = 0
            ElseIf isSGtag = False And Skills.TagSkillsVal > 0 Then
                isSGtag = True
                LblSGuns.ForeColor = Color.WhiteSmoke
                LblSGunsVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.SGTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblBGuns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBGuns.Click, LblBGunsVal.Click
        PanChangePos(sender, isBGtag)
        PicDesc.Image = My.Resources.BGunsDesc
        DetDescrChange(52, 52)

        If Not isDone = True Then

            If isBGtag = True Then
                isBGtag = False
                LblBGuns.ForeColor = Color.LimeGreen
                LblBGunsVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.BGTagBonus = 0
            ElseIf isBGtag = False And Skills.TagSkillsVal > 0 Then
                isBGtag = True
                LblBGuns.ForeColor = Color.WhiteSmoke
                LblBGunsVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.BGTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblLPick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblLPick.Click, LblLPickVal.Click
        PanChangePos(sender, isLPtag)
        PicDesc.Image = My.Resources.LPDesc
        DetDescrChange(48, 48)

        If Not isDone = True Then

            If isLPtag = True Then
                isLPtag = False
                LblLPick.ForeColor = Color.LimeGreen
                LblLPickVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.LPTagBonus = 0
            ElseIf isLPtag = False And Skills.TagSkillsVal > 0 Then
                isLPtag = True
                LblLPick.ForeColor = Color.WhiteSmoke
                LblLPickVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.LPTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblThrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblThrow.Click, LblThrowVal.Click
        PanChangePos(sender, isThrowtag)
        PicDesc.Image = My.Resources.ThrowDesc
        DetDescrChange(56, 56)

        If Not isDone = True Then

            If isThrowtag = True Then
                isThrowtag = False
                LblThrow.ForeColor = Color.LimeGreen
                LblThrowVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ThTagBonus = 0
            ElseIf isThrowtag = False And Skills.TagSkillsVal > 0 Then
                isThrowtag = True
                LblThrow.ForeColor = Color.WhiteSmoke
                LblThrowVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ThTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblCCombat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCCombat.Click, LblCCombVal.Click
        PanChangePos(sender, isCCtag)
        PicDesc.Image = My.Resources.CCombatDesc
        DetDescrChange(55, 55)

        If Not isDone = True Then

            If isCCtag = True Then
                isCCtag = False
                LblCCombat.ForeColor = Color.LimeGreen
                LblCCombVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.CCTagBonus = 0
            ElseIf isCCtag = False And Skills.TagSkillsVal > 0 Then
                isCCtag = True
                LblCCombat.ForeColor = Color.WhiteSmoke
                LblCCombVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.CCTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblScavenge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblScavenge.Click, LblScavenVal.Click
        PanChangePos(sender, isScavtag)
        PicDesc.Image = My.Resources.ScavengeDesc
        DetDescrChange(51, 51)

        If Not isDone = True Then

            If isScavtag = True Then
                isScavtag = False
                LblScavenge.ForeColor = Color.GreenYellow
                LblScavenVal.ForeColor = Color.GreenYellow
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ScavTagBonus = 0
            ElseIf isScavtag = False And Skills.TagSkillsVal > 0 Then
                isScavtag = True
                LblScavenge.ForeColor = Color.PaleGoldenrod
                LblScavenVal.ForeColor = Color.PaleGoldenrod
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ScavTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblFAid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblFAid.Click, LblFaidVal.Click
        PanChangePos(sender, isFAtag)
        PicDesc.Image = My.Resources.FADesc
        DetDescrChange(57, 57)

        If Not isDone = True Then

            If isFAtag = True Then
                isFAtag = False
                LblFAid.ForeColor = Color.LimeGreen
                LblFaidVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.FATagBonus = 0
            ElseIf isFAtag = False And Skills.TagSkillsVal > 0 Then
                isFAtag = True
                LblFAid.ForeColor = Color.WhiteSmoke
                LblFaidVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.FATagBonus = 20
            End If
            Skills.setSkillValues()
            Statistics.SetStatistics()

            FACoolSecInitial = 9000 / Skills.FAid
            Dim FACoolSpanIn As TimeSpan = TimeSpan.FromSeconds(FACoolSecInitial)
            LblTOFAVal.Text = FACoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                        FACoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDoctor.Click, LblDocVal.Click
        PanChangePos(sender, isDoctag)
        PicDesc.Image = My.Resources.DocDesc
        DetDescrChange(50, 50)

        If Not isDone = True Then

            If isDoctag = True Then
                isDoctag = False
                LblDoctor.ForeColor = Color.LimeGreen
                LblDocVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.DocTagBonus = 0
            ElseIf isDoctag = False And Skills.TagSkillsVal > 0 Then
                isDoctag = True
                LblDoctor.ForeColor = Color.WhiteSmoke
                LblDocVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.DocTagBonus = 20
            End If
            Skills.setSkillValues()
            Statistics.SetStatistics()

            DocCoolSecInitial = 9000 / Skills.Doctor
            Dim DocCoolSpanIn As TimeSpan = TimeSpan.FromSeconds(DocCoolSecInitial)
            Label2.Text = DocCoolSecInitial
            LblTODocVal.Text = DocCoolSpanIn.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                        DocCoolSpanIn.Seconds.ToString.PadLeft(2, "0"c)
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblSneak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSneak.Click, LblSneakVal.Click
        PanChangePos(sender, isSneaktag)
        PicDesc.Image = My.Resources.SneakDesc
        DetDescrChange(49, 49)

        If Not isDone = True Then

            If isSneaktag = True Then
                isSneaktag = False
                LblSneak.ForeColor = Color.LimeGreen
                LblSneakVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.SnkTagBonus = 0
            ElseIf isSneaktag = False And Skills.TagSkillsVal > 0 Then
                isSneaktag = True
                LblSneak.ForeColor = Color.WhiteSmoke
                LblSneakVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.SnkTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblSteal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSteal.Click, LblStealVal.Click
        PanChangePos(sender, isStealtag)
        PicDesc.Image = My.Resources.StealDesc
        DetDescrChange(58, 58)

        If Not isDone = True Then

            If isStealtag = True Then
                isStealtag = False
                LblSteal.ForeColor = Color.LimeGreen
                LblStealVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.StlTagBonus = 0
            ElseIf isStealtag = False And Skills.TagSkillsVal > 0 Then
                isStealtag = True
                LblSteal.ForeColor = Color.WhiteSmoke
                LblStealVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.StlTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblTraps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTraps.Click, LblTrapsVal.Click
        PanChangePos(sender, isTrapstag)
        PicDesc.Image = My.Resources.TrapsDesc
        DetDescrChange(59, 59)

        If Not isDone = True Then

            If isTrapstag = True Then
                isTrapstag = False
                LblTraps.ForeColor = Color.LimeGreen
                LblTrapsVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.TrpTagBonus = 0
            ElseIf isTrapstag = False And Skills.TagSkillsVal > 0 Then
                isTrapstag = True
                LblTraps.ForeColor = Color.WhiteSmoke
                LblTrapsVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.TrpTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblScience_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblScience.Click, LblScienceVal.Click
        PanChangePos(sender, isSciencetag)
        PicDesc.Image = My.Resources.ScienceDesc
        DetDescrChange(60, 60)

        If Not isDone = True Then

            If isSciencetag = True Then
                isSciencetag = False
                LblScience.ForeColor = Color.LimeGreen
                LblScienceVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ScnTagBonus = 0
            ElseIf isSciencetag = False And Skills.TagSkillsVal > 0 Then
                isSciencetag = True
                LblScience.ForeColor = Color.WhiteSmoke
                LblScienceVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ScnTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblRepair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblRepair.Click, LblRepairVal.Click
        PanChangePos(sender, isReptag)
        PicDesc.Image = My.Resources.RepairDesc
        DetDescrChange(46, 46)

        If Not isDone = True Then

            If isReptag = True Then
                isReptag = False
                LblRepair.ForeColor = Color.LimeGreen
                LblRepairVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.RepTagBonus = 0
            ElseIf isReptag = False And Skills.TagSkillsVal > 0 Then
                isReptag = True
                LblRepair.ForeColor = Color.WhiteSmoke
                LblRepairVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.RepTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblSpeech_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSpeech.Click, LblSpeechVal.Click
        PanChangePos(sender, isSpeechtag)
        PicDesc.Image = My.Resources.SpeechDesc
        DetDescrChange(61, 61)

        If Not isDone = True Then

            If isSpeechtag = True Then
                isSpeechtag = False
                LblSpeech.ForeColor = Color.LimeGreen
                LblSpeechVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.SpTagBonus = 0
            ElseIf isSpeechtag = False And Skills.TagSkillsVal > 0 Then
                isSpeechtag = True
                LblSpeech.ForeColor = Color.WhiteSmoke
                LblSpeechVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.SpTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblBarter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBarter.Click, LblBarterVal.Click
        PanChangePos(sender, isBartertag)
        PicDesc.Image = My.Resources.BarterDesc
        DetDescrChange(62, 62)

        If Not isDone = True Then

            If isBartertag = True Then
                isBartertag = False
                LblBarter.ForeColor = Color.GreenYellow
                LblBarterVal.ForeColor = Color.GreenYellow
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.BartTagBonus = 0
            ElseIf isBartertag = False And Skills.TagSkillsVal > 0 Then
                isBartertag = True
                LblBarter.ForeColor = Color.PaleGoldenrod
                LblBarterVal.ForeColor = Color.PaleGoldenrod
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.BartTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblGambling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblGambling.Click, LblGamblVal.Click
        PanChangePos(sender, isGambtag)
        PicDesc.Image = My.Resources.GamblingDesc
        DetDescrChange(47, 47)

        If Not isDone = True Then

            If isGambtag = True Then
                isGambtag = False
                LblGambling.ForeColor = Color.LimeGreen
                LblGamblVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.GambTagBonus = 0
            ElseIf isGambtag = False And Skills.TagSkillsVal > 0 Then
                isGambtag = True
                LblGambling.ForeColor = Color.WhiteSmoke
                LblGamblVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.GambTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub

    Private Sub LblODMan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblODMan.Click, LblODVal.Click
        PanChangePos(sender, isODtag)
        PicDesc.Image = My.Resources.ODDEsc
        DetDescrChange(63, 63)

        If Not isDone = True Then

            If isODtag = True Then
                isODtag = False
                LblODMan.ForeColor = Color.LimeGreen
                LblODVal.ForeColor = Color.LimeGreen
                Skills.TagSkillsVal = Skills.TagSkillsVal + 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ODTagBonus = 0
            ElseIf isODtag = False And Skills.TagSkillsVal > 0 Then
                isODtag = True
                LblODMan.ForeColor = Color.WhiteSmoke
                LblODVal.ForeColor = Color.WhiteSmoke
                Skills.TagSkillsVal = Skills.TagSkillsVal - 1
                LblSkPointsVal.Text = Skills.TagSkillsVal
                Skills.ODTagBonus = 20
            End If
            Skills.setSkillValues()
        Else
            PanSkUpDown.Visible = True
            'NUDSkills.Visible = True
        End If
    End Sub


    '*************************
    '* Detailed Descriptions *
    '*************************

    Sub DetDescrChange(ByVal DescNameIndex As Integer, ByVal DescTextIndex As Integer)
        Dim lenght As Integer
        Dim restLenght As Integer

        LblDetDesc.Text = DetDescrName(DescNameIndex)

        'LblDetDescrText.Text = DetDescrText(DescTextIndex)

        lenght = Len(DetDescrText(DescNameIndex))
        Text = DetDescrText(DescTextIndex)

        If lenght <= 45 Then

            LblDetDescrText.Text = Text

        ElseIf lenght <= 90 Then
            restLenght = lenght - 45
            LblDetDescrText.Text = Text.Substring(0, lenght - (lenght - 45)) & vbCrLf & Text.Substring(45, restLenght)
        ElseIf lenght <= 135 Then
            restLenght = lenght - 90
            LblDetDescrText.Text = Text.Substring(0, lenght - (lenght - 45)) & vbCrLf & Text.Substring(45, lenght - (lenght - 45)) _
                 & vbCrLf & Text.Substring(90, restLenght)
        ElseIf lenght <= 180 Then
            restLenght = lenght - 135
            LblDetDescrText.Text = Text.Substring(0, lenght - (lenght - 45)) & vbCrLf & Text.Substring(45, lenght - (lenght - 45)) _
                                    & vbCrLf & Text.Substring(90, lenght - (lenght - 45)) & vbCrLf _
                                    & Text.Substring(135, restLenght)
        End If
        'prevent weird bug that FOrm text will be overide by Perk Desc!
        Me.Text = "FOnline 2 Character Planner"
    End Sub

    Private Sub PanDetDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanDetDesc.Click, LblDetailedDesc.Click
        PicDesc.Hide()
        'PanDetText.Show()
        LblDetDesc.Show()
        LblDetDescrText.Show()
        PanNormDesc.BackColor = Color.Brown
        PanDetDesc.BackColor = Color.ForestGreen
        PanDetText.BackColor = Color.FromArgb(200, 0, 0, 0)

    End Sub

    Private Sub PanNormDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanNormDesc.Click, LblGenDescr.Click
        'PanDetText.Hide()
        PicDesc.Show()
        LblDetDesc.Hide()
        LblDetDescrText.Hide()
        PanNormDesc.BackColor = Color.ForestGreen
        PanDetDesc.BackColor = Color.Brown
        'PicDesc.BackColor = Color.Transparent
    End Sub


    'After initial values for SPECIAL, Traits and tagged Skills are set 
    Private Sub BtnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDone.Click
        My.Computer.Audio.Play(My.Resources.button_50, AudioPlayMode.Background)
        Dim ctl As Control
        Dim strItem As String
        Dim ctlzaehler As Integer = 0

        SaveBuildToolStripMenuItem.Enabled = True
        PanDrugs.Enabled = True
        BtnAllDrugs.Enabled = True

        Stats.GetStats()

        'reset Description 
        LblDetDesc.Text = ""
        LblDetDescrText.Text = ""

        If isDone = False Then
            isDone = True
            isDonefirstTime = True
            BtnDone.Enabled = False
            BtnDone.Visible = False

            If isBHead = True And Stats.Intelligence < 1 Then
                Stats.Intelligence = 1
                Stats.SetStats()
            End If

            For Each ctl In PanStats.Controls
                If Not ctl.GetType Is GetType(Windows.Forms.Label) Then
                    ctl.Visible = False
                End If
            Next

            For Each ctl In PanTraits.Controls
                If ctl.ForeColor = Color.Gold Then
                    strItem = ctl.Text
                    LstBoxPerks.Items.Add(strItem)
                End If
                ctl.Enabled = False
            Next

            'DetDescr Perks
            DetDescrName(0) = "Action Boy" 'rank 2
            DetDescrName(1) = "Adrenaline Rush"
            DetDescrName(2) = "Anticritical" 'rank 2
            DetDescrName(3) = "Better Criticals"
            DetDescrName(4) = "Bonus HtH Attacks"
            DetDescrName(5) = "Bonus HtH Damage" 'rank 3
            DetDescrName(6) = "Bonus Ranged Damage" 'rank 2
            DetDescrName(7) = "Bonus Rate of Fire"
            DetDescrName(8) = "Cautious Nature"
            DetDescrName(9) = "Dodger"
            DetDescrName(10) = "Earlier Sequence"
            DetDescrName(11) = "Educated"
            DetDescrName(12) = "Gain Agility"
            DetDescrName(13) = "Gain Charisma"
            DetDescrName(14) = "Gain Endurance"
            DetDescrName(15) = "Gain Intelligence"
            DetDescrName(16) = "Gain Luck"
            DetDescrName(17) = "Gain Perception"
            DetDescrName(18) = "Gain Strength"
            DetDescrName(19) = "Ghost"
            DetDescrName(20) = "Harmless"
            DetDescrName(21) = "Healer" 'rank 2
            DetDescrName(22) = "HtH Evade"
            DetDescrName(23) = "Lifegiver" 'rank 2
            DetDescrName(24) = "Light Step"
            DetDescrName(25) = "Living Anatomy"
            DetDescrName(26) = "Magnetic Personality"
            DetDescrName(27) = "Master Thief"
            DetDescrName(28) = "Medic"
            DetDescrName(29) = "More Critical" 'rank 2
            DetDescrName(30) = "Mr. Fixit"
            DetDescrName(31) = "Pathfinder"
            DetDescrName(32) = "Pickpocket"
            DetDescrName(33) = "Quick Hands"
            DetDescrName(34) = "Quick Recovery"
            DetDescrName(35) = "Sharpshooter"
            DetDescrName(36) = "Silent Death"
            DetDescrName(37) = "Silent Running"
            DetDescrName(38) = "Stonewall"
            DetDescrName(39) = "Strong Back"
            DetDescrName(40) = "Thief"
            DetDescrName(41) = "Toughness" 'rank 2
            DetDescrName(42) = "Weapon Handling"
           

            'Implants
            DetDescrName(70) = "Accuracy Implant"
            DetDescrText(70) = "You gain +5 to your Sight (FOV) and +40%     to your SG/BG and EW-Skills."
            DescPicIndex(70) = "ImplAccurDesc"
            DetDescrName(71) = "Chem Control Implant"
            DetDescrText(71) = "Your drug duration time is doubled and       every S-Stimpak you use heals +30% HP."
            DescPicIndex(71) = "ChemControlImpDesc"
            DetDescrName(72) = "Defense Implant"
            DescPicIndex(72) = "ImplDefDesc"
            DetDescrText(72) = "You gain +4% to all types of Damage          Resistances and +2% to all Damage Thresholds."
            DetDescrName(73) = "Enviromental Implant"
            DetDescrText(73) = "You gain +10 to your Healing Rate,           +40% Poison- and +50% Radiation Resistance."
            DescPicIndex(73) = "EnvImplDesc"
            DetDescrName(74) = "Engineering Implant"
            DescPicIndex(74) = "ImplEngDesc"
            DetDescrText(74) = "You gain +100% to Repair-, Science- and      EWeapons-Skill. Additionally your chance to  craft an item with updates is 10% higher."
            DetDescrName(75) = "Enhancement Implant"
            'check if there are all perks available
            DetDescrText(75) = "You can choose an additional perk. Note:     Only Perks, for which you fullfill the requir-ements (Level/SPECIAL) can be taken!"
            DescPicIndex(75) = "ImplEnhanceDesc"
            DetDescrName(76) = "Marksmanship Implant"
            DetDescrText(76) = "You gain +4% to your Crit Roll, +4% to       your Critical Chance and +2 Sight(FOV)."
            DescPicIndex(76) = "StandbySW" 'no pic yet
            DetDescrName(77) = "Medical Implant"
            DetDescrText(77) = "You gain +50% to Doctor- and 50% to        FA-Skill. You deal +5 Damage to living creatures. The HP you can heal(FA) is now 175HP."
            DescPicIndex(77) = "StandbySW" 'no pic yet
            DetDescrName(78) = "Scouting Implant"
            DetDescrText(78) = "You gain +30% to your sneak skill and        +30 to your Armor Class. Your skill can be    raised +20% over the cap. "
            DescPicIndex(78) = "StandbySW" 'no pic yet
            DetDescrName(79) = "Speed Implant"
            DescPicIndex(79) = "ImplSpeedDesc"
            DetDescrText(79) = "Your running animation is 10% faster.        You get +1 Action Point and +6 Sequence."
            DetDescrName(80) = "Survival Implant"
            DetDescrText(80) = "You gain +100% to your ODMan-Skill and       +30 Hit Points. Also you gain +30% experience"
            DescPicIndex(80) = "ImplSurvivalDesc"

            DetDescrText(0) = "You gain +1 Action Point."
            DescPicIndex(0) = "ABoyDesc"
            DetDescrText(1) = "If your Hit Points are below 50% you gain:    +1 AP and +10% to all restistances."
            DescPicIndex(1) = "ARushDesc"
            DetDescrText(2) = "You gain +18% to your Anti-Crit Resistance.   This stacks with armor anticrit bonuses."
            DescPicIndex(2) = "AnticriticalDescNeu"
            DetDescrText(3) = "You gain +20% on your critical hit table.     Note: This doesn't affect your      crit chance!"
            DescPicIndex(3) = "BetterCrDesc"
            DetDescrText(4) = "HtH attacks cost 1 Action Point less."
            'Adds to melee dmg?
            DescPicIndex(4) = "BHtHAtDesc"
            DetDescrText(5) = "You gain +4 HtH Damge."
            DescPicIndex(5) = "BHtHDmgDesc"
            DetDescrText(6) = "You do +2 additional damage for each bullet   on ranged weapons."
            DescPicIndex(6) = "BRDDesc"
            DetDescrText(7) = "Ranged weapon attacks cost 1 AP less."
            DescPicIndex(7) = "BRoFDesc"
            DetDescrText(8) = "This perk doesn't affect anything at the      moment and needs to be reworked."
            DescPicIndex(8) = ""
            DetDescrText(9) = "You gain +40 Armor Class."
            DescPicIndex(9) = "DodgerDesc"
            DetDescrText(10) = "You gain +6 Sequence."
            DescPicIndex(10) = "EarlSeqDesc"
            DetDescrText(11) = "Each Level Up you gain +2 Skill Points,      additionaly to your base value."
            DescPicIndex(11) = "EducatedDesc"
            DetDescrText(12) = "You gain +2 Agility."
            DescPicIndex(12) = "GAGDesc"
            DetDescrText(13) = "You gain +2 Charisma."
            DescPicIndex(13) = "StandbySW" 'no pic yet
            DetDescrText(14) = "You gain +2 Endurance."
            DescPicIndex(14) = "GENDesc"
            DetDescrText(15) = "You gain +2 Intelligence."
            DescPicIndex(15) = "StandbySW" 'no pic yet
            DetDescrText(16) = "You gain +2 Luck."
            DescPicIndex(16) = "GLuckDesc"
            DetDescrText(17) = "You gain +2 Perception."
            DescPicIndex(17) = "GainPEDesc"
            DetDescrText(18) = "You gain +2 Strenght."
            DescPicIndex(18) = "StandbySW" 'no pic yet
            DetDescrText(19) = "You gain +30% Sneak in dark conditions."
            DescPicIndex(19) = "StandbySW" 'no pic yet
            DetDescrText(20) = "You gain +40% Steal-Skill."
            DescPicIndex(20) = "HarmlessDesc"
            DetDescrText(21) = "+4-10 HP are healed when using First Aid."
            DescPicIndex(21) = "StandbySW" 'no pic yet
            DetDescrText(22) = "You get an additional bonus to your Armor    Class at the end of a turn. Note:    This perk has probably no effect in Real Time mode!"
            DescPicIndex(22) = "StandbySW" 'no pic yet
            DetDescrText(23) = "You gain +40 Hit Points."
            DescPicIndex(23) = "LifeGDesc"
            DetDescrText(24) = "You chance to set off a trap is lowered by   -90%."
            DescPicIndex(24) = "LStepDesc"
            DetDescrText(25) = "You gain +20% to your Doctor-Skill and deal  +5 damage to living creatures                (including other players)."
            DescPicIndex(25) = "StandbySW" 'no pic yet
            DetDescrText(26) = "You can carry 2 more people around with you."
            DescPicIndex(26) = "StandbySW" 'no pic yet
            DetDescrText(27) = "You gain +20% to Steal- and Lockpick-Skills."
            DescPicIndex(27) = "StandbySW" 'no pic yet
            DetDescrText(28) = "You gain +25% to First Aid- and Doctor-      Skills and your timeouts are decreased by 40%."
            DescPicIndex(28) = "MedicDesc"
            DetDescrText(29) = "You gain +8% Crit Chance."
            DescPicIndex(29) = "MCritsDesc"
            DetDescrText(30) = "You gain +10% to Repair- and Science-Skills."
            DescPicIndex(30) = "MrFixitDesc"
            DetDescrText(31) = "You gain +30% to your Outdoorsman-Skill and  your travel time (on world map) is   reduced by 30%."
            DescPicIndex(31) = "PFinderDesc"
            DetDescrText(32) = "Size and facing modifiers are ignored when   stealing. Note: Size means the       weight of an item"
            DescPicIndex(32) = "StandbySW" 'no pic yet
            DetDescrText(33) = "Inventory actions cost half AP. Reload and   Use costs only 1 AP."
            DescPicIndex(33) = "QHandsDesc"
            DetDescrText(34) = "You recover more quickly from knockdowns."
            DescPicIndex(34) = "QRecDesc"
            DetDescrText(35) = "You gain +2PE for determining range          (= +6 FOV or +8% Hit Chance)."
            DescPicIndex(35) = "SShootDesc"
            DetDescrText(36) = "You deal twice the damage, when performing   a HtH attack from behind."
            DescPicIndex(36) = "StandbySW" 'no pic yet
            DetDescrText(37) = "Ability to sneak and run at the same time.   Note: Must have for a sneak          character!"
            DescPicIndex(37) = "SilentRDesc"
            DetDescrText(38) = "The chance to be knocked down is decreased."
            DescPicIndex(38) = "StWallDesc"
            DetDescrText(39) = "You gain +22kg to your Carry Weight."
            DescPicIndex(39) = "StrBackDesc"
            DetDescrText(40) = "-10 seconds to Steal cooldown + chance for   no cooldown at all."
            DescPicIndex(40) = "ThiefDesc"
            DetDescrText(41) = "You gain +8% to all types of Damage          Resistance."
            DescPicIndex(41) = "ThoughDesc"
            DetDescrText(42) = "You gain +3 ST for weapon Strenght checks."
            DescPicIndex(42) = "WHandlDesc"

            'Achievements
            DetDescrName(43) = "Awareness"
            DetDescrName(44) = "Heave Ho!"
            DetDescrName(45) = "Pyromaniac"
            DetDescrName(64) = "Albert the Abberation"
            DetDescrName(65) = "Mother of God"
            DetDescrName(116) = "Pack Rat"

            DetDescrText(43) = "You now have detailed info about examined    critters/players. You will gain this perk automatically after reaching level 26."
            DescPicIndex(43) = "AchievAwarenessDesc"
            DetDescrText(44) = "You gain +3ST when determining throwing      range. In order to get this perk you need to kill 100 mans with throwing weapons."
            DescPicIndex(44) = "AchievHeaveDesc"
            DetDescrText(45) = "You gain +50 flat damage to fire-based       weapons. To obtain this achievement  you have to kill 100 humanoids with Flamer or        Improved Flamer."
            DescPicIndex(45) = "AchievPyroDesc"
            DetDescrText(64) = "You do +5 Damage to Floaters and Centaurs.   In order to achieve this you'll need to kill the Abberation in SF Tanker dungeon."
            DescPicIndex(64) = "AchievAlAberDesc"
            DetDescrText(65) = "You do +5 Damage to Deathclaws."
            DescPicIndex(65) = "AchievMoGDesc"
            DescPicIndex(116) = "AchievPackRDesc"
            DetDescrText(116) = "Carry Weight is increased by 23kg."

            'Statistics

            LblTagSkills.Visible = False
            LblSkPoints.Visible = True
            'LblSkPointsVal.Text = (2 * Stats.Intelligence) + 5
            'Skills.SkillP = (2 * Stats.Intelligence) + 5
            'Skills.skillPMax = Skills.SkillP
            BtnLvlUp.Visible = True
            BtnLvlDwn.Visible = True
            LblLevel.Visible = True

            'Enable Books, Quest...Buttons
            BtnBooks.Visible = True
            BtnQuests.Visible = True
            BtnAchievem.Visible = True
            BtnImpl.Visible = True

            'Save SkillTags for later Load/Save 
            SaveLoadSkillTag(0, True, isSGtag)
            SaveLoadSkillTag(1, True, isBGtag)
            SaveLoadSkillTag(2, True, isEWtag)
            SaveLoadSkillTag(3, True, isCCtag)
            SaveLoadSkillTag(4, True, isThrowtag)
            SaveLoadSkillTag(5, True, isFAtag)
            SaveLoadSkillTag(6, True, isDoctag)
            SaveLoadSkillTag(7, True, isSneaktag)
            SaveLoadSkillTag(8, True, isLPtag)
            SaveLoadSkillTag(9, True, isStealtag)
            SaveLoadSkillTag(10, True, isTrapstag)
            SaveLoadSkillTag(11, True, isSciencetag)
            SaveLoadSkillTag(12, True, isReptag)
            SaveLoadSkillTag(13, True, isSpeechtag)
            SaveLoadSkillTag(14, True, isBartertag)
            SaveLoadSkillTag(15, True, isGambtag)
            SaveLoadSkillTag(16, True, isODtag)


            'Books
            BooksCalc()
            'Minimum SkillVal
            NUDSkillsMinValues()
            'set levelVal to 1
            Perks.levelVal = 1

            'Save SkillVal
            SaveLevelStats(True, 0)

        End If
    End Sub

    'Update of Minimum Skill Values @Level
    Sub NUDSkillsMinValues()
        Dim ctl As Control
        Dim zaehler As Integer
        Dim s As String

        zaehler = 0
        For Each ctl In PanSkills.Controls
            If ctl.Text Like "*%" Then
                s = ctl.Text
                SkillsMinVal(zaehler) = s.Substring(0, (Len(ctl.Text) - 1))
                SkillsName(zaehler) = ctl.Name
                'Debug.Print("Skill: " & ctl.Name)
                zaehler = zaehler + 1
            End If
        Next


    End Sub

    'Updating Description of Perks when hovering 
    Private Sub LstVPerks_MouseHoover(ByVal sender As Object, _
      ByVal e As ListViewItemMouseHoverEventArgs) Handles LstVPerks.ItemMouseHover
        Dim strItem As String
        Dim s As String
        Dim text As String
        Dim Lenght As Integer
        Dim restLenght As Integer
        Dim resName As String

        'Hoovered Perk Text
        strItem = e.Item.Text
        s = strItem.Substring(0, (Len(e.Item.Text)))

        For i = 0 To UBound(DetDescrName)
            If s = DetDescrName(i) Then
                Lenght = Len(DetDescrText(i))
                text = DetDescrText(i)

                'PerkDescCaption

                LblDetDesc.Text = DetDescrName(i)


                If Lenght <= 45 Then

                    LblDetDescrText.Text = DetDescrText(i)

                ElseIf Lenght <= 90 Then
                    restLenght = Lenght - 45
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, restLenght)
                ElseIf Lenght <= 135 Then
                    restLenght = Lenght - 90
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                         & vbCrLf & text.Substring(90, restLenght)
                ElseIf Lenght <= 180 Then
                    restLenght = Lenght - 135
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                                            & vbCrLf & text.Substring(135, Lenght - (Lenght - 90)) & vbCrLf _
                                            & text.Substring(180, restLenght)
                End If

                'LblDetDescrText.Text = DetDescrText(i)

            End If
        Next

        'PicDescPic
        For i = 0 To UBound(DescPicIndex)
            If s = DetDescrName(i) Then
                resName = DescPicIndex(i)
                Try
                    Dim obj As Object = My.Resources.ResourceManager.GetObject(resName)
                    PicDesc.Image = obj
                Catch ex As Exception
                End Try
            End If
        Next

    End Sub

    '*******************
    '* Level UP Button *
    '*******************
    Private Sub BtnLvlUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLvlUp.Click
        Dim skillPLeft As Integer
        Dim ctl As Control
        Dim s As String

        ResetDrugEffects()

        Stats.GetStats()

        'not sure if needed later on
        lvlUp = True

        For Each ctl In PanSkills.Controls
            If ctl.Text Like "*%" Then
                If ctl.Top = panPos - 43 Then
                    s = ctl.Text
                    skillMin = s.Substring(0, (Len(ctl.Text) - 1))
                End If
            End If
        Next

        'refresh SkillP
        skillPLeft = LblSkPointsVal.Text
        SaveLevelStats(True, skillPLeft)

        Perks.levelVal = LblLevelVal.Text
        Perks.LevelTest(Perks.levelVal, Perkstaken)

        If Not Perks.isPerkToTake = True And Not Perks.levelVal = 99 Then


            If Perks.levelVal <= 25 Then
                If Perks.isEducated = True Then
                    Skills.SkillP = skillPLeft + (2 * Stats.Intelligence) + 5 + 2
                Else
                    Skills.SkillP = skillPLeft + (2 * Stats.Intelligence) + 5
                End If
            Else
                If Perks.isEducated = True Then
                    Skills.SkillP = skillPLeft + Math.Floor(((2 * Stats.Intelligence) + 5 + 2) / 2)
                Else
                    Skills.SkillP = skillPLeft + Math.Floor(((2 * Stats.Intelligence) + 5) / 2)
                End If
            End If
            LblSkPointsVal.Text = Skills.SkillP
            Skills.skillPMax = Skills.SkillP
            'PanSkUpDown.Visible = False
        End If
        'calc new MinValues for skills
        NUDSkillsMinValues()

        'clear array of taken Impl and maybe others
        'If SaveLoadImpl(Perks.levelVal, False, "Impl") <> "" Then
        'SaveLoadImpl(Perks.levelVal, True, "")
        'End If
        'Label3.Text = "N° Perks LvlUp: " & Perkstaken

        Perks.levelUP()

    End Sub

    Friend SkPointstolastlvl As Integer
    Friend HitPointstolastlvl As Integer
    Friend lastLevel As Integer
    Friend isFastUp As Boolean

    'Fast Up to lvl 99
    Private Sub BtnLvlFastUp_Click(sender As System.Object, e As System.EventArgs) Handles BtnLvlFastUp.Click
        Dim skillPLeft As Integer
        Dim ctl As Control
        Dim s As String
        'Dim hptemp As Integer
        'Dim lvlTemp As Integer

        ResetDrugEffects()

        Stats.GetStats()

        For Each ctl In PanSkills.Controls
            If ctl.Text Like "*%" Then
                If ctl.Top = panPos - 43 Then
                    s = ctl.Text
                    skillMin = s.Substring(0, (Len(ctl.Text) - 1))
                End If
            End If
        Next

        'refresh SkillP
        skillPLeft = LblSkPointsVal.Text
        lastLevel = LblLevelVal.Text
        Perks.levelVal = LblLevelVal.Text
        Perks.LevelTest(Perks.levelVal, Perkstaken)

        'todo --> save skills for lvl24 before going up
        SaveLevelStats(True, skillPLeft)

        If Not Perks.isPerkToTake = True And Not Perks.levelVal = 99 Then

            If Perks.levelVal <= 25 Then
                If Perks.isEducated = True Then
                    Skills.SkillP = skillPLeft + (((2 * Stats.Intelligence) + 5 + 2) * (26 - Perks.levelVal))
                    Skills.SkillP = Skills.SkillP + ((Math.Floor(((2 * Stats.Intelligence) + 5 + 2) / 2))) + ((99 - Perks.levelVal) - (26 - Perks.levelVal))
                    SkPointstolastlvl = (((2 * Stats.Intelligence) + 5 + 2) * (26 - Perks.levelVal))
                    'save added SKPoints for later
                    SkPointstolastlvl = SkPointstolastlvl + ((Math.Floor(((2 * Stats.Intelligence) + 5 + 2) / 2))) + ((99 - Perks.levelVal) - (26 - Perks.levelVal))
                Else
                    Skills.SkillP = skillPLeft + (((2 * Stats.Intelligence) + 5) * (26 - Perks.levelVal))
                    Skills.SkillP = Skills.SkillP + ((Math.Floor(((2 * Stats.Intelligence) + 5) / 2))) * ((99 - Perks.levelVal) - (26 - Perks.levelVal))
                    SkPointstolastlvl = (((2 * Stats.Intelligence) + 5) * (26 - Perks.levelVal))
                    SkPointstolastlvl = SkPointstolastlvl + ((Math.Floor(((2 * Stats.Intelligence) + 5) / 2))) * ((99 - Perks.levelVal) - (26 - Perks.levelVal))
                End If
            Else
                If Perks.isEducated = True Then
                    Skills.SkillP = skillPLeft + ((Math.Floor(((2 * Stats.Intelligence) + 5 + 2) / 2)) * (99 - Perks.levelVal))
                    SkPointstolastlvl = ((Math.Floor(((2 * Stats.Intelligence) + 5 + 2) / 2)) * (99 - Perks.levelVal))
                Else
                    Skills.SkillP = skillPLeft + ((Math.Floor(((2 * Stats.Intelligence) + 5) / 2)) * (99 - Perks.levelVal))
                    SkPointstolastlvl = ((Math.Floor(((2 * Stats.Intelligence) + 5) / 2)) * (99 - Perks.levelVal))
                End If
            End If
            LblSkPointsVal.Text = Skills.SkillP
            Skills.skillPMax = Skills.SkillP
            'PanSkUpDown.Visible = False
        End If
        'calc new MinValues for skills
        NUDSkillsMinValues()

        Stats.GetStats()
        Statistics.GetStatistics()

        If Not Perks.levelVal >= 99 And Not Perks.isPerkToTake = True Then

            'Stats
            'check if EN is equal or unequal
            If Not Perks.levelVal >= 26 Then

                Select Case Perks.levelVal
                    Case 24
                        If Stats.Endurance Mod 2 = 0 Then
                            Statistics.HitPoints = Statistics.HitPoints + ((Math.Floor(2 + (Stats.Endurance / 2))) * 2)
                            HitPointstolastlvl = ((Math.Floor(2 + (Stats.Endurance / 2))) * 2)
                        Else
                            Statistics.HitPoints = Statistics.HitPoints + ((Math.Floor(2 + (Stats.Endurance / 2))) * 2) + 1
                            HitPointstolastlvl = ((Math.Floor(2 + (Stats.Endurance / 2))) * 2) + 1
                        End If

                    Case 25
                        If Stats.Endurance Mod 2 = 0 Then
                            Statistics.HitPoints = Statistics.HitPoints + ((Math.Floor(2 + (Stats.Endurance / 2))))
                            HitPointstolastlvl = ((Math.Floor(2 + (Stats.Endurance / 2))))
                        Else
                            Statistics.HitPoints = Statistics.HitPoints + ((Math.Floor(2 + (Stats.Endurance / 2)))) + 1
                            HitPointstolastlvl = ((Math.Floor(2 + (Stats.Endurance / 2)))) + 1
                        End If

                End Select

                If Perks.levelVal = 24 Then
                    Statistics.HitPoints = Statistics.HitPoints + 36
                    HitPointstolastlvl = HitPointstolastlvl + 36
                    Statistics.CarryWeight = Statistics.CarryWeight + (99 - Perks.levelVal)
                    Perks.levelVal = 99
                    Statistics.SetStatistics()
                ElseIf Perks.levelVal = 25 Then
                    Statistics.HitPoints = Statistics.HitPoints + 36
                    HitPointstolastlvl = HitPointstolastlvl + 36
                    Statistics.CarryWeight = Statistics.CarryWeight + (99 - Perks.levelVal)
                    Perks.levelVal = 99
                    Statistics.SetStatistics()
                End If


            Else

                Statistics.CarryWeight = Statistics.CarryWeight + (99 - Perks.levelVal)
                Statistics.HitPoints = Statistics.HitPoints + ((99 - Perks.levelVal) / 2)
                HitPointstolastlvl = ((99 - Perks.levelVal) / 2)
                Perks.levelVal = Perks.levelVal + (99 - Perks.levelVal)
                Statistics.SetStatistics()

            End If

                'add CW


                'check if Perks can be seleceted
                'add to perk list


                If isPerklater = True Then
                    BtnLvlUp.Enabled = False
                    BtnLvlDwn.Enabled = False
                    Perks.availablePerks()
                    PanSkUpDown.Visible = False
                    PanSkills.Enabled = False
                    BtnBooks.Enabled = False
                    BtnQuests.Enabled = False
                    BtnAchievem.Enabled = False
                    BtnImpl.Enabled = False
                End If

            End If

        BtnLvlUp.Visible = False
        BtnLvlDwn.Visible = False

        BtnLvlFastDwn.Visible = True
        BtnLvlFastUp.Visible = False
        LblLevelVal.Text = Perks.levelVal

        isFastUp = True

        Statistics.SetStatistics()

    End Sub

    'Fast down from lvl 99
    Private Sub BtnLvlFastDwn_Click(sender As System.Object, e As System.EventArgs) Handles BtnLvlFastDwn.Click
        BtnLvlFastDwn.Visible = False

        ResetDrugEffects()

        Statistics.GetStatistics()
        Statistics.HitPoints = Statistics.HitPoints - HitPointstolastlvl
        Statistics.CarryWeight = Statistics.CarryWeight - (99 - lastLevel)
        Statistics.SetStatistics()

        Perks.levelVal = lastLevel
        LblLevelVal.Text = lastLevel

        'skillpoints
        Skills.SkillP = Skills.SkillP - SkPointstolastlvl
        Skills.LoadSkills()

        BtnLvlDwn.Visible = True
        BtnLvlUp.Visible = True
        BtnLvlFastUp.Visible = True

        isFastUp = False

        'MessageBox.Show("lastlevel: " & lastLevel)
        'MessageBox.Show("HPtolast: " & HitPointstolastlvl)
        'MessageBox.Show("SKPtolast: " & SkPointstolastlvl)
    End Sub


    '********************************************
    '* Color Behaviour of ListBItems/ListVItems *
    '********************************************

    Private Sub LstVChess_DrawItem(ByVal sender As Object, _
   ByVal e As DrawListViewItemEventArgs) _
   Handles LstVChess.DrawItem
        If Not (e.State And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
        End If
        e.DrawText()
    End Sub

    Private Sub LstVAchiev_DrawItem(ByVal sender As Object, _
    ByVal e As DrawListViewItemEventArgs) _
    Handles LstVAchiev.DrawItem
        If Not (e.State And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
        End If
        e.DrawText()
    End Sub

    Private Sub LstVQuests_DrawItem(ByVal sender As Object, _
    ByVal e As DrawListViewItemEventArgs) _
    Handles LstVQuests.DrawItem
        If Not (e.State And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
        End If
        e.DrawText()
    End Sub

    Private Sub LstVImpl_DrawItem(ByVal sender As Object, _
     ByVal e As DrawListViewItemEventArgs) _
     Handles LstVImpl.DrawItem
        If Not (e.State And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
        End If
        e.DrawText()
    End Sub

    Private Sub LstV1_DrawItem(ByVal sender As Object, _
      ByVal e As DrawListViewItemEventArgs) _
      Handles LstVBooks.DrawItem
        If Not (e.State And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
        End If

    End Sub

    Private Sub LstV1_DrawSItem(ByVal sender As Object, _
      ByVal e As DrawListViewSubItemEventArgs) _
      Handles LstVBooks.DrawSubItem
        If Not (e.ItemState And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
        End If

        ' Draw the item text for views other than the Details view.

        e.DrawText()
    End Sub

    Private Sub LstVPerks_DrawItem(ByVal sender As Object, _
      ByVal e As DrawListViewItemEventArgs) _
      Handles LstVPerks.DrawItem

        If Not (e.State And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
        End If

        ' Draw the item text for views other than the Details view.
        If Not Me.LstVPerks.View = View.Details Then
            e.DrawText()
        End If

    End Sub

    Dim HiLiteBrush As New SolidBrush(Color.FromArgb(255, 20, 50, 21))

    Private Sub ListBoxPerks_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles LstBoxPerks.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(HiLiteBrush, e.Bounds)
        End If
        If Not LstBoxPerks.Items.Count = 0 Then
            Using b As New SolidBrush(e.ForeColor)
                Try
                    e.Graphics.DrawString(LstBoxPerks.GetItemText(LstBoxPerks.Items(e.Index)), e.Font, b, e.Bounds)
                Catch ex As Exception

                End Try

            End Using
        End If
        e.DrawFocusRectangle()
    End Sub

    'Perks selection
    Private Sub PerkSel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVPerks.ItemSelectionChanged
        Dim item As ListViewItem
        Dim strItem As String
        Dim isPerkchoosen As Boolean
        Dim PRank(15) As Integer
        Dim perkFoundInLstB As Boolean
        Dim rankhigh As Boolean

        isPerkchoosen = False
        For Each item In LstVPerks.SelectedItems
            isPerkchoosen = True
            strItem = item.Text

            perkFoundInLstB = False
            rankhigh = False

            'check if perk can be taken more then once
            'If so, a number, according to the actual rank is written in brackets next to perk caption.
            If Not strItem = "Medic" Then
                If Not LstBoxPerks.Items.Count = 0 Then
                    For i = 0 To LstBoxPerks.Items.Count - 1
                        If InStr(LstBoxPerks.Items(i), strItem) > 0 Then

                            If InStr(LstBoxPerks.Items(i), "(2)") > 0 Then
                                LstBoxPerks.Items(i) = strItem & " (3)"
                                perkFoundInLstB = True
                                rankhigh = True
                                Exit For
                            Else
                                LstBoxPerks.Items(i) = strItem & " (2)"
                                perkFoundInLstB = True
                                Exit For
                            End If
                        Else
                            perkFoundInLstB = False
                        End If
                    Next
                Else
                    perkFoundInLstB = False
                End If
            End If

            If perkFoundInLstB = False Then
                LstBoxPerks.Items.Add(strItem)
            End If

            If Not isSaveEnhanceImplPerk = True Then
                'prevent count of Enhancement Impl-Perk as regular perk
                Perkstaken = Perkstaken + 1
            End If
            SaveLoadPerkLater(Perks.levelVal, True, Perkstaken)
            Perks.addTakenPerks(strItem)
            Perks.perkChanges(strItem)
            item.Remove()

            'SavePerk
            'check for ranked perk
            If perkFoundInLstB = True And rankhigh = True Then
                SavePerkStats(strItem & " (3)", Perks.levelVal)
            ElseIf perkFoundInLstB = True And rankhigh = False Then
                SavePerkStats(strItem & " (2)", Perks.levelVal)
            Else
                SavePerkStats(strItem, Perks.levelVal)

            End If

        Next

        If isPerkchoosen = True Then
            isPerklater = False
            SaveLoadPerkLater(Perks.levelVal, True, False)
            For Each item In LstVPerks.Items
                item.Remove()
            Next
        End If

        BtnPerkLater.Visible = False
        BtnLvlUp.Enabled = True
        BtnLvlDwn.Enabled = True
        PanSkills.Enabled = True

        BtnBooks.Enabled = True
        BtnQuests.Enabled = True
        BtnAchievem.Enabled = True
        BtnImpl.Enabled = True

        'If lvl24 is reached show BtnLvlFastUp
        If Perks.levelVal >= 24 Then
            BtnLvlFastUp.Visible = True
        Else
            BtnLvlFastUp.Visible = False
        End If
    End Sub

    '*******************************************************
    '* Raising/Lowering Skills via Numeric Up/Down Element *
    '*******************************************************
    'Buttons react on hold 
    '...todo: if hold longer --> speed increase <-- done, experimental

    'skillVal needs to be updated when going back (down) in Level
    Sub SkillValAfterLoad()
        Dim ctl As Control
        Dim s As String

        For Each ctl In PanSkills.Controls
            If ctl.Text Like "*%" Then
                s = ctl.Text
                If ctl.Top = panPos - 43 Then
                    skillVal = s.Substring(0, (Len(ctl.Text) - 1))
                End If
            End If
        Next

        NUDSkillsMinValues()

        For Each ctl In PanSkills.Controls
            If ctl.Text Like "*%" Then
                If ctl.Top = panPos - 43 Then
                    s = ctl.Text
                    skillVal = s.Substring(0, (Len(ctl.Text) - 1))

                    For i = 0 To UBound(SkillsName)
                        If SkillsName(i) = ctl.Name Then
                            skillMin = SkillsMinVal(i)
                        End If
                    Next
                End If
            End If
        Next
    End Sub

    'Lowering Skill Points
    Private Sub BtnSKDown_MouseDown(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnSkDown.MouseDown, BtnSkDown.Click
        Dim ctl As Control
        Dim s As String
        ' Aktion starten
        If Not bMouseDown Then
            bMouseDown = True
            Do While bMouseDown
                System.Threading.Thread.Sleep(120)

                For Each ctl In PanSkills.Controls
                    If ctl.Text Like "*%" Then
                        If ctl.Top = panPos - 43 Then

                            If ctl.ForeColor = Color.WhiteSmoke Then
                                Select Case skillVal

                                    'when tagged
                                    '0% - 100% : 2% further costs 1 skill point
                                    '101% - 125% : 2% further costs 2 skill points
                                    '126% - 150% : 2% further costs 3 skill points
                                    '151% - 175% : 2% further costs 4 skill points
                                    '176% - 200% : 2% further costs 5 skill points
                                    '201% - 300% : 2% further costs 6 skill points

                                    Case 0 To 102
                                        skillMax = skillVal + (Skills.SkillP * 2)
                                        incr = 2
                                        neededSP = 1
                                    Case 103 To 126
                                        skillMax = skillVal + Skills.SkillP
                                        incr = 2
                                        neededSP = 2

                                    Case 127 To 151
                                        skillMax = skillVal + (Skills.SkillP / 1.5)
                                        incr = 2
                                        neededSP = 3

                                    Case 152 To 176
                                        skillMax = skillVal + (Skills.SkillP / 2)
                                        incr = 2
                                        neededSP = 4
                                    Case 177 To 202
                                        skillMax = skillVal + (Skills.SkillP / 2.5)
                                        incr = 2
                                        neededSP = 5
                                    Case 203 To 300
                                        skillMax = skillVal + (Skills.SkillP / 3)
                                        incr = 2
                                        neededSP = 6

                                End Select
                            Else
                                Select Case skillVal
                                    '0% - 100% : 1% further costs 1 skill point
                                    '101% - 125% : 1% further costs 2 skill points
                                    '126% - 150% : 1% further costs 3 skill points
                                    '151% - 175% : 1% further costs 4 skill points
                                    '176% - 200% : 1% further costs 5 skill points
                                    '201% - 300% : 1% further costs 6 skill points

                                    Case 0 To 101
                                        skillMax = skillVal + Skills.SkillP
                                        incr = 1
                                        neededSP = 1
                                    Case 102 To 126
                                        skillMax = skillVal + (Skills.SkillP / 2)
                                        incr = 1
                                        neededSP = 2

                                    Case 127 To 151
                                        skillMax = skillVal + (Skills.SkillP / 3)
                                        incr = 1
                                        neededSP = 3

                                    Case 152 To 176
                                        skillMax = skillVal + (Skills.SkillP / 4)
                                        incr = 1
                                        neededSP = 4

                                    Case 177 To 201
                                        skillMax = skillVal + (Skills.SkillP / 5)
                                        incr = 1
                                        neededSP = 5

                                    Case 202 To 300
                                        skillMax = skillVal + (Skills.SkillP / 6)
                                        incr = 1
                                        neededSP = 6

                                End Select
                            End If

                        End If
                    End If
                Next

                For Each ctl In PanSkills.Controls
                    If ctl.Text Like "*%" Then
                        If ctl.Top = panPos - 43 Then
                            s = ctl.Text
                            'skillVal = s.Substring(0, (Len(ctl.Text) - 1))
                            If Not ctl.Name = "LblScavenVal" And Not ctl.Name = "LblBarterVal" Then
                                If Not skillVal = skillMin Then
                                    skillVal = skillVal - incr
                                    ctl.Text = skillVal & "%"
                                    'If Not LblLevelVal.Text = "1" Then

                                    Skills.SkillP = Skills.SkillP + neededSP
                                    'Label10.Text = skills.skillP
                                    LblSkPointsVal.Text = Skills.SkillP
                                    'End If
                                End If
                            End If
                        End If
                    End If
                Next

                Application.DoEvents()
            Loop
        End If
        Statistics.GetStatistics()
        Statistics.SetStatistics()
    End Sub

    'Raising Skill Points
    Private Sub BtnSKUp_MouseDown(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnSkUp.MouseDown, BtnSkUp.Click
        Dim ctl As Control
        Dim s As String
        Dim sleepVal As Integer

        ' Aktion starten
        Skills.SkillP = LblSkPointsVal.Text
        If Skills.SkillP < 100 Then
            sleepVal = 120
        ElseIf Skills.SkillP < 200 Then
            sleepVal = 100
        Else
            sleepVal = 80
        End If

        If Not bMouseDown Then
            bMouseDown = True
            Do While bMouseDown

                System.Threading.Thread.Sleep(sleepVal)

                'check if UpDown Panel has moved or not

                For Each ctl In PanSkills.Controls
                    If ctl.Text Like "*%" Then
                        If ctl.Top = panPos - 43 Then

                            If ctl.ForeColor = Color.WhiteSmoke Then
                                Select Case skillVal

                                    'when tagged
                                    '0% - 100% : 2% further costs 1 skill point
                                    '101% - 125% : 2% further costs 2 skill points
                                    '126% - 150% : 2% further costs 3 skill points
                                    '151% - 175% : 2% further costs 4 skill points
                                    '176% - 200% : 2% further costs 5 skill points
                                    '201% - 300% : 2% further costs 6 skill points

                                    Case 0 To 100
                                        skillMax = skillVal + (Skills.SkillP * 2)
                                        incr = 2
                                        neededSP = 1
                                    Case 101 To 124
                                        skillMax = skillVal + Skills.SkillP
                                        incr = 2
                                        neededSP = 2

                                    Case 125 To 149
                                        skillMax = skillVal + (Skills.SkillP / 1.5)
                                        incr = 2
                                        neededSP = 3

                                    Case 150 To 174
                                        skillMax = skillVal + (Skills.SkillP / 2)
                                        incr = 2
                                        neededSP = 4
                                    Case 175 To 200

                                        skillMax = skillVal + (Skills.SkillP / 2.5)
                                        incr = 2
                                        neededSP = 5
                                    Case 201 To 300
                                        skillMax = skillVal + (Skills.SkillP / 3)
                                        incr = 2
                                        neededSP = 6

                                End Select
                            Else
                                Select Case skillVal
                                    '0% - 100% : 1% further costs 1 skill point
                                    '101% - 125% : 1% further costs 2 skill points
                                    '126% - 150% : 1% further costs 3 skill points
                                    '151% - 175% : 1% further costs 4 skill points
                                    '176% - 200% : 1% further costs 5 skill points
                                    '201% - 300% : 1% further costs 6 skill points

                                    Case 0 To 100
                                        skillMax = skillVal + Skills.SkillP
                                        incr = 1
                                        neededSP = 1
                                    Case 101 To 125
                                        skillMax = skillVal + (Skills.SkillP / 2)
                                        incr = 1
                                        neededSP = 2
                                    Case 126 To 150
                                        skillMax = skillVal + (Skills.SkillP / 3)
                                        incr = 1
                                        neededSP = 3
                                    Case 151 To 175
                                        skillMax = skillVal + (Skills.SkillP / 4)
                                        incr = 1
                                        neededSP = 4
                                    Case 176 To 200
                                        skillMax = skillVal + (Skills.SkillP / 5)
                                        incr = 1
                                        neededSP = 5
                                    Case 201 To 300
                                        skillMax = skillVal + (Skills.SkillP / 6)
                                        incr = 1
                                        neededSP = 6
                                End Select
                            End If

                        End If
                    End If
                Next


                For Each ctl In PanSkills.Controls
                    If ctl.Text Like "*%" Then
                        If ctl.Top = panPos - 43 Then
                            s = ctl.Text
                            If ctl.Name = "LblCCombVal" Then
                                If skillMax >= 200 Then
                                    skillMax = 200
                                End If
                            Else
                                If skillMax >= 300 Then
                                    skillMax = 300
                                End If
                            End If
                            If Not Skills.SkillP = 0 And Not ctl.Name = "LblScavenVal" And Not ctl.Name = "LblBarterVal" Then
                                If Not skillVal >= skillMax And Skills.SkillP - neededSP >= 0 Then
                                    skillVal = skillVal + incr
                                    ctl.Text = skillVal & "%"
                                    If skillVal > 300 Then
                                        ctl.Text = "300%"
                                    End If
                                    Skills.SkillP = Skills.SkillP - neededSP
                                    LblSkPointsVal.Text = Skills.SkillP
                                End If
                            End If
                        End If
                    End If
                Next

                'Important ---> to react on Mouse Event

                Application.DoEvents()
            Loop
        End If

        Statistics.GetStatistics()
        Statistics.SetStatistics()
    End Sub

    Private Sub BtnSKUp_MouseUp(ByVal sender As Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnSkUp.MouseUp, BtnSkDown.MouseUp

        'End action
        bMouseDown = False
    End Sub

    'Option to choose a perk later on
    Private Sub BtnPerkLater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPerkLater.Click
        For Each item In LstVPerks.Items
            item.Remove()
        Next
        BtnPerkLater.Visible = False
        BtnLvlUp.Enabled = True
        BtnLvlDwn.Enabled = True
        PanSkills.Enabled = True
        isPerklater = True

        BtnBooks.Enabled = True
        BtnQuests.Enabled = True
        BtnAchievem.Enabled = True
        BtnImpl.Enabled = True

        SaveLoadPerkLater(Perks.levelVal, True, isPerklater)

    End Sub

    Sub LoadPerkLater(ByVal levelNo As Integer)
        isPerklater = SaveLoadPerkLater(levelNo, False, False)
        SaveLoadPerkLater(levelNo, True, False)
        'Label3.Text = isPerklater
    End Sub

    Function SaveLoadPerkLater(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal isNotTaken As Boolean)
        Static PerkNotTakenAtLvl(100, 1) As Boolean

        If saveload = True Then
            PerkNotTakenAtLvl(LevelNo, 0) = isNotTaken
            Return 1
        Else
            Return PerkNotTakenAtLvl(LevelNo, 0)
            'erase data entry
            PerkNotTakenAtLvl(LevelNo, 0) = False
        End If
    End Function

    Sub LoadPerkstaken(ByVal levelNo As Integer)
        Perkstaken = SaveLoadPerkstaken(levelNo, False, 1)
    End Sub

    Function SaveLoadPerkstaken(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal PTaken As Integer)
        Static PerkstakenAtlLvl(100, 1) As Integer
        If saveload = True Then
            PerkstakenAtlLvl(LevelNo, 0) = PTaken
            Return 1
        Else
            Return PerkstakenAtlLvl(LevelNo, 0)
            'PerkstakenAtlLvl(LevelNo, 0) = 0
        End If
    End Function

    'Achievements
    Private Sub LstVAchieve_Indexchange(ByVal sender As System.Object, ByVal e As EventArgs) Handles LstVAchiev.ItemSelectionChanged
        Dim strItem As ListViewItem
        Dim Achievement As String
        Dim valueSK As Integer
        Dim s As String

        For Each strItem In LstVAchiev.SelectedItems
            Achievement = strItem.Text
            strItem.Remove()
            Exit For
        Next
        If Not Achievement = "" Then
            LstBoxPerks.Items.Add(Achievement)
            If Achievement = "Pathfinder" Then

                DetDescrChange(31, 31)

                s = LblODVal.Text
                valueSK = s.Substring(0, (Len(LblODVal.Text) - 1))
                If valueSK + 30 <= 300 Then
                    Skills.ODMan = Skills.ODMan + 30
                    LblODVal.Text = (valueSK + 30) & "%"
                Else
                    LblODVal.Text = 300 & "%"
                End If

            End If

            If Achievement = "Engineering Implant" Then
                
                Skills.getSkillValues()
                If Skills.Repair + 100 >= 300 Then
                    Skills.Repair = 300
                    LblRepairVal.Text = 300 & "%"
                Else
                    Skills.Repair = Skills.Repair + 100
                    LblRepairVal.Text = Skills.Repair & "%"
                End If

                If Skills.Science + 100 >= 300 Then
                    Skills.Science = 300
                    LblScienceVal.Text = 300 & "%"
                Else
                    Skills.Science = Skills.Science + 100
                    LblScienceVal.Text = Skills.Science & "%"
                End If

                If Skills.EWeapons + 100 >= 300 Then
                    Skills.EWeapons = 300
                    LblEWeaponsVal.Text = 300 & "%"
                Else
                    Skills.EWeapons = Skills.EWeapons + 100
                    LblEWeaponsVal.Text = Skills.EWeapons & "%"
                End If
            End If

            If Achievement = "Pack Rat" Then
                Statistics.GetStatistics()
                Statistics.CarryWeight = Statistics.CarryWeight + 23
                Statistics.SetStatistics()
            End If
        End If

        'update skill values 
        NUDSkillsMinValues()
        SaveLoadAchievements(Perks.levelVal, True, Achievement)

    End Sub


    'Drugs
    'Visual Behaviour when hoovering
    Private Sub BtnDrugsBuff_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsBuff.MouseHover
        BtnDrugsBuff.Image = My.Resources.BuffoutHighNew
    End Sub

    Private Sub BtnDrugsBuff_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsBuff.MouseLeave
        If Not isBuffoutActive = True Then
            BtnDrugsBuff.Image = My.Resources.BuffoutNew
        End If
    End Sub

    Private Sub BtnDrugsJet_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsJet.MouseHover
        BtnDrugsJet.Image = My.Resources.JetHigh
    End Sub

    Private Sub BtnDrugsJet_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsJet.MouseLeave
        If Not isJetActive = True Then
            BtnDrugsJet.Image = My.Resources.Jet
        End If
    End Sub

    Private Sub BtnDrugsPsycho_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsPsycho.MouseHover
        BtnDrugsPsycho.Image = My.Resources.PsychoHigh
    End Sub

    Private Sub BtnDrugsPsycho_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsPsycho.MouseLeave
        If Not isPsychoActive = True Then
            BtnDrugsPsycho.Image = My.Resources.Psycho
        End If
    End Sub

    Private Sub BtnDrugsNuka_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsNuka.MouseHover
        BtnDrugsNuka.Image = My.Resources.NukaHigh
    End Sub

    Private Sub BtnDrugsNuka_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsNuka.MouseLeave
        If Not isNukaActive = True Then
            BtnDrugsNuka.Image = My.Resources.Nuka
        End If
    End Sub
    Private Sub BtnDrugsCigs_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsCigs.MouseHover
        BtnDrugsCigs.Image = My.Resources.CigarettesHighNew
    End Sub

    Private Sub BtnDrugsCigs_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDrugsCigs.MouseLeave
        If Not isCigsActive = True Then
            BtnDrugsCigs.Image = My.Resources.CigarettesNew
        End If
    End Sub

    'Click on Drugs
    Friend AddSubstractJetAP As Integer = 3
    Friend AddSubstractBuffoutST As Integer = 2
    Friend AddSubstractBuffoutEN As Integer = 1
    Friend AddSubstractPsychoDMGRes As Integer = 20
    Friend AddSubstractPsychoIN As Integer = 2
    Friend AddSubstractPsychoPE As Integer = 7
    Friend AddSubstractNukaAP As Integer = 1
    Friend AddSubstractCigsFoV As Integer = 3

    Friend PEBeforePsycho As Integer
    Friend INBeforePsycho As Integer

    Dim isJetActive As Boolean
    Dim isBuffoutActive As Boolean
    Dim isPsychoActive As Boolean
    Dim isNukaActive As Boolean
    Dim isCigsActive As Boolean

    'DetDescrName(137) = "Jet"
    'DetDescrText(137) = "Effect: +3 Action Points.                    Addiction: -1 Action Point."
    'DetDescrName(138) = "Buffout"
    'DetDescrText(138) = "Effect: +2 Strenght, +1 Endurance.           Addiction: -1 Strenght , -1 Endurance."
    'DetDescrName(139) = "Psycho"
    'DetDescrText(139) = "Effect: +20% to normal dmg. res,             -7 to PE, -2 to IN .                         Addiction: -10% Damage Resistance."
    'DetDescrName(140) = "Nuka Cola"
    'DetDescrText(140) = "Effect: +1 Action Point.                     Addiction: None."
    'DetDescrName(141) = "Cigarettes"
    'DetDescrText(141) = "Effect: +3 to Field of view.          "

    Private Sub BtnDrugsJet_Click(sender As System.Object, e As System.EventArgs) Handles BtnDrugsJet.Click
       
        DetDescrChange(137, 137)
        PicDesc.Image = My.Resources.JetDescPic
        Statistics.GetStatistics()
        If isJetActive = True Then
            isJetActive = False
            BtnDrugsJet.Image = My.Resources.Jet
            Statistics.APoints = Statistics.APoints - AddSubstractJetAP

            If Not isNukaActive = True Then
                LblAPointsVal.ForeColor = Color.LimeGreen
                LblAPointsVal.Font = myFontNormal
            End If
        Else
            isJetActive = True
            BtnDrugsJet.Image = My.Resources.JetHigh
            Statistics.APoints = Statistics.APoints + AddSubstractJetAP
            LblAPointsVal.ForeColor = Color.LightSkyBlue
            LblAPointsVal.Font = myFontBold
        End If

        TestActiveDrugs()
        Statistics.SetStatistics()
    End Sub

    Private Sub BtnDrugsBuff_Click(sender As System.Object, e As System.EventArgs) Handles BtnDrugsBuff.Click
        DetDescrChange(138, 138)
        PicDesc.Image = My.Resources.BuffoutDescPic
        Stats.GetStats()
        Statistics.GetStatistics()
        If isBuffoutActive = True Then
            isBuffoutActive = False
            BtnDrugsBuff.Image = My.Resources.BuffoutNew
            Stats.Strenght = Stats.Strenght - AddSubstractBuffoutST
            Stats.Endurance = Stats.Endurance - AddSubstractBuffoutEN

            LblMDmgVal.ForeColor = Color.LimeGreen
            LblMDmgVal.Font = myFontNormal
            LblCWVal.ForeColor = Color.LimeGreen
            LblCWVal.Font = myFontNormal
            LblPoisonResVal.ForeColor = Color.LimeGreen
            LblPoisonResVal.Font = myFontNormal
            LblRadResVal.ForeColor = Color.LimeGreen
            LblRadResVal.Font = myFontNormal
            LblStatsENVal.ForeColor = Color.LimeGreen
            LblStatsSTVal.ForeColor = Color.LimeGreen
        Else
            isBuffoutActive = True
            BtnDrugsBuff.Image = My.Resources.BuffoutHighNew

            If Not Stats.Strenght = 10 Then
                If Not Stats.Strenght = 9 Then
                    Stats.Strenght = Stats.Strenght + AddSubstractBuffoutST
                Else
                    Stats.Strenght = Stats.Strenght + 1
                    AddSubstractBuffoutST = 1
                End If
            Else
                AddSubstractBuffoutST = 0
            End If

            If Not Stats.Endurance = 10 Then
                Stats.Endurance = Stats.Endurance + AddSubstractBuffoutEN
            Else
                AddSubstractBuffoutEN = 0
            End If


            LblMDmgVal.ForeColor = Color.LightSkyBlue
            LblMDmgVal.Font = myFontBold
            LblCWVal.ForeColor = Color.LightSkyBlue
            LblCWVal.Font = myFontBold
            LblPoisonResVal.ForeColor = Color.LightSkyBlue
            LblPoisonResVal.Font = myFontBold
            LblRadResVal.ForeColor = Color.LightSkyBlue
            LblRadResVal.Font = myFontBold
            LblStatsENVal.ForeColor = Color.LightSkyBlue
            LblStatsSTVal.ForeColor = Color.LightSkyBlue

        End If
        Stats.SetStats()
        Stats.GetStats()
        'Radiation/Poison Resist Calc
        If isFastMeta = False Then
            Statistics.RadRes = 2 * Stats.Endurance
        Else
            Statistics.RadRes = 0
        End If

        If isFastMeta = False Then
            Statistics.PoisonRes = 5 * Stats.Endurance
        Else
            Statistics.PoisonRes = 0
        End If

        'CW
        If isSFrame = True Then
            If Stats.Strenght = 2 Then
                Statistics.CarryWeight = 33 + (Perks.levelVal - 1) '<-- todo --> 33 base value + 1 * N° of lvl!!!
            ElseIf Stats.Strenght = 7 Then
                Statistics.CarryWeight = 67 + (Perks.levelVal - 1)
            Else
                Statistics.CarryWeight = Math.Round((20 + (Stats.Strenght * 15) / 2.2046226), 0) + (Perks.levelVal - 1)
            End If
        Else
            If Stats.Strenght = 8 Then
                Statistics.CarryWeight = 110 + (Perks.levelVal - 1) '<-- todo --> 110 base value + 1 * N° of lvl!!!          
            Else
                Statistics.CarryWeight = Math.Round((20 + (Stats.Strenght * 25) / 2.2046226), 0) + (Perks.levelVal - 1)
            End If
        End If

        'Melee Calc New
        Statistics.MeleeDmg = Stats.Strenght + (Statistics.addHHanded) + (Statistics.addBruiser) + (Statistics.addMutantMDmg)
        TestActiveDrugs()
        Statistics.SetStatistics()
    End Sub

    Private Sub BtnDrugsPsycho_Click(sender As System.Object, e As System.EventArgs) Handles BtnDrugsPsycho.Click

        DetDescrChange(139, 139)
        PicDesc.Image = My.Resources.PsychoDescPic
        Statistics.GetStatistics()
        If isPsychoActive = True Then
            isPsychoActive = False
            BtnDrugsPsycho.Image = My.Resources.Psycho

            Stats.Perception = PEBeforePsycho
            Stats.Intelligence = INBeforePsycho

            Statistics.DmgRes = Statistics.DmgRes - AddSubstractPsychoDMGRes

            LblSightVal.ForeColor = Color.LimeGreen
            LblSightVal.Font = myFontNormal
            LblStatsPEVal.ForeColor = Color.LimeGreen
            LblStatsINVal.ForeColor = Color.LimeGreen
            LblDmgResVal.ForeColor = Color.LimeGreen
            LblDmgResVal.Font = myFontNormal

        Else
            isPsychoActive = True
            BtnDrugsPsycho.Image = My.Resources.PsychoHigh

            PEBeforePsycho = Stats.Perception
            INBeforePsycho = Stats.Intelligence

            If Stats.Perception - 7 <= 1 Then
                Stats.Perception = 1
            Else
                Stats.Perception = Stats.Perception - AddSubstractPsychoPE
            End If

            If Stats.Intelligence - 2 <= 1 Then
                Stats.Intelligence = 1
            Else
                Stats.Intelligence = Stats.Intelligence - AddSubstractPsychoIN
            End If

            Statistics.DmgRes = Statistics.DmgRes + AddSubstractPsychoDMGRes

            LblSightVal.ForeColor = Color.LightSkyBlue
            LblSightVal.Font = myFontBold
            LblStatsPEVal.ForeColor = Color.LightSkyBlue
            LblStatsINVal.ForeColor = Color.LightSkyBlue
            LblDmgResVal.ForeColor = Color.LightSkyBlue
            LblDmgResVal.Font = myFontBold
        End If
        Stats.SetStats()
        Stats.GetStats()
        TestActiveDrugs()
        Statistics.Sight = 20 + (Stats.Perception * 3)
        Statistics.SetStatistics()
    End Sub

    Private Sub BtnDrugsNuka_Click(sender As System.Object, e As System.EventArgs) Handles BtnDrugsNuka.Click

        DetDescrChange(140, 140)
        PicDesc.Image = My.Resources.NukaDescPic
        Statistics.GetStatistics()
        If isNukaActive = True Then
            isNukaActive = False
            BtnDrugsNuka.Image = My.Resources.Nuka

            Statistics.APoints = Statistics.APoints - AddSubstractNukaAP

            If Not isJetActive = True Then
                LblAPointsVal.ForeColor = Color.LimeGreen
                LblAPointsVal.Font = myFontNormal
            End If
        Else
            isNukaActive = True
            BtnDrugsNuka.Image = My.Resources.NukaHigh
            Statistics.APoints = Statistics.APoints + AddSubstractNukaAP
            LblAPointsVal.ForeColor = Color.LightSkyBlue
            LblAPointsVal.Font = myFontBold
          
        End If
        TestActiveDrugs()
        Statistics.SetStatistics()
    End Sub

    Private Sub BtnDrugsCigs_Click(sender As System.Object, e As System.EventArgs) Handles BtnDrugsCigs.Click

        DetDescrChange(141, 141)
        PicDesc.Image = My.Resources.CigsDescPic
        Statistics.GetStatistics()
        If isCigsActive = True Then
            isCigsActive = False
            BtnDrugsCigs.Image = My.Resources.CigarettesNew

            Statistics.Sight = Statistics.Sight - AddSubstractCigsFoV
            LblSightVal.ForeColor = Color.LimeGreen
            LblSightVal.Font = myFontNormal


        Else
            isCigsActive = True
            BtnDrugsCigs.Image = My.Resources.CigarettesHighNew
            Statistics.Sight = Statistics.Sight + AddSubstractCigsFoV
            LblSightVal.ForeColor = Color.LightSkyBlue
            LblSightVal.Font = myFontBold
        End If
        TestActiveDrugs()
        Statistics.SetStatistics()
    End Sub

    Private Sub BtnAllDrugs_Click(sender As System.Object, e As System.EventArgs) Handles BtnAllDrugs.Click
        If isAllDrugsActive = False Then
            ResetDrugEffects()
            BtnDrugsJet_Click(sender, e)
            BtnDrugsBuff_Click(sender, e)
            BtnDrugsPsycho_Click(sender, e)
            BtnDrugsNuka_Click(sender, e)
            BtnDrugsCigs_Click(sender, e)

            BtnAllDrugs.Image = My.Resources.Antitoxin
            PicDesc.Image = My.Resources.AntitoxinDescPic
            BtnAllDrugs.Text = Nothing

            isAllDrugsActive = True
        Else
            BtnAllDrugs.Text = "All"
            BtnAllDrugs.Font = myFontAll
            BtnAllDrugs.Image = Nothing
            ResetDrugEffects()
            isAllDrugsActive = False
        End If
       
    End Sub

    Friend isAllDrugsActive As Boolean
    Private Sub TestActiveDrugs()
        If isJetActive = True And isBuffoutActive = True And isPsychoActive _
            And isNukaActive And isCigsActive = True Then
            BtnAllDrugs.Image = My.Resources.Antitoxin
            PicDesc.Image = My.Resources.AntitoxinDescPic
            BtnAllDrugs.Text = Nothing
            isAllDrugsActive = True
        Else
            isAllDrugsActive = False
        End If
    End Sub

    Private Sub ResetDrugEffects()
        Statistics.GetStatistics()
        Stats.GetStats()
        If isJetActive = True Then
            isJetActive = False
            BtnDrugsJet.Image = My.Resources.Jet
            Statistics.APoints = Statistics.APoints - AddSubstractJetAP
            LblAPointsVal.ForeColor = Color.LimeGreen
            LblAPointsVal.Font = myFontNormal
        End If

        If isBuffoutActive = True Then
            isBuffoutActive = False
            BtnDrugsBuff.Image = My.Resources.Buffout
            Stats.Strenght = Stats.Strenght - AddSubstractBuffoutST
            Stats.Endurance = Stats.Endurance - AddSubstractBuffoutEN

            LblMDmgVal.ForeColor = Color.LimeGreen
            LblMDmgVal.Font = myFontNormal
            LblCWVal.ForeColor = Color.LimeGreen
            LblCWVal.Font = myFontNormal
            LblPoisonResVal.ForeColor = Color.LimeGreen
            LblPoisonResVal.Font = myFontNormal
            LblRadResVal.ForeColor = Color.LimeGreen
            LblRadResVal.Font = myFontNormal
            LblStatsENVal.ForeColor = Color.LimeGreen
            LblStatsSTVal.ForeColor = Color.LimeGreen

            'Radiation/Poison Resist Calc
            If isFastMeta = False Then
                Statistics.RadRes = 2 * Stats.Endurance
            Else
                Statistics.RadRes = 0
            End If

            If isFastMeta = False Then
                Statistics.PoisonRes = 5 * Stats.Endurance
            Else
                Statistics.PoisonRes = 0
            End If

            'CW

            If isSFrame = True Then
                If Stats.Strenght = 2 Then
                    Statistics.CarryWeight = 33 + (Perks.levelVal - 1) '<-- todo --> 33 base value + 1 * N° of lvl!!!
                ElseIf Stats.Strenght = 7 Then
                    Statistics.CarryWeight = 67 + (Perks.levelVal - 1)
                Else
                    Statistics.CarryWeight = Math.Round((20 + (Stats.Strenght * 15) / 2.2046226), 0) + (Perks.levelVal - 1)
                End If
            Else
                If Stats.Strenght = 8 Then
                    Statistics.CarryWeight = 110 + (Perks.levelVal - 1) '<-- todo --> 110 base value + 1 * N° of lvl!!!          
                Else
                    Statistics.CarryWeight = Math.Round((20 + (Stats.Strenght * 25) / 2.2046226), 0) + (Perks.levelVal - 1)
                End If
            End If

            'Melee Calc New
            Statistics.MeleeDmg = Stats.Strenght + (Statistics.addHHanded) + (Statistics.addBruiser) + (Statistics.addMutantMDmg)

        End If

        If isPsychoActive = True Then
            isPsychoActive = False
            BtnDrugsPsycho.Image = My.Resources.Psycho

            Stats.Perception = PEBeforePsycho
            Stats.Intelligence = INBeforePsycho

            Statistics.DmgRes = Statistics.DmgRes - AddSubstractPsychoDMGRes

            LblSightVal.ForeColor = Color.LimeGreen
            LblSightVal.Font = myFontNormal
            LblStatsPEVal.ForeColor = Color.LimeGreen
            LblStatsINVal.ForeColor = Color.LimeGreen
            LblDmgResVal.ForeColor = Color.LimeGreen
            LblDmgResVal.Font = myFontNormal
        End If

        If isCigsActive = True Then
            isCigsActive = False
            BtnDrugsCigs.Image = My.Resources.CigarettesNew
            Statistics.Sight = Statistics.Sight - AddSubstractCigsFoV
            LblSightVal.ForeColor = Color.LimeGreen
            LblSightVal.Font = myFontNormal
        End If

        If isNukaActive = True Then
            isNukaActive = False
            BtnDrugsNuka.Image = My.Resources.Nuka
            Statistics.APoints = Statistics.APoints - AddSubstractNukaAP
            LblAPointsVal.ForeColor = Color.LimeGreen
            LblAPointsVal.Font = myFontNormal
        End If

        Stats.SetStats()
        Statistics.SetStatistics()
    End Sub

    'Quests
    Friend AuswBeschr As String
    Friend chessavailable As Boolean

    Private Sub LstVQuests_Indexchange(ByVal sender As System.Object, ByVal e As EventArgs) Handles LstVQuests.ItemSelectionChanged
        Dim Quest As String
        Dim strItem As ListViewItem

        Quest = ""
        AuswBeschr = ""
        Stats.GetStats()
        Statistics.GetStatistics()
        Skills.getSkillValues()

        For Each strItem In LstVQuests.SelectedItems
            Quest = strItem.Text
            If Quest = "Chess Game" And chessavailable = False Then
            Else
                strItem.Remove()
            End If
            Exit For
        Next

        Select Case Quest

            Case "Chess Game"
                'a) +3 Crit Chance, b) +1 to Sight and +5%    Hit Chance, c) +10 HP & +4 Healing Rate."
                'AusChGame = ChessGame()
                If Not chessavailable = False Then
                    LstVChess.Visible = True
                    LstVQuests.Visible = False
                    LblQuests.Visible = False
                    LblChessRew.Visible = True
                    BtnQuests.Enabled = False
                    chessgametaken = True
                End If

            Case "Mary Ann - JT"
                If Not Stats.Charisma >= 10 Then
                    Stats.Charisma = Stats.Charisma + 1
                    LblStatsCHVal.Text = Stats.Charisma
                End If
            Case "Pete Quest - JT"
                If Not Skills.Repair >= 80 Then
                    Skills.Repair = Skills.Repair + 20
                    LblRepairVal.Text = Skills.Repair & "%"
                End If
        End Select

        'prevent Outofblah-exception
        If Not Quest = "" Then
            If Not Quest = "Chess Game" Then
                LstBoxPerks.Items.Add(Quest)
            End If
        End If

        SaveLoadQuests(Perks.levelVal, True, Quest)

        NUDSkillsMinValues()
    End Sub

    Private Sub LstVChess_Indexchange(ByVal sender As System.Object, ByVal e As EventArgs) Handles LstVChess.ItemSelectionChanged
        Dim strItem As ListViewItem
        Dim reward As String

        'Stats.GetStats()
        'Statistics.GetStatistics()
        'Skills.getSkillValues()

        reward = ""

        For Each strItem In LstVChess.SelectedItems
            reward = strItem.Text
            'strItem.Remove()
            Exit For
        Next

        Select Case reward
            Case "+3 to Crit Chance"
                Statistics.CritChance = Statistics.CritChance + 3
                LblCritChVal.Text = Statistics.CritChance
                AuswBeschr = "+3 CChance"

            Case "+1 to FOV, +5% HitChance"
                Statistics.Sight = Statistics.Sight + 1
                LblSightVal.Text = Statistics.Sight
                AuswBeschr = "+1 FOV, +5% HitC."

            Case "+10HP, +4 Healing Rate"
                Statistics.HealRate = Statistics.HealRate + 4
                LblHealRVal.Text = Statistics.HealRate
                Statistics.HitPoints = Statistics.HitPoints + 10
                LblHitPoints.Text = Statistics.HitPoints
                AuswBeschr = "+10HP, +4 HRate"
        End Select

        LstVChess.Visible = False
        LblChessRew.Visible = False
        LstVQuests.Visible = True
        LblQuests.Visible = True
        BtnQuests.Enabled = True

        If Not AuswBeschr = "" Then
            LstBoxPerks.Items.Add("Chess Game" & " - " & AuswBeschr)
            SaveLoadQuests(Perks.levelVal, True, "Chess Game" & " - " & AuswBeschr)
            'Exit Sub
        End If

    End Sub

    'old random chessreward function
    Function ChessGame() As String
        'Chess game isnt random, so function is obsolete
        Dim random As New Random
        Dim ZufZahl As Integer
        Dim Auswahl As String

        Auswahl = 0
        ZufZahl = random.Next(0, 2)

        Select Case ZufZahl
            Case 0
                Auswahl = "a"
            Case 1
                Auswahl = "b"
            Case 2
                Auswahl = "c"
        End Select

        Return Auswahl
    End Function

    'Achievements
    Private Sub LstVAchiev_Moushoover(ByVal sender As Object, _
    ByVal e As ListViewItemMouseHoverEventArgs) Handles LstVAchiev.ItemMouseHover
        Dim strItem As String
        Dim s As String
        Dim text As String
        Dim Lenght As Integer
        Dim restLenght As Integer
        Dim resName As String

        'Hoovered Perk Text
        strItem = e.Item.Text
        s = strItem.Substring(0, (Len(e.Item.Text)))

        For i = 0 To UBound(DetDescrName)
            If s = DetDescrName(i) Then
                Lenght = Len(DetDescrText(i))
                text = DetDescrText(i)

                LblDetDesc.Text = DetDescrName(i)

                If Lenght <= 45 Then

                    LblDetDescrText.Text = text

                ElseIf Lenght <= 90 Then
                    restLenght = Lenght - 45
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, restLenght)
                ElseIf Lenght <= 135 Then
                    restLenght = Lenght - 90
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                         & vbCrLf & text.Substring(90, restLenght)
                ElseIf Lenght <= 180 Then
                    restLenght = Lenght - 135
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                                            & vbCrLf & text.Substring(90, Lenght - (Lenght - 45)) & vbCrLf _
                                            & text.Substring(135, restLenght)
                End If
            End If
        Next

        'PicDescPic
        For i = 0 To UBound(DescPicIndex)
            If s = DetDescrName(i) Then
                resName = DescPicIndex(i)
                Try
                    Dim obj As Object = My.Resources.ResourceManager.GetObject(resName)
                    PicDesc.Image = obj
                Catch ex As Exception
                End Try
            End If
        Next

    End Sub

    'Quests Desc
    Private Sub LstVQuests_Moushoover(ByVal sender As Object, _
     ByVal e As ListViewItemMouseHoverEventArgs) Handles LstVQuests.ItemMouseHover
        Dim strItem As String
        Dim s As String
        Dim text As String
        Dim Lenght As Integer
        Dim restLenght As Integer
        Dim resName As String

        'Hoovered Perk Text
        strItem = e.Item.Text
        s = strItem.Substring(0, (Len(e.Item.Text)))

        If Stats.Intelligence <= 5 Then
            chessavailable = False
        Else
            chessavailable = True
        End If

        For i = 0 To UBound(DetDescrName)
            If s = DetDescrName(i) Then
                Lenght = Len(DetDescrText(i))
                text = DetDescrText(i)

                LblDetDesc.Text = DetDescrName(i)

                If Lenght <= 45 Then

                    LblDetDescrText.Text = text

                ElseIf Lenght <= 90 Then
                    restLenght = Lenght - 45
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, restLenght)
                ElseIf Lenght <= 135 Then
                    restLenght = Lenght - 90
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                         & vbCrLf & text.Substring(90, restLenght)
                ElseIf Lenght <= 180 Then
                    restLenght = Lenght - 135
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                                            & vbCrLf & text.Substring(90, Lenght - (Lenght - 45)) & vbCrLf _
                                            & text.Substring(135, restLenght)
                End If
            End If
        Next

        'PicDescPic
        For i = 0 To UBound(DescPicIndex)
            If s = DetDescrName(i) Then
                resName = DescPicIndex(i)
                Try
                    Dim obj As Object = My.Resources.ResourceManager.GetObject(resName)
                    PicDesc.Image = obj
                Catch ex As Exception
                End Try
            End If
        Next

    End Sub

    'Books
    Private Sub LstV1_Indexchange(ByVal sender As System.Object, ByVal e As EventArgs) Handles LstVBooks.SelectedIndexChanged
        Dim item As ListViewItem
        'Dim subitem As ListViewItem

        LblBookAmVal.Enabled = True
        BtnBookValDown.Enabled = True
        BtnBookValUp.Enabled = True
        BtnBookDone.Enabled = True

        For Each item In LstVBooks.Items
            If Not item.Selected Then
                item.ForeColor = Color.DarkGray
                item.SubItems(1).ForeColor = Color.DarkGray
            Else
                item.ForeColor = Color.Chartreuse
                item.SubItems(1).ForeColor = Color.Chartreuse
            End If
        Next
        'reset Amount of Books to choose for new selected Book
        LblBookAmVal.Text = 1
        'LstVBooks.SelectedItems(0).SubItems(1).Text = LstVBooks.SelectedItems(0).SubItems(1).Text - 1

    End Sub


    Dim BooksVal As Integer
    Dim FABookVal As Integer
    Dim RepairBVal As Integer
    Dim ScienceBVal As Integer
    Dim ODBVal As Integer
    Dim SGunBVal As Integer
    Dim BookAmount As Integer
    Dim BookAmountMax As Integer
    Friend SavedSPBooksTemp As Integer
    Friend savedSPbooksDiff As Integer
    Friend SavedSPBooksSmallG As Integer
    Friend SavedSPBooksFAid As Integer
    Friend SavedSPBooksScience As Integer
    Friend SavedSPBooksOD As Integer
    Friend SavedSPBooksRep As Integer

    'Initial calculation of Book Values
    Private Sub BooksCalc()
        'Dim BooksVal As Integer

        Stats.GetStats()

        BooksVal = Stats.Intelligence

        For i = 0 To CBoxBooks.Items.Count - 1
            CBoxBooks.Items(i) = CBoxBooks.Items(i) & " - " & BooksVal
        Next

        CBoxBooks.Enabled = True

        FABookVal = BooksVal
        RepairBVal = BooksVal
        ScienceBVal = BooksVal
        ODBVal = BooksVal
        SGunBVal = BooksVal

    End Sub

    'old Books Control --> set to invisible - can be deleted if not needed
    Private Sub CBoxBooks_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBoxBooks.SelectedIndexChanged
        Dim valueSK As Integer
        Dim s As String
        Dim BookTitle As String
        Dim newSPoints As Integer
        'Dim Skill As Control

        Stats.GetStats()
        Statistics.GetStatistics()
        Skills.getSkillValues()

        s = sender.text
        If Not BooksVal > 9 Then
            BookTitle = s.Substring(0, Len(sender.text) - 7)
        Else
            BookTitle = s.Substring(0, Len(sender.text) - 8)
        End If

        'Read in initial Skill-Value when choosing a book

        Select Case BookTitle
            Case "First Aid"
                If Not FABookVal = 0 Then
                    valueSK = Skills.FAid
                    FABookVal = FABookVal - 1
                    'calculate new value of the skill after reading the book
                    newSPoints = SPThroughBooksCalc(valueSK)
                    Skills.FAid = newSPoints
                    LblFaidVal.Text = newSPoints & "%"
                    'CBoxBooks.Items(0) = "First Aid B." & " - " & FABookVal
                End If
            Case "Outdoorsman"
                If Not ODBVal = 0 Then
                    valueSK = Skills.ODMan
                    ODBVal = ODBVal - 1
                    newSPoints = SPThroughBooksCalc(valueSK)
                    Skills.ODMan = newSPoints
                    LblODVal.Text = newSPoints & "%"
                End If
            Case "Repair"
                If Not RepairBVal = 0 Then
                    valueSK = Skills.Repair
                    RepairBVal = RepairBVal - 1
                    newSPoints = SPThroughBooksCalc(valueSK)
                    Skills.Repair = newSPoints
                    LblRepairVal.Text = newSPoints & "%"

                End If
            Case "Science"
                If Not ScienceBVal = 0 Then
                    valueSK = Skills.Science
                    ScienceBVal = ScienceBVal - 1
                    newSPoints = SPThroughBooksCalc(valueSK)
                    Skills.Science = newSPoints
                    LblScienceVal.Text = newSPoints & "%"
                End If
            Case "Small Guns"
                If Not SGunBVal = 0 Then
                    valueSK = Skills.SmallGuns
                    SGunBVal = SGunBVal - 1
                    newSPoints = SPThroughBooksCalc(valueSK)
                    Skills.SmallGuns = newSPoints
                    LblSGunsVal.Text = newSPoints & "%"
                End If
        End Select

        PanSkUpDown.Visible = False

        'refresh MinSkillValues
        NUDSkillsMinValues()


    End Sub

    'Calculation of SkillPoints you get by certain amount of books
    Function SPThroughBooksCalc(ByVal SPVal As Integer) As Integer
        Dim Diff As Integer
        Dim newSKVal As Integer
        '0% - 100% : 1% further costs 1 skill point
        '101% - 125% : 1% further costs 2 skill points
        '126% - 150% : 1% further costs 3 skill points
        '151% - 175% : 1% further costs 4 skill points
        '176% - 200% : 1% further costs 5 skill points
        '201% - 300% : 1% further costs 6 skill points

        'Seems as books ignore wether skills are tagged or not.

        Select Case SPVal
            Case 0 To 93
                newSKVal = SPVal + 8
                SavedSPBooksTemp = 0
            Case 94 To 101
                Diff = 101 - SPVal
                newSKVal = Math.Floor(SPVal + Diff + ((8 - Diff) / 2))
                SavedSPBooksTemp = (8 - Diff) Mod 2
            Case 102 To 122
                newSKVal = SPVal + 4
            Case 123 To 126
                If Not (126 - SPVal) = 0 Then
                    Diff = Math.Ceiling((126 - SPVal) / 2)
                Else
                    Diff = 0
                End If
                newSKVal = SPVal + Diff + Math.Floor(((8 - Diff) / 3))
                SavedSPBooksTemp = (8 - Diff) Mod 3
            Case 127 To 150
                newSKVal = SPVal + 2
                SavedSPBooksTemp = 2
            Case 151 To 174
                newSKVal = SPVal + 2
                SavedSPBooksTemp = 0
            Case 175 To 199
                newSKVal = SPVal + 1
                SavedSPBooksTemp = 3
            Case 200 To 299
                newSKVal = SPVal + 1
                SavedSPBooksTemp = 2
            Case 300
                newSKVal = SPVal

        End Select
        Return newSKVal
    End Function

    Function SavedSPBooksCalk(ByVal SavedSP As Integer, ByVal SkVal As Integer) As Integer

        Dim SPToAdd As Integer
        Dim Diff As Integer
        '0% - 100% : 1% further costs 1 skill point
        '101% - 125% : 1% further costs 2 skill points
        '126% - 150% : 1% further costs 3 skill points
        '151% - 175% : 1% further costs 4 skill points
        '176% - 200% : 1% further costs 5 skill points
        '201% - 300% : 1% further costs 6 skill points

        'Seems as books ignore wether skills are tagged or not.

        Select Case SkVal
            Case 0 To 125
                SPToAdd = 0
            Case 126 To 145
                SPToAdd = Math.Floor(SavedSP / 3)
                savedSPbooksDiff = SavedSP Mod 3
            Case 146 To 150
                'SavedSP - (Diff to 151% /3) + Diff/4
                Diff = SavedSP - ((151 - SkVal) * 3)
                'MessageBox.Show("Diff: " & Diff)
                SPToAdd = Math.Floor((SavedSP - Diff) / 3) + Math.Floor(Diff / 4)
                'MessageBox.Show("SPtoAdd: " & SPToAdd)
                savedSPbooksDiff = (SavedSP - Diff) Mod 3 + (Diff Mod 4)
            Case 151 To 175
                SPToAdd = Math.Floor(SavedSP / 4)
                savedSPbooksDiff = SavedSP Mod 4
            Case 176 To 200
                SPToAdd = Math.Floor(SavedSP / 5)
                savedSPbooksDiff = SavedSP Mod 5
            Case 201 To 299
                SPToAdd = Math.Floor(SavedSP / 6)
                savedSPbooksDiff = SavedSP Mod 6
                SPToAdd = 0
                savedSPbooksDiff = SavedSP
        End Select
        Return SPToAdd
    End Function

    'Close Form
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Books 
    Private Sub BtnBooks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBooks.Click
        PicDesc.Image = My.Resources.BooksDesc

        If isBookactive = True Then
            BtnBooks.ForeColor = Color.LightGray
            isBookactive = False
            isBookListVis = False
            LblPerks.Visible = True

            LblBooks.Visible = False
            LstVBooks.Visible = False
            PanBookValEdit.Visible = False

            BtnQuests.Enabled = True
            BtnAchievem.Enabled = True
            BtnImpl.Enabled = True

            BtnLvlUp.Enabled = True
            BtnLvlDwn.Enabled = True
            PanSkUpDown.Enabled = True
            LblBMentats.Visible = False

            BtnBooksAll.Visible = False

        Else
            BtnBooks.ForeColor = Color.SkyBlue
            isBookactive = True
            isBookListVis = True
            LblPerks.Visible = False
            LstVPerks.Visible = False
            LblBooks.Visible = True
            LstVBooks.Visible = True
            PanBookValEdit.Visible = True
            LblBookAmVal.Enabled = False
            BtnBookValDown.Enabled = False
            BtnBookValUp.Enabled = False
            BtnBookDone.Enabled = False

            BtnQuests.Enabled = False
            BtnAchievem.Enabled = False
            BtnImpl.Enabled = False

            BtnLvlUp.Enabled = False
            BtnLvlDwn.Enabled = False
            PanSkUpDown.Visible = False
            PanSkUpDown.Enabled = False

            LblBMentats.Visible = True

            'Read in BookAmountVal in LstView Books Sub Items
            LstVBooks.Items(0).SubItems(1).Text = FABookVal
            LstVBooks.Items(1).SubItems(1).Text = ODBVal
            LstVBooks.Items(2).SubItems(1).Text = RepairBVal
            LstVBooks.Items(3).SubItems(1).Text = ScienceBVal
            LstVBooks.Items(4).SubItems(1).Text = SGunBVal

            BtnBooksAll.Visible = True
        End If


    End Sub

    Private Sub BtnBookDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBookDone.Click
        Dim valueSK As Integer
        'Dim s As String
        Dim BookTitle As String
        Dim newSPoints As Integer
        'Dim Skill As Control

        Stats.GetStats()
        Statistics.GetStatistics()
        Skills.getSkillValues()

        BookTitle = LstVBooks.SelectedItems(0).Text
        BookAmount = LblBookAmVal.Text


        'Read in initial Skill-Value when choosing a book
        'Set new BookMax Amount 
        Select Case BookTitle
            Case "First Aid Book"
                If Not FABookVal = 0 Then
                    'if BookAmountMax is needed later on 
                    BookAmountMax = FABookVal
                    valueSK = Skills.FAid
                    'step 2
                    FABookVal = FABookVal - BookAmount

                    'FABookVal = (FABookVal + addBMentats) - BookAmount
                    'calculate new value of the skill after reading the book
                    For i = 1 To BookAmount
                        newSPoints = SPThroughBooksCalc(valueSK)
                        SavedSPBooksFAid = SavedSPBooksFAid + SavedSPBooksTemp
                        SavedSPBooksTemp = 0
                        Skills.FAid = newSPoints
                        valueSK = Skills.FAid
                    Next
                    If newSPoints + SavedSPBooksCalk(SavedSPBooksFAid, newSPoints) >= 300 Then
                        newSPoints = 300
                    Else
                        newSPoints = newSPoints + SavedSPBooksCalk(SavedSPBooksFAid, newSPoints)
                    End If
                    Skills.FAid = newSPoints
                    LblFaidVal.Text = newSPoints & "%"
                    SavedSPBooksFAid = savedSPbooksDiff
                End If

            Case "Outdoorsman Book"
                If Not ODBVal = 0 Then
                    BookAmountMax = ODBVal
                    valueSK = Skills.ODMan
                    ODBVal = ODBVal - BookAmount
                    For i = 1 To BookAmount
                        newSPoints = SPThroughBooksCalc(valueSK)
                        SavedSPBooksOD = SavedSPBooksOD + SavedSPBooksTemp
                        SavedSPBooksTemp = 0
                        Skills.ODMan = newSPoints
                        valueSK = Skills.ODMan
                    Next
                    'MessageBox.Show("SavedSPBooksOD: " & SavedSPBooksOD)
                    If newSPoints + SavedSPBooksCalk(SavedSPBooksOD, newSPoints) >= 300 Then
                        newSPoints = 300
                    Else
                        newSPoints = newSPoints + SavedSPBooksCalk(SavedSPBooksOD, newSPoints)
                    End If
                    'MessageBox.Show("SavedSPDiff: " & savedSPbooksDiff)
                    Skills.ODMan = newSPoints
                    LblODVal.Text = newSPoints & "%"
                    SavedSPBooksOD = savedSPbooksDiff
                    'MessageBox.Show("savedSPBooksOD neu: " & SavedSPBooksOD)
                End If
            Case "Repair Book"
                If Not RepairBVal = 0 Then
                    BookAmountMax = RepairBVal
                    valueSK = Skills.Repair
                    RepairBVal = RepairBVal - BookAmount
                    For i = 1 To BookAmount
                        newSPoints = SPThroughBooksCalc(valueSK)
                        SavedSPBooksRep = SavedSPBooksRep + SavedSPBooksTemp
                        SavedSPBooksTemp = 0
                        Skills.Repair = newSPoints
                        valueSK = Skills.Repair
                    Next
                    If newSPoints + SavedSPBooksCalk(SavedSPBooksRep, newSPoints) >= 300 Then
                        newSPoints = 300
                    Else
                        newSPoints = newSPoints + SavedSPBooksCalk(SavedSPBooksRep, newSPoints)
                    End If

                    Skills.Repair = newSPoints
                    LblRepairVal.Text = newSPoints & "%"
                    SavedSPBooksRep = savedSPbooksDiff

                End If
            Case "Science Book"
                If Not ScienceBVal = 0 Then
                    BookAmountMax = ScienceBVal
                    valueSK = Skills.Science
                    ScienceBVal = ScienceBVal - BookAmount
                    For i = 1 To BookAmount
                        newSPoints = SPThroughBooksCalc(valueSK)
                        SavedSPBooksScience = SavedSPBooksScience + SavedSPBooksTemp
                        SavedSPBooksTemp = 0
                        Skills.Science = newSPoints
                        valueSK = Skills.Science
                    Next
                    If newSPoints + SavedSPBooksCalk(SavedSPBooksScience, newSPoints) >= 300 Then
                        newSPoints = 300
                    Else
                        newSPoints = newSPoints + SavedSPBooksCalk(SavedSPBooksScience, newSPoints)
                    End If
                    Skills.Science = newSPoints
                    LblScienceVal.Text = newSPoints & "%"
                    SavedSPBooksScience = savedSPbooksDiff
                End If

            Case "Small Guns Book"
                If Not SGunBVal = 0 Then
                    BookAmountMax = SGunBVal
                    valueSK = Skills.SmallGuns
                    SGunBVal = SGunBVal - BookAmount
                    For i = 1 To BookAmount
                        newSPoints = SPThroughBooksCalc(valueSK)
                        SavedSPBooksSmallG = SavedSPBooksSmallG + SavedSPBooksTemp
                        SavedSPBooksTemp = 0
                        Skills.SmallGuns = newSPoints
                        valueSK = Skills.SmallGuns
                    Next
                    If newSPoints + SavedSPBooksCalk(SavedSPBooksSmallG, newSPoints) >= 300 Then
                        newSPoints = 300
                    Else
                        newSPoints = newSPoints + SavedSPBooksCalk(SavedSPBooksSmallG, newSPoints)
                    End If
                    Skills.SmallGuns = newSPoints
                    LblSGunsVal.Text = newSPoints & "%"
                    SavedSPBooksSmallG = savedSPbooksDiff
                End If
        End Select
        'STep 1

        LstVBooks.Items(0).SubItems(1).Text = FABookVal
        LstVBooks.Items(1).SubItems(1).Text = ODBVal
        LstVBooks.Items(2).SubItems(1).Text = RepairBVal
        LstVBooks.Items(3).SubItems(1).Text = ScienceBVal
        LstVBooks.Items(4).SubItems(1).Text = SGunBVal

        LblBookAmVal.Text = 1
        PanSkUpDown.Visible = False

        'refresh MinSkillValues
        NUDSkillsMinValues()
    End Sub

    Private Sub BtnBookValUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBookValUp.Click
        Dim BMaxAmount As Integer

        BMaxAmount = LstVBooks.SelectedItems(0).SubItems(1).Text

        If Not LblBookAmVal.Text >= BMaxAmount Then
            LblBookAmVal.Text = LblBookAmVal.Text + 1
        End If

    End Sub

    Private Sub BtnBookValDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBookValDown.Click
        Dim ActualBAmVal As Integer

        ActualBAmVal = LblBookAmVal.Text

        If Not ActualBAmVal <= 1 Then
            LblBookAmVal.Text = LblBookAmVal.Text - 1
        End If
    End Sub

    '************************************************
    '* Tracker Music - Player Feature Using BassMod *
    '************************************************

    Friend isPlay As Boolean
    Friend isSkip As Boolean
    Friend takenTracks(65) As Boolean
    Friend Zaehler As Integer
    Friend trackLenght As Long
    Friend startzeit As DateTime
    Friend Laenge As Integer
    Friend Volume As Integer


    'Start Music
    Private Sub MOnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOnToolStripMenuItem.Click
        'zufällige titelwiedergabe
        Dim RandomSong(65) As String
        Dim SongInfoText(65) As String
        Dim ZufZahl As Integer
        Dim random As New Random
        Dim s As String = "Music Title"
        'Dim isPlay As Boolean

        isPlay = True

        BtnMscStop.Visible = True
        BtnMscSkip.Visible = True
        BtnMusicVolDown.Visible = True
        BtnMusicVolUp.Visible = True
        PicBoxMusicVol.Visible = True

        TxtBMusicText.Visible = True
        LblMusicNPlay.Visible = True
        LblMusicTElap.Visible = True

        LblMusicLenghtMin.Visible = True
        LblMusicLenghtSec.Visible = True


        RandomSong(0) = "BREAKLINE"
        SongInfoText(0) = "Brkline - composed by: - mobi -"
        RandomSong(1) = "chris_glaister___lost_patrol_theme"
        SongInfoText(1) = "Lost Patrol Theme - composed by: Chris Glaister"
        RandomSong(2) = "Prestige3"
        SongInfoText(2) = "Prestige 3 - composed by: KIWI/EFFECT"
        RandomSong(3) = "Prestige4"
        SongInfoText(3) = "Prestige 4 - composed by: zarch/tfx + adc"
        RandomSong(4) = "anthrox"
        SongInfoText(4) = "Anthrox - composed by: aztech of anthrox"

        RandomSong(6) = "m1993"
        SongInfoText(6) = "1993 - composed by: u4ia of megawatts"
        RandomSong(7) = "aftertouch"
        SongInfoText(7) = "Aftertouch - composed by: substance/mono + kinky"
        RandomSong(8) = "m2000AD"
        SongInfoText(8) = "Multi-Tune_Dungeon - composed by: tuneless/2000 a.d."
        RandomSong(9) = "rastaman"
        SongInfoText(9) = "Rastaman - composed by: Firefox of Phenomen"
        RandomSong(10) = "chris_glaister___lost_patrol_theme"
        SongInfoText(10) = "Lost Patrol Theme - composed by: Chris Glaister"
        RandomSong(11) = "ctsewer"
        SongInfoText(11) = "Ctsewer"
        RandomSong(12) = "denaris_remix"
        SongInfoText(12) = "Denaris(rmx) - conversion by: John Stringer, comp. by: Chris Huelsbeck"
        RandomSong(13) = "feather"
        SongInfoText(13) = "..Feathers Fell.. - composed by: DARKSOUL"
        RandomSong(14) = "lastnin1"
        SongInfoText(14) = "Last Ninja Theme - composed by: Mad-Mega"
        RandomSong(15) = "castlevania_1"
        SongInfoText(15) = "Castlevania Theme - composed by: natan1/superstars/maktone + class"
        RandomSong(16) = "DREAMWEB2"
        SongInfoText(16) = "DreamWeb Theme 2 - composed by: ripped by The BEEJ"
        RandomSong(17) = "lastnin1"
        SongInfoText(17) = "Last Ninja Theme - composed by: Mad-Mega"
        RandomSong(5) = "DREAMWEB6"
        SongInfoText(5) = "DreamWeb Theme 6 - composed by: unknown, ripped by The BEEJ"
        RandomSong(18) = "age_of_loneliness"
        SongInfoText(18) = "Age of Loneliness - composed by: T-Reks\wp"
        RandomSong(19) = "dreamweb_ingame"
        SongInfoText(19) = "DreamWeb Theme Ingame - composed by: unknown, ripped by The BEEJ"
        RandomSong(20) = "dreamweb4"
        SongInfoText(20) = "DreamWeb Theme 4 - composed by: unknown, ripped by The BEEJ"
        RandomSong(21) = "Millenium1"
        SongInfoText(21) = "Millenium #3 - composed by: millenium"
        RandomSong(22) = "Anthrox9"
        SongInfoText(22) = "Quartex 2 - composed by: ref lex"
        RandomSong(23) = "Crash2"
        SongInfoText(23) = "(c)hip 2 - composed by: stargazer"
        RandomSong(24) = "Defjam3"
        SongInfoText(24) = "The Last Kuusnepa- composed by: wal of punishers"
        RandomSong(25) = "Delight7"
        SongInfoText(25) = "Jack The Ripper 1.0 - composed by: Mr.Urk of SHINING"
        RandomSong(26) = "Supplex1"
        SongInfoText(26) = "For srow'n'supplex  - composed by: wotw of Supplex"
        RandomSong(27) = "Joy_and_Magnificent_Force2"
        SongInfoText(27) = "Rb2 - composed by: unknown"
        RandomSong(28) = "Estrayk___The_HER_song_10"
        SongInfoText(28) = "Her 10 - composed by: Estrayk of Paradox"
        RandomSong(29) = "Tempest___Acidjazzed_evening"
        SongInfoText(29) = "Acidjazzed Evening - composed by: tempest/dmg"
        RandomSong(30) = "TRSI_and_Zenith2"
        SongInfoText(30) = "Digital Bass-Line - composed by: emax\trsi"
        RandomSong(31) = "Jakim___Whatever_it_means"
        SongInfoText(31) = "Whatever It Means - composed by: Jakim/Stage Magician"
        RandomSong(32) = "Wave___1999"
        SongInfoText(32) = "1999 - composed by: Wave"
        RandomSong(33) = "Dubmood___3D_galaxy"
        SongInfoText(33) = "3D Galaxy - composed by: dubmood\Razor1911"
        RandomSong(34) = "Joule_and_Coda___Going_nuts"
        SongInfoText(34) = "G0ing Nuts - composed by: j0yl/c0da"
        RandomSong(35) = "Key_G___Red_green_blue_5"
        SongInfoText(35) = "Red Green Blue 5 - composed by: keyG"
        RandomSong(36) = "Cascade4"
        SongInfoText(36) = "Falling - composed by: skimmer"
        RandomSong(37) = "Cave8"
        SongInfoText(37) = "Trip To Space - composed by: unknown"
        RandomSong(38) = "Accession1"
        SongInfoText(38) = "Accession 1 - composed by: KTWT\EFFECT"
        RandomSong(39) = "Slash___Because"
        SongInfoText(39) = "Because - composed by: Slash"
        RandomSong(40) = "Classic3"
        SongInfoText(40) = "Introkiller - composed by: deszecrator"
        RandomSong(41) = "turrican2ingame1rmx"
        SongInfoText(41) = "Turrican 2.1 - composed by: elef/tsiroudis"
        RandomSong(42) = "turrican2titlermx"
        SongInfoText(42) = "Turrican II - composed by: elef/tsiroudis"
        RandomSong(43) = "Wiklund___Bonfire"
        SongInfoText(43) = "Bonfire - composed by: Wiklund"
        RandomSong(44) = "her1"
        SongInfoText(44) = "Her Numbness - composed by: Estrayk of Paradox"
        RandomSong(45) = "her2"
        SongInfoText(45) = "Her Numbness 2 - composed by: Estrayk of Paradox"
        RandomSong(46) = "her3"
        SongInfoText(46) = "Her Numbness 3 - composed by: Estrayk of Paradox"
        RandomSong(47) = "WCD1"
        SongInfoText(47) = "Bidzej - composed by: poolbet/ww"
        RandomSong(48) = "her5"
        SongInfoText(48) = "Her Numbness 5 - composed by: Estrayk of Paradox"
        RandomSong(49) = "her6"
        SongInfoText(49) = "Her Numbness 6 - composed by: Estrayk of Paradox"
        RandomSong(50) = "her7"
        SongInfoText(50) = "Her Numbness 7 - composed by: Estrayk of Paradox"
        RandomSong(51) = "her8"
        SongInfoText(51) = "Her Numbness 8 - composed by: Estrayk of Paradox"
        RandomSong(52) = "her9"
        SongInfoText(52) = "Her Numbness 9 - composed by: Estrayk of Paradox"
        RandomSong(53) = "her10"
        SongInfoText(53) = "Her Numbness 10 - composed by: Estrayk of Paradox"
        RandomSong(54) = "WCD1"
        SongInfoText(54) = "Bidzej - composed by: mokasyn\ww"
        RandomSong(55) = "her7"
        SongInfoText(55) = "Her Numbness 7 - composed by: Estrayk of Paradox"
        RandomSong(56) = "Cave8"
        SongInfoText(56) = "Trip To Space - composed by: unknown"
        RandomSong(57) = "ATOMIC"
        SongInfoText(57) = "Atom Henge - composed by: @r@k()s@"
        RandomSong(58) = "DESIRATA"
        SongInfoText(58) = "Desirata - composed by: stargazer of sonic"
        RandomSong(59) = "ERTERTER"
        SongInfoText(59) = "Ertertertertrtyrtyr - composed by: unknown"
        RandomSong(60) = "FACTORY"
        SongInfoText(60) = "Factory Theme - composed by: jason/s i l e n t s"
        RandomSong(61) = "FUCKFUCK"
        SongInfoText(61) = "Fuckfuckfuckfuck - destroyed by: mf"
        RandomSong(62) = "LOST"
        SongInfoText(62) = "Lost Scrotum - composed by: paso/dynamix"
        RandomSong(63) = "MUSIC"
        SongInfoText(63) = "Music - composed by: nuke/cosmos"
        RandomSong(64) = "PACKCHP1"
        SongInfoText(64) = "Packchip 1 - composed by: unknown"
        RandomSong(65) = "SECRET"
        SongInfoText(65) = "Secret Gardens - composed by: emax/trsi"
        RandomSong(65) = "SNORWALK"
        SongInfoText(65) = "Snorwalk - composed by: deelite/enigma"



        While Zaehler < 64
            ZufZahl = random.Next(0, 65)

            'If ZufZahl was taken before while loop continues to pick next
            'If Not then ZufZahl is valid, counter is increased by 1 and Loop is terminated
            If Not takenTracks(ZufZahl) = True Then
                takenTracks(ZufZahl) = True
                Zaehler = Zaehler + 1
                s = SongInfoText(ZufZahl)
                'If all tracks were played once set all takenTracks values to false
                'Songs will be played again
                If Zaehler = 64 Then
                    Zaehler = 0
                    For i = 1 To 65
                        takenTracks(i) = False
                    Next
                End If

                Exit While
            End If

        End While

        'Plays a random title from the ressources (see list above)
        Dim obj As Object = My.Resources.ResourceManager.GetObject(RandomSong(ZufZahl))

        BassMOD.BASSMOD_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT)
        'BassMOD.BASSMOD_MusicLoad(My.Resources.chris_glaister___lost_patrol_theme, 0, 0, BASSMusic.BASS_MUSIC_LOOP)
        BassMOD.BASSMOD_MusicLoad(obj, 0, 0, BASSMusic.BASS_MUSIC_CALCLE)
        'Get actual time (in clicks)
        startzeit = Now
        'Start Music Play
        BassMOD.BASSMOD_MusicPlay()
        BassMOD.BASSMOD_SetVolume(20)

        'Get lenght of track in weird format
        trackLenght = BassMOD.BASSMOD_MusicGetLength(True)
        'Start Timer for Countdown
        tracklenghtTimer.Enabled = True
        'Calculation to approximitly get lenght of track in ms
        Laenge = Math.Floor(trackLenght / 176000)

        'Timespan of actual track lenght converted in mm:ss
        Dim Zeit As New TimeSpan(0, 0, Laenge)

        If Zeit.Seconds < 10 Then
            LblMusicLenghtSec.Text = "0" & Zeit.Seconds
        Else
            LblMusicLenghtSec.Text = Zeit.Seconds
        End If

        LblMusicLenghtMin.Text = Zeit.Minutes & ":"

        MOnToolStripMenuItem.Enabled = False
        MOffToolStripMenuItem.Enabled = True
        NextToolStripMenuItem.Enabled = True

        While TextRenderer.MeasureText(s, TxtBMusicText.Font).Width < TxtBMusicText.Width
            s &= " "
        End While
        s = s.Substring(0, s.Length - 1)
        TxtBMusicText.Text = s
        TxtBMusicText.ReadOnly = True
        t.Enabled = True

    End Sub

    'Eventhandler for moving text
    Private WithEvents t As New System.Windows.Forms.Timer With {.Enabled = False, .Interval = 120}

    Private Sub t_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles t.Tick
        Dim s As String = TxtBMusicText.Text
        Dim c As Char = s(s.Length - 1)
        TxtBMusicText.Text = c.ToString & s.Substring(0, s.Length - 1)
    End Sub

    'Timer for track lenght
    'Note: It actually doesn't read the exact time of the track lenght
    Private WithEvents tracklenghtTimer As New System.Windows.Forms.Timer With {.Enabled = False, .Interval = 1000}

    Private Sub tracklenghtTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tracklenghtTimer.Tick
        'If Not Val(LblMusicLenghtSec.Text) = 0 And Not Val(LblMusicLenghtMin.Text) = 0 Then
        'End If
        'LblMusicLenghtSec.Text = Val(LblMusicLenghtSec.Text) - 1
        'If Val(LblMusicLenghtSec.Text) = 0 And Not Val(LblMusicLenghtMin.Text) = 0 Then
        'LblMusicLenghtMin.Text = Val(LblMusicLenghtMin.Text) - 1
        'End If

        Dim elapsedTimeSec = TimeSpan.FromTicks(Now.Ticks - startzeit.Ticks).Seconds
        Dim elapsedTimeMin = TimeSpan.FromTicks(Now.Ticks - startzeit.Ticks).Minutes
        Dim diffTime As New TimeSpan(0, 0, Laenge - elapsedTimeSec - (elapsedTimeMin * 60))

        'elapsedTime = elapsedTime + 1

        If Laenge - elapsedTimeSec - (elapsedTimeMin * 60) <= 0 Then
            tracklenghtTimer.Enabled = False
            tracklenghtTimer.Stop()
            LblMusicLenghtSec.Text = "00"
        Else
            If diffTime.Seconds < 10 Then
                LblMusicLenghtSec.Text = "0" & diffTime.Seconds
            Else
                LblMusicLenghtSec.Text = diffTime.Seconds
            End If


            LblMusicLenghtMin.Text = diffTime.Minutes & ":"
        End If


    End Sub

    'Stop Music
    Private Sub MOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOffToolStripMenuItem.Click

        BassMOD.BASSMOD_MusicStop()
        BassMOD.BASSMOD_Free()
        isPlay = False
        BtnMscPlay.Visible = False
        BtnMscSkip.Visible = False
        BtnMscStop.Visible = False
        BtnMusicVolDown.Visible = False
        BtnMusicVolUp.Visible = False
        PicBoxMusicVol.Visible = False

        TxtBMusicText.Visible = False
        LblMusicLenghtMin.Visible = False
        LblMusicLenghtSec.Visible = False
        LblMusicNPlay.Visible = False
        LblMusicTElap.Visible = False



        MOnToolStripMenuItem.Enabled = True
        MOffToolStripMenuItem.Enabled = False
        NextToolStripMenuItem.Enabled = False

    End Sub

    'click Play Btn
    Private Sub BtnMscPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMscPlay.Click
        isPlay = True

        BtnMscStop.Visible = True
        BtnMscSkip.Visible = True
        TxtBMusicText.Visible = True

        MOnToolStripMenuItem_Click(sender, e)
    End Sub

    'prevent IBeam Cursor to be shown in TextBox where floating Music-Title-Text is shown
    <DllImport("user32")>
    Private Shared Function HideCaret(ByVal hWnd As IntPtr) As Integer
    End Function
    <DllImport("user32")>
    Private Shared Function ShowCaret(ByVal hWnd As IntPtr) As Integer
    End Function
    Private Sub Textbox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBMusicText.GotFocus
        If Me.TxtBMusicText.ReadOnly Then
            HideCaret(TxtBMusicText.Handle)
        Else
            ShowCaret(TxtBMusicText.Handle)
        End If
    End Sub

    'click stop btn
    Private Sub BtnMscStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMscStop.Click
        isPlay = False

        BtnMscPlay.Visible = True
        BtnMscStop.Visible = False
        BtnMscSkip.Visible = False
        BtnMusicVolDown.Visible = False
        BtnMusicVolUp.Visible = False
        PicBoxMusicVol.Visible = False

        TxtBMusicText.Visible = False
        LblMusicNPlay.Visible = False
        LblMusicTElap.Visible = False

        LblMusicLenghtMin.Visible = False
        LblMusicLenghtSec.Visible = False


        BassMOD.BASSMOD_MusicStop()
        BassMOD.BASSMOD_Free()
    End Sub

    'Restart App
    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click

        Try

            Application.Exit()
            Application.ExitThread()
            Application.Restart()

            'Windows.Forms.Application.DoEvents()
            'Threading.Thread.Sleep(1000)
            'Application.Restart()
            'Application.Exit()
            'End

            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Normal
            End If
        Catch ex As Exception
            Dim writer As New StreamWriter(My.Application.Info.DirectoryPath & "\datlog.txt", True, System.Text.Encoding.ASCII)
            writer.WriteLine(ex.Message)
            writer.Close()
        End Try

    End Sub

    'Next Music Title
    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click, BtnMscSkip.Click
        isPlay = True
        BassMOD.BASSMOD_MusicStop()
        BassMOD.BASSMOD_Free()
        MOnToolStripMenuItem.Enabled = False
        MOnToolStripMenuItem_Click(sender, e)
        MOffToolStripMenuItem.Enabled = True
        BassMOD.BASSMOD_SetVolume(Volume)

        Select Case Volume
            Case 0
                PicBoxMusicVol.BackgroundImage = My.Resources.VolumeMute
            Case 20

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume0
            Case 40

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume25
            Case 60

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume50
            Case 80

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume75
            Case 100

                PicBoxMusicVol.BackgroundImage = My.Resources.VolumeFull
        End Select
    End Sub


    'Volume
    Private Sub BtnMusicVolDown_Click(sender As System.Object, e As System.EventArgs) Handles BtnMusicVolDown.Click
        Dim Vol As Integer

        Vol = BassMOD.BASSMOD_GetVolume

        If Not Vol <= 0 Then
            Vol = Vol - 20
        End If
        BassMOD.BASSMOD_SetVolume(Vol)

        'Me.SuspendLayout()
        Select Case Vol
            Case 0

                PicBoxMusicVol.BackgroundImage = My.Resources.VolumeMute
            Case 20

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume0
            Case 40

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume25
            Case 60

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume50
            Case 80

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume75
            Case 100

                PicBoxMusicVol.BackgroundImage = My.Resources.VolumeFull
        End Select

        Volume = Vol
        'Me.ResumeLayout()
    End Sub

    Private Sub BtnMusicVolUp_Click(sender As System.Object, e As System.EventArgs) Handles BtnMusicVolUp.Click
        Dim Vol As Integer

        Vol = BassMOD.BASSMOD_GetVolume

        If Not Vol >= 100 Then
            Vol = Vol + 20
        End If
        BassMOD.BASSMOD_SetVolume(Vol)

        'Me.SuspendLayout()
        Select Case Vol
            Case 0
                PicBoxMusicVol.BackgroundImage = My.Resources.VolumeMute
            Case 20

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume0
            Case 40

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume25
            Case 60

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume50
            Case 80

                PicBoxMusicVol.BackgroundImage = My.Resources.Volume75
            Case 100

                PicBoxMusicVol.BackgroundImage = My.Resources.VolumeFull
        End Select

        Volume = Vol
        'Me.ResumeLayout()
    End Sub


    'Credits/Info
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        PicDesc.Show()
        LblDetDesc.Hide()
        LblDetDescrText.Hide()
        PanNormDesc.BackColor = Color.ForestGreen
        PanDetDesc.BackColor = Color.Brown
        PicDesc.Image = My.Resources.Creditsneu_v1_5
    End Sub

    'addMentats Effekt for reading Books -> 2 more Books readable
    Private Sub LblBMentats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBMentats.Click
        isBookMentats = True
        Dim addMentatsAmount As Integer

        Stats.GetStats()
        'todo --> amount can't be raised over 10!!! --> IN9 means max of 10 books with mentats
        'IN10 = 10 max <-- done test pending
        If Stats.Intelligence <= 8 Then
            addMentatsAmount = 2
        ElseIf Stats.Intelligence = 9 Then
            addMentatsAmount = 1
        ElseIf Stats.Intelligence = 10 Then
            addMentatsAmount = 0
        Else
            addMentatsAmount = 0
        End If
        LstVBooks.Items(0).SubItems(1).Text = LstVBooks.Items(0).SubItems(1).Text + addMentatsAmount
        LstVBooks.Items(1).SubItems(1).Text = LstVBooks.Items(1).SubItems(1).Text + addMentatsAmount
        LstVBooks.Items(2).SubItems(1).Text = LstVBooks.Items(2).SubItems(1).Text + addMentatsAmount
        LstVBooks.Items(3).SubItems(1).Text = LstVBooks.Items(3).SubItems(1).Text + addMentatsAmount
        LstVBooks.Items(4).SubItems(1).Text = LstVBooks.Items(4).SubItems(1).Text + addMentatsAmount

        FABookVal = FABookVal + addMentatsAmount
        ODBVal = ODBVal + addMentatsAmount
        ScienceBVal = ScienceBVal + addMentatsAmount
        RepairBVal = RepairBVal + addMentatsAmount
        SGunBVal = SGunBVal + addMentatsAmount

        LblBMentats.Enabled = False
    End Sub

    'Some graphical things with labels
    Private Sub LblBMentats_MouseOver(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBMentats.MouseEnter
        LblBMentats.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub LblBMentats_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBMentats.MouseLeave
        LblBMentats.ForeColor = Color.LightSalmon
    End Sub

    Private Sub PanNormDesc_MEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanNormDesc.MouseEnter, LblGenDescr.MouseEnter
        LblGenDescr.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PanNormDesc_MLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanNormDesc.MouseLeave, LblGenDescr.MouseLeave
        LblGenDescr.ForeColor = Color.LightCyan
    End Sub

    Private Sub PanDetDesc_MEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanDetDesc.MouseEnter, LblDetailedDesc.MouseEnter
        LblDetailedDesc.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub PanDetDesc_MLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanDetDesc.MouseLeave, LblDetailedDesc.MouseLeave
        LblDetailedDesc.ForeColor = Color.LightCyan
    End Sub

    'Button Implants
    Friend isEnhancedRemoved As Boolean
    Private Sub BtnImpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpl.Click
        Dim Level As Integer
        Level = CInt(LblLevelVal.Text)

        If isImplantActive = True Then
            BtnImpl.ForeColor = Color.LightGray
            BtnBooks.Enabled = True
            BtnQuests.Enabled = True
            BtnAchievem.Enabled = True

            isImplantActive = False
            LstVImpl.Visible = False
            LblImpl.Visible = False
            LblPerks.Visible = True
            PanSkUpDown.Enabled = True
            'PanSkUpDown.Visible = True
            BtnLvlDwn.Enabled = True
            BtnLvlUp.Enabled = True

            Level = CInt(LblLevelVal.Text)
            Label3.Text = Level


        Else
            BtnImpl.ForeColor = Color.SkyBlue
            isImplantActive = True
            BtnBooks.Enabled = False
            BtnQuests.Enabled = False
            BtnAchievem.Enabled = False
            LstVImpl.Visible = True
            LblImpl.Visible = True
            LblPerks.Visible = False
            PanSkUpDown.Enabled = False
            PanSkUpDown.Visible = False
            BtnLvlDwn.Enabled = False
            BtnLvlUp.Enabled = False

            Level = CInt(LblLevelVal.Text)
            'Label3.Text = Level


            If Level < 3 Then
                For Each ctl As ListViewItem In LstVImpl.Items
                    If ctl.Text = "Enhancement Implant" Then
                        ctl.Remove()
                        isEnhancedRemoved = True
                        Exit For
                    End If
                Next
            End If

            If Level >= 3 Then
                If isEnhancedRemoved = True Then
                    LstVImpl.Items.Insert(LstVImpl.Items.Count, "Enhancement Implant")
                    isEnhancedRemoved = False
                End If
            End If


        End If
    End Sub

    'For Impl Descriptions
    Private Sub LstVImpl_Moushoover(ByVal sender As Object, _
      ByVal e As ListViewItemMouseHoverEventArgs) Handles LstVImpl.ItemMouseHover
        Dim strItem As String
        Dim s As String
        Dim text As String
        Dim Lenght As Integer
        Dim restLenght As Integer
        Dim resName As String

        'Hoovered Perk Text
        strItem = e.Item.Text
        s = strItem.Substring(0, (Len(e.Item.Text)))

        For i = 0 To UBound(DetDescrName)
            If s = DetDescrName(i) Then
                Lenght = Len(DetDescrText(i))
                text = DetDescrText(i)

                LblDetDesc.Text = DetDescrName(i)

                If Lenght <= 45 Then

                    LblDetDescrText.Text = DetDescrText(i)

                ElseIf Lenght <= 90 Then
                    restLenght = Lenght - 45
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, restLenght)
                ElseIf Lenght <= 135 Then
                    restLenght = Lenght - 90
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                         & vbCrLf & text.Substring(90, restLenght)
                ElseIf Lenght <= 180 Then
                    restLenght = Lenght - 135
                    LblDetDescrText.Text = text.Substring(0, Lenght - (Lenght - 45)) & vbCrLf & text.Substring(45, Lenght - (Lenght - 45)) _
                                            & vbCrLf & text.Substring(135, Lenght - (Lenght - 90)) & vbCrLf _
                                            & text.Substring(180, restLenght)
                End If

                'LblDetDescrText.Text = DetDescrText(i)

            End If
        Next

        'PicDescPic
        For i = 0 To UBound(DescPicIndex)
            If s = DetDescrName(i) Then
                resName = DescPicIndex(i)
                Try
                    Dim obj As Object = My.Resources.ResourceManager.GetObject(resName)
                    PicDesc.Image = obj
                Catch ex As Exception
                End Try
            End If
        Next

    End Sub

    'Implant choice
    Dim isImplChoosen As Boolean
    Dim ImplantName As String
    Dim isSaveEnhanceImplPerk As Boolean
    Friend isEnhanceImpl As Boolean
    Private Sub LstVImpl_IndexChange(ByVal sender As System.Object, ByVal e As EventArgs) Handles LstVImpl.SelectedIndexChanged
        Dim s As String
        Dim item As ListViewItem
        'Dim skillVal As Integer

        Stats.GetStats()
        Statistics.GetStatistics()
        Skills.getSkillValues()
        If Not isImplChoosen = True Then
            isImplChoosen = True

            s = LstVImpl.SelectedItems(0).Text

            'Implant Name is saved for later use when restoring levels
            ImplantName = s
            LstBoxPerks.Items.Add(s)

            Select Case s
                Case "Accuracy Implant"
                    Statistics.Sight = Statistics.Sight + 5

                    If Skills.BigGuns + 40 >= 300 Then
                        Skills.BigGuns = 300
                        LblBGunsVal.Text = 300 & "%"
                    Else
                        Skills.BigGuns = Skills.BigGuns + 40
                        LblBGunsVal.Text = Skills.BigGuns & "%"
                    End If

                    If Skills.SmallGuns + 40 >= 300 Then
                        Skills.SmallGuns = 300
                        LblSGunsVal.Text = 300 & "%"
                    Else
                        Skills.SmallGuns = Skills.SmallGuns + 40
                        LblSGunsVal.Text = Skills.SmallGuns & "%"
                    End If

                    If Skills.EWeapons + 40 >= 300 Then
                        Skills.EWeapons = 300
                        LblEWeaponsVal.Text = 300 & "%"
                    Else
                        Skills.EWeapons = Skills.EWeapons + 40
                        LblEWeaponsVal.Text = Skills.EWeapons & "%"
                    End If

                Case "Chem Control Implant"
                    'doesnt change any visible values
                Case "Defense Implant"
                    Statistics.DmgRes = Statistics.DmgRes + 4
                Case "Enviromental Implant"
                    Statistics.HealRate = Statistics.HealRate + 10
                    If Statistics.PoisonRes + 40 >= 95 Then
                        Statistics.PoisonRes = 95
                    Else
                        Statistics.PoisonRes = Statistics.PoisonRes + 40
                    End If

                    If Statistics.RadRes + 50 >= 95 Then
                        Statistics.RadRes = 95
                    Else
                        Statistics.RadRes = Statistics.RadRes + 50
                    End If


                Case "Engineering Implant"
                    If Skills.Repair + 100 >= 300 Then
                        Skills.Repair = 300
                        LblRepairVal.Text = 300 & "%"
                    Else
                        Skills.Repair = Skills.Repair + 100
                        LblRepairVal.Text = Skills.Repair & "%"
                    End If

                    If Skills.Science + 100 >= 300 Then
                        Skills.Science = 300
                        LblScienceVal.Text = 300 & "%"
                    Else
                        Skills.Science = Skills.Science + 100
                        LblScienceVal.Text = Skills.Science & "%"
                    End If

                    If Skills.EWeapons + 100 >= 300 Then
                        Skills.EWeapons = 300
                        LblEWeaponsVal.Text = 300 & "%"
                    Else
                        Skills.EWeapons = Skills.EWeapons + 100
                        LblEWeaponsVal.Text = Skills.EWeapons & "%"
                    End If


                Case "Enhancement Implant"
                    'todo --> check if perk choosement isnt affected at all by doing this
                    'if taken at low level no perks can be choosen --> somehow do check to check if list is empty to go on
                    BtnLvlDwn.Enabled = False
                    BtnLvlUp.Enabled = False
                    isEnhanceImpl = True
                    isSaveEnhanceImplPerk = True
                    BtnImpl.Enabled = False
                    LblImpl.Visible = False

                    LblPerks.Visible = True
                    LstVImpl.Visible = False
                    LstVPerks.Visible = True
                    BtnPerkLater.Visible = False
                    Perks.availablePerks()

                Case "Marksmanship Implant"
                    Statistics.Sight = Statistics.Sight + 2
                    Statistics.CritChance = Statistics.CritChance + 4
                Case "Medical Implant"
                    If Skills.Doctor + 50 >= 300 Then
                        Skills.Doctor = 300
                        LblDocVal.Text = 300 & "%"
                    Else
                        Skills.Doctor = Skills.Doctor + 50
                        LblDocVal.Text = Skills.Doctor & "%"
                    End If

                    If Skills.FAid + 50 >= 300 Then
                        Skills.FAid = 300
                        LblFaidVal.Text = 300 & "%"
                    Else
                        Skills.FAid = Skills.FAid + 50
                        LblFaidVal.Text = Skills.FAid & "%"
                    End If

                    LstBoxPerks.Items.Add("Living Anatomy (by Implant)")

                Case "Scouting Implant"
                    If Skills.Sneak + 50 >= 320 Then
                        Skills.Sneak = 320
                        LblSneakVal.Text = 320 & "%"
                        LblSneakVal.ForeColor = Color.Tomato
                    Else
                        Skills.Sneak = Skills.Sneak + 50
                        LblSneakVal.Text = Skills.Sneak & "%"
                    End If

                    Statistics.AClass = Statistics.AClass + 30
                Case "Speed Implant"
                    Statistics.APoints = Statistics.APoints + 1
                    Statistics.Sequence = Statistics.Sequence + 6
                Case "Survival Implant"
                    Statistics.HitPoints = Statistics.HitPoints + 30
                    If Skills.ODMan + 100 >= 300 Then
                        Skills.ODMan = 300
                        LblODVal.Text = 300 & "%"
                    Else
                        Skills.ODMan = Skills.ODMan + 100
                        LblODVal.Text = Skills.ODMan & "%"
                    End If
            End Select

            Stats.SetStats()
            Statistics.SetStatistics()
            SaveImplants(Perks.levelVal, ImplantName)

            For Each item In LstVImpl.Items
                item.Remove()
            Next

        End If
        Stats.SetStats()
        Statistics.SetStatistics()

        'Label1.Text = Statistics.Sight
        'refresh MinSkillValues
        NUDSkillsMinValues()

        BtnImpl.ForeColor = Color.LightGray
        BtnBooks.Enabled = True
        BtnQuests.Enabled = True
        BtnAchievem.Enabled = True

        isImplantActive = False
        LstVImpl.Visible = False
        LblImpl.Visible = False
        LblPerks.Visible = True
        PanSkUpDown.Enabled = True
        'PanSkUpDown.Visible = True

        If isEnhanceImpl = False Then
            BtnLvlDwn.Enabled = True
            BtnLvlUp.Enabled = True
        End If



    End Sub

    'ListBPerks Description Updates
    Private Sub LstBPerks_IndChange(ByVal sender As System.Object, ByVal e As EventArgs) Handles LstBoxPerks.SelectedIndexChanged
        Dim strItem As String
        Dim resName As String
        'Dim s As String

        strItem = sender.text
        Debug.Print("Perkdesc: " & strItem)
        If InStr(strItem, "(2)") Or InStr(strItem, "(3)") Then
            strItem = strItem.Substring(0, (Len(strItem) - 4))
        End If

        For i = 0 To UBound(DetDescrName)

            If strItem = DetDescrName(i) Then
                DetDescrChange(i, i)
            End If
        Next

        For i = 0 To UBound(DescPicIndex)
            If strItem = DetDescrName(i) Then
                resName = DescPicIndex(i)
                Try
                    Dim obj As Object = My.Resources.ResourceManager.GetObject(resName)
                    PicDesc.Image = obj
                Catch ex As Exception
                End Try
            End If
        Next

    End Sub

    'Button Quests
    Friend chessgametaken As Boolean
    Private Sub BtnQuests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuests.Click
        Dim chessGAlreadyThere As Boolean

        Stats.GetStats()
        If isQuestsActive = True Then
            BtnQuests.ForeColor = Color.LightGray
            BtnBooks.Enabled = True
            BtnImpl.Enabled = True
            BtnAchievem.Enabled = True
            isQuestsActive = False
            LstVQuests.Visible = False
            LblQuests.Visible = False
            LblPerks.Visible = True
            PanSkUpDown.Enabled = True
            'PanSkUpDown.Visible = True
            BtnLvlDwn.Enabled = True
            BtnLvlUp.Enabled = True

        Else
            BtnQuests.ForeColor = Color.SkyBlue
            isQuestsActive = True
            BtnBooks.Enabled = False
            BtnImpl.Enabled = False
            BtnAchievem.Enabled = False
            LstVQuests.Visible = True
            LblQuests.Visible = True
            LblPerks.Visible = False
            PanSkUpDown.Enabled = False
            PanSkUpDown.Visible = False
            BtnLvlUp.Enabled = False
            BtnLvlDwn.Enabled = False

            If Stats.Intelligence <= 5 Then
                chessavailable = False
                For Each ctl As ListViewItem In LstVQuests.Items
                    If ctl.Text = "Chess Game" Then
                        ctl.Remove()
                    End If
                Next

            Else
                chessavailable = True
                For Each ctl As ListViewItem In LstVQuests.Items
                    If ctl.Text = "Chess Game" Then
                        chessGAlreadyThere = True
                    End If
                Next
                If chessGAlreadyThere = False And chessgametaken = False Then
                    If LstVQuests.Items.Count = 0 Then
                        LstVQuests.Items.Insert(0, "Chess Game")
                    Else
                        LstVQuests.Items.Insert(LstVQuests.Items.Count, "Chess Game")
                    End If

                End If
            End If
        End If

    End Sub

    'Screenshot Feature
    Private Sub AsImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsImageToolStripMenuItem.Click
        Dim scr As Bitmap
        Dim saveFileDialog1 As New SaveFileDialog()

        Dim w As Integer = Me.Width
        Dim h As Integer = Me.Height

        Dim LstBY As Integer

        'Feature that extends Listbox of Taken Perks/Traits when Screenshot is saved
        'so you always have all taken perks, quests, traits etc on your screen
        If LstBoxPerks.ItemHeight * LstBoxPerks.Items.Count > LstBoxPerks.Height Then
            'Scrollbar must be visible
            BtnAllDrugs.Visible = False
            PanDrugs.Visible = False
            LblDrugs.Visible = False

            LstBY = LstBoxPerks.Location.Y - ((LstBoxPerks.ItemHeight * LstBoxPerks.Items.Count) - LstBoxPerks.Height)
            LstBoxPerks.Location = New System.Drawing.Point(236, LstBY)

            LstBoxPerks.Height = LstBoxPerks.ItemHeight * LstBoxPerks.Items.Count
            LblPTraitsTaken.Location = New System.Drawing.Point(237, LstBY - 19)
            Me.Refresh()
        End If


        saveFileDialog1.Filter = "PNG Image|*.png"
        saveFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath
        scr = New Bitmap(w, h)
        Me.DrawToBitmap(scr, Rectangle.FromLTRB(0, 0, w, h))
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName = "" Then
            saveFileDialog1.ShowDialog()
        Else
            scr.Save(saveFileDialog1.FileName)
        End If

        LstBoxPerks.Height = 130
        LstBoxPerks.Location = New System.Drawing.Point(236, 425)
        LblPTraitsTaken.Location = New System.Drawing.Point(237, 406)

        BtnAllDrugs.Visible = True
        PanDrugs.Visible = True
        LblDrugs.Visible = True

        Me.Refresh()

    End Sub

    'Button Achievements
    Private Sub BtnAchievem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAchievem.Click
        If isAchieveActive = True Then
            BtnAchievem.ForeColor = Color.LightGray
            BtnBooks.Enabled = True
            BtnImpl.Enabled = True
            BtnQuests.Enabled = True
            isAchieveActive = False
            LstVAchiev.Visible = False
            LblAchieve.Visible = False
            LblPerks.Visible = True
            PanSkUpDown.Enabled = True
            'PanSkUpDown.Visible = True
            BtnLvlUp.Enabled = True
            BtnLvlDwn.Enabled = True
        Else
            BtnAchievem.ForeColor = Color.SkyBlue
            isAchieveActive = True
            BtnBooks.Enabled = False
            BtnImpl.Enabled = False
            BtnQuests.Enabled = False
            LstVAchiev.Visible = True
            LblAchieve.Visible = True
            LblPerks.Visible = False
            PanSkUpDown.Enabled = False
            PanSkUpDown.Visible = False
            BtnLvlUp.Enabled = False
            BtnLvlDwn.Enabled = False

        End If
    End Sub

    Friend isBooksAll As Boolean
    'Button Books "Take All"
    Private Sub BtnBooksAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBooksAll.Click
        Dim SKVal As Integer
        Dim newSkPoints As Integer

        Stats.GetStats()
        Statistics.GetStatistics()
        Skills.getSkillValues()

        
        'FA
        If Not FABookVal = 0 Then

            SKVal = Skills.FAid
            For i = 1 To FABookVal
                newSkPoints = SPThroughBooksCalc(SKVal)
                SavedSPBooksFAid = SavedSPBooksFAid + SavedSPBooksTemp
                SavedSPBooksTemp = 0
                Skills.FAid = newSkPoints
                SKVal = Skills.FAid
            Next
            If newSkPoints + SavedSPBooksCalk(SavedSPBooksFAid, newSkPoints) >= 300 Then
                newSkPoints = 300
            Else
                newSkPoints = newSkPoints + SavedSPBooksCalk(SavedSPBooksFAid, newSkPoints)
            End If
            Skills.FAid = newSkPoints
            LblFaidVal.Text = newSkPoints & "%"
            FABookVal = 0
        End If

        'OD
        If Not ODBVal = 0 Then

            SKVal = Skills.ODMan

            For i = 1 To ODBVal
                newSkPoints = SPThroughBooksCalc(SKVal)
                SavedSPBooksOD = SavedSPBooksOD + SavedSPBooksTemp
                SavedSPBooksTemp = 0
                Skills.ODMan = newSkPoints
                SKVal = Skills.ODMan
            Next
            If newSkPoints + SavedSPBooksCalk(SavedSPBooksOD, newSkPoints) >= 300 Then
                newSkPoints = 300
            Else
                newSkPoints = newSkPoints + SavedSPBooksCalk(SavedSPBooksOD, newSkPoints)
            End If
            Skills.ODMan = newSkPoints
            LblODVal.Text = newSkPoints & "%"
            ODBVal = 0
        End If

        'Repair
        If Not RepairBVal = 0 Then

            SKVal = Skills.Repair

            For i = 1 To RepairBVal
                newSkPoints = SPThroughBooksCalc(SKVal)
                SavedSPBooksRep = SavedSPBooksRep + SavedSPBooksTemp
                SavedSPBooksTemp = 0
                Skills.Repair = newSkPoints
                SKVal = Skills.Repair
            Next
            If newSkPoints + SavedSPBooksCalk(SavedSPBooksRep, newSkPoints) >= 300 Then
                newSkPoints = 300
            Else
                newSkPoints = newSkPoints + SavedSPBooksCalk(SavedSPBooksRep, newSkPoints)
            End If
            Skills.Repair = newSkPoints
            LblRepairVal.Text = newSkPoints & "%"
            RepairBVal = 0
        End If

        'Science
        If Not ScienceBVal = 0 Then

            SKVal = Skills.Science

            For i = 1 To ScienceBVal
                newSkPoints = SPThroughBooksCalc(SKVal)
                SavedSPBooksScience = SavedSPBooksScience + SavedSPBooksTemp
                SavedSPBooksTemp = 0
                Skills.Science = newSkPoints
                SKVal = Skills.Science
            Next
            If newSkPoints + SavedSPBooksCalk(SavedSPBooksScience, newSkPoints) >= 300 Then
                newSkPoints = 300
            Else
                newSkPoints = newSkPoints + SavedSPBooksCalk(SavedSPBooksScience, newSkPoints)
            End If
            Skills.Science = newSkPoints
            LblScienceVal.Text = newSkPoints & "%"
            ScienceBVal = 0
        End If

        'Small Guns
        If Not SGunBVal = 0 Then

            SKVal = Skills.SmallGuns

            For i = 1 To SGunBVal
                newSkPoints = SPThroughBooksCalc(SKVal)
                SavedSPBooksSmallG = SavedSPBooksSmallG + SavedSPBooksTemp
                SavedSPBooksTemp = 0
                Skills.SmallGuns = newSkPoints
                SKVal = Skills.SmallGuns
            Next
            If newSkPoints + SavedSPBooksCalk(SavedSPBooksSmallG, newSkPoints) >= 300 Then
                newSkPoints = 300
            Else
                newSkPoints = newSkPoints + SavedSPBooksCalk(SavedSPBooksSmallG, newSkPoints)
            End If
            Skills.SmallGuns = newSkPoints
            LblSGunsVal.Text = newSkPoints & "%"
            SGunBVal = 0
        End If

        LstVBooks.Items(0).SubItems(1).Text = FABookVal
        LstVBooks.Items(1).SubItems(1).Text = ODBVal
        LstVBooks.Items(2).SubItems(1).Text = RepairBVal
        LstVBooks.Items(3).SubItems(1).Text = ScienceBVal
        LstVBooks.Items(4).SubItems(1).Text = SGunBVal

        NUDSkillsMinValues()

        If isBookMentats = True Then
            PanBookValEdit.Enabled = False
            BtnBooksAll.Enabled = False
        End If

        isBooksAll = True
    End Sub

    'Save Level
    Sub SaveLevelStats(ByVal saveload As Boolean, ByVal SPLeft As Integer)
        Dim s As String
        Dim zaehler As Integer
        'Dim SpLeft As Integer
        Dim SkillValue(20) As Integer
        Dim SkName(30) As String

        zaehler = 0

        'Read in actual Skill-Values
        For Each ctl As Object In PanSkills.Controls
            If ctl.Text Like "*%" Then
                s = ctl.Text
                SkillValue(zaehler) = s.Substring(0, (Len(ctl.Text) - 1))
            End If
            zaehler = zaehler + 1
        Next

        SkName(0) = "ODMan"
        SkName(1) = "Gambling"
        SkName(2) = "Barter"
        SkName(3) = "Speech"
        SkName(4) = "Repair"
        SkName(5) = "Science"
        SkName(6) = "Traps"
        SkName(7) = "Steal"
        SkName(8) = "Lockpick"
        SkName(9) = "Sneak"
        SkName(10) = "Doctor"
        SkName(11) = "FAid"
        SkName(12) = "Throwing"
        SkName(13) = "Scavenge"
        SkName(14) = "CloseCbt"
        SkName(15) = "EWeapons"
        SkName(16) = "BGuns"
        SkName(17) = "SGuns"

        'Save Skill-Values in array
        For i = 0 To 18
            SaveLoadLvlSkills(Perks.levelVal, saveload, i, SkillValue(i), SkName(i))
        Next

        'SpLeft = LblSkPointsVal.Text
        'Save Taken Perk(s)
        SaveLoadSPLeft(Perks.levelVal, SPLeft, True)

        Stats.GetStats()

        'Save actual SPECIAL-Values
        SaveLoadSpecial(Perks.levelVal, True, 0, Stats.Strenght)
        SaveLoadSpecial(Perks.levelVal, True, 1, Stats.Perception)
        SaveLoadSpecial(Perks.levelVal, True, 2, Stats.Endurance)
        SaveLoadSpecial(Perks.levelVal, True, 3, Stats.Charisma)
        SaveLoadSpecial(Perks.levelVal, True, 4, Stats.Intelligence)
        SaveLoadSpecial(Perks.levelVal, True, 5, Stats.Agility)
        SaveLoadSpecial(Perks.levelVal, True, 6, Stats.Luck)

        Statistics.GetStatistics()

        'Save Statistics
        SaveStatistics(Perks.levelVal)

        'Save Books
        SaveBooks(Perks.levelVal)

        'Save isMedic

    End Sub

    'Timeouts SaveLoad for Save/Load Feature (later if needed)
    Function SaveLoadMedic(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal StatsVal As Boolean, Optional ByVal StatsName As String = "")
        Static isMedicatLevel(100, 0) As Boolean

        If saveload = True Then
            isMedicatLevel(LevelNo, 0) = StatsVal
            Return 1
        Else
            Return isMedicatLevel(LevelNo, 0)
        End If

    End Function

    '**************************************
    '* Save/Load Functions for all values *
    '**************************************

    Sub SavePerkStats(ByVal perk As String, ByVal level As Integer)
        SaveLoadPerks(perk, level, True)
    End Sub

    Sub LoadPerkStats(ByVal level As Integer)
        Dim perkName As String
        Dim substr As String
        Dim lstInd As Integer
        Dim isSecondPerk As Boolean
        Dim isFirstEmpty As Boolean

        If SaveLoadPerks("perk", level, False, 1) = "" Then
            perkName = SaveLoadPerks("perk", level, False)
        Else
            If SaveLoadPerks("perk", level, False) = "" Then
                isFirstEmpty = True
            Else
                isFirstEmpty = False
            End If
            perkName = SaveLoadPerks("perk", level, False, 1)
            isSecondPerk = True

            'erase entry of 2nd ind 
            SaveLoadPerks("", level, True, 1)
        End If

        substr = perkName
        lstInd = LstBoxPerks.FindString(perkName)

        Label2.Text = "perkName " & perkName

        'check if perk was taken before
        If Not perkName = "" Then
            'test if it's a perk with rank >1
            If InStr(perkName, "(2)") Then

                'find ranked perk in listbox, remove it and insert it as new
                LstBoxPerks.Items.Remove(perkName)
                perkName = substr.Substring(0, (Len(perkName) - 4))
                Try
                    LstBoxPerks.Items.Insert(lstInd, perkName)
                Catch
                End Try

                'change rank status and perktaken boolean
                If Not isFirstEmpty = True Then
                    Perkstaken = Perkstaken - 1
                End If
                'End If
                SaveLoadPerkstaken(level, True, Perkstaken)
                Perks.removeTakenPerks(perkName)
                Perks.addRankForRemovedPerks(perkName)


            ElseIf InStr(perkName, "(3)") Then

                LstBoxPerks.Items.Remove(perkName)
                perkName = substr.Substring(0, (Len(perkName) - 4))

                Perks.removeTakenPerks(perkName)
                Perks.addRankForRemovedPerks(perkName)

                perkName = perkName & " (2)"
                Try
                    LstBoxPerks.Items.Insert(lstInd, perkName)
                Catch
                End Try
                'change rank status and perktaken boolean
                If Not isFirstEmpty = True Then
                    Perkstaken = Perkstaken - 1

                End If
                SaveLoadPerkstaken(level, True, Perkstaken)
            Else
                'change rank status and perktaken boolean
                If Not isFirstEmpty = True Then
                    Perkstaken = Perkstaken - 1
                End If
                SaveLoadPerkstaken(level, True, Perkstaken)
                Perks.removeTakenPerks(perkName)
                'Hmmm!!
                Perks.addRankForRemovedPerks(perkName)
                LstBoxPerks.Items.Remove(perkName)
            End If
        Else

        End If

        Label2.Text = "perkName " & perkName

        If isSecondPerk = True Then
            Label2.Text = "isSecondPerk"
            perkName = SaveLoadPerks("perk", level, False)
            substr = perkName
            lstInd = LstBoxPerks.FindString(perkName)


            If Not perkName = "" Then
                'test if it's a perk with rank >1
                If InStr(perkName, "(2)") Then

                    'find ranked perk in listbox, remove it and insert it as new
                    LstBoxPerks.Items.Remove(perkName)
                    perkName = substr.Substring(0, (Len(perkName) - 4))
                    LstBoxPerks.Items.Insert(lstInd, perkName)

                    'change rank status and perktaken boolean
                    'If Not Perkstaken = 0 Then
                    'Perkstaken = Perkstaken - 1
                    'End If

                    Perks.removeTakenPerks(perkName)
                    Perks.addRankForRemovedPerks(perkName)


                ElseIf InStr(perkName, "(3)") Then

                    LstBoxPerks.Items.Remove(perkName)
                    perkName = substr.Substring(0, (Len(perkName) - 4))

                    Perks.removeTakenPerks(perkName)
                    Perks.addRankForRemovedPerks(perkName)

                    perkName = perkName & " (2)"
                    LstBoxPerks.Items.Insert(lstInd, perkName)
                    'change rank status and perktaken boolean
                    'If Not Perkstaken = 0 Then
                    'Perkstaken = Perkstaken - 1
                    'End If


                Else
                    'change rank status and perktaken boolean
                    'If Not Perkstaken = 0 Then
                    'Perkstaken = Perkstaken - 1
                    'End If

                    Perks.removeTakenPerks(perkName)
                    'Hmmm!!
                    Perks.addRankForRemovedPerks(perkName)
                    LstBoxPerks.Items.Remove(perkName)
                End If
            Else

            End If
        End If

        'Erase entry
        SaveLoadPerks("", level, True)

    End Sub

    Function SaveLoadSkillTag(ByVal SkillNo As Integer, ByVal saveload As Boolean, ByVal tagged As Boolean)
        Static SkillTagged(16) As Boolean

        If saveload = True Then
            SkillTagged(SkillNo) = tagged
            Return 1
        Else
            Return SkillTagged(SkillNo)
        End If

    End Function

    Function SaveLoadLvlSkills(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal SkillInd As Integer, ByVal SkillVal As Integer, Optional ByVal SkillName As String = "Skill")
        Static SkillValue(100, 20) As Integer
        '
        Skills.getSkillValues()

        If saveload = True Then
            SkillValue(LevelNo, SkillInd) = SkillVal
            'test
            'LstBoxPerks.Items.Add(SkillName & " " & SkillVal)

            Return 1
        Else
            Return SkillValue(LevelNo, SkillInd)
        End If
    End Function

    Function SaveLoadSPLeft(ByVal Level As Integer, ByVal SPointsLeft As Integer, ByVal saveload As Boolean)
        Static SPLeft(100, 1) As Integer
        If saveload = True Then
            SPLeft(Level, 0) = SPointsLeft
            'Test
            'Label1.Text = "Level: " & Perks.levelVal & " , SPLeft: " & SPointsLeft
            Return 1
        Else
            'Test
            'LstBoxPerks.Items.Add(Level)
            'LstBoxPerks.Items.Add("SkP: " & SPLeft(Level, 0))
            Return SPLeft(Level, 0)
        End If

    End Function

    Function SaveLoadPerks(ByVal perk As String, ByVal level As Integer, ByVal loadsave As Boolean, Optional ByVal perkInd As Integer = 0)
        Static PerkAtLevel(100, 1) As String
        If loadsave = True Then
            'save perkname at given level
            If isSaveEnhanceImplPerk = True Then
                PerkAtLevel(level, 1) = perk
                isSaveEnhanceImplPerk = False
            Else
                PerkAtLevel(level, perkInd) = perk
            End If

            'Function needs something to return :)
            Return 1
        Else
            'load info about perk
            Return PerkAtLevel(level, perkInd)
            PerkAtLevel(level, perkInd) = ""
        End If

        Return 1

    End Function

    Function SaveLoadStatistics(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal StatsInd As Integer, ByVal StatsVal As Integer, Optional ByVal StatsName As String = "HitPoints")
        Static StatisticsatLevel(100, 14) As Integer

        If saveload = True Then
            StatisticsatLevel(LevelNo, StatsInd) = StatsVal
            Return 1
        Else
            Return StatisticsatLevel(LevelNo, StatsInd)
        End If

    End Function

    Sub SaveStatistics(ByVal level As Integer)
        Statistics.GetStatistics()

        SaveLoadStatistics(level, True, 0, Statistics.HitPoints, "HitPoints")
        SaveLoadStatistics(level, True, 1, Statistics.AClass, "AClass")
        SaveLoadStatistics(level, True, 2, Statistics.APoints, "APoints")
        SaveLoadStatistics(level, True, 3, Statistics.DmgRes, "DmgRes")
        SaveLoadStatistics(level, True, 4, Statistics.PoisonRes, "PoisonRes")
        SaveLoadStatistics(level, True, 5, Statistics.RadRes, "RadRes")
        SaveLoadStatistics(level, True, 6, Statistics.CarryWeight, "CarryWeight")
        SaveLoadStatistics(level, True, 7, Statistics.CritChance, "CritChance")
        SaveLoadStatistics(level, True, 8, Statistics.Sequence, "Sequence")
        SaveLoadStatistics(level, True, 9, Statistics.HealRate, "HealRate")
        SaveLoadStatistics(level, True, 10, Statistics.MeleeDmg, "MeleeDmg")
        SaveLoadStatistics(level, True, 11, Statistics.Sight, "Sight")
        SaveLoadStatistics(level, True, 12, Statistics.ACritical, "ACritical")


    End Sub

    Sub LoadStatistics(ByVal level As Integer)
        Statistics.HitPoints = SaveLoadStatistics(level, False, 0, 1)
        Statistics.AClass = SaveLoadStatistics(level, False, 1, 1)
        Statistics.APoints = SaveLoadStatistics(level, False, 2, 1)
        Statistics.DmgRes = SaveLoadStatistics(level, False, 3, 1)
        Statistics.PoisonRes = SaveLoadStatistics(level, False, 4, 1)
        Statistics.RadRes = SaveLoadStatistics(level, False, 5, 1)
        Statistics.CarryWeight = SaveLoadStatistics(level, False, 6, 1)
        Statistics.CritChance = SaveLoadStatistics(level, False, 7, 1)
        Statistics.Sequence = SaveLoadStatistics(level, False, 8, 1)
        Statistics.HealRate = SaveLoadStatistics(level, False, 9, 1)
        Statistics.MeleeDmg = SaveLoadStatistics(level, False, 10, 1)
        Statistics.Sight = SaveLoadStatistics(level, False, 11, 1)
        Statistics.ACritical = SaveLoadStatistics(level, False, 12, 1)

        Statistics.SetStatistics()


    End Sub

    Sub LoadSPECIALS(ByVal level As Integer)
        LblStatsSTVal.Text = SaveLoadSpecial(level, False, 0, 1)
        LblStatsPEVal.Text = SaveLoadSpecial(level, False, 1, 1)
        LblStatsENVal.Text = SaveLoadSpecial(level, False, 2, 1)
        LblStatsCHVal.Text = SaveLoadSpecial(level, False, 3, 1)
        LblStatsINVal.Text = SaveLoadSpecial(level, False, 4, 1)
        LblStatsAGVal.Text = SaveLoadSpecial(level, False, 5, 1)
        LblStatsLKVal.Text = SaveLoadSpecial(level, False, 6, 1)

        'update SPECIAL values
        Stats.GetStats()
    End Sub

    Sub SaveBooks(ByVal level As Integer)
        SaveLoadBooks(level, True, 0, FABookVal)
        SaveLoadBooks(level, True, 1, ODBVal)
        SaveLoadBooks(level, True, 2, RepairBVal)
        SaveLoadBooks(level, True, 3, ScienceBVal)
        SaveLoadBooks(level, True, 4, SGunBVal)
    End Sub

    Sub LoadBooks(ByVal level As Integer)
        FABookVal = SaveLoadBooks(level, False, 0, 1)
        ODBVal = SaveLoadBooks(level, False, 1, 1)
        RepairBVal = SaveLoadBooks(level, False, 2, 1)
        ScienceBVal = SaveLoadBooks(level, False, 3, 1)
        SGunBVal = SaveLoadBooks(level, False, 4, 1)
    End Sub

    Sub LoadImplants(ByVal level As Integer)
        Dim ImplName As String

        ImplName = SaveLoadImpl(level, False, "Impl")

        If Not ImplName = "" Then
            Try
                LstBoxPerks.Items.Remove(ImplName)
                If ImplName = "Medical Implant" Then
                    LstBoxPerks.Items.Remove("Living Anatomy (by Implant)")
                End If
            Catch ex As Exception

            End Try
            'reset check if Impl was already taken
            isImplChoosen = False

            'fill list again
            LstVImpl.Items.Insert(0, "Accuracy Implant")
            LstVImpl.Items.Insert(1, "Chem Control Implant")
            LstVImpl.Items.Insert(2, "Defense Implant")
            LstVImpl.Items.Insert(3, "Enhancement Implant")
            LstVImpl.Items.Insert(4, "Enviromental Implant")
            LstVImpl.Items.Insert(5, "Marksmanship Implant")
            LstVImpl.Items.Insert(6, "Medical Implant")
            LstVImpl.Items.Insert(7, "Scouting Implant")
            LstVImpl.Items.Insert(8, "Speed Implant")
            LstVImpl.Items.Insert(9, "Survival Implant")

            'delete actual entry in array
            SaveLoadImpl(level, True, "")

        End If

    End Sub

    Sub LoadAchievements(ByVal level As Integer)
        Dim AchievmName As String

        For i = 0 To 10
            AchievmName = SaveLoadAchievements(level, False, "", i)

            If Not AchievmName = "" Then
                Try
                    LstBoxPerks.Items.Remove(AchievmName)
                    LstVAchiev.Items.Insert(LstVAchiev.Items.Count, AchievmName)
                Catch ex As Exception
                End Try


            End If

        Next

    End Sub

    Function SaveLoadAchievements(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal AchievemName As String, Optional ByVal AchInd As Integer = 0)
        Static AchievementAtLvl(100, 10) As String
        If saveload = True Then

            If isLoad = True Then 'If function was called by Load-feature
                AchievementAtLvl(LevelNo, AchInd) = AchievemName
            Else
                For i = 0 To 10

                    If AchievementAtLvl(LevelNo, i) = "" Then
                        AchievementAtLvl(LevelNo, i) = AchievemName
                        Exit For
                    End If
                Next
            End If
            Return 1
        Else
            Return AchievementAtLvl(LevelNo, AchInd)
        End If

    End Function

    Sub SaveImplants(ByVal level As Integer, ByVal ImplName As String)
        SaveLoadImpl(level, True, ImplName)
    End Sub

    Friend lstBitem As String
    Sub LoadQuests(ByVal level As Integer)
        Dim QuestN(3) As String
        'Dim lstBitem As String

        For i = 0 To 2
            QuestN(i) = SaveLoadQuests(level, False, "quest", i)
            'Testausgabe
            'Debug.Print("QUestN(" & i & ") = " & QuestN(i))
            If Not QuestN(i) = "" Then
                If InStr(QuestN(i), "Chess Game") > 0 Then
                    LstVQuests.Items.Insert(LstVQuests.Items.Count, "Chess Game")
                    LstBoxPerks.Items.Remove(QuestN(i))
                Else
                    LstVQuests.Items.Insert(LstVQuests.Items.Count, QuestN(i))
                    LstBoxPerks.Items.Remove(QuestN(i))
                End If

            End If

        Next

        'QuestN = SaveLoadQuests(level, False, "quest")

        For i = 0 To 2
            SaveLoadQuests(level, True, "", i, True)
        Next
        'SaveLoadQuests(level, True, "")

    End Sub

    Function SaveLoadQuests(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal QuestName As String, _
                            Optional ByVal QuestInd As Integer = 0, Optional ByVal isEraseafterLoad As Boolean = False)
        Static QuestatLevel(100, 2) As String
        If saveload = True Then
            'check if the func is called by Sub "LoadQuests" to erase all entries
            If isEraseafterLoad = True Then
                QuestatLevel(LevelNo, QuestInd) = QuestName
                Return 1
            Else
                If isLoad = True Then 'If function was called by Load-feature
                    QuestatLevel(LevelNo, QuestInd) = QuestName
                Else
                    For i = 0 To 2
                        If QuestatLevel(LevelNo, i) = "Chess Game" And InStr(QuestName, "Chess Game") > 0 Then
                            QuestatLevel(LevelNo, i) = QuestName
                            Exit For
                        ElseIf QuestatLevel(LevelNo, i) = "" Then
                            QuestatLevel(LevelNo, i) = QuestName
                            'Debug.Print(QuestatLevel(LevelNo, i))
                            Exit For
                        End If
                    Next
                End If
                'QuestatLevel(LevelNo, 0) = QuestName
                Return 1
        End If
        Else
            Return QuestatLevel(LevelNo, QuestInd)
        End If

    End Function

    Function SaveLoadImpl(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal ImplName As String)
        Static ImplantatLvl(100, 1) As String
        If saveload = True Then
            ImplantatLvl(LevelNo, 0) = ImplName
            Return 1
        Else
            Return ImplantatLvl(LevelNo, 0)
        End If

    End Function

    Function SaveLoadBooks(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal BookInd As Integer, ByVal BookAmount As Integer)
        Static BooksatLevel(100, 5) As Integer

        If saveload = True Then
            BooksatLevel(LevelNo, BookInd) = BookAmount
            Return 1
        Else
            Return BooksatLevel(LevelNo, BookInd)
        End If

    End Function

    Function SaveLoadSpecial(ByVal LevelNo As Integer, ByVal saveload As Boolean, ByVal SPECIALInd As Integer, ByVal SPECIALVal As Integer)
        Static SPECIALatLevel(100, 7) As Integer
        Stats.GetStats()

        If saveload = True Then
            SPECIALatLevel(LevelNo, SPECIALInd) = SPECIALVal
            Return 1
        Else
            Return SPECIALatLevel(LevelNo, SPECIALInd)
        End If


    End Function

    Function SaveLoadPerkRank(ByVal saveload As Boolean, ByVal PInd As Integer, ByVal Rank As Integer)
        Static PerkRankAtLvl(43) As Integer
        If saveload = True Then
            PerkRankAtLvl(PInd) = Rank
            Return 1
        Else
            Return PerkRankAtLvl(PInd)
            'PerkstakenAtlLvl(LevelNo, 0) = 0
        End If
    End Function

    'When Going down in Level
    'Load saved Stats when going down in level
    Private Sub BtnLvlDwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLvlDwn.Click
        Dim level As Integer

        level = CInt(LblLevelVal.Text)

        ResetDrugEffects()

        If level <= 24 Then
            BtnLvlFastUp.Visible = False
        Else
            BtnLvlFastUp.Visible = True
        End If

        If Not LblLevelVal.Text <= 1 Then
            LblLevelVal.Text = LblLevelVal.Text - 1
            Skills.LoadSkills()
            LoadPerkStats(level)
            LoadSPECIALS(level - 1)
            LoadStatistics(level - 1)
            LoadBooks(level - 1)
            LoadImplants(level)
            LoadQuests(level)
            LoadPerkLater(level - 1)
            LoadAchievements(level)
            'LoadPerkstaken(level)
            Label3.Text = "N° Perks LvlDown: " & Perkstaken
        Else
            Label3.Text = "N° Perks LvlDown: " & Perkstaken
            Skills.LoadSkills()
            LoadPerkStats(level)
            LoadSPECIALS(level)
            LoadStatistics(level)
            LoadBooks(level)
            LoadQuests(level)
            LoadImplants(level)
            LoadAchievements(level)
        End If

        If isFastUp = True And level = lastLevel Then
            isFastUp = False
        End If

    End Sub

    '***************************************************
    '* Save/Load complete builds - NOT IMPLEMENTED YET *
    '***************************************************

    'also not finished...still some elements/values have to be saved and to be loaded
    'whole feature needs also to be tested later on!!

    'Save build via Save Dialog
    Private Sub SaveBuildToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBuildToolStripMenuItem.Click
        Dim saveBuildDialog As New SaveFileDialog()
        Dim fileName As String
        Dim path As String
        Dim skPLeft As Integer = LblSkPointsVal.Text

        PanDrugs.Enabled = False
        BtnAllDrugs.Enabled = False

        ResetDrugEffects()

        Stats.GetStats()
        Statistics.GetStatistics()
        Skills.getSkillValues()
        Perks.levelVal = LblLevelVal.Text

        'simulate click on lvlup Button to save values from actual level
        SaveLevelStats(True, skPLeft)

        saveBuildDialog.Filter = "Text (*.txt)|*.txt"
        saveBuildDialog.InitialDirectory = My.Application.Info.DirectoryPath
        If saveBuildDialog.ShowDialog() = DialogResult.OK Then

            fileName = saveBuildDialog.FileName
            path = fileName

            'delete previous text in file, if it already exists
            If File.Exists(path) = True Then
                File.WriteAllText(path, "")
            End If

            Using sw As StreamWriter = New StreamWriter(fileName)

                ' Add some text to the file.
                sw.Write("* FCP - Fallout Online 2 Character Planner *") '1
                sw.WriteLine("") '1
                sw.WriteLine("* Saved Build - File *") '2
                sw.WriteLine("*--------------------------------------------------*") '3
                sw.WriteLine("") '4
                sw.WriteLine("*Change this file on your own risk!*") '5
                sw.WriteLine("") '6

                'SPECIAL @lvl
                sw.WriteLine("*SPECIAL - Attributes*") '7
                sw.WriteLine("*--------------------*") '8

                For i = 1 To 100
                    For j = 0 To 7
                        sw.WriteLine(SaveLoadSpecial(i, False, j, 1))
                    Next
                Next

                'STATS
                sw.WriteLine("*Statistics*") '16
                sw.WriteLine("*----------*") '17

                For i = 1 To 100
                    For j = 0 To 12
                        sw.WriteLine(SaveLoadStatistics(i, False, j, 1))
                    Next
                Next

                'SKILLS
                'info about tagged or not is saved first
                sw.WriteLine("*Skills-Tag*") '31
                sw.WriteLine("*----------*") '32
                'sw.WriteLine(Skills.SmallGuns) '33
                sw.WriteLine(isSGtag)
                'sw.WriteLine(Skills.BigGuns)
                sw.WriteLine(isBGtag)
                'sw.WriteLine(Skills.EWeapons)
                sw.WriteLine(isEWtag)
                'sw.WriteLine(Skills.CCombat)
                sw.WriteLine(isCCtag)
                'sw.WriteLine(Skills.Throwing)
                sw.WriteLine(isThrowtag)
                'sw.WriteLine(Skills.FAid)
                sw.WriteLine(isFAtag)
                'sw.WriteLine(Skills.Doctor)
                sw.WriteLine(isDoctag)
                'sw.WriteLine(Skills.Speech)
                sw.WriteLine(isSpeechtag)
                'sw.WriteLine(Skills.Barter)
                sw.WriteLine(isBartertag)
                'sw.WriteLine(Skills.LockPick)
                sw.WriteLine(isLPtag)
                'sw.WriteLine(Skills.Traps)
                sw.WriteLine(isTrapstag)
                'sw.WriteLine(Skills.Science)
                sw.WriteLine(isSciencetag)
                'sw.WriteLine(Skills.Repair)
                sw.WriteLine(isReptag)
                'sw.WriteLine(Skills.Sneak)
                sw.WriteLine(isSneaktag)
                'sw.WriteLine(Skills.Steal)
                sw.WriteLine(isStealtag)
                'sw.WriteLine(Skills.Gambling)
                sw.WriteLine(isGambtag)
                'sw.WriteLine(Skills.ODMan)
                sw.WriteLine(isODtag)

                sw.WriteLine("*Skills*")
                sw.WriteLine("--------")
                For i = 1 To 100
                    For j = 0 To 17
                        sw.WriteLine(SaveLoadLvlSkills(i, False, j, 1))
                    Next
                Next

                'Level
                sw.WriteLine("*Level*")
                sw.WriteLine("*-----*")
                sw.WriteLine(Perks.levelVal)

                'PERKS
                sw.WriteLine("*Perks*")

                For i = 1 To 100
                    For j = 0 To 1
                        sw.WriteLine(SaveLoadPerks("perk", i, False, j))
                    Next
                Next

                'TRAITS
                sw.WriteLine("*Traits*") '
                sw.WriteLine(isFastMeta)
                sw.WriteLine(isBruiser)
                sw.WriteLine(isSFrame)
                sw.WriteLine(isOHanded)
                sw.WriteLine(isFinesse)
                sw.WriteLine(isKamikaze)
                sw.WriteLine(isHHanded)
                sw.WriteLine(isFShot)
                sw.WriteLine(isBlMess)
                sw.WriteLine(isJinxed)
                sw.WriteLine(isGNatured)
                sw.WriteLine(isCRel)
                sw.WriteLine(isCRes)
                sw.WriteLine(isBHead)
                sw.WriteLine(isMutant)
                sw.WriteLine(isEvader)

                sw.WriteLine("*Perkstaken*")
                sw.WriteLine("------------")
                'actual value
                sw.WriteLine(Perkstaken)

                For i = 1 To 100
                    sw.WriteLine(SaveLoadPerkstaken(i, False, 1))
                Next

                'Books
                sw.WriteLine("*Books*")
                sw.WriteLine("-------")

                For i = 1 To 100
                    For j = 0 To 5
                        sw.WriteLine(SaveLoadBooks(i, False, j, 1))
                    Next
                Next

                'Implants
                sw.WriteLine("*Implants*")
                sw.WriteLine("----------")

                For i = 1 To 100
                    sw.WriteLine(SaveLoadImpl(i, False, ""))
                Next

                'Achievements
                sw.WriteLine("*Achievements*")
                sw.WriteLine("--------------")

                For i = 1 To 100
                    For j = 0 To 10
                        sw.WriteLine(SaveLoadAchievements(i, False, "", j))
                    Next
                Next

                'Quests
                sw.WriteLine("*Quests*")
                sw.WriteLine("--------")

                For i = 1 To 100
                    For j = 0 To 2
                        sw.WriteLine(SaveLoadQuests(i, False, "", j))
                    Next
                Next

                'SkillPLeft @actual level
                sw.WriteLine("Skill Points Left")
                sw.WriteLine("-----------------")
                sw.WriteLine(skPLeft)

                'SkLeft @Levels
                For i = 1 To 100
                    For j = 0 To 1
                        sw.WriteLine(SaveLoadSPLeft(i, j, False))
                    Next
                Next

                'Save actual level stats
                sw.WriteLine("*Stats @actual Level*")
                sw.WriteLine("---------------------")
                sw.WriteLine("*SPECIAL*")
                sw.WriteLine(LblStatsSTVal.Text)
                sw.WriteLine(LblStatsPEVal.Text)
                sw.WriteLine(LblStatsENVal.Text)
                sw.WriteLine(LblStatsCHVal.Text)
                sw.WriteLine(LblStatsINVal.Text)
                sw.WriteLine(LblStatsAGVal.Text)
                sw.WriteLine(LblStatsLKVal.Text)
                sw.WriteLine("*Statistics*")

                'SkillTags New
                sw.WriteLine("Tagged Skills")
                sw.WriteLine("-------------")

                For i = 0 To 16
                    sw.WriteLine(SaveLoadSkillTag(i, False, False))
                Next

                'Check if Quest "Chess Game" is available and if it was taken
                sw.WriteLine("Chess Game - Booleans")
                sw.WriteLine("---------------------")
                sw.WriteLine(chessavailable)
                sw.WriteLine(chessgametaken)

                'Save Status of "PerkLater" option
                sw.WriteLine("Perklater")
                sw.WriteLine("---------")
                For i = 1 To 100
                    sw.WriteLine(SaveLoadPerkLater(i, False, False))
                Next

                sw.WriteLine("MedicPerk")
                sw.WriteLine("---------")
                sw.WriteLine(isMedic)

                'Save Status of Book-Buttons
                sw.WriteLine("BooksAllTaken")
                sw.WriteLine("-------------")
                sw.WriteLine(isBooksAll)

                sw.WriteLine("MentatsBooksTaken")
                sw.WriteLine("-----------------")
                sw.WriteLine(isBookMentats)

                'Save Books-SavedSP
                sw.WriteLine("Saved SkP Books")
                sw.WriteLine("---------------")
                sw.WriteLine("OD,Rep,SG,SC,FA")
                sw.WriteLine(SavedSPBooksOD)
                sw.WriteLine(SavedSPBooksRep)
                sw.WriteLine(SavedSPBooksSmallG)
                sw.WriteLine(SavedSPBooksScience)
                sw.WriteLine(SavedSPBooksFAid)

                'Save if Implant was choosen
                sw.WriteLine("Save ImplChoosen")
                sw.WriteLine("----------------")
                sw.WriteLine(isImplChoosen)

                'FastUpLvl vars
                sw.WriteLine("Skill Points to Last Level")
                sw.WriteLine("--------------------------")
                sw.WriteLine(SkPointstolastlvl)

                sw.WriteLine("HP to Last Level")
                sw.WriteLine("----------------")
                sw.WriteLine(HitPointstolastlvl)

                'was FastLvlUp pressed
                sw.WriteLine("isFastup")
                sw.WriteLine("--------")
                sw.WriteLine(isFastUp)

                'lastlevel
                sw.WriteLine("Last level before Fast Up")
                sw.WriteLine("-------------------------")
                sw.WriteLine(lastLevel)

                'PerkRanks
                sw.WriteLine("PerkRank")
                sw.WriteLine("--------")

                For i = 0 To 43
                    sw.WriteLine(Perks.PerkRank(i))
                Next

                sw.Close()
            End Using
        End If

        PanDrugs.Enabled = True
        BtnAllDrugs.Enabled = True
    End Sub
    Friend isLoad As Boolean = False
    Friend isLoadedOnce As Boolean = False
    'Load previous saved text-file
    Private Sub LoadBuildToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBuildToolStripMenuItem.Click
        Dim loadBuildDialog As New OpenFileDialog()
        Dim fileName As String
        Dim path As String
        Dim text(8000) As String
        Dim fileContent As String
        Dim ktemp As Integer
        Dim level As String

        If isBookactive = True Then
            BtnBooks_Click(sender, e)
        End If

        If isImplantActive = True Then
            BtnImpl_Click(sender, e)
        End If

        If isAchieveActive = True Then
            BtnAchievem_Click(sender, e)
        End If

        If isQuestsActive = True Then
            BtnQuests_Click(sender, e)
        End If

        loadBuildDialog.Filter = "Text (*.txt)|*.txt"
        loadBuildDialog.InitialDirectory = My.Application.Info.DirectoryPath
        If loadBuildDialog.ShowDialog() = DialogResult.OK Then
            'todo --> exception handler
            Try
                fileName = loadBuildDialog.FileName
                path = fileName

                Dim sr As StreamReader = New StreamReader(path)
                fileContent = sr.ReadToEnd()

                text = fileContent.Split(vbNewLine)
                'text = Split(fileContent, " ")
                sr.Close()

            Catch ex As Security.SecurityException
                MsgBox("Something went wrong! Seems as you don't own the rights to open this file. " & ex.Message)
            Catch ex As IOException
                MsgBox("Something went wrong! Seems as this file is already in use by some other process. " & ex.Message)
            Catch ex As Exception
                MsgBox("Something went wrong! " & ex.Message)
            End Try

            If Not text(0) = "* FCP - Fallout Online 2 Character Planner *" Then
                MessageBox.Show("Wrong File! - Please Choose a valid FCP-File")

            Else
                isDone = True
                isLoad = True
                isImplChoosen = False
                SaveBuildToolStripMenuItem.Enabled = True
                ResetDrugEffects()
                PanDrugs.Enabled = True
                BtnAllDrugs.Enabled = True
                'Reset CharPoints in Case Build was loaded before Done was clicked
                Stats.CharPoints = 0
                LblCPoints.Text = "0"

                For Each ctl In PanStats.Controls
                    If Not ctl.GetType Is GetType(Windows.Forms.Label) Then
                        ctl.Visible = False
                    End If
                Next

                'Clear LstVChess and add Quests
                LstVQuests.Items.Clear()
                LstVQuests.Items.Insert(0, "Mary Ann - JT")
                LstVQuests.Items.Insert(1, "Pete Quest - JT")

                Dim isChessinLBPerks As Boolean
                If isLoadedOnce = True Then
                    LstVQuests.Items.Clear()

                    If Stats.Intelligence >= 6 Then
                        For Each LBPerksItem As String In LstBoxPerks.Items
                            If InStr(LBPerksItem, "Chess Game") Then
                                isChessinLBPerks = True
                            End If
                        Next

                        If isChessinLBPerks = False Then
                            LstVQuests.Items.Insert(0, "Chess Game")
                        End If
                    End If

                    If isChessinLBPerks = True Then
                        LstVQuests.Items.Insert(0, "Mary Ann - JT")
                        LstVQuests.Items.Insert(1, "Pete Quest - JT")
                    Else
                        If Not Stats.Intelligence >= 6 Then
                            LstVQuests.Items.Insert(0, "Mary Ann - JT")
                            LstVQuests.Items.Insert(1, "Pete Quest - JT")
                        Else
                            LstVQuests.Items.Insert(1, "Mary Ann - JT")
                            LstVQuests.Items.Insert(2, "Pete Quest - JT")
                        End If
                    End If

                End If

                LblLevel.Visible = True
                BtnLvlDwn.Visible = True
                BtnLvlUp.Visible = True
                PanTraits.Enabled = False
                BtnImpl.Visible = True
                BtnQuests.Visible = True
                BtnAchievem.Visible = True
                BtnBooks.Visible = True

                'Write in Descriptions which else would only be written in when "Done" was clicked7
                'DetDescr Perks
                DetDescrName(0) = "Action Boy" 'rank 2
                DetDescrName(1) = "Adrenaline Rush"
                DetDescrName(2) = "Anticritical" 'rank 2
                DetDescrName(3) = "Better Criticals"
                DetDescrName(4) = "Bonus HtH Attacks"
                DetDescrName(5) = "Bonus HtH Damage" 'rank 3
                DetDescrName(6) = "Bonus Ranged Damage" 'rank 2
                DetDescrName(7) = "Bonus Rate of Fire"
                DetDescrName(8) = "Cautious Nature"
                DetDescrName(9) = "Dodger"
                DetDescrName(10) = "Earlier Sequence"
                DetDescrName(11) = "Educated"
                DetDescrName(12) = "Gain Agility"
                DetDescrName(13) = "Gain Charisma"
                DetDescrName(14) = "Gain Endurance"
                DetDescrName(15) = "Gain Intelligence"
                DetDescrName(16) = "Gain Luck"
                DetDescrName(17) = "Gain Perception"
                DetDescrName(18) = "Gain Strength"
                DetDescrName(19) = "Ghost"
                DetDescrName(20) = "Harmless"
                DetDescrName(21) = "Healer" 'rank 2
                DetDescrName(22) = "HtH Evade"
                DetDescrName(23) = "Lifegiver" 'rank 2
                DetDescrName(24) = "Light Step"
                DetDescrName(25) = "Living Anatomy"
                DetDescrName(26) = "Magnetic Personality"
                DetDescrName(27) = "Master Thief"
                DetDescrName(28) = "Medic"
                DetDescrName(29) = "More Critical" 'rank 2
                DetDescrName(30) = "Mr. Fixit"
                DetDescrName(31) = "Pathfinder"
                DetDescrName(32) = "Pickpocket"
                DetDescrName(33) = "Quick Hands"
                DetDescrName(34) = "Quick Recovery"
                DetDescrName(35) = "Sharpshooter"
                DetDescrName(36) = "Silent Death"
                DetDescrName(37) = "Silent Running"
                DetDescrName(38) = "Stonewall"
                DetDescrName(39) = "Strong Back"
                DetDescrName(40) = "Thief"
                DetDescrName(41) = "Toughness" 'rank 2
                DetDescrName(42) = "Weapon Handling"


                'Implants
                DetDescrName(70) = "Accuracy Implant"
                DetDescrText(70) = "You gain +5 to your Sight (FOV) and +40%     to your SG/BG and EW-Skills."
                DescPicIndex(70) = "ImplAccurDesc"
                DetDescrName(71) = "Chem Control Implant"
                DetDescrText(71) = "Your drug duration time is doubled and       every S-Stimpak you use heals +30% HP."
                DescPicIndex(71) = "ChemControlImpDesc"
                DetDescrName(72) = "Defense Implant"
                DescPicIndex(72) = "ImplDefDesc"
                DetDescrText(72) = "You gain +4% to all types of Damage          Resistances and +2% to all Damage Thresholds."
                DetDescrName(73) = "Enviromental Implant"
                DetDescrText(73) = "You gain +10 to your Healing Rate,           +40% Poison- and +50% Radiation Resistance."
                DescPicIndex(73) = "EnvImplDesc"
                DetDescrName(74) = "Engineering Implant"
                DescPicIndex(74) = "ImplEngDesc"
                DetDescrText(74) = "You gain +100% to Repair-, Science- and      EWeapons-Skill. Additionally your chance to  craft an item with updates is 10% higher."
                DetDescrName(75) = "Enhancement Implant"
                'check if there are all perks available
                DetDescrText(75) = "You can choose an additional perk. Note:     Only Perks, for which you fullfill the requir-ements (Level/SPECIAL) can be taken!"
                DescPicIndex(75) = "ImplEnhanceDesc"
                DetDescrName(76) = "Marksmanship Implant"
                DetDescrText(76) = "You gain +4% to your Crit Roll, +4% to       your Critical Chance and +2 Sight(FOV)."
                DescPicIndex(76) = "StandbySW" 'no pic yet
                DetDescrName(77) = "Medical Implant"
                DetDescrText(77) = "You gain +50% to Doctor- and 50% to        FA-Skill. You deal +5 Damage to living creatures. The HP you can heal(FA) is now 175HP."
                DescPicIndex(77) = "StandbySW" 'no pic yet
                DetDescrName(78) = "Scouting Implant"
                DetDescrText(78) = "You gain +30% to your sneak skill and        +30 to your Armor Class. Your skill can be    raised +20% over the cap. "
                DescPicIndex(78) = "StandbySW" 'no pic yet
                DetDescrName(79) = "Speed Implant"
                DescPicIndex(79) = "ImplSpeedDesc"
                DetDescrText(79) = "Your running animation is 10% faster.        You get +1 Action Point and +6 Sequence."
                DetDescrName(80) = "Survival Implant"
                DetDescrText(80) = "You gain +100% to your ODMan-Skill and       +30 Hit Points. Also you gain +30% experience"
                DescPicIndex(80) = "ImplSurvivalDesc"

                DetDescrText(0) = "You gain +1 Action Point."
                DescPicIndex(0) = "ABoyDesc"
                DetDescrText(1) = "If your Hit Points are below 50% you gain:    +1 AP and +10% to all restistances."
                DescPicIndex(1) = "ARushDesc"
                DetDescrText(2) = "You gain +18% to your Anti-Crit Resistance.   This stacks with armor anticrit bonuses."
                DescPicIndex(2) = "AnticriticalDescNeu"
                DetDescrText(3) = "You gain +20% on your critical hit table.     Note: This doesn't affect your      crit chance!"
                DescPicIndex(3) = "BetterCrDesc"
                DetDescrText(4) = "HtH attacks cost 1 Action Point less."
                'Adds to melee dmg?
                DescPicIndex(4) = "BHtHAtDesc"
                DetDescrText(5) = "You gain +4 HtH Damge."
                DescPicIndex(5) = "BHtHDmgDesc"
                DetDescrText(6) = "You do +2 additional damage for each bullet   on ranged weapons."
                DescPicIndex(6) = "BRDDesc"
                DetDescrText(7) = "Ranged weapon attacks cost 1 AP less."
                DescPicIndex(7) = "BRoFDesc"
                DetDescrText(8) = "This perk doesn't affect anything at the      moment and needs to be reworked."
                DescPicIndex(8) = ""
                DetDescrText(9) = "You gain +40 Armor Class."
                DescPicIndex(9) = "DodgerDesc"
                DetDescrText(10) = "You gain +6 Sequence."
                DescPicIndex(10) = "EarlSeqDesc"
                DetDescrText(11) = "Each Level Up you gain +2 Skill Points,      additionaly to your base value."
                DescPicIndex(11) = "EducatedDesc"
                DetDescrText(12) = "You gain +2 Agility."
                DescPicIndex(12) = "GAGDesc"
                DetDescrText(13) = "You gain +2 Charisma."
                DescPicIndex(13) = "StandbySW" 'no pic yet
                DetDescrText(14) = "You gain +2 Endurance."
                DescPicIndex(14) = "GENDesc"
                DetDescrText(15) = "You gain +2 Intelligence."
                DescPicIndex(15) = "StandbySW" 'no pic yet
                DetDescrText(16) = "You gain +2 Luck."
                DescPicIndex(16) = "GLuckDesc"
                DetDescrText(17) = "You gain +2 Perception."
                DescPicIndex(17) = "GainPEDesc"
                DetDescrText(18) = "You gain +2 Strenght."
                DescPicIndex(18) = "StandbySW" 'no pic yet
                DetDescrText(19) = "You gain +30% Sneak in dark conditions."
                DescPicIndex(19) = "StandbySW" 'no pic yet
                DetDescrText(20) = "You gain +40% Steal-Skill."
                DescPicIndex(20) = "HarmlessDesc"
                DetDescrText(21) = "+4-10 HP are healed when using First Aid."
                DescPicIndex(21) = "StandbySW" 'no pic yet
                DetDescrText(22) = "You get an additional bonus to your Armor    Class at the end of a turn. Note:    This perk has probably no effect in Real Time mode!"
                DescPicIndex(22) = "StandbySW" 'no pic yet
                DetDescrText(23) = "You gain +40 Hit Points."
                DescPicIndex(23) = "LifeGDesc"
                DetDescrText(24) = "You chance to set off a trap is lowered by   -90%."
                DescPicIndex(24) = "LStepDesc"
                DetDescrText(25) = "You gain +20% to your Doctor-Skill and deal  +5 damage to living creatures                (including other players)."
                DescPicIndex(25) = "StandbySW" 'no pic yet
                DetDescrText(26) = "You can carry 2 more people around with you."
                DescPicIndex(26) = "StandbySW" 'no pic yet
                DetDescrText(27) = "You gain +20% to Steal- and Lockpick-Skills."
                DescPicIndex(27) = "StandbySW" 'no pic yet
                DetDescrText(28) = "You gain +25% to First Aid- and Doctor-      Skills and your timeouts are decreased by 40%."
                DescPicIndex(28) = "MedicDesc"
                DetDescrText(29) = "You gain +8% Crit Chance."
                DescPicIndex(29) = "MCritsDesc"
                DetDescrText(30) = "You gain +10% to Repair- and Science-Skills."
                DescPicIndex(30) = "MrFixitDesc"
                DetDescrText(31) = "You gain +30% to your Outdoorsman-Skill and  your travel time (on world map) is   reduced by 30%."
                DescPicIndex(31) = "PFinderDesc"
                DetDescrText(32) = "Size and facing modifiers are ignored when   stealing. Note: Size means the       weight of an item"
                DescPicIndex(32) = "StandbySW" 'no pic yet
                DetDescrText(33) = "Inventory actions cost half AP. Reload and   Use costs only 1 AP."
                DescPicIndex(33) = "QHandsDesc"
                DetDescrText(34) = "You recover more quickly from knockdowns."
                DescPicIndex(34) = "QRecDesc"
                DetDescrText(35) = "You gain +2PE for determining range          (= +6 FOV or +8% Hit Chance)."
                DescPicIndex(35) = "SShootDesc"
                DetDescrText(36) = "You deal twice the damage, when performing   a HtH attack from behind."
                DescPicIndex(36) = "StandbySW" 'no pic yet
                DetDescrText(37) = "Ability to sneak and run at the same time.   Note: Must have for a sneak          character!"
                DescPicIndex(37) = "SilentRDesc"
                DetDescrText(38) = "The chance to be knocked down is decreased."
                DescPicIndex(38) = "StWallDesc"
                DetDescrText(39) = "You gain +22kg to your Carry Weight."
                DescPicIndex(39) = "StrBackDesc"
                DetDescrText(40) = "-10 seconds to Steal cooldown + chance for   no cooldown at all."
                DescPicIndex(40) = "ThiefDesc"
                DetDescrText(41) = "You gain +8% to all types of Damage          Resistance."
                DescPicIndex(41) = "ThoughDesc"
                DetDescrText(42) = "You gain +3 ST for weapon Strenght checks."
                DescPicIndex(42) = "WHandlDesc"

                'Achievements
                DetDescrName(43) = "Awareness"
                DetDescrName(44) = "Heave Ho!"
                DetDescrName(45) = "Pyromaniac"
                DetDescrName(64) = "Albert the Abberation"
                DetDescrName(65) = "Mother of God"
                DetDescrName(116) = "Pack Rat"

                DetDescrText(43) = "You now have detailed info about examined    critters/players. You will gain this perk automatically after reaching level 26."
                DescPicIndex(43) = "AchievAwarenessDesc"
                DetDescrText(44) = "You gain +3ST when determining throwing      range. In order to get this perk you need to kill 100 mans with throwing weapons."
                DescPicIndex(44) = "AchievHeaveDesc"
                DetDescrText(45) = "You gain +50 flat damage to fire-based       weapons. To obtain this achievement  you have to kill 100 humanoids with Flamer or        Improved Flamer."
                DescPicIndex(45) = "AchievPyroDesc"
                DetDescrText(64) = "You do +5 Damage to Floaters and Centaurs.   In order to achieve this you'll need to kill the Abberation in SF Tanker dungeon."
                DescPicIndex(64) = "AchievAlAberDesc"
                DetDescrText(65) = "You do +5 Damage to Deathclaws."
                DescPicIndex(65) = "AchievMoGDesc"
                DescPicIndex(116) = "AchievPackRDesc"
                DetDescrText(116) = "Carry Weight is increased by 23kg."

                'Clear and add Implants to list before loading
                LstVImpl.Clear()
                LstVImpl.Items.Insert(0, "Accuracy Implant")
                LstVImpl.Items.Insert(1, "Chem Control Implant")
                LstVImpl.Items.Insert(2, "Defense Implant")
                LstVImpl.Items.Insert(3, "Enhancement Implant")
                LstVImpl.Items.Insert(4, "Enviromental Implant")
                LstVImpl.Items.Insert(5, "Marksmanship Implant")
                LstVImpl.Items.Insert(6, "Medical Implant")
                LstVImpl.Items.Insert(7, "Scouting Implant")
                LstVImpl.Items.Insert(8, "Speed Implant")
                LstVImpl.Items.Insert(9, "Survival Implant")


                'Test with Statistics
                For i = 1 To 100
                    'for j=index (Statistic type)
                    For j = 0 To 13
                        'ktemp marks the line in text file
                        ktemp = 810 + (i * 13) - 13 + j

                        If Not ktemp + 12 > 2110 Then
                            'write saved values in static var
                            SaveLoadStatistics(i, True, j, CInt(text(ktemp)))
                            'careful if testing the following line, can take some time to compute :) :
                            'Debug.Print("Level: " & i & ", Index: " & j & ", Value: " & CInt(text(ktemp)))
                        End If
                    Next
                Next

                'Perks

                'ranks
                For i = 0 To 43
                    If Not ktemp + 1 > 6779 Then
                        ktemp = 6736 + i
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        Perks.PerkRank(i) = CInt(text(ktemp))
                    End If
                    
                Next

                For i = 1 To 100
                    For j = 0 To 1
                        ktemp = 3935 + (i * 2) - 2 + j
                        If Not ktemp + 1 > 4135 Then
                            'delete line feed from text()
                            text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                            SaveLoadPerks(CStr(text(ktemp)), i, True, j)
                            Debug.Print("Perk: " & text(ktemp) & " , Level: " & i & " , Ind: " & j)
                        End If
                    Next
                Next

                'Perkstaken
                Perkstaken = CInt(text(4154))

                For i = 1 To 100
                    If Not ktemp + 1 > 4254 Then
                        ktemp = 4154 + i
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadPerkstaken(i, True, CInt(text(ktemp)))
                    End If
                Next


                'Perklater
                For i = 1 To 100
                    If Not ktemp + 1 > 6701 Then
                        ktemp = 6602 + i
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadPerkLater(i, True, CBool(text(ktemp)))
                    End If
                Next

                'Skills
                For i = 1 To 100
                    For j = 0 To 17
                        ktemp = 2131 + (i * 18) - 18 + j
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadLvlSkills(i, True, j, CInt(text(ktemp)))
                    Next
                Next

                'is Skill tagged?
                For i = 0 To 16
                    ktemp = 6579 + i
                    text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                    SaveLoadSkillTag(i, True, text(ktemp))
                Next

                For i = 0 To 16
                    If SaveLoadSkillTag(i, False, False) = True Then
                        Select Case i
                            Case 0
                                LblSGuns.ForeColor = Color.WhiteSmoke
                                LblSGunsVal.ForeColor = Color.WhiteSmoke
                            Case 1
                                LblBGuns.ForeColor = Color.WhiteSmoke
                                LblBGunsVal.ForeColor = Color.WhiteSmoke
                            Case 2
                                LblEWeapons.ForeColor = Color.WhiteSmoke
                                LblEWeaponsVal.ForeColor = Color.WhiteSmoke
                            Case 3
                                LblCCombat.ForeColor = Color.WhiteSmoke
                                LblCCombVal.ForeColor = Color.WhiteSmoke
                            Case 4
                                LblThrow.ForeColor = Color.WhiteSmoke
                                LblThrowVal.ForeColor = Color.WhiteSmoke
                            Case 5
                                LblFAid.ForeColor = Color.WhiteSmoke
                                LblFaidVal.ForeColor = Color.WhiteSmoke
                            Case 6
                                LblDoctor.ForeColor = Color.WhiteSmoke
                                LblDocVal.ForeColor = Color.WhiteSmoke
                            Case 7
                                LblSneak.ForeColor = Color.WhiteSmoke
                                LblSneakVal.ForeColor = Color.WhiteSmoke
                            Case 8
                                LblLPick.ForeColor = Color.WhiteSmoke
                                LblLPickVal.ForeColor = Color.WhiteSmoke
                            Case 9
                                LblSteal.ForeColor = Color.WhiteSmoke
                                LblStealVal.ForeColor = Color.WhiteSmoke
                            Case 10
                                LblTraps.ForeColor = Color.WhiteSmoke
                                LblTrapsVal.ForeColor = Color.WhiteSmoke
                            Case 11
                                LblScience.ForeColor = Color.WhiteSmoke
                                LblScienceVal.ForeColor = Color.WhiteSmoke
                            Case 9
                                LblBarter.ForeColor = Color.WhiteSmoke
                                LblBarterVal.ForeColor = Color.WhiteSmoke
                            Case 8
                                LblLPick.ForeColor = Color.WhiteSmoke
                                LblLPickVal.ForeColor = Color.WhiteSmoke
                            Case 10
                                LblTraps.ForeColor = Color.WhiteSmoke
                                LblTrapsVal.ForeColor = Color.WhiteSmoke
                            Case 11
                                LblScience.ForeColor = Color.WhiteSmoke
                                LblScienceVal.ForeColor = Color.WhiteSmoke
                            Case 12
                                LblRepair.ForeColor = Color.WhiteSmoke
                                LblRepairVal.ForeColor = Color.WhiteSmoke
                            Case 13
                                LblSpeech.ForeColor = Color.WhiteSmoke
                                LblSpeechVal.ForeColor = Color.WhiteSmoke
                            Case 14
                                LblBarter.ForeColor = Color.WhiteSmoke
                                LblBarterVal.ForeColor = Color.WhiteSmoke
                            Case 15
                                LblGambling.ForeColor = Color.WhiteSmoke
                                LblGamblVal.ForeColor = Color.WhiteSmoke
                            Case 16
                                LblODMan.ForeColor = Color.WhiteSmoke
                                LblODVal.ForeColor = Color.WhiteSmoke
                        End Select
                    End If
                Next

                'In case user clicked on skills to tag before lvl1
                'make em green again
                For i = 0 To 16
                    If SaveLoadSkillTag(i, False, False) = False Then
                        Select Case i
                            Case 0
                                LblSGuns.ForeColor = Color.LimeGreen
                                LblSGunsVal.ForeColor = Color.LimeGreen
                            Case 1
                                LblBGuns.ForeColor = Color.LimeGreen
                                LblBGunsVal.ForeColor = Color.LimeGreen
                            Case 2
                                LblEWeapons.ForeColor = Color.LimeGreen
                                LblEWeaponsVal.ForeColor = Color.LimeGreen
                            Case 3
                                LblCCombat.ForeColor = Color.LimeGreen
                                LblCCombVal.ForeColor = Color.LimeGreen
                            Case 4
                                LblThrow.ForeColor = Color.LimeGreen
                                LblThrowVal.ForeColor = Color.LimeGreen
                            Case 5
                                LblFAid.ForeColor = Color.LimeGreen
                                LblFaidVal.ForeColor = Color.LimeGreen
                            Case 6
                                LblDoctor.ForeColor = Color.LimeGreen
                                LblDocVal.ForeColor = Color.LimeGreen
                            Case 7
                                LblSneak.ForeColor = Color.LimeGreen
                                LblSneakVal.ForeColor = Color.LimeGreen
                            Case 8
                                LblLPick.ForeColor = Color.LimeGreen
                                LblLPickVal.ForeColor = Color.LimeGreen
                            Case 9
                                LblSteal.ForeColor = Color.LimeGreen
                                LblStealVal.ForeColor = Color.LimeGreen
                            Case 10
                                LblTraps.ForeColor = Color.LimeGreen
                                LblTrapsVal.ForeColor = Color.LimeGreen
                            Case 11
                                LblScience.ForeColor = Color.LimeGreen
                                LblScienceVal.ForeColor = Color.LimeGreen
                            Case 9
                                LblBarter.ForeColor = Color.LimeGreen
                                LblBarterVal.ForeColor = Color.LimeGreen
                            Case 8
                                LblLPick.ForeColor = Color.LimeGreen
                                LblLPickVal.ForeColor = Color.LimeGreen
                            Case 10
                                LblTraps.ForeColor = Color.LimeGreen
                                LblTrapsVal.ForeColor = Color.LimeGreen
                            Case 11
                                LblScience.ForeColor = Color.LimeGreen
                                LblScienceVal.ForeColor = Color.LimeGreen
                            Case 12
                                LblRepair.ForeColor = Color.LimeGreen
                                LblRepairVal.ForeColor = Color.LimeGreen
                            Case 13
                                LblSpeech.ForeColor = Color.LimeGreen
                                LblSpeechVal.ForeColor = Color.LimeGreen
                            Case 14
                                LblBarter.ForeColor = Color.LimeGreen
                                LblBarterVal.ForeColor = Color.LimeGreen
                            Case 15
                                LblGambling.ForeColor = Color.LimeGreen
                                LblGamblVal.ForeColor = Color.LimeGreen
                            Case 16
                                LblODMan.ForeColor = Color.LimeGreen
                                LblODVal.ForeColor = Color.LimeGreen
                        End Select
                    End If
                Next

                'skPLeft
                For i = 1 To 100
                    For j = 0 To 1
                        ktemp = 6366 + (i * 2) - 2 + j
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadSPLeft(i, CInt(text(ktemp)), True)
                    Next
                Next i


                'SkPLeft
                'LblSkPointsVal.Text = CInt(text(6365))

                'Special
                For i = 1 To 100
                    For j = 0 To 7
                        ktemp = 8 + (i * 8) - 8 + j
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadSpecial(i, True, j, CInt(text(ktemp)))
                    Next
                Next
                'Books
                For i = 1 To 100
                    For j = 0 To 5
                        ktemp = 4257 + (i * 6) - 6 + j
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadBooks(i, True, j, CInt(text(ktemp)))
                    Next
                Next

                'Quests
                For i = 1 To 100
                    For j = 0 To 2
                        ktemp = 6063 + (i * 3) - 3 + j
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadQuests(i, True, text(ktemp), j)
                        'Debug.Print("Level: " & i & " , Ind: " & j & " , " & text(ktemp))
                    Next
                Next i

                'Fill Achievement List before loading/adding/removing them
                'in case user saved, then took achievements and then loads again
                LstVAchiev.Clear()
                LstVAchiev.Items.Insert(0, "Albert the Abberation")
                LstVAchiev.Items.Insert(1, "Awareness")
                LstVAchiev.Items.Insert(2, "Engineering Implant")
                LstVAchiev.Items.Insert(3, "Heave Ho!")
                LstVAchiev.Items.Insert(4, "Mother of God")
                LstVAchiev.Items.Insert(5, "Pack Rat")
                LstVAchiev.Items.Insert(6, "Pathfinder")
                LstVAchiev.Items.Insert(0, "Pyromaniac")

                'Achievements
                For i = 1 To 100
                    For j = 0 To 10
                        ktemp = 4961 + (i * 11) - 11 + j
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadAchievements(i, True, CStr(text(ktemp)), j)
                        'Debug.Print("Level: " & i & " , Ind: " & j & " , " & text(ktemp))
                    Next
                Next

                'test
                Dim saveloadteststring As String
                For i = 1 To 20
                    For j = 0 To 10
                        saveloadteststring = SaveLoadAchievements(i, False, "", j)
                        Debug.Print("TestAch Lvl: " & i & " , Ind: " & j & " , Achiev: " & saveloadteststring)
                    Next
                Next

                'was implant choosen
                text(6721) = Replace(text(6721), vbLf, vbNullString)
                isImplChoosen = CBool(text(6721))

                'Implants
                ktemp = 0
                For i = 1 To 100
                    If Not ktemp + 1 > 4958 Then
                        ktemp = 4859 + i
                        text(ktemp) = Replace(text(ktemp), vbLf, vbNullString)
                        SaveLoadImpl(i, True, text(ktemp))
                        Debug.Print("Level: " & i & " , Impl: " & text(ktemp))
                    End If
                Next

                Dim strTemp As String
                strTemp = ""

                'Load Build
                level = text(3933)
                LblLevelVal.Text = Format(CInt(level), "##")
                Perks.levelVal = LblLevelVal.Text
                'Debug.Print("Levelload: " & Perks.levelVal & " , Level(level): " & level)

                LstBoxPerks.Items.Clear()
                LoadBooks(level)
                LoadSPECIALS(CInt(text(3933)))

                'load statistics at level, at which the build was save
                'LoadStatistics(CInt(text(3933)) - 1)
                LoadStatistics(CInt(text(3933)))
                'Statistics.SetStatistics()

                'HP/SP to last level
                text(6724) = Replace(text(6724), vbLf, vbNullString)
                SkPointstolastlvl = text(6724)

                text(6727) = Replace(text(6727), vbLf, vbNullString)
                HitPointstolastlvl = text(6727)

                text(6733) = Replace(text(6733), vbLf, vbNullString)
                lastLevel = text(6733)

                'was FastLvlUp pressed
                text(6730) = Replace(text(6730), vbLf, vbNullString)
                isFastUp = CBool(text(6730))

                'Traits

                text(4136) = Replace(text(4136), vbLf, vbNullString)
                isFastMeta = CBool(text(4136))
                text(4137) = Replace(text(4137), vbLf, vbNullString)
                isBruiser = CBool(text(4137))
                text(4138) = Replace(text(4138), vbLf, vbNullString)
                isSFrame = CBool(text(4138))
                text(4139) = Replace(text(4139), vbLf, vbNullString)
                isOHanded = CBool(text(4139))
                text(4140) = Replace(text(4140), vbLf, vbNullString)
                isFinesse = CBool(text(4140))
                text(4141) = Replace(text(4141), vbLf, vbNullString)
                isKamikaze = CBool(text(4141))
                text(4142) = Replace(text(4142), vbLf, vbNullString)
                isHHanded = CBool(text(4142))
                text(4143) = Replace(text(4143), vbLf, vbNullString)
                isFShot = CBool(text(4143))
                text(4144) = Replace(text(4144), vbLf, vbNullString)
                isBlMess = CBool(text(4144))
                text(4145) = Replace(text(4145), vbLf, vbNullString)
                isJinxed = CBool(text(4145))
                text(4146) = Replace(text(4146), vbLf, vbNullString)
                isGNatured = CBool(text(4146))
                text(4147) = Replace(text(4147), vbLf, vbNullString)
                isCRel = CBool(text(4147))
                text(4148) = Replace(text(4148), vbLf, vbNullString)
                isCRes = CBool(text(4148))
                text(4149) = Replace(text(4149), vbLf, vbNullString)
                isBHead = CBool(text(4149))
                text(4150) = Replace(text(4150), vbLf, vbNullString)
                isMutant = CBool(text(4150))
                text(4151) = Replace(text(4151), vbLf, vbNullString)
                isEvader = CBool(text(4151))


                'sw.WriteLine(isFastMeta)
                If isFastMeta = True Then
                    LstBoxPerks.Items.Add("Fast Metabolism")
                End If
                'sw.WriteLine(isBruiser)
                If isBruiser = True Then
                    LstBoxPerks.Items.Add("Bruiser")
                End If
                'sw.WriteLine(isSFrame)
                If isSFrame = True Then
                    LstBoxPerks.Items.Add("Small Frame")
                End If
                'sw.WriteLine(isOHanded)
                If isOHanded = True Then
                    LstBoxPerks.Items.Add("One Handed")
                End If
                'sw.WriteLine(isFinesse)
                If isFinesse = True Then
                    LstBoxPerks.Items.Add("Finesse")
                End If
                'sw.WriteLine(isKamikaze)
                If isKamikaze = True Then
                    LstBoxPerks.Items.Add("Kamikaze")
                End If
                'sw.WriteLine(isHHanded)
                If isHHanded = True Then
                    LstBoxPerks.Items.Add("Heavy Handed")
                End If
                'sw.WriteLine(isFShot)
                If isFShot = True Then
                    LstBoxPerks.Items.Add("Fast Shot")
                End If
                'sw.WriteLine(isBlMess)
                If isBlMess = True Then
                    LstBoxPerks.Items.Add("Bloody Mess")
                End If
                'sw.WriteLine(isJinxed)
                If isJinxed = True Then
                    LstBoxPerks.Items.Add("Jinxed")
                End If
                'sw.WriteLine(isGNatured)
                If isGNatured = True Then
                    LstBoxPerks.Items.Add("Good Natured")
                End If
                'sw.WriteLine(isCRel)
                If isCRel = True Then
                    LstBoxPerks.Items.Add("Chem Reliant")
                End If
                'sw.WriteLine(isCRes)
                If isCRes = True Then
                    LstBoxPerks.Items.Add("Chem Resistant")
                End If
                'sw.WriteLine(isBHead)
                If isBHead = True Then
                    LstBoxPerks.Items.Add("Bonehead")
                End If
                'sw.WriteLine(isMutant)
                If isMutant = True Then
                    LstBoxPerks.Items.Add("Mutant")
                End If
                'sw.WriteLine(isEvader)
                If isEvader = True Then
                    LstBoxPerks.Items.Add("Evader")
                End If

                'add loaded Perks to lstBoxPerks
                For i = 1 To CInt(level)
                    For j = 0 To 1
                        strTemp = SaveLoadPerks("", i, False, j)

                        If Not strTemp = "" Then
                            'Debug.Print("strTemp" & "..." & strTemp & "...")
                            'MessageBox.Show(strTemp)
                            LstBoxPerks.Items.Add(strTemp)
                        End If
                    Next
                Next

                'Check for doublettes in case a ranked perk was taken more then once, it has to be
                'removed from list again

                Dim PLItemTemp As String
                Dim PLItems(100) As String
                Dim PLzaehler As Integer = 0

                'Write all ListItems into Array
                For Each PLItem As String In LstBoxPerks.Items
                    PLItems(PLzaehler) = PLItem
                    PLzaehler = PLzaehler + 1
                Next

                For i = 0 To 100
                    PLItemTemp = PLItems(i)
                    'Debug.Print("items(" & i & ") : " & (PLItems(i)))
                    If InStr(PLItems(i), "(3)") Then
                        Try
                            LstBoxPerks.Items.Remove(PLItemTemp.Replace("(3)", "(2)"))
                            LstBoxPerks.Items.Remove(PLItemTemp.Substring(0, Len(PLItems(i)) - 4))
                        Catch ex As Exception
                        End Try

                    ElseIf InStr(PLItems(i), "(2)") Then
                        Try
                            LstBoxPerks.Items.Remove(PLItemTemp.Substring(0, Len(PLItems(i)) - 4))
                        Catch ex As Exception
                        End Try
                    End If
                Next

                'add loaded Achievements to Perk/Trait-List
                Dim isItemInLBPerks As Boolean
                For i = 1 To CInt(level)
                    For j = 0 To 10
                        strTemp = SaveLoadAchievements(i, False, "", j)
                        isItemInLBPerks = False
                        If Not strTemp = "" Then
                            Debug.Print("strTemp Achievements" & "..." & strTemp & "...")
                            If isLoadedOnce = True Then
                                'MessageBox.Show("Trrueee")
                                For Each LBAchievemItem As String In LstBoxPerks.Items
                                    If strTemp = LBAchievemItem Then
                                        isItemInLBPerks = True
                                    End If
                                Next

                                If Not isItemInLBPerks = True Then
                                    LstBoxPerks.Items.Add(strTemp)
                                End If
                            Else
                                LstBoxPerks.Items.Add(strTemp)
                            End If
                        End If
                    Next
                Next

                'Delete Achievements from A.List
                Dim ALIstItemStr As String

                For i = 1 To CInt(level)
                    For j = 0 To 10
                        strTemp = SaveLoadAchievements(i, False, "", j)

                        If Not strTemp = "" Then
                            For Each AListItem As ListViewItem In LstVAchiev.Items
                                ALIstItemStr = AListItem.ToString
                                ALIstItemStr = ALIstItemStr.Remove(0, 15)
                                ALIstItemStr = ALIstItemStr.TrimEnd("}")

                                If strTemp = ALIstItemStr Then
                                    AListItem.Remove()
                                End If

                            Next
                        End If
                    Next
                Next

                'Add Implants to ListBPerks and Remove ImplListItems
                For i = 1 To 100
                    strTemp = SaveLoadImpl(i, False, "")
                    If Not strTemp = "" Then
                        LstBoxPerks.Items.Add(strTemp)
                        For Each item In LstVImpl.Items
                            item.Remove()
                        Next
                    End If
                Next


                Dim LItemStr As String
                Dim LItem As ListViewItem

                'Remove taken Quests from List
                Dim zaehlerChessInListB As Integer = 0

                For i = 1 To 100
                    For j = 0 To 2
                        strTemp = SaveLoadQuests(i, False, "Quest", j)
                        'Debug.Print(strTemp)
                        If Not strTemp = "" Then
                            'If Not isLoadedOnce = True Then
                            For Each LItem In LstVQuests.Items
                                LItemStr = LItem.ToString
                                LItemStr = LItemStr.Remove(0, 15)
                                LItemStr = LItemStr.TrimEnd("}")
                                Debug.Print("LItemStr: " & LItemStr)
                                If InStr(strTemp, "Chess Game") Then
                                    If Not zaehlerChessInListB > 0 Then
                                        LstBoxPerks.Items.Add(strTemp)
                                        zaehlerChessInListB = zaehlerChessInListB + 1

                                    End If

                                ElseIf LItemStr = strTemp Then
                                    LItem.Remove()
                                    LstBoxPerks.Items.Add(strTemp)
                                End If
                            Next
                            'End If
                        End If
                    Next
                Next

                'Book Buttons and Saved Skill Points
                text(6707) = Replace(text(6707), vbLf, vbNullString)
                isBooksAll = CBool(text(6707))
                text(6710) = Replace(text(6710), vbLf, vbNullString)
                isBookMentats = CBool(text(6710))

                If isBooksAll = True Then
                    BtnBooksAll.Enabled = False
                Else
                    BtnBooksAll.Enabled = True
                End If

                If isBookMentats = True Then
                    LblBMentats.Enabled = False
                Else
                    LblBMentats.Enabled = True
                End If

                SavedSPBooksOD = CInt(text(6714))
                SavedSPBooksRep = CInt(text(6715))
                SavedSPBooksSmallG = CInt(text(6716))
                SavedSPBooksScience = CInt(text(6717))
                SavedSPBooksFAid = CInt(text(6718))



                'FA/Doc Timeouts            
                text(6704) = Replace(text(6704), vbLf, vbNullString)
                isMedic = CBool(text(6704))

                Dim FACoolSecLoad As Double = 0
                Dim DocCoolSecLoad As Double = 0
                Dim DocAtLvl As Integer
                Dim FAAtLvl As Integer

                DocAtLvl = SaveLoadLvlSkills(level, False, 10, 1)
                FAAtLvl = SaveLoadLvlSkills(level, False, 11, 1)

                If isMedic = True Then
                    FACoolSecLoad = 9000 / FAAtLvl * 0.6
                Else
                    FACoolSecLoad = 9000 / FAAtLvl
                End If

                If isMedic = True Then
                    DocCoolSecLoad = 9000 / DocAtLvl * 0.6
                Else
                    DocCoolSecLoad = 9000 / DocAtLvl
                End If

                Dim DocCoolSpanLoad As TimeSpan = TimeSpan.FromSeconds(DocCoolSecLoad)
                'Form1.Label2.Text = DocCoolSec
                LblTODocVal.Text = DocCoolSpanLoad.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                            DocCoolSpanLoad.Seconds.ToString.PadLeft(2, "0"c)
                Dim FACoolSpanLoad As TimeSpan = TimeSpan.FromSeconds(FACoolSecLoad)
                LblTOFAVal.Text = FACoolSpanLoad.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                            FACoolSpanLoad.Seconds.ToString.PadLeft(2, "0"c)

                'read in the value of those booleans to determine wether Chess Game was
                'already taken or not at the level, the file was saved
                text(6598) = Replace(text(6598), vbLf, vbNullString)
                strTemp = text(6598)
                chessavailable = CBool(strTemp)
                text(6599) = Replace(text(6598), vbLf, vbNullString)
                strTemp = text(6599)
                chessgametaken = CBool(strTemp)

                isPerklater = SaveLoadPerkLater(level, False, False)

                'LoadPerkStats(CInt(text(3933)))
                Skills.LoadSkills()
                'SkillValAfterLoad()
                isLoadedOnce = True
                isLoad = False

                If level >= 24 And level <= 99 Then
                    BtnLvlFastUp.Visible = True
                Else
                    BtnLvlFastUp.Visible = False
                End If

                If isFastUp = True Then
                    BtnLvlDwn.Visible = False
                    BtnLvlFastDwn.Visible = True
                    BtnLvlUp.Visible = False
                    BtnLvlFastUp.Visible = False
                End If

            End If
        End If
    End Sub

    
End Class

