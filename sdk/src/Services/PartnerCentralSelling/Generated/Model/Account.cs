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
    /// Specifies the <c>Customer</c>'s account details associated with the <c>Opportunity</c>.
    /// </summary>
    public partial class Account
    {
        private Address _address;
        private string _awsAccountId;
        private string _companyName;
        private string _duns;
        private Industry _industry;
        private string _otherIndustry;
        private string _websiteUrl;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s address details associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Address Address
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
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// Specifies the <c>Customer</c> Amazon Web Services account ID associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s company name associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=120)]
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
        /// Gets and sets the property Duns. 
        /// <para>
        /// Indicates the <c>Customer</c> DUNS number, if available.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Duns
        {
            get { return this._duns; }
            set { this._duns = value; }
        }

        // Check to see if Duns property is set
        internal bool IsSetDuns()
        {
            return this._duns != null;
        }

        /// <summary>
        /// Gets and sets the property Industry. 
        /// <para>
        /// Specifies the industry the end <c>Customer</c> belongs to that's associated with the
        /// <c>Opportunity</c>. It refers to the category or sector where the customer's business
        /// operates. This is a required field.
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
        /// Gets and sets the property OtherIndustry. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s industry associated with the <c>Opportunity</c>,
        /// when the selected value in the <c>Industry</c> field is <c>Other</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string OtherIndustry
        {
            get { return this._otherIndustry; }
            set { this._otherIndustry = value; }
        }

        // Check to see if OtherIndustry property is set
        internal bool IsSetOtherIndustry()
        {
            return this._otherIndustry != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// Specifies the end customer's company website URL associated with the <c>Opportunity</c>.
        /// This value is crucial to map the customer within the Amazon Web Services CRM system.
        /// This field is required in all cases except when the opportunity is related to national
        /// security.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=255)]
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