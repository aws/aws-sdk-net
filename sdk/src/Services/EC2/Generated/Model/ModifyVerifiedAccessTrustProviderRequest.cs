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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the ModifyVerifiedAccessTrustProvider operation.
    /// Modifies the configuration of the specified Amazon Web Services Verified Access trust
    /// provider.
    /// </summary>
    public partial class ModifyVerifiedAccessTrustProviderRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private ModifyVerifiedAccessTrustProviderDeviceOptions _deviceOptions;
        private bool? _dryRun;
        private ModifyVerifiedAccessNativeApplicationOidcOptions _nativeApplicationOidcOptions;
        private ModifyVerifiedAccessTrustProviderOidcOptions _oidcOptions;
        private VerifiedAccessSseSpecificationRequest _sseSpecification;
        private string _verifiedAccessTrustProviderId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Verified Access trust provider.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceOptions. 
        /// <para>
        /// The options for a device-based trust provider. This parameter is required when the
        /// provider type is <c>device</c>.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessTrustProviderDeviceOptions DeviceOptions
        {
            get { return this._deviceOptions; }
            set { this._deviceOptions = value; }
        }

        // Check to see if DeviceOptions property is set
        internal bool IsSetDeviceOptions()
        {
            return this._deviceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NativeApplicationOidcOptions. 
        /// <para>
        /// The OpenID Connect (OIDC) options.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessNativeApplicationOidcOptions NativeApplicationOidcOptions
        {
            get { return this._nativeApplicationOidcOptions; }
            set { this._nativeApplicationOidcOptions = value; }
        }

        // Check to see if NativeApplicationOidcOptions property is set
        internal bool IsSetNativeApplicationOidcOptions()
        {
            return this._nativeApplicationOidcOptions != null;
        }

        /// <summary>
        /// Gets and sets the property OidcOptions. 
        /// <para>
        /// The options for an OpenID Connect-compatible user-identity trust provider.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessTrustProviderOidcOptions OidcOptions
        {
            get { return this._oidcOptions; }
            set { this._oidcOptions = value; }
        }

        // Check to see if OidcOptions property is set
        internal bool IsSetOidcOptions()
        {
            return this._oidcOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SseSpecification. 
        /// <para>
        /// The options for server side encryption.
        /// </para>
        /// </summary>
        public VerifiedAccessSseSpecificationRequest SseSpecification
        {
            get { return this._sseSpecification; }
            set { this._sseSpecification = value; }
        }

        // Check to see if SseSpecification property is set
        internal bool IsSetSseSpecification()
        {
            return this._sseSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviderId. 
        /// <para>
        /// The ID of the Verified Access trust provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedAccessTrustProviderId
        {
            get { return this._verifiedAccessTrustProviderId; }
            set { this._verifiedAccessTrustProviderId = value; }
        }

        // Check to see if VerifiedAccessTrustProviderId property is set
        internal bool IsSetVerifiedAccessTrustProviderId()
        {
            return this._verifiedAccessTrustProviderId != null;
        }

    }
}