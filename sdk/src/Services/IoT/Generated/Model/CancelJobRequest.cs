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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJob operation.
    /// Cancels a job.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelJob</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CancelJobRequest : AmazonIoTRequest
    {
        private string _comment;
        private bool? _force;
        private string _jobId;
        private string _reasonCode;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment string describing why the job was canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// (Optional) If <c>true</c> job executions with status "IN_PROGRESS" and "QUEUED" are
        /// canceled, otherwise only job executions with status "QUEUED" are canceled. The default
        /// is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Canceling a job which is "IN_PROGRESS", will cause a device which is executing the
        /// job to be unable to update the job execution status. Use caution and ensure that each
        /// device executing a job which is canceled is able to recover to a valid state.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// (Optional)A reason code string that explains why the job was canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

    }
}