using System.Text;

namespace DevConfigGenerator;

public class DevConfigFile
{
    public CoreChange? Core { get; set; }

    public List<Service> Services { get; } = new List<Service>();

    public List<Extension> Extensions { get; } = new List<Extension>();
}

public class CoreChange
{
    public List<string> Messages { get; } = new List<string>();

    public bool UpdateServiceMinimum { get; set; }

    public string Type { get; set; } = "patch";

    public string FormattedNameColumn()
    {
        var sb = new StringBuilder();
        sb.AppendLine("AWSSDK.Core");
        sb.AppendLine($"Update service minimums: [green]{UpdateServiceMinimum}[/]");
        return sb.ToString();
    }

    public string FormattedMessagesColumn()
    {
        var sb = new StringBuilder();
        foreach (var message in Messages)
        {
            sb.AppendLine(message.ToString());
        }
        return sb.ToString();
    }
}

public class Service
{
    public required string Name { get; init; }

    public List<string> Messages { get; } = new List<string>();

    public string Type { get; set; } = "patch";


    public string FormattedNameColumn()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"AWSSDK.{Name}");
        return sb.ToString();
    }

    public string FormattedMessagesColumn()
    {
        var sb = new StringBuilder();
        foreach (var message in Messages)
        {
            sb.AppendLine(message.ToString());
        }
        return sb.ToString();
    }
}

public class Extension
{
    public required string Name { get; init; }

    public List<string> Messages { get; } = new List<string>();

    public string Type { get; set; } = "patch";

    public string FormattedNameColumn()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"AWSSDK.{Name}");
        return sb.ToString();
    }

    public string FormattedMessagesColumn()
    {
        var sb = new StringBuilder();
        foreach (var message in Messages)
        {
            sb.AppendLine(message.ToString());
        }
        return sb.ToString();
    }
}