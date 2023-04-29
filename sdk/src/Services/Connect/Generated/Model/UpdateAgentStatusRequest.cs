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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAgentStatus operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Updates agent status.
    /// </para>
    /// </summary>
    public partial class UpdateAgentStatusRequest : AmazonConnectRequest
    {
        private string _agentStatusId;
        private string _description;
        private int? _displayOrder;
        private string _instanceId;
        private string _name;
        private bool? _resetOrderNumber;
        private AgentStatusState _state;

        /// <summary>
        /// Gets and sets the property AgentStatusId. 
        /// <para>
        /// The identifier of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentStatusId
        {
            get { return this._agentStatusId; }
            set { this._agentStatusId = value; }
        }

        // Check to see if AgentStatusId property is set
        internal bool IsSetAgentStatusId()
        {
            return this._agentStatusId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
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
        /// Gets and sets the property DisplayOrder. 
        /// <para>
        /// The display order of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int DisplayOrder
        {
            get { return this._displayOrder.GetValueOrDefault(); }
            set { this._displayOrder = value; }
        }

        // Check to see if DisplayOrder property is set
        internal bool IsSetDisplayOrder()
        {
            return this._displayOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResetOrderNumber. 
        /// <para>
        /// A number indicating the reset order of the agent status.
        /// </para>
        /// </summary>
        public bool ResetOrderNumber
        {
            get { return this._resetOrderNumber.GetValueOrDefault(); }
            set { this._resetOrderNumber = value; }
        }

        // Check to see if ResetOrderNumber property is set
        internal bool IsSetResetOrderNumber()
        {
            return this._resetOrderNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the agent status.
        /// </para>
        /// </summary>
        public AgentStatusState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}