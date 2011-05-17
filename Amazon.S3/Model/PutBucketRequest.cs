/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2006-03-01
 *
 */

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The PutBucketRequest contains the parameters used for the PutBucket operation.
    /// The BucketRegion parameter is used if you wish to specify the bucket locality.
    /// <br />Required Parameters: BucketName
    /// <br />Optional Parameters: BucketRegion, Default - S3Region.US
    /// </summary>
    public class PutBucketRequest : S3Request
    {
        #region Private Member

        private string bucketName;
        private S3Region bucketRegion;
        private string bucketRegionName;

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the S3 Bucket that will be created by this request.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
        public PutBucketRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

        #region BucketRegion

        /// <summary>
        /// Gets and sets the BucketRegion property.
        /// Refer <see cref="T:Amazon.S3.Model.S3Region"/>
        /// for a list of possible values.
        /// Default: S3Region.US
        /// <see cref="T:Amazon.S3.Model.S3Region" />
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketRegion")]
        public S3Region BucketRegion
        {
            get { return this.bucketRegion; }
            set
            {
                if (value >= S3Region.US &&
                    value <= S3Region.APN1)
                {
                    this.bucketRegion = value;
                }
            }
        }

        /// <summary>
        /// Sets the BucketRegion property for this request.
        /// When set, this will determine where your data will
        /// reside in S3. Refer <see cref="T:Amazon.S3.Model.S3Region"/>
        /// for a list of possible values.
        /// </summary>
        /// <param name="bucketRegion">The value that BucketRegion is set to</param>
        /// <returns>the request with the BucketRegion set</returns>
        public PutBucketRequest WithBucketRegion(S3Region bucketRegion)
        {
            BucketRegion = bucketRegion;
            return this;
        }

        /// <summary>
        /// Alternative to setting bucket region by using the region's name.
        /// When set, this will determine where your data will
        /// reside in S3.
        /// Valid values: us-east-1, us-west-1, eu-west-1, ap-southeast-1, ap-northeast-1
        /// </summary>
        public string BucketRegionName
        {
            get { return this.bucketRegionName; }
            set
            {
                this.bucketRegionName = value;
            }
        }

        /// <summary>
        /// Alternative to setting bucket region by using the region's name.
        /// When set, this will determine where your data will
        /// reside in S3.
        /// Valid values: us-east-1, us-west-1, eu-west-1, ap-southeast-1, ap-northeast-1
        /// </summary>
        /// <param name="bucketRegionName">The value that BucketRegionName is set to</param>
        /// <returns>the request with the BucketRegionName set</returns>
        public PutBucketRequest WithBucketRegionName(string bucketRegionName)
        {
            BucketRegionName = bucketRegionName;
            return this;
        }

        #endregion
    }
}