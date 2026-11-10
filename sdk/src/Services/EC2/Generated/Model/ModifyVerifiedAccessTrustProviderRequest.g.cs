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
    /// Container for the parameters to the ModifyVerifiedAccessTrustProvider operation. Modifies
    /// the configuration of the specified Amazon Web Services Verified Access trust provider.
    /// </summary>
    public partial class ModifyVerifiedAccessTrustProviderRequest : AmazonEC2Request
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
        public ModifyVerifiedAccessTrustProviderDeviceOptions DeviceOptions { get; set; }

        /// <summary>
        /// Checks to see if the DeviceOptions property is set.
        /// </summary>
        internal bool IsSetDeviceOptions() => this.DeviceOptions != null;

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
        public ModifyVerifiedAccessNativeApplicationOidcOptions NativeApplicationOidcOptions { get; set; }

        /// <summary>
        /// Checks to see if the NativeApplicationOidcOptions property is set.
        /// </summary>
        internal bool IsSetNativeApplicationOidcOptions() => this.NativeApplicationOidcOptions != null;

        /// <summary>
        /// Gets and sets the property OidcOptions. 
        /// <para>
        /// The options for an OpenID Connect-compatible user-identity trust provider.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessTrustProviderOidcOptions OidcOptions { get; set; }

        /// <summary>
        /// Checks to see if the OidcOptions property is set.
        /// </summary>
        internal bool IsSetOidcOptions() => this.OidcOptions != null;

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
        /// Gets and sets the property VerifiedAccessTrustProviderId. 
        /// <para>
        /// The ID of the Verified Access trust provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VerifiedAccessTrustProviderId { get; set; }

        /// <summary>
        /// Checks to see if the VerifiedAccessTrustProviderId property is set.
        /// </summary>
        internal bool IsSetVerifiedAccessTrustProviderId() => this.VerifiedAccessTrustProviderId != null;
    }
}
