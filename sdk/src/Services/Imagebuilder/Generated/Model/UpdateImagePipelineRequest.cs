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
    /// Container for the parameters to the UpdateImagePipeline operation.
    /// Updates an image pipeline. Use image pipelines to automate the creation and distribution
    /// of images. You must specify exactly one recipe for your image, using either a <c>containerRecipeArn</c>
    /// or an <c>imageRecipeArn</c>. The recipe must be the same type, image or container,
    /// as the pipeline's current recipe.
    /// 
    ///  <note> 
    /// <para>
    /// UpdateImagePipeline does not support selective updates. The request replaces the pipeline's
    /// entire configuration, so include every setting that you want to keep. Any optional
    /// property that you omit is removed or reset to its default.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateImagePipelineRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private string _containerRecipeArn;
        private string _description;
        private string _distributionConfigurationArn;
        private bool? _enhancedImageMetadataEnabled;
        private string _executionRole;
        private string _imagePipelineArn;
        private string _imageRecipeArn;
        private ImageScanningConfiguration _imageScanningConfiguration;
        private Dictionary<string, string> _imageTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ImageTestsConfiguration _imageTestsConfiguration;
        private string _infrastructureConfigurationArn;
        private PipelineLoggingConfiguration _loggingConfiguration;
        private Schedule _schedule;
        private PipelineStatus _status;
        private List<WorkflowConfiguration> _workflows = AWSConfigs.InitializeCollections ? new List<WorkflowConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure that the operation runs
        /// no more than one time. If you retry a request with the same client token, Image Builder
        /// returns the original response without running the operation again. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe that is used to configure images
        /// created by this container pipeline. You must specify either this property or <c>imageRecipeArn</c>,
        /// but not both.
        /// </para>
        /// </summary>
        public string ContainerRecipeArn
        {
            get { return this._containerRecipeArn; }
            set { this._containerRecipeArn = value; }
        }

        // Check to see if ContainerRecipeArn property is set
        internal bool IsSetContainerRecipeArn()
        {
            return this._containerRecipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the image pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property DistributionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration that Image Builder
        /// uses to configure and distribute images created by this image pipeline.
        /// </para>
        /// </summary>
        public string DistributionConfigurationArn
        {
            get { return this._distributionConfigurationArn; }
            set { this._distributionConfigurationArn = value; }
        }

        // Check to see if DistributionConfigurationArn property is set
        internal bool IsSetDistributionConfigurationArn()
        {
            return this._distributionConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedImageMetadataEnabled. 
        /// <para>
        /// Specifies whether to collect additional information about the image being created,
        /// including the operating system (OS) version and package list. Defaults to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? EnhancedImageMetadataEnabled
        {
            get { return this._enhancedImageMetadataEnabled; }
            set { this._enhancedImageMetadataEnabled = value; }
        }

        // Check to see if EnhancedImageMetadataEnabled property is set
        internal bool IsSetEnhancedImageMetadataEnabled()
        {
            return this._enhancedImageMetadataEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) for the IAM role you create that grants Image
        /// Builder access to perform workflow actions. If you omit this property, the pipeline
        /// reverts to the Image Builder service-linked role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image pipeline that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImagePipelineArn
        {
            get { return this._imagePipelineArn; }
            set { this._imagePipelineArn = value; }
        }

        // Check to see if ImagePipelineArn property is set
        internal bool IsSetImagePipelineArn()
        {
            return this._imagePipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image recipe that configures images created
        /// by this image pipeline. You must specify either this property or <c>containerRecipeArn</c>,
        /// but not both.
        /// </para>
        /// </summary>
        public string ImageRecipeArn
        {
            get { return this._imageRecipeArn; }
            set { this._imageRecipeArn = value; }
        }

        // Check to see if ImageRecipeArn property is set
        internal bool IsSetImageRecipeArn()
        {
            return this._imageRecipeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageScanningConfiguration. 
        /// <para>
        /// Contains settings for vulnerability scans that Amazon Inspector runs against the test
        /// instance during image creation.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration
        {
            get { return this._imageScanningConfiguration; }
            set { this._imageScanningConfiguration = value; }
        }

        // Check to see if ImageScanningConfiguration property is set
        internal bool IsSetImageScanningConfiguration()
        {
            return this._imageScanningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The tags that Image Builder applies to the Image Builder image resource that this
        /// pipeline's scheduled executions create. These tags don't apply to the output AMI.
        /// To tag output AMIs, use <c>amiTags</c> in the pipeline's distribution configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && (this._imageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// Specifies the test settings that Image Builder applies to images that this pipeline
        /// creates. If you don't provide test settings, Image Builder stores a default configuration
        /// with image tests enabled.
        /// </para>
        /// </summary>
        public ImageTestsConfiguration ImageTestsConfiguration
        {
            get { return this._imageTestsConfiguration; }
            set { this._imageTestsConfiguration = value; }
        }

        // Check to see if ImageTestsConfiguration property is set
        internal bool IsSetImageTestsConfiguration()
        {
            return this._imageTestsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure configuration that Image Builder
        /// uses to build images created by this image pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InfrastructureConfigurationArn
        {
            get { return this._infrastructureConfigurationArn; }
            set { this._infrastructureConfigurationArn = value; }
        }

        // Check to see if InfrastructureConfigurationArn property is set
        internal bool IsSetInfrastructureConfigurationArn()
        {
            return this._infrastructureConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// Specifies the logging configuration for the image pipeline. Use this to define custom
        /// CloudWatch Logs log groups for your pipeline execution logs and image build logs.
        /// The service manages log groups with names starting with <c>/aws/imagebuilder/</c>
        /// using the service-linked role. For custom log group names outside of this prefix,
        /// you must also provide an <c>executionRole</c>.
        /// </para>
        /// </summary>
        public PipelineLoggingConfiguration LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the image pipeline. Because the update replaces the entire configuration,
        /// omitting this property removes any existing schedule. The pipeline then runs only
        /// when you call <a>StartImagePipelineExecution</a>.
        /// </para>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the image pipeline. Defaults to <c>ENABLED</c> when omitted. To keep
        /// a pipeline disabled, include this property set to <c>DISABLED</c> in your update request.
        /// </para>
        /// </summary>
        public PipelineStatus Status
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
        /// Gets and sets the property Workflows. 
        /// <para>
        /// The array of workflow configuration objects for builds that this pipeline starts.
        /// You must also specify <c>executionRole</c> when you provide workflows.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkflowConfiguration> Workflows
        {
            get { return this._workflows; }
            set { this._workflows = value; }
        }

        // Check to see if Workflows property is set
        internal bool IsSetWorkflows()
        {
            return this._workflows != null && (this._workflows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}