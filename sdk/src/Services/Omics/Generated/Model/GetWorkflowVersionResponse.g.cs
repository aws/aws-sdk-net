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
    /// This is the response object from the GetWorkflowVersion operation.
    /// </summary>
    public partial class GetWorkflowVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// The accelerator for this workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public Accelerators Accelerators { get; set; }

        /// <summary>
        /// Checks to see if the Accelerators property is set.
        /// </summary>
        internal bool IsSetAccelerators() => this.Accelerators != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ContainerRegistryMap. 
        /// <para>
        /// The registry map that this workflow version uses.
        /// </para>
        /// </summary>
        public ContainerRegistryMap ContainerRegistryMap { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRegistryMap property is set.
        /// </summary>
        internal bool IsSetContainerRegistryMap() => this.ContainerRegistryMap != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the workflow version was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Definition of the workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property DefinitionRepositoryDetails. 
        /// <para>
        /// Details about the source code repository that hosts the workflow version definition
        /// files.
        /// </para>
        /// </summary>
        public DefinitionRepositoryDetails DefinitionRepositoryDetails { get; set; }

        /// <summary>
        /// Checks to see if the DefinitionRepositoryDetails property is set.
        /// </summary>
        internal bool IsSetDefinitionRepositoryDetails() => this.DefinitionRepositoryDetails != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the workflow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        /// The workflow version's digest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Digest { get; set; }

        /// <summary>
        /// Checks to see if the Digest property is set.
        /// </summary>
        internal bool IsSetDigest() => this.Digest != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The workflow engine for this workflow version.
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
        /// The path of the main definition file for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Main { get; set; }

        /// <summary>
        /// Checks to see if the Main property is set.
        /// </summary>
        internal bool IsSetMain() => this.Main != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the workflow version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParameterTemplate. 
        /// <para>
        /// The parameter template for the workflow version.
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
        /// Gets and sets the property ProfileParameterTemplates. 
        /// <para>
        /// A mapping of profile names to their parameter templates. Each profile defines its
        /// own set of parameters that you can use when starting a run with that profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, WorkflowParameter>> ProfileParameterTemplates { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, WorkflowParameter>>() : null;

        /// <summary>
        /// Checks to see if the ProfileParameterTemplates property is set.
        /// </summary>
        internal bool IsSetProfileParameterTemplates() => this.ProfileParameterTemplates != null && (this.ProfileParameterTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// The list of Nextflow profiles that are available for this workflow version. Profiles
        /// allow you to select predefined configuration settings at runtime.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Profiles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Profiles property is set.
        /// </summary>
        internal bool IsSetProfiles() => this.Profiles != null && (this.Profiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Readme. 
        /// <para>
        /// The README content for the workflow version, providing documentation and usage information
        /// specific to this version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Readme { get; set; }

        /// <summary>
        /// Checks to see if the Readme property is set.
        /// </summary>
        internal bool IsSetReadme() => this.Readme != null;

        /// <summary>
        /// Gets and sets the property ReadmePath. 
        /// <para>
        /// The path to the workflow version README markdown file within the repository. This
        /// file provides documentation and usage information for the workflow. If not specified,
        /// the <c>README.md</c> file from the root directory of the repository will be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ReadmePath { get; set; }

        /// <summary>
        /// Checks to see if the ReadmePath property is set.
        /// </summary>
        internal bool IsSetReadmePath() => this.ReadmePath != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The workflow version status
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public WorkflowStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The workflow version status message
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StorageCapacity. 
        /// <para>
        /// The default run storage capacity for static storage.
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
        /// The default storage type for the run.
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
        /// The workflow version tags
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The workflow version type
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public WorkflowType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The universally unique identifier (UUID) value for this workflow version
        /// </para>
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// Checks to see if the Uuid property is set.
        /// </summary>
        internal bool IsSetUuid() => this.Uuid != null;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The workflow version name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;

        /// <summary>
        /// Gets and sets the property WorkflowBucketOwnerId. 
        /// <para>
        /// Amazon Web Services Id of the owner of the bucket.
        /// </para>
        /// </summary>
        public string WorkflowBucketOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowBucketOwnerId property is set.
        /// </summary>
        internal bool IsSetWorkflowBucketOwnerId() => this.WorkflowBucketOwnerId != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The workflow's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;
    }
}
