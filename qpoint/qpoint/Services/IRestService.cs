using qpoint.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace qpoint.Services
{
    public interface IRestService
    {
        Task<List<Language>> RefreshLanguageDataAsync();
        Task SaveTodoItemAsync(Language item, bool isNewItem);
        Task DeleteTodoItemAsync(string id);
    }
}
