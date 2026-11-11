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
    /// Container for the parameters to the PutTableBucketLogging operation. Sets, updates,
    /// or removes the server access logging configuration for a table bucket. When logging
    /// is enabled, Amazon S3 delivers a record of the requests made to the table bucket and
    /// its tables to the target general purpose bucket that you specify. To disable logging,
    /// call this operation with an empty <c>tableBucketLoggingStatus</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-server-logs.html">Server
    /// access logging for table buckets</a> in the <i>Amazon Simple Storage Service User
    /// Guide</i>. <dl> <dt>Permissions</dt> <dd> <para> You must have the <c>s3tables:PutTableBucketLogging</c>
    /// permission to use this operation. </para> </dd> </dl>
    /// </summary>
    public partial class PutTableBucketLoggingRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableBucketARN { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketARN property is set.
        /// </summary>
        internal bool IsSetTableBucketARN() => this.TableBucketARN != null;

        /// <summary>
        /// Gets and sets the property TableBucketLoggingStatus. 
        /// <para>
        /// The logging status to apply to the table bucket. To disable logging, specify an empty
        /// <c>tableBucketLoggingStatus</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableBucketLoggingStatus TableBucketLoggingStatus { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketLoggingStatus property is set.
        /// </summary>
        internal bool IsSetTableBucketLoggingStatus() => this.TableBucketLoggingStatus != null;
    }
}
