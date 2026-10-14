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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Defines a condition that can automatically trigger the execution of a Region switch
    /// plan.
    /// </summary>
    public partial class Trigger
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform when the trigger fires. Valid values include <c>activate</c>
        /// and <c>deactivate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowTargetAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions that must be met for the trigger to fire.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<TriggerCondition> Conditions { get; set; } = AWSConfigs.InitializeCollections ? new List<TriggerCondition>() : null;

        /// <summary>
        /// Checks to see if the Conditions property is set.
        /// </summary>
        internal bool IsSetConditions() => this.Conditions != null && (this.Conditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for a trigger.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MinDelayMinutesBetweenExecutions. 
        /// <para>
        /// The minimum time, in minutes, that must elapse between automatic executions of the
        /// plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MinDelayMinutesBetweenExecutions { get; set; }

        /// <summary>
        /// Checks to see if the MinDelayMinutesBetweenExecutions property is set.
        /// </summary>
        internal bool IsSetMinDelayMinutesBetweenExecutions() => this.MinDelayMinutesBetweenExecutions.HasValue;

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The Amazon Web Services Region for a trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetRegion { get; set; }

        /// <summary>
        /// Checks to see if the TargetRegion property is set.
        /// </summary>
        internal bool IsSetTargetRegion() => this.TargetRegion != null;
    }
}
