using System.Data;
using System.Security.AccessControl;

namespace Constants.StoredProcedure
{
    public static class SolutionDB
    {
        // public const string AddProductWithSubscription = "SP__InsertProductWithSubscription";

        // public const string GetInstitutionProduct = "SP__GetAllInstitutionProducts";

        // public const string UpdateInstitutionProduct = "SP__UpdateInstitutionProduct";

        // public const string DeleteInstitutionProduct="SP__DeleteInstitutionProductByUSRinstitutionID";

        // public const string AddInstituteProduct="SP__InsertInstitutionProduct";

        // public const string GetProductWithSubscriptionByID = "SP__GetProductWithSubscriptionsAndModes";
        // public const string GetProductWithSubscriptionAndModes= "SP__GetAllProductsWithSubscriptionsAndModes";
        // public const string UpdateProductWithSubscription= "SP__UpdateProductWithSubscription";
        // public const string DeleteProductWithSubscription= "SP__DeleteProductWithSubscription";
        public const string GetGroups="SP__GetGroup";

        public const string CreateEntityGroup="SP__CreateEntityGroup";

        public const string GetUserGroup="SP__GetGroupNameByUserId";


    }
}