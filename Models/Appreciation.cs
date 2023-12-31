﻿namespace projet_progra_objet;
public class Appreciation : Eval
{
    private string appreciation;
    private static List<Appreciation> listAppreciation = new List<Appreciation>();

    public Appreciation(string appreciation, string uidActivite, string uidStudent, string uid = "uninitiated") : base(uidActivite, uidStudent, uid)
    {
        this.appreciation = appreciation;
        listAppreciation.Add(this);
    }

    public string AppreciationValue
    {
        get { return appreciation; }
        set { appreciation = value; }
    }

    public override int Note()
    {
        if (appreciation == "X") { return 20; }
        else if (appreciation == "TB") { return 16; }
        else if (appreciation == "B") { return 12; }
        else if (appreciation == "C") { return 8; }
        else if (appreciation == "N") { return 4; }
        else { return 0; }
    }

    public static List<Appreciation> ListAppreciation
    {
        get { return listAppreciation; }
    }
}

