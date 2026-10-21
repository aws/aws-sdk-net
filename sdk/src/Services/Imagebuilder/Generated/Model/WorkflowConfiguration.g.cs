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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains control settings and configurable inputs for a workflow resource.
    /// </summary>
    public partial class WorkflowConfiguration
    {
        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// The action to take if the workflow fails. With <c>CONTINUE</c>, a failed workflow
        /// is logged and image creation proceeds to the next workflow. If you don't set a value,
        /// the image build fails when the workflow fails. You can only set this property for
        /// test workflows.
        /// </para>
        /// </summary>
        public OnWorkflowFailure OnFailure { get; set; }

        /// <summary>
        /// Checks to see if the OnFailure property is set.
        /// </summary>
        internal bool IsSetOnFailure() => this.OnFailure != null;

        /// <summary>
        /// Gets and sets the property ParallelGroup. 
        /// <para>
        /// Test workflows are defined within named runtime groups called parallel groups. The
        /// parallel group is the named group that contains this test workflow. Test workflows
        /// within a parallel group can run at the same time. Image Builder starts up to five
        /// test workflows in the group at the same time, and starts additional workflows as others
        /// complete, until all workflows in the group have completed. This field only applies
        /// for test workflows.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ParallelGroup { get; set; }

        /// <summary>
        /// Checks to see if the ParallelGroup property is set.
        /// </summary>
        internal bool IsSetParallelGroup() => this.ParallelGroup != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Contains parameter values for each of the parameters that the workflow document defined
        /// for the workflow resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<WorkflowParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkflowParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;
    }
}
