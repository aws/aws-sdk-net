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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
        private OnWorkflowFailure _onFailure;
        private string _parallelGroup;
        private List<WorkflowParameter> _parameters = AWSConfigs.InitializeCollections ? new List<WorkflowParameter>() : null;
        private string _workflowArn;

        /// <summary>
        /// Gets and sets the property OnFailure. 
        /// <para>
        /// The action to take if the workflow fails.
        /// </para>
        /// </summary>
        public OnWorkflowFailure OnFailure
        {
            get { return this._onFailure; }
            set { this._onFailure = value; }
        }

        // Check to see if OnFailure property is set
        internal bool IsSetOnFailure()
        {
            return this._onFailure != null;
        }

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
        [AWSProperty(Min=1, Max=100)]
        public string ParallelGroup
        {
            get { return this._parallelGroup; }
            set { this._parallelGroup = value; }
        }

        // Check to see if ParallelGroup property is set
        internal bool IsSetParallelGroup()
        {
            return this._parallelGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Contains parameter values for each of the parameters that the workflow document defined
        /// for the workflow resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<WorkflowParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkflowArn
        {
            get { return this._workflowArn; }
            set { this._workflowArn = value; }
        }

        // Check to see if WorkflowArn property is set
        internal bool IsSetWorkflowArn()
        {
            return this._workflowArn != null;
        }

    }
}