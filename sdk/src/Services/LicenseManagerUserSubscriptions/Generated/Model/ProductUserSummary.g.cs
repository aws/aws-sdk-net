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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// A summary of the user-based subscription products for a specific user.
    /// </summary>
    public partial class ProductUserSummary
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name of the Active Directory that contains the user information for the
        /// product subscription.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// An object that specifies details for the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property LicenseExpirationDate. 
        /// <para>
        /// The expiration date of the license associated with this subscription, in ISO 8601
        /// UTC format (for example, <c>2025-03-15T00:00:00Z</c>).
        /// </para>
        ///  
        /// <para>
        /// This field applies only to subscriptions that use license server endpoints, such as
        /// Remote Desktop Services (RDS) Subscriber Access License (SAL). It returns <c>null</c>
        /// for products that don't use license-based subscriptions.
        /// </para>
        /// </summary>
        public string LicenseExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the LicenseExpirationDate property is set.
        /// </summary>
        internal bool IsSetLicenseExpirationDate() => this.LicenseExpirationDate != null;

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The name of the user-based subscription product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Product { get; set; }

        /// <summary>
        /// Checks to see if the Product property is set.
        /// </summary>
        internal bool IsSetProduct() => this.Product != null;

        /// <summary>
        /// Gets and sets the property ProductUserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this product user.
        /// </para>
        /// </summary>
        public string ProductUserArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductUserArn property is set.
        /// </summary>
        internal bool IsSetProductUserArn() => this.ProductUserArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a product for this user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for a product for this user.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SubscriptionEndDate. 
        /// <para>
        /// The end date of a subscription.
        /// </para>
        /// </summary>
        public string SubscriptionEndDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionEndDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionEndDate() => this.SubscriptionEndDate != null;

        /// <summary>
        /// Gets and sets the property SubscriptionStartDate. 
        /// <para>
        /// The start date of a subscription.
        /// </para>
        /// </summary>
        public string SubscriptionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionStartDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionStartDate() => this.SubscriptionStartDate != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name from the identity provider for this product user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
