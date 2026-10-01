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
    /// This is the response object from the GetTemplateStep operation.
    /// </summary>
    public partial class GetTemplateStepResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the step was created.
        /// </para>
        /// </summary>
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the step.
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
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The outputs of the step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepOutput> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<StepOutput>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property StepAutomationConfiguration. 
        /// <para>
        /// The custom script to run tests on source or target environments.
        /// </para>
        /// </summary>
        public StepAutomationConfiguration StepAutomationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StepAutomationConfiguration property is set.
        /// </summary>
        internal bool IsSetStepAutomationConfiguration() => this.StepAutomationConfiguration != null;

        /// <summary>
        /// Gets and sets the property StepGroupId. 
        /// <para>
        /// The ID of the step group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string StepGroupId { get; set; }

        /// <summary>
        /// Checks to see if the StepGroupId property is set.
        /// </summary>
        internal bool IsSetStepGroupId() => this.StepGroupId != null;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The ID of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;
    }
}
