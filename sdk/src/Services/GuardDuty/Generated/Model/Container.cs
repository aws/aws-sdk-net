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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Details of a container.
    /// </summary>
    public partial class Container
    {
        private string _containerRuntime;
        private string _id;
        private string _image;
        private string _imagePrefix;
        private string _name;
        private SecurityContext _securityContext;
        private List<VolumeMount> _volumeMounts = AWSConfigs.InitializeCollections ? new List<VolumeMount>() : null;

        /// <summary>
        /// Gets and sets the property ContainerRuntime. 
        /// <para>
        /// The container runtime (such as, Docker or containerd) used to run the container.
        /// </para>
        /// </summary>
        public string ContainerRuntime
        {
            get { return this._containerRuntime; }
            set { this._containerRuntime = value; }
        }

        // Check to see if ContainerRuntime property is set
        internal bool IsSetContainerRuntime()
        {
            return this._containerRuntime != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Container ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// Container image.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePrefix. 
        /// <para>
        /// Part of the image name before the last slash. For example, imagePrefix for public.ecr.aws/amazonlinux/amazonlinux:latest
        /// would be public.ecr.aws/amazonlinux. If the image name is relative and does not have
        /// a slash, this field is empty.
        /// </para>
        /// </summary>
        public string ImagePrefix
        {
            get { return this._imagePrefix; }
            set { this._imagePrefix = value; }
        }

        // Check to see if ImagePrefix property is set
        internal bool IsSetImagePrefix()
        {
            return this._imagePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Container name.
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
        /// Gets and sets the property SecurityContext. 
        /// <para>
        /// Container security context.
        /// </para>
        /// </summary>
        public SecurityContext SecurityContext
        {
            get { return this._securityContext; }
            set { this._securityContext = value; }
        }

        // Check to see if SecurityContext property is set
        internal bool IsSetSecurityContext()
        {
            return this._securityContext != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeMounts. 
        /// <para>
        /// Container volume mounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeMount> VolumeMounts
        {
            get { return this._volumeMounts; }
            set { this._volumeMounts = value; }
        }

        // Check to see if VolumeMounts property is set
        internal bool IsSetVolumeMounts()
        {
            return this._volumeMounts != null && (this._volumeMounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}