/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the SendAutomationSignal operation.
    /// Sends a signal to an Automation execution to change the current behavior or status
    /// of the execution.
    /// </summary>
    public partial class SendAutomationSignalRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _automationExecutionId;
        private Dictionary<string, List<string>> _payload = new Dictionary<string, List<string>>();
        private SignalType _signalType;

        /// <summary>
        /// Gets and sets the property AutomationExecutionId. 
        /// <para>
        /// The unique identifier for an existing Automation execution that you want to send the
        /// signal to.
        /// </para>
        /// </summary>
        public string AutomationExecutionId
        {
            get { return this._automationExecutionId; }
            set { this._automationExecutionId = value; }
        }

        // Check to see if AutomationExecutionId property is set
        internal bool IsSetAutomationExecutionId()
        {
            return this._automationExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The data sent with the signal. The data schema depends on the type of signal used
        /// in the request. 
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null && this._payload.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// The type of signal. Valid signal types include the following: Approve and Reject 
        /// </para>
        /// </summary>
        public SignalType SignalType
        {
            get { return this._signalType; }
            set { this._signalType = value; }
        }

        // Check to see if SignalType property is set
        internal bool IsSetSignalType()
        {
            return this._signalType != null;
        }

    }
}