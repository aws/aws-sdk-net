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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the ResetTokenVaultKeyMaterial operation. Resets the
    /// key material for a token vault whose customer managed KMS key has been deleted, and
    /// re-encrypts the token vault with an Amazon Web Services managed key so that you can
    /// use the token vault again. <important> <para> This operation can't be undone. The
    /// reset permanently deletes the OAuth2 access tokens and refresh tokens stored in the
    /// token vault, including tokens obtained through all supported flows. After the reset,
    /// your agents must complete these flows again to get new tokens, and for user-delegated
    /// flows your users must authorize access again. The reset doesn't delete your credential
    /// providers or their configuration. </para> </important> <para> You can reset a token
    /// vault only if its customer managed key has been deleted. If the key still exists,
    /// including when it's disabled or scheduled for deletion, this operation returns a <c>ValidationException</c>.
    /// To use the token vault again, enable the key or cancel its scheduled deletion in KMS.
    /// To switch to a different key, use <c>SetTokenVaultCMK</c>. </para>
    /// </summary>
    public partial class ResetTokenVaultKeyMaterialRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property TokenVaultId. 
        /// <para>
        /// The unique identifier of the token vault to reset. To reset your account's default
        /// token vault, specify <c>default</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TokenVaultId { get; set; }

        /// <summary>
        /// Checks to see if the TokenVaultId property is set.
        /// </summary>
        internal bool IsSetTokenVaultId() => this.TokenVaultId != null;
    }
}
