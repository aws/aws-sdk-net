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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A checksum structure used to verify data integrity.
    /// </summary>
    public partial class Checksum
    {
        /// <summary>
        /// Gets and sets the property EncryptionAlgorithm. 
        /// <para>
        /// The encryption algorithm used to generate the checksum.
        /// </para>
        /// </summary>
        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionAlgorithm property is set.
        /// </summary>
        internal bool IsSetEncryptionAlgorithm() => this.EncryptionAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Hash. 
        /// <para>
        /// The hash value of the checksum.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string Hash { get; set; }

        /// <summary>
        /// Checks to see if the Hash property is set.
        /// </summary>
        internal bool IsSetHash() => this.Hash != null;
    }
}
