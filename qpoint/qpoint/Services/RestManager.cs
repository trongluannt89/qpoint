using qpoint.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace qpoint.Services
{
    public class RestManager   {
        IRestService restService;
        public RestManager(IRestService service) {
            restService = service;
        }

        public Task<List<Language>> GetTasksAsync() {
            return restService.RefreshLanguageDataAsync();
        }
    }
}
