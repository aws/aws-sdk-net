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
    /// Container for the parameters to the UpdateLocationObjectStorage operation.
    /// Updates some parameters of an existing object storage location that DataSync accesses
    /// for a transfer. For information about creating a self-managed object storage location,
    /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
    /// a location for object storage</a>.
    /// </summary>
    public partial class UpdateLocationObjectStorageRequest : AmazonDataSyncRequest
    {
        private string _accessKey;
        private List<string> _agentArns = new List<string>();
        private string _locationArn;
        private string _secretKey;
        private MemoryStream _serverCertificate;
        private int? _serverPort;
        private ObjectStorageServerProtocol _serverProtocol;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// Specifies the access key (for example, a user name) if credentials are required to
        /// authenticate with the object storage server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string AccessKey
        {
            get { return this._accessKey; }
            set { this._accessKey = value; }
        }

        // Check to see if AccessKey property is set
        internal bool IsSetAccessKey()
        {
            return this._accessKey != null;
        }

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// Specifies the Amazon Resource Names (ARNs) of the DataSync agents that can securely
        /// connect with your location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && this._agentArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the ARN of the object storage system location that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretKey. 
        /// <para>
        /// Specifies the secret key (for example, a password) if credentials are required to
        /// authenticate with the object storage server.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string SecretKey
        {
            get { return this._secretKey; }
            set { this._secretKey = value; }
        }

        // Check to see if SecretKey property is set
        internal bool IsSetSecretKey()
        {
            return this._secretKey != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificate. 
        /// <para>
        /// Specifies a certificate to authenticate with an object storage system that uses a
        /// private or self-signed certificate authority (CA). You must specify a Base64-encoded
        /// <code>.pem</code> file (for example, <code>file:///home/user/.ssh/storage_sys_certificate.pem</code>).
        /// The certificate can be up to 32768 bytes (before Base64 encoding).
        /// </para>
        ///  
        /// <para>
        /// To use this parameter, configure <code>ServerProtocol</code> to <code>HTTPS</code>.
        /// </para>
        ///  
        /// <para>
        /// Updating the certificate doesn't interfere with tasks that you have in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public MemoryStream ServerCertificate
        {
            get { return this._serverCertificate; }
            set { this._serverCertificate = value; }
        }

        // Check to see if ServerCertificate property is set
        internal bool IsSetServerCertificate()
        {
            return this._serverCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// Specifies the port that your object storage server accepts inbound network traffic
        /// on (for example, port 443).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public int ServerPort
        {
            get { return this._serverPort.GetValueOrDefault(); }
            set { this._serverPort = value; }
        }

        // Check to see if ServerPort property is set
        internal bool IsSetServerPort()
        {
            return this._serverPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerProtocol. 
        /// <para>
        /// Specifies the protocol that your object storage server uses to communicate.
        /// </para>
        /// </summary>
        public ObjectStorageServerProtocol ServerProtocol
        {
            get { return this._serverProtocol; }
            set { this._serverProtocol = value; }
        }

        // Check to see if ServerProtocol property is set
        internal bool IsSetServerProtocol()
        {
            return this._serverProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies the object prefix for your object storage server. If this is a source location,
        /// DataSync only copies objects with this prefix. If this is a destination location,
        /// DataSync writes all objects with this prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

    }
}