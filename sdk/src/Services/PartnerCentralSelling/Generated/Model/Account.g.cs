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
    /// Specifies the <c>Customer</c>'s account details associated with the <c>Opportunity</c>.
    /// </summary>
    public partial class Account
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// Specifies the end <c>Customer</c>'s address details associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// Specifies the <c>Customer</c> Amazon Web Services account ID associated with the <c>Opportunity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

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
        /// Gets and sets the property Duns. 
        /// <para>
        /// Indicates the <c>Customer</c> DUNS number, if available.
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
        /// Specifies the industry the end <c>Customer</c> belongs to that's associated with the
        /// <c>Opportunity</c>. It refers to the category or sector where the customer's business
        /// operates. This is a required field.
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
        /// Specifies the end <c>Customer</c>'s industry associated with the <c>Opportunity</c>,
        /// when the selected value in the <c>Industry</c> field is <c>Other</c>.
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
        /// This field is required in all cases except when the opportunity is related to national
        /// security.
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
