using System;

public class Examen
{
	private DateTime dateexam;
	private String examde;
	private DateTime datefin;
	private int e_nbrequestion;
	private int e_note;
	public Examen(DateTime date, String de, DateTime fin,int question , int note)//constructeur
    {  		
		dateexam = date;
		de = examde;
		datefin = fin;
		e_nbrequestion = question;
		e_note = note;
    }
	public DateTime Dateexam //setters et getters de dateexam
	{
		get { return dateexam ; }
		set { dateexam = value ; }
	}
	/* public void affichedateexam ()
	 * { Console.WriteLine("Date d'examen est : " +dateexam );}*/
	public String Examde //setters getters de exam de
    {
        get { return examde ;}
        set { examde = value; }
    }
	public DateTime Datefin //setters getters datefin
    {
		get { return datefin; }
		set { datefin = value; }
    } 
	public int Nbrequestion//setters getters nbrequestion
    {
        get { return e_nbrequestion; }
		set { e_nbrequestion = value; }
    }
	public int Note//setters getters note
    {
        get { return e_note; }
        set { e_note = value; }
    }
}
