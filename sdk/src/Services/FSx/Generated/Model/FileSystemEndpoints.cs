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
    /// An Amazon FSx for NetApp ONTAP file system has the following endpoints that are used
    /// to access data or to manage the file system using the NetApp ONTAP CLI, REST API,
    /// or NetApp SnapMirror.
    /// </summary>
    public partial class FileSystemEndpoints
    {
        private FileSystemEndpoint _intercluster;
        private FileSystemEndpoint _management;

        /// <summary>
        /// Gets and sets the property Intercluster. 
        /// <para>
        /// An endpoint for managing your file system by setting up NetApp SnapMirror with other
        /// ONTAP systems.
        /// </para>
        /// </summary>
        public FileSystemEndpoint Intercluster
        {
            get { return this._intercluster; }
            set { this._intercluster = value; }
        }

        // Check to see if Intercluster property is set
        internal bool IsSetIntercluster()
        {
            return this._intercluster != null;
        }

        /// <summary>
        /// Gets and sets the property Management. 
        /// <para>
        /// An endpoint for managing your file system using the NetApp ONTAP CLI and NetApp ONTAP
        /// API.
        /// </para>
        /// </summary>
        public FileSystemEndpoint Management
        {
            get { return this._management; }
            set { this._management = value; }
        }

        // Check to see if Management property is set
        internal bool IsSetManagement()
        {
            return this._management != null;
        }

    }
}