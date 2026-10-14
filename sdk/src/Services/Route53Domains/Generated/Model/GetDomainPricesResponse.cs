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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// The GetDomainPrices response includes the following element.
    /// </summary>
    public partial class GetDomainPricesResponse : AmazonWebServiceResponse
    {
        private DomainPrice _domainPrice;

        /// <summary>
        /// Gets and sets the property DomainPrice. 
        /// <para>
        /// The registration, transfer, owner change, renewal, and restoration prices for the
        /// specified domain.
        /// </para>
        /// </summary>
        public DomainPrice DomainPrice
        {
            get { return this._domainPrice; }
            set { this._domainPrice = value; }
        }

        // Check to see if DomainPrice property is set
        internal bool IsSetDomainPrice()
        {
            return this._domainPrice != null;
        }

    }
}