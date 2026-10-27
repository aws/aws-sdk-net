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
    /// An image recipe.
    /// </summary>
    public partial class ImageRecipe
    {
        /// <summary>
        /// Gets and sets the property AdditionalInstanceConfiguration. 
        /// <para>
        /// Before you create a new AMI, Image Builder launches temporary Amazon EC2 instances
        /// to build and test your image configuration. Instance configuration adds a layer of
        /// control over those instances. You can define settings and add scripts to run when
        /// Image Builder launches your build instance.
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
        /// The AMI watermark names attached to the output AMI from this recipe. AMI watermarks
        /// are lineage markers that automatically propagate to derivative AMIs when the source
        /// AMI is copied or distributed.
        /// </para>
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image recipe.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mappings to apply when creating images from this recipe.
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
        /// Gets and sets the property Components. 
        /// <para>
        /// The components that are included in the image recipe. A recipe can contain a maximum
        /// of 20 build and test components in any combination, by default. This maximum is an
        /// adjustable quota. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/imagebuilder.html">EC2
        /// Image Builder endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which this image recipe was created.
        /// </para>
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated != null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image recipe.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the image recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

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
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ParentImage { get; set; }

        /// <summary>
        /// Checks to see if the ParentImage property is set.
        /// </summary>
        internal bool IsSetParentImage() => this.ParentImage != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the image recipe.
        /// </para>
        /// </summary>
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

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
        /// Gets and sets the property Type. 
        /// <para>
        /// The output image type. For an image recipe, this is always AMI. Container images are
        /// built from container recipes, a separate resource. This field isn't currently returned
        /// in responses.
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
        /// The version of the image recipe.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

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
