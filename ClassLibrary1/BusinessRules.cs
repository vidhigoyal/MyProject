using System;

namespace ClassBusinessRule
{
    public class BusinessRules
    {

       public ProductTypes enumProductTypes = ProductTypes.Undefined;
       public SubProductTypes enumSubProductTypes = SubProductTypes.Undefined;
        public void ApplyRules(Product objProduct)
        {
                switch (objProduct.ProductType)
                {
                case ProductTypes.Physical:
                    // generate a packing slip for shipping
                    GeneratePackingSlip(objProduct);
                    ApplySubProductTypeRules(objProduct);
                    GenerateCommisionPayment(objProduct);
                    break;


                case ProductTypes.Membership:
                    ActivateMembership(objProduct);
                    EmailMember(objProduct);
                    break;

                case ProductTypes.UpgradeMembership:
                    UpgradeMembership(objProduct);
                    EmailMember(objProduct);
                    break;

                default:
                    //do nothing
                    break;

            }

        }

        private void GeneratePackingSlip(Product objProduct)
        {
            // to do
            //code for unit test
            enumProductTypes = ProductTypes.Physical;
        }

        private void GenerateDuplicatePackingSlip(Product objProduct)
        {
            // to do
            enumSubProductTypes = SubProductTypes.Book;
        }

        private void ActivateMembership(Product objProduct)
        {
            // to do
            //code for unit test
            enumProductTypes = ProductTypes.Membership;
        }

        private void UpgradeMembership(Product objProduct)
        {
            // to do
        }

        private void EmailMember(Product objProduct)
        {
            // to do
        }

        private void GenerateCommisionPayment(Product objProduct)
        {
            // to do
        }
        private void AddOffer(Product objProduct)
        {
            // to do
        }


        private void ApplySubProductTypeRules(Product objProduct)
        {
            switch (objProduct.SubProductType)
            {
                case SubProductTypes.Book:
                    // generate a duplicate packing slip for the royality department
                    GenerateDuplicatePackingSlip(objProduct);
                    break;
                case SubProductTypes.LearningToSki:
                    //add firstAid video also
                    AddOffer(objProduct);
                    break;
                default:
                    //do nothing
                    break;

            }
        }

    }
}
