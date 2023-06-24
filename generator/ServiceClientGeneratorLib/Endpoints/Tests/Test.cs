using Json.LitJson;
using System.Collections.Generic;

namespace ServiceClientGenerator.Endpoints.Tests
{
    /// <summary>
    /// Object model for Test.
    /// </summary>
    public class Test
    {
        public string documentation { get; set; }
        public Dictionary<string, JsonData> @params { get; set; }
        public string[] tags { get; set; }
        public Expectation expect { get; set; }
        public List<JsonData> operationInputs { get; set; }
    }
}
