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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The decryption settings for the SRT caller source. Present only if the source has
    /// decryption enabled.
    /// </summary>
    public partial class SrtCallerDecryption
    {
        /// <summary>
        /// Gets and sets the property Algorithm. The algorithm used to encrypt content.
        /// </summary>
        public Algorithm Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

        /// <summary>
        /// Gets and sets the property PassphraseSecretArn. The ARN for the secret in Secrets
        /// Manager. Someone in your organization must create a secret and provide you with its
        /// ARN. The secret holds the passphrase that MediaLive uses to decrypt the source content.
        /// </summary>
        public string PassphraseSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the PassphraseSecretArn property is set.
        /// </summary>
        internal bool IsSetPassphraseSecretArn() => this.PassphraseSecretArn != null;
    }
}
