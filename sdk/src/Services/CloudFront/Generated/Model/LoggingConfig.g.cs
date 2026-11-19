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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that specifies whether access logs are written for the distribution.
    /// 
    ///  <note> 
    /// <para>
    /// If you already enabled standard logging (legacy) and you want to enable standard logging
    /// (v2) to send your access logs to Amazon S3, we recommend that you specify a <i>different</i>
    /// Amazon S3 bucket or use a <i>separate path</i> in the same bucket (for example, use
    /// a log prefix or partitioning). This helps you keep track of which log files are associated
    /// with which logging subscription and prevents log files from overwriting each other.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/AccessLogs.html">Standard
    /// logging (access logs)</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LoggingConfig
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public LoggingConfig() { }

        /// <summary>
        /// Instantiates LoggingConfig with the parameterized properties
        /// </summary>
        /// <param name="bucket">The Amazon S3 bucket to store the access logs in, for example, <c>amzn-s3-demo-bucket.s3.amazonaws.com</c>.</param>
        /// <param name="prefix">An optional string that you want CloudFront to prefix to the access log <c>filenames</c> for this distribution, for example, <c>myprefix/</c>. If you want to enable logging, but you don't want to specify a prefix, you still must include an empty <c>Prefix</c> element in the <c>Logging</c> element.</param>
        public LoggingConfig(string bucket, string prefix)
        {
            this.Bucket = bucket;
            this.Prefix = prefix;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket to store the access logs in, for example, <c>amzn-s3-demo-bucket.s3.amazonaws.com</c>.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether you want CloudFront to save access logs to an Amazon S3 bucket.
        /// If you don't want to enable logging when you create a distribution or if you want
        /// to disable logging for an existing distribution, specify <c>false</c> for <c>Enabled</c>,
        /// and specify empty <c>Bucket</c> and <c>Prefix</c> elements. If you specify <c>false</c>
        /// for <c>Enabled</c> but you specify values for <c>Bucket</c> and <c>prefix</c>, the
        /// values are automatically deleted.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeCookies. 
        /// <para>
        /// Specifies whether you want CloudFront to include cookies in access logs, specify <c>true</c>
        /// for <c>IncludeCookies</c>. If you choose to include cookies in logs, CloudFront logs
        /// all cookies regardless of how you configure the cache behaviors for this distribution.
        /// If you don't want to include cookies when you create a distribution or if you want
        /// to disable include cookies for an existing distribution, specify <c>false</c> for
        /// <c>IncludeCookies</c>.
        /// </para>
        /// </summary>
        public bool? IncludeCookies { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCookies property is set.
        /// </summary>
        internal bool IsSetIncludeCookies() => this.IncludeCookies.HasValue;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An optional string that you want CloudFront to prefix to the access log <c>filenames</c>
        /// for this distribution, for example, <c>myprefix/</c>. If you want to enable logging,
        /// but you don't want to specify a prefix, you still must include an empty <c>Prefix</c>
        /// element in the <c>Logging</c> element.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
