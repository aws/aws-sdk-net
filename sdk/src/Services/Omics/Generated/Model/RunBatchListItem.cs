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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
        private string _runArn;
        private string _runId;
        private string _runInternalUuid;
        private string _runSettingId;
        private string _submissionFailureMessage;
        private string _submissionFailureReason;
        private SubmissionStatus _submissionStatus;

        /// <summary>
        /// Gets and sets the property RunArn. 
        /// <para>
        /// The unique ARN of the workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RunArn
        {
            get { return this._runArn; }
            set { this._runArn = value; }
        }

        // Check to see if RunArn property is set
        internal bool IsSetRunArn()
        {
            return this._runArn != null;
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The HealthOmics-generated identifier for the workflow run. Empty if submission failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

        /// <summary>
        /// Gets and sets the property RunInternalUuid. 
        /// <para>
        /// The universally unique identifier (UUID) for the run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RunInternalUuid
        {
            get { return this._runInternalUuid; }
            set { this._runInternalUuid = value; }
        }

        // Check to see if RunInternalUuid property is set
        internal bool IsSetRunInternalUuid()
        {
            return this._runInternalUuid != null;
        }

        /// <summary>
        /// Gets and sets the property RunSettingId. 
        /// <para>
        /// The customer-provided identifier for the run configuration. Use this to correlate
        /// results back to the input configuration provided in <c>inlineSettings</c> or <c>s3UriSettings</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RunSettingId
        {
            get { return this._runSettingId; }
            set { this._runSettingId = value; }
        }

        // Check to see if RunSettingId property is set
        internal bool IsSetRunSettingId()
        {
            return this._runSettingId != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionFailureMessage. 
        /// <para>
        /// A detailed message describing the submission failure.
        /// </para>
        /// </summary>
        public string SubmissionFailureMessage
        {
            get { return this._submissionFailureMessage; }
            set { this._submissionFailureMessage = value; }
        }

        // Check to see if SubmissionFailureMessage property is set
        internal bool IsSetSubmissionFailureMessage()
        {
            return this._submissionFailureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionFailureReason. 
        /// <para>
        /// The error category for a failed submission. See the run-level failure table in the
        /// HealthOmics User Guide for details on each value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SubmissionFailureReason
        {
            get { return this._submissionFailureReason; }
            set { this._submissionFailureReason = value; }
        }

        // Check to see if SubmissionFailureReason property is set
        internal bool IsSetSubmissionFailureReason()
        {
            return this._submissionFailureReason != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionStatus. 
        /// <para>
        /// The submission outcome for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public SubmissionStatus SubmissionStatus
        {
            get { return this._submissionStatus; }
            set { this._submissionStatus = value; }
        }

        // Check to see if SubmissionStatus property is set
        internal bool IsSetSubmissionStatus()
        {
            return this._submissionStatus != null;
        }

    }
}