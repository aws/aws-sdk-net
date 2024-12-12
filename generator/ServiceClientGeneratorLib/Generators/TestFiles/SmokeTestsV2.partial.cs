using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Json.LitJson;

namespace ServiceClientGenerator.Generators.TestFiles
{
    public partial class SmokeTestsV2
    {
        #region Core Configuration Properties
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

        public string GetUri(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var uri = config["uri"];
            if (uri == null)
                return null;

            return $"\"{uri.ToString()}\"";
        }
        
        #endregion
        
        #region Endpoint Configuration Properties
        public bool? GetUseFipsEndpoint(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var useFips = config["useFips"];
            if (useFips == null)
                return null;

            return (bool)useFips;
        }

        public bool? GetUseDualstackEndpoint(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var useDualstack = config["useDualstack"];
            if (useDualstack == null)
                return null;

            return (bool)useDualstack;
        }
        #endregion

        #region S3-Specific Configuration Properties
        public bool? GetUseAccelerateEndpoint(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var useAccelerate = config["useAccelerate"];
            if (useAccelerate == null)
                return null;

            return (bool)useAccelerate;
        }

        public bool? GetUseGlobalEndpoint(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var useGlobalEndpoint = config["useGlobalEndpoint"];
            if (useGlobalEndpoint == null)
                return null;

            return (bool)useGlobalEndpoint;
        }

        public bool? GetUseArnRegion(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var useArnRegion = config["useArnRegion"];
            if (useArnRegion == null)
                return null;

            return (bool)useArnRegion;
        }

        public bool? GetForcePathStyle(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var forcePathStyle = config["forcePathStyle"];
            if (forcePathStyle == null)
                return null;

            return (bool)forcePathStyle;
        }
        #endregion
        
        #region Authentication Configuration Properties
        public bool? GetUseAccountIdRouting(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var useAccountIdRouting = config["useAccountIdRouting"];
            if (useAccountIdRouting == null)
                return null;

            return (bool)useAccountIdRouting;
        }

        public string[] GetSigV4aRegionSet(JsonData testCase)
        {
            var config = testCase["config"];
            if (config == null)
                return null;

            var sigv4aRegionSet = config["sigv4aRegionSet"];
            if (sigv4aRegionSet == null || !sigv4aRegionSet.IsArray)
                return null;

            var regions = new List<string>();
            foreach (JsonData region in sigv4aRegionSet)
            {
                regions.Add(region.ToString());
            }
            return regions.ToArray();
        }
        #endregion
        
        #region Test Case Properties
        public JsonData GetInput(JsonData testCase)
        {
            return testCase["input"];
        }

        public bool IsSuccessExpected(JsonData testCase)
        {
            var expectation = testCase["expectation"];
            return expectation["success"] != null;
        }

        public string GetExpectedErrorId(JsonData testCase)
        {
            var expectation = testCase["expectation"];
            var failure = expectation["failure"];
            return failure?["errorId"]?.ToString();
        }
        #endregion

        /// <summary>
        /// Finds the operation in the ServiceModel based on the operation name in the smoke2 json file. The
        /// name in that file does not take any customizations that might have been put in place. So we need to 
        /// compare to the raw ShapeName instead of Name property which has customizations applied.
        /// </summary>
        private Operation FindOperation(JsonData testCase)
        {
            var operationShapeName = testCase["operationName"].ToString();
            return this.Config.ServiceModel.Operations.FirstOrDefault(x => string.Equals(x.ShapeName, operationShapeName));
        }
    }
}