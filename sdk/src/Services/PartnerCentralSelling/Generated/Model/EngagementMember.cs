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
    /// Engagement members are the participants in an Engagement, which is likely a collaborative
    /// project or business opportunity within the AWS partner network. Members can be different
    /// partner organizations or AWS accounts that are working together on a specific engagement.
    /// 
    /// 
    ///  
    /// <para>
    /// Each member is represented by their AWS Account ID, Company Name, and associated details.
    /// Members have a status within the Engagement (PENDING, ACCEPTED, REJECTED, or WITHDRAWN),
    /// indicating their current state of participation. Only existing members of an Engagement
    /// can view the list of other members. This implies a level of privacy and access control
    /// within the Engagement structure. 
    /// </para>
    /// </summary>
    public partial class EngagementMember
    {
        private string _accountId;
        private string _companyName;
        private string _websiteUrl;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// This is the unique identifier for the AWS account associated with the member organization.
        /// It's used for AWS-related operations and identity verification. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The official name of the member's company or organization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=120)]
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
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The URL of the member company's website. This offers a way to find more information
        /// about the member organization and serves as an additional identifier. 
        /// </para>
        /// </summary>
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