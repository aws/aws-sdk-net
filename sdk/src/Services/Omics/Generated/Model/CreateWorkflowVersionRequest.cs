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
    /// Don't include any personally identifiable information (PII) in the version name. Version
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
        private ContainerRegistryMap _containerRegistryMap;
        private string _containerRegistryMapUri;
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
        /// Gets and sets the property ContainerRegistryMap. 
        /// <para>
        /// (Optional) Use a container registry map to specify mappings between the ECR private
        /// repository and one or more upstream registries. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-ecr.html">Container
        /// images</a> in the <i>Amazon Web Services HealthOmics User Guide</i>. 
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
        /// Gets and sets the property ContainerRegistryMapUri. 
        /// <para>
        /// (Optional) URI of the S3 location for the registry mapping file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public string ContainerRegistryMapUri
        {
            get { return this._containerRegistryMapUri; }
            set { this._containerRegistryMapUri = value; }
        }

        // Check to see if ContainerRegistryMapUri property is set
        internal bool IsSetContainerRegistryMapUri()
        {
            return this._containerRegistryMapUri != null;
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
        /// The S3 URI of a definition for this workflow version. The S3 bucket must be in the
        /// same region as this workflow version.
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
        /// A ZIP archive containing the main workflow definition file and dependencies that it
        /// imports for this workflow version. You can use a file with a ://fileb prefix instead
        /// of the Base64 string. For more information, see Workflow definition requirements in
        /// the <i>Amazon Web Services HealthOmics User Guide</i>.
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
        /// The workflow engine for this workflow version. This is only required if you have workflow
        /// definition files from more than one engine in your zip file. Otherwise, the service
        /// can detect the engine automatically from your workflow definition.
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
        /// The path of the main definition file for this workflow version. This parameter is
        /// not required if the ZIP archive contains only one workflow definition file, or if
        /// the main definition file is named “main”. An example path is: <c>workflow-definition/main-file.wdl</c>.
        /// 
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
        /// A parameter template for this workflow version. If this field is blank, Amazon Web
        /// Services HealthOmics will automatically parse the parameter template values from your
        /// workflow definition file. To override these service generated default values, provide
        /// a parameter template. To view an example of a parameter template, see <a href="https://docs.aws.amazon.com/omics/latest/dev/parameter-templates.html">Parameter
        /// template files</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
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
        /// An idempotency token to ensure that duplicate workflows are not created when Amazon
        /// Web Services HealthOmics submits retry requests.
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
        /// version. The <c>storageCapacity</c> can be overwritten at run time. The storage capacity
        /// is not required for runs with a <c>DYNAMIC</c> storage type.
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
        /// The default storage type for runs that use this workflow version. The <c>storageType</c>
        /// can be overridden at run time. <c>DYNAMIC</c> storage dynamically scales the storage
        /// up or down, based on file system utilization. STATIC storage allocates a fixed amount
        /// of storage. For more information about dynamic and static storage types, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-run-types.html">Run
        /// storage types</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
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
        /// Tags for this workflow version. You can define up to 50 tags for the workflow. For
        /// more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/add-a-tag.html">Adding
        /// a tag</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
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
        /// The ID of the workflow where you are creating the new version. The <c>workflowId</c>
        /// is not the UUID.
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