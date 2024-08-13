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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a volume that Linux processes in a container can access.
    /// When you define a volume, the IoT Greengrass Core software mounts the source files
    /// to the destination inside the container.
    /// </summary>
    public partial class LambdaVolumeMount
    {
        private bool? _addGroupOwner;
        private string _destinationPath;
        private LambdaFilesystemPermission _permission;
        private string _sourcePath;

        /// <summary>
        /// Gets and sets the property AddGroupOwner. 
        /// <para>
        /// Whether or not to add the IoT Greengrass user group as an owner of the volume.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? AddGroupOwner
        {
            get { return this._addGroupOwner; }
            set { this._addGroupOwner = value; }
        }

        // Check to see if AddGroupOwner property is set
        internal bool IsSetAddGroupOwner()
        {
            return this._addGroupOwner.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationPath. 
        /// <para>
        /// The path to the logical volume in the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationPath
        {
            get { return this._destinationPath; }
            set { this._destinationPath = value; }
        }

        // Check to see if DestinationPath property is set
        internal bool IsSetDestinationPath()
        {
            return this._destinationPath != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The permission to access the volume: read/only (<c>ro</c>) or read/write (<c>rw</c>).
        /// </para>
        ///  
        /// <para>
        /// Default: <c>ro</c> 
        /// </para>
        /// </summary>
        public LambdaFilesystemPermission Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// The path to the physical volume in the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourcePath
        {
            get { return this._sourcePath; }
            set { this._sourcePath = value; }
        }

        // Check to see if SourcePath property is set
        internal bool IsSetSourcePath()
        {
            return this._sourcePath != null;
        }

    }
}