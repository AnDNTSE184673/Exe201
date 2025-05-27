﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMate.Repository.DTOs.UserDTO
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string Email { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string? FullName { get; set; }

        public string? AvatarUrl { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public bool IsGoogle { get; set; }

        public int RoleId { get; set; }

        public DateTime TermsAcceptedAt { get; set; }

        public DateTime? PremiumExpiry { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
