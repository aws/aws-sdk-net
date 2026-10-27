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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes an image.
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications associated with the image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Application> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<Application>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AppstreamAgentVersion. 
        /// <para>
        /// The version of the WorkSpaces Applications agent to use for instances that are launched
        /// from this image. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AppstreamAgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppstreamAgentVersion property is set.
        /// </summary>
        internal bool IsSetAppstreamAgentVersion() => this.AppstreamAgentVersion != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the image.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BaseImageArn. 
        /// <para>
        /// The ARN of the image from which this image was created.
        /// </para>
        /// </summary>
        public string BaseImageArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseImageArn property is set.
        /// </summary>
        internal bool IsSetBaseImageArn() => this.BaseImageArn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the image was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The image name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DynamicAppProvidersEnabled. 
        /// <para>
        /// Indicates whether dynamic app providers are enabled within an WorkSpaces Applications
        /// image or not.
        /// </para>
        /// </summary>
        public DynamicAppProvidersEnabled DynamicAppProvidersEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DynamicAppProvidersEnabled property is set.
        /// </summary>
        internal bool IsSetDynamicAppProvidersEnabled() => this.DynamicAppProvidersEnabled != null;

        /// <summary>
        /// Gets and sets the property ImageBuilderName. 
        /// <para>
        /// The name of the image builder that was used to create the private image. If the image
        /// is shared, copied, or updated by using Managed Image Updates, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ImageBuilderName { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuilderName property is set.
        /// </summary>
        internal bool IsSetImageBuilderName() => this.ImageBuilderName != null;

        /// <summary>
        /// Gets and sets the property ImageBuilderSupported. 
        /// <para>
        /// Indicates whether an image builder can be launched from this image.
        /// </para>
        /// </summary>
        public bool? ImageBuilderSupported { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuilderSupported property is set.
        /// </summary>
        internal bool IsSetImageBuilderSupported() => this.ImageBuilderSupported.HasValue;

        /// <summary>
        /// Gets and sets the property ImageErrors. 
        /// <para>
        /// Describes the errors that are returned when a new image can't be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceError> ImageErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceError>() : null;

        /// <summary>
        /// Checks to see if the ImageErrors property is set.
        /// </summary>
        internal bool IsSetImageErrors() => this.ImageErrors != null && (this.ImageErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImagePermissions. 
        /// <para>
        /// The permissions to provide to the destination AWS account for the specified image.
        /// </para>
        /// </summary>
        public ImagePermissions ImagePermissions { get; set; }

        /// <summary>
        /// Checks to see if the ImagePermissions property is set.
        /// </summary>
        internal bool IsSetImagePermissions() => this.ImagePermissions != null;

        /// <summary>
        /// Gets and sets the property ImageSharedWithOthers. 
        /// <para>
        /// Indicates whether the image is shared with another account ID.
        /// </para>
        /// </summary>
        public ImageSharedWithOthers ImageSharedWithOthers { get; set; }

        /// <summary>
        /// Checks to see if the ImageSharedWithOthers property is set.
        /// </summary>
        internal bool IsSetImageSharedWithOthers() => this.ImageSharedWithOthers != null;

        /// <summary>
        /// Gets and sets the property ImageSoftwareMetadata. 
        /// <para>
        /// The software metadata associated with the image.
        /// </para>
        /// </summary>
        public ImageSoftwareMetadata ImageSoftwareMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ImageSoftwareMetadata property is set.
        /// </summary>
        internal bool IsSetImageSoftwareMetadata() => this.ImageSoftwareMetadata != null;

        /// <summary>
        /// Gets and sets the property ImageType. 
        /// <para>
        /// The type of the image. Images created through AMI import have type "custom", while
        /// WorkSpaces Applications provided images have type "native". Custom images support
        /// additional instance types including GeneralPurpose, MemoryOptimized, ComputeOptimized,
        /// and Accelerated instance families.
        /// </para>
        /// </summary>
        public ImageType ImageType { get; set; }

        /// <summary>
        /// Checks to see if the ImageType property is set.
        /// </summary>
        internal bool IsSetImageType() => this.ImageType != null;

        /// <summary>
        /// Gets and sets the property LatestAppstreamAgentVersion. 
        /// <para>
        /// Indicates whether the image is using the latest WorkSpaces Applications agent version
        /// or not.
        /// </para>
        /// </summary>
        public LatestAppstreamAgentVersion LatestAppstreamAgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestAppstreamAgentVersion property is set.
        /// </summary>
        internal bool IsSetLatestAppstreamAgentVersion() => this.LatestAppstreamAgentVersion != null;

        /// <summary>
        /// Gets and sets the property ManagedSoftwareIncluded. 
        /// <para>
        /// Indicates whether the image includes license-included applications.
        /// </para>
        /// </summary>
        public bool? ManagedSoftwareIncluded { get; set; }

        /// <summary>
        /// Checks to see if the ManagedSoftwareIncluded property is set.
        /// </summary>
        internal bool IsSetManagedSoftwareIncluded() => this.ManagedSoftwareIncluded.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the image.
        /// </para>
        /// </summary>
        public PlatformType Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PublicBaseImageReleasedDate. 
        /// <para>
        /// The release date of the public base image. For private images, this date is the release
        /// date of the base image from which the image was created.
        /// </para>
        /// </summary>
        public DateTime? PublicBaseImageReleasedDate { get; set; }

        /// <summary>
        /// Checks to see if the PublicBaseImageReleasedDate property is set.
        /// </summary>
        internal bool IsSetPublicBaseImageReleasedDate() => this.PublicBaseImageReleasedDate.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The image starts in the <c>PENDING</c> state. If image creation succeeds, the state
        /// is <c>AVAILABLE</c>. If image creation fails, the state is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ImageState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The reason why the last state change occurred.
        /// </para>
        /// </summary>
        public ImageStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeReason property is set.
        /// </summary>
        internal bool IsSetStateChangeReason() => this.StateChangeReason != null;

        /// <summary>
        /// Gets and sets the property SupportedInstanceFamilies. 
        /// <para>
        /// The supported instances families that determine which image a customer can use when
        /// the customer launches a fleet or image builder. The following instances families are
        /// supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// General Purpose
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Compute Optimized
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Memory Optimized
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Graphics G4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Graphics G5
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Graphics G6
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedInstanceFamilies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedInstanceFamilies property is set.
        /// </summary>
        internal bool IsSetSupportedInstanceFamilies() => this.SupportedInstanceFamilies != null && (this.SupportedInstanceFamilies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Indicates whether the image is public or private.
        /// </para>
        /// </summary>
        public VisibilityType Visibility { get; set; }

        /// <summary>
        /// Checks to see if the Visibility property is set.
        /// </summary>
        internal bool IsSetVisibility() => this.Visibility != null;
    }
}
