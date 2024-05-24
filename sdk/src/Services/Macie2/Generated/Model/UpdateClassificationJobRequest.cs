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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// CANCELLED - Stops the job permanently and cancels it. This value is valid only if
        /// the job's current status is IDLE, PAUSED, RUNNING, or USER_PAUSED.
        /// </para>
        ///  
        /// <para>
        /// If you specify this value and the job's current status is RUNNING, Amazon Macie immediately
        /// begins to stop all processing tasks for the job. You can't resume or restart a job
        /// after you cancel it.
        /// </para>
        /// </li> <li>
        /// <para>
        /// RUNNING - Resumes the job. This value is valid only if the job's current status is
        /// USER_PAUSED.
        /// </para>
        ///  
        /// <para>
        /// If you paused the job while it was actively running and you specify this value less
        /// than 30 days after you paused the job, Macie immediately resumes processing from the
        /// point where you paused the job. Otherwise, Macie resumes the job according to the
        /// schedule and other settings for the job.
        /// </para>
        /// </li> <li>
        /// <para>
        /// USER_PAUSED - Pauses the job temporarily. This value is valid only if the job's current
        /// status is IDLE, PAUSED, or RUNNING. If you specify this value and the job's current
        /// status is RUNNING, Macie immediately begins to pause all processing tasks for the
        /// job.
        /// </para>
        ///  
        /// <para>
        /// If you pause a one-time job and you don't resume it within 30 days, the job expires
        /// and Macie cancels the job. If you pause a recurring job when its status is RUNNING
        /// and you don't resume it within 30 days, the job run expires and Macie cancels the
        /// run. To check the expiration date, refer to the UserPausedDetails.jobExpiresAt property.
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