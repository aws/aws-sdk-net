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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the encryption configuration for X-Ray.
    /// </summary>
    public partial class AwsXrayEncryptionConfigDetails
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The identifier of the KMS key that is used for encryption. Provided if <c>Type</c>
        /// is <c>KMS</c>.
        /// </para>
        /// </summary>
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the encryption configuration. Valid values are <c>ACTIVE</c>
        /// or <c>UPDATING</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>Status</c> is equal to <c>UPDATING</c>, X-Ray might use both the old and new
        /// encryption.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of encryption. <c>KMS</c> indicates that the encryption uses KMS keys. <c>NONE</c>
        /// indicates the default encryption.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
