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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrigger operation. Creates a new trigger.
    /// <para> Job arguments may be logged. Do not pass plaintext secrets as arguments. Retrieve
    /// secrets from a Glue Connection, Amazon Web Services Secrets Manager or other secret
    /// management mechanism if you intend to keep them within the Job. </para>
    /// </summary>
    public partial class CreateTriggerRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions initiated by this trigger when it fires.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Action> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<Action>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the new trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBatchingCondition. 
        /// <para>
        /// Batch condition that must be met (specified number of events received or batch time
        /// window expired) before EventBridge event trigger fires.
        /// </para>
        /// </summary>
        public EventBatchingCondition EventBatchingCondition { get; set; }

        /// <summary>
        /// Checks to see if the EventBatchingCondition property is set.
        /// </summary>
        internal bool IsSetEventBatchingCondition() => this.EventBatchingCondition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Predicate. 
        /// <para>
        /// A predicate to specify when the new trigger should fire.
        /// </para>
        ///  
        /// <para>
        /// This field is required when the trigger type is <c>CONDITIONAL</c>.
        /// </para>
        /// </summary>
        public Predicate Predicate { get; set; }

        /// <summary>
        /// Checks to see if the Predicate property is set.
        /// </summary>
        internal bool IsSetPredicate() => this.Predicate != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A <c>cron</c> expression used to specify the schedule (see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html">Time-Based
        /// Schedules for Jobs and Crawlers</a>. For example, to run something every day at 12:15
        /// UTC, you would specify: <c>cron(15 12 * * ? *)</c>.
        /// </para>
        ///  
        /// <para>
        /// This field is required when the trigger type is SCHEDULED.
        /// </para>
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property StartOnCreation. 
        /// <para>
        /// Set to <c>true</c> to start <c>SCHEDULED</c> and <c>CONDITIONAL</c> triggers when
        /// created. True is not supported for <c>ON_DEMAND</c> triggers.
        /// </para>
        /// </summary>
        public bool? StartOnCreation { get; set; }

        /// <summary>
        /// Checks to see if the StartOnCreation property is set.
        /// </summary>
        internal bool IsSetStartOnCreation() => this.StartOnCreation.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to use with this trigger. You may use tags to limit access to the trigger.
        /// For more information about tags in Glue, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">Amazon
        /// Web Services Tags in Glue</a> in the developer guide. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the new trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TriggerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the workflow associated with the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowName property is set.
        /// </summary>
        internal bool IsSetWorkflowName() => this.WorkflowName != null;
    }
}
