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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the StartKeyPhrasesDetectionJob operation.
    /// </summary>
    public partial class StartKeyPhrasesDetectionJobResponse : AmazonWebServiceResponse
    {
        private string _jobArn;
        private string _jobId;
        private JobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the key phrase detection job. It is a unique, fully
        /// qualified identifier for the job. It includes the Amazon Web Services account, Amazon
        /// Web Services Region, and the job ID. The format of the ARN is as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:&lt;partition&gt;:comprehend:&lt;region&gt;:&lt;account-id&gt;:key-phrases-detection-job/&lt;job-id&gt;</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The following is an example job ARN:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:comprehend:us-west-2:111122223333:key-phrases-detection-job/1234abcd12ab34cd56ef1234567890ab</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier generated for the job. To get the status of a job, use this identifier
        /// with the operation.
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
        /// The status of the job. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SUBMITTED - The job has been received and is queued for processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN_PROGRESS - Amazon Comprehend is processing the job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED - The job was successfully completed and the output is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The job did not complete. To get details, use the operation.
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