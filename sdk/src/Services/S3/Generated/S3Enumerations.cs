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
namespace Amazon.S3
{
    public sealed partial class S3Region
    {
        /// <summary>
        /// Specifies that the S3 Bucket should use the af-south-1 locality.
        /// </summary>
        public static readonly S3Region AFSouth1 = new S3Region("af-south-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-east-1 locality.
        /// </summary>
        public static readonly S3Region APEast1 = new S3Region("ap-east-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-northeast-1 locality.
        /// </summary>
        public static readonly S3Region APNortheast1 = new S3Region("ap-northeast-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-northeast-2 locality.
        /// </summary>
        public static readonly S3Region APNortheast2 = new S3Region("ap-northeast-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-northeast-3 locality.
        /// </summary>
        public static readonly S3Region APNortheast3 = new S3Region("ap-northeast-3");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-south-1 locality.
        /// </summary>
        public static readonly S3Region APSouth1 = new S3Region("ap-south-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-south-2 locality.
        /// </summary>
        public static readonly S3Region APSouth2 = new S3Region("ap-south-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-southeast-1 locality.
        /// </summary>
        public static readonly S3Region APSoutheast1 = new S3Region("ap-southeast-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-southeast-2 locality.
        /// </summary>
        public static readonly S3Region APSoutheast2 = new S3Region("ap-southeast-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ap-southeast-3 locality.
        /// </summary>
        public static readonly S3Region APSoutheast3 = new S3Region("ap-southeast-3");

        /// <summary>
        /// Specifies that the S3 Bucket should use the ca-central-1 locality.
        /// </summary>
        public static readonly S3Region CACentral1 = new S3Region("ca-central-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-central-1 locality.
        /// </summary>
        public static readonly S3Region EUCentral1 = new S3Region("eu-central-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-central-2 locality.
        /// </summary>
        public static readonly S3Region EUCentral2 = new S3Region("eu-central-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-north-1 locality.
        /// </summary>
        public static readonly S3Region EUNorth1 = new S3Region("eu-north-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-south-1 locality.
        /// </summary>
        public static readonly S3Region EUSouth1 = new S3Region("eu-south-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-south-2 locality.
        /// </summary>
        public static readonly S3Region EUSouth2 = new S3Region("eu-south-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-west-1 locality.
        /// </summary>
        public static readonly S3Region EUWest1 = new S3Region("EU");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-west-2 locality.
        /// </summary>
        public static readonly S3Region EUWest2 = new S3Region("eu-west-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the eu-west-3 locality.
        /// </summary>
        public static readonly S3Region EUWest3 = new S3Region("eu-west-3");

        /// <summary>
        /// Specifies that the S3 Bucket should use the me-central-1 locality.
        /// </summary>
        public static readonly S3Region MECentral1 = new S3Region("me-central-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the me-south-1 locality.
        /// </summary>
        public static readonly S3Region MESouth1 = new S3Region("me-south-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the sa-east-1 locality.
        /// </summary>
        public static readonly S3Region SAEast1 = new S3Region("sa-east-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-east-1 locality.
        /// </summary>
        public static readonly S3Region USEast1 = new S3Region("");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-east-2 locality.
        /// </summary>
        public static readonly S3Region USEast2 = new S3Region("us-east-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-west-1 locality.
        /// </summary>
        public static readonly S3Region USWest1 = new S3Region("us-west-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-west-2 locality.
        /// </summary>
        public static readonly S3Region USWest2 = new S3Region("us-west-2");

        /// <summary>
        /// Specifies that the S3 Bucket should use the cn-north-1 locality.
        /// </summary>
        public static readonly S3Region CNNorth1 = new S3Region("cn-north-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the cn-northwest-1 locality.
        /// </summary>
        public static readonly S3Region CNNorthWest1 = new S3Region("cn-northwest-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-gov-east-1 locality.
        /// </summary>
        public static readonly S3Region USGovCloudEast1 = new S3Region("us-gov-east-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-gov-west-1 locality.
        /// </summary>
        public static readonly S3Region USGovCloudWest1 = new S3Region("us-gov-west-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-iso-east-1 locality.
        /// </summary>
        public static readonly S3Region USIsoEast1 = new S3Region("us-iso-east-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-iso-west-1 locality.
        /// </summary>
        public static readonly S3Region USIsoWest1 = new S3Region("us-iso-west-1");

        /// <summary>
        /// Specifies that the S3 Bucket should use the us-isob-east-1 locality.
        /// </summary>
        public static readonly S3Region USIsobEast1 = new S3Region("us-isob-east-1");

    }
}