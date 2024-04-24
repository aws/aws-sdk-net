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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// The configuration of a signing operation.
    /// </summary>
    public partial class SigningConfiguration
    {
        private EncryptionAlgorithmOptions _encryptionAlgorithmOptions;
        private HashAlgorithmOptions _hashAlgorithmOptions;

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithmOptions. 
        /// <para>
        /// The encryption algorithm options that are available for a code-signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionAlgorithmOptions EncryptionAlgorithmOptions
        {
            get { return this._encryptionAlgorithmOptions; }
            set { this._encryptionAlgorithmOptions = value; }
        }

        // Check to see if EncryptionAlgorithmOptions property is set
        internal bool IsSetEncryptionAlgorithmOptions()
        {
            return this._encryptionAlgorithmOptions != null;
        }

        /// <summary>
        /// Gets and sets the property HashAlgorithmOptions. 
        /// <para>
        /// The hash algorithm options that are available for a code-signing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HashAlgorithmOptions HashAlgorithmOptions
        {
            get { return this._hashAlgorithmOptions; }
            set { this._hashAlgorithmOptions = value; }
        }

        // Check to see if HashAlgorithmOptions property is set
        internal bool IsSetHashAlgorithmOptions()
        {
            return this._hashAlgorithmOptions != null;
        }

    }
}