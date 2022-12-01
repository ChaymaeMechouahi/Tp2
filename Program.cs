using System;


namespace Tp2
{
    class ProgramPrincipale
    {
        static void Main(string[] args)
        {

		}
    }
public class Examen
{
	private DateTime dateexam;
	private String examde;
	private int duration;
	private int e_nbrequestion;
	private int e_note;
	
	public Examen(DateTime date, String de,int fin,int question , int note)//constructeur
    {  		
		dateexam = date;
		de = examde;
		duration = fin;
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
	public int Duree //setters getters duree
    {
		get { return duration; }
		set { duration= value; }
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
	public abstract class Question //plusieurs questions ont les memes attributs  
	{
		private int reference;
		private string txtquestion;
		private int note;
	}
    public class Proposition
    {
        private string txtproposition;
        private int reference;
        //methods
    }
    public class QCM : Question //inheritance
	{
		private int nbreproposition;
		
	}
	public class VraiFaux : Question //inheritance
	{
        ////attribut  && méthode
    }
    public class QuestionIndirect : Question //inheritance
	{
		//attribut  && méthode
	}
	public class Etudiant
	{
		private string e_nom;

		public PEtudiant(string nom)
		{
			this.e_nom = nom;

		}

		public string Nom//setters getters nbrequestion
		{
			get { return e_nom; }
			set { e_nom = value; }
		}
	} 
}
