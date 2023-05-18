public static class Info{
    private static List<Pais> ListaPaises = new List<Pais>{};
    private static void InicializarLista(){
        Pais unPais = new Pais("Argentina", "argentina.png", 45000000, new DateTime(1816, 7, 9), "Cataratas");
        ListaPaises.Add(unPais);
        unPais = new Pais("Brasil", "brasil.png", 400000000, new DateTime(1816, 7, 10), "Rio de Janeiro");
        ListaPaises.Add(unPais);
        unPais = new Pais("Uruguay", "uruguay.webp", 4000000, new DateTime(1816, 7, 11), "Montevideo");
        ListaPaises.Add(unPais);
        unPais = new Pais("chile", "chile.png", 400, new DateTime(1816, 7, 12), "Santiago de chile");
        ListaPaises.Add(unPais);
        unPais = new Pais("Costa rica", "CR.png", 2000000, new DateTime(1816, 7, 13), "San Jose");
        ListaPaises.Add(unPais);
    }
    public static List<Pais> ListarPaises()
    {
        if (ListaPaises.Count==0)
        {
            InicializarLista();
        }
        return ListaPaises;
    }
    public static Pais DetallePais(string Nombre)
    {
        Pais PaisBuscado = new Pais();
        foreach (Pais item in ListaPaises)
        {
            if(item.Nombre== Nombre){
                return item;
            }
        }
        return PaisBuscado;
    }
}