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
	public abstract class Question //plusieurs questions ont les memes attributs  
	{
		private int reference;
		private string txtquestion;
		private int note;
	}
	public class QCM : Question //inheritance
	{
		private int nbreproposition;
		private int nbrepropojuste;		
	}
	public class VraiFaux : Question //inheritance
	{
		//attribut && méthode
	}
	public class QuestionIndirect : Question //inheritance
	{
		//attribut  && méthode
	}
	public class CopieEtudiant
	{
		private string nom;
		private ReponseEtudiant reponse = new ReponseEtudiant();
	}
	public abstract class ReponseEtudiant
    {
		//attributs && méthode
    }
    public class ReponseEINd : ReponseEtudiant
	{
		//attributs && méthode
	}
	public class EVF : ReponseEtudiant
	{
		//attributs && méthode
	}
	public class EQCM : ReponseEtudiant
	{
		//attributs && méthode
	}
}
