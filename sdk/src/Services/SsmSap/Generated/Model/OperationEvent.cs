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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// An operation event returns details for an operation, including key milestones which
    /// can be used to monitor and track operations in progress.
    /// 
    ///  
    /// <para>
    /// Operation events contain:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description string
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Resource, including its ARN and type
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Status
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// StatusMessage string
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// TimeStamp
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Operation event examples include StartApplication or StopApplication.
    /// </para>
    /// </summary>
    public partial class OperationEvent
    {
        private string _description;
        private Resource _resource;
        private OperationEventStatus _status;
        private string _statusMessage;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the operation event. For example, "Stop the EC2 instance i-abcdefgh987654321".
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource involved in the operations event.
        /// </para>
        ///  
        /// <para>
        /// Contains <c>ResourceArn</c> ARN and <c>ResourceType</c>.
        /// </para>
        /// </summary>
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation event. The possible statuses are: <c>IN_PROGRESS</c>,
        /// <c>COMPLETED</c>, and <c>FAILED</c>.
        /// </para>
        /// </summary>
        public OperationEventStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message relating to a specific operation event.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the specified operation event.
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}