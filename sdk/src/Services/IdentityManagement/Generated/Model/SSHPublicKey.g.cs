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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an SSH public key.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetSSHPublicKey.html">GetSSHPublicKey</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UploadSSHPublicKey.html">UploadSSHPublicKey</a>
    /// operations. 
    /// </para>
    /// </summary>
    public partial class SSHPublicKey
    {
        /// <summary>
        /// Gets and sets the property Fingerprint. 
        /// <para>
        /// The MD5 message digest of the SSH public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 48, Max = 48)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Checks to see if the Fingerprint property is set.
        /// </summary>
        internal bool IsSetFingerprint() => this.Fingerprint != null;

        /// <summary>
        /// Gets and sets the property SSHPublicKeyBody. 
        /// <para>
        /// The SSH public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16384)]
        public string SSHPublicKeyBody { get; set; }

        /// <summary>
        /// Checks to see if the SSHPublicKeyBody property is set.
        /// </summary>
        internal bool IsSetSSHPublicKeyBody() => this.SSHPublicKeyBody != null;

        /// <summary>
        /// Gets and sets the property SSHPublicKeyId. 
        /// <para>
        /// The unique identifier for the SSH public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 128)]
        public string SSHPublicKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SSHPublicKeyId property is set.
        /// </summary>
        internal bool IsSetSSHPublicKeyId() => this.SSHPublicKeyId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSH public key. <c>Active</c> means that the key can be used for
        /// authentication with an CodeCommit repository. <c>Inactive</c> means that the key cannot
        /// be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UploadDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the SSH public key was uploaded.
        /// </para>
        /// </summary>
        public DateTime? UploadDate { get; set; }

        /// <summary>
        /// Checks to see if the UploadDate property is set.
        /// </summary>
        internal bool IsSetUploadDate() => this.UploadDate.HasValue;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user associated with the SSH public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
