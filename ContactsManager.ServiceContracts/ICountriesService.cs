using ContactsManager.ServiceContracts.DTO.Countries;

namespace ContactsManager.ServiceContracts;

/// <summary>
/// Interface for the countries service
/// </summary>
public interface ICountriesService
{
    /// <summary>
    /// Method to add a new country
    /// </summary>
    /// <param name="request"> type of CountryAddRequest </param>
    /// <returns> returns type of CountryResponse </returns>
   CountryResponse AddCountry(CountryAddRequest request);
}
