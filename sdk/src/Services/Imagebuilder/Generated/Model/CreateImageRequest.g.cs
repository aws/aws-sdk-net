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
    /// Container for the parameters to the CreateImage operation. Creates a new image along
    /// with all configured output resources defined in the distribution configuration. You
    /// must specify exactly one recipe for your image, using either a <c>containerRecipeArn</c>
    /// or an <c>imageRecipeArn</c>. <para> The response returns as soon as Image Builder
    /// creates the new image resource. The image build process runs asynchronously. To check
    /// its progress, call <a href="https://docs.aws.amazon.com/imagebuilder/latest/APIReference/API_GetImage.html">GetImage</a>
    /// and check the image status. </para>
    /// </summary>
    public partial class CreateImageRequest : AmazonImagebuilderRequest
    {
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
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContainerRecipeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe that defines how images are
        /// configured and tested. You must specify either this property or <c>imageRecipeArn</c>,
        /// but not both.
        /// </para>
        /// </summary>
        public string ContainerRecipeArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRecipeArn property is set.
        /// </summary>
        internal bool IsSetContainerRecipeArn() => this.ContainerRecipeArn != null;

        /// <summary>
        /// Gets and sets the property DistributionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration that defines and
        /// configures the outputs of the image build. If you don't specify a distribution configuration,
        /// Image Builder creates the output image only in the account and Amazon Web Services
        /// Region where the build runs.
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
        /// Builder access to perform workflow actions. This property is required if you specify
        /// <c>workflows</c>. If you don't provide a role, Image Builder uses the Image Builder
        /// service-linked role in your account, and creates it if it doesn't exist.
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
        /// The Amazon Resource Name (ARN) of the image recipe that defines how images are configured,
        /// tested, and assessed. You must specify either this property or <c>containerRecipeArn</c>,
        /// but not both.
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
        /// The settings that determine whether and how Amazon Inspector scans the image for vulnerabilities.
        /// </para>
        /// </summary>
        public ImageScanningConfiguration ImageScanningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageScanningConfiguration property is set.
        /// </summary>
        internal bool IsSetImageScanningConfiguration() => this.ImageScanningConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageTestsConfiguration. 
        /// <para>
        /// Settings that determine whether Image Builder runs tests on the image after building
        /// it. Image tests are enabled by default.
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
        /// The Amazon Resource Name (ARN) of the infrastructure configuration that defines the
        /// environment in which your image will be built and tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InfrastructureConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureConfigurationArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureConfigurationArn() => this.InfrastructureConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The CloudWatch Logs log group where Image Builder sends the image build logs. If you
        /// specify a log group name outside of the <c>/aws/imagebuilder/</c> namespace, you must
        /// also provide an <c>executionRole</c> that has permission to write to that log group.
        /// </para>
        /// </summary>
        public ImageLoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the image.
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
        /// The array of workflow configuration objects for the build. If you specify workflows,
        /// they replace the default workflows that Image Builder otherwise runs for the build,
        /// and you must also provide an <c>executionRole</c>.
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
