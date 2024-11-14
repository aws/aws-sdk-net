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
    /// A summary of the user-based subscription products for a specific user.
    /// </summary>
    public partial class ProductUserSummary
    {
        private string _domain;
        private IdentityProvider _identityProvider;
        private string _product;
        private string _productUserArn;
        private string _status;
        private string _statusMessage;
        private string _subscriptionEndDate;
        private string _subscriptionStartDate;
        private string _username;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name of the Active Directory that contains the user information for the
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
        /// Gets and sets the property ProductUserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this product user.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a product for this user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for a product for this user.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionEndDate. 
        /// <para>
        /// The end date of a subscription.
        /// </para>
        /// </summary>
        public string SubscriptionEndDate
        {
            get { return this._subscriptionEndDate; }
            set { this._subscriptionEndDate = value; }
        }

        // Check to see if SubscriptionEndDate property is set
        internal bool IsSetSubscriptionEndDate()
        {
            return this._subscriptionEndDate != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionStartDate. 
        /// <para>
        /// The start date of a subscription.
        /// </para>
        /// </summary>
        public string SubscriptionStartDate
        {
            get { return this._subscriptionStartDate; }
            set { this._subscriptionStartDate = value; }
        }

        // Check to see if SubscriptionStartDate property is set
        internal bool IsSetSubscriptionStartDate()
        {
            return this._subscriptionStartDate != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name from the identity provider for this product user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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