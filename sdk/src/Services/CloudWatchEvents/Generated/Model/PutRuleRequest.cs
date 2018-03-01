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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the PutRule operation.
    /// Creates or updates the specified rule. Rules are enabled by default, or based on value
    /// of the state. You can disable a rule using <a>DisableRule</a>.
    /// 
    ///  
    /// <para>
    /// If you are updating an existing rule, the rule is completely replaced with what you
    /// specify in this <code>PutRule</code> command. If you omit arguments in <code>PutRule</code>,
    /// the old values for those arguments are not kept. Instead, they are replaced with null
    /// values.
    /// </para>
    ///  
    /// <para>
    /// When you create or update a rule, incoming events might not immediately start matching
    /// to new or updated rules. Please allow a short period of time for changes to take effect.
    /// </para>
    ///  
    /// <para>
    /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
    /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
    /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
    /// in which case the rule triggers on matching events as well as on a schedule.
    /// </para>
    ///  
    /// <para>
    /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
    /// However, CloudWatch Events uses an exact match in event patterns and rules. Be sure
    /// to use the correct ARN characters when creating event patterns so that they match
    /// the ARN syntax in the event you want to match.
    /// </para>
    /// </summary>
    public partial class PutRuleRequest : AmazonCloudWatchEventsRequest
    {
        private string _description;
        private string _eventPattern;
        private string _name;
        private string _roleArn;
        private string _scheduleExpression;
        private RuleState _state;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule.
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
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The event pattern. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/CloudWatchEventsandEventPatterns.html">Events
        /// and Event Patterns</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        /// </summary>
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule that you are creating or updating.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the rule.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The scheduling expression. For example, "cron(0 20 * * ? *)" or "rate(5 minutes)".
        /// </para>
        /// </summary>
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether the rule is enabled or disabled.
        /// </para>
        /// </summary>
        public RuleState State
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