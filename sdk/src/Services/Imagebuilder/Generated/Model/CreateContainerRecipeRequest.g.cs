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
    /// Container for the parameters to the CreateContainerRecipe operation. Creates a new
    /// container recipe. Container recipes define how images are configured, tested, and
    /// assessed.
    /// </summary>
    public partial class CreateContainerRecipeRequest : AmazonImagebuilderRequest
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
        /// Gets and sets the property Components. 
        /// <para>
        /// The components included in the container recipe. You can specify each component only
        /// one time in a recipe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ComponentConfiguration> Components { get; set; } = AWSConfigs.InitializeCollections ? new List<ComponentConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Components property is set.
        /// </summary>
        internal bool IsSetComponents() => this.Components != null && (this.Components.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainerType. 
        /// <para>
        /// The type of container to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContainerType ContainerType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerType property is set.
        /// </summary>
        internal bool IsSetContainerType() => this.ContainerType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DockerfileTemplateData. 
        /// <para>
        /// The Dockerfile template used to build your image, as an inline data blob. You must
        /// specify exactly one of the <c>dockerfileTemplateData</c> or <c>dockerfileTemplateUri</c>
        /// properties. For the contextual variables that the template can include, see <a href="https://docs.aws.amazon.com/imagebuilder/latest/userguide/create-container-recipes.html">Create
        /// a new version of a container recipe</a> in the <i>EC2 Image Builder User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16000)]
        public string DockerfileTemplateData { get; set; }

        /// <summary>
        /// Checks to see if the DockerfileTemplateData property is set.
        /// </summary>
        internal bool IsSetDockerfileTemplateData() => this.DockerfileTemplateData != null;

        /// <summary>
        /// Gets and sets the property DockerfileTemplateUri. 
        /// <para>
        /// The Amazon S3 URI for the Dockerfile template that is used to build your container
        /// image. You must have permission to read the object. Image Builder reads the object
        /// once, when it creates the recipe, and stores its content in the recipe. Later changes
        /// to the S3 object don't affect the recipe. You must specify exactly one of the <c>dockerfileTemplateData</c>
        /// or <c>dockerfileTemplateUri</c> properties.
        /// </para>
        /// </summary>
        public string DockerfileTemplateUri { get; set; }

        /// <summary>
        /// Checks to see if the DockerfileTemplateUri property is set.
        /// </summary>
        internal bool IsSetDockerfileTemplateUri() => this.DockerfileTemplateUri != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Validates the required permissions and request parameters without performing the operation.
        /// If validation succeeds, the operation returns a <c>DryRunOperationException</c> error
        /// response.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ImageOsVersionOverride. 
        /// <para>
        /// Specifies the operating system version for the base image. Use this property only
        /// when the base image is a container image from a registry. When the base image is an
        /// Image Builder image, the operating system version comes from the parent image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ImageOsVersionOverride { get; set; }

        /// <summary>
        /// Checks to see if the ImageOsVersionOverride property is set.
        /// </summary>
        internal bool IsSetImageOsVersionOverride() => this.ImageOsVersionOverride != null;

        /// <summary>
        /// Gets and sets the property InstanceConfiguration. 
        /// <para>
        /// A group of options that can be used to configure an instance for building and testing
        /// container images.
        /// </para>
        /// </summary>
        public InstanceConfiguration InstanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConfiguration property is set.
        /// </summary>
        internal bool IsSetInstanceConfiguration() => this.InstanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies which KMS key is used to encrypt
        /// the Dockerfile template. This can be either the Key ARN or the Alias ARN. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">Key
        /// identifiers (KeyId)</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container recipe. The recipe name, combined with the semantic version,
        /// must be unique to your account in each Amazon Web Services Region. Image Builder generates
        /// the container recipe ARN from a normalized form of the name, so names that differ
        /// only in case, spaces, or underscores count as the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParentImage. 
        /// <para>
        /// The base image for the container recipe. This can be an Image Builder image resource
        /// ARN or a container image URI from a registry, for example <c>amazonlinux:latest</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ParentImage { get; set; }

        /// <summary>
        /// Checks to see if the ParentImage property is set.
        /// </summary>
        internal bool IsSetParentImage() => this.ParentImage != null;

        /// <summary>
        /// Gets and sets the property PlatformOverride. 
        /// <para>
        /// Specifies the operating system platform when you use a custom base image. Container
        /// recipes support only the Linux and Windows platforms.
        /// </para>
        /// </summary>
        public Platform PlatformOverride { get; set; }

        /// <summary>
        /// Checks to see if the PlatformOverride property is set.
        /// </summary>
        internal bool IsSetPlatformOverride() => this.PlatformOverride != null;

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the container recipe. This version follows the semantic version
        /// syntax.
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
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SemanticVersion { get; set; }

        /// <summary>
        /// Checks to see if the SemanticVersion property is set.
        /// </summary>
        internal bool IsSetSemanticVersion() => this.SemanticVersion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags that are attached to the container recipe.
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
        /// Gets and sets the property TargetRepository. 
        /// <para>
        /// The destination repository for the container image. The Amazon ECR repository must
        /// already exist in the Amazon Web Services Region where the build runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetContainerRepository TargetRepository { get; set; }

        /// <summary>
        /// Checks to see if the TargetRepository property is set.
        /// </summary>
        internal bool IsSetTargetRepository() => this.TargetRepository != null;

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory for use during build and test workflows.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}
