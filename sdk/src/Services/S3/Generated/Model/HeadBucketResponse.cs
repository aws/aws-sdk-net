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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the HeadBucket operation.
    /// </summary>
    public partial class HeadBucketResponse : AmazonWebServiceResponse
    {
        private bool? _accessPointAlias;
        private string _bucketArn;
        private string _bucketLocationName;
        private LocationType _bucketLocationType;
        private string _bucketRegion;

        /// <summary>
        /// Gets and sets the property AccessPointAlias. 
        /// <para>
        /// Indicates whether the bucket name used in the request is an access point alias.
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, the value of this field is <c>false</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? AccessPointAlias
        {
            get { return this._accessPointAlias; }
            set { this._accessPointAlias = value; }
        }

        // Check to see if AccessPointAlias property is set
        internal bool IsSetAccessPointAlias()
        {
            return this._accessPointAlias.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket. ARNs uniquely identify Amazon Web
        /// Services resources across all of Amazon Web Services.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported for S3 directory buckets. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Using
        /// tags with directory buckets</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property BucketLocationName. 
        /// <para>
        /// The name of the location where the bucket will be created.
        /// </para>
        ///  
        /// <para>
        /// For directory buckets, the Zone ID of the Availability Zone or the Local Zone where
        /// the bucket is created. An example Zone ID value for an Availability Zone is <c>usw2-az1</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is only supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string BucketLocationName
        {
            get { return this._bucketLocationName; }
            set { this._bucketLocationName = value; }
        }

        // Check to see if BucketLocationName property is set
        internal bool IsSetBucketLocationName()
        {
            return this._bucketLocationName != null;
        }

        /// <summary>
        /// Gets and sets the property BucketLocationType. 
        /// <para>
        /// The type of location where the bucket is created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is only supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public LocationType BucketLocationType
        {
            get { return this._bucketLocationType; }
            set { this._bucketLocationType = value; }
        }

        // Check to see if BucketLocationType property is set
        internal bool IsSetBucketLocationType()
        {
            return this._bucketLocationType != null;
        }

        /// <summary>
        /// Gets and sets the property BucketRegion. 
        /// <para>
        /// The Region that the bucket is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public string BucketRegion
        {
            get { return this._bucketRegion; }
            set { this._bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this._bucketRegion != null;
        }

    }
}