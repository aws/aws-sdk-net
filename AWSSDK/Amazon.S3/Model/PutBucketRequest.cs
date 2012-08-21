/*******************************************************************************
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public class PutBucketRequest : S3PutWithACLRequest
    {
        #region Private Member

        private string bucketName;
        private S3Region bucketRegion;
        private string bucketRegionName;
        private bool useClientRegion;
        private S3CannedACL cannedACL;

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
        /// Valid values: us-east-1, us-west-1, us-west-2, eu-west-1, ap-southeast-1, ap-northeast-1, sa-east-1
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
        /// Valid values: us-east-1, us-west-1, us-west-2, eu-west-1, ap-southeast-1, ap-northeast-1, sa-east-1
        /// </summary>
        /// <param name="bucketRegionName">The value that BucketRegionName is set to</param>
        /// <returns>the request with the BucketRegionName set</returns>
        public PutBucketRequest WithBucketRegionName(string bucketRegionName)
        {
            BucketRegionName = bucketRegionName;
            return this;
        }

        /// <summary>
        /// Gets and sets UseClientRegion property.
        /// If set to true the bucket will be created in the region the AmazonS3 client is configured.  This is default to false.
        /// </summary>
        public bool UseClientRegion
        {
            get { return this.useClientRegion; }
            set
            {
                this.useClientRegion = value;
            }
        }

        public PutBucketRequest WithUseClientRegion(bool useClientRegion)
        {
            this.useClientRegion = useClientRegion;
            return this;
        }

        #endregion

        #region Grants

        /// <summary>
        /// Adds Custom Access Control Lists to this request.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3Grant"/> for information on
        /// S3 Grants.
        /// </summary>
        /// <param name="grants">One or more S3 Grants.</param>
        /// <returns>The request with the Grants set.</returns>
        /// <remarks>You can use either a canned ACL or specify access permissions explicitly. You cannot do both.</remarks>
        public PutBucketRequest WithGrants(params S3Grant[] grants)
        {
            this.Grants.AddRange(grants);
            return this;
        }

        #endregion

        #region CannedACL

        /// <summary>
        /// Gets and sets the CannedACL property.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// Adds a canned ACL to this request.
        /// </summary>
        /// <param name="acl">The canned ACL to apply; you can specify only one canned ACL in your request</param>
        /// <returns>The request with the Grants set.</returns>
        /// <remarks>You can use either a canned ACL or specify access permissions explicitly. You cannot do both.</remarks>
        public PutBucketRequest WithCannedACL(S3CannedACL acl)
        {
            this.cannedACL = acl;
            return this;
        }

        /// <summary>
        /// Checks if the S3CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the S3CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (cannedACL != S3CannedACL.NoACL);
        }

        /// <summary>
        /// Resets the S3CannedACL
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion
    }
}