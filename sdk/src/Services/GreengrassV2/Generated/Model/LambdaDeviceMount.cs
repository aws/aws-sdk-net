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
    /// Contains information about a device that Linux processes in a container can access.
    /// </summary>
    public partial class LambdaDeviceMount
    {
        private bool? _addGroupOwner;
        private string _path;
        private LambdaFilesystemPermission _permission;

        /// <summary>
        /// Gets and sets the property AddGroupOwner. 
        /// <para>
        /// Whether or not to add the component's system user as an owner of the device.
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The mount path for the device in the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The permission to access the device: read/only (<c>ro</c>) or read/write (<c>rw</c>).
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

    }
}