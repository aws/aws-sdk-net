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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVerifiedAccessTrustProvider operation. A
    /// trust provider is a third-party entity that creates, maintains, and manages identity
    /// information for users and devices. When an application request is made, the identity
    /// information sent by the trust provider is evaluated by Verified Access before allowing
    /// or denying the application request.
    /// </summary>
    public partial class CreateVerifiedAccessTrustProviderRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Verified Access trust provider.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceOptions. 
        /// <para>
        /// The options for a device-based trust provider. This parameter is required when the
        /// provider type is <c>device</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessTrustProviderDeviceOptions DeviceOptions { get; set; }

        /// <summary>
        /// Checks to see if the DeviceOptions property is set.
        /// </summary>
        internal bool IsSetDeviceOptions() => this.DeviceOptions != null;

        /// <summary>
        /// Gets and sets the property DeviceTrustProviderType. 
        /// <para>
        /// The type of device-based trust provider. This parameter is required when the provider
        /// type is <c>device</c>.
        /// </para>
        /// </summary>
        public DeviceTrustProviderType DeviceTrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceTrustProviderType property is set.
        /// </summary>
        internal bool IsSetDeviceTrustProviderType() => this.DeviceTrustProviderType != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property NativeApplicationOidcOptions. 
        /// <para>
        /// The OpenID Connect (OIDC) options.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessNativeApplicationOidcOptions NativeApplicationOidcOptions { get; set; }

        /// <summary>
        /// Checks to see if the NativeApplicationOidcOptions property is set.
        /// </summary>
        internal bool IsSetNativeApplicationOidcOptions() => this.NativeApplicationOidcOptions != null;

        /// <summary>
        /// Gets and sets the property OidcOptions. 
        /// <para>
        /// The options for a OpenID Connect-compatible user-identity trust provider. This parameter
        /// is required when the provider type is <c>user</c>.
        /// </para>
        /// </summary>
        public CreateVerifiedAccessTrustProviderOidcOptions OidcOptions { get; set; }

        /// <summary>
        /// Checks to see if the OidcOptions property is set.
        /// </summary>
        internal bool IsSetOidcOptions() => this.OidcOptions != null;

        /// <summary>
        /// Gets and sets the property PolicyReferenceName. 
        /// <para>
        /// The identifier to be used when working with policy rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyReferenceName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyReferenceName property is set.
        /// </summary>
        internal bool IsSetPolicyReferenceName() => this.PolicyReferenceName != null;

        /// <summary>
        /// Gets and sets the property SseSpecification. 
        /// <para>
        /// The options for server side encryption.
        /// </para>
        /// </summary>
        public VerifiedAccessSseSpecificationRequest SseSpecification { get; set; }

        /// <summary>
        /// Checks to see if the SseSpecification property is set.
        /// </summary>
        internal bool IsSetSseSpecification() => this.SseSpecification != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Verified Access trust provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrustProviderType. 
        /// <para>
        /// The type of trust provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustProviderType TrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the TrustProviderType property is set.
        /// </summary>
        internal bool IsSetTrustProviderType() => this.TrustProviderType != null;

        /// <summary>
        /// Gets and sets the property UserTrustProviderType. 
        /// <para>
        /// The type of user-based trust provider. This parameter is required when the provider
        /// type is <c>user</c>.
        /// </para>
        /// </summary>
        public UserTrustProviderType UserTrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the UserTrustProviderType property is set.
        /// </summary>
        internal bool IsSetUserTrustProviderType() => this.UserTrustProviderType != null;
    }
}
