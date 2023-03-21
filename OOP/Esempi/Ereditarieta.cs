using System;

namespace OOP
{

    public class ParametroBase
    {
        private int _parametro;
        public ParametroBase(int parametro)
        {
            this._parametro = parametro;
        }

        public virtual int MioMetodo()
        {
            return this._parametro;
        }
    }

    public class ParametroDerivato : ParametroBase
    {
        public ParametroDerivato(int parametro) : base(parametro)
        {
        }
    }

    /// <summary>
    /// Ereditarietà
    /// </summary>
    public class ClasseBase
    {
        //membri della classe

        private int _value = 10; //field (campo)

        //classe innestata (nested)
        public class ClasseDerivata : ClasseBase
        {
            public int GetValue() //funzione (comportamento)
            {
                return _value;
            }
        }

    }

    public class ClasseCheIstanza 
    {
        public void StampaValore() => Console.WriteLine(new ClasseBase.ClasseDerivata().GetValue());
    }


    /// <summary>
    /// Anagrafica base
    /// </summary>
    public class AnagraficaBase
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
    }

    public class Clienti : AnagraficaBase {
        public string Email { get; set; }
    }


    public class AnagraficaCliente
    {
        public void StampaCliente(Clienti cliente) => Console.WriteLine($"Cliente {cliente.Nome} {cliente.Cognome} email {cliente.Email}");
    }




    
}
