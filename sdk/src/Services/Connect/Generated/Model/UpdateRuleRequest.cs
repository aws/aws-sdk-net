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
    /// Container for the parameters to the UpdateRule operation.
    /// Updates a rule for the specified Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// Use the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/connect-rules-language.html">Rules
    /// Function language</a> to code conditions for the rule. 
    /// </para>
    /// </summary>
    public partial class UpdateRuleRequest : AmazonConnectRequest
    {
        private List<RuleAction> _actions = new List<RuleAction>();
        private string _function;
        private string _instanceId;
        private string _name;
        private RulePublishStatus _publishStatus;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of actions to be run when the rule is triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RuleAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The conditions of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
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
        /// The name of the rule. You can change the name only if <code>TriggerEventSource</code>
        /// is one of the following values: <code>OnZendeskTicketCreate</code> | <code>OnZendeskTicketStatusUpdate</code>
        /// | <code>OnSalesforceCaseCreate</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property PublishStatus. 
        /// <para>
        /// The publish status of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RulePublishStatus PublishStatus
        {
            get { return this._publishStatus; }
            set { this._publishStatus = value; }
        }

        // Check to see if PublishStatus property is set
        internal bool IsSetPublishStatus()
        {
            return this._publishStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// A unique identifier for the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

    }
}