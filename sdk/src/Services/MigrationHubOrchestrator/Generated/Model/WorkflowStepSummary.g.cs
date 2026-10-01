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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// The summary of the step in a migration workflow.
    /// </summary>
    public partial class WorkflowStepSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the step.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Next. 
        /// <para>
        /// The next step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Next { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Next property is set.
        /// </summary>
        internal bool IsSetNext() => this.Next != null && (this.Next.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NoOfSrvCompleted. 
        /// <para>
        /// The number of servers that have been migrated.
        /// </para>
        /// </summary>
        public int? NoOfSrvCompleted { get; set; }

        /// <summary>
        /// Checks to see if the NoOfSrvCompleted property is set.
        /// </summary>
        internal bool IsSetNoOfSrvCompleted() => this.NoOfSrvCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property NoOfSrvFailed. 
        /// <para>
        /// The number of servers that have failed to migrate.
        /// </para>
        /// </summary>
        public int? NoOfSrvFailed { get; set; }

        /// <summary>
        /// Checks to see if the NoOfSrvFailed property is set.
        /// </summary>
        internal bool IsSetNoOfSrvFailed() => this.NoOfSrvFailed.HasValue;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the step.
        /// </para>
        /// </summary>
        public Owner Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Previous. 
        /// <para>
        /// The previous step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Previous { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Previous property is set.
        /// </summary>
        internal bool IsSetPrevious() => this.Previous != null && (this.Previous.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScriptLocation. 
        /// <para>
        /// The location of the script.
        /// </para>
        /// </summary>
        public string ScriptLocation { get; set; }

        /// <summary>
        /// Checks to see if the ScriptLocation property is set.
        /// </summary>
        internal bool IsSetScriptLocation() => this.ScriptLocation != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the step.
        /// </para>
        /// </summary>
        public StepStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the migration workflow.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StepActionType. 
        /// <para>
        /// The action type of the step. You must run and update the status of a manual step for
        /// the workflow to continue after the completion of the step.
        /// </para>
        /// </summary>
        public StepActionType StepActionType { get; set; }

        /// <summary>
        /// Checks to see if the StepActionType property is set.
        /// </summary>
        internal bool IsSetStepActionType() => this.StepActionType != null;

        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        /// The ID of the step.
        /// </para>
        /// </summary>
        public string StepId { get; set; }

        /// <summary>
        /// Checks to see if the StepId property is set.
        /// </summary>
        internal bool IsSetStepId() => this.StepId != null;

        /// <summary>
        /// Gets and sets the property TotalNoOfSrv. 
        /// <para>
        /// The total number of servers that have been migrated.
        /// </para>
        /// </summary>
        public int? TotalNoOfSrv { get; set; }

        /// <summary>
        /// Checks to see if the TotalNoOfSrv property is set.
        /// </summary>
        internal bool IsSetTotalNoOfSrv() => this.TotalNoOfSrv.HasValue;
    }
}
