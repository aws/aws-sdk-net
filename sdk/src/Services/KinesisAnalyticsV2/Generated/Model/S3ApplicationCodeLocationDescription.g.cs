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
    /// Describes the location of an application's code stored in an S3 bucket.
    /// </summary>
    public partial class S3ApplicationCodeLocationDescription
    {
        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the S3 bucket containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BucketARN { get; set; }

        /// <summary>
        /// Checks to see if the BucketARN property is set.
        /// </summary>
        internal bool IsSetBucketARN() => this.BucketARN != null;

        /// <summary>
        /// Gets and sets the property FileKey. 
        /// <para>
        /// The file key for the object containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string FileKey { get; set; }

        /// <summary>
        /// Checks to see if the FileKey property is set.
        /// </summary>
        internal bool IsSetFileKey() => this.FileKey != null;

        /// <summary>
        /// Gets and sets the property ObjectVersion. 
        /// <para>
        /// The version of the object containing the application code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersion property is set.
        /// </summary>
        internal bool IsSetObjectVersion() => this.ObjectVersion != null;
    }
}
