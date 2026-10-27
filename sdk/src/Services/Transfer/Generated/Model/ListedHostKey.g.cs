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
    /// Returns properties of the host key that's specified.
    /// </summary>
    public partial class ListedHostKey
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the host key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DateImported. 
        /// <para>
        /// The date on which the host key was added to the server.
        /// </para>
        /// </summary>
        public DateTime? DateImported { get; set; }

        /// <summary>
        /// Checks to see if the DateImported property is set.
        /// </summary>
        internal bool IsSetDateImported() => this.DateImported.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The current description for the host key. You can change it by calling the <c>UpdateHostKey</c>
        /// operation and providing a new description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Fingerprint. 
        /// <para>
        /// The public key fingerprint, which is a short sequence of bytes used to identify the
        /// longer public key.
        /// </para>
        /// </summary>
        public string Fingerprint { get; set; }

        /// <summary>
        /// Checks to see if the Fingerprint property is set.
        /// </summary>
        internal bool IsSetFingerprint() => this.Fingerprint != null;

        /// <summary>
        /// Gets and sets the property HostKeyId. 
        /// <para>
        /// A unique identifier for the host key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 25)]
        public string HostKeyId { get; set; }

        /// <summary>
        /// Checks to see if the HostKeyId property is set.
        /// </summary>
        internal bool IsSetHostKeyId() => this.HostKeyId != null;

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN of the Secrets Manager secret that stores the host key material, when <c>StorageType</c>
        /// is <c>SECRETS_MANAGER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretId property is set.
        /// </summary>
        internal bool IsSetSecretId() => this.SecretId != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Specifies whether the host key is stored by Transfer Family (<c>SERVICE_MANAGED</c>)
        /// or in Secrets Manager (<c>SECRETS_MANAGER</c>).
        /// </para>
        /// </summary>
        public HostKeyStorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The encryption algorithm that is used for the host key. The <c>Type</c> parameter
        /// is specified by using one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ssh-rsa</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ssh-ed25519</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecdsa-sha2-nistp256</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecdsa-sha2-nistp384</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ecdsa-sha2-nistp521</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
