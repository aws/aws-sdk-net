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
    /// Container for the parameters to the UpdatePlan operation. Updates an existing Region
    /// switch plan. You can modify the plan's description, workflows, execution role, recovery
    /// time objective, associated alarms, and triggers.
    /// </summary>
    public partial class UpdatePlanRequest : AmazonARCRegionswitchRequest
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
        /// The updated CloudWatch alarms associated with the plan.
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
        /// The updated description for the Region switch plan.
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
        /// The updated IAM role ARN that grants Region switch the permissions needed to execute
        /// the plan steps.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property RecoveryTimeObjectiveMinutes. 
        /// <para>
        /// The updated target recovery time objective (RTO) in minutes for the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10080)]
        public int? RecoveryTimeObjectiveMinutes { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryTimeObjectiveMinutes property is set.
        /// </summary>
        internal bool IsSetRecoveryTimeObjectiveMinutes() => this.RecoveryTimeObjectiveMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ReportConfiguration. 
        /// <para>
        /// The updated report configuration for the plan.
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
        /// Specifies whether service quota checks are enabled for the Region switch plan.
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
        /// The updated conditions that can automatically trigger the execution of the plan.
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
        /// The updated workflows for the Region switch plan.
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
