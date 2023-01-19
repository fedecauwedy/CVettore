using System;
using System.Linq;

public class Vettore //nel costruttore non deve mai tornare indietro niente
{  
    private int[] vettore; //costruttore vuoto che crea internamente un vettore di un solo elemento intero inizializzato a zero
    private int idx=0;
    public Vettore () //metodo che richiama Vettore
    {
        vettore = new int[]{0};
    }
    
    //un costruttore con un parametro N (che crea internamente un vettore di N interi)

    public Vettore(int N) //può avere lo stesso nome perche ora gli do un parametro
    {
        //nel caso in cui N sia negativo costruisce un vettore vuoto di 0 elementi
        if(N < 0)
        vettore= new int[0];
        else
        vettore = new int[N];
    }

    //un metodo bool Aggiungi( val ) (che aggiunge sempre in fondo il valore val e torna true se riesce ad inserirlo... false altrimenti)
    
    public bool Aggiungi( int val )
    {
        if(idx >= vettore.Length)
            return false;

        vettore[idx] = val;
        idx++;
        return true;
        
        
    }

    //un metodo Somma che torna la somma degli elementi
    public int Somma()
    {
        int retVal = 0;
        for(int idx=0; idx < vettore.Length; idx++)
        {
            retVal += vettore[idx];
        }
        return retVal;
    }

    //un metodo Ultimo che torna l'ultimo valore inserito
    public int Ultimo()
    {
        if(vettore.Length == 0)
           return 0;
        
        if( idx == 0)
        return vettore[idx];
        
        return vettore[idx-1];
        
    }
    
}