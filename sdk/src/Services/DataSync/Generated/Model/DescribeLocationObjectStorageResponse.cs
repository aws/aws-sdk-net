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
    /// DescribeLocationObjectStorageResponse
    /// </summary>
    public partial class DescribeLocationObjectStorageResponse : AmazonWebServiceResponse
    {
        private string _accessKey;
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CmkSecretConfig _cmkSecretConfig;
        private DateTime? _creationTime;
        private CustomSecretConfig _customSecretConfig;
        private string _locationArn;
        private string _locationUri;
        private ManagedSecretConfig _managedSecretConfig;
        private MemoryStream _serverCertificate;
        private int? _serverPort;
        private ObjectStorageServerProtocol _serverProtocol;

        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// The access key (for example, a user name) required to authenticate with the object
        /// storage system.
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
        /// The ARNs of the DataSync agents that can connect with your object storage system.
        /// </para>
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
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Describes configuration information for a customer-managed secret, such as an authentication
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
        /// The ARN of the object storage system location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URI of the object storage system location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4360)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location.
        /// DataSync uses the default Amazon Web Services-managed KMS key to encrypt this secret
        /// in Secrets Manager.
        /// </para>
        /// </summary>
        public ManagedSecretConfig ManagedSecretConfig
        {
            get { return this._managedSecretConfig; }
            set { this._managedSecretConfig = value; }
        }

        // Check to see if ManagedSecretConfig property is set
        internal bool IsSetManagedSecretConfig()
        {
            return this._managedSecretConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificate. 
        /// <para>
        /// The certificate chain for DataSync to authenticate with your object storage system
        /// if the system uses a private or self-signed certificate authority (CA).
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
        /// The port that your object storage server accepts inbound network traffic on (for example,
        /// port 443).
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
        /// The protocol that your object storage system uses to communicate.
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

    }
}