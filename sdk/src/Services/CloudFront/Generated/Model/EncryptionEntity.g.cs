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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Complex data type for field-level encryption profiles that includes the encryption
    /// key and field pattern specifications.
    /// </summary>
    public partial class EncryptionEntity
    {
        /// <summary>
        /// Gets and sets the property FieldPatterns. 
        /// <para>
        /// Field patterns in a field-level encryption content type profile specify the fields
        /// that you want to be encrypted. You can provide the full field name, or any beginning
        /// characters followed by a wildcard (*). You can't overlap field patterns. For example,
        /// you can't have both ABC* and AB*. Note that field patterns are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldPatterns FieldPatterns { get; set; }

        /// <summary>
        /// Checks to see if the FieldPatterns property is set.
        /// </summary>
        internal bool IsSetFieldPatterns() => this.FieldPatterns != null;

        /// <summary>
        /// Gets and sets the property ProviderId. 
        /// <para>
        /// The provider associated with the public key being used for encryption. This value
        /// must also be provided with the private key for applications to be able to decrypt
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderId property is set.
        /// </summary>
        internal bool IsSetProviderId() => this.ProviderId != null;

        /// <summary>
        /// Gets and sets the property PublicKeyId. 
        /// <para>
        /// The public key associated with a set of field-level encryption patterns, to be used
        /// when encrypting the fields that match the patterns.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PublicKeyId { get; set; }

        /// <summary>
        /// Checks to see if the PublicKeyId property is set.
        /// </summary>
        internal bool IsSetPublicKeyId() => this.PublicKeyId != null;
    }
}
