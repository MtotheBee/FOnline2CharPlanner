Public Class CharSkills
    Inherits CharBaseStats
    'Dim Perks As New CharPerks

    'Values for Skills + Initial CPoints
    Friend TagSkillsVal As Integer = 3
    Friend SkillP As Integer
    Friend skillPMax As Integer
    Friend SmallGuns As Integer
    Friend BigGuns As Integer
    Friend EWeapons As Integer
    Friend CCombat As Integer
    Friend Scavenging As Integer
    Friend Throwing As Integer
    Friend FAid As Integer
    Friend Doctor As Integer
    Friend Sneak As Integer
    Friend LockPick As Integer
    Friend Steal As Integer
    Friend Traps As Integer
    Friend Science As Integer
    Friend Repair As Integer
    Friend Speech As Integer
    Friend Barter As Integer
    Friend Gambling As Integer
    Friend ODMan As Integer

    Friend SGTagBonus As Integer
    Friend BGTagBonus As Integer
    Friend EWTagBonus As Integer
    Friend CCTagBonus As Integer
    Friend ScavTagBonus As Integer
    Friend ThTagBonus As Integer
    Friend FATagBonus As Integer
    Friend DocTagBonus As Integer
    Friend SnkTagBonus As Integer
    Friend LPTagBonus As Integer
    Friend StlTagBonus As Integer
    Friend TrpTagBonus As Integer
    Friend ScnTagBonus As Integer
    Friend RepTagBonus As Integer
    Friend SpTagBonus As Integer
    Friend BartTagBonus As Integer
    Friend GambTagBonus As Integer
    Friend ODTagBonus As Integer

    Friend addTaggedSkillVal As Integer
    Friend addGNatured As Integer
    Friend addGNaturedW As Integer
    Friend addMutant As Integer
    Friend addBHead As Integer
    Friend addEvade As Integer

    'Initial Level
    Sub getSkillValues()
        
        SmallGuns = Form1.LblSGunsVal.Text.Substring(0, Len(Form1.LblSGunsVal.Text) - 1)
        BigGuns = Form1.LblBGunsVal.Text.Substring(0, Len(Form1.LblBGunsVal.Text) - 1)
        EWeapons = Form1.LblEWeaponsVal.Text.Substring(0, Len(Form1.LblEWeaponsVal.Text) - 1)
        CCombat = Form1.LblCCombVal.Text.Substring(0, Len(Form1.LblCCombVal.Text) - 1)
        Throwing = Form1.LblThrowVal.Text.Substring(0, Len(Form1.LblThrowVal.Text) - 1)
        FAid = Form1.LblFaidVal.Text.Substring(0, Len(Form1.LblFaidVal.Text) - 1)
        Doctor = Form1.LblDocVal.Text.Substring(0, Len(Form1.LblDocVal.Text) - 1)
        Speech = Form1.LblSpeechVal.Text.Substring(0, Len(Form1.LblSpeechVal.Text) - 1)
        Barter = Form1.LblBarterVal.Text.Substring(0, Len(Form1.LblBarterVal.Text) - 1)
        LockPick = Form1.LblLPickVal.Text.Substring(0, Len(Form1.LblLPickVal.Text) - 1)
        Traps = Form1.LblTrapsVal.Text.Substring(0, Len(Form1.LblTrapsVal.Text) - 1)
        Science = Form1.LblScienceVal.Text.Substring(0, Len(Form1.LblScienceVal.Text) - 1)
        Repair = Form1.LblRepairVal.Text.Substring(0, Len(Form1.LblRepairVal.Text) - 1)
        Sneak = Form1.LblSneakVal.Text.Substring(0, Len(Form1.LblSneakVal.Text) - 1)
        Steal = Form1.LblStealVal.Text.Substring(0, Len(Form1.LblStealVal.Text) - 1)
        Gambling = Form1.LblGamblVal.Text.Substring(0, Len(Form1.LblGamblVal.Text) - 1)
        ODMan = Form1.LblODVal.Text.Substring(0, Len(Form1.LblODVal.Text) - 1)
         
    End Sub

    Sub setSkillValues()

        GetStats()
        'CCombat 	        --> 30% + 2x(AG+ST) 
        'FAid               --> PEx2 + IN*2
        'Doc                --> 5% + PE + IN
        'LPick+Traps        --> 10% + AG + PE
        'Speech             --> 0% + CH*5
        'Barter             --> 0% + CH*4
        'OD                 --> (EN+IN) x2
        'Science            --> 4xIN
        'Repair             --> 3xIN
        'SGuns              --> 5% + AG*4
        'BGuns              --> AG*2
        'EWeapons           --> AG*2
        'Throw              --> AG*4
        'Sneak              --> 5% +3*AG
        'Steal              --> 3*AG
        'Gambling           --> 5*LK

        'addBHead is needed as workaround for the "Bonehead-Skillvalue-Issue"
        'addEvade --> same

        If Form1.isGNatured = True Then
            addGNaturedW = 10
            addGNatured = 15
        Else
            addGNatured = 0
            addGNaturedW = 0
        End If

        SmallGuns = (5 + (Agility * 4)) - (addGNaturedW) + SGTagBonus
        BigGuns = (Agility * 2) - (addGNaturedW) + BGTagBonus
        EWeapons = (Agility * 2) - (addGNaturedW) + EWTagBonus
        CCombat = (30 + (2 * (Agility + Strenght))) - (addGNaturedW) + CCTagBonus
        Throwing = (Agility * 4) - (addGNaturedW) + ThTagBonus
        FAid = (Perception * 2) + ((Intelligence + addBHead) * 2) + (addGNatured) + FATagBonus
        Doctor = 5 + (Perception + (Intelligence + addBHead)) + (addGNatured) + DocTagBonus
        Speech = (Charisma * 5) + (addGNatured) + SpTagBonus
        Barter = (Charisma * 4) + (addGNatured) + BartTagBonus
        LockPick = 10 + (Agility + Perception) + LPTagBonus
        Traps = 10 + (Agility + Perception) + TrpTagBonus
        Science = (4 * (Intelligence + addBHead)) + ScnTagBonus
        Repair = (3 * (Intelligence + addBHead)) + RepTagBonus
        Sneak = 5 + (3 * Agility) + SnkTagBonus
        Steal = (3 * Agility) + StlTagBonus
        Gambling = (5 * Luck) + GambTagBonus
        ODMan = (((Endurance + addEvade) + (Intelligence + addBHead)) * 2) + ODTagBonus + addMutant
        Scavenging = ScavTagBonus

        Form1.LblSGunsVal.Text = SmallGuns & "%"
        Form1.LblBGunsVal.Text = BigGuns & "%"
        Form1.LblEWeaponsVal.Text = EWeapons & "%"
        Form1.LblCCombVal.Text = CCombat & "%"
        Form1.LblThrowVal.Text = Throwing & "%"
        Form1.LblFaidVal.Text = FAid & "%"
        Form1.LblDocVal.Text = Doctor & "%"
        Form1.LblSpeechVal.Text = Speech & "%"
        Form1.LblBarterVal.Text = Barter & "%"
        Form1.LblLPickVal.Text = LockPick & "%"
        Form1.LblTrapsVal.Text = Traps & "%"
        Form1.LblScienceVal.Text = Science & "%"
        Form1.LblRepairVal.Text = Repair & "%"
        Form1.LblSneakVal.Text = Sneak & "%"
        Form1.LblStealVal.Text = Steal & "%"
        Form1.LblGamblVal.Text = Gambling & "%"
        Form1.LblODVal.Text = ODMan & "%"
        Form1.LblScavenVal.Text = Scavenging & "%"

        'check for wrong SPECIAL stats (Bruiser, Bonehead, Values over 10 or below 0 etc.)

        If CharPoints = 0 And TagSkillsVal = 0 Then
            If Not Strenght > 10 Or Strenght <= 0 Or Intelligence <= 0 Or Agility <= 0 Or Agility > 10 Or Endurance <= 0 Then
                If Form1.isEvader = True And Endurance > 8 Then
                    Form1.BtnDone.Enabled = False
                    Form1.LblDetDesc.Text = "Incorrect SPECIAL data"
                    Form1.LblDetDescrText.Text = "If you choose Evader, EN has to be" & vbCrLf & "8 or below."
                ElseIf Form1.isBHead = True And Intelligence = 10 Then
                    Form1.BtnDone.Enabled = False
                    Form1.LblDetDesc.Text = "Incorrect SPECIAL data"
                    Form1.LblDetDescrText.Text = "If you choose Bonehead, IN has to be" & vbCrLf & "9 or below."
                Else
                    Form1.BtnDone.Enabled = True
                End If
            Else
                Form1.BtnDone.Enabled = False
            End If
        Else
            Form1.BtnDone.Enabled = False
        End If

    End Sub

    Sub LoadSkills()
        Dim SkillValue(20) As Integer
        Dim SkName(30) As String
        Dim perks As New CharPerks
        perks.levelVal = Form1.LblLevelVal.Text
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

        For i = 0 To 18
            SkillValue(i) = Form1.SaveLoadLvlSkills(perks.levelVal, False, i, i)
            'test
            'Form1.LstBoxPerks.Items.Add(SkName(i) & " " & SkillValue(i))
        Next

        'pass Skill-Values to vars
        ODMan = SkillValue(0)
        Gambling = SkillValue(1)
        Barter = SkillValue(2)
        Speech = SkillValue(3)
        Repair = SkillValue(4)
        Science = SkillValue(5)
        Traps = SkillValue(6)
        Steal = SkillValue(7)
        LockPick = SkillValue(8)
        Sneak = SkillValue(9)
        Doctor = SkillValue(10)
        FAid = SkillValue(11)
        Throwing = SkillValue(12)
        Scavenging = SkillValue(13)
        CCombat = SkillValue(14)
        EWeapons = SkillValue(15)
        BigGuns = SkillValue(16)
        SmallGuns = SkillValue(17)

        'Set New Values
        Form1.LblODVal.Text = ODMan & "%"
        Form1.LblGamblVal.Text = Gambling & "%"
        Form1.LblBarterVal.Text = Barter & "%"
        Form1.LblSpeechVal.Text = Speech & "%"
        Form1.LblRepairVal.Text = Repair & "%"
        Form1.LblScienceVal.Text = Science & "%"
        Form1.LblTrapsVal.Text = Traps & "%"
        Form1.LblStealVal.Text = Steal & "%"
        Form1.LblLPickVal.Text = LockPick & "%"
        Form1.LblSneakVal.Text = Sneak & "%"
        Form1.LblDocVal.Text = Doctor & "%"
        Form1.LblFaidVal.Text = FAid & "%"
        Form1.LblThrowVal.Text = Throwing & "%"
        Form1.LblScavenVal.Text = Scavenging & "%"
        Form1.LblCCombVal.Text = CCombat & "%"
        Form1.LblEWeaponsVal.Text = EWeapons & "%"
        Form1.LblSGunsVal.Text = SmallGuns & "%"
        Form1.LblBGunsVal.Text = BigGuns & "%"

        Form1.LblSkPointsVal.Text = Form1.SaveLoadSPLeft(perks.levelVal, 1, False)
        'Form1.Label1.Text = Form1.SaveLoadSPLeft(perks.levelVal, 1, False)

        Form1.SkillValAfterLoad()
    End Sub

End Class
