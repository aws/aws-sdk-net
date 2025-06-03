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
    /// Contains details about the customer associated with the Engagement Invitation, including
    /// company information and industry.
    /// </summary>
    public partial class EngagementCustomer
    {
        private string _companyName;
        private CountryCode _countryCode;
        private Industry _industry;
        private string _websiteUrl;

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// Represents the name of the customer’s company associated with the Engagement Invitation.
        /// This field is used to identify the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=120)]
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
        /// Indicates the country in which the customer’s company operates. This field is useful
        /// for understanding regional requirements or compliance needs.
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
        /// Specifies the industry to which the customer’s company belongs. This field helps categorize
        /// the opportunity based on the customer’s business sector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// Provides the website URL of the customer’s company. This field helps partners verify
        /// the legitimacy and size of the customer organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=4, Max=255)]
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