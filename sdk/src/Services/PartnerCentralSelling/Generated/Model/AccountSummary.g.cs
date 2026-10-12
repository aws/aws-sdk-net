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
    /// An object that contains an <c>Account</c>'s subset of fields.
    /// </summary>
    public partial class AccountSummary
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s address details associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public AddressSummary Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s company name associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null;

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// Specifies which industry the end <c>Customer</c> belongs to associated with the <c>Opportunity</c>.
        /// It refers to the category or sector that the customer's business operates in.
        /// </para>
        ///  
        /// <para>
        /// To submit a value outside the picklist, use <c>Other</c>.
        /// </para>
        ///  
        /// <para>
        /// Conditionally mandatory if <c>Other</c> is selected for Industry Vertical in LOVs.
        /// </para>
        /// </summary>
        public Industry Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property OtherIndustry. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s industry associated with the <c> Opportunity</c>,
        /// when the selected value in the <c>Industry</c> field is <c>Other</c>. This field is
        /// relevant when the customer's industry doesn't fall under the predefined picklist values
        /// and requires a custom description.
        /// </para>
        /// </summary>
        public string OtherIndustry { get; set; }

        /// <summary>
        /// Checks to see if the OtherIndustry property is set.
        /// </summary>
        internal bool IsSetOtherIndustry() => this.OtherIndustry != null;

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// Specifies the end customer's company website URL associated with the <c>Opportunity</c>.
        /// This value is crucial to map the customer within the Amazon Web Services CRM system.
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
