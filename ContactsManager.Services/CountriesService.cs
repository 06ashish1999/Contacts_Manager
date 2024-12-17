using ContactsManager.Entities;
using ContactsManager.ServiceContracts;
using ContactsManager.ServiceContracts.DTO.Countries;

namespace ContactsManager.Services;

public class CountriesService : ICountriesService
{
    // Data source
    private readonly List<Country> _countries;
    public CountriesService()
    {
        _countries = new List<Country>();
    }

    public CountryResponse AddCountry(CountryAddRequest request)
    {
        // checking whether request is null or not
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }
        // checking whether request.CountryName is null or empty
        if (request.CountryName == null || request.CountryName == string.Empty)
        {
            throw new ArgumentException("CountryName cannot be null or empty", nameof(request));
        }
        // checking whether country name is already present or not
        if (_countries.Where(country => country.CountryName == request.CountryName).Count() > 0)
        {
            throw new ArgumentException("CountryName already exists", nameof(request));
        }

        // converting request to domain
        Country countryObject = request.ConvertToCountryDomain();

        // generate new country id
        countryObject.CountryId = Guid.NewGuid();

        // Adding to the data source
        _countries.Add(countryObject);


        return countryObject.ConvertToCountryResponse();
    }
}
