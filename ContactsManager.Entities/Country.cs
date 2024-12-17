﻿namespace ContactsManager.Entities;

/// <summary>
/// Domain model for storing Country information
/// </summary>
public class Country
{
    public Guid CountryId { get; set; }
    public string? CountryName { get; set; }
}
