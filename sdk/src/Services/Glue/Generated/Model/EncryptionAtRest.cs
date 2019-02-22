/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the encryption-at-rest configuration for the Data Catalog.
    /// </summary>
    public partial class EncryptionAtRest
    {
        private CatalogEncryptionMode _catalogEncryptionMode;
        private string _sseAwsKmsKeyId;

        /// <summary>
        /// Gets and sets the property CatalogEncryptionMode. 
        /// <para>
        /// The encryption-at-rest mode for encrypting Data Catalog data.
        /// </para>
        /// </summary>
        public CatalogEncryptionMode CatalogEncryptionMode
        {
            get { return this._catalogEncryptionMode; }
            set { this._catalogEncryptionMode = value; }
        }

        // Check to see if CatalogEncryptionMode property is set
        internal bool IsSetCatalogEncryptionMode()
        {
            return this._catalogEncryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property SseAwsKmsKeyId. 
        /// <para>
        /// The ID of the AWS KMS key to use for encryption at rest.
        /// </para>
        /// </summary>
        public string SseAwsKmsKeyId
        {
            get { return this._sseAwsKmsKeyId; }
            set { this._sseAwsKmsKeyId = value; }
        }

        // Check to see if SseAwsKmsKeyId property is set
        internal bool IsSetSseAwsKmsKeyId()
        {
            return this._sseAwsKmsKeyId != null;
        }

    }
}