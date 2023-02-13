namespace Calculator
{
    public class TaxData
    {
        private double ProvincialTaxWithheld;
        private double FederalTaxWithheld;
        private double DependantDeduction;
        private double TotalWithheld;
        private double TotalTakeHome;
        
        public TaxData (double ProvincialTaxWithheld, double FederalTaxWithheld, double DependantDeduction, double TotalWithheld, double TotalTakeHome)
        {
            this.ProvincialTaxWithheld = ProvincialTaxWithheld;
            this.FederalTaxWithheld = FederalTaxWithheld;
            this.DependantDeduction = DependantDeduction;
            this.TotalWithheld = TotalWithheld;
            this.TotalTakeHome = TotalTakeHome;
        }
    }
}