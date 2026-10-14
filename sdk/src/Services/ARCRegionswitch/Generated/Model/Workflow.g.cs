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
    /// Represents a workflow in a Region switch plan. A workflow defines a sequence of steps
    /// to execute during a Region switch.
    /// </summary>
    public partial class Workflow
    {
        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// The steps that make up the workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Step> Steps { get; set; } = AWSConfigs.InitializeCollections ? new List<Step>() : null;

        /// <summary>
        /// Checks to see if the Steps property is set.
        /// </summary>
        internal bool IsSetSteps() => this.Steps != null && (this.Steps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowDescription. 
        /// <para>
        /// The description of the workflow.
        /// </para>
        /// </summary>
        public string WorkflowDescription { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowDescription property is set.
        /// </summary>
        internal bool IsSetWorkflowDescription() => this.WorkflowDescription != null;

        /// <summary>
        /// Gets and sets the property WorkflowTargetAction. 
        /// <para>
        /// The action that the workflow performs. Valid values include <c>activate</c> and <c>deactivate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowTargetAction WorkflowTargetAction { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowTargetAction property is set.
        /// </summary>
        internal bool IsSetWorkflowTargetAction() => this.WorkflowTargetAction != null;

        /// <summary>
        /// Gets and sets the property WorkflowTargetRegion. 
        /// <para>
        /// The Amazon Web Services Region that the workflow targets.
        /// </para>
        /// </summary>
        public string WorkflowTargetRegion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowTargetRegion property is set.
        /// </summary>
        internal bool IsSetWorkflowTargetRegion() => this.WorkflowTargetRegion != null;
    }
}
