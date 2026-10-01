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

namespace Amazon.AIOps.Model
{
    /// <summary>
    /// Use this structure to specify a customer managed KMS key to use to encrypt investigation
    /// data.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If the investigation group uses a customer managed key for encryption, this field
        /// displays the ID of that key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Displays whether investigation data is encrypted by a customer managed key or an Amazon
        /// Web Services owned key.
        /// </para>
        /// </summary>
        public EncryptionConfigurationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
