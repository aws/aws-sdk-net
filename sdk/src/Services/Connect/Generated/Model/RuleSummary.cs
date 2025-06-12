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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A list of <c>ActionTypes</c> associated with a rule.
    /// </summary>
    public partial class RuleSummary
    {
        private List<ActionSummary> _actionSummaries = AWSConfigs.InitializeCollections ? new List<ActionSummary>() : null;
        private DateTime? _createdTime;
        private EventSourceName _eventSourceName;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private RulePublishStatus _publishStatus;
        private string _ruleArn;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property ActionSummaries. 
        /// <para>
        /// A list of ActionTypes associated with a rule. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ActionSummary> ActionSummaries
        {
            get { return this._actionSummaries; }
            set { this._actionSummaries = value; }
        }

        // Check to see if ActionSummaries property is set
        internal bool IsSetActionSummaries()
        {
            return this._actionSummaries != null && (this._actionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the rule was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventSourceName. 
        /// <para>
        /// The name of the event source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventSourceName EventSourceName
        {
            get { return this._eventSourceName; }
            set { this._eventSourceName = value; }
        }

        // Check to see if EventSourceName property is set
        internal bool IsSetEventSourceName()
        {
            return this._eventSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp for when the rule was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
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

    }
}