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
    /// The customer information that you provide for a customer account, such as the company
    /// name, website, and address. We use these details to match the account to a customer.
    /// </summary>
    public partial class CustomerAccountData
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address of the customer company.
        /// </para>
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the customer company.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The internet domain of the customer company, such as <c>example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 253)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property Duns. 
        /// <para>
        /// The Data Universal Numbering System (DUNS) number of the customer company.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Duns { get; set; }

        /// <summary>
        /// Checks to see if the Duns property is set.
        /// </summary>
        internal bool IsSetDuns() => this.Duns != null;

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// The industry of the customer company.
        /// </para>
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property OtherIndustry. 
        /// <para>
        /// A description of the industry, used when the industry is <c>Other</c>.
        /// </para>
        /// </summary>
        public string OtherIndustry { get; set; }

        /// <summary>
        /// Checks to see if the OtherIndustry property is set.
        /// </summary>
        internal bool IsSetOtherIndustry() => this.OtherIndustry != null;

        /// <summary>
        /// Gets and sets the property ParentCompanyName. 
        /// <para>
        /// The name of the parent company of the customer company, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ParentCompanyName { get; set; }

        /// <summary>
        /// Checks to see if the ParentCompanyName property is set.
        /// </summary>
        internal bool IsSetParentCompanyName() => this.ParentCompanyName != null;

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The website URL of the customer company.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebsiteUrl property is set.
        /// </summary>
        internal bool IsSetWebsiteUrl() => this.WebsiteUrl != null;
    }
}
