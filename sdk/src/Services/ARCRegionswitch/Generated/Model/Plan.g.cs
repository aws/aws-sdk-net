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
    /// Represents a Region switch plan. A plan defines the steps required to shift traffic
    /// from one Amazon Web Services Region to another.
    /// </summary>
    public partial class Plan
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedAlarms. 
        /// <para>
        /// The associated application health alarms for a plan.
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
        /// The description for a plan.
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
        /// The execution role for a plan.
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
        /// The name for a plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of a plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The primary Region for a plan.
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
        /// The recovery time objective for a plan.
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
        /// The Amazon Web Services Regions for a plan.
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
        /// <para>
        /// The report configuration for a plan.
        /// </para>
        /// </summary>
        public ReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReportConfiguration property is set.
        /// </summary>
        internal bool IsSetReportConfiguration() => this.ReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceQuotaChecksEnabled. 
        /// <para>
        /// Indicates whether service quota checks are enabled for the Region switch plan. When
        /// enabled, Region switch compares the applied service quota values across the plan's
        /// Amazon Web Services Regions and creates a warning when a quota in one Region is lower
        /// than the value required for the matching resource in another Region. Service quota
        /// checks are advisory and don't prevent you from creating, evaluating, or executing
        /// a plan.
        /// </para>
        /// </summary>
        public bool? ServiceQuotaChecksEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ServiceQuotaChecksEnabled property is set.
        /// </summary>
        internal bool IsSetServiceQuotaChecksEnabled() => this.ServiceQuotaChecksEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The triggers for a plan.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the plan was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version for the plan.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property Workflows. 
        /// <para>
        /// The workflows for a plan.
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
