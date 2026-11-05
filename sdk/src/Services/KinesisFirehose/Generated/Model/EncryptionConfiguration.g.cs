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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the encryption for a destination in Amazon S3.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property KMSEncryptionConfig. 
        /// <para>
        /// The encryption key.
        /// </para>
        /// </summary>
        public KMSEncryptionConfig KMSEncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the KMSEncryptionConfig property is set.
        /// </summary>
        internal bool IsSetKMSEncryptionConfig() => this.KMSEncryptionConfig != null;

        /// <summary>
        /// Gets and sets the property NoEncryptionConfig. 
        /// <para>
        /// Specifically override existing encryption information to ensure that no encryption
        /// is used.
        /// </para>
        /// </summary>
        public NoEncryptionConfig NoEncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the NoEncryptionConfig property is set.
        /// </summary>
        internal bool IsSetNoEncryptionConfig() => this.NoEncryptionConfig != null;
    }
}
