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
    /// Contains detailed information about the customer associated with the lead, including
    /// company details, industry classification, and AWS maturity level. This information
    /// helps qualify and categorize the lead for appropriate engagement strategies.
    /// </summary>
    public partial class LeadCustomer
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The address information for the lead customer.
        /// </para>
        /// </summary>
        public LeadAddress Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AwsMaturity. 
        /// <para>
        /// Indicates the customer's level of experience and adoption with AWS services. This
        /// assessment helps determine the appropriate engagement approach and solution complexity.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string AwsMaturity { get; set; }

        /// <summary>
        /// Checks to see if the AwsMaturity property is set.
        /// </summary>
        internal bool IsSetAwsMaturity() => this.AwsMaturity != null;

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the lead customer's company. This field is essential for identifying and
        /// tracking the customer organization associated with the lead.
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
        /// Specifies the industry sector to which the lead customer's company belongs. This categorization
        /// helps in understanding the customer's business context and tailoring appropriate solutions.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Industry { get; set; }

        /// <summary>
        /// Checks to see if the Industry property is set.
        /// </summary>
        internal bool IsSetIndustry() => this.Industry != null;

        /// <summary>
        /// Gets and sets the property MarketSegment. 
        /// <para>
        /// Specifies the market segment classification of the lead customer, such as enterprise,
        /// mid-market, or small business. This segmentation helps in targeting appropriate solutions
        /// and engagement strategies.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string MarketSegment { get; set; }

        /// <summary>
        /// Checks to see if the MarketSegment property is set.
        /// </summary>
        internal bool IsSetMarketSegment() => this.MarketSegment != null;

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The website URL of the lead customer's company. This provides additional context about
        /// the customer organization and helps verify company legitimacy and size.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 255)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebsiteUrl property is set.
        /// </summary>
        internal bool IsSetWebsiteUrl() => this.WebsiteUrl != null;
    }
}
