using GiftingAPI.Models;

namespace GiftingAPI.Domain
{
    public interface ICatalogPeople
    {
        public Task<PersonItemResponse> AddPersonAsync(PersonCreateRequest request);

        public Task<PersonResponse> GetPeopleAsync(CancellationToken token);
        public Task<PersonItemResponse?> GetPersonByIdAsync(int id);
    }
}
