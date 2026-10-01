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
    /// The summary of a migration workflow.
    /// </summary>
    public partial class MigrationWorkflowSummary
    {
        /// <summary>
        /// Gets and sets the property AdsApplicationConfigurationName. 
        /// <para>
        /// The name of the application configured in Application Discovery Service.
        /// </para>
        /// </summary>
        public string AdsApplicationConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the AdsApplicationConfigurationName property is set.
        /// </summary>
        internal bool IsSetAdsApplicationConfigurationName() => this.AdsApplicationConfigurationName != null;

        /// <summary>
        /// Gets and sets the property CompletedSteps. 
        /// <para>
        /// The steps completed in the migration workflow.
        /// </para>
        /// </summary>
        public int? CompletedSteps { get; set; }

        /// <summary>
        /// Checks to see if the CompletedSteps property is set.
        /// </summary>
        internal bool IsSetCompletedSteps() => this.CompletedSteps.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the migration workflow was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the migration workflow ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the migration workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the migration workflow.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the migration workflow.
        /// </para>
        /// </summary>
        public MigrationWorkflowStatusEnum Status { get; set; }

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
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template.
        /// </para>
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;

        /// <summary>
        /// Gets and sets the property TotalSteps. 
        /// <para>
        /// All the steps in a migration workflow.
        /// </para>
        /// </summary>
        public int? TotalSteps { get; set; }

        /// <summary>
        /// Checks to see if the TotalSteps property is set.
        /// </summary>
        internal bool IsSetTotalSteps() => this.TotalSteps.HasValue;
    }
}
