namespace bank_core1.domain.Entites
{
    public class Account_type :IDbEntities
    {
        public int Id { get; set; }
        public string Type_name { get; set; }
        public string Description { get; set; }

    }
}
