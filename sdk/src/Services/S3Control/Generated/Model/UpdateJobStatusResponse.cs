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
    /// This is the response object from the UpdateJobStatus operation.
    /// </summary>
    public partial class UpdateJobStatusResponse : AmazonWebServiceResponse
    {
        private string _jobId;
        private JobStatus _status;
        private string _statusUpdateReason;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for the job whose status was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=36)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the specified job.
        /// </para>
        /// </summary>
        public JobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusUpdateReason. 
        /// <para>
        /// The reason that the specified job's status was updated.
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