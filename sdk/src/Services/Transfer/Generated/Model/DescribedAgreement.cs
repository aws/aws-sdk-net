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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of an agreement.
    /// </summary>
    public partial class DescribedAgreement
    {
        private string _accessRole;
        private string _agreementId;
        private string _arn;
        private string _baseDirectory;
        private string _description;
        private string _localProfileId;
        private string _partnerProfileId;
        private string _serverId;
        private AgreementStatusType _status;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AccessRole. 
        /// <para>
        /// With AS2, you can send files by calling <code>StartFileTransfer</code> and specifying
        /// the file paths in the request parameter, <code>SendFilePaths</code>. We use the file’s
        /// parent directory (for example, for <code>--send-file-paths /bucket/dir/file.txt</code>,
        /// parent directory is <code>/bucket/dir/</code>) to temporarily store a processed AS2
        /// message file, store the MDN when we receive them from the partner, and write a final
        /// JSON file containing relevant metadata of the transmission. So, the <code>AccessRole</code>
        /// needs to provide read and write access to the parent directory of the file location
        /// used in the <code>StartFileTransfer</code> request. Additionally, you need to provide
        /// read and write access to the parent directory of the files that you intend to send
        /// with <code>StartFileTransfer</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// A unique identifier for the agreement. This identifier is returned when you create
        /// an agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BaseDirectory. 
        /// <para>
        /// The landing directory (folder) for files that are transferred by using the AS2 protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The name or short description that's used to identify the agreement.
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
        /// Gets and sets the property LocalProfileId. 
        /// <para>
        /// A unique identifier for the AS2 local profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
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
        [AWSProperty(Min=19, Max=19)]
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
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server instance. This identifier indicates
        /// the specific server that the agreement uses.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
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
        /// The current status of the agreement, either <code>ACTIVE</code> or <code>INACTIVE</code>.
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}