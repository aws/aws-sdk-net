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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the GetThirdPartyFirewallAssociationStatus operation.
    /// </summary>
    public partial class GetThirdPartyFirewallAssociationStatusResponse : AmazonWebServiceResponse
    {
        private MarketplaceSubscriptionOnboardingStatus _marketplaceOnboardingStatus;
        private ThirdPartyFirewallAssociationStatus _thirdPartyFirewallStatus;

        /// <summary>
        /// Gets and sets the property MarketplaceOnboardingStatus. 
        /// <para>
        /// The status for subscribing to the third-party firewall vendor in the Amazon Web Services
        /// Marketplace.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NO_SUBSCRIPTION</c> - The Firewall Manager policy administrator isn't subscribed
        /// to the third-party firewall service in the Amazon Web Services Marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_COMPLETE</c> - The Firewall Manager policy administrator is in the process
        /// of subscribing to the third-party firewall service in the Amazon Web Services Marketplace,
        /// but doesn't yet have an active subscription.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> - The Firewall Manager policy administrator has an active subscription
        /// to the third-party firewall service in the Amazon Web Services Marketplace.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MarketplaceSubscriptionOnboardingStatus MarketplaceOnboardingStatus
        {
            get { return this._marketplaceOnboardingStatus; }
            set { this._marketplaceOnboardingStatus = value; }
        }

        // Check to see if MarketplaceOnboardingStatus property is set
        internal bool IsSetMarketplaceOnboardingStatus()
        {
            return this._marketplaceOnboardingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ThirdPartyFirewallStatus. 
        /// <para>
        /// The current status for setting a Firewall Manager policy administrators account as
        /// an administrator of the third-party firewall tenant.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ONBOARDING</c> - The Firewall Manager policy administrator is being designated
        /// as a tenant administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONBOARD_COMPLETE</c> - The Firewall Manager policy administrator is designated
        /// as a tenant administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OFFBOARDING</c> - The Firewall Manager policy administrator is being removed as
        /// a tenant administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OFFBOARD_COMPLETE</c> - The Firewall Manager policy administrator has been removed
        /// as a tenant administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_EXIST</c> - The Firewall Manager policy administrator doesn't exist as a tenant
        /// administrator.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ThirdPartyFirewallAssociationStatus ThirdPartyFirewallStatus
        {
            get { return this._thirdPartyFirewallStatus; }
            set { this._thirdPartyFirewallStatus = value; }
        }

        // Check to see if ThirdPartyFirewallStatus property is set
        internal bool IsSetThirdPartyFirewallStatus()
        {
            return this._thirdPartyFirewallStatus != null;
        }

    }
}