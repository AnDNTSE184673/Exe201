﻿using System;
using System.Collections.Generic;

namespace HealthMate.Repository.Models;

public partial class ArticleTagMapping
{
    public int ArticleId { get; set; }

    public int TagId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Article Article { get; set; } = null!;

    public virtual Tag Tag { get; set; } = null!;
}
