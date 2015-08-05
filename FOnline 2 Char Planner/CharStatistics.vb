Public Class CharStatistics
    'Inherits from Stats-class
    Inherits CharBaseStats

    Friend Skills As New CharSkills
    'Dim Perks As New CharPerks

    Friend HitPoints As Integer
    Friend AClass As Integer
    Friend APoints As Integer
    Friend DmgRes As Integer
    Friend PoisonRes As Integer
    Friend RadRes As Integer
    Friend CarryWeight As Integer
    Friend CritChance As Integer
    Friend Sequence As Integer
    Friend HealRate As Integer
    Friend MeleeDmg As Integer
    Friend addHP As Integer
    Friend addMeleeDmg As Integer
    Friend addHRate As Integer
    Friend addCritChance As Integer
    Friend addHHanded As Integer
    Friend addBruiser As Integer
    Friend addMutantMDmg As Integer
    Friend addKamikaze As Integer
    Friend addMutantDR As Integer
    Friend lowCritChance As Integer
    Friend Sight As Integer
    Friend addSShooter As Integer
    Friend ACritical As Integer
    Dim DocCoolSec As Double = 0 'Total number of seconds
    Dim FACoolSec As Double = 0
    'Friend isMedic As Boolean


    Dim Traits As New CharTraits

    Sub GetStatistics()

        'Used to read in actual values
        HitPoints = Form1.LblHitPoints.Text
        AClass = Form1.LblAClassVal.Text
        APoints = Form1.LblAPointsVal.Text
        DmgRes = Form1.LblDmgResVal.Text
        PoisonRes = Form1.LblPoisonResVal.Text
        RadRes = Form1.LblRadResVal.Text
        CarryWeight = Form1.LblCWVal.Text
        CritChance = Form1.LblCritChVal.Text
        Sequence = Form1.LblSeqVal.Text
        HealRate = Form1.LblHealRVal.Text
        MeleeDmg = Form1.LblMDmgVal.Text
        Sight = Form1.LblSightVal.Text
        ACritical = Form1.LblACritVal.Text

    End Sub
   
    Sub SetStatistics()

        GetStats()

        'Before starting leveling up
        If Not Form1.isDone = True Then
            'Hit Points Calc
            HitPoints = (55 + Strenght + (Endurance * 2)) + addHP
            Form1.LblHitPoints.Text = CStr(HitPoints)

            'Carry Weight Calc, Formula in engine seems to be slight different.
            'Therefor 2 Values (at ST2, when SF and at ST8, when normal) have to
            'be checked (33kg instead of 34kg and 110kg instead of 111kg).
            If Form1.isSFrame = True Then
                If Strenght = 2 Then
                    Form1.LblCWVal.Text = 33 '<-- todo --> 33 base value + 1 * N° of lvl!!!
                ElseIf Strenght = 7 Then
                    Form1.LblCWVal.Text = 67
                Else
                    Form1.LblCWVal.Text = Math.Round((20 + (Strenght * 15) / 2.2046226), 0)
                End If
            Else
                If Strenght = 8 Then
                    Form1.LblCWVal.Text = 110 '<-- todo --> 110 base value + 1 * N° of lvl!!!          
                Else
                    Form1.LblCWVal.Text = Math.Round((20 + (Strenght * 25) / 2.2046226), 0)
                End If
            End If

            'AClass Calc
            Form1.LblAClassVal.Text = CStr(Agility) '<--- todo --> additional AC through perks || probably not needed in this sub

            'ActionPoints Calc

            'Bruiser doesnt effect AP anymore since Update 12.7.15
            'If Form1.isBruiser = True Then
            'Form1.LblAPointsVal.Text = CStr((5 + Int(Agility / 2)) - 2)
            'Else
            Form1.LblAPointsVal.Text = CStr(5 + Int(Agility / 2))
            'End If

            'Melee Calc New
            Form1.LblMDmgVal.Text = Strenght + (addHHanded) + (addBruiser) + (addMutantMDmg)

            'HRate Calc
            If Endurance = 1 And Form1.isFastMeta = False Then
                Form1.LblHealRVal.Text = "1"
            ElseIf Form1.isFastMeta = False And Endurance > 1 Then
                Form1.LblHealRVal.Text = Math.Round((Endurance / 3.5), 0)
            ElseIf Form1.isFastMeta = True And Endurance = 1 Then
                Form1.LblHealRVal.Text = "11"
            ElseIf Form1.isFastMeta = True And Endurance > 1 Then
                Form1.LblHealRVal.Text = Math.Round((Endurance / 3.5), 0) + (addHRate)
            End If

            'Radiation/Poison Resist Calc
            If Form1.isFastMeta = False Then
                Form1.LblRadResVal.Text = 2 * Endurance
            Else
                Form1.LblRadResVal.Text = 0
            End If

            If Form1.isFastMeta = False Then
                Form1.LblPoisonResVal.Text = 5 * Endurance
            Else
                Form1.LblPoisonResVal.Text = 0
            End If

            'Sequence Calc
            Form1.LblSeqVal.Text = 2 * Perception

            'CritChance Calc
            If Form1.isFinesse = True Or Form1.isBruiser = True Then
                Form1.LblCritChVal.Text = Luck + addCritChance - lowCritChance
            Else
                Form1.LblCritChVal.Text = Luck - lowCritChance
            End If

            If Form1.LblCritChVal.Text < 0 Then
                Form1.LblCritChVal.ForeColor = Color.Red
            Else
                Form1.LblCritChVal.ForeColor = Color.LimeGreen
            End If

            'DmgRes Calc
            Form1.LblDmgResVal.Text = addKamikaze + addMutantDR

            'Sight Calc
            Form1.LblSightVal.Text = 20 + (Perception * 3)
            'Sight = 20 + (Perception * 3)
            'Anticritical calc
            If Form1.isMutant = True Then
                Form1.LblACritVal.Text = 5
            Else
                Form1.LblACritVal.Text = 0
            End If

            SetStats()
        Else

            If Form1.LblCritChVal.Text < 0 Then
                Form1.LblCritChVal.ForeColor = Color.Red
            Else
                Form1.LblCritChVal.ForeColor = Color.LimeGreen
            End If

            Form1.LblHitPoints.Text = HitPoints
            Form1.LblAClassVal.Text = AClass
            Form1.LblAPointsVal.Text = APoints
            Form1.LblDmgResVal.Text = DmgRes
            Form1.LblPoisonResVal.Text = PoisonRes
            Form1.LblCWVal.Text = CarryWeight
            Form1.LblCritChVal.Text = CritChance
            Form1.LblSeqVal.Text = Sequence
            Form1.LblHealRVal.Text = HealRate
            Form1.LblMDmgVal.Text = MeleeDmg
            Form1.LblRadResVal.Text = RadRes
            Form1.LblACritVal.Text = ACritical
            Form1.LblSightVal.Text = Sight

            'Timeouts/Cooldowns Update
            Skills.getSkillValues()

            Form1.Label1.Text = Form1.isMedic
            If Form1.isMedic = True Then
                DocCoolSec = 9000 / Skills.Doctor * 0.6

            Else
                DocCoolSec = 9000 / Skills.Doctor
            End If

            Dim DocCoolSpan As TimeSpan = TimeSpan.FromSeconds(DocCoolSec)
            'Form1.Label2.Text = DocCoolSec
            Form1.LblTODocVal.Text = DocCoolSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                        DocCoolSpan.Seconds.ToString.PadLeft(2, "0"c)

            If Form1.isMedic = True Then
                FACoolSec = 9000 / Skills.FAid * 0.6
            Else
                FACoolSec = 9000 / Skills.FAid
            End If

            Dim FACoolSpan As TimeSpan = TimeSpan.FromSeconds(FACoolSec)
            Form1.LblTOFAVal.Text = FACoolSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                        FACoolSpan.Seconds.ToString.PadLeft(2, "0"c)

        End If
    End Sub

    Sub RefreshSight()
        GetStats()
        Sight = 20 + (Perception * 3) + Form1.AddSubstractMarksmanImpl + Form1.AddSubstractSShooter

        If Form1.isCigsActive = True Then
            Sight = Sight + 3
        End If

        If Form1.isChessFoV = True Then
            Sight = Sight + 1
            SetStatistics()
        End If

        If Form1.isGainPE = True Then
            SetStatistics()
        End If


    End Sub

End Class
