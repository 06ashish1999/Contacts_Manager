using ContactsManager.Entities;

namespace ContactsManager.ServiceContracts.DTO.Countries;


/// <summary>
/// DTO class used as the return type for most of the countries method
/// </summary>
public class CountryResponse
{
    public Guid? CountryId { get; set; }
    public string? CountryName { get; set; }
}

public static class CountryExtensions
{
    public static CountryResponse ConvertToCountryResponse(this Country country)
    {
        return new CountryResponse()
        {
            CountryId = country.CountryId,
            CountryName = country.CountryName
        };
    }
}
