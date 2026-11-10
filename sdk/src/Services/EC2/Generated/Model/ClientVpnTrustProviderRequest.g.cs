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
    /// Describes a device trust provider to configure for a Client VPN endpoint.
    /// </summary>
    public partial class ClientVpnTrustProviderRequest
    {
        /// <summary>
        /// Gets and sets the property PublicSigningKeyUrl. 
        /// <para>
        /// The URL of the public signing key that is used to verify the identity token issued
        /// by the device trust provider.
        /// </para>
        /// </summary>
        public string PublicSigningKeyUrl { get; set; }

        /// <summary>
        /// Checks to see if the PublicSigningKeyUrl property is set.
        /// </summary>
        internal bool IsSetPublicSigningKeyUrl() => this.PublicSigningKeyUrl != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The tenant ID associated with your device trust provider account.
        /// </para>
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;

        /// <summary>
        /// Gets and sets the property TrustProviderType. 
        /// <para>
        /// The type of the device trust provider. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>crowdstrike</c> - CrowdStrike device trust provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>jamf</c> - Jamf device trust provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>jumpcloud</c> - JumpCloud device trust provider.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ClientVpnDeviceTrustProviderType TrustProviderType { get; set; }

        /// <summary>
        /// Checks to see if the TrustProviderType property is set.
        /// </summary>
        internal bool IsSetTrustProviderType() => this.TrustProviderType != null;
    }
}
