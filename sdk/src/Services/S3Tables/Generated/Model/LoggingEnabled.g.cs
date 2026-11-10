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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Describes where logs are stored and the prefix that Amazon S3 assigns to all log object
    /// keys for a table bucket.
    /// </summary>
    public partial class LoggingEnabled
    {
        /// <summary>
        /// Gets and sets the property TargetBucket. 
        /// <para>
        /// The name of the general purpose bucket that logs are delivered to. The bucket must
        /// be in the same Amazon Web Services Region and owned by the same Amazon Web Services
        /// account as the table bucket. The bucket can't use SSE-KMS or DSSE-KMS default encryption,
        /// can't have S3 Object Lock enabled, and can't have Requester Pays enabled. You can
        /// deliver logs from multiple table buckets to the same target bucket. In this case,
        /// choose a different <c>targetPrefix</c> for each table bucket so that you can tell
        /// their log objects apart.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// Checks to see if the TargetBucket property is set.
        /// </summary>
        internal bool IsSetTargetBucket() => this.TargetBucket != null;

        /// <summary>
        /// Gets and sets the property TargetObjectKeyFormat. 
        /// <para>
        /// The key format of the log objects. Log object keys are always partitioned by date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetObjectKeyFormat TargetObjectKeyFormat { get; set; }

        /// <summary>
        /// Checks to see if the TargetObjectKeyFormat property is set.
        /// </summary>
        internal bool IsSetTargetObjectKeyFormat() => this.TargetObjectKeyFormat != null;

        /// <summary>
        /// Gets and sets the property TargetPrefix. 
        /// <para>
        /// The prefix for the keys of the log objects that are delivered to the target bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string TargetPrefix { get; set; }

        /// <summary>
        /// Checks to see if the TargetPrefix property is set.
        /// </summary>
        internal bool IsSetTargetPrefix() => this.TargetPrefix != null;
    }
}
