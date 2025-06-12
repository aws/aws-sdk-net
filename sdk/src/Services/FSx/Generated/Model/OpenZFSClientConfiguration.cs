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
    /// Specifies who can mount an OpenZFS file system and the options available while mounting
    /// the file system.
    /// </summary>
    public partial class OpenZFSClientConfiguration
    {
        private string _clients;
        private List<string> _options = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Clients. 
        /// <para>
        /// A value that specifies who can mount the file system. You can provide a wildcard character
        /// (<c>*</c>), an IP address (<c>0.0.0.0</c>), or a CIDR address (<c>192.0.2.0/24</c>).
        /// By default, Amazon FSx uses the wildcard character when specifying the client. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Clients
        {
            get { return this._clients; }
            set { this._clients = value; }
        }

        // Check to see if Clients property is set
        internal bool IsSetClients()
        {
            return this._clients != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options to use when mounting the file system. For a list of options that you can
        /// use with Network File System (NFS), see the <a href="https://linux.die.net/man/5/exports">exports(5)
        /// - Linux man page</a>. When choosing your options, consider the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>crossmnt</c> is used by default. If you don't specify <c>crossmnt</c> when changing
        /// the client configuration, you won't be able to see or access snapshots in your file
        /// system's snapshot directory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sync</c> is used by default. If you instead specify <c>async</c>, the system acknowledges
        /// writes before writing to disk. If the system crashes before the writes are finished,
        /// you lose the unwritten data. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}