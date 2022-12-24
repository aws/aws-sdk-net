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
        /// The US East (Virginia) regional endpoint.
        /// S3-specific, use for backward compatibility only.
        /// </summary>
        private static readonly RegionEndpoint USEast1Regional = GetEndpoint("us-east-1-regional", "US East (Virginia) regional");

        /// <summary>
        /// The Africa (Cape Town) endpoint.
        /// </summary>
        public static readonly RegionEndpoint AFSouth1 = GetEndpoint("af-south-1", "Africa (Cape Town)");

        /// <summary>
        /// The Asia Pacific (Hong Kong) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APEast1 = GetEndpoint("ap-east-1", "Asia Pacific (Hong Kong)");

        /// <summary>
        /// The Asia Pacific (Tokyo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast1 = GetEndpoint("ap-northeast-1", "Asia Pacific (Tokyo)");

        /// <summary>
        /// The Asia Pacific (Seoul) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast2 = GetEndpoint("ap-northeast-2", "Asia Pacific (Seoul)");

        /// <summary>
        /// The Asia Pacific (Osaka) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APNortheast3 = GetEndpoint("ap-northeast-3", "Asia Pacific (Osaka)");

        /// <summary>
        /// The Asia Pacific (Mumbai) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSouth1 = GetEndpoint("ap-south-1", "Asia Pacific (Mumbai)");

        /// <summary>
        /// The Asia Pacific (Hyderabad) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSouth2 = GetEndpoint("ap-south-2", "Asia Pacific (Hyderabad)");

        /// <summary>
        /// The Asia Pacific (Singapore) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast1 = GetEndpoint("ap-southeast-1", "Asia Pacific (Singapore)");

        /// <summary>
        /// The Asia Pacific (Sydney) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast2 = GetEndpoint("ap-southeast-2", "Asia Pacific (Sydney)");

        /// <summary>
        /// The Asia Pacific (Jakarta) endpoint.
        /// </summary>
        public static readonly RegionEndpoint APSoutheast3 = GetEndpoint("ap-southeast-3", "Asia Pacific (Jakarta)");

        /// <summary>
        /// The Canada (Central) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CACentral1 = GetEndpoint("ca-central-1", "Canada (Central)");

        /// <summary>
        /// The Europe (Frankfurt) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUCentral1 = GetEndpoint("eu-central-1", "Europe (Frankfurt)");

        /// <summary>
        /// The Europe (Zurich) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUCentral2 = GetEndpoint("eu-central-2", "Europe (Zurich)");

        /// <summary>
        /// The Europe (Stockholm) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUNorth1 = GetEndpoint("eu-north-1", "Europe (Stockholm)");

        /// <summary>
        /// The Europe (Milan) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUSouth1 = GetEndpoint("eu-south-1", "Europe (Milan)");

        /// <summary>
        /// The Europe (Spain) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUSouth2 = GetEndpoint("eu-south-2", "Europe (Spain)");

        /// <summary>
        /// The Europe (Ireland) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest1 = GetEndpoint("eu-west-1", "Europe (Ireland)");

        /// <summary>
        /// The Europe (London) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest2 = GetEndpoint("eu-west-2", "Europe (London)");

        /// <summary>
        /// The Europe (Paris) endpoint.
        /// </summary>
        public static readonly RegionEndpoint EUWest3 = GetEndpoint("eu-west-3", "Europe (Paris)");

        /// <summary>
        /// The Middle East (UAE) endpoint.
        /// </summary>
        public static readonly RegionEndpoint MECentral1 = GetEndpoint("me-central-1", "Middle East (UAE)");

        /// <summary>
        /// The Middle East (Bahrain) endpoint.
        /// </summary>
        public static readonly RegionEndpoint MESouth1 = GetEndpoint("me-south-1", "Middle East (Bahrain)");

        /// <summary>
        /// The South America (São Paulo) endpoint.
        /// </summary>
        public static readonly RegionEndpoint SAEast1 = GetEndpoint("sa-east-1", "South America (São Paulo)");

        /// <summary>
        /// The US East (N. Virginia) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USEast1 = GetEndpoint("us-east-1", "US East (N. Virginia)");

        /// <summary>
        /// The US East (Ohio) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USEast2 = GetEndpoint("us-east-2", "US East (Ohio)");

        /// <summary>
        /// The US West (N. California) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest1 = GetEndpoint("us-west-1", "US West (N. California)");

        /// <summary>
        /// The US West (Oregon) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USWest2 = GetEndpoint("us-west-2", "US West (Oregon)");

        /// <summary>
        /// The China (Beijing) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CNNorth1 = GetEndpoint("cn-north-1", "China (Beijing)");

        /// <summary>
        /// The China (Ningxia) endpoint.
        /// </summary>
        public static readonly RegionEndpoint CNNorthWest1 = GetEndpoint("cn-northwest-1", "China (Ningxia)");

        /// <summary>
        /// The AWS GovCloud (US-East) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USGovCloudEast1 = GetEndpoint("us-gov-east-1", "AWS GovCloud (US-East)");

        /// <summary>
        /// The AWS GovCloud (US-West) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USGovCloudWest1 = GetEndpoint("us-gov-west-1", "AWS GovCloud (US-West)");

        /// <summary>
        /// The US ISO East endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsoEast1 = GetEndpoint("us-iso-east-1", "US ISO East");

        /// <summary>
        /// The US ISO WEST endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsoWest1 = GetEndpoint("us-iso-west-1", "US ISO WEST");

        /// <summary>
        /// The US ISOB East (Ohio) endpoint.
        /// </summary>
        public static readonly RegionEndpoint USIsobEast1 = GetEndpoint("us-isob-east-1", "US ISOB East (Ohio)");

    }
}