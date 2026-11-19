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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration parameters for a job-completion report.
    /// </summary>
    public partial class JobReport
    {
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
        [AWSProperty(Min = 1, Max = 128)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the specified job will generate a job-completion report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// Lists the Amazon Web Services account ID that owns the target bucket, where the completion
        /// report is received.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the specified job-completion report.
        /// </para>
        /// </summary>
        public JobReportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An optional prefix to describe where in the specified bucket the job-completion report
        /// will be stored. Amazon S3 stores the job-completion report at <c>&lt;prefix&gt;/job-&lt;job-id&gt;/report.json</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property ReportScope. 
        /// <para>
        /// Indicates whether the job-completion report will include details of all tasks or only
        /// failed tasks.
        /// </para>
        /// </summary>
        public JobReportScope ReportScope { get; set; }

        /// <summary>
        /// Checks to see if the ReportScope property is set.
        /// </summary>
        internal bool IsSetReportScope() => this.ReportScope != null;
    }
}
