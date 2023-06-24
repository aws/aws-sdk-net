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
    /// Information about a rule.
    /// </summary>
    public partial class Rule
    {
        private List<RuleAction> _actions = new List<RuleAction>();
        private DateTime? _createdTime;
        private string _function;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private RulePublishStatus _publishStatus;
        private string _ruleArn;
        private string _ruleId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private RuleTriggerEventSource _triggerEventSource;

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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the rule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
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
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp for the when the rule was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
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
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RuleArn
        {
            get { return this._ruleArn; }
            set { this._ruleArn = value; }
        }

        // Check to see if RuleArn property is set
        internal bool IsSetRuleArn()
        {
            return this._ruleArn != null;
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TriggerEventSource. 
        /// <para>
        /// The event source to trigger the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleTriggerEventSource TriggerEventSource
        {
            get { return this._triggerEventSource; }
            set { this._triggerEventSource = value; }
        }

        // Check to see if TriggerEventSource property is set
        internal bool IsSetTriggerEventSource()
        {
            return this._triggerEventSource != null;
        }

    }
}