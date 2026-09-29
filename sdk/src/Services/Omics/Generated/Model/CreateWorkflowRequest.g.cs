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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkflow operation. Creates a private workflow.
    /// Before you create a private workflow, you must create and configure these required
    /// resources: <ul> <li> <para> <i>Workflow definition file:</i> A workflow definition
    /// file written in WDL, Nextflow, or CWL. The workflow definition specifies the inputs
    /// and outputs for runs that use the workflow. It also includes specifications for the
    /// runs and run tasks for your workflow, including compute and memory requirements. The
    /// workflow definition file must be in <c>.zip</c> format. For more information, see
    /// <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-definition-files.html">Workflow
    /// definition files</a> in Amazon Web Services HealthOmics. </para> <ul> <li> <para>
    /// You can use Amazon Q CLI to build and validate your workflow definition files in WDL,
    /// Nextflow, and CWL. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/getting-started.html#omics-q-prompts">Example
    /// prompts for Amazon Q CLI</a> and the <a href="https://github.com/aws-samples/aws-healthomics-tutorials/tree/main/generative-ai">Amazon
    /// Web Services HealthOmics Agentic generative AI tutorial</a> on GitHub. </para> </li>
    /// </ul> </li> <li> <para> <i>(Optional) Parameter template file:</i> A parameter template
    /// file written in JSON. Create the file to define the run parameters, or Amazon Web
    /// Services HealthOmics generates the parameter template for you. For more information,
    /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/parameter-templates.html">Parameter
    /// template files for HealthOmics workflows</a>. </para> </li> <li> <para> <i>ECR container
    /// images:</i> Create container images for the workflow in a private ECR repository,
    /// or synchronize images from a supported upstream registry with your Amazon ECR private
    /// repository. </para> </li> <li> <para> <i>(Optional) Sentieon licenses:</i> Request
    /// a Sentieon license to use the Sentieon software in private workflows. </para> </li>
    /// </ul> <para> For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/creating-private-workflows.html">Creating
    /// or updating a private workflow in Amazon Web Services HealthOmics</a> in the <i>Amazon
    /// Web Services HealthOmics User Guide</i>. </para>
    /// </summary>
    public partial class CreateWorkflowRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// The computational accelerator specified to run the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public Accelerators Accelerators { get; set; }

        /// <summary>
        /// Checks to see if the Accelerators property is set.
        /// </summary>
        internal bool IsSetAccelerators() => this.Accelerators != null;

        /// <summary>
        /// Gets and sets the property ContainerRegistryMap. 
        /// <para>
        /// (Optional) Use a container registry map to specify mappings between the ECR private
        /// repository and one or more upstream registries. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-ecr.html">Container
        /// images</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        public ContainerRegistryMap ContainerRegistryMap { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRegistryMap property is set.
        /// </summary>
        internal bool IsSetContainerRegistryMap() => this.ContainerRegistryMap != null;

        /// <summary>
        /// Gets and sets the property ContainerRegistryMapUri. 
        /// <para>
        /// (Optional) URI of the S3 location for the registry mapping file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 750)]
        public string ContainerRegistryMapUri { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRegistryMapUri property is set.
        /// </summary>
        internal bool IsSetContainerRegistryMapUri() => this.ContainerRegistryMapUri != null;

        /// <summary>
        /// Gets and sets the property DefinitionRepository. 
        /// <para>
        /// The repository information for the workflow definition. This allows you to source
        /// your workflow definition directly from a code repository.
        /// </para>
        /// </summary>
        public DefinitionRepository DefinitionRepository { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionRepository property is set.
        /// </summary>
        internal bool IsSetDefinitionRepository() => this.DefinitionRepository != null;

        /// <summary>
        /// Gets and sets the property DefinitionUri. 
        /// <para>
        /// The S3 URI of a definition for the workflow. The S3 bucket must be in the same region
        /// as the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DefinitionUri { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionUri property is set.
        /// </summary>
        internal bool IsSetDefinitionUri() => this.DefinitionUri != null;

        /// <summary>
        /// Gets and sets the property DefinitionZip. 
        /// <para>
        /// A ZIP archive containing the main workflow definition file and dependencies that it
        /// imports for the workflow. You can use a file with a ://fileb prefix instead of the
        /// Base64 string. For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-defn-requirements.html">Workflow
        /// definition requirements</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        public MemoryStream DefinitionZip { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionZip property is set.
        /// </summary>
        internal bool IsSetDefinitionZip() => this.DefinitionZip != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The workflow engine for the workflow. By default, Amazon Web Services HealthOmics
        /// detects the engine automatically from your workflow definition. Provide a value if
        /// you have workflow definition files from more than one engine in your zip file, or
        /// to use WDL lenient.
        /// </para>
        ///  
        /// <para>
        /// WDL lenient is designed to handle workflows migrated from Cromwell. It supports customer
        /// Cromwell directives and some non-conformant logic. For details, see <a href="https://docs.aws.amazon.com/omics/latest/dev/workflow-wdl-type-conversion.html">Implicit
        /// type conversion in WDL lenient</a> in the <i>Amazon Web Services HealthOmics User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public WorkflowEngine Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property Main. 
        /// <para>
        /// The path of the main definition file for the workflow. This parameter is not required
        /// if the ZIP archive contains only one workflow definition file, or if the main definition
        /// file is named “main”. An example path is: <c>workflow-definition/main-file.wdl</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Main { get; set; }

        /// <summary>
        /// Checks to see if the Main property is set.
        /// </summary>
        internal bool IsSetMain() => this.Main != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name (optional but highly recommended) for the workflow to locate relevant information
        /// in the CloudWatch logs and Amazon Web Services HealthOmics console. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParameterTemplate. 
        /// <para>
        /// A parameter template for the workflow. If this field is blank, Amazon Web Services
        /// HealthOmics will automatically parse the parameter template values from your workflow
        /// definition file. To override these service generated default values, provide a parameter
        /// template. To view an example of a parameter template, see <a href="https://docs.aws.amazon.com/omics/latest/dev/parameter-templates.html">Parameter
        /// template files</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public Dictionary<string, WorkflowParameter> ParameterTemplate { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkflowParameter>() : null;

        /// <summary>
        /// Checks to see if the ParameterTemplate property is set.
        /// </summary>
        internal bool IsSetParameterTemplate() => this.ParameterTemplate != null && (this.ParameterTemplate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParameterTemplatePath. 
        /// <para>
        /// The path to the workflow parameter template JSON file within the repository. This
        /// file defines the input parameters for runs that use this workflow. If not specified,
        /// the workflow will be created without a parameter template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ParameterTemplatePath { get; set; }

        /// <summary>
        /// Checks to see if the ParameterTemplatePath property is set.
        /// </summary>
        internal bool IsSetParameterTemplatePath() => this.ParameterTemplatePath != null;

        /// <summary>
        /// Gets and sets the property ReadmeMarkdown. 
        /// <para>
        /// The markdown content for the workflow's README file. This provides documentation and
        /// usage information for users of the workflow.
        /// </para>
        /// </summary>
        public string ReadmeMarkdown { get; set; }

        /// <summary>
        /// Checks to see if the ReadmeMarkdown property is set.
        /// </summary>
        internal bool IsSetReadmeMarkdown() => this.ReadmeMarkdown != null;

        /// <summary>
        /// Gets and sets the property ReadmePath. 
        /// <para>
        /// The path to the workflow README markdown file within the repository. This file provides
        /// documentation and usage information for the workflow. If not specified, the <c>README.md</c>
        /// file from the root directory of the repository will be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ReadmePath { get; set; }

        /// <summary>
        /// Checks to see if the ReadmePath property is set.
        /// </summary>
        internal bool IsSetReadmePath() => this.ReadmePath != null;

        /// <summary>
        /// Gets and sets the property ReadmeUri. 
        /// <para>
        /// The S3 URI of the README file for the workflow. This file provides documentation and
        /// usage information for the workflow. Requirements include:
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
        public string ReadmeUri { get; set; }

        /// <summary>
        /// Checks to see if the ReadmeUri property is set.
        /// </summary>
        internal bool IsSetReadmeUri() => this.ReadmeUri != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// An idempotency token to ensure that duplicate workflows are not created when Amazon
        /// Web Services HealthOmics submits retry requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The default static storage capacity (in gibibytes) for runs that use this workflow
        /// or workflow version. The <c>storageCapacity</c> can be overwritten at run time. The
        /// storage capacity is not required for runs with a <c>DYNAMIC</c> storage type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100000)]
        public int? StorageCapacity { get; set; }

        /// <summary>
        /// Checks to see if the StorageCapacity property is set.
        /// </summary>
        internal bool IsSetStorageCapacity() => this.StorageCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The default storage type for runs that use this workflow. The <c>storageType</c> can
        /// be overridden at run time. <c>DYNAMIC</c> storage dynamically scales the storage up
        /// or down, based on file system utilization. <c>STATIC</c> storage allocates a fixed
        /// amount of storage. For more information about dynamic and static storage types, see
        /// <a href="https://docs.aws.amazon.com/omics/latest/dev/workflows-run-types.html">Run
        /// storage types</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the workflow. You can define up to 50 tags for the workflow. For more information,
        /// see <a href="https://docs.aws.amazon.com/omics/latest/dev/add-a-tag.html">Adding a
        /// tag</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
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
        /// Gets and sets the property WorkflowBucketOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the expected owner of the S3 bucket that contains
        /// the workflow definition. If not specified, the service skips the validation.
        /// </para>
        /// </summary>
        public string WorkflowBucketOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowBucketOwnerId property is set.
        /// </summary>
        internal bool IsSetWorkflowBucketOwnerId() => this.WorkflowBucketOwnerId != null;
    }
}
