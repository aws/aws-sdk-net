/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
namespace Amazon
{
    /// <summary>
    /// This class contains region information used to lazily compute the service endpoints. The static constants representing the 
    /// regions can be used while constructing the AWS client instead of looking up the exact endpoint URL.
    /// </summary>
    public partial class RegionEndpoint
    {

        /// <summary>
        /// The Africa (Cape Town) endpoint.
        /// </summary>
        public static readonly RegionEndpoint AFSouth1 = GetRegionEndpoint("af-south-1", "Africa (Cape Town)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Hong Kong) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APEast1 = GetRegionEndpoint("ap-east-1", "Asia Pacific (Hong Kong)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Taipei) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APEast2 = GetRegionEndpoint("ap-east-2", "Asia Pacific (Taipei)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Tokyo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast1 = GetRegionEndpoint("ap-northeast-1", "Asia Pacific (Tokyo)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Seoul) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast2 = GetRegionEndpoint("ap-northeast-2", "Asia Pacific (Seoul)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Osaka) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast3 = GetRegionEndpoint("ap-northeast-3", "Asia Pacific (Osaka)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Mumbai) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSouth1 = GetRegionEndpoint("ap-south-1", "Asia Pacific (Mumbai)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Hyderabad) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSouth2 = GetRegionEndpoint("ap-south-2", "Asia Pacific (Hyderabad)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Singapore) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast1 = GetRegionEndpoint("ap-southeast-1", "Asia Pacific (Singapore)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Sydney) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast2 = GetRegionEndpoint("ap-southeast-2", "Asia Pacific (Sydney)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Jakarta) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast3 = GetRegionEndpoint("ap-southeast-3", "Asia Pacific (Jakarta)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Melbourne) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast4 = GetRegionEndpoint("ap-southeast-4", "Asia Pacific (Melbourne)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Malaysia) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast5 = GetRegionEndpoint("ap-southeast-5", "Asia Pacific (Malaysia)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (New Zealand) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast6 = GetRegionEndpoint("ap-southeast-6", "Asia Pacific (New Zealand)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Asia Pacific (Thailand) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast7 = GetRegionEndpoint("ap-southeast-7", "Asia Pacific (Thailand)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Canada (Central) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CACentral1 = GetRegionEndpoint("ca-central-1", "Canada (Central)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Canada West (Calgary) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CAWest1 = GetRegionEndpoint("ca-west-1", "Canada West (Calgary)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (Frankfurt) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUCentral1 = GetRegionEndpoint("eu-central-1", "Europe (Frankfurt)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (Zurich) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUCentral2 = GetRegionEndpoint("eu-central-2", "Europe (Zurich)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (Stockholm) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUNorth1 = GetRegionEndpoint("eu-north-1", "Europe (Stockholm)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (Milan) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUSouth1 = GetRegionEndpoint("eu-south-1", "Europe (Milan)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (Spain) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUSouth2 = GetRegionEndpoint("eu-south-2", "Europe (Spain)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (Ireland) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest1 = GetRegionEndpoint("eu-west-1", "Europe (Ireland)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (London) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest2 = GetRegionEndpoint("eu-west-2", "Europe (London)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Europe (Paris) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest3 = GetRegionEndpoint("eu-west-3", "Europe (Paris)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Israel (Tel Aviv) endpoint.
        /// </summary>
        public static readonly RegionEndpoint ILCentral1 = GetRegionEndpoint("il-central-1", "Israel (Tel Aviv)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Middle East (UAE) endpoint.
        /// </summary>
        public static readonly RegionEndpoint MECentral1 = GetRegionEndpoint("me-central-1", "Middle East (UAE)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Middle East (Bahrain) endpoint.
        /// </summary>
        public static readonly RegionEndpoint MESouth1 = GetRegionEndpoint("me-south-1", "Middle East (Bahrain)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The Mexico (Central) endpoint.
        /// </summary>
        public static readonly RegionEndpoint MXCentral1 = GetRegionEndpoint("mx-central-1", "Mexico (Central)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The South America (Sao Paulo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint SAEast1 = GetRegionEndpoint("sa-east-1", "South America (Sao Paulo)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US East (Virginia) regional endpoint.
        /// S3-specific, use for backward compatibility only.
        /// </summary>
        private static readonly RegionEndpoint USEast1Regional = GetRegionEndpoint("us-east-1-regional", "US East (Virginia) regional", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US East (N. Virginia) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USEast1 = GetRegionEndpoint("us-east-1", "US East (N. Virginia)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US East (Ohio) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USEast2 = GetRegionEndpoint("us-east-2", "US East (Ohio)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US West (N. California) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest1 = GetRegionEndpoint("us-west-1", "US West (N. California)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US West (Oregon) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest2 = GetRegionEndpoint("us-west-2", "US West (Oregon)", "aws", "amazonaws.com", @"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The China (Beijing) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CNNorth1 = GetRegionEndpoint("cn-north-1", "China (Beijing)", "aws-cn", "amazonaws.com.cn", @"^cn\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The China (Ningxia) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CNNorthWest1 = GetRegionEndpoint("cn-northwest-1", "China (Ningxia)", "aws-cn", "amazonaws.com.cn", @"^cn\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The EU (Germany) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUSCDeEast1 = GetRegionEndpoint("eusc-de-east-1", "EU (Germany)", "aws-eusc", "amazonaws.eu", @"^eusc\-(de)\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US ISO East endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsoEast1 = GetRegionEndpoint("us-iso-east-1", "US ISO East", "aws-iso", "c2s.ic.gov", @"^us\-iso\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US ISO WEST endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsoWest1 = GetRegionEndpoint("us-iso-west-1", "US ISO WEST", "aws-iso", "c2s.ic.gov", @"^us\-iso\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US ISOB East (Ohio) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsobEast1 = GetRegionEndpoint("us-isob-east-1", "US ISOB East (Ohio)", "aws-iso-b", "sc2s.sgov.gov", @"^us\-isob\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The EU ISOE West endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUIsoeWest1 = GetRegionEndpoint("eu-isoe-west-1", "EU ISOE West", "aws-iso-e", "cloud.adc-e.uk", @"^eu\-isoe\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US ISOF EAST endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsofEast1 = GetRegionEndpoint("us-isof-east-1", "US ISOF EAST", "aws-iso-f", "csp.hci.ic.gov", @"^us\-isof\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The US ISOF SOUTH endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsofSouth1 = GetRegionEndpoint("us-isof-south-1", "US ISOF SOUTH", "aws-iso-f", "csp.hci.ic.gov", @"^us\-isof\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The AWS GovCloud (US-East) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USGovCloudEast1 = GetRegionEndpoint("us-gov-east-1", "AWS GovCloud (US-East)", "aws-us-gov", "amazonaws.com", @"^us\-gov\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");

        /// <summary>
        /// The AWS GovCloud (US-West) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USGovCloudWest1 = GetRegionEndpoint("us-gov-west-1", "AWS GovCloud (US-West)", "aws-us-gov", "amazonaws.com", @"^us\-gov\-\w+\-\d+$", "{service}.{region}.{dnsSuffix}");
    }
}