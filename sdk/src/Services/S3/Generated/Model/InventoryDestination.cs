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
    /// Specifies the S3 Inventory configuration for an Amazon S3 bucket.
    /// </summary>
    public partial class InventoryDestination
    {
        private InventoryS3BucketDestination _s3BucketDestination;

        /// <summary>
        /// Gets and sets the property S3BucketDestination. 
        /// <para>
        /// Contains the bucket name, file format, bucket owner (optional), and prefix (optional)
        /// where inventory results are published.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryS3BucketDestination S3BucketDestination
        {
            get { return this._s3BucketDestination; }
            set { this._s3BucketDestination = value; }
        }

        // Check to see if S3BucketDestination property is set
        internal bool IsSetS3BucketDestination()
        {
            return this._s3BucketDestination != null;
        }

    }
}