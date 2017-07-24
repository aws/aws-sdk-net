/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// New streaming instances are booted from images. The image stores the application catalog
    /// and is connected to fleets.
    /// </summary>
    public partial class Image
    {
        private List<Application> _applications = new List<Application>();
        private string _arn;
        private string _baseImageArn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private bool? _imageBuilderSupported;
        private string _name;
        private PlatformType _platform;
        private DateTime? _publicBaseImageReleasedDate;
        private ImageState _state;
        private ImageStateChangeReason _stateChangeReason;
        private VisibilityType _visibility;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications associated with an image.
        /// </para>
        /// </summary>
        public List<Application> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && this._applications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the image.
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
        /// The source image ARN from which this image was created.
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
        /// The time stamp when the image was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
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
        /// A meaningful description for the image.
        /// </para>
        /// </summary>
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
        /// The display name for the image.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ImageBuilderSupported. 
        /// <para>
        /// Whether an image builder can be launched from this image.
        /// </para>
        /// </summary>
        public bool ImageBuilderSupported
        {
            get { return this._imageBuilderSupported.GetValueOrDefault(); }
            set { this._imageBuilderSupported = value; }
        }

        // Check to see if ImageBuilderSupported property is set
        internal bool IsSetImageBuilderSupported()
        {
            return this._imageBuilderSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique identifier for the image.
        /// </para>
        /// </summary>
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
        /// The AWS release date of the public base image. For private images, this date is the
        /// release date of the base image from which the image was created.
        /// </para>
        /// </summary>
        public DateTime PublicBaseImageReleasedDate
        {
            get { return this._publicBaseImageReleasedDate.GetValueOrDefault(); }
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
        /// The image starts in the <b>PENDING</b> state. If image creation succeeds, it moves
        /// to <b>AVAILABLE</b>. If image creation fails, it moves to <b>FAILED</b>.
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
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of an image to the user; images can be public or private.
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