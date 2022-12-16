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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Complex data type for field-level encryption profiles that includes the encryption
    /// key and field pattern specifications.
    /// </summary>
    public partial class EncryptionEntity
    {
        private FieldPatterns _fieldPatterns;
        private string _providerId;
        private string _publicKeyId;

        /// <summary>
        /// Gets and sets the property FieldPatterns. 
        /// <para>
        /// Field patterns in a field-level encryption content type profile specify the fields
        /// that you want to be encrypted. You can provide the full field name, or any beginning
        /// characters followed by a wildcard (*). You can't overlap field patterns. For example,
        /// you can't have both ABC* and AB*. Note that field patterns are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldPatterns FieldPatterns
        {
            get { return this._fieldPatterns; }
            set { this._fieldPatterns = value; }
        }

        // Check to see if FieldPatterns property is set
        internal bool IsSetFieldPatterns()
        {
            return this._fieldPatterns != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderId. 
        /// <para>
        /// The provider associated with the public key being used for encryption. This value
        /// must also be provided with the private key for applications to be able to decrypt
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProviderId
        {
            get { return this._providerId; }
            set { this._providerId = value; }
        }

        // Check to see if ProviderId property is set
        internal bool IsSetProviderId()
        {
            return this._providerId != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeyId. 
        /// <para>
        /// The public key associated with a set of field-level encryption patterns, to be used
        /// when encrypting the fields that match the patterns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PublicKeyId
        {
            get { return this._publicKeyId; }
            set { this._publicKeyId = value; }
        }

        // Check to see if PublicKeyId property is set
        internal bool IsSetPublicKeyId()
        {
            return this._publicKeyId != null;
        }

    }
}