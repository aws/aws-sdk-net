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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
    /// Container for the parameters to the UpdatePlan operation.
    /// Updates an existing Region switch plan. You can modify the plan's description, workflows,
    /// execution role, recovery time objective, associated alarms, and triggers.
    /// </summary>
    public partial class UpdatePlanRequest : AmazonARCRegionswitchRequest
    {
        private string _arn;
        private Dictionary<string, AssociatedAlarm> _associatedAlarms = AWSConfigs.InitializeCollections ? new Dictionary<string, AssociatedAlarm>() : null;
        private string _description;
        private string _executionRole;
        private int? _recoveryTimeObjectiveMinutes;
        private List<Trigger> _triggers = AWSConfigs.InitializeCollections ? new List<Trigger>() : null;
        private List<Workflow> _workflows = AWSConfigs.InitializeCollections ? new List<Workflow>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedAlarms. 
        /// <para>
        /// The updated CloudWatch alarms associated with the plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AssociatedAlarm> AssociatedAlarms
        {
            get { return this._associatedAlarms; }
            set { this._associatedAlarms = value; }
        }

        // Check to see if AssociatedAlarms property is set
        internal bool IsSetAssociatedAlarms()
        {
            return this._associatedAlarms != null && (this._associatedAlarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the Region switch plan.
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
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The updated IAM role ARN that grants Region switch the permissions needed to execute
        /// the plan steps.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryTimeObjectiveMinutes. 
        /// <para>
        /// The updated target recovery time objective (RTO) in minutes for the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10080)]
        public int? RecoveryTimeObjectiveMinutes
        {
            get { return this._recoveryTimeObjectiveMinutes; }
            set { this._recoveryTimeObjectiveMinutes = value; }
        }

        // Check to see if RecoveryTimeObjectiveMinutes property is set
        internal bool IsSetRecoveryTimeObjectiveMinutes()
        {
            return this._recoveryTimeObjectiveMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The updated conditions that can automatically trigger the execution of the plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Trigger> Triggers
        {
            get { return this._triggers; }
            set { this._triggers = value; }
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this._triggers != null && (this._triggers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Workflows. 
        /// <para>
        /// The updated workflows for the Region switch plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Workflow> Workflows
        {
            get { return this._workflows; }
            set { this._workflows = value; }
        }

        // Check to see if Workflows property is set
        internal bool IsSetWorkflows()
        {
            return this._workflows != null && (this._workflows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}