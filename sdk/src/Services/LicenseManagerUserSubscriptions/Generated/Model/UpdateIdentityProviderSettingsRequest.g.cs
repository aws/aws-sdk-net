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
    /// Container for the parameters to the UpdateIdentityProviderSettings operation. Updates
    /// additional product configuration settings for the registered identity provider.
    /// </summary>
    public partial class UpdateIdentityProviderSettingsRequest : AmazonLicenseManagerUserSubscriptionsRequest
    {
        /// <summary>
        /// Gets and sets the property IdentityProvider.
        /// </summary>
        public IdentityProvider IdentityProvider { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProvider property is set.
        /// </summary>
        internal bool IsSetIdentityProvider() => this.IdentityProvider != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity provider to update.
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
        [AWSProperty(Required = true)]
        public UpdateSettings UpdateSettings { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSettings property is set.
        /// </summary>
        internal bool IsSetUpdateSettings() => this.UpdateSettings != null;
    }
}
