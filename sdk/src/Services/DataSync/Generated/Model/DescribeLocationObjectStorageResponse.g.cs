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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// This is the response object from the DescribeLocationObjectStorage operation.
    /// </summary>
    public partial class DescribeLocationObjectStorageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessKey. 
        /// <para>
        /// The access key (for example, a user name) required to authenticate with the object
        /// storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Checks to see if the AccessKey property is set.
        /// </summary>
        internal bool IsSetAccessKey() => this.AccessKey != null;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The ARNs of the DataSync agents that can connect with your object storage system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public List<string> AgentArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AgentArns property is set.
        /// </summary>
        internal bool IsSetAgentArns() => this.AgentArns != null && (this.AgentArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CmkSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed KMS key.
        /// </para>
        /// </summary>
        public CmkSecretConfig CmkSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CmkSecretConfig property is set.
        /// </summary>
        internal bool IsSetCmkSecretConfig() => this.CmkSecretConfig != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomSecretConfig. 
        /// <para>
        /// Describes configuration information for a customer-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location,
        /// and a customer-managed Identity and Access Management (IAM) role that provides access
        /// to the secret.
        /// </para>
        /// </summary>
        public CustomSecretConfig CustomSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecretConfig property is set.
        /// </summary>
        internal bool IsSetCustomSecretConfig() => this.CustomSecretConfig != null;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of the object storage system location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URI of the object storage system location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4360)]
        public string LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LocationUri property is set.
        /// </summary>
        internal bool IsSetLocationUri() => this.LocationUri != null;

        /// <summary>
        /// Gets and sets the property ManagedSecretConfig. 
        /// <para>
        /// Describes configuration information for a DataSync-managed secret, such as an authentication
        /// token or set of credentials that DataSync uses to access a specific transfer location.
        /// DataSync uses the default Amazon Web Services-managed KMS key to encrypt this secret
        /// in Secrets Manager.
        /// </para>
        /// </summary>
        public ManagedSecretConfig ManagedSecretConfig { get; set; }

        /// <summary>
        /// Checks to see if the ManagedSecretConfig property is set.
        /// </summary>
        internal bool IsSetManagedSecretConfig() => this.ManagedSecretConfig != null;

        /// <summary>
        /// Gets and sets the property ServerCertificate. 
        /// <para>
        /// The certificate chain for DataSync to authenticate with your object storage system
        /// if the system uses a private or self-signed certificate authority (CA).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public MemoryStream ServerCertificate { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificate property is set.
        /// </summary>
        internal bool IsSetServerCertificate() => this.ServerCertificate != null;

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// The port that your object storage server accepts inbound network traffic on (for example,
        /// port 443).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public int? ServerPort { get; set; }

        /// <summary>
        /// Checks to see if the ServerPort property is set.
        /// </summary>
        internal bool IsSetServerPort() => this.ServerPort.HasValue;

        /// <summary>
        /// Gets and sets the property ServerProtocol. 
        /// <para>
        /// The protocol that your object storage system uses to communicate.
        /// </para>
        /// </summary>
        public ObjectStorageServerProtocol ServerProtocol { get; set; }

        /// <summary>
        /// Checks to see if the ServerProtocol property is set.
        /// </summary>
        internal bool IsSetServerProtocol() => this.ServerProtocol != null;
    }
}
