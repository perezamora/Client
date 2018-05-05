using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AppMVCStudent.Common.Logic.Logger;
using AppMVCStudent.Common.Logic.Model;
using Newtonsoft.Json;

namespace AppMVCStudent.Business.Logic
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _client;
        private readonly ILogger _log;
        private readonly string BaseUrl;

        public StudentService(HttpClient client, ILogger log)
        {
            //this._client = ConfigurationService.InitClient(client);
            this._client = client;
            this.BaseUrl = System.Configuration.ConfigurationManager.AppSettings[Resources.Config.basendpoint];
            this.InitializeWSR();
            this._log = log;
        }

        private void InitializeWSR()
        {
            this._client.BaseAddress = new Uri(this.BaseUrl);
            this._client.DefaultRequestHeaders.Accept.Clear();
            this._client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Student> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAll()
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + ":" + _client.BaseAddress + Resources.Config.apiGetAll);

            try
            {
                var response = await _client.GetAsync(Resources.Config.apiGetAll);
                response.EnsureSuccessStatusCode();
                using (var content = response.Content)
                {
                    //var result = await content.ReadAsAsync<List<Student>>();
                    var result = await content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Student>>(result);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Student> Set(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
