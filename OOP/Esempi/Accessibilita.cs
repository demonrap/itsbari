namespace OOP
{
    /// <summary>
    /// In questo esempio, abbiamo definito una classe MiaClassePublica con un campo e un metodo pubblici.
    /// </summary>
    public class MiaClassePublica
    {
        public string MioCampoPublico;
        public void MioMetodoPublico()
        {
            // Codice del metodo
        }
    }


    /// <summary>
    /// In questo esempio, abbiamo definito una classe MiaClassePrivata con un campo e un metodo privati.
    /// </summary>
    public class MiaClassePrivata
    {
        private string mioCampoPrivato;
        private void mioMetodoPrivato()
        {
            // Codice del metodo
        }
    }

    /// <summary>
    /// In questo esempio, abbiamo definito una classe MiaClasseProtetta con un campo e un metodo protetti 
    /// e una classe MiaClasseDerivata che eredita dalla classe protetta. 
    /// La classe derivata può accedere al campo protetto della classe base.
    /// </summary>
    public class MiaClasseProtetta
    {
        protected string mioCampoProtetto;
        protected void mioMetodoProtetto()
        {
            // Codice del metodo
        }
    }

    public class MiaClasseDerivata : MiaClasseProtetta
    {
        public void MetodoCheUtilizzaIlCampoProtetto()
        {
            mioCampoProtetto = "Nuovo valore"; // Il campo protetto può essere utilizzato dalla classe derivata
        }
    }

    /// <summary>
    /// In questo esempio, abbiamo definito una classe MiaClasseInterna con un campo e un metodo interni, 
    /// ovvero visibili solo all'interno dello stesso assembly.
    /// </summary>
    internal class MiaClasseInterna
    {
        internal string mioCampoInterno;
        internal void mioMetodoInterno()
        {
            // Codice del metodo
        }
    }

    /// <summary>
    /// In questo esempio, abbiamo definito una classe MiaClasseProtettaInterna con un campo e un metodo protetti interni
    /// e una classe MiaClasseDerivataProtettaInterna che eredita dalla classe protetta.
    /// La classe derivata può accedere al campo protetto interno della classe base, ma solo all'interno dello stesso assembly.
    /// </summary>
    public class MiaClasseProtettaInterna
    {
        protected internal string mioCampoProtettoInterno;
        protected internal void mioMetodoProtettoInterno()
        {
            // Codice del metodo
        }
    }

    public class MiaClasseDerivataProtettaInterna : MiaClasseProtettaInterna
    {
        public void MetodoCheUtilizzaIlCampoProtettoInterno()
        {
            mioCampoProtettoInterno = "Nuovo valore"; // Il campo protetto interno può essere utilizzato dalla classe derivata
        }
    }


    public class MiaClassePrivataProtetta
    {
        private protected string mioCampoPrivatoProtetto;
        private protected void mioMetodoPrivatoProtetto()
        {
            // Codice del metodo
        }
    }

    public class MiaClasseDerivataPrivataProtetta : MiaClassePrivataProtetta
    {
        public void MetodoCheUtilizzaIlCampoPrivatoProtetto()
        {
            mioCampoPrivatoProtetto = "Nuovo valore"; // Il campo privato protetto può essere utilizzato dalla classe derivata all

        }
    }
}
