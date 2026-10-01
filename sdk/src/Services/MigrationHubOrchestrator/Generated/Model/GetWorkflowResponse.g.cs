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
    /// This is the response object from the GetWorkflow operation.
    /// </summary>
    public partial class GetWorkflowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdsApplicationConfigurationId. 
        /// <para>
        /// The configuration ID of the application configured in Application Discovery Service.
        /// </para>
        /// </summary>
        public string AdsApplicationConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the AdsApplicationConfigurationId property is set.
        /// </summary>
        internal bool IsSetAdsApplicationConfigurationId() => this.AdsApplicationConfigurationId != null;

        /// <summary>
        /// Gets and sets the property AdsApplicationName. 
        /// <para>
        /// The name of the application configured in Application Discovery Service.
        /// </para>
        /// </summary>
        public string AdsApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the AdsApplicationName property is set.
        /// </summary>
        internal bool IsSetAdsApplicationName() => this.AdsApplicationName != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the migration workflow.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CompletedSteps. 
        /// <para>
        /// Get a list of completed steps in the migration workflow.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the migration workflow.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time at which the migration workflow was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastStartTime. 
        /// <para>
        /// The time at which the migration workflow was last started.
        /// </para>
        /// </summary>
        public DateTime? LastStartTime { get; set; }

        /// <summary>
        /// Checks to see if the LastStartTime property is set.
        /// </summary>
        internal bool IsSetLastStartTime() => this.LastStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastStopTime. 
        /// <para>
        /// The time at which the migration workflow was last stopped.
        /// </para>
        /// </summary>
        public DateTime? LastStopTime { get; set; }

        /// <summary>
        /// Checks to see if the LastStopTime property is set.
        /// </summary>
        internal bool IsSetLastStopTime() => this.LastStopTime.HasValue;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags added to the migration workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Tools. 
        /// <para>
        /// List of AWS services utilized in a migration workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tool> Tools { get; set; } = AWSConfigs.InitializeCollections ? new List<Tool>() : null;

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null && (this.Tools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalSteps. 
        /// <para>
        /// The total number of steps in the migration workflow.
        /// </para>
        /// </summary>
        public int? TotalSteps { get; set; }

        /// <summary>
        /// Checks to see if the TotalSteps property is set.
        /// </summary>
        internal bool IsSetTotalSteps() => this.TotalSteps.HasValue;

        /// <summary>
        /// Gets and sets the property WorkflowBucket. 
        /// <para>
        /// The Amazon S3 bucket where the migration logs are stored.
        /// </para>
        /// </summary>
        public string WorkflowBucket { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowBucket property is set.
        /// </summary>
        internal bool IsSetWorkflowBucket() => this.WorkflowBucket != null;

        /// <summary>
        /// Gets and sets the property WorkflowInputs. 
        /// <para>
        /// The inputs required for creating the migration workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, StepInput> WorkflowInputs { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, StepInput>() : null;

        /// <summary>
        /// Checks to see if the WorkflowInputs property is set.
        /// </summary>
        internal bool IsSetWorkflowInputs() => this.WorkflowInputs != null && (this.WorkflowInputs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
