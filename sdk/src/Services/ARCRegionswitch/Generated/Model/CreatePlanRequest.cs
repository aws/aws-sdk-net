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
    /// Container for the parameters to the CreatePlan operation.
    /// Creates a new Region switch plan. A plan defines the steps required to shift traffic
    /// from one Amazon Web Services Region to another.
    /// 
    ///  
    /// <para>
    /// You must specify a name for the plan, the primary Region, and at least one additional
    /// Region. You can also provide a description, execution role, recovery time objective,
    /// associated alarms, triggers, and workflows that define the steps to execute during
    /// a Region switch.
    /// </para>
    /// </summary>
    public partial class CreatePlanRequest : AmazonARCRegionswitchRequest
    {
        private Dictionary<string, AssociatedAlarm> _associatedAlarms = AWSConfigs.InitializeCollections ? new Dictionary<string, AssociatedAlarm>() : null;
        private string _description;
        private string _executionRole;
        private string _name;
        private string _primaryRegion;
        private RecoveryApproach _recoveryApproach;
        private int? _recoveryTimeObjectiveMinutes;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Trigger> _triggers = AWSConfigs.InitializeCollections ? new List<Trigger>() : null;
        private List<Workflow> _workflows = AWSConfigs.InitializeCollections ? new List<Workflow>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedAlarms. 
        /// <para>
        /// The alarms associated with a Region switch plan.
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
        /// The description of a Region switch plan.
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
        /// An execution role is a way to categorize a Region switch plan.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a Region switch plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The primary Amazon Web Services Region for the application. This is the Region where
        /// the application normally runs before any Region switch occurs.
        /// </para>
        /// </summary>
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryApproach. 
        /// <para>
        /// The recovery approach for a Region switch plan, which can be active/active (activeActive)
        /// or active/passive (activePassive).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecoveryApproach RecoveryApproach
        {
            get { return this._recoveryApproach; }
            set { this._recoveryApproach = value; }
        }

        // Check to see if RecoveryApproach property is set
        internal bool IsSetRecoveryApproach()
        {
            return this._recoveryApproach != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryTimeObjectiveMinutes. 
        /// <para>
        /// Optionally, you can specify an recovery time objective for a Region switch plan, in
        /// minutes.
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
        /// Gets and sets the property Regions. 
        /// <para>
        /// An array that specifies the Amazon Web Services Regions for a Region switch plan.
        /// Specify two Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the Region switch plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The triggers associated with a Region switch plan.
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
        /// An array of workflows included in a Region switch plan.
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