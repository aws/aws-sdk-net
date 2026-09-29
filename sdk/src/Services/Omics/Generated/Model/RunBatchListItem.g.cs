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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// A single run entry returned by <c>ListRunsInBatch</c>.
    /// </summary>
    public partial class RunBatchListItem
    {
        /// <summary>
        /// Gets and sets the property RunArn. 
        /// <para>
        /// The unique ARN of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RunArn { get; set; }

        /// <summary>
        /// Checks to see if the RunArn property is set.
        /// </summary>
        internal bool IsSetRunArn() => this.RunArn != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The HealthOmics-generated identifier for the workflow run. Empty if submission failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property RunInternalUuid. 
        /// <para>
        /// The universally unique identifier (UUID) for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RunInternalUuid { get; set; }

        /// <summary>
        /// Checks to see if the RunInternalUuid property is set.
        /// </summary>
        internal bool IsSetRunInternalUuid() => this.RunInternalUuid != null;

        /// <summary>
        /// Gets and sets the property RunSettingId. 
        /// <para>
        /// The customer-provided identifier for the run configuration. Use this to correlate
        /// results back to the input configuration provided in <c>inlineSettings</c> or <c>s3UriSettings</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RunSettingId { get; set; }

        /// <summary>
        /// Checks to see if the RunSettingId property is set.
        /// </summary>
        internal bool IsSetRunSettingId() => this.RunSettingId != null;

        /// <summary>
        /// Gets and sets the property SubmissionFailureMessage. 
        /// <para>
        /// A detailed message describing the submission failure.
        /// </para>
        /// </summary>
        public string SubmissionFailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionFailureMessage property is set.
        /// </summary>
        internal bool IsSetSubmissionFailureMessage() => this.SubmissionFailureMessage != null;

        /// <summary>
        /// Gets and sets the property SubmissionFailureReason. 
        /// <para>
        /// The error category for a failed submission. See the run-level failure table in the
        /// HealthOmics User Guide for details on each value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SubmissionFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionFailureReason property is set.
        /// </summary>
        internal bool IsSetSubmissionFailureReason() => this.SubmissionFailureReason != null;

        /// <summary>
        /// Gets and sets the property SubmissionStatus. 
        /// <para>
        /// The submission outcome for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public SubmissionStatus SubmissionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionStatus property is set.
        /// </summary>
        internal bool IsSetSubmissionStatus() => this.SubmissionStatus != null;
    }
}
