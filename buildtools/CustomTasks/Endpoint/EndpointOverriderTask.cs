using System;
using System.IO;

namespace CustomTasks.Endpoint
{
    public class EndpointOverriderTask : BuildTaskBase
    {
        public string EndpointsJsonSourceLocation { get; set; }
        public string EndpointsOverrideLocation { get; set; }

        public override bool Execute()
        {
            if (!File.Exists(EndpointsJsonSourceLocation))
                throw new ArgumentException("Unable to find the endpoints-original.json file.", nameof(EndpointsJsonSourceLocation));

            // We only want to do it on endpoints-original.json files.
            if (Path.GetFileName(EndpointsJsonSourceLocation) != "endpoints-original.json")
                throw new ArgumentException("The specified file is not an endpoints-original.json file.", nameof(EndpointsJsonSourceLocation));

            var overrider = new EndpointOverrider();
            overrider.ApplyOverrides(EndpointsJsonSourceLocation, EndpointsOverrideLocation);
            return true;
        }
    }
}
