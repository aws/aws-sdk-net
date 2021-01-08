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

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Container for the parameters to the ResolveCustomer operation.
    /// ResolveCustomer is called by a SaaS application during the registration process. When
    /// a buyer visits your website during the registration process, the buyer submits a registration
    /// token through their browser. The registration token is resolved through this API to
    /// obtain a CustomerIdentifier and product code.
    /// </summary>
    public partial class ResolveCustomerRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private string _registrationToken;

        /// <summary>
        /// Gets and sets the property RegistrationToken. 
        /// <para>
        /// When a buyer visits your website during the registration process, the buyer submits
        /// a registration token through the browser. The registration token is resolved to obtain
        /// a CustomerIdentifier and product code.
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