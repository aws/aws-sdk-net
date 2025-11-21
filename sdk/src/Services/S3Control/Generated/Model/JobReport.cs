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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
    /// Contains the configuration parameters for a job-completion report.
    /// </summary>
    public partial class JobReport
    {
        private string _bucket;
        private bool? _enabled;
        private string _expectedBucketOwner;
        private JobReportFormat _format;
        private string _prefix;
        private JobReportScope _reportScope;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the bucket where specified job-completion report
        /// will be stored.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - Directory buckets aren't supported as a location for Batch
        /// Operations to store job completion reports.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the specified job will generate a job-completion report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// Lists the Amazon Web Services account ID that owns the target bucket, where the completion
        /// report is received.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the specified job-completion report.
        /// </para>
        /// </summary>
        public JobReportFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An optional prefix to describe where in the specified bucket the job-completion report
        /// will be stored. Amazon S3 stores the job-completion report at <c>&lt;prefix&gt;/job-&lt;job-id&gt;/report.json</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property ReportScope. 
        /// <para>
        /// Indicates whether the job-completion report will include details of all tasks or only
        /// failed tasks.
        /// </para>
        /// </summary>
        public JobReportScope ReportScope
        {
            get { return this._reportScope; }
            set { this._reportScope = value; }
        }

        // Check to see if ReportScope property is set
        internal bool IsSetReportScope()
        {
            return this._reportScope != null;
        }

    }
}