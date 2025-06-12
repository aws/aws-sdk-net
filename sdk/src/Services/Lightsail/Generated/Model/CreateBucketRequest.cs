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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBucket operation.
    /// Creates an Amazon Lightsail bucket.
    /// 
    ///  
    /// <para>
    /// A bucket is a cloud storage resource available in the Lightsail object storage service.
    /// Use buckets to store objects such as data and its descriptive metadata. For more information
    /// about buckets, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/buckets-in-amazon-lightsail">Buckets
    /// in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateBucketRequest : AmazonLightsailRequest
    {
        private string _bucketName;
        private string _bundleId;
        private bool? _enableObjectVersioning;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name for the bucket.
        /// </para>
        ///  
        /// <para>
        /// For more information about bucket names, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/bucket-naming-rules-in-amazon-lightsail">Bucket
        /// naming rules in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=54)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle to use for the bucket.
        /// </para>
        ///  
        /// <para>
        /// A bucket bundle specifies the monthly cost, storage space, and data transfer quota
        /// for a bucket.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetBucketBundles.html">GetBucketBundles</a>
        /// action to get a list of bundle IDs that you can specify.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_UpdateBucketBundle.html">UpdateBucketBundle</a>
        /// action to change the bundle after the bucket is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property EnableObjectVersioning. 
        /// <para>
        /// A Boolean value that indicates whether to enable versioning of objects in the bucket.
        /// </para>
        ///  
        /// <para>
        /// For more information about versioning, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-managing-bucket-object-versioning">Enabling
        /// and suspending object versioning in a bucket in Amazon Lightsail</a> in the <i>Amazon
        /// Lightsail Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableObjectVersioning
        {
            get { return this._enableObjectVersioning; }
            set { this._enableObjectVersioning = value; }
        }

        // Check to see if EnableObjectVersioning property is set
        internal bool IsSetEnableObjectVersioning()
        {
            return this._enableObjectVersioning.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the bucket during creation.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_TagResource.html">TagResource</a>
        /// action to tag the bucket after it's created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}