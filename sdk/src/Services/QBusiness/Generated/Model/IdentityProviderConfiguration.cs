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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information about the identity provider (IdP) used to authenticate end users
    /// of an Amazon Q Business web experience.
    /// </summary>
    public partial class IdentityProviderConfiguration
    {
        private OpenIDConnectProviderConfiguration _openidConnectConfiguration;
        private SamlProviderConfiguration _samlConfiguration;

        /// <summary>
        /// Gets and sets the property OpenIDConnectConfiguration.
        /// </summary>
        public OpenIDConnectProviderConfiguration OpenIDConnectConfiguration
        {
            get { return this._openidConnectConfiguration; }
            set { this._openidConnectConfiguration = value; }
        }

        // Check to see if OpenIDConnectConfiguration property is set
        internal bool IsSetOpenIDConnectConfiguration()
        {
            return this._openidConnectConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SamlConfiguration.
        /// </summary>
        public SamlProviderConfiguration SamlConfiguration
        {
            get { return this._samlConfiguration; }
            set { this._samlConfiguration = value; }
        }

        // Check to see if SamlConfiguration property is set
        internal bool IsSetSamlConfiguration()
        {
            return this._samlConfiguration != null;
        }

    }
}