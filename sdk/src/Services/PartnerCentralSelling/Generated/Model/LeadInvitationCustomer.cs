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
    /// Contains customer information included in a lead invitation payload. This structure
    /// provides essential details about the customer to help partners evaluate the lead opportunity
    /// and determine their interest in engagement.
    /// </summary>
    public partial class LeadInvitationCustomer
    {
        private string _awsMaturity;
        private string _companyName;
        private CountryCode _countryCode;
        private Industry _industry;
        private MarketSegment _marketSegment;
        private string _websiteUrl;

        /// <summary>
        /// Gets and sets the property AwsMaturity. 
        /// <para>
        /// Indicates the customer's level of experience and adoption with AWS services. This
        /// assessment helps partners understand the customer's cloud maturity and tailor their
        /// engagement approach accordingly.
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
        /// The name of the customer company associated with the lead invitation. This field identifies
        /// the target organization for the lead engagement opportunity.
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
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code indicating the geographic location of the customer company. This
        /// information helps partners understand regional requirements and assess their ability
        /// to serve the customer effectively.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public CountryCode CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// Specifies the industry sector of the customer company associated with the lead invitation.
        /// This categorization helps partners understand the customer's business context and
        /// assess solution fit.
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
        /// Specifies the market segment classification of the customer, such as enterprise, mid-market,
        /// or small business. This segmentation helps partners determine the appropriate solution
        /// complexity and engagement strategy.
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
        /// The website URL of the customer company. This provides additional context about the
        /// customer organization and helps partners verify company details and assess business
        /// size and legitimacy.
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