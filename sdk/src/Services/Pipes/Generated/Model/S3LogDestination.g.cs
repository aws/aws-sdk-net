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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The Amazon S3 logging configuration settings for the pipe.
    /// </summary>
    public partial class S3LogDestination
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket to which EventBridge delivers the log records for
        /// the pipe.
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property BucketOwner. 
        /// <para>
        /// The Amazon Web Services account that owns the Amazon S3 bucket to which EventBridge
        /// delivers the log records for the pipe.
        /// </para>
        /// </summary>
        public string BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the BucketOwner property is set.
        /// </summary>
        internal bool IsSetBucketOwner() => this.BucketOwner != null;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The format EventBridge uses for the log records.
        /// </para>
        ///  
        /// <para>
        /// EventBridge currently only supports <c>json</c> formatting.
        /// </para>
        /// </summary>
        public S3OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix text with which to begin Amazon S3 log object names.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-prefixes.html">Organizing
        /// objects using prefixes</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
