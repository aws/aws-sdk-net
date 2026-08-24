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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an unsuccessful application status check suppression.
    /// </summary>
    public partial class UnsuccessfulSuppressionResponseObject
    {
        private string _instanceId;
        private string _reason;
        private DateTime? _resumeAt;
        private DateTime? _suppressAt;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the suppression failed.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property ResumeAt. 
        /// <para>
        /// The date and time when health checks would have resumed.
        /// </para>
        /// </summary>
        public DateTime? ResumeAt
        {
            get { return this._resumeAt; }
            set { this._resumeAt = value; }
        }

        // Check to see if ResumeAt property is set
        internal bool IsSetResumeAt()
        {
            return this._resumeAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuppressAt. 
        /// <para>
        /// The date and time when suppression was attempted.
        /// </para>
        /// </summary>
        public DateTime? SuppressAt
        {
            get { return this._suppressAt; }
            set { this._suppressAt = value; }
        }

        // Check to see if SuppressAt property is set
        internal bool IsSetSuppressAt()
        {
            return this._suppressAt.HasValue; 
        }

    }
}