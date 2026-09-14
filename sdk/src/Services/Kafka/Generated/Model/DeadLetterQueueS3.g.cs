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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Configuration of the Amazon S3 bucket where records that fail to deliver are stored.
    /// </summary>
    public partial class DeadLetterQueueS3
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dead-letter Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property ErrorOutputPrefix. 
        /// <para>
        /// An optional prefix prepended to every dead-letter Amazon S3 object key.
        /// </para>
        /// </summary>
        public string ErrorOutputPrefix { get; set; }

        /// <summary>
        /// Checks to see if the ErrorOutputPrefix property is set.
        /// </summary>
        internal bool IsSetErrorOutputPrefix() => this.ErrorOutputPrefix != null;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// Optional 12-digit AWS account ID expected to own the dead-letter Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;
    }
}
