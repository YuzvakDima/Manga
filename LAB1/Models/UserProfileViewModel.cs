﻿namespace LAB1.Models
{
    public class UserProfileViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
        public List<Bookmark> Bookmarks { get; set; } // Список закладок користувача
    }
}
