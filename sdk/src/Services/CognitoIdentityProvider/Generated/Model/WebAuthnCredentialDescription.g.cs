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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The details of a passkey, or webauthN, biometric or security-key authentication factor
    /// for a user.
    /// </summary>
    public partial class WebAuthnCredentialDescription
    {
        /// <summary>
        /// Gets and sets the property AuthenticatorAttachment. 
        /// <para>
        /// The general category of the passkey authenticator. Can be a platform, or on-device
        /// authenticator like a built-in fingerprint scanner, or a cross-platform device that's
        /// not attached to the device like a Bluetooth security key.
        /// </para>
        /// </summary>
        public string AuthenticatorAttachment { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticatorAttachment property is set.
        /// </summary>
        internal bool IsSetAuthenticatorAttachment() => this.AuthenticatorAttachment != null;

        /// <summary>
        /// Gets and sets the property AuthenticatorTransports. 
        /// <para>
        /// Information about the transport methods of the passkey credential, for example USB
        /// or Bluetooth Low Energy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AuthenticatorTransports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthenticatorTransports property is set.
        /// </summary>
        internal bool IsSetAuthenticatorTransports() => this.AuthenticatorTransports != null && (this.AuthenticatorTransports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialId. 
        /// <para>
        /// The unique identifier of the passkey credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 131072)]
        public string CredentialId { get; set; }

        /// <summary>
        /// Checks to see if the CredentialId property is set.
        /// </summary>
        internal bool IsSetCredentialId() => this.CredentialId != null;

        /// <summary>
        /// Gets and sets the property FriendlyCredentialName. 
        /// <para>
        /// An automatically-generated friendly name for the passkey credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 131072)]
        public string FriendlyCredentialName { get; set; }

        /// <summary>
        /// Checks to see if the FriendlyCredentialName property is set.
        /// </summary>
        internal bool IsSetFriendlyCredentialName() => this.FriendlyCredentialName != null;

        /// <summary>
        /// Gets and sets the property RelyingPartyId. 
        /// <para>
        /// The relying-party ID of the provider for the passkey credential.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 131072)]
        public string RelyingPartyId { get; set; }

        /// <summary>
        /// Checks to see if the RelyingPartyId property is set.
        /// </summary>
        internal bool IsSetRelyingPartyId() => this.RelyingPartyId != null;
    }
}
