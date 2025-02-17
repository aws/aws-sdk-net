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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Encryption options for a package.
    /// </summary>
    public partial class PackageEncryptionOptions
    {
        private bool? _encryptionEnabled;
        private string _kmsKeyIdentifier;

        /// <summary>
        /// Gets and sets the property EncryptionEnabled. 
        /// <para>
        /// This indicates whether encryption is enabled for the package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EncryptionEnabled
        {
            get { return this._encryptionEnabled.GetValueOrDefault(); }
            set { this._encryptionEnabled = value; }
        }

        // Check to see if EncryptionEnabled property is set
        internal bool IsSetEncryptionEnabled()
        {
            return this._encryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        ///  KMS key ID for encrypting the package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

    }
}