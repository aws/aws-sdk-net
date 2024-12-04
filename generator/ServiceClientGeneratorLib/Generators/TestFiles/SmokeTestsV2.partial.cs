using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Json.LitJson;

namespace ServiceClientGenerator.Generators.TestFiles
{
    public partial class SmokeTestsV2
    {
        public string GetRegion(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var region = config["region"];
            if (region == null)
                return null;

            return region.ToJson();
        }

        /// <summary>
        /// Finds the operation in the ServiceModel based on the operation name in the smoke2 json file. The
        /// name in that file does not take any customizations that might have been put in place. So we need to 
        /// compare to the raw ShapeName instead of Name property which has customizations applied.
        /// </summary>
        /// <param name="operationShapeName"></param>
        /// <returns></returns>
        private Operation FindOperation(JsonData testCase)
        {
            var operationShapeName = testCase["operationName"].ToString();
            return this.Config.ServiceModel.Operations.FirstOrDefault(x => string.Equals(x.ShapeName, operationShapeName));
        }
    }
}