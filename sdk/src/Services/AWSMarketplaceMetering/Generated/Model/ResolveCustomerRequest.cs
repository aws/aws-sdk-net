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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
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
namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Container for the parameters to the ResolveCustomer operation.
    /// <c>ResolveCustomer</c> is called by a SaaS application during the registration process.
    /// When a buyer visits your website during the registration process, the buyer submits
    /// a registration token through their browser. The registration token is resolved through
    /// this API to obtain a <c>CustomerIdentifier</c> along with the <c>CustomerAWSAccountId</c>
    /// and <c>ProductCode</c>.
    /// 
    ///  <note> 
    /// <para>
    /// To successfully resolve the token, the API must be called from the account that was
    /// used to publish the SaaS application. For an example of using <c>ResolveCustomer</c>,
    /// see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/saas-code-examples.html#saas-resolvecustomer-example">
    /// ResolveCustomer code example</a> in the <i>Amazon Web Services Marketplace Seller
    /// Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Permission is required for this operation. Your IAM role or user performing this operation
    /// requires a policy to allow the <c>aws-marketplace:ResolveCustomer</c> action. For
    /// more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsmarketplacemeteringservice.html">Actions,
    /// resources, and condition keys for Amazon Web Services Marketplace Metering Service</a>
    /// in the <i>Service Authorization Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// For Amazon Web Services Regions that support <c>ResolveCustomer</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#resolvecustomer-region-support">ResolveCustomer
    /// Region support</a>. 
    /// </para>
    /// </summary>
    public partial class ResolveCustomerRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private string _registrationToken;

        /// <summary>
        /// Gets and sets the property RegistrationToken. 
        /// <para>
        /// When a buyer visits your website during the registration process, the buyer submits
        /// a registration token through the browser. The registration token is resolved to obtain
        /// a <c>CustomerIdentifier</c> along with the <c>CustomerAWSAccountId</c> and <c>ProductCode</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistrationToken
        {
            get { return this._registrationToken; }
            set { this._registrationToken = value; }
        }

        // Check to see if RegistrationToken property is set
        internal bool IsSetRegistrationToken()
        {
            return this._registrationToken != null;
        }

    }
}