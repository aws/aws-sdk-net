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

        writer.WriteEndObject();
    }
}
