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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes an update for the Amazon S3 code content location for an application.
    /// </summary>
    public partial class S3ContentLocationUpdate
    {
        /// <summary>
        /// Gets and sets the property BucketARNUpdate. 
        /// <para>
        /// The new Amazon Resource Name (ARN) for the S3 bucket containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string BucketARNUpdate { get; set; }

        /// <summary>
        /// Checks to see if the BucketARNUpdate property is set.
        /// </summary>
        internal bool IsSetBucketARNUpdate() => this.BucketARNUpdate != null;

        /// <summary>
        /// Gets and sets the property FileKeyUpdate. 
        /// <para>
        /// The new file key for the object containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FileKeyUpdate { get; set; }

        /// <summary>
        /// Checks to see if the FileKeyUpdate property is set.
        /// </summary>
        internal bool IsSetFileKeyUpdate() => this.FileKeyUpdate != null;

        /// <summary>
        /// Gets and sets the property ObjectVersionUpdate. 
        /// <para>
        /// The new version of the object containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ObjectVersionUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersionUpdate property is set.
        /// </summary>
        internal bool IsSetObjectVersionUpdate() => this.ObjectVersionUpdate != null;
    }
}
