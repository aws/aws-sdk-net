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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateClassificationJob operation.
    /// Changes the status of a classification job.
    /// </summary>
    public partial class UpdateClassificationJobRequest : AmazonMacie2Request
    {
        private string _jobId;
        private JobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for the classification job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The new status for the job. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// CANCELLED - Stops the job permanently and cancels it. You can't resume a job after
        /// you cancel it. This value is valid only if the job's current status is IDLE, PAUSED,
        /// RUNNING, or USER_PAUSED.
        /// </para>
        /// </li> <li>
        /// <para>
        /// RUNNING - Resumes the job. This value is valid only if the job's current status is
        /// USER_PAUSED. If you specify this value, Amazon Macie immediately resumes the job.
        /// </para>
        /// </li> <li>
        /// <para>
        /// USER_PAUSED - Pauses the job. This value is valid only if the job's current status
        /// is IDLE or RUNNING. If you specify this value and the job is currently running, Macie
        /// immediately stops running the job.
        /// </para>
        ///  
        /// <para>
        /// To resume a job after you pause it, change the job's status to RUNNING. If you don't
        /// resume a job within 30 days of pausing it, the job expires and Macie cancels it. You
        /// can't resume a job after it's cancelled.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

    }
}