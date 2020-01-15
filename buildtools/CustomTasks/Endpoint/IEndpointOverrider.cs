namespace CustomTasks.Endpoint
{
    /// <summary>
    /// Endpoint overrider: will override the endpoints.json file and remove/add endpoints
    /// Based on a json input file for addition and removal
    /// </summary>
    interface IEndpointOverrider
    {
        /// <summary>
        /// Applies overrides to an endpoints.json file
        /// </summary>
        /// <param name="endpointsJsonSourceFilePath">The endpoints.json source location</param>
        /// <param name="endpointsOverrideFilePath">The path to the endpoints override json file</param>
        /// <returns>String: the new endpoints.json input text.</returns>
        string ApplyOverrides(string endpointsJsonSourceFilePath, string endpointsOverrideFilePath);
    }
}
