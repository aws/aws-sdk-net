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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    public partial class PutBucketRequest : PutWithACLRequest
    {
        private S3Region bucketRegion;
        private string bucketRegionName;
        private bool useClientRegion = true;

        /// <summary>
        /// If set to true the bucket will be created in the same region
        /// as the configuration of the AmazonS3 client.
        /// If PutBucketRequest.BucketRegion or PutBucketRequest.BucketRegionName are set they take precedence over
        /// this property.
        /// Default: true.
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
        /// The region locality for the bucket.
        /// </summary>
        /// <remarks>
        /// When set, this will determine where your data will
        /// reside in S3. Refer <see cref="T:Amazon.S3.S3Region"/>
        /// for a list of possible values.
        /// This should not be set at the same time as <see cref="BucketRegionName"/>
        /// If it is, then whichever is set last will be the region where the bucket is created.
        /// </remarks>
        public S3Region BucketRegion
        {
            get 
            {
                return bucketRegion;
            } 
            set 
            { 
                this.bucketRegion = value;
                if (this.bucketRegion != null && !string.IsNullOrEmpty(bucketRegion.Value))
                {
                    if (this._putBucketConfiguration == null)
                    {
                        _putBucketConfiguration = new PutBucketConfiguration();
                        _putBucketConfiguration.LocationConstraint = bucketRegion.Value;
                    }
                }
            }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this.bucketRegion != null;
        }

        /// <summary>
        /// The bucket region locality expressed using the name of the region.
        /// When set, this will determine where your data will reside in S3.
        /// Valid values: us-east-1, us-west-1, us-west-2, eu-west-1, ap-southeast-1, ap-southeast-2, ap-northeast-1, sa-east-1
        /// This should not be set at the same time as <see cref="BucketRegion"/>. If both are set, whichever was set last
        /// will take precedence.
        /// </summary>
        public string BucketRegionName
        {
            get 
            {
                return bucketRegionName;
            }
            set
            {
                this.bucketRegionName = value;
                if (bucketRegionName != "us-east-1")
                {
                    _putBucketConfiguration = new PutBucketConfiguration();
                    if (bucketRegionName == "eu-west-1")
                        _putBucketConfiguration.LocationConstraint = "EU";
                    else
                        _putBucketConfiguration.LocationConstraint = bucketRegionName;
                }
            }
        }

        // Check to see if BucketRegionName property is set
        internal bool IsSetBucketRegionName()
        {
            return !string.IsNullOrEmpty(this.bucketRegionName);
        }
    }
}
    
