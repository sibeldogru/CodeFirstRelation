﻿namespace CodeFirstRelation_Pratik.Entities
{
    public class PostEntity : BaseEntity 
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public int UserId { get; set; }

        // Relational Property

        public UserEntity User { get; set; }
    }
}
