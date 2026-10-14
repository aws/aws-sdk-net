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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the parameters for the connector, as identified by the <c>ConnectorId</c>.
    /// </summary>
    public partial class DescribedConnector
    {
        /// <summary>
        /// Gets and sets the property AccessRole. 
        /// <para>
        /// Connectors are used to send files using either the AS2 or SFTP protocol. For the access
        /// role, provide the Amazon Resource Name (ARN) of the Identity and Access Management
        /// role to use.
        /// </para>
        ///  
        /// <para>
        ///  <b>For AS2 connectors</b> 
        /// </para>
        ///  
        /// <para>
        /// With AS2, you can send files by calling <c>StartFileTransfer</c> and specifying the
        /// file paths in the request parameter, <c>SendFilePaths</c>. We use the file’s parent
        /// directory (for example, for <c>--send-file-paths /bucket/dir/file.txt</c>, parent
        /// directory is <c>/bucket/dir/</c>) to temporarily store a processed AS2 message file,
        /// store the MDN when we receive them from the partner, and write a final JSON file containing
        /// relevant metadata of the transmission. So, the <c>AccessRole</c> needs to provide
        /// read and write access to the parent directory of the file location used in the <c>StartFileTransfer</c>
        /// request. Additionally, you need to provide read and write access to the parent directory
        /// of the files that you intend to send with <c>StartFileTransfer</c>.
        /// </para>
        ///  
        /// <para>
        /// If you are using Basic authentication for your AS2 connector, the access role requires
        /// the <c>secretsmanager:GetSecretValue</c> permission for the secret. If the secret
        /// is encrypted using a customer-managed key instead of the Amazon Web Services managed
        /// key in Secrets Manager, then the role also needs the <c>kms:Decrypt</c> permission
        /// for that key.
        /// </para>
        ///  
        /// <para>
        ///  <b>For SFTP connectors</b> 
        /// </para>
        ///  
        /// <para>
        /// Make sure that the access role provides read and write access to the parent directory
        /// of the file location that's used in the <c>StartFileTransfer</c> request. Additionally,
        /// make sure that the role provides <c>secretsmanager:GetSecretValue</c> permission to
        /// Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AccessRole { get; set; }

        /// <summary>
        /// Checks to see if the AccessRole property is set.
        /// </summary>
        internal bool IsSetAccessRole() => this.AccessRole != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property As2Config. 
        /// <para>
        /// A structure that contains the parameters for an AS2 connector object.
        /// </para>
        /// </summary>
        public As2ConnectorConfig As2Config { get; set; }

        /// <summary>
        /// Checks to see if the As2Config property is set.
        /// </summary>
        internal bool IsSetAs2Config() => this.As2Config != null;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique identifier for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorId property is set.
        /// </summary>
        internal bool IsSetConnectorId() => this.ConnectorId != null;

        /// <summary>
        /// Gets and sets the property EgressConfig. 
        /// <para>
        /// Current egress configuration of the connector, showing how traffic is routed to the
        /// SFTP server. Contains VPC Lattice settings when using VPC_LATTICE egress type.
        /// </para>
        ///  
        /// <para>
        /// When using the VPC_LATTICE egress type, Transfer Family uses a managed Service Network
        /// to simplify the resource sharing process.
        /// </para>
        /// </summary>
        public DescribedConnectorEgressConfig EgressConfig { get; set; }

        /// <summary>
        /// Checks to see if the EgressConfig property is set.
        /// </summary>
        internal bool IsSetEgressConfig() => this.EgressConfig != null;

        /// <summary>
        /// Gets and sets the property EgressType. 
        /// <para>
        /// Type of egress configuration for the connector. SERVICE_MANAGED uses Transfer Family
        /// managed NAT gateways, while VPC_LATTICE routes traffic through customer VPCs using
        /// VPC Lattice.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorEgressType EgressType { get; set; }

        /// <summary>
        /// Checks to see if the EgressType property is set.
        /// </summary>
        internal bool IsSetEgressType() => this.EgressType != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message providing details when the connector is in ERRORED status. Contains
        /// information to help troubleshoot connector creation or operation failures.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// IP address type for the connector's network connections. When set to <c>IPV4</c>,
        /// the connector uses IPv4 addresses only. When set to <c>DUALSTACK</c>, the connector
        /// supports both IPv4 and IPv6 addresses, with IPv6 preferred when available.
        /// </para>
        /// </summary>
        public ConnectorsIpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// allows a connector to turn on CloudWatch logging for Amazon S3 events. When set, you
        /// can view connector activity in your CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string LoggingRole { get; set; }

        /// <summary>
        /// Checks to see if the LoggingRole property is set.
        /// </summary>
        internal bool IsSetLoggingRole() => this.LoggingRole != null;

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// The text name of the security policy for the specified connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string SecurityPolicyName { get; set; }

        /// <summary>
        /// Checks to see if the SecurityPolicyName property is set.
        /// </summary>
        internal bool IsSetSecurityPolicyName() => this.SecurityPolicyName != null;

        /// <summary>
        /// Gets and sets the property ServiceManagedEgressIpAddresses. 
        /// <para>
        /// The list of egress IP addresses of this connector. These IP addresses are assigned
        /// automatically when you create the connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceManagedEgressIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ServiceManagedEgressIpAddresses property is set.
        /// </summary>
        internal bool IsSetServiceManagedEgressIpAddresses() => this.ServiceManagedEgressIpAddresses != null && (this.ServiceManagedEgressIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SftpConfig. 
        /// <para>
        /// A structure that contains the parameters for an SFTP connector object.
        /// </para>
        /// </summary>
        public SftpConnectorConfig SftpConfig { get; set; }

        /// <summary>
        /// Checks to see if the SftpConfig property is set.
        /// </summary>
        internal bool IsSetSftpConfig() => this.SftpConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the connector. PENDING indicates creation/update in progress, ACTIVE
        /// means ready for operations, and ERRORED indicates a failure requiring attention.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for connectors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the partner's AS2 or SFTP endpoint.
        /// </para>
        ///  
        /// <para>
        /// When creating AS2 connectors or service-managed SFTP connectors (connectors without
        /// egress configuration), you must provide a URL to specify the remote server endpoint.
        /// For VPC Lattice type connectors, the URL must be null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
