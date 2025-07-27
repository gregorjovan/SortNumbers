using Microsoft.Extensions.DependencyInjection;
using SortNumbers;
using SortNumbers.Application;
using System.Windows.Forms;

var services = new ServiceCollection();
services.AddSingleton<ISortService, InsertionSortService>();
services.AddTransient<frmMain>();
var provider = services.BuildServiceProvider();

ApplicationConfiguration.Initialize();
Application.Run(provider.GetRequiredService<frmMain>());