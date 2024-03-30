using System.Runtime.CompilerServices;

namespace Constants.StoredProcedure
{
        public static class UserDB
        {
                public const string CheckUserExistence = "SP__CheckUserExistence__V1";
                public const string RegisterUser = "SP__RegisterUser_V2";

                public const string InsertUrl = "SP__InsertUrl_V1";

                public const string UpdateUserWithUrls = "SP__UpdateUserWithUrls_V1";

                public const string GetUserWithUrls = "SP__GetUserWithUrls";

                public const string UpdateUserAdditionalAddress = "SP__UpdateUserAdditionalAddress";

                public const string GetUsersAddtionalAddress = "SP__GetUserAdditionalAddress";

                public const string CreateFacility = "CreateFacilitySP";

                public const string GetUserIdByEmailAddress = "SP__GetUserByEmailAddress_V1";

                public const string RegisterInstitution = "SP__AddInstitutionv1";
                public const string InstituteAddress = "SP__InstituteAddress";

                public const string GetOwnerShip = "SP__GetOwnerShip";
                public const string CreateInstitutionOwnership = "SP__InstitutionOwnerShip";

                public const string GetGovernance = "SP__GetGovernanceListv1";
                public const string InsertInstituteTempData = "SP__InsertInstituteDataTemp";
                public const string AddInstituteHead = "SP__InstituteHead";
                public const string GetFacility = "SP__GetAllFacilities";

                public const string GetUrlLabels = "SP__GetUrlLabels";
                public const string AddInstituteV3 = "SP__AddInstitution_V3";
                public const string AddInstituteCodeForLyceeEGov = "SP__InsertInsCodeForLyceeEgov";
                public const string AddUserInstitute = "SP__UserInstitute";
                public const string GetManagement = "SP__GetManagement";

                public const string GetAssosication = "SP__GetAssosication";

                public const string GetCategories = "SP__GetCategories";

                public const string GetLevels = "SP__GetLevels";

                public const string GetCourse = "SP__GetCourse";
                public const string GetUserInstitutes = "SP__GetUserInstitutionDetailV1";
                public const string UpdateInstitute="SP_UpdateInstitution_V3";


        }
}