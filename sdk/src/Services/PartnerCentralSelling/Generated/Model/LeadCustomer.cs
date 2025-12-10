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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
        private AddressSummary _address;
        private string _awsMaturity;
        private string _companyName;
        private Industry _industry;
        private MarketSegment _marketSegment;
        private string _websiteUrl;

        /// <summary>
        /// Gets and sets the property Address.
        /// </summary>
        [AWSProperty(Required=true)]
        public AddressSummary Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property AwsMaturity. 
        /// <para>
        /// Indicates the customer's level of experience and adoption with AWS services. This
        /// assessment helps determine the appropriate engagement approach and solution complexity.
        /// </para>
        /// </summary>
        public string AwsMaturity
        {
            get { return this._awsMaturity; }
            set { this._awsMaturity = value; }
        }

        // Check to see if AwsMaturity property is set
        internal bool IsSetAwsMaturity()
        {
            return this._awsMaturity != null;
        }

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the lead customer's company. This field is essential for identifying and
        /// tracking the customer organization associated with the lead.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string CompanyName
        {
            get { return this._companyName; }
            set { this._companyName = value; }
        }

        // Check to see if CompanyName property is set
        internal bool IsSetCompanyName()
        {
            return this._companyName != null;
        }

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// Specifies the industry sector to which the lead customer's company belongs. This categorization
        /// helps in understanding the customer's business context and tailoring appropriate solutions.
        /// </para>
        /// </summary>
        public Industry Industry
        {
            get { return this._industry; }
            set { this._industry = value; }
        }

        // Check to see if Industry property is set
        internal bool IsSetIndustry()
        {
            return this._industry != null;
        }

        /// <summary>
        /// Gets and sets the property MarketSegment. 
        /// <para>
        /// Specifies the market segment classification of the lead customer, such as enterprise,
        /// mid-market, or small business. This segmentation helps in targeting appropriate solutions
        /// and engagement strategies.
        /// </para>
        /// </summary>
        public MarketSegment MarketSegment
        {
            get { return this._marketSegment; }
            set { this._marketSegment = value; }
        }

        // Check to see if MarketSegment property is set
        internal bool IsSetMarketSegment()
        {
            return this._marketSegment != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The website URL of the lead customer's company. This provides additional context about
        /// the customer organization and helps verify company legitimacy and size.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string WebsiteUrl
        {
            get { return this._websiteUrl; }
            set { this._websiteUrl = value; }
        }

        // Check to see if WebsiteUrl property is set
        internal bool IsSetWebsiteUrl()
        {
            return this._websiteUrl != null;
        }

    }
}