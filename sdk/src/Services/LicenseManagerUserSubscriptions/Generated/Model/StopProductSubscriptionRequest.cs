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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the StopProductSubscription operation.
    /// Stops a product subscription for a user with the specified identity provider.
    /// </summary>
    public partial class StopProductSubscriptionRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        private string _domain;
        private IdentityProvider _identityProvider;
        private string _product;
        private string _productUserArn;
        private string _username;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name of the Active Directory that contains the user for whom to stop the
        /// product subscription.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// An object that specifies details for the identity provider.
        /// </para>
        /// </summary>
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
        ///  
        /// <para>
        /// Valid values: <c>VISUAL_STUDIO_ENTERPRISE</c> | <c>VISUAL_STUDIO_PROFESSIONAL</c>
        /// | <c>OFFICE_PROFESSIONAL_PLUS</c> | <c>REMOTE_DESKTOP_SERVICES</c> 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProductUserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the product user.
        /// </para>
        /// </summary>
        public string ProductUserArn
        {
            get { return this._productUserArn; }
            set { this._productUserArn = value; }
        }

        // Check to see if ProductUserArn property is set
        internal bool IsSetProductUserArn()
        {
            return this._productUserArn != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name from the identity provider for the user.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}