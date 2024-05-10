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
    /// Container for the parameters to the CreateConnector operation.
    /// Creates the connector, which captures the parameters for a connection for the AS2
    /// or SFTP protocol. For AS2, the connector is required for sending files to an externally
    /// hosted AS2 server. For SFTP, the connector is required when sending files to an SFTP
    /// server or receiving files from an SFTP server. For more details about connectors,
    /// see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/configure-as2-connector.html">Configure
    /// AS2 connectors</a> and <a href="https://docs.aws.amazon.com/transfer/latest/userguide/configure-sftp-connector.html">Create
    /// SFTP connectors</a>.
    /// 
    ///  <note> 
    /// <para>
    /// You must specify exactly one configuration object: either for AS2 (<c>As2Config</c>)
    /// or SFTP (<c>SftpConfig</c>).
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateConnectorRequest : AmazonTransferRequest
    {
        private string _accessRole;
        private As2ConnectorConfig _as2Config;
        private string _loggingRole;
        private string _securityPolicyName;
        private SftpConnectorConfig _sftpConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _url;

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
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string AccessRole
        {
            get { return this._accessRole; }
            set { this._accessRole = value; }
        }

        // Check to see if AccessRole property is set
        internal bool IsSetAccessRole()
        {
            return this._accessRole != null;
        }

        /// <summary>
        /// Gets and sets the property As2Config. 
        /// <para>
        /// A structure that contains the parameters for an AS2 connector object.
        /// </para>
        /// </summary>
        public As2ConnectorConfig As2Config
        {
            get { return this._as2Config; }
            set { this._as2Config = value; }
        }

        // Check to see if As2Config property is set
        internal bool IsSetAs2Config()
        {
            return this._as2Config != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// allows a connector to turn on CloudWatch logging for Amazon S3 events. When set, you
        /// can view connector activity in your CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LoggingRole
        {
            get { return this._loggingRole; }
            set { this._loggingRole = value; }
        }

        // Check to see if LoggingRole property is set
        internal bool IsSetLoggingRole()
        {
            return this._loggingRole != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityPolicyName. 
        /// <para>
        /// Specifies the name of the security policy for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string SecurityPolicyName
        {
            get { return this._securityPolicyName; }
            set { this._securityPolicyName = value; }
        }

        // Check to see if SecurityPolicyName property is set
        internal bool IsSetSecurityPolicyName()
        {
            return this._securityPolicyName != null;
        }

        /// <summary>
        /// Gets and sets the property SftpConfig. 
        /// <para>
        /// A structure that contains the parameters for an SFTP connector object.
        /// </para>
        /// </summary>
        public SftpConnectorConfig SftpConfig
        {
            get { return this._sftpConfig; }
            set { this._sftpConfig = value; }
        }

        // Check to see if SftpConfig property is set
        internal bool IsSetSftpConfig()
        {
            return this._sftpConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for connectors. Tags are metadata
        /// attached to connectors for any purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the partner's AS2 or SFTP endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}