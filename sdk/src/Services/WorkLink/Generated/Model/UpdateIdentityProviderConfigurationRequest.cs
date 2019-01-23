/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIdentityProviderConfiguration operation.
    /// Updates the identity provider configuration for the fleet.
    /// </summary>
    public partial class UpdateIdentityProviderConfigurationRequest : AmazonWorkLinkRequest
    {
        private string _fleetArn;
        private string _identityProviderSamlMetadata;
        private IdentityProviderType _identityProviderType;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The ARN of the fleet.
        /// </para>
        /// </summary>
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderSamlMetadata. 
        /// <para>
        /// The SAML metadata document provided by the customer’s identity provider. The existing
        /// IdentityProviderSamlMetadata is unset if null is passed.
        /// </para>
        /// </summary>
        public string IdentityProviderSamlMetadata
        {
            get { return this._identityProviderSamlMetadata; }
            set { this._identityProviderSamlMetadata = value; }
        }

        // Check to see if IdentityProviderSamlMetadata property is set
        internal bool IsSetIdentityProviderSamlMetadata()
        {
            return this._identityProviderSamlMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// The type of identity provider.
        /// </para>
        /// </summary>
        public IdentityProviderType IdentityProviderType
        {
            get { return this._identityProviderType; }
            set { this._identityProviderType = value; }
        }

        // Check to see if IdentityProviderType property is set
        internal bool IsSetIdentityProviderType()
        {
            return this._identityProviderType != null;
        }

    }
}