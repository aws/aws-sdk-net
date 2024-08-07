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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
    /// Complete these parameters only if the content is encrypted.
    /// </summary>
    public partial class SrtCallerDecryptionRequest
    {
        private Algorithm _algorithm;
        private string _passphraseSecretArn;

        /// <summary>
        /// Gets and sets the property Algorithm. The algorithm used to encrypt content.
        /// </summary>
        public Algorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property PassphraseSecretArn. The ARN for the secret in Secrets
        /// Manager. Someone in your organization must create a secret and provide you with its
        /// ARN. This secret holds the passphrase that MediaLive will use to decrypt the source
        /// content.
        /// </summary>
        public string PassphraseSecretArn
        {
            get { return this._passphraseSecretArn; }
            set { this._passphraseSecretArn = value; }
        }

        // Check to see if PassphraseSecretArn property is set
        internal bool IsSetPassphraseSecretArn()
        {
            return this._passphraseSecretArn != null;
        }

    }
}