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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The full details of a flow, including its definition specifying the steps.
    /// </summary>
    public partial class FlowDetail
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the principal who created the flow.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time this flow was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlowDefinition. 
        /// <para>
        /// The definition of the flow, specifying the steps and configurations. This is the flow
        /// definition in Quick Flow's internal format. The format is subject to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Amazon.Runtime.Documents.Document FlowDefinition { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinition property is set.
        /// </summary>
        internal bool IsSetFlowDefinition() => !this.FlowDefinition.IsNull();

        /// <summary>
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowId { get; set; }

        /// <summary>
        /// Checks to see if the FlowId property is set.
        /// </summary>
        internal bool IsSetFlowId() => this.FlowId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The identifier of the last principal who updated the flow.
        /// </para>
        /// </summary>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time this flow was modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PublishState. 
        /// <para>
        /// The publish state of the flow. Valid values are <c>DRAFT</c>, <c>PUBLISHED</c>, or
        /// <c>PENDING_APPROVAL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowPublishState PublishState { get; set; }

        /// <summary>
        /// Checks to see if the PublishState property is set.
        /// </summary>
        internal bool IsSetPublishState() => this.PublishState != null;

        /// <summary>
        /// Gets and sets the property StepAliases. 
        /// <para>
        /// A list of step alias mappings for the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepAliasMapping> StepAliases { get; set; } = AWSConfigs.InitializeCollections ? new List<StepAliasMapping>() : null;

        /// <summary>
        /// Checks to see if the StepAliases property is set.
        /// </summary>
        internal bool IsSetStepAliases() => this.StepAliases != null && (this.StepAliases.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
