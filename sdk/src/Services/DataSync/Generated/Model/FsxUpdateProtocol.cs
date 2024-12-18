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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies the data transfer protocol that DataSync uses to access your Amazon FSx
    /// file system.
    /// 
    ///  <note> 
    /// <para>
    /// You can't update the Network File System (NFS) protocol configuration for FSx for
    /// ONTAP locations. DataSync currently only supports NFS version 3 with this location
    /// type.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class FsxUpdateProtocol
    {
        private FsxProtocolNfs _nfs;
        private FsxUpdateProtocolSmb _smb;

        /// <summary>
        /// Gets and sets the property NFS.
        /// </summary>
        public FsxProtocolNfs NFS
        {
            get { return this._nfs; }
            set { this._nfs = value; }
        }

        // Check to see if NFS property is set
        internal bool IsSetNFS()
        {
            return this._nfs != null;
        }

        /// <summary>
        /// Gets and sets the property SMB. 
        /// <para>
        /// Specifies the Server Message Block (SMB) protocol configuration that DataSync uses
        /// to access your FSx for ONTAP file system's storage virtual machine (SVM).
        /// </para>
        /// </summary>
        public FsxUpdateProtocolSmb SMB
        {
            get { return this._smb; }
            set { this._smb = value; }
        }

        // Check to see if SMB property is set
        internal bool IsSetSMB()
        {
            return this._smb != null;
        }

    }
}