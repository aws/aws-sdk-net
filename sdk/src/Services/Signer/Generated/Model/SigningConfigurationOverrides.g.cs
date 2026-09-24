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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// A signing configuration that overrides the default encryption or hash algorithm of
    /// a signing job.
    /// </summary>
    public partial class SigningConfigurationOverrides
    {
        /// <summary>
        /// Gets and sets the property EncryptionAlgorithm. 
        /// <para>
        /// A specified override of the default encryption algorithm that is used in a code-signing
        /// job.
        /// </para>
        /// </summary>
        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAlgorithm property is set.
        /// </summary>
        internal bool IsSetEncryptionAlgorithm() => this.EncryptionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property HashAlgorithm. 
        /// <para>
        /// A specified override of the default hash algorithm that is used in a code-signing
        /// job.
        /// </para>
        /// </summary>
        public HashAlgorithm HashAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the HashAlgorithm property is set.
        /// </summary>
        internal bool IsSetHashAlgorithm() => this.HashAlgorithm != null;
    }
}
