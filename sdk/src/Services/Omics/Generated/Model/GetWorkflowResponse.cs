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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetWorkflow operation.
    /// </summary>
    public partial class GetWorkflowResponse : AmazonWebServiceResponse
    {
        private Accelerators _accelerators;
        private string _arn;
        private ContainerRegistryMap _containerRegistryMap;
        private DateTime? _creationTime;
        private string _definition;
        private DefinitionRepositoryDetails _definitionRepositoryDetails;
        private string _description;
        private string _digest;
        private WorkflowEngine _engine;
        private string _id;
        private string _main;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _name;
        private Dictionary<string, WorkflowParameter> _parameterTemplate = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkflowParameter>() : null;
        private string _readme;
        private string _readmePath;
        private WorkflowStatus _status;
        private string _statusMessage;
        private int? _storageCapacity;
        private StorageType _storageType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private WorkflowType _type;
        private string _uuid;

        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// The computational accelerator specified to run the workflow. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public Accelerators Accelerators
        {
            get { return this._accelerators; }
            set { this._accelerators = value; }
        }

        // Check to see if Accelerators property is set
        internal bool IsSetAccelerators()
        {
            return this._accelerators != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The workflow's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerRegistryMap. 
        /// <para>
        /// The registry map that this workflow is using.
        /// </para>
        /// </summary>
        public ContainerRegistryMap ContainerRegistryMap
        {
            get { return this._containerRegistryMap; }
            set { this._containerRegistryMap = value; }
        }

        // Check to see if ContainerRegistryMap property is set
        internal bool IsSetContainerRegistryMap()
        {
            return this._containerRegistryMap != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the workflow was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The workflow's definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property DefinitionRepositoryDetails. 
        /// <para>
        /// Details about the source code repository that hosts the workflow definition files.
        /// </para>
        /// </summary>
        public DefinitionRepositoryDetails DefinitionRepositoryDetails
        {
            get { return this._definitionRepositoryDetails; }
            set { this._definitionRepositoryDetails = value; }
        }

        // Check to see if DefinitionRepositoryDetails property is set
        internal bool IsSetDefinitionRepositoryDetails()
        {
            return this._definitionRepositoryDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The workflow's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Digest. 
        /// <para>
        /// The workflow's digest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Digest
        {
            get { return this._digest; }
            set { this._digest = value; }
        }

        // Check to see if Digest property is set
        internal bool IsSetDigest()
        {
            return this._digest != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The workflow's engine.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public WorkflowEngine Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The workflow's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Main. 
        /// <para>
        /// The path of the main definition file for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Main
        {
            get { return this._main; }
            set { this._main = value; }
        }

        // Check to see if Main property is set
        internal bool IsSetMain()
        {
            return this._main != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Gets metadata for the workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The workflow's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterTemplate. 
        /// <para>
        /// The workflow's parameter template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public Dictionary<string, WorkflowParameter> ParameterTemplate
        {
            get { return this._parameterTemplate; }
            set { this._parameterTemplate = value; }
        }

        // Check to see if ParameterTemplate property is set
        internal bool IsSetParameterTemplate()
        {
            return this._parameterTemplate != null && (this._parameterTemplate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Readme. 
        /// <para>
        /// The README content for the workflow, providing documentation and usage information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Readme
        {
            get { return this._readme; }
            set { this._readme = value; }
        }

        // Check to see if Readme property is set
        internal bool IsSetReadme()
        {
            return this._readme != null;
        }

        /// <summary>
        /// Gets and sets the property ReadmePath. 
        /// <para>
        /// The path to the workflow README markdown file within the repository. This file provides
        /// documentation and usage information for the workflow. If not specified, the <c>README.md</c>
        /// file from the root directory of the repository will be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ReadmePath
        {
            get { return this._readmePath; }
            set { this._readmePath = value; }
        }

        // Check to see if ReadmePath property is set
        internal bool IsSetReadmePath()
        {
            return this._readmePath != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The workflow's status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public WorkflowStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The workflow's status message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The default static storage capacity (in gibibytes) for runs that use this workflow
        /// or workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int? StorageCapacity
        {
            get { return this._storageCapacity; }
            set { this._storageCapacity = value; }
        }

        // Check to see if StorageCapacity property is set
        internal bool IsSetStorageCapacity()
        {
            return this._storageCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The default storage type for runs using this workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The workflow's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The workflow's type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public WorkflowType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The universally unique identifier (UUID) value for this workflow.
        /// </para>
        /// </summary>
        public string Uuid
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if Uuid property is set
        internal bool IsSetUuid()
        {
            return this._uuid != null;
        }

    }
}