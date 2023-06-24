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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies how DataSync can access a location using the NFS protocol.
    /// </summary>
    public partial class NfsMountOptions
    {
        private NfsVersion _version;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Specifies the NFS version that you want DataSync to use when mounting your NFS share.
        /// If the server refuses to use the version specified, the task fails.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AUTOMATIC</code> (default): DataSync chooses NFS version 4.1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NFS3</code>: Stateless protocol version that allows for asynchronous writes
        /// on the server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NFSv4_0</code>: Stateful, firewall-friendly protocol version that supports
        /// delegations and pseudo file systems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NFSv4_1</code>: Stateful protocol version that supports sessions, directory
        /// delegations, and parallel data processing. NFS version 4.1 also includes all features
        /// available in version 4.0.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// DataSync currently only supports NFS version 3 with Amazon FSx for NetApp ONTAP locations.
        /// </para>
        ///  </note>
        /// </summary>
        public NfsVersion Version
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