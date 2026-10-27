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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the settings used to enable server-side encryption.
    /// </summary>
    public partial class SSESpecification
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether server-side encryption is done using an Amazon Web Services managed
        /// key or an Amazon Web Services owned key. If enabled (true), server-side encryption
        /// type is set to <c>KMS</c> and an Amazon Web Services managed key is used (KMS charges
        /// apply). If disabled (false) or not specified, server-side encryption is set to Amazon
        /// Web Services owned key.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property KMSMasterKeyId. 
        /// <para>
        /// The KMS key that should be used for the KMS encryption. To specify a key, use its
        /// key ID, Amazon Resource Name (ARN), alias name, or alias ARN. Note that you should
        /// only provide this parameter if the key is different from the default DynamoDB key
        /// <c>alias/aws/dynamodb</c>.
        /// </para>
        /// </summary>
        public string KMSMasterKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KMSMasterKeyId property is set.
        /// </summary>
        internal bool IsSetKMSMasterKeyId() => this.KMSMasterKeyId != null;

        /// <summary>
        /// Gets and sets the property SSEType. 
        /// <para>
        /// Server-side encryption type. The only supported value is:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KMS</c> - Server-side encryption that uses Key Management Service. The key is
        /// stored in your account and is managed by KMS (KMS charges apply).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SSEType SSEType { get; set; }

        /// <summary>
        /// Checks to see if the SSEType property is set.
        /// </summary>
        internal bool IsSetSSEType() => this.SSEType != null;
    }
}
