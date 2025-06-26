namespace Tenant.Domain.Tenant.Dtos
{
    public class AddPolicyTenantDto
    {
        /// <summary>
        /// نام سیاست
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  روی چه چیزی اعمال بشه؟ مثلا "Orders", "Users"
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// مجاز به چه کاری؟ مثلا "Read", "Write", "Delete"
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        ///  شرط خاص مثلا "OnlyOwner" یا "AdminOnly"
        /// </summary>
        public string Condition { get; set; }
    }
}
