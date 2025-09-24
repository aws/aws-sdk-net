using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DevConfigGenerator;

public class DevConfigWriter
{
    public static void Write(DevConfigFile config, string filePath)
    {
        using var stream = File.OpenWrite(filePath);
        using Utf8JsonWriter writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });

        writer.WriteStartObject();

        if (config.Core != null)
        {
            writer.WriteStartObject("core");

            writer.WriteBoolean("updateMinimum", config.Core.UpdateServiceMinimum);
            ValidateType(config.Core.Type);
            writer.WriteString("type", config.Core.Type);
            writer.WriteStartArray("changeLogMessages");
            foreach (var message in config.Core.Messages)
            {
                writer.WriteStringValue(message);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        if(config.Services.Any())
        {
            writer.WriteStartArray("services");

            foreach (var service in config.Services)
            {
                writer.WriteStartObject();
                writer.WriteString("serviceName", service.Name);
                ValidateType(service.Type);
                writer.WriteString("type", service.Type);

                writer.WriteStartArray("changeLogMessages");
                foreach(var message in service.Messages)
                {
                    writer.WriteStringValue(message);
                }
                writer.WriteEndArray();

                writer.WriteEndObject();
            }

            writer.WriteEndArray();
        }

        if (config.Extensions.Any())
        {
            writer.WriteStartArray("extensions");

            foreach (var extension in config.Extensions)
            {
                writer.WriteStartObject();
                writer.WriteString("extensionName", extension.Name);
                ValidateType(extension.Type);
                writer.WriteString("type", extension.Type);

                writer.WriteStartArray("changeLogMessages");
                foreach (var message in extension.Messages)
                {
                    writer.WriteStringValue(message);
                }
                writer.WriteEndArray();

                writer.WriteEndObject();
            }

            writer.WriteEndArray();
        }

        writer.WriteEndObject();
    }

    private static void ValidateType(string type)
    {
        if (!string.Equals("minor", type, StringComparison.Ordinal) && !string.Equals("patch", type, StringComparison.Ordinal))
            throw new InvalidDataException($"Change type of {type} is invalid. Valid types are 'minor' and 'patch'");
    }
}
