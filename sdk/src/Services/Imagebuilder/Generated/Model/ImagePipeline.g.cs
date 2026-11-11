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
    /// Defines the automation configuration for building, testing, and distributing images.
    /// A pipeline references the resources that its builds use, such as the recipe and infrastructure
    /// configuration. It also holds the settings that control its builds, such as the schedule
    /// and custom workflows.
    /// </summary>
    public partial class ImagePipeline
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image pipeline.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConsecutiveFailures. 
        /// <para>
        /// Image Builder tracks the number of consecutive failures for scheduled pipeline executions
        /// and takes one of the following actions each time it runs on a schedule:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the pipeline execution is successful, the number of consecutive failures resets
        /// to zero.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the pipeline execution fails, Image Builder increments the number of consecutive
        /// failures. If the failure count reaches the limit defined in the <a>AutoDisablePolicy</a>,
        /// Image Builder disables the pipeline.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The consecutive failure count is also reset to zero under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The pipeline runs manually and succeeds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The pipeline configuration is updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the pipeline runs manually and fails, the count remains the same. The next scheduled
        /// run continues to increment where it left off before.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ConsecutiveFailures { get; set; }

        /// <summary>
        /// Checks to see if the ConsecutiveFailures property is set.
        /// </summary>
        internal bool IsSetConsecutiveFailures() => this.ConsecutiveFailures.HasValue;

        /// <summary>
        /// Gets and sets the property ContainerRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe that is used for this pipeline.
        /// </para>
        /// </summary>
        public string ContainerRecipeArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRecipeArn property is set.
        /// </summary>
        internal bool IsSetContainerRecipeArn() => this.ContainerRecipeArn != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which this image pipeline was created.
        /// </para>
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated != null;

        /// <summary>
        /// Gets and sets the property DateLastRun. 
        /// <para>
        /// The date on which this image pipeline was last run.
        /// </para>
        /// </summary>
        public string DateLastRun { get; set; }

        /// <summary>
        /// Checks to see if the DateLastRun property is set.
        /// </summary>
        internal bool IsSetDateLastRun() => this.DateLastRun != null;

        /// <summary>
        /// Gets and sets the property DateNextRun. 
        /// <para>
        /// The next date when the pipeline is scheduled to run.
        /// </para>
        /// </summary>
        public string DateNextRun { get; set; }

        /// <summary>
        /// Checks to see if the DateNextRun property is set.
        /// </summary>
        internal bool IsSetDateNextRun() => this.DateNextRun != null;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date on which this image pipeline was last updated.
        /// </para>
        /// </summary>
        public string DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the image pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DistributionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration associated with this
        /// image pipeline.
        /// </para>
        /// </summary>
        public string DistributionConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the DistributionConfigurationArn property is set.
        /// </summary>
        internal bool IsSetDistributionConfigurationArn() => this.DistributionConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property EnhancedImageMetadataEnabled. 
        /// <para>
        /// Specifies whether to collect additional information about the image being created,
        /// including the operating system (OS) version and package list. Defaults to <c>true</c>.
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
        /// Gets and sets the property ImageRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image recipe associated with this image pipeline.
        /// </para>
        /// </summary>
        public string ImageRecipeArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageRecipeArn property is set.
        /// </summary>
        internal bool IsSetImageRecipeArn() => this.ImageRecipeArn != null;

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// The settings that determine whether and how Amazon Inspector scans the images that
        /// the pipeline creates.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningConfiguration property is set.
        /// </summary>
        internal bool IsSetImageScanningConfiguration() => this.ImageScanningConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The tags that Image Builder applies to the Image Builder image resource that this
        /// pipeline's scheduled executions create. These tags don't apply to the output AMI.
        /// Builds that you start manually use the tags from the <a href="https://docs.aws.amazon.com/imagebuilder/latest/APIReference/API_StartImagePipelineExecution.html">StartImagePipelineExecution</a>
        /// request instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> ImageTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ImageTags property is set.
        /// </summary>
        internal bool IsSetImageTags() => this.ImageTags != null && (this.ImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// The image tests configuration of the image pipeline.
        /// </para>
        /// </summary>
        public ImageTestsConfiguration ImageTestsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageTestsConfiguration property is set.
        /// </summary>
        internal bool IsSetImageTestsConfiguration() => this.ImageTestsConfiguration != null;

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration associated with
        /// this image pipeline.
        /// </para>
        /// </summary>
        public string InfrastructureConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureConfigurationArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureConfigurationArn() => this.InfrastructureConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// The status of the last image that this pipeline built, such as <c>BUILDING</c>, <c>TESTING</c>,
        /// <c>FAILED</c>, or <c>AVAILABLE</c>.
        /// </para>
        /// </summary>
        public ImageStatus LastRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastRunStatus property is set.
        /// </summary>
        internal bool IsSetLastRunStatus() => this.LastRunStatus != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The CloudWatch Logs configuration for the pipeline: the log group for image build
        /// logs and the log group for pipeline execution logs.
        /// </para>
        /// </summary>
        public PipelineLoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image pipeline.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the image pipeline, inherited from the recipe that the pipeline uses.
        /// </para>
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the image pipeline.
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the image pipeline. A disabled pipeline doesn't run on its schedule,
        /// but you can still start builds manually. Image Builder can also disable a pipeline
        /// automatically when consecutive scheduled builds fail.
        /// </para>
        /// </summary>
        public PipelineStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of this image pipeline.
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
        /// Gets and sets the property Workflows. 
        /// <para>
        /// Contains the workflows that run for the image pipeline.
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
