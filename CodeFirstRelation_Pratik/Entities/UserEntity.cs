namespace CodeFirstRelation_Pratik.Entities
{
    public class UserEntity : BaseEntity 
    {
        public string Username { get; set; }
        public string Email { get; set; }

        // Relational Property

        public List<PostEntity> Posts { get; set; }
    }
}
