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
    /// Specifies the version of the Server Message Block (SMB) protocol that DataSync uses
    /// to access an SMB file server.
    /// </summary>
    public partial class SmbMountOptions
    {
        private SmbVersion _version;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// By default, DataSync automatically chooses an SMB protocol version based on negotiation
        /// with your SMB file server. You also can configure DataSync to use a specific SMB version,
        /// but we recommend doing this only if DataSync has trouble negotiating with the SMB
        /// file server automatically.
        /// </para>
        ///  
        /// <para>
        /// These are the following options for configuring the SMB version:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AUTOMATIC</code> (default): DataSync and the SMB file server negotiate a protocol
        /// version that they mutually support. (DataSync supports SMB versions 1.0 and later.)
        /// </para>
        ///  
        /// <para>
        /// This is the recommended option. If you instead choose a specific version that your
        /// file server doesn't support, you may get an <code>Operation Not Supported</code> error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMB3</code>: Restricts the protocol negotiation to only SMB version 3.0.2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMB2</code>: Restricts the protocol negotiation to only SMB version 2.1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMB2_0</code>: Restricts the protocol negotiation to only SMB version 2.0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMB1</code>: Restricts the protocol negotiation to only SMB version 1.0.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>SMB1</code> option isn't available when <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateLocationFsxOntap.html">creating
        /// an Amazon FSx for NetApp ONTAP location</a>.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public SmbVersion Version
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