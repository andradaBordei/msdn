using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
namespace StudentApp.Service
{
    public class SchoolModule 
    {
        public void ConfigureServices(IServiceCollection services) {
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
