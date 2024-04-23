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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateImagePipeline operation.
    /// Updates an image pipeline. Image pipelines enable you to automate the creation and
    /// distribution of images. You must specify exactly one recipe for your image, using
    /// either a <c>containerRecipeArn</c> or an <c>imageRecipeArn</c>.
    /// 
    ///  <note> 
    /// <para>
    /// UpdateImagePipeline does not support selective updates for the pipeline. You must
    /// specify all of the required properties in the update request, not just the properties
    /// that have changed.
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
        private ImageTestsConfiguration _imageTestsConfiguration;
        private string _infrastructureConfigurationArn;
        private Schedule _schedule;
        private PipelineStatus _status;
        private List<WorkflowConfiguration> _workflows = AWSConfigs.InitializeCollections ? new List<WorkflowConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// The Amazon Resource Name (ARN) of the container pipeline to update.
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
        /// uses to configure and distribute images that this image pipeline has updated.
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
        /// Collects additional information about the image being created, including the operating
        /// system (OS) version and package list. This information is used to enhance the overall
        /// experience of using EC2 Image Builder. Enabled by default.
        /// </para>
        /// </summary>
        public bool EnhancedImageMetadataEnabled
        {
            get { return this._enhancedImageMetadataEnabled.GetValueOrDefault(); }
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
        /// Builder access to perform workflow actions.
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
        /// The Amazon Resource Name (ARN) of the image recipe that will be used to configure
        /// images updated by this image pipeline.
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
        /// Contains settings for vulnerability scans.
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
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// The image test configuration of the image pipeline.
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
        /// uses to build images that this image pipeline has updated.
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
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the image pipeline.
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
        /// The status of the image pipeline.
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
        /// Contains the workflows to run for the pipeline.
        /// </para>
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