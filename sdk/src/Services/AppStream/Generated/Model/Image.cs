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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
        private List<Application> _applications = AWSConfigs.InitializeCollections ? new List<Application>() : null;
        private string _appstreamAgentVersion;
        private string _arn;
        private string _baseImageArn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private DynamicAppProvidersEnabled _dynamicAppProvidersEnabled;
        private string _imageBuilderName;
        private bool? _imageBuilderSupported;
        private List<ResourceError> _imageErrors = AWSConfigs.InitializeCollections ? new List<ResourceError>() : null;
        private ImagePermissions _imagePermissions;
        private ImageSharedWithOthers _imageSharedWithOthers;
        private LatestAppstreamAgentVersion _latestAppstreamAgentVersion;
        private string _name;
        private PlatformType _platform;
        private DateTime? _publicBaseImageReleasedDate;
        private ImageState _state;
        private ImageStateChangeReason _stateChangeReason;
        private List<string> _supportedInstanceFamilies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VisibilityType _visibility;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications associated with the image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Application> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AppstreamAgentVersion. 
        /// <para>
        /// The version of the AppStream 2.0 agent to use for instances that are launched from
        /// this image. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AppstreamAgentVersion
        {
            get { return this._appstreamAgentVersion; }
            set { this._appstreamAgentVersion = value; }
        }

        // Check to see if AppstreamAgentVersion property is set
        internal bool IsSetAppstreamAgentVersion()
        {
            return this._appstreamAgentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the image.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BaseImageArn. 
        /// <para>
        /// The ARN of the image from which this image was created.
        /// </para>
        /// </summary>
        public string BaseImageArn
        {
            get { return this._baseImageArn; }
            set { this._baseImageArn = value; }
        }

        // Check to see if BaseImageArn property is set
        internal bool IsSetBaseImageArn()
        {
            return this._baseImageArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the image was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The image name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicAppProvidersEnabled. 
        /// <para>
        /// Indicates whether dynamic app providers are enabled within an AppStream 2.0 image
        /// or not.
        /// </para>
        /// </summary>
        public DynamicAppProvidersEnabled DynamicAppProvidersEnabled
        {
            get { return this._dynamicAppProvidersEnabled; }
            set { this._dynamicAppProvidersEnabled = value; }
        }

        // Check to see if DynamicAppProvidersEnabled property is set
        internal bool IsSetDynamicAppProvidersEnabled()
        {
            return this._dynamicAppProvidersEnabled != null;
        }

        /// <summary>
        /// Gets and sets the property ImageBuilderName. 
        /// <para>
        /// The name of the image builder that was used to create the private image. If the image
        /// is shared, copied, or updated by using Managed Image Updates, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ImageBuilderName
        {
            get { return this._imageBuilderName; }
            set { this._imageBuilderName = value; }
        }

        // Check to see if ImageBuilderName property is set
        internal bool IsSetImageBuilderName()
        {
            return this._imageBuilderName != null;
        }

        /// <summary>
        /// Gets and sets the property ImageBuilderSupported. 
        /// <para>
        /// Indicates whether an image builder can be launched from this image.
        /// </para>
        /// </summary>
        public bool? ImageBuilderSupported
        {
            get { return this._imageBuilderSupported; }
            set { this._imageBuilderSupported = value; }
        }

        // Check to see if ImageBuilderSupported property is set
        internal bool IsSetImageBuilderSupported()
        {
            return this._imageBuilderSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageErrors. 
        /// <para>
        /// Describes the errors that are returned when a new image can't be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceError> ImageErrors
        {
            get { return this._imageErrors; }
            set { this._imageErrors = value; }
        }

        // Check to see if ImageErrors property is set
        internal bool IsSetImageErrors()
        {
            return this._imageErrors != null && (this._imageErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImagePermissions. 
        /// <para>
        /// The permissions to provide to the destination AWS account for the specified image.
        /// </para>
        /// </summary>
        public ImagePermissions ImagePermissions
        {
            get { return this._imagePermissions; }
            set { this._imagePermissions = value; }
        }

        // Check to see if ImagePermissions property is set
        internal bool IsSetImagePermissions()
        {
            return this._imagePermissions != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSharedWithOthers. 
        /// <para>
        /// Indicates whether the image is shared with another account ID.
        /// </para>
        /// </summary>
        public ImageSharedWithOthers ImageSharedWithOthers
        {
            get { return this._imageSharedWithOthers; }
            set { this._imageSharedWithOthers = value; }
        }

        // Check to see if ImageSharedWithOthers property is set
        internal bool IsSetImageSharedWithOthers()
        {
            return this._imageSharedWithOthers != null;
        }

        /// <summary>
        /// Gets and sets the property LatestAppstreamAgentVersion. 
        /// <para>
        /// Indicates whether the image is using the latest AppStream 2.0 agent version or not.
        /// </para>
        /// </summary>
        public LatestAppstreamAgentVersion LatestAppstreamAgentVersion
        {
            get { return this._latestAppstreamAgentVersion; }
            set { this._latestAppstreamAgentVersion = value; }
        }

        // Check to see if LatestAppstreamAgentVersion property is set
        internal bool IsSetLatestAppstreamAgentVersion()
        {
            return this._latestAppstreamAgentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the image.
        /// </para>
        /// </summary>
        public PlatformType Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property PublicBaseImageReleasedDate. 
        /// <para>
        /// The release date of the public base image. For private images, this date is the release
        /// date of the base image from which the image was created.
        /// </para>
        /// </summary>
        public DateTime? PublicBaseImageReleasedDate
        {
            get { return this._publicBaseImageReleasedDate; }
            set { this._publicBaseImageReleasedDate = value; }
        }

        // Check to see if PublicBaseImageReleasedDate property is set
        internal bool IsSetPublicBaseImageReleasedDate()
        {
            return this._publicBaseImageReleasedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The image starts in the <c>PENDING</c> state. If image creation succeeds, the state
        /// is <c>AVAILABLE</c>. If image creation fails, the state is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The reason why the last state change occurred.
        /// </para>
        /// </summary>
        public ImageStateChangeReason StateChangeReason
        {
            get { return this._stateChangeReason; }
            set { this._stateChangeReason = value; }
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this._stateChangeReason != null;
        }

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
        /// Graphics
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Graphics Design
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Graphics Pro
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Graphics G4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Graphics G5
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedInstanceFamilies
        {
            get { return this._supportedInstanceFamilies; }
            set { this._supportedInstanceFamilies = value; }
        }

        // Check to see if SupportedInstanceFamilies property is set
        internal bool IsSetSupportedInstanceFamilies()
        {
            return this._supportedInstanceFamilies != null && (this._supportedInstanceFamilies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Indicates whether the image is public or private.
        /// </para>
        /// </summary>
        public VisibilityType Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}