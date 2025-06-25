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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Describes the FSx for OpenZFS attachment configuration of an S3 access point attachment.
    /// </summary>
    public partial class S3AccessPointOpenZFSConfiguration
    {
        private OpenZFSFileSystemIdentity _fileSystemIdentity;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property FileSystemIdentity. 
        /// <para>
        /// The file system identity used to authorize file access requests made using the S3
        /// access point.
        /// </para>
        /// </summary>
        public OpenZFSFileSystemIdentity FileSystemIdentity
        {
            get { return this._fileSystemIdentity; }
            set { this._fileSystemIdentity = value; }
        }

        // Check to see if FileSystemIdentity property is set
        internal bool IsSetFileSystemIdentity()
        {
            return this._fileSystemIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the FSx for OpenZFS volume that the S3 access point is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=23, Max=23)]
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}