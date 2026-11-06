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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A combination of a bucket and Region that's part of a Multi-Region Access Point.
    /// </summary>
    public partial class RegionReport
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property BucketAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the Amazon S3 bucket that's associated
        /// with this Multi-Region Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string BucketAccountId { get; set; }

        /// <summary>
        /// Checks to see if the BucketAccountId property is set.
        /// </summary>
        internal bool IsSetBucketAccountId() => this.BucketAccountId != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The name of the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
