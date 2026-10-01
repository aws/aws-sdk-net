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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a device that Linux processes in a container can access.
    /// </summary>
    public partial class LambdaDeviceMount
    {
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
        public bool? AddGroupOwner { get; set; }

        /// <summary>
        /// Checks to see if the AddGroupOwner property is set.
        /// </summary>
        internal bool IsSetAddGroupOwner() => this.AddGroupOwner.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The mount path for the device in the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

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
        public LambdaFilesystemPermission Permission { get; set; }

        /// <summary>
        /// Checks to see if the Permission property is set.
        /// </summary>
        internal bool IsSetPermission() => this.Permission != null;
    }
}
