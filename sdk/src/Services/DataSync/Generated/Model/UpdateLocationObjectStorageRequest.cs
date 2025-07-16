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
    /// Container for the parameters to the UpdateLocationObjectStorage operation.
    /// Modifies the following configuration parameters of the object storage transfer location
    /// that you're using with DataSync.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Configuring
    /// DataSync transfers with an object storage system</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLocationObjectStorageRequest : AmazonDataSyncRequest
    {
        private string _accessKey;
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CmkSecretConfig _cmkSecretConfig;
        private CustomSecretConfig _customSecretConfig;
        private string _locationArn;
        private string _secretKey;
        private MemoryStream _serverCertificate;
        private string _serverHostname;
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
        [AWSProperty(Min=0, Max=200)]
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
        /// (Optional) Specifies the Amazon Resource Names (ARNs) of the DataSync agents that
        /// can connect with your object storage system. If you are setting up an agentless cross-cloud
        /// transfer, you do not need to specify a value for this parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot add or remove agents from a storage location after you initially create
        /// it.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._agentArns != null && (this._agentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Specifies configuration information for a DataSync-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig
        {
            get { return this._cmkSecretConfig; }
            set { this._cmkSecretConfig = value; }
        }

        // Check to see if CmkSecretConfig property is set
        internal bool IsSetCmkSecretConfig()
        {
            return this._cmkSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Specifies configuration information for a customer-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig
        {
            get { return this._customSecretConfig; }
            set { this._customSecretConfig = value; }
        }

        // Check to see if CustomSecretConfig property is set
        internal bool IsSetCustomSecretConfig()
        {
            return this._customSecretConfig != null;
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
        ///  <note> 
        /// <para>
        /// If you provide a secret using <c>SecretKey</c>, but do not provide secret configuration
        /// details using <c>CmkSecretConfig</c> or <c>CustomSecretConfig</c>, then DataSync stores
        /// the token using your Amazon Web Services account's Secrets Manager secret.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
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
        /// Specifies a certificate chain for DataSync to authenticate with your object storage
        /// system if the system uses a private or self-signed certificate authority (CA). You
        /// must specify a single <c>.pem</c> file with a full certificate chain (for example,
        /// <c>file:///home/user/.ssh/object_storage_certificates.pem</c>).
        /// </para>
        ///  
        /// <para>
        /// The certificate chain might include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The object storage system's certificate
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All intermediate certificates (if there are any)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The root certificate of the signing CA
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can concatenate your certificates into a <c>.pem</c> file (which can be up to
        /// 32768 bytes before base64 encoding). The following example <c>cat</c> command creates
        /// an <c>object_storage_certificates.pem</c> file that includes three certificates:
        /// </para>
        ///  
        /// <para>
        ///  <c>cat object_server_certificate.pem intermediate_certificate.pem ca_root_certificate.pem
        /// &gt; object_storage_certificates.pem</c> 
        /// </para>
        ///  
        /// <para>
        /// To use this parameter, configure <c>ServerProtocol</c> to <c>HTTPS</c>.
        /// </para>
        ///  
        /// <para>
        /// Updating this parameter doesn't interfere with tasks that you have in progress.
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
        /// Specifies the domain name or IP address (IPv4 or IPv6) of the object storage server
        /// that your DataSync agent connects to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        public int? ServerPort
        {
            get { return this._serverPort; }
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