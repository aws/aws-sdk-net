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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJobStatus operation.
    /// Updates the status for the specified job. Use this operation to confirm that you want
    /// to run a job or to cancel an existing job. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
    /// Batch Operations</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
    /// 
    ///   
    /// <para>
    /// Related actions include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateJobStatusRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _jobId;
        private RequestedJobStatus _requestedJobStatus;
        private string _statusUpdateReason;

        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job whose status you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=36)]
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
        /// Gets and sets the property RequestedJobStatus. 
        /// <para>
        /// The status that you want to move the specified job to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequestedJobStatus RequestedJobStatus
        {
            get { return this._requestedJobStatus; }
            set { this._requestedJobStatus = value; }
        }

        // Check to see if RequestedJobStatus property is set
        internal bool IsSetRequestedJobStatus()
        {
            return this._requestedJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StatusUpdateReason. 
        /// <para>
        /// A description of the reason why you want to change the specified job's status. This
        /// field can be any string up to the maximum length.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StatusUpdateReason
        {
            get { return this._statusUpdateReason; }
            set { this._statusUpdateReason = value; }
        }

        // Check to see if StatusUpdateReason property is set
        internal bool IsSetStatusUpdateReason()
        {
            return this._statusUpdateReason != null;
        }

    }
}