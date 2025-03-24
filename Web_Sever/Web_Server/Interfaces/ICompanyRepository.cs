using Web_Server.Models;

namespace Web_Server.Interfaces
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllCompanies();
        Task<Company> GetByIdAsync(int id);
        Task<List<Company>> GetTop4Companies();
        Task<List<Company>> GetCompaniesByName(string companyName);
    }
}
