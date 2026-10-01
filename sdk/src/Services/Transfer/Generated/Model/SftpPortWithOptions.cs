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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Specifies the configuration for a single SFTP port on a Transfer Family server that
    /// uses the SFTP protocol and has a <c>PUBLIC</c> endpoint. Each entry in the <c>SftpPorts</c>
    /// list is an <c>SftpPortWithOptions</c> object that pairs a port number with a communication
    /// mode.
    /// </summary>
    public partial class SftpPortWithOptions
    {
        private CommunicationMode _communicationMode;
        private int? _sftpPort;

        /// <summary>
        /// Gets and sets the property CommunicationMode. 
        /// <para>
        /// Determines whether the server or the client sends data first when a client establishes
        /// an SFTP connection on this port. Valid values are <c>SERVER_TALK_FIRST</c> and <c>CLIENT_TALK_FIRST</c>.
        /// For a description of each mode, see the <c>SftpPorts</c> property. This value is optional.
        /// </para>
        /// </summary>
        public CommunicationMode CommunicationMode
        {
            get { return this._communicationMode; }
            set { this._communicationMode = value; }
        }

        // Check to see if CommunicationMode property is set
        internal bool IsSetCommunicationMode()
        {
            return this._communicationMode != null;
        }

        /// <summary>
        /// Gets and sets the property SftpPort. 
        /// <para>
        /// The port on which the Transfer Family server listens for SFTP connections. Specify
        /// any integer from 2000 to 65535, or 22. This value is required for each entry in the
        /// <c>SftpPorts</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? SftpPort
        {
            get { return this._sftpPort; }
            set { this._sftpPort = value; }
        }

        // Check to see if SftpPort property is set
        internal bool IsSetSftpPort()
        {
            return this._sftpPort.HasValue; 
        }

    }
}