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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        ///  
        /// <para>
        /// For <code>Approve</code> and <code>Reject</code> signal types, the payload is an optional
        /// comment that you can send with the signal type. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>Comment="Looks good"</code> 
        /// </para>
        ///  
        /// <para>
        /// For <code>StartStep</code> and <code>Resume</code> signal types, you must send the
        /// name of the Automation step to start or resume as the payload. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>StepName="step1"</code> 
        /// </para>
        ///  
        /// <para>
        /// For the <code>StopStep</code> signal type, you must send the step execution ID as
        /// the payload. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>StepExecutionId="97fff367-fc5a-4299-aed8-0123456789ab"</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// The type of signal to send to an Automation execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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