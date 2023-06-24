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
    /// An image summary.
    /// </summary>
    public partial class ImageSummary
    {
        private string _arn;
        private BuildType _buildType;
        private string _dateCreated;
        private ImageSource _imageSource;
        private string _name;
        private string _osVersion;
        private OutputResources _outputResources;
        private string _owner;
        private Platform _platform;
        private ImageState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private ImageType _type;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image.
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
        /// Gets and sets the property BuildType. 
        /// <para>
        /// Indicates the type of build that created this image. The build can be initiated in
        /// the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>USER_INITIATED</b> – A manual pipeline build request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SCHEDULED</b> – A pipeline build initiated by a cron expression in the Image Builder
        /// pipeline, or from EventBridge.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IMPORT</b> – A VM import created the image to use as the base image for the recipe.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BuildType BuildType
        {
            get { return this._buildType; }
            set { this._buildType = value; }
        }

        // Check to see if BuildType property is set
        internal bool IsSetBuildType()
        {
            return this._buildType != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date on which Image Builder created this image.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// The origin of the base image that Image Builder used to build this image.
        /// </para>
        /// </summary>
        public ImageSource ImageSource
        {
            get { return this._imageSource; }
            set { this._imageSource = value; }
        }

        // Check to see if ImageSource property is set
        internal bool IsSetImageSource()
        {
            return this._imageSource != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image.
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
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system version of the instances that launch from this image. For example,
        /// Amazon Linux 2, Ubuntu 18, or Microsoft Windows Server 2019.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }

        // Check to see if OsVersion property is set
        internal bool IsSetOsVersion()
        {
            return this._osVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OutputResources. 
        /// <para>
        /// The output resources that Image Builder produced when it created this image.
        /// </para>
        /// </summary>
        public OutputResources OutputResources
        {
            get { return this._outputResources; }
            set { this._outputResources = value; }
        }

        // Check to see if OutputResources property is set
        internal bool IsSetOutputResources()
        {
            return this._outputResources != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The image operating system platform, such as Linux or Windows.
        /// </para>
        /// </summary>
        public Platform Platform
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the image.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that apply to this image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies whether this image produces an AMI or a container image.
        /// </para>
        /// </summary>
        public ImageType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the image.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}