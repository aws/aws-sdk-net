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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// An Amazon FSx for NetApp ONTAP storage virtual machine (SVM) has the following endpoints
    /// that are used to access data or to manage the SVM using the NetApp ONTAP CLI, REST
    /// API, or NetApp CloudManager.
    /// </summary>
    public partial class SvmEndpoints
    {
        /// <summary>
        /// Gets and sets the property Iscsi. 
        /// <para>
        /// An endpoint for connecting using the Internet Small Computer Systems Interface (iSCSI)
        /// protocol.
        /// </para>
        /// </summary>
        public SvmEndpoint Iscsi { get; set; }

        /// <summary>
        /// Checks to see if the Iscsi property is set.
        /// </summary>
        internal bool IsSetIscsi() => this.Iscsi != null;

        /// <summary>
        /// Gets and sets the property Management. 
        /// <para>
        /// An endpoint for managing SVMs using the NetApp ONTAP CLI, NetApp ONTAP API, or NetApp
        /// CloudManager.
        /// </para>
        /// </summary>
        public SvmEndpoint Management { get; set; }

        /// <summary>
        /// Checks to see if the Management property is set.
        /// </summary>
        internal bool IsSetManagement() => this.Management != null;

        /// <summary>
        /// Gets and sets the property Nfs. 
        /// <para>
        /// An endpoint for connecting using the Network File System (NFS) protocol.
        /// </para>
        /// </summary>
        public SvmEndpoint Nfs { get; set; }

        /// <summary>
        /// Checks to see if the Nfs property is set.
        /// </summary>
        internal bool IsSetNfs() => this.Nfs != null;

        /// <summary>
        /// Gets and sets the property Smb. 
        /// <para>
        /// An endpoint for connecting using the Server Message Block (SMB) protocol.
        /// </para>
        /// </summary>
        public SvmEndpoint Smb { get; set; }

        /// <summary>
        /// Checks to see if the Smb property is set.
        /// </summary>
        internal bool IsSetSmb() => this.Smb != null;
    }
}
