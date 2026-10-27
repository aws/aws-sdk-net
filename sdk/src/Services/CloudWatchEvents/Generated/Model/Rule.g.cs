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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Contains information about a rule in Amazon EventBridge.
    /// </summary>
    public partial class Rule
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The name or ARN of the event bus associated with the rule. If you omit this, the default
        /// event bus is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EventBusName { get; set; }

        /// <summary>
        /// Checks to see if the EventBusName property is set.
        /// </summary>
        internal bool IsSetEventBusName() => this.EventBusName != null;

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The event pattern of the rule. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-and-event-patterns.html">Events
        /// and Event Patterns</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public string EventPattern { get; set; }

        /// <summary>
        /// Checks to see if the EventPattern property is set.
        /// </summary>
        internal bool IsSetEventPattern() => this.EventPattern != null;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// If the rule was created on behalf of your account by an Amazon Web Services service,
        /// this field displays the principal name of the service that created the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that is used for target invocation.
        /// </para>
        ///  
        /// <para>
        /// If you're setting an event bus in another account as the target and that account granted
        /// permission to your account through an organization instead of directly by the account
        /// ID, you must specify a <c>RoleArn</c> with proper permissions in the <c>Target</c>
        /// structure, instead of here in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The scheduling expression. For example, "cron(0 20 * * ? *)", "rate(5 minutes)". For
        /// more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-create-rule-schedule.html">Creating
        /// an Amazon EventBridge rule that runs on a schedule</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the rule.
        /// </para>
        /// </summary>
        public RuleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
