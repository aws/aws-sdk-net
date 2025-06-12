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
    /// Container for the parameters to the CreateWorkflow operation.
    /// Creates a private workflow.Private workflows depend on a variety of resources that
    /// you create and configure before creating the workflow:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i>Input data</i>: Input data for the workflow, stored in an S3 bucket or a Amazon
    /// Web Services HealthOmics sequence store. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Workflow definition files</i>: Define your workflow in one or more workflow definition
    /// files, written in WDL, Nextflow, or CWL. The workflow definition specifies the inputs
    /// and outputs for runs that use the workflow. It also includes specifications for the
    /// runs and run tasks for your workflow, including compute and memory requirements.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Parameter template files</i>: Define run parameters using a parameter template
    /// file (written in JSON). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>ECR container images</i>: Create one or more container images for the workflow.
    /// Store the images in a private ECR repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) <i>Sentieon licenses</i>: Request a Sentieon license if you plan to use
    /// Sentieon software in a private workflow.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/creating-private-workflows.html">Creating
    /// or updating a private workflow in Amazon Web Services HealthOmics</a> in the Amazon
    /// Web Services HealthOmics User Guide.
    /// </para>
    /// </summary>
    public partial class CreateWorkflowRequest : AmazonOmicsRequest
    {
        private Accelerators _accelerators;
        private string _definitionUri;
        private MemoryStream _definitionZip;
        private string _description;
        private WorkflowEngine _engine;
        private string _main;
        private string _name;
        private Dictionary<string, WorkflowParameter> _parameterTemplate = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkflowParameter>() : null;
        private string _requestId;
        private int? _storageCapacity;
        private StorageType _storageType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property DefinitionUri. 
        /// <para>
        /// The URI of a definition for the workflow.
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
        /// A ZIP archive for the workflow.
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
        /// A description for the workflow.
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
        /// The workflow engine for the workflow.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the workflow.
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
        /// A parameter template for the workflow.
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
        ///  The default storage type for runs that use this workflow. STATIC storage allocates
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
        /// Tags for the workflow.
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

    }
}