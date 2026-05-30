using System;

namespace BMW
{
    class BMW
    {
        private string model = "";
        private int pretEuro;
        private string cutia = "";

        public void setDate (string _model , int _pretEuro , string _cutia)
        {
            model = _model;
            pretEuro = _pretEuro;
            cutia = _cutia;
            
            Console.WriteLine("Model " + _model + " Pret euro " + _pretEuro + " cutia " + _cutia);
        }   
    }
}