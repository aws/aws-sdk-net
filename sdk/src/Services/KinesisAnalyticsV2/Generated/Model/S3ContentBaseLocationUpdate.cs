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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// The information required to update the S3 base location that holds the application.
    /// </summary>
    public partial class S3ContentBaseLocationUpdate
    {
        private string _basePathUpdate;
        private string _bucketARNUpdate;

        /// <summary>
        /// Gets and sets the property BasePathUpdate. 
        /// <para>
        /// The updated S3 bucket path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string BasePathUpdate
        {
            get { return this._basePathUpdate; }
            set { this._basePathUpdate = value; }
        }

        // Check to see if BasePathUpdate property is set
        internal bool IsSetBasePathUpdate()
        {
            return this._basePathUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property BucketARNUpdate. 
        /// <para>
        /// The updated Amazon Resource Name (ARN) of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string BucketARNUpdate
        {
            get { return this._bucketARNUpdate; }
            set { this._bucketARNUpdate = value; }
        }

        // Check to see if BucketARNUpdate property is set
        internal bool IsSetBucketARNUpdate()
        {
            return this._bucketARNUpdate != null;
        }

    }
}