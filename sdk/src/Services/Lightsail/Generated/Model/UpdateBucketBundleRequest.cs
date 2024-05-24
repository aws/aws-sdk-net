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
    /// Container for the parameters to the UpdateBucketBundle operation.
    /// Updates the bundle, or storage plan, of an existing Amazon Lightsail bucket.
    /// 
    ///  
    /// <para>
    /// A bucket bundle specifies the monthly cost, storage space, and data transfer quota
    /// for a bucket. You can update a bucket's bundle only one time within a monthly Amazon
    /// Web Services billing cycle. To determine if you can update a bucket's bundle, use
    /// the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetBuckets.html">GetBuckets</a>
    /// action. The <c>ableToUpdateBundle</c> parameter in the response will indicate whether
    /// you can currently update a bucket's bundle.
    /// </para>
    ///  
    /// <para>
    /// Update a bucket's bundle if it's consistently going over its storage space or data
    /// transfer quota, or if a bucket's usage is consistently in the lower range of its storage
    /// space or data transfer quota. Due to the unpredictable usage fluctuations that a bucket
    /// might experience, we strongly recommend that you update a bucket's bundle only as
    /// a long-term strategy, instead of as a short-term, monthly cost-cutting measure. Choose
    /// a bucket bundle that will provide the bucket with ample storage space and data transfer
    /// for a long time to come.
    /// </para>
    /// </summary>
    public partial class UpdateBucketBundleRequest : AmazonLightsailRequest
    {
        private string _bucketName;
        private string _bundleId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to update the bundle.
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
        /// The ID of the new bundle to apply to the bucket.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetBucketBundles.html">GetBucketBundles</a>
        /// action to get a list of bundle IDs that you can specify.
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

    }
}