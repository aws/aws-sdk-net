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
    /// Container for the parameters to the DeregisterIdentityProvider operation. Deregisters
    /// the Active Directory identity provider from License Manager user-based subscriptions.
    /// </summary>
    public partial class DeregisterIdentityProviderRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        /// <summary>
        /// Gets and sets the property IdentityProvider. 
        /// <para>
        /// An object that specifies details for the Active Directory identity provider.
        /// </para>
        /// </summary>
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the identity provider to deregister.
        /// </para>
        /// </summary>
        public string IdentityProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderArn property is set.
        /// </summary>
        internal bool IsSetIdentityProviderArn() => this.IdentityProviderArn != null;

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
    }
}
