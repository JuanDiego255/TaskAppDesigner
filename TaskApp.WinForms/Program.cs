using TaskApp.Application;
using TaskApp.Infrastructure;

namespace TaskApp.WinForms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        var dbPath = Path.Combine(AppContext.BaseDirectory, "taskapp.db");
        var cs = $"Data Source={dbPath};";

        var factory = new SqliteConnectionFactory(cs);
        var db = new DbInitializer(factory);
        db.EnsureCreated();

        var repo = new DapperTaskRepository(factory);
        var userRepo = new DapperUserRepository(factory);

        var service = new TaskService(repo);
        var userService = new UserService(userRepo);

        var vm = new MainViewModel(service);
        var uvm = new UserViewModel(userService);

        System.Windows.Forms.Application.Run(new TaskAppForm(vm, uvm));
    }
}
