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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// A structure that contains the encryption configuration for the policy store and child
    /// resources.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response parameter field for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_GetPolicyStore.html">GetPolicyStore</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class EncryptionState
    {
        /// <summary>
        /// Gets and sets the property Default. 
        /// <para>
        /// This is the default encryption state. The policy store is encrypted using an Amazon
        /// Web Services owned key.
        /// </para>
        /// </summary>
        public Unit Default { get; set; }

        /// <summary>
        /// Checks to see if the Default property is set.
        /// </summary>
        internal bool IsSetDefault() => this.Default != null;

        /// <summary>
        /// Gets and sets the property KmsEncryptionState. 
        /// <para>
        /// The KMS encryption settings currently configured for this policy store to encrypt
        /// data with. It contains the customer-managed KMS key, and a user-defined encryption
        /// context. 
        /// </para>
        /// </summary>
        public KmsEncryptionState KmsEncryptionState { get; set; }

        /// <summary>
        /// Checks to see if the KmsEncryptionState property is set.
        /// </summary>
        internal bool IsSetKmsEncryptionState() => this.KmsEncryptionState != null;
    }
}
