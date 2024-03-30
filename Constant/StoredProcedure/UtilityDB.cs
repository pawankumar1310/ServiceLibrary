namespace Constants.StoredProcedure
{
    public static class UtilityDB
    {
        public const string GetPlaceInfoByZipCode = "SP__GetPlaceInformationByZipCodeID";
        public const string GetZipCodeIDByZipCode="spGetZipCodeIdByCode";
        public const string GetAllPhoneCodes = "SP__GetAllPhoneCodes";
        public const string GetPhoneCode = "SP__GetPhoneCode";


        public const string GetAllZipCodes = "SP__GetAllZipCodes";
        public const string GetZipCode = "SP__GetZipCode";
        public const string GetZipCodeDetails = "SP__GetZipCodeDetails";
        public const string GetZipCodesByCity = "SP__GetZipCodesByCity";
        public const string GetZipCodesByState = "SP__GetZipCodesByState";
        public const string GetZipCodesByCountry = "SP__GetZipCodesByCountry";


        public const string GetCity = "SP__GetCity";
        public const string GetAllCities = "SP__GetAllCities";
        public const string GetCitiesByState = "SP__GetCitiesByState";
        public const string GetCitiesByCountry = "SP__GetCitiesByCountry";


        public const string GetStates = "SP__GetStates";
        public const string GetAllStates = "SP__GetAllStates";


        public const string GetCountry = "SP__GetCountry";
        public const string GetAllCountries = "SP__GetAllCountries";


        public const string GetAllTableDetails = "SP__GetAllTableDetails";
        public const string GetTableDetailsByID = "SP__GetTableDetailsByID";
        public const string GetTableDetailsByName = "SP__GetTableDetailsByName";
    }
}