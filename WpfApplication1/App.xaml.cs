using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private BL.UnitOfWork unitOfWork = new BL.UnitOfWork();

        protected override void OnStartup(StartupEventArgs e)
        {
            var allEmps = unitOfWork.EmpRepository.GetAll() as List<BL.Emp>;
            //Debug.WriteLine("sdfsdfsdfsdfsdfsdf");
            base.OnStartup(e);

        }
    }
}
