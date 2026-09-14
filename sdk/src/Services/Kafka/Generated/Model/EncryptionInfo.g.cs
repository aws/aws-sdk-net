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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Includes encryption-related information, such as the AWS KMS key used for encrypting
    /// data at rest and whether you want MSK to encrypt your data in transit.
    /// </summary>
    public partial class EncryptionInfo
    {
        /// <summary>
        /// Gets and sets the property EncryptionAtRest. 
        /// <para>
        /// The data-volume encryption details.
        /// </para>
        /// </summary>
        public EncryptionAtRest EncryptionAtRest { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAtRest property is set.
        /// </summary>
        internal bool IsSetEncryptionAtRest() => this.EncryptionAtRest != null;

        /// <summary>
        /// Gets and sets the property EncryptionInTransit. 
        /// <para>
        /// The details for encryption in transit.
        /// </para>
        /// </summary>
        public EncryptionInTransit EncryptionInTransit { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionInTransit property is set.
        /// </summary>
        internal bool IsSetEncryptionInTransit() => this.EncryptionInTransit != null;
    }
}
