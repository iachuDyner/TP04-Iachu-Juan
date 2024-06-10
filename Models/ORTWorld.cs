public class ORTWorld{
public static List<string> ListaDestinos {get; private set;} 
public static List<string> ListaHoteles {get; private set;}
public static List<string> ListaAereos {get; private set;}
public static List<string> ListaExcursiones {get; private set;}
public static Dictionary<string, Paquete> Paquetes {get; private set;}

static ORTWorld()
{
    ListaDestinos = new List<string>{
        "Argentina", "España", "Mexico", "Camerun", "Paises Bajos", "Portugal", "Australia", "Colombia", "Grecia", "Japon"
    };

    ListaHoteles = new List<string>{
       "Hotel1.jpg", "Hotel2.jpg", "Hotel3.jpg", "Hotel4.jpg", "Hotel5.jpg", "Hotel6.jpg", "Hotel7.jpg", "Hotel8.jpg", "Hotel9.jpg", "Hotel10.jpg"
    };

    ListaAereos = new List<string>{
        "Aereolineas1.png", "Aereolineas2.png", "Aereolineas3.png", "Aereolineas4.png", "Aereolineas5.png", "Aereolineas6.png", "Aereolineas7.png", "Aereolineas8.png", "Aereolineas9.png", "Aereolineas10.png"
    };

    ListaExcursiones= new List<string>{
        "excursion1.jpg","excursion2.jpg","excursion3.jpg","excursion4.jpg","excursion5.jpg","excursion6.jpg","excursion7.jpg","excursion8.jpg","excursion9.jpg","excursion10.jpg"
    };

    Paquetes = new Dictionary<string, Paquete>();
}
public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
    
       
    if (!Paquetes.ContainsKey(destinoSeleccionado))
    {
        return true; 
    }
    else
    {
        return false;
    }
}

}