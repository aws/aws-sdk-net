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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines a custom base AMI and block device mapping configurations of an instance used
    /// for building and testing container images.
    /// </summary>
    public partial class InstanceConfiguration
    {
        private List<InstanceBlockDeviceMapping> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<InstanceBlockDeviceMapping>() : null;
        private string _image;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Defines the block devices to attach for building an instance from this Image Builder
        /// AMI.
        /// </para>
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && (this._blockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The AMI ID to use as the base image for a container build and test instance. If not
        /// specified, Image Builder will use the appropriate ECS-optimized AMI as a base image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}