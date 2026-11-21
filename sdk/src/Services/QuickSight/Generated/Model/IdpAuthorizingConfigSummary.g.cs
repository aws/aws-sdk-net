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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A summary of the identity provider configuration of an access control application.
    /// </summary>
    public partial class IdpAuthorizingConfigSummary
    {
        /// <summary>
        /// Gets and sets the property IdcTrustedTokenIssuerConfiguration. 
        /// <para>
        /// A trusted token issuer configuration. When you provide it, Quick Sight authenticates
        /// the user with the external IdP and then exchanges the token with IAM Identity Center
        /// through the specified trusted token issuer. You can't change it after the application
        /// is created.
        /// </para>
        /// </summary>
        public IdcTrustedTokenIssuerConfig IdcTrustedTokenIssuerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdcTrustedTokenIssuerConfiguration property is set.
        /// </summary>
        internal bool IsSetIdcTrustedTokenIssuerConfiguration() => this.IdcTrustedTokenIssuerConfiguration != null;

        /// <summary>
        /// Gets and sets the property IdpAuthorizingConfigurationSummaryDetail. 
        /// <para>
        /// The details of the external IdP configuration. This is present when the <c>IdpAuthorizingType</c>
        /// is <c>EXTERNAL_IDP_PUBLIC_AUTH_CODE</c> or <c>EXTERNAL_IDP_CONFIDENTIAL_AUTH_CODE</c>.
        /// </para>
        /// </summary>
        public IdpAuthorizingConfigurationSummaryDetail IdpAuthorizingConfigurationSummaryDetail { get; set; }

        /// <summary>
        /// Checks to see if the IdpAuthorizingConfigurationSummaryDetail property is set.
        /// </summary>
        internal bool IsSetIdpAuthorizingConfigurationSummaryDetail() => this.IdpAuthorizingConfigurationSummaryDetail != null;

        /// <summary>
        /// Gets and sets the property IdpAuthorizingType. 
        /// <para>
        /// How users of the access control application are authenticated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdpAuthorizingType IdpAuthorizingType { get; set; }

        /// <summary>
        /// Checks to see if the IdpAuthorizingType property is set.
        /// </summary>
        internal bool IsSetIdpAuthorizingType() => this.IdpAuthorizingType != null;
    }
}
