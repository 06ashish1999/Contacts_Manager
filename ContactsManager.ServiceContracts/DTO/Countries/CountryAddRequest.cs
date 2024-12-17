using ContactsManager.Entities;
namespace ContactsManager.ServiceContracts.DTO.Countries;

/// <summary>
/// DTO class for adding a new country
/// </summary>
public class CountryAddRequest
{
    public string? CountryName { get; set; }

    public Country ConvertToCountryDomain()
    {
        return new Country()
        {
            CountryName = this.CountryName
        };
    }
}
