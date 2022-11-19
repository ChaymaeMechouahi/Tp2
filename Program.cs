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
	private Question question1 = new Question();
    private Question question2 = new Question();
    private Question question3 = new Question();
		//... nbre de question 
	private CopieEtudiant cp1 = new CopieEtudiant();
	private CopieEtudiant cp2 = new CopieEtudiant();
	private CopieEtudiant cp3 = new CopieEtudiant();
		//...nbre d'étudiant
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
		private Reponse reponse;
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
	public abstract class Reponse //plusieurs reponses ont les memes attributs 
	{
		private int note ;
		private int pourcentage_reponse;
	}
	public class PropositionQCM : Reponse
	{
		private int reference;//reference de chaque reponse du qcm  comme 1.a. , 1.b. , 1.c.
	}
	public class ReponseVF : Reponse
	{
		//attributs && méthode 
	}
	public class ReponseInd : Reponse
	{
		//attributs && méthode
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
	public class QCM : ReponseEtudiant
	{
		//attributs && méthode
	}
}
