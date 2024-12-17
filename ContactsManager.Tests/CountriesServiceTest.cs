using ContactsManager.ServiceContracts;
using ContactsManager.ServiceContracts.DTO.Countries;
using ContactsManager.Services;

namespace ContactsManager.Tests;

public class CountriesServiceTest
{
    private readonly ICountriesService _countriesService;
    public CountriesServiceTest()
    {
        _countriesService = new CountriesService();
    }

    // 1. When CountryAddRequest is null, it should throw ArgumentNullException
    [Fact]
    public void AddCountry_WhenCountryAddRequestIsNull()
    {
        // Arrange
        CountryAddRequest? request = null;

        // Arrange
        Assert.Throws<ArgumentNullException>(() =>
        {
            // Act
            _countriesService.AddCountry(request);
        });
    }
    // 2. When CountryName is null or empty, it should throw ArgumentException
    [Fact]
    public void AddCountry_WhenCountryNameIsNullOrEmpty()
    {
        // Arrange
        CountryAddRequest request = new CountryAddRequest()
        {
            CountryName = string.Empty
        };

        // Arrange
        Assert.Throws<ArgumentException>(() =>
        {
            // Act
            _countriesService.AddCountry(request);
        });
    }
    // 3. when CountryName is Duplicate, it should throw ArgumentException
    [Fact]
    public void AddCountry_WhenCountryNameIsDuplicate()
    {
        // Arrange
        CountryAddRequest request = new CountryAddRequest() { CountryName = "India" };
        

        // Assert
        Assert.Throws<ArgumentException>(() =>
        {
            // Act
            _countriesService.AddCountry(request);
            _countriesService.AddCountry(request);
        });
    }
    // 4. When CountryName is valid, it should return CountryResponse
    [Fact]
    public void AddCountry_WhenCountryNameIsValid()
    {
        // Arrange
        CountryAddRequest request = new CountryAddRequest() { CountryName = "India" };

        // Act
        CountryResponse response = _countriesService.AddCountry(request);

        // Assert
        Assert.True(response.CountryId != Guid.Empty);
    }
}
