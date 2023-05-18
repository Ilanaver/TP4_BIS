public class Pais{
    public string Nombre {get; private set;}
    public string imgBandera {get; private set;}
    public int Poblacion {get; private set;}
    public DateTime FechaIndependencia {get; private set;}
    public string AtractivosTuriscticos {get; private set;}

    public Pais (){
        
    }
    public Pais (string nom, string img, int pob, DateTime fInd, string AT){
        Nombre = nom;
        imgBandera = img;
        Poblacion = pob;
        FechaIndependencia = fInd;
        AtractivosTuriscticos = AT;
    }
}