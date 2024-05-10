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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMatchingWorkflow operation.
    /// Creates a <c>MatchingWorkflow</c> object which stores the configuration of the data
    /// processing job to be run. It is important to note that there should not be a pre-existing
    /// <c>MatchingWorkflow</c> with the same name. To modify an existing workflow, utilize
    /// the <c>UpdateMatchingWorkflow</c> API.
    /// </summary>
    public partial class CreateMatchingWorkflowRequest : AmazonEntityResolutionRequest
    {
        private string _description;
        private IncrementalRunConfig _incrementalRunConfig;
        private List<InputSource> _inputSourceConfig = AWSConfigs.InitializeCollections ? new List<InputSource>() : null;
        private List<OutputSource> _outputSourceConfig = AWSConfigs.InitializeCollections ? new List<OutputSource>() : null;
        private ResolutionTechniques _resolutionTechniques;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workflowName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IncrementalRunConfig. 
        /// <para>
        /// An object which defines an incremental run type and has only <c>incrementalRunType</c>
        /// as a field.
        /// </para>
        /// </summary>
        public IncrementalRunConfig IncrementalRunConfig
        {
            get { return this._incrementalRunConfig; }
            set { this._incrementalRunConfig = value; }
        }

        // Check to see if IncrementalRunConfig property is set
        internal bool IsSetIncrementalRunConfig()
        {
            return this._incrementalRunConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InputSourceConfig. 
        /// <para>
        /// A list of <c>InputSource</c> objects, which have the fields <c>InputSourceARN</c>
        /// and <c>SchemaName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<InputSource> InputSourceConfig
        {
            get { return this._inputSourceConfig; }
            set { this._inputSourceConfig = value; }
        }

        // Check to see if InputSourceConfig property is set
        internal bool IsSetInputSourceConfig()
        {
            return this._inputSourceConfig != null && (this._inputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputSourceConfig. 
        /// <para>
        /// A list of <c>OutputSource</c> objects, each of which contains fields <c>OutputS3Path</c>,
        /// <c>ApplyNormalization</c>, and <c>Output</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<OutputSource> OutputSourceConfig
        {
            get { return this._outputSourceConfig; }
            set { this._outputSourceConfig = value; }
        }

        // Check to see if OutputSourceConfig property is set
        internal bool IsSetOutputSourceConfig()
        {
            return this._outputSourceConfig != null && (this._outputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResolutionTechniques. 
        /// <para>
        /// An object which defines the <c>resolutionType</c> and the <c>ruleBasedProperties</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResolutionTechniques ResolutionTechniques
        {
            get { return this._resolutionTechniques; }
            set { this._resolutionTechniques = value; }
        }

        // Check to see if ResolutionTechniques property is set
        internal bool IsSetResolutionTechniques()
        {
            return this._resolutionTechniques != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. Entity Resolution assumes this role
        /// to create resources on your behalf as part of workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the workflow. There can't be multiple <c>MatchingWorkflows</c> with the
        /// same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string WorkflowName
        {
            get { return this._workflowName; }
            set { this._workflowName = value; }
        }

        // Check to see if WorkflowName property is set
        internal bool IsSetWorkflowName()
        {
            return this._workflowName != null;
        }

    }
}