using Spectre.Console;
using DevConfigGenerator;
using System.Runtime.InteropServices.Marshalling;

var devConfig = new DevConfigFile();

try
{
    while (true)
    {
        if (devConfig.Core != null || devConfig.Services.Any() || devConfig.Extensions.Any())
        {
            var table = new Table();
            table.ShowRowSeparators = true;
            table.AddColumn("Package");
            table.AddColumn("Type");
            table.AddColumn("Change Messages");

            if (devConfig.Core != null)
            {
                table.AddRow(devConfig.Core.FormattedNameColumn(), devConfig.Core.Type, devConfig.Core.FormattedMessagesColumn());
            }

            foreach (var service in devConfig.Services)
            {
                table.AddRow(service.FormattedNameColumn(), service.Type, service.FormattedMessagesColumn());
            }

            foreach (var extension in devConfig.Extensions)
            {
                table.AddRow(extension.FormattedNameColumn(), extension.Type, extension.FormattedMessagesColumn());
            }

            AnsiConsole.Write(table);
        }

        var changeType = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("What type of change was made?")
                .AddChoices(new[] {
                "Core", "Generator", "Service", "Extension", "Save DevConfigFile", "Exit Without Saving"
                }));

        switch (changeType)
        {
            case "Core":
                CoreChange();
                break;
            case "Generator":
                GeneratorChange();
                break;
            case "Service":
                ServiceChange();
                break;
            case "Extension":
                ExtensionChange();
                break;
            case "Save DevConfigFile":
                WriteDevConfigFile();
                return;
            case "Exit Without Saving":
                return;
        }
    }

}
catch (Exception e)
{
    Console.WriteLine("Unhandled exception while generating dev config file");
    Console.WriteLine(e.Message);
}

void WriteDevConfigFile()
{
    if (devConfig.Core == null && !devConfig.Services.Any())
    {
        AnsiConsole.Markup("[yellow]Skipped writing dev config since the config is empty[/]\n");
    }

    var devConfigDirectory = Path.Combine(FindRepoRoot(), "generator", ".DevConfigs");
    if (!Directory.Exists(devConfigDirectory))
    {
        Directory.CreateDirectory(devConfigDirectory);
    }

    var devConfigFilePath = Path.Combine(devConfigDirectory, Guid.NewGuid().ToString() + ".json");
    DevConfigWriter.Write(devConfig, devConfigFilePath);

    AnsiConsole.Markup($"DevConfig file written to: [green]{devConfigFilePath}[/]\n");
    AnsiConsole.WriteLine(File.ReadAllText(devConfigFilePath));
}


void CoreChange()
{
    var change = AnsiConsole.Prompt(new TextPrompt<string>("Enter the change message for the [green]core[/] change:"));

    var newCoreConfig = false;
    if (devConfig.Core == null)
    {
        newCoreConfig = true;
        devConfig.Core = new CoreChange();
    }

    devConfig.Core.Messages.Add(change);

    devConfig.Core.Type = AskChangeType(devConfig.Core.Type);

    var textPrompt = new TextPrompt<bool>("Should service packages be updated to use new Core?")
            .AddChoice(true)
            .AddChoice(false)
            .WithConverter(choice => choice ? "y" : "n");

    // If added a second change message to core then default the update service minimum to the value choosen for the previous entry.
    if (!newCoreConfig)
    {
        textPrompt.DefaultValue(devConfig.Core.UpdateServiceMinimum);
    }

    var updateServiceMinimum = AnsiConsole.Prompt(textPrompt);

    devConfig.Core.UpdateServiceMinimum = updateServiceMinimum;
}

void GeneratorChange()
{
    AnsiConsole.Markup("Generator changes are saved as [green]Core changes[/] with update service minimum set to [green]true[/].\n");
    var change = AnsiConsole.Prompt(new TextPrompt<string>("Enter the change message for the [green]generator[/] change:"));

    if (devConfig.Core == null)
    {
        devConfig.Core = new CoreChange();
    }

    devConfig.Core.Messages.Add(change);
    devConfig.Core.UpdateServiceMinimum = true;

    devConfig.Core.Type = AskChangeType(devConfig.Core.Type);
}

void ServiceChange()
{
    var serviceNames = new List<string>();
    foreach(var serviceDirectory in Directory.GetDirectories(Path.Combine(FindRepoRoot(), "sdk", "src", "Services")))
    {
        serviceNames.Add(new DirectoryInfo(serviceDirectory).Name);
    }

    var searchQuery = AnsiConsole.Ask<string>("What service was changed (The name should match directory name in the sdk/src/Services parent directory)?");


    string serviceName;
    if (serviceNames.FirstOrDefault(x => string.Equals(x, searchQuery, StringComparison.OrdinalIgnoreCase)) != null)
    {
        serviceName = serviceNames.FirstOrDefault(x => string.Equals(x, searchQuery, StringComparison.OrdinalIgnoreCase))!;
    }
    else
    {
        var topMatches = FuzzySharp.Process.ExtractTop(searchQuery, serviceNames)
                                .Select(result => result.Value)
                                .ToList();

        serviceName = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .PageSize(10)
                .AddChoices(topMatches));
    }


    var service = devConfig.Services.FirstOrDefault(x => x.Name == serviceName);

    // Check to see if this is the first change log entry for this service being added to the dev config.
    // If so add the service to the list of services being changed.
    if (service == null)
    {
        service = new Service { Name = serviceName };
        devConfig.Services.Add(service);
    }

    var change = AnsiConsole.Prompt(new TextPrompt<string>($"Enter the change message for [green]{serviceName}[/] change:"));
    service.Messages.Add(change);

    service.Type = AskChangeType(service.Type);
}

void ExtensionChange()
{
    var extensionsNames = new List<string>();
    foreach (var extensionDirectory in Directory.GetDirectories(Path.Combine(FindRepoRoot(), "extensions", "src")))
    {
        if (!Directory.GetFiles(extensionDirectory, "*.nuspec").Any())
        {
            continue;
        }
        extensionsNames.Add(new DirectoryInfo(extensionDirectory).Name.Replace("AWSSDK.", string.Empty));
    }

    var extensionName = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .AddChoices(extensionsNames));

    var extension = devConfig.Extensions.FirstOrDefault(x => x.Name == extensionName);

    // Check to see if this is the first change log entry for this extension being added to the dev config.
    // If so add the extension to the list of extensions being changed.
    if (extension == null)
    {
        extension = new Extension { Name = extensionName };
        devConfig.Extensions.Add(extension);
    }


    var change = AnsiConsole.Prompt(new TextPrompt<string>($"Enter the change message for [green]{extensionName}[/] change:"));
    extension.Messages.Add(change);

    extension.Type = AskChangeType(extension.Type);
}

static string AskChangeType(string defaultValue)
{
    string[] choices;
    if (defaultValue == "patch")
    {
        choices = new[] { "patch", "minor" };
    }
    else
    {
        choices = new[] { "minor", "patch" };
    }

    var changeType = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Type of change?")
            .AddChoices(choices));

    return changeType;
}

static string FindRepoRoot()
{
    var directory = Directory.GetParent(typeof(Program).Assembly.Location)?.FullName;
    while(directory != null)
    {
        if (File.Exists(Path.Combine(directory, "SDK.CHANGELOG.MD")))
        {
            return directory;
        }

        directory = Directory.GetParent(directory)?.FullName;
    }

    throw new ApplicationException("Failed to resolve SDK's repository root. The tool must be run within the SDK's repository");
}