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
    /// Container for the parameters to the CreateImageRecipe operation. Creates a new image
    /// recipe. Image recipes define how images are configured, tested, and assessed.
    /// </summary>
    public partial class CreateImageRecipeRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalInstanceConfiguration. 
        /// <para>
        /// The additional settings and launch scripts for your build instances.
        /// </para>
        /// </summary>
        public AdditionalInstanceConfiguration AdditionalInstanceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInstanceConfiguration property is set.
        /// </summary>
        internal bool IsSetAdditionalInstanceConfiguration() => this.AdditionalInstanceConfiguration != null;

        /// <summary>
        /// Gets and sets the property AmiTags. 
        /// <para>
        /// Tags that are applied to the AMI that Image Builder creates during the Build phase
        /// prior to image distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> AmiTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AmiTags property is set.
        /// </summary>
        internal bool IsSetAmiTags() => this.AmiTags != null && (this.AmiTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AmiWatermarks. 
        /// <para>
        /// The AMI watermark names to attach to the output AMI from this recipe. AMI watermarks
        /// are lineage markers. They automatically propagate to derivative AMIs when the source
        /// AMI is copied or distributed across Regions or accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// AMI watermarks are supported only for image recipes. AMIs with watermarks cannot be
        /// made public.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> AmiWatermarks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AmiWatermarks property is set.
        /// </summary>
        internal bool IsSetAmiWatermarks() => this.AmiWatermarks != null && (this.AmiWatermarks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mappings that Image Builder applies to the build instance and the
        /// output AMI. For example, you can override the size of the base image's root volume
        /// or attach additional EBS volumes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceBlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The components included in the image recipe. Components are optional. A recipe with
        /// no components bakes the base image without additional customization. You can specify
        /// each component only one time in a recipe. Components with a status of <c>DEPRECATED</c>
        /// or <c>DISABLED</c> can't be added to new recipes.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the image recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image recipe. The recipe name, combined with the semantic version,
        /// must be unique to your account in each Amazon Web Services Region. Image Builder generates
        /// the image recipe ARN from a normalized form of the name, so names that differ only
        /// in case, spaces, or underscores count as the same name.
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
        /// The base image for customizations specified in the image recipe. You can specify the
        /// parent image using one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AMI ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Image Builder image Amazon Resource Name (ARN)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Systems Manager (SSM) Parameter Store Parameter, prefixed by <c>ssm:</c>,
        /// followed by the parameter name or ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Marketplace product ID
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you enter an AMI ID or an SSM parameter that contains the AMI ID, you must have
        /// access to the AMI. The AMI must also be in the Region where you're creating the recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ParentImage { get; set; }

        /// <summary>
        /// Checks to see if the ParentImage property is set.
        /// </summary>
        internal bool IsSetParentImage() => this.ParentImage != null;

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        /// The semantic version of the image recipe. This version follows the semantic version
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
        /// The tags of the image recipe.
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
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory used during build and test workflows. If you don't specify a
        /// working directory, Image Builder uses <c>/tmp</c> for Linux and macOS build instances,
        /// and <c>C:/</c> for Windows build instances.
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
