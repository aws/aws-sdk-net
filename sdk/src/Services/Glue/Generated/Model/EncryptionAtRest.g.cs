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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the encryption-at-rest configuration for the Data Catalog.
    /// </summary>
    public partial class EncryptionAtRest
    {
        /// <summary>
        /// Gets and sets the property CatalogEncryptionMode. 
        /// <para>
        /// The encryption-at-rest mode for encrypting Data Catalog data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CatalogEncryptionMode CatalogEncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the CatalogEncryptionMode property is set.
        /// </summary>
        internal bool IsSetCatalogEncryptionMode() => this.CatalogEncryptionMode != null;

        /// <summary>
        /// Gets and sets the property CatalogEncryptionServiceRole. 
        /// <para>
        /// The role that Glue assumes to encrypt and decrypt the Data Catalog objects on the
        /// caller's behalf.
        /// </para>
        /// </summary>
        public string CatalogEncryptionServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the CatalogEncryptionServiceRole property is set.
        /// </summary>
        internal bool IsSetCatalogEncryptionServiceRole() => this.CatalogEncryptionServiceRole != null;

        /// <summary>
        /// Gets and sets the property SseAwsKmsKeyId. 
        /// <para>
        /// The ID of the KMS key to use for encryption at rest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SseAwsKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the SseAwsKmsKeyId property is set.
        /// </summary>
        internal bool IsSetSseAwsKmsKeyId() => this.SseAwsKmsKeyId != null;
    }
}
