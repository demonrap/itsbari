using System;

namespace OOP.Esempi
{

    /*
     * In questo esempio, abbiamo creato un oggetto Button chiamato myButton 
     * e abbiamo associato il metodo MyButtonClickHandler() all'evento Click del pulsante. 
     * Abbiamo poi generato l'evento Click chiamando il metodo OnClick() del pulsante.
     * Quando l'evento Click viene generato, il metodo MyButtonClickHandler() viene eseguito 
     * e viene stampato il messaggio "Il pulsante è stato cliccato!".
     */
    public class Button
    {
        // Definizione del delegate che verrà utilizzato per l'evento Click
        public delegate void ClickEventHandler(object sender, EventArgs e);

        // Dichiarazione dell'evento Click
        public event ClickEventHandler Click;

        // Metodo che viene chiamato quando l'utente fa clic sul pulsante
        public virtual void OnClick(EventArgs e)
        {
            // Esecuzione di tutti i metodi associati all'evento Click
            Click?.Invoke(this, e);
        }

        public void MyButtonClickHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Il pulsante è stato cliccato!");
        }
    }


}
