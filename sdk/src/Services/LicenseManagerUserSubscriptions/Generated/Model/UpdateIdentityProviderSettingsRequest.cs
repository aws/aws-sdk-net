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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIdentityProviderSettings operation.
    /// Updates additional product configuration settings for the registered identity provider.
    /// </summary>
    public partial class UpdateIdentityProviderSettingsRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        private IdentityProvider _identityProvider;
        private string _product;
        private UpdateSettings _updateSettings;

        /// <summary>
        /// Gets and sets the property IdentityProvider.
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityProvider IdentityProvider
        {
            get { return this._identityProvider; }
            set { this._identityProvider = value; }
        }

        // Check to see if IdentityProvider property is set
        internal bool IsSetIdentityProvider()
        {
            return this._identityProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The name of the user-based subscription product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        // Check to see if Product property is set
        internal bool IsSetProduct()
        {
            return this._product != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateSettings. 
        /// <para>
        /// Updates the registered identity provider’s product related configuration settings.
        /// You can update any combination of settings in a single operation such as the:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Subnets which you want to add to provision VPC endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subnets which you want to remove the VPC endpoints from.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Security group ID which permits traffic to the VPC endpoints.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateSettings UpdateSettings
        {
            get { return this._updateSettings; }
            set { this._updateSettings = value; }
        }

        // Check to see if UpdateSettings property is set
        internal bool IsSetUpdateSettings()
        {
            return this._updateSettings != null;
        }

    }
}