using UserManagement.Debugging;

namespace UserManagement
{
    public class UserManagementConsts
    {
        public const string LocalizationSourceName = "UserManagement";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5d5ea3f9fd394229948ec0f19fa44fa5";
    }
}
