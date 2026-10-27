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
    /// An Image Builder image resource that keeps track of all of the settings used to create,
    /// configure, and distribute output for that image. An image that Image Builder built
    /// from a recipe contains exactly one recipe – either a container recipe (<c>containerRecipe</c>),
    /// which creates a container image, or an image recipe (<c>imageRecipe</c>), which creates
    /// an AMI. Imported images don't contain a recipe.
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image.
        /// </para>
        ///  <note> 
        /// <para>
        /// Semantic versioning is included in each object's Amazon Resource Name (ARN), at the
        /// level that applies to that object as follows:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Versionless ARNs and Name ARNs do not include specific values in any of the nodes.
        /// The nodes are either left off entirely, or they are specified as wildcards, for example:
        /// x.x.x.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version ARNs have only the first three nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Build version ARNs have all four nodes, and point to a specific build for a specific
        /// version of an object.
        /// </para>
        ///  </li> </ol> </note>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BuildType. 
        /// <para>
        /// Indicates the type of build that created this image. The build can be initiated in
        /// the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>USER_INITIATED</b> – A manual pipeline build request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SCHEDULED</b> – A pipeline build initiated by a cron expression in the Image Builder
        /// pipeline, or from EventBridge.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IMPORT</b> – A VM import created the image to use as the base image for the recipe.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IMPORT_ISO</b> – An ISO disk import created the image.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BuildType BuildType { get; set; }

        /// <summary>
        /// Checks to see if the BuildType property is set.
        /// </summary>
        internal bool IsSetBuildType() => this.BuildType != null;

        /// <summary>
        /// Gets and sets the property ContainerRecipe. 
        /// <para>
        /// For container images, this is the container recipe that Image Builder used to create
        /// the image. For images that distribute an AMI, this is empty.
        /// </para>
        /// </summary>
        public ContainerRecipe ContainerRecipe { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRecipe property is set.
        /// </summary>
        internal bool IsSetContainerRecipe() => this.ContainerRecipe != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which Image Builder created this image.
        /// </para>
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated != null;

        /// <summary>
        /// Gets and sets the property DeprecationTime. 
        /// <para>
        /// The time when deprecation occurs for an image resource. This can be a past or future
        /// date.
        /// </para>
        /// </summary>
        public DateTime? DeprecationTime { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationTime property is set.
        /// </summary>
        internal bool IsSetDeprecationTime() => this.DeprecationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DistributionConfiguration. 
        /// <para>
        /// The distribution configuration that Image Builder used to create this image.
        /// </para>
        /// </summary>
        public DistributionConfiguration DistributionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DistributionConfiguration property is set.
        /// </summary>
        internal bool IsSetDistributionConfiguration() => this.DistributionConfiguration != null;

        /// <summary>
        /// Gets and sets the property EnhancedImageMetadataEnabled. 
        /// <para>
        /// Indicates whether Image Builder collects additional information about the image, such
        /// as the operating system (OS) version and package list.
        /// </para>
        /// </summary>
        public bool? EnhancedImageMetadataEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedImageMetadataEnabled property is set.
        /// </summary>
        internal bool IsSetEnhancedImageMetadataEnabled() => this.EnhancedImageMetadataEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) for the IAM role you create that grants Image
        /// Builder access to perform workflow actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property ImageRecipe. 
        /// <para>
        /// For images that distribute an AMI, this is the image recipe that Image Builder used
        /// to create the image. For container images, this is empty.
        /// </para>
        /// </summary>
        public ImageRecipe ImageRecipe { get; set; }

        /// <summary>
        /// Checks to see if the ImageRecipe property is set.
        /// </summary>
        internal bool IsSetImageRecipe() => this.ImageRecipe != null;

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// Settings for the vulnerability scans that Amazon Inspector runs for this image. For
        /// AMI output, Amazon Inspector scans the test instance during image creation. For container
        /// output, Amazon Inspector scans the container image in its Amazon ECR repository.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningConfiguration property is set.
        /// </summary>
        internal bool IsSetImageScanningConfiguration() => this.ImageScanningConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// The origin of the base image that Image Builder used to build this image.
        /// </para>
        /// </summary>
        public ImageSource ImageSource { get; set; }

        /// <summary>
        /// Checks to see if the ImageSource property is set.
        /// </summary>
        internal bool IsSetImageSource() => this.ImageSource != null;

        /// <summary>
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// The image test settings that Image Builder used when it created this image.
        /// </para>
        /// </summary>
        public ImageTestsConfiguration ImageTestsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageTestsConfiguration property is set.
        /// </summary>
        internal bool IsSetImageTestsConfiguration() => this.ImageTestsConfiguration != null;

        /// <summary>
        /// Gets and sets the property InfrastructureConfiguration. 
        /// <para>
        /// The infrastructure that Image Builder used to create this image.
        /// </para>
        /// </summary>
        public InfrastructureConfiguration InfrastructureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureConfiguration property is set.
        /// </summary>
        internal bool IsSetInfrastructureConfiguration() => this.InfrastructureConfiguration != null;

        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// Identifies the last runtime instance of the lifecycle policy to take action on the
        /// image.
        /// </para>
        /// </summary>
        public string LifecycleExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleExecutionId property is set.
        /// </summary>
        internal bool IsSetLifecycleExecutionId() => this.LifecycleExecutionId != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The logging configuration that's defined for the image. Image Builder uses the defined
        /// settings to direct execution log output during image creation.
        /// </para>
        /// </summary>
        public ImageLoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system version for instances that launch from this image. For example,
        /// Amazon Linux 2, Ubuntu 18, or Microsoft Windows Server 2019.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;

        /// <summary>
        /// Gets and sets the property OutputResources. 
        /// <para>
        /// The output resources that Image Builder produces for this image.
        /// </para>
        /// </summary>
        public OutputResources OutputResources { get; set; }

        /// <summary>
        /// Checks to see if the OutputResources property is set.
        /// </summary>
        internal bool IsSetOutputResources() => this.OutputResources != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The image operating system platform, such as Linux or Windows.
        /// </para>
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property ScanState. 
        /// <para>
        /// Contains information about the current state of scans for this image.
        /// </para>
        /// </summary>
        public ImageScanState ScanState { get; set; }

        /// <summary>
        /// Checks to see if the ScanState property is set.
        /// </summary>
        internal bool IsSetScanState() => this.ScanState != null;

        /// <summary>
        /// Gets and sets the property SourcePipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image pipeline that created this image. This
        /// field is only present for images that a pipeline execution created.
        /// </para>
        /// </summary>
        public string SourcePipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the SourcePipelineArn property is set.
        /// </summary>
        internal bool IsSetSourcePipelineArn() => this.SourcePipelineArn != null;

        /// <summary>
        /// Gets and sets the property SourcePipelineName. 
        /// <para>
        /// The name of the image pipeline that created this image. Image Builder doesn't return
        /// this field for new images. Use <c>sourcePipelineArn</c> instead.
        /// </para>
        /// </summary>
        public string SourcePipelineName { get; set; }

        /// <summary>
        /// Checks to see if the SourcePipelineName property is set.
        /// </summary>
        internal bool IsSetSourcePipelineName() => this.SourcePipelineName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the image.
        /// </para>
        /// </summary>
        public ImageState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply to this image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies whether this image produces an AMI or a container image.
        /// </para>
        /// </summary>
        public ImageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The semantic version of the image.
        /// </para>
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Assignment:</b> For the first three nodes, you can assign any positive integer
        /// value, including zero. The upper limit is 2^30-1, or 1073741823, for each node. Image
        /// Builder automatically assigns the build number to the fourth node.
        /// </para>
        ///  
        /// <para>
        ///  <b>Patterns:</b> You can use any numeric pattern that adheres to the assignment requirements
        /// for the nodes that you can assign. For example, you might choose a software version
        /// pattern, such as 1.0.0, or a date, such as 2021.01.01.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> You can use wildcards (x) to specify the most recent versions or
        /// nodes when selecting the base image or components for your recipe. When you use a
        /// wildcard in any node, all nodes to the right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 5, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property Workflows. 
        /// <para>
        /// The build, test, and distribution workflow configurations that are associated with
        /// the image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkflowConfiguration> Workflows { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkflowConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Workflows property is set.
        /// </summary>
        internal bool IsSetWorkflows() => this.Workflows != null && (this.Workflows.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
