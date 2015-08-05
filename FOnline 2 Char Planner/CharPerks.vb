Public Class CharPerks

    Inherits CharBaseStats
    Dim stats As New CharStatistics
    Friend levelVal As Integer

    'String list with caption of all Perks
    Friend Perks(42) As String
    Friend Perkstaken(42) As Boolean
    Friend isEducated As Boolean
    Friend isActionBoy As Boolean
    Friend isActionBoy2nd As Boolean
    Friend isGainAG As Boolean
    Friend addActionBoy As Integer
    Friend isLifegiver As Boolean
    Friend isLifegiver2nd As Boolean
    Friend isHealer As Boolean
    Friend isHealer2nd As Boolean
    Friend isESeq As Boolean
    Friend PerkRank(43) As Integer
    Friend addLifegiver As Integer
    Friend isPerkToTake As Boolean
    Friend TakenPerks(15) As String
    Friend isGainPerception As Boolean
    'Friend isMedic As Boolean

    Dim skills As New CharSkills

    'Read in all perks at the beginning + their ranks
    Sub readPerks()
        Dim s As String
        'once read in all Perks from LstView
        For i = 0 To UBound(Perks)
            s = Form1.LstVPerks.Items.Item(i).ToString.Substring(15)
            Perks(i) = s.Substring(0, Len(s) - 1)
            PerkRank(i) = readRank(Perks(i))
            Debug.Print(Perks(i))
            Debug.Print(PerkRank(i))
        Next


    End Sub

    Function readRank(ByVal perk As String)
        Dim rank As Integer
        Select Case perk
            Case "Action Boy"
                rank = 2
                'Case "Anticritical"
                '   rank = 2

                'Client Update 12.7.15 --> http://forum.fonline2.com/index.php?topic=13301.0

                'Case "Bonus HtH Damage"
                'rank = 3
            Case "Bonus Ranged Damage"
                rank = 2
            Case "Lifegiver"
                rank = 2
            Case "More Critical"
                rank = 2
            Case "Toughness"
                rank = 2
            Case Else
                rank = 1
        End Select
        Return rank
    End Function

    'Test if perk has to be choosen now
    Sub LevelTest(ByVal level As Integer, ByVal NumbPTaken As Integer)
        isPerkToTake = False
        Select Case level

            Case 5
                If NumbPTaken = 0 Then
                    MsgBox("Please choose a Perk.")
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.PanSkills.Enabled = False
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    isPerkToTake = True
                End If
            Case 8
                If NumbPTaken = 1 Then
                    MsgBox("Please choose a Perk.")
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.PanSkills.Enabled = False
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    isPerkToTake = True
                End If
            Case 11
                If NumbPTaken = 2 Then
                    MsgBox("Please choose a Perk.")
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.PanSkills.Enabled = False
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    isPerkToTake = True
                End If
            Case 14
                If NumbPTaken = 3 Then
                    MsgBox("Please choose a Perk.")
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.PanSkills.Enabled = False
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    isPerkToTake = True

                End If
            Case 17
                If NumbPTaken = 4 Then
                    MsgBox("Please choose a Perk.")
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.PanSkills.Enabled = False
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    isPerkToTake = True
                End If
            Case 20
                If NumbPTaken = 5 Then
                    MsgBox("Please choose a Perk.")
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.PanSkills.Enabled = False
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    isPerkToTake = True
                End If
            Case 23
                If NumbPTaken = 6 Then
                    MsgBox("Please choose a Perk.")
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.PanSkills.Enabled = False
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    isPerkToTake = True
                End If
        End Select

    End Sub

    'Level UP Routine for Perks
    Sub levelUP()

        GetStats()
        stats.GetStatistics()
        'read Level
        levelVal = Form1.LblLevelVal.Text
        'Test if user has to choose perk if skipped before
        'LevelTest(levelVal, Form1.Perkstaken)

        'Form1.Label1.Text = Form1.Perkstaken

        If Not levelVal >= 99 And Not isPerkToTake = True Then
            levelVal = levelVal + 1
            Form1.LblLevelVal.Text = levelVal

            'Stats
            'check if EN is equal or unequal
            If Not levelVal >= 27 Then

                If Endurance Mod 2 = 0 Then
                    stats.HitPoints = stats.HitPoints + Math.Floor(2 + (Endurance / 2))
                Else
                    If levelVal Mod 2 = 0 Then
                        stats.HitPoints = stats.HitPoints + Math.Floor(2 + (Endurance / 2))
                    Else
                        stats.HitPoints = stats.HitPoints + Math.Floor(2 + (Endurance / 2)) + 1
                    End If
                End If
            Else
                'after level 27
              
                If levelVal Mod 2 = 0 Then
                    stats.HitPoints = stats.HitPoints + 1
                End If

            End If

                'add CW
                stats.CarryWeight = stats.CarryWeight + 1

                'check if Perks can be seleceted
                'add to perk list
                If levelVal Mod 3 = 0 And Not levelVal >= 25 Then
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.BtnPerkLater.Visible = True
                    Form1.PanSkills.Enabled = False

                    Form1.BtnBooks.Enabled = False
                    Form1.BtnQuests.Enabled = False
                    Form1.BtnAchievem.Enabled = False
                    Form1.BtnImpl.Enabled = False

                ElseIf Form1.isPerklater = True Then
                    Form1.BtnLvlUp.Enabled = False
                    Form1.BtnLvlDwn.Enabled = False
                    availablePerks()
                    Form1.PanSkUpDown.Visible = False
                    Form1.BtnPerkLater.Visible = True
                    Form1.PanSkills.Enabled = False

                    Form1.BtnBooks.Enabled = False
                    Form1.BtnQuests.Enabled = False
                    Form1.BtnAchievem.Enabled = False
                    Form1.BtnImpl.Enabled = False
                End If

        End If

        stats.SetStatistics()

    End Sub

    'Check for available Perks @given lvl
    Sub availablePerks()
        Dim isAv As Boolean
        Dim item As ListViewItem

        'remove all Items from list temporarly
        For Each item In Form1.LstVPerks.Items
            item.Remove()
        Next

        Form1.LstVPerks.Visible = True
        Form1.LblPerks.Visible = True

        'show all available Perks
        For i = 0 To UBound(Perks)
            
            isAv = PerkRequirement(Perks(i), Perkstaken(i))
            If isAv = True Then
                'Show in List
                Form1.LstVPerks.Items.Add(Perks(i))
            End If
        Next

        If Form1.isEnhanceImpl = True And Form1.LstVPerks.Items.Count = 0 Then
            Form1.BtnImpl.Enabled = True
        End If


    End Sub

    'Remove already taken Perks when going down in lvl
    Sub removeTakenPerks(ByVal perk As String)
        'Sets removed Perks back to "not taken already" to be accessable again
        For i = 0 To UBound(Perks)
            If Perks(i) = perk Then
                Perkstaken(i) = False
                'timeouts
                If perk = "Medic" Then
                    Form1.isMedic = False
                ElseIf perk = "HtH Evade" Then
                    Form1.isHtHEvade = False
                ElseIf perk = "Sharpshooter" Then
                    Form1.AddSubstractSShooter = 0
                ElseIf (perk = "Gain Perception") Then
                    Form1.isGainPE = False
                End If
                'Form1.Label2.Text = "Removed Perk: " & perk
            End If
        Next

    End Sub

    'add +1 Rank for removed perks if needed
    Sub addRankForRemovedPerks(ByVal perk As String)

        For i = 0 To UBound(Perks)
            If Perks(i) = perk Then
                PerkRank(i) = PerkRank(i) + 1
                'Form1.Label2.Text = "Perk: " & perk & " , RankNew: " & PerkRank(i)
            End If
        Next
    End Sub

    'Adds taken perks to array
    Sub addTakenPerks(ByVal perk As String)
        'Taken Perks are set to True
        For i = 0 To UBound(Perks)
            If Perks(i) = perk Then
                If PerkRank(i) > 1 Then
                    PerkRank(i) = PerkRank(i) - 1
                    'Form1.SaveLoadPerkRank(i, True, PerkRank(i))
                Else
                    PerkRank(i) = PerkRank(i) - 1
                    'Form1.SaveLoadPerkRank(i, True, PerkRank(i))
                    Perkstaken(i) = True
                End If

            End If
        Next


    End Sub

    'Effects of Perks
    Sub perkChanges(ByVal perk As String)
        'set Changes to come into effect
        Dim s As String
        Dim valueSK As Integer

        GetStats()
        stats.GetStatistics()

        Select Case perk
            Case "Action Boy"
                If isActionBoy = True Then
                    isActionBoy2nd = True
                    stats.APoints = stats.APoints + 1
                    addActionBoy = addActionBoy + 1
                Else
                    isActionBoy = True
                    stats.APoints = stats.APoints + 1
                    addActionBoy = addActionBoy + 1
                End If
               
                Form1.DetDescrChange(0, 0)
            Case "Adrenaline Rush"
                Form1.DetDescrChange(1, 1)
            Case "Anticritical"
                Form1.DetDescrChange(2, 2)
                stats.ACritical = stats.ACritical + 18
            Case "Better Criticals"
                Form1.DetDescrChange(3, 3)
            Case "Bonus HtH Attacks"
                Form1.DetDescrChange(4, 4)
            Case "Bonus HtH Damage"
                Form1.DetDescrChange(5, 5)
                stats.MeleeDmg = stats.MeleeDmg + 10
            Case "Bonus Ranged Damage"
                Form1.DetDescrChange(6, 6)
            Case "Bonus Rate of Fire"
                Form1.DetDescrChange(7, 7)
            Case "Cautious Nature"
                Form1.DetDescrChange(8, 8)
            Case "Dodger"
                Form1.DetDescrChange(9, 9)
                stats.AClass = stats.AClass + 40
            Case "Earlier Sequence"
                Form1.DetDescrChange(10, 10)
                stats.Sequence = stats.Sequence + 6
                isESeq = True
            Case "Educated"
                Form1.DetDescrChange(11, 11)
                isEducated = True
                Form1.EducatedAtLvl = True
                'one time +2 SP at the level you choose Educated
                Form1.LblSkPointsVal.Text = Form1.LblSkPointsVal.Text + 2


            Case "Gain Agility"
                Form1.DetDescrChange(12, 12)
                Agility = Agility + 2
                isGainAG = True

                If isActionBoy = True And isActionBoy2nd = True Then
                    addActionBoy = 2
                ElseIf isActionBoy = True And isActionBoy2nd = False Then
                    addActionBoy = 1
                Else
                    addActionBoy = 0
                End If

                'ActionPoints Calc
                If Form1.isBruiser = True Then
                    stats.APoints = ((5 + Int(Agility / 2)) - 2) + addActionBoy
                Else
                    stats.APoints = (5 + Int(Agility / 2)) + addActionBoy
                End If

                'AC calc
                stats.AClass = stats.AClass + 2

            Case "Gain Charisma"
                Form1.DetDescrChange(13, 13)
                Charisma = Charisma + 2
            Case "Gain Endurance"
                Form1.DetDescrChange(14, 14)
                Endurance = Endurance + 2
                'Radiation/Poison Resist Calc
                If Form1.isFastMeta = False Then
                    stats.RadRes = 2 * Endurance
                End If
                If Form1.isFastMeta = False Then
                    stats.PoisonRes = 5 * Endurance
                End If

                'HRate Calc
                If Form1.isFastMeta = False Then
                    stats.HealRate = Math.Round((Endurance / 3.5), 0)
                Else
                    stats.HealRate = Math.Round((Endurance / 3.5), 0) + 10
                End If

            Case "Gain Intelligence"
                Form1.DetDescrChange(15, 15)
                Intelligence = Intelligence + 2

                Form1.addGainINVal = 2

                If Intelligence <= 3 Then
                    Form1.chessavailable = False
                Else
                    Form1.chessavailable = True
                    Form1.LstVChess.Items.Item(0).ForeColor = Color.Chartreuse
                End If

            Case "Gain Luck"
                Form1.DetDescrChange(16, 16)
                Luck = Luck + 2

                'If Form1.isFinesse = True Then
                'stats.CritChance = stats.CritChance + 2 + 10 '+2 through LK +10 through finess
                'Else
                stats.CritChance = stats.CritChance + 2
                'End If


            Case "Gain Perception"
                Form1.DetDescrChange(17, 17)
                Perception = Perception + 2
                'sequence calc
                If isESeq = True Then
                    stats.Sequence = (2 * Perception) + 6
                Else
                    stats.Sequence = 2 * Perception
                End If
                'new Sight calc
                'stats.Sight = 20 + (Perception * 3) + Form1.AddSubstractMarksmanImpl + Form1.AddSubstractSShooter
                Form1.isGainPE = True

            Case "Gain Strenght"
                Form1.DetDescrChange(18, 18)

                Strenght = Strenght + 2

                'Melee Calc New
                If Strenght <= 6 Then
                    If Form1.isBruiser = True And Form1.isHHanded = True Then
                        stats.MeleeDmg = 1 + 4 + 8
                    ElseIf Form1.isBruiser = True And Form1.isHHanded = False Then
                        stats.MeleeDmg = 1 + 8
                    ElseIf Form1.isBruiser = False And Form1.isHHanded = True Then
                        stats.MeleeDmg = 1 + 4
                    Else
                        stats.MeleeDmg = 1
                    End If
                Else
                    If Form1.isBruiser = True And Form1.isHHanded = True Then
                        stats.MeleeDmg = (Strenght - 5) + 4 + 8
                    ElseIf Form1.isBruiser = True And Form1.isHHanded = False Then
                        stats.MeleeDmg = (Strenght - 5) + 8
                    ElseIf Form1.isBruiser = False And Form1.isHHanded = True Then
                        stats.MeleeDmg = (Strenght - 5) + 4
                    Else
                        stats.MeleeDmg = (Strenght - 5)
                    End If
                End If

                'CW new
                If Form1.isSFrame = True Then
                    If Strenght = 2 Then
                        stats.CarryWeight = 33
                    ElseIf Strenght = 7 Then
                        stats.CarryWeight = 67
                    Else
                        stats.CarryWeight = Math.Round((20 + (Strenght * 15) / 2.2046226), 0)
                    End If
                Else
                    If Strenght = 8 Then
                        stats.CarryWeight = 110 '<-- todo --> 110 base value + 1 * N° of lvl!!!          
                    Else
                        stats.CarryWeight = Math.Round((20 + (Strenght * 25) / 2.2046226), 0)
                    End If
                End If

                'Hit Points Bonus
                stats.HitPoints = stats.HitPoints + 2

            Case "Ghost"
                Form1.DetDescrChange(19, 19)
            Case "Harmless"
                Form1.DetDescrChange(20, 20)
                s = Form1.LblStealVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblStealVal.Text) - 1))
                If valueSK + 40 <= 300 Then
                    skills.Steal = skills.Steal + 40
                    Form1.LblStealVal.Text = (valueSK + 40) & "%"
                Else
                    Form1.LblStealVal.Text = 300 & "%"
                End If

            Case "Healer"
                Form1.DetDescrChange(21, 21)

            Case "Heave Ho!"
                'achievement!!! --> todo: Select Achievement-Perks as special perks
                Form1.DetDescrChange(44, 44)
            Case "HtH Evade"
                Form1.DetDescrChange(22, 22)
                Form1.isHtHEvade = True
            Case "Lifegiver"
                Form1.DetDescrChange(23, 23)

                If isLifegiver = False Then
                    isLifegiver = True
                    addLifegiver = 40
                ElseIf isLifegiver = True And isLifegiver2nd = False Then
                    isLifegiver2nd = True
                    addLifegiver = 40
                End If

                stats.HitPoints = stats.HitPoints + addLifegiver
            Case "Light Step"
                Form1.DetDescrChange(24, 24)
            Case "Living Anatomy"
                Form1.DetDescrChange(25, 25)

                s = Form1.LblDocVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblDocVal.Text) - 1))
                If valueSK + 20 <= 300 Then
                    skills.Doctor = skills.Doctor + 20
                    Form1.LblDocVal.Text = (valueSK + 20) & "%"
                Else
                    Form1.LblDocVal.Text = 300 & "%"
                End If

            Case "Magnetic Personality"
                Form1.DetDescrChange(26, 26)
            Case "Master Thief"
                Form1.DetDescrChange(27, 27)

                s = Form1.LblStealVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblStealVal.Text) - 1))
                If valueSK + 20 <= 300 Then
                    skills.Steal = skills.Steal + 20
                    Form1.LblStealVal.Text = (valueSK + 20) & "%"
                Else
                    Form1.LblStealVal.Text = 300 & "%"
                End If

                s = Form1.LblLPickVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblLPickVal.Text) - 1))
                If valueSK + 20 <= 300 Then
                    skills.LockPick = skills.LockPick + 20
                    Form1.LblLPickVal.Text = (valueSK + 20) & "%"
                Else
                    Form1.LblLPickVal.Text = 300 & "%"
                End If


            Case "Medic"
                Form1.DetDescrChange(28, 28)

                s = Form1.LblDocVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblDocVal.Text) - 1))
                If valueSK + 25 <= 300 Then
                    skills.Doctor = skills.Doctor + 25
                    Form1.LblDocVal.Text = (valueSK + 25) & "%"
                Else
                    Form1.LblDocVal.Text = 300 & "%"
                End If

                s = Form1.LblFaidVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblFaidVal.Text) - 1))
                If valueSK + 25 <= 300 Then
                    skills.FAid = skills.FAid + 25
                    Form1.LblFaidVal.Text = (valueSK + 25) & "%"
                Else
                    Form1.LblFaidVal.Text = 300 & "%"
                End If

                Form1.isMedic = True

            Case "More Critical"
                Form1.DetDescrChange(29, 29)
                stats.CritChance = stats.CritChance + 8
                

            Case "Mr. Fixit"
                Form1.DetDescrChange(30, 30)

                s = Form1.LblRepairVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblRepairVal.Text) - 1))
                If valueSK + 10 <= 300 Then
                    skills.Repair = skills.Repair + 10
                    Form1.LblRepairVal.Text = (valueSK + 10) & "%"
                Else
                    Form1.LblRepairVal.Text = 300 & "%"
                End If

                s = Form1.LblScienceVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblScienceVal.Text) - 1))
                If valueSK + 10 <= 300 Then
                    skills.Science = skills.Science + 10
                    Form1.LblScienceVal.Text = (valueSK + 10) & "%"
                Else
                    Form1.LblScienceVal.Text = 300 & "%"
                End If

            Case "Pathfinder"
                Form1.DetDescrChange(31, 31)

                s = Form1.LblODVal.Text
                valueSK = s.Substring(0, (Len(Form1.LblODVal.Text) - 1))
                If valueSK + 30 <= 300 Then
                    skills.ODMan = skills.ODMan + 30
                    Form1.LblODVal.Text = (valueSK + 30) & "%"
                Else
                    Form1.LblODVal.Text = 300 & "%"
                End If

            Case "Pickpocket"
                Form1.DetDescrChange(32, 32)
            Case "Pyromaniac"
                'achievement!!! --> todo: Select Achievement-Perks as special perks
                Form1.DetDescrChange(45, 45)
            Case "Quick Hands"
                Form1.DetDescrChange(33, 33)
            Case "Quick Recovery"
                Form1.DetDescrChange(34, 34)
            Case "Sharpshooter"
                Form1.DetDescrChange(35, 35)
                'stats.Sight = 20 + (Perception * 3) + 6
                stats.Sight = stats.Sight + 6
                'Form1.SightBeforeDrugs
                Form1.AddSubstractSShooter = 6
            Case "Silent Death"
                Form1.DetDescrChange(36, 36)
            Case "Silent Running"
                Form1.DetDescrChange(37, 37)
            Case "Stonewall"
                Form1.DetDescrChange(38, 38)
            Case "Strong Back"
                Form1.DetDescrChange(39, 39)

                stats.CarryWeight = stats.CarryWeight + 22
            Case "Thief"
                Form1.DetDescrChange(40, 40)
            Case "Toughness"
                Form1.DetDescrChange(41, 41)

                stats.DmgRes = stats.DmgRes + 8
            Case "Weapon Handling"
                Form1.DetDescrChange(42, 42)
        End Select
        stats.SetStatistics()
        'refresh SPECIAL and SKillminValues
        Form1.NUDSkillsMinValues()
        SetStats()
        If Form1.LblCritChVal.Text < 0 Then
            Form1.LblCritChVal.ForeColor = Color.Red
        Else
            Form1.LblCritChVal.ForeColor = Color.LimeGreen
        End If

        If Form1.isGainPE = True Then
            stats.RefreshSight()
        End If
    End Sub

    'Check Perk Requirements
    Function PerkRequirement(ByVal perkName As String, ByVal isTaken As Boolean) As Boolean
        Dim isAvailable As Boolean
       
        GetStats()
        skills.getSkillValues()

        'Check if a specified Perk is available and will be shown in list
        isAvailable = False

        Select Case perkName
            Case "Action Boy"
                If isTaken = False And Not levelVal < 12 And Not Agility < 5 Then
                    isAvailable = True
                End If
            Case "Adrenaline Rush"
                If isTaken = False And Not levelVal < 6 And Not Strenght >= 10 Then
                    isAvailable = True
                End If
            Case "Anticritical"
                If isTaken = False And Not levelVal < 3 Then
                    isAvailable = True
                End If
            Case "Better Criticals"
                If isTaken = False And Not levelVal < 12 And Perception >= 7 And Luck >= 7 And Agility >= 4 Then
                    isAvailable = True
                End If
            Case "Bonus HtH Attacks"
                If isTaken = False And Not levelVal < 15 And Agility >= 6 Then
                    isAvailable = True
                End If
            Case "Bonus HtH Damage"
                If isTaken = False And Not levelVal < 3 And Agility >= 6 And Strenght >= 6 Then
                    isAvailable = True
                End If
            Case "Bonus Ranged Damage"
                If isTaken = False And Not levelVal < 6 And Agility >= 6 And Luck >= 6 Then
                    isAvailable = True
                End If
            Case "Bonus Rate of Fire"
                If isTaken = False And Not levelVal < 15 And Agility >= 7 And Intelligence >= 6 And Perception >= 6 Then
                    isAvailable = True
                End If
            Case "Cautious Nature"

                isAvailable = False
            Case "Dodger"
                If isTaken = False And Not levelVal < 9 And Agility >= 6 Then
                    isAvailable = True
                End If
            Case "Earlier Sequence"
                If isTaken = False And Not levelVal < 3 And Perception >= 6 Then
                    isAvailable = True
                End If
            Case "Educated"
                If isTaken = False And Not levelVal < 6 And Intelligence >= 6 Then
                    isAvailable = True
                End If
            Case "Gain Agility"
                If isTaken = False And Not levelVal < 12 And Agility < 9 Then
                    isAvailable = True

                End If
            Case "Gain Charisma"
                If isTaken = False And Not levelVal < 12 And Charisma < 9 Then
                    isAvailable = True

                End If
            Case "Gain Endurance"
                If isTaken = False And Not levelVal < 12 And Endurance < 9 Then
                    isAvailable = True
                End If
            Case "Gain Intelligence"
                If isTaken = False And Not levelVal < 12 And Intelligence < 9 Then
                    isAvailable = True

                End If
            Case "Gain Luck"
                If isTaken = False And Not levelVal < 12 And Luck < 9 Then
                    isAvailable = True

                End If
            Case "Gain Perception"
                If isTaken = False And Not levelVal < 12 And Perception < 9 Then
                    isAvailable = True

                End If
            Case "Gain Strenght"
                If isTaken = False And Not levelVal < 12 And Strenght < 9 Then
                    isAvailable = True

                End If
            Case "Ghost"
                If isTaken = False And Not levelVal < 6 And skills.Sneak >= 60 Then
                    isAvailable = True
                End If
            Case "Harmless"
                If isTaken = False And Not levelVal < 6 And skills.Steal >= 50 Then
                    isAvailable = True

                End If
            Case "Healer"
                If isTaken = False And Not levelVal < 3 And Perception >= 7 And Agility >= 6 And Intelligence >= 5 And skills.FAid >= 40 Then
                    isAvailable = True
                End If
            Case "Heave Ho!"
                'achievement!!! --> todo: Select Achievement-Perks as special perks
                isAvailable = False
            Case "HtH Evade"
                If isTaken = False And Not levelVal < 12 And skills.CCombat >= 200 And skills.BigGuns <= 100 And skills.EWeapons <= 100 And skills.SmallGuns <= 100 Then
                    isAvailable = True
                End If
            Case "Lifegiver"
                If isTaken = False And Not levelVal < 12 And Endurance >= 4 Then
                    isAvailable = True
                End If
            Case "Light Step"
                If isTaken = False And Not levelVal < 9 And Agility >= 5 And Luck >= 5 Then
                    isAvailable = True
                End If
            Case "Living Anatomy"
                If isTaken = False And Not levelVal < 12 And skills.Doctor >= 60 Then
                    isAvailable = True
                End If
            Case "Magnetic Personality"
                If isTaken = False And Not levelVal < 6 Then
                    isAvailable = True
                End If
            Case "Master Thief"
                If isTaken = False And Not levelVal < 12 And skills.Steal >= 50 And skills.LockPick >= 50 Then
                    isAvailable = True
                End If
            Case "Medic"
                If isTaken = False And Not levelVal < 12 And skills.FAid >= 40 And skills.Doctor >= 40 Then
                    isAvailable = True
                End If
            Case "More Critical"
                If isTaken = False And Not levelVal < 6 And Luck >= 6 Then
                    isAvailable = True
                End If
            Case "Mr. Fixit"
                If isTaken = False And Not levelVal < 12 And skills.Repair >= 40 And skills.Science >= 40 Then
                    isAvailable = True
                End If
                'Case "Pathfinder"
                'If isTaken = False And Not levelVal < 6 And Endurance >= 6 And skills.ODMan >= 40 Then
                'isAvailable = True
                'End If
            Case "Pickpocket"
                If isTaken = False And Not levelVal < 15 And Agility >= 8 And skills.Steal >= 80 Then
                    isAvailable = True
                End If
            Case "Pyromaniac"
                'achievement!!! --> todo: Select Achievement-Perks as special perks
                isAvailable = False
            Case "Quick Hands"
                If isTaken = False And Not levelVal < 3 And Agility >= 5 Then
                    isAvailable = True
                End If
            Case "Quick Recovery"
                If isTaken = False And Not levelVal < 3 And Agility >= 5 Then
                    isAvailable = True
                End If
            Case "Sharpshooter"
                If isTaken = False And Not levelVal < 9 And Perception >= 7 And Intelligence >= 6 Then
                    isAvailable = True
                End If
            Case "Silent Death"
                If isTaken = False And Not levelVal < 18 And Agility >= 10 And skills.Sneak >= 80 And skills.CCombat >= 80 Then
                    isAvailable = True
                End If
            Case "Silent Running"
                If isTaken = False And Not levelVal < 6 And Agility >= 6 And skills.Sneak >= 50 Then
                    isAvailable = True
                End If
            Case "Stonewall"
                If isTaken = False And Not levelVal < 3 And Strenght >= 6 Then
                    isAvailable = True
                End If
            Case "Strong Back"
                If isTaken = False And Not levelVal < 3 And Strenght >= 6 And Endurance >= 6 Then
                    isAvailable = True
                End If
            Case "Thief"
                If isTaken = False And Not levelVal < 3 Then
                    isAvailable = True
                End If
            Case "Toughness"
                If isTaken = False And Not levelVal < 3 And Endurance >= 6 Then
                    isAvailable = True
                End If
            Case "Weapon Handling"
                If isTaken = False And Not levelVal < 9 And Agility >= 5 Then
                    isAvailable = True
                End If
        End Select

        Return isAvailable

    End Function

End Class
