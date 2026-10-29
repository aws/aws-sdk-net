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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the GetDomainPrices operation. Returns the following
    /// prices for the specified domain: <ul> <li> <para> Registration </para> </li> <li>
    /// <para> Transfer </para> </li> <li> <para> Owner change </para> </li> <li> <para> Renewal
    /// </para> </li> <li> <para> Restoration </para> </li> </ul> <para> For most domains,
    /// the prices match the standard prices for the TLD that the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_ListPrices.html">ListPrices</a>
    /// operation returns. For a premium domain, the registry sets the price individually.
    /// Premium prices might differ from the standard prices and can change over time. </para>
    /// </summary>
    public partial class GetDomainPricesRequest : AmazonRoute53DomainsRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to get the prices for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;
    }
}
