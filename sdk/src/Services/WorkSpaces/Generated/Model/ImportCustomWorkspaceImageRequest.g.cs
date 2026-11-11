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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ImportCustomWorkspaceImage operation. Imports
    /// the specified Windows 10 or 11 Bring Your Own License (BYOL) image into Amazon WorkSpaces
    /// using EC2 Image Builder. The image must be an already licensed image that is in your
    /// Amazon Web Services account, and you must own the image. For more information about
    /// creating BYOL images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">
    /// Bring Your Own Windows Desktop Licenses</a>.
    /// </summary>
    public partial class ImportCustomWorkspaceImageRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// The supported compute type for the WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageComputeType ComputeType { get; set; }

        /// <summary>
        /// Checks to see if the ComputeType property is set.
        /// </summary>
        internal bool IsSetComputeType() => this.ComputeType != null;

        /// <summary>
        /// Gets and sets the property ImageDescription. 
        /// <para>
        /// The description of the WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ImageDescription { get; set; }

        /// <summary>
        /// Checks to see if the ImageDescription property is set.
        /// </summary>
        internal bool IsSetImageDescription() => this.ImageDescription != null;

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ImageName { get; set; }

        /// <summary>
        /// Checks to see if the ImageName property is set.
        /// </summary>
        internal bool IsSetImageName() => this.ImageName != null;

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// The options for image import source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageSourceIdentifier ImageSource { get; set; }

        /// <summary>
        /// Checks to see if the ImageSource property is set.
        /// </summary>
        internal bool IsSetImageSource() => this.ImageSource != null;

        /// <summary>
        /// Gets and sets the property ImageValidationMode. 
        /// <para>
        /// The image validation mode for the WorkSpace image import.
        /// </para>
        /// </summary>
        public ImageValidationMode ImageValidationMode { get; set; }

        /// <summary>
        /// Checks to see if the ImageValidationMode property is set.
        /// </summary>
        internal bool IsSetImageValidationMode() => this.ImageValidationMode != null;

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The infrastructure configuration ARN that specifies how the WorkSpace image is built.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string InfrastructureConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureConfigurationArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureConfigurationArn() => this.InfrastructureConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The OS version for the WorkSpace image source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OSVersion OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform for the WorkSpace image source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Platform Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The supported protocol for the WorkSpace image. Windows 11 does not support PCOIP
        /// protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomImageProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The resource tags. Each WorkSpaces resource can have a maximum of 50 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
