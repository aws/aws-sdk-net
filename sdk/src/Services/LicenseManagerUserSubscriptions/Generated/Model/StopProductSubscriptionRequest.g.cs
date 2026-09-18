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
    /// Container for the parameters to the StopProductSubscription operation. Stops a product
    /// subscription for a user with the specified identity provider.
    /// </summary>
    public partial class StopProductSubscriptionRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name of the Active Directory that contains the user for whom to stop the
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
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The name of the user-based subscription product.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>VISUAL_STUDIO_ENTERPRISE</c> | <c>VISUAL_STUDIO_PROFESSIONAL</c>
        /// | <c>OFFICE_PROFESSIONAL_PLUS</c> | <c>OFFICE_STANDARD</c> | <c>REMOTE_DESKTOP_SERVICES</c>
        /// 
        /// </para>
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// Checks to see if the Product property is set.
        /// </summary>
        internal bool IsSetProduct() => this.Product != null;

        /// <summary>
        /// Gets and sets the property ProductUserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the product user.
        /// </para>
        /// </summary>
        public string ProductUserArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductUserArn property is set.
        /// </summary>
        internal bool IsSetProductUserArn() => this.ProductUserArn != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name from the identity provider for the user.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
