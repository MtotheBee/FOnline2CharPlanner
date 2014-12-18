Public Class CharBaseStats

    'Eigenschaften von Character Stats
    'SPECIAL Stats
    Friend Strenght As Integer
    Friend Perception As Integer
    Friend Endurance As Integer
    Friend Charisma As Integer
    Friend Intelligence As Integer
    Friend Agility As Integer
    Friend Luck As Integer
    Friend CharPoints As Integer

    Sub GetStats()
        'Read out Values from Labels
        Strenght = CInt(Form1.LblStatsSTVal.Text)
        Perception = CInt(Form1.LblStatsPEVal.Text)
        Endurance = CInt(Form1.LblStatsENVal.Text)
        Charisma = CInt(Form1.LblStatsCHVal.Text)
        Intelligence = CInt(Form1.LblStatsINVal.Text)
        Agility = CInt(Form1.LblStatsAGVal.Text)
        Luck = CInt(Form1.LblStatsLKVal.Text)
        CharPoints = CInt(Form1.LblCPoints.Text)
    End Sub

    Sub SetStats()
        'Set Stats to new values, 
        'method will be called by event Subs in Form mostly
        Form1.LblStatsSTVal.Text = CStr(Strenght)
        Form1.LblStatsPEVal.Text = CStr(Perception)
        Form1.LblStatsENVal.Text = CStr(Endurance)
        Form1.LblStatsCHVal.Text = CStr(Charisma)
        Form1.LblStatsINVal.Text = CStr(Intelligence)
        Form1.LblStatsAGVal.Text = CStr(Agility)
        Form1.LblStatsLKVal.Text = CStr(Luck)
        Form1.LblCPoints.Text = CStr(CharPoints)

    End Sub
End Class

