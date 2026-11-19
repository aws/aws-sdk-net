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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomerAccount operation. Use <c>CreateCustomerAccount</c>
    /// to map a customer account from your records to an AWS customer. Provide details about
    /// the customer, such as the company name and website. AWS then matches the account to
    /// a customer and adds enrichment information about it. <para> Matching runs asynchronously.
    /// The response returns the new customer account with a status of <c>PENDING</c>. Use
    /// <c>GetCustomerAccount</c> to check the result and read the enrichment information.
    /// </para>
    /// </summary>
    public partial class CreateCustomerAccountRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// Specifies the details of the customer, such as the company name, website, and address.
        /// AWS uses these details to match the account to a customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomerAccountData Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog for the request. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c>: Production.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sandbox</c>: Testing environments.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive identifier that you provide to make the request
        /// idempotent. If you retry a request with the same token, the operation returns the
        /// result of the original request instead of creating another customer account.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property PartnerAccountIdentifier. 
        /// <para>
        /// Specifies your own identifier for the customer account, such as the account ID in
        /// your CRM system. Use it to correlate the customer account with your records.
        /// </para>
        /// </summary>
        public string PartnerAccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PartnerAccountIdentifier property is set.
        /// </summary>
        internal bool IsSetPartnerAccountIdentifier() => this.PartnerAccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags to add to the customer account. Each tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
