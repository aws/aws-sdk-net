/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The parameters to request creation of a new bucket.
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
        /// The name of the bucket to be created.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to be created.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The region locality for the bucket.
        /// Default: S3Region.US
        /// </summary>
        /// <remarks>
        /// When set, this will determine where your data will
        /// reside in S3. Refer <see cref="T:Amazon.S3.Model.S3Region"/>
        /// for a list of possible values.
        /// </remarks>
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
        /// Default: S3Region.US
        /// </summary>
        /// <remarks>
        /// When set, this will determine where your data will
        /// reside in S3. Refer <see cref="T:Amazon.S3.Model.S3Region"/>
        /// for a list of possible values.
        /// </remarks>
        /// <param name="bucketRegion">The region locality to use for the new bucket</param>
        /// <returns>the request with the BucketRegion set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutBucketRequest WithBucketRegion(S3Region bucketRegion)
        {
            BucketRegion = bucketRegion;
            return this;
        }

        /// <summary>
        /// The bucket region locality expressed using the name of the region.
        /// When set, this will determine where your data will reside in S3.
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
        /// Sets the bucket region locality using the name of the region.
        /// When set, this will determine where your data will reside in S3.
        /// Valid values: us-east-1, us-west-1, us-west-2, eu-west-1, ap-southeast-1, ap-northeast-1, sa-east-1
        /// </summary>
        /// <param name="bucketRegionName">The name of the region to contain the bucket</param>
        /// <returns>the request with the BucketRegionName set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutBucketRequest WithBucketRegionName(string bucketRegionName)
        {
            BucketRegionName = bucketRegionName;
            return this;
        }

        /// <summary>
        /// If set to true the bucket will be created in the same region as the configuration of the AmazonS3 client.
        /// Default: false.
        /// </summary>
        public bool UseClientRegion
        {
            get { return this.useClientRegion; }
            set
            {
                this.useClientRegion = value;
            }
        }

        /// <summary>
        /// If set to true the bucket will be created in the same region as the configuration of the AmazonS3 client.
        /// </summary>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutBucketRequest WithUseClientRegion(bool useClientRegion)
        {
            this.useClientRegion = useClientRegion;
            return this;
        }

        #endregion

        #region Grants

        /// <summary>
        /// Adds Custom Access Control Lists to the new bucket.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3Grant"/> for information on
        /// S3 Grants.
        /// <remarks>You can use either a canned ACL or specify access permissions explicitly. You cannot do both.</remarks>
        /// </summary>
        /// <param name="grants">One or more S3 Grants.</param>
        /// <returns>The request with the Grants set.</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutBucketRequest WithGrants(params S3Grant[] grants)
        {
            this.Grants.AddRange(grants);
            return this;
        }

        #endregion

        #region CannedACL

        /// <summary>
        /// Applies a canned access control list (ACL) to the new bucket.
        /// </summary>
        /// <remarks>You can use either a canned ACL or specify access permissions explicitly. You cannot do both.</remarks>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// Applies a canned access control list (ACL) to the new bucket.
        /// </summary>
        /// <remarks>You can use either a canned ACL or specify access permissions explicitly. You cannot do both.</remarks>
        /// <param name="acl">The canned ACL to apply; you can specify only one canned ACL in your request</param>
        /// <returns>The request with the Grants set.</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Resets the S3CannedACL previously set in this object.
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion
    }
}
