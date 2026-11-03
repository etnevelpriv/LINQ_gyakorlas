using System;

namespace LINQ_gyakorlas;

public class Diak
{
    private string nev;
    private int eletkor;
    private string osztaly;
    private double atlag;

    public Diak(string nev, int eletkor, string osztaly, double atlag)
    {
        this.nev = nev;
        this.eletkor = eletkor;
        this.osztaly = osztaly;
        this.atlag = atlag;
    }

    public string Nev
    {
        get { return nev; }
        set { nev = value; }
    }

    public int Eletkor
    {
        get { return eletkor; }
        set { eletkor = value; }
    }

    public string Osztaly
    {
        get { return osztaly; }
        set { osztaly = value; }
    }

    public double Atlag
    {
        get { return atlag; }
        set { atlag = value; }
    }
}
