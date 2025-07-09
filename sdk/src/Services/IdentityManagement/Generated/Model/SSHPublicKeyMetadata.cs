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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an SSH public key, without the key's body or fingerprint.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListSSHPublicKeys.html">ListSSHPublicKeys</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class SSHPublicKeyMetadata
    {
        private string _sshPublicKeyId;
        private StatusType _status;
        private DateTime? _uploadDate;
        private string _userName;

        /// <summary>
        /// Gets and sets the property SSHPublicKeyId. 
        /// <para>
        /// The unique identifier for the SSH public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=128)]
        public string SSHPublicKeyId
        {
            get { return this._sshPublicKeyId; }
            set { this._sshPublicKeyId = value; }
        }

        // Check to see if SSHPublicKeyId property is set
        internal bool IsSetSSHPublicKeyId()
        {
            return this._sshPublicKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSH public key. <c>Active</c> means that the key can be used for
        /// authentication with an CodeCommit repository. <c>Inactive</c> means that the key cannot
        /// be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatusType Status
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
        /// Gets and sets the property UploadDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the SSH public key was uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UploadDate
        {
            get { return this._uploadDate; }
            set { this._uploadDate = value; }
        }

        // Check to see if UploadDate property is set
        internal bool IsSetUploadDate()
        {
            return this._uploadDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user associated with the SSH public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}