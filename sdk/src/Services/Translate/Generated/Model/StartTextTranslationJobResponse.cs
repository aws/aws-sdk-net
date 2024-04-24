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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the StartTextTranslationJob operation.
    /// </summary>
    public partial class StartTextTranslationJobResponse : AmazonWebServiceResponse
    {
        private string _jobId;
        private JobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier generated for the job. To get the status of a job, use this ID with
        /// the <a>DescribeTextTranslationJob</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// The status of the job. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUBMITTED</c> - The job has been received and is queued for processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - Amazon Translate is processing the job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The job was successfully completed and the output is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED_WITH_ERROR</c> - The job was completed with errors. The errors can be
        /// analyzed in the job's output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The job did not complete. To get details, use the <a>DescribeTextTranslationJob</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOP_REQUESTED</c> - The user who started the job has requested that it be stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> - The job has been stopped.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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