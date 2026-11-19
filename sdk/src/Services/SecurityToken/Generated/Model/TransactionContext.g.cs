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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// The session's <c>aws:TransactionContext/IdentityProvider/*</c> keys.
    /// </summary>
    public partial class TransactionContext
    {
        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// The session's <c>aws:TransactionContext/IdentityProvider/*</c> keys, keyed by the
        /// part of the key name after <c>aws:TransactionContext/IdentityProvider/</c>. Each value
        /// is up to 128 characters.
        /// </para>
        ///  
        /// <para>
        /// The number of entries is bounded twice. IAM limits how many keys a context provider
        /// maps when you configure it on the identity provider, and Amazon Web Services STS rejects
        /// a session whose session token exceeds the maximum size with <c>PackedPolicyTooLarge</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IdentityProvider { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null && (this.IdentityProvider.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
