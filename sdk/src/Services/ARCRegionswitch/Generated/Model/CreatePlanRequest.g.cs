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
    /// Container for the parameters to the CreatePlan operation. Creates a new Region switch
    /// plan. A plan defines the steps required to shift traffic from one Amazon Web Services
    /// Region to another. <para> You must specify a name for the plan, the primary Region,
    /// and at least one additional Region. You can also provide a description, execution
    /// role, recovery time objective, associated alarms, triggers, and workflows that define
    /// the steps to execute during a Region switch. </para>
    /// </summary>
    public partial class CreatePlanRequest : AmazonARCRegionswitchRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatedAlarms. 
        /// <para>
        /// The alarms associated with a Region switch plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AssociatedAlarm> AssociatedAlarms { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AssociatedAlarm>() : null;

        /// <summary>
        /// Checks to see if the AssociatedAlarms property is set.
        /// </summary>
        internal bool IsSetAssociatedAlarms() => this.AssociatedAlarms != null && (this.AssociatedAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a Region switch plan.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// An execution role is a way to categorize a Region switch plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a Region switch plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The primary Amazon Web Services Region for the application. This is the Region where
        /// the application normally runs before any Region switch occurs.
        /// </para>
        /// </summary>
        public string PrimaryRegion { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryRegion property is set.
        /// </summary>
        internal bool IsSetPrimaryRegion() => this.PrimaryRegion != null;

        /// <summary>
        /// Gets and sets the property RecoveryApproach. 
        /// <para>
        /// The recovery approach for a Region switch plan, which can be active/active (activeActive)
        /// or active/passive (activePassive).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecoveryApproach RecoveryApproach { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryApproach property is set.
        /// </summary>
        internal bool IsSetRecoveryApproach() => this.RecoveryApproach != null;

        /// <summary>
        /// Gets and sets the property RecoveryTimeObjectiveMinutes. 
        /// <para>
        /// Optionally, you can specify an recovery time objective for a Region switch plan, in
        /// minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10080)]
        public int? RecoveryTimeObjectiveMinutes { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryTimeObjectiveMinutes property is set.
        /// </summary>
        internal bool IsSetRecoveryTimeObjectiveMinutes() => this.RecoveryTimeObjectiveMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// An array that specifies the Amazon Web Services Regions for a Region switch plan.
        /// Specify two Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportConfiguration.
        /// </summary>
        public ReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReportConfiguration property is set.
        /// </summary>
        internal bool IsSetReportConfiguration() => this.ReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceQuotaChecksEnabled. 
        /// <para>
        /// Specifies whether to enable service quota checks for the Region switch plan.
        /// </para>
        /// </summary>
        public bool? ServiceQuotaChecksEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ServiceQuotaChecksEnabled property is set.
        /// </summary>
        internal bool IsSetServiceQuotaChecksEnabled() => this.ServiceQuotaChecksEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the Region switch plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The triggers associated with a Region switch plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Trigger> Triggers { get; set; } = AWSConfigs.InitializeCollections ? new List<Trigger>() : null;

        /// <summary>
        /// Checks to see if the Triggers property is set.
        /// </summary>
        internal bool IsSetTriggers() => this.Triggers != null && (this.Triggers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Workflows. 
        /// <para>
        /// An array of workflows included in a Region switch plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Workflow> Workflows { get; set; } = AWSConfigs.InitializeCollections ? new List<Workflow>() : null;

        /// <summary>
        /// Checks to see if the Workflows property is set.
        /// </summary>
        internal bool IsSetWorkflows() => this.Workflows != null && (this.Workflows.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
