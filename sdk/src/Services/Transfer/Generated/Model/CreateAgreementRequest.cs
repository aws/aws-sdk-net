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
    /// Container for the parameters to the CreateAgreement operation.
    /// Creates an agreement. An agreement is a bilateral trading partner agreement, or partnership,
    /// between an Transfer Family server and an AS2 process. The agreement defines the file
    /// and message transfer relationship between the server and the AS2 process. To define
    /// an agreement, Transfer Family combines a server, local profile, partner profile, certificate,
    /// and other attributes.
    /// 
    ///  
    /// <para>
    /// The partner is identified with the <c>PartnerProfileId</c>, and the AS2 process is
    /// identified with the <c>LocalProfileId</c>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Specify <i>either</i> <c>BaseDirectory</c> or <c>CustomDirectories</c>, but not both.
    /// Specifying both causes the command to fail.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateAgreementRequest : AmazonTransferRequest
    {
        private string _accessRole;
        private string _baseDirectory;
        private CustomDirectoriesType _customDirectories;
        private string _description;
        private EnforceMessageSigningType _enforceMessageSigning;
        private string _localProfileId;
        private string _partnerProfileId;
        private PreserveFilenameType _preserveFilename;
        private string _serverId;
        private AgreementStatusType _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property BaseDirectory. 
        /// <para>
        /// The landing directory (folder) for files transferred by using the AS2 protocol.
        /// </para>
        ///  
        /// <para>
        /// A <c>BaseDirectory</c> example is <c>/<i>amzn-s3-demo-bucket</i>/home/mydirectory</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string BaseDirectory
        {
            get { return this._baseDirectory; }
            set { this._baseDirectory = value; }
        }

        // Check to see if BaseDirectory property is set
        internal bool IsSetBaseDirectory()
        {
            return this._baseDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDirectories. 
        /// <para>
        /// A <c>CustomDirectoriesType</c> structure. This structure specifies custom directories
        /// for storing various AS2 message files. You can specify directories for the following
        /// types of files.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Failed files
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MDN files
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Payload files
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status files
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Temporary files
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CustomDirectoriesType CustomDirectories
        {
            get { return this._customDirectories; }
            set { this._customDirectories = value; }
        }

        // Check to see if CustomDirectories property is set
        internal bool IsSetCustomDirectories()
        {
            return this._customDirectories != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A name or short description to identify the agreement. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnforceMessageSigning. 
        /// <para>
        ///  Determines whether or not unsigned messages from your trading partners will be accepted.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Transfer Family rejects unsigned messages from your trading partner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> (default value): Transfer Family accepts unsigned messages from your
        /// trading partner.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EnforceMessageSigningType EnforceMessageSigning
        {
            get { return this._enforceMessageSigning; }
            set { this._enforceMessageSigning = value; }
        }

        // Check to see if EnforceMessageSigning property is set
        internal bool IsSetEnforceMessageSigning()
        {
            return this._enforceMessageSigning != null;
        }

        /// <summary>
        /// Gets and sets the property LocalProfileId. 
        /// <para>
        /// A unique identifier for the AS2 local profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string LocalProfileId
        {
            get { return this._localProfileId; }
            set { this._localProfileId = value; }
        }

        // Check to see if LocalProfileId property is set
        internal bool IsSetLocalProfileId()
        {
            return this._localProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerProfileId. 
        /// <para>
        /// A unique identifier for the partner profile used in the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string PartnerProfileId
        {
            get { return this._partnerProfileId; }
            set { this._partnerProfileId = value; }
        }

        // Check to see if PartnerProfileId property is set
        internal bool IsSetPartnerProfileId()
        {
            return this._partnerProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveFilename. 
        /// <para>
        ///  Determines whether or not Transfer Family appends a unique string of characters to
        /// the end of the AS2 message payload filename when saving it. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: the filename provided by your trading parter is preserved when the
        /// file is saved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> (default value): when Transfer Family saves the file, the filename
        /// is adjusted, as described in <a href="https://docs.aws.amazon.com/transfer/latest/userguide/send-as2-messages.html#file-names-as2">File
        /// names and locations</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PreserveFilenameType PreserveFilename
        {
            get { return this._preserveFilename; }
            set { this._preserveFilename = value; }
        }

        // Check to see if PreserveFilename property is set
        internal bool IsSetPreserveFilename()
        {
            return this._preserveFilename != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server instance. This is the specific server
        /// that the agreement uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the agreement. The agreement can be either <c>ACTIVE</c> or <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        public AgreementStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for agreements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

    }
}