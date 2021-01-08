/*
  * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
  *
  * Licensed under the Apache License, Version 2.0 (the "License").
  * You may not use this file except in compliance with the License.
  * A copy of the License is located at
  *
  *  http://aws.amazon.com/apache2.0
  *
  * or in the "license" file accompanying this file. This file is distributed
  * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
  * express or implied. See the License for the specific language governing
  * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Util.Internal;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon;
using System.Globalization;

namespace Amazon.SecurityToken
{
    public partial class AmazonSecurityTokenServiceConfig : ClientConfig
    {
        private StsRegionalEndpointsValue? _stsRegionalEndpoints;
        /// <summary>
        /// StsRegionalEndpoints should be set to StsRegionalEndpointsValue.Legacy to resolve to the global
        /// sts endpoint (only for legacy global regions) or StsRegionalEndpointsValue.Regional to resolve to
        /// the regional sts endpoint. The default value for StsRegionalEndpoints is StsRegionalEndpointsValue.Legacy.
        /// 
        /// Get the Sts Regional Flag value
        /// by checking the environment variable
        /// and shared credentials file field
        /// </summary>
        public StsRegionalEndpointsValue StsRegionalEndpoints {
            get {
                if (!this._stsRegionalEndpoints.HasValue)
                {
                    var tempStsRegionalEndpoints = CheckSTSEnvironmentVariable() ?? CheckCredentialsFile();
                    this._stsRegionalEndpoints = tempStsRegionalEndpoints ?? StsRegionalEndpointsValue.Legacy;
                }
                return this._stsRegionalEndpoints.GetValueOrDefault();
            }
            set {
                this._stsRegionalEndpoints = value;
            }
        }

        private const string AwsProfileEnvironmentVariable = "AWS_PROFILE";

        private const string DefaultProfileName = "default";

        private const string AwsStsRegionalEndpointsEnvironmentVariable = "AWS_STS_REGIONAL_ENDPOINTS";

        private const string StsDefaultHostname = "https://sts.amazonaws.com";
        
        private static CredentialProfileStoreChain credentialProfileChain = new CredentialProfileStoreChain();
        
#if BCL35
        private readonly HashSet<RegionEndpoint> legacyGlobalRegions = new HashSet<RegionEndpoint>
         {
             RegionEndpoint.USEast1,
             RegionEndpoint.USEast2,
             RegionEndpoint.USWest1,
             RegionEndpoint.USWest2,
             RegionEndpoint.SAEast1,
             RegionEndpoint.EUWest1,
             RegionEndpoint.EUWest2,
             RegionEndpoint.EUWest3,
             RegionEndpoint.EUNorth1,
             RegionEndpoint.EUCentral1,
             RegionEndpoint.CACentral1,
             RegionEndpoint.APSoutheast1,
             RegionEndpoint.APSoutheast2,
             RegionEndpoint.APSouth1,
             RegionEndpoint.APNortheast1
         };
#else
        private readonly ISet<RegionEndpoint> legacyGlobalRegions = new HashSet<RegionEndpoint>
         {
             RegionEndpoint.USEast1,
             RegionEndpoint.USEast2,
             RegionEndpoint.USWest1,
             RegionEndpoint.USWest2,
             RegionEndpoint.SAEast1,
             RegionEndpoint.EUWest1,
             RegionEndpoint.EUWest2,
             RegionEndpoint.EUWest3,
             RegionEndpoint.EUNorth1,
             RegionEndpoint.EUCentral1,
             RegionEndpoint.CACentral1,
             RegionEndpoint.APSoutheast1,
             RegionEndpoint.APSoutheast2,
             RegionEndpoint.APSouth1,
             RegionEndpoint.APNortheast1
         };
#endif

        /// <summary>
        /// Override DetermineServiceURL to set the url to the 
        /// global endpoint if the sts regional flag is equal to legacy
        /// and the region is a legacy global region
        /// </summary>
        /// <returns> url: A string url for the request </returns>
        public override string DetermineServiceURL()
        {
            if (this.ServiceURL != null)
            {
                return this.ServiceURL;
            }
            // also check if the region is within the list of legacy global regions
            else if (this.StsRegionalEndpoints == StsRegionalEndpointsValue.Legacy && legacyGlobalRegions.Contains(this.RegionEndpoint))
            {
                this.AuthenticationRegion = "us-east-1";
                return StsDefaultHostname;
            }
            else
            {
                return GetUrl(this.RegionEndpoint, this.RegionEndpointServiceName, this.UseHttp, this.UseDualstackEndpoint);
            }
        }

        internal static string GetUrl(RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
        {
            var endpoint = regionEndpoint.GetEndpointForService(regionEndpointServiceName, useDualStack);
            string url = new Uri(string.Format(CultureInfo.InvariantCulture, "{0}{1}", useHttp ? "http://" : "https://", endpoint.Hostname)).AbsoluteUri;
            return url;
        }

        /// <summary>
        /// If the sts regional flag environment variable is set, then first validate that
        /// it is an acceptable value, if not, then throw an error. Then
        /// set the sts regional flag to that value.
        /// </summary>
        /// <returns> _isRegionalFlagSet: a boolean for whether or not
        /// the environment variable set the regional flag </returns>
        private static StsRegionalEndpointsValue? CheckSTSEnvironmentVariable()
        {
            string stsRegionalFlag = Environment.GetEnvironmentVariable(AwsStsRegionalEndpointsEnvironmentVariable);
            if (!string.IsNullOrEmpty(stsRegionalFlag))
            {
#if BCL35
                StsRegionalEndpointsValue? stsRegionalFlagValue = null;
                try
                {
                    stsRegionalFlagValue = (StsRegionalEndpointsValue)Enum.Parse(typeof(StsRegionalEndpointsValue), stsRegionalFlag, true);
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Invalid value for AWS_STS_REGIONAL_ENDPOINTS environment variable. A string regional/legacy is expected.");
                }
#else
                if (!Enum.TryParse<StsRegionalEndpointsValue>(stsRegionalFlag, true, out var stsRegionalFlagValue))
                {
                    throw new InvalidOperationException("Invalid value for AWS_STS_REGIONAL_ENDPOINTS environment variable. A string regional/legacy is expected.");
                }
#endif
                return stsRegionalFlagValue;
            }
            return null;
        }

        /// <summary>
        /// Check the credential file for an sts regional endpoints
        /// option. If it is set within the file, then set the sts
        /// regional flag to that value.
        /// </summary>
        /// <returns> _isRegionalFlagSet: A boolean for whether
        /// or not the credentials file set the regional flag </returns>
        private static StsRegionalEndpointsValue? CheckCredentialsFile()
        {
            CredentialProfile profile;
            var profileName = Environment.GetEnvironmentVariable(AwsProfileEnvironmentVariable) ?? DefaultProfileName;
            credentialProfileChain.TryGetProfile(profileName, out profile);
            return profile?.StsRegionalEndpoints;
        }
    }
}
