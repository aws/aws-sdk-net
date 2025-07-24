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
    /// Container for the parameters to the CreateWorkflowVersion operation.
    /// Creates a new workflow version for the workflow that you specify with the <c>workflowId</c>
    /// parameter.
    /// 
    ///  
    /// <para>
    /// When you create a new version of a workflow, you need to specify the configuration
    /// for the new version. It doesn't inherit any configuration values from the workflow.
    /// </para>
    ///  
    /// <para>
    /// Provide a version name that is unique for this workflow. You cannot change the name
    /// after HealthOmics creates the version.
    /// </para>
    ///  <note> 
    /// <para>
    /// Don’t include any personally identifiable information (PII) in the version name. Version
    /// names appear in the workflow version ARN.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-versions.html">Workflow
    /// versioning in Amazon Web Services HealthOmics</a> in the <i>Amazon Web Services HealthOmics
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateWorkflowVersionRequest : AmazonOmicsRequest
    {
        private Accelerators _accelerators;
        private DefinitionRepository _definitionRepository;
        private string _definitionUri;
        private MemoryStream _definitionZip;
        private string _description;
        private WorkflowEngine _engine;
        private string _main;
        private Dictionary<string, WorkflowParameter> _parameterTemplate = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkflowParameter>() : null;
        private string _parameterTemplatePath;
        private string _readmeMarkdown;
        private string _readmePath;
        private string _readmeUri;
        private string _requestId;
        private int? _storageCapacity;
        private StorageType _storageType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _versionName;
        private string _workflowBucketOwnerId;
        private string _workflowId;

        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// The computational accelerator for this workflow version.
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
        /// Gets and sets the property DefinitionRepository. 
        /// <para>
        /// The repository information for the workflow version definition. This allows you to
        /// source your workflow version definition directly from a code repository.
        /// </para>
        /// </summary>
        public DefinitionRepository DefinitionRepository
        {
            get { return this._definitionRepository; }
            set { this._definitionRepository = value; }
        }

        // Check to see if DefinitionRepository property is set
        internal bool IsSetDefinitionRepository()
        {
            return this._definitionRepository != null;
        }

        /// <summary>
        /// Gets and sets the property DefinitionUri. 
        /// <para>
        /// The URI specifies the location of the workflow definition for this workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DefinitionUri
        {
            get { return this._definitionUri; }
            set { this._definitionUri = value; }
        }

        // Check to see if DefinitionUri property is set
        internal bool IsSetDefinitionUri()
        {
            return this._definitionUri != null;
        }

        /// <summary>
        /// Gets and sets the property DefinitionZip. 
        /// <para>
        /// A zip archive containing the workflow definition for this workflow version.
        /// </para>
        /// </summary>
        public MemoryStream DefinitionZip
        {
            get { return this._definitionZip; }
            set { this._definitionZip = value; }
        }

        // Check to see if DefinitionZip property is set
        internal bool IsSetDefinitionZip()
        {
            return this._definitionZip != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for this workflow version.
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The workflow engine for this workflow version.
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
        /// Gets and sets the property Main. 
        /// <para>
        /// The path of the main definition file for this workflow version.
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
        /// Gets and sets the property ParameterTemplate. 
        /// <para>
        /// The parameter template defines the input parameters for runs that use this workflow
        /// version.
        /// </para>
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
        /// Gets and sets the property ParameterTemplatePath. 
        /// <para>
        /// The path to the workflow version parameter template JSON file within the repository.
        /// This file defines the input parameters for runs that use this workflow version. If
        /// not specified, the workflow version will be created without a parameter template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ParameterTemplatePath
        {
            get { return this._parameterTemplatePath; }
            set { this._parameterTemplatePath = value; }
        }

        // Check to see if ParameterTemplatePath property is set
        internal bool IsSetParameterTemplatePath()
        {
            return this._parameterTemplatePath != null;
        }

        /// <summary>
        /// Gets and sets the property ReadmeMarkdown. 
        /// <para>
        /// The markdown content for the workflow version's README file. This provides documentation
        /// and usage information for users of this specific workflow version.
        /// </para>
        /// </summary>
        public string ReadmeMarkdown
        {
            get { return this._readmeMarkdown; }
            set { this._readmeMarkdown = value; }
        }

        // Check to see if ReadmeMarkdown property is set
        internal bool IsSetReadmeMarkdown()
        {
            return this._readmeMarkdown != null;
        }

        /// <summary>
        /// Gets and sets the property ReadmePath. 
        /// <para>
        /// The path to the workflow version README markdown file within the repository. This
        /// file provides documentation and usage information for the workflow. If not specified,
        /// the <c>README.md</c> file from the root directory of the repository will be used.
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
        /// Gets and sets the property ReadmeUri. 
        /// <para>
        /// The S3 URI of the README file for the workflow version. This file provides documentation
        /// and usage information for the workflow version. Requirements include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The S3 URI must begin with <c>s3://USER-OWNED-BUCKET/</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requester must have access to the S3 bucket and object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max README content length is 500 KiB.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ReadmeUri
        {
            get { return this._readmeUri; }
            set { this._readmeUri = value; }
        }

        // Check to see if ReadmeUri property is set
        internal bool IsSetReadmeUri()
        {
            return this._readmeUri != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// To ensure that requests don't run multiple times, specify a unique ID for each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The default static storage capacity (in gibibytes) for runs that use this workflow
        /// or workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public int StorageCapacity
        {
            get { return this._storageCapacity.GetValueOrDefault(); }
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
        /// The default storage type for runs that use this workflow. STATIC storage allocates
        /// a fixed amount of storage. DYNAMIC storage dynamically scales the storage up or down,
        /// based on file system utilization. For more information about static and dynamic storage,
        /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/Using-workflows.html">Running
        /// workflows</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
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
        /// Optional tags to associate with this workflow version.
        /// </para>
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
        /// Gets and sets the property VersionName. 
        /// <para>
        /// A name for the workflow version. Provide a version name that is unique for this workflow.
        /// You cannot change the name after HealthOmics creates the version. 
        /// </para>
        ///  
        /// <para>
        /// The version name must start with a letter or number and it can include upper-case
        /// and lower-case letters, numbers, hyphens, periods and underscores. The maximum length
        /// is 64 characters. You can use a simple naming scheme, such as version1, version2,
        /// version3. You can also match your workflow versions with your own internal versioning
        /// conventions, such as 2.7.0, 2.7.1, 2.7.2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowBucketOwnerId. 
        /// <para>
        /// Amazon Web Services Id of the owner of the S3 bucket that contains the workflow definition.
        /// You need to specify this parameter if your account is not the bucket owner.
        /// </para>
        /// </summary>
        public string WorkflowBucketOwnerId
        {
            get { return this._workflowBucketOwnerId; }
            set { this._workflowBucketOwnerId = value; }
        }

        // Check to see if WorkflowBucketOwnerId property is set
        internal bool IsSetWorkflowBucketOwnerId()
        {
            return this._workflowBucketOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The ID of the workflow where you are creating the new version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=18)]
        public string WorkflowId
        {
            get { return this._workflowId; }
            set { this._workflowId = value; }
        }

        // Check to see if WorkflowId property is set
        internal bool IsSetWorkflowId()
        {
            return this._workflowId != null;
        }

    }
}