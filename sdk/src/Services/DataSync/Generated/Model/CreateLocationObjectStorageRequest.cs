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
    /// Container for the parameters to the CreateLocationObjectStorage operation.
    /// Creates an endpoint for an object storage system that DataSync can access for a transfer.
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
    /// a location for object storage</a>.
    /// </summary>
    public partial class CreateLocationObjectStorageRequest : AmazonDataSyncRequest
    {
        private string _accessKey;
        private List<string> _agentArns = new List<string>();
        private string _bucketName;
        private string _secretKey;
        private MemoryStream _serverCertificate;
        private string _serverHostname;
        private int? _serverPort;
        private ObjectStorageServerProtocol _serverProtocol;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

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
        [AWSProperty(Required=true, Min=1, Max=4)]
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
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Specifies the name of the object storage bucket involved in the transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
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
        /// Gets and sets the property ServerHostname. 
        /// <para>
        /// Specifies the domain name or IP address of the object storage server. A DataSync agent
        /// uses this hostname to mount the object storage server in a network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ServerHostname
        {
            get { return this._serverHostname; }
            set { this._serverHostname = value; }
        }

        // Check to see if ServerHostname property is set
        internal bool IsSetServerHostname()
        {
            return this._serverHostname != null;
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pair that represents a tag that you want to add to the resource.
        /// Tags can help you manage, filter, and search for your resources. We recommend creating
        /// a name tag for your location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}