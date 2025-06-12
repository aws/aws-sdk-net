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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ImportKeyPair operation.
    /// </summary>
    public partial class ImportKeyPairResponse : AmazonWebServiceResponse
    {
        private string _keyFingerprint;
        private string _keyName;
        private string _keyPairId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property KeyFingerprint. <ul> <li> 
        /// <para>
        /// For RSA key pairs, the key fingerprint is the MD5 public key fingerprint as specified
        /// in section 4 of RFC 4716.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ED25519 key pairs, the key fingerprint is the base64-encoded SHA-256 digest, which
        /// is the default for OpenSSH, starting with <a href="http://www.openssh.com/txt/release-6.8">OpenSSH
        /// 6.8</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KeyFingerprint
        {
            get { return this._keyFingerprint; }
            set { this._keyFingerprint = value; }
        }

        // Check to see if KeyFingerprint property is set
        internal bool IsSetKeyFingerprint()
        {
            return this._keyFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The key pair name that you provided.
        /// </para>
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPairId. 
        /// <para>
        /// The ID of the resulting key pair.
        /// </para>
        /// </summary>
        public string KeyPairId
        {
            get { return this._keyPairId; }
            set { this._keyPairId = value; }
        }

        // Check to see if KeyPairId property is set
        internal bool IsSetKeyPairId()
        {
            return this._keyPairId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the imported key pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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