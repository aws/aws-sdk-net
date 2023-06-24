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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about your account details.
    /// </summary>
    public partial class AccountDetails
    {
        private List<string> _additionalContactEmailAddresses = new List<string>();
        private ContactLanguage _contactLanguage;
        private MailType _mailType;
        private ReviewDetails _reviewDetails;
        private string _useCaseDescription;
        private string _websiteURL;

        /// <summary>
        /// Gets and sets the property AdditionalContactEmailAddresses. 
        /// <para>
        /// Additional email addresses where updates are sent about your account review process.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4)]
        public List<string> AdditionalContactEmailAddresses
        {
            get { return this._additionalContactEmailAddresses; }
            set { this._additionalContactEmailAddresses = value; }
        }

        // Check to see if AdditionalContactEmailAddresses property is set
        internal bool IsSetAdditionalContactEmailAddresses()
        {
            return this._additionalContactEmailAddresses != null && this._additionalContactEmailAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContactLanguage. 
        /// <para>
        /// The language you would prefer for the case. The contact language can be one of <code>ENGLISH</code>
        /// or <code>JAPANESE</code>.
        /// </para>
        /// </summary>
        public ContactLanguage ContactLanguage
        {
            get { return this._contactLanguage; }
            set { this._contactLanguage = value; }
        }

        // Check to see if ContactLanguage property is set
        internal bool IsSetContactLanguage()
        {
            return this._contactLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property MailType. 
        /// <para>
        /// The type of email your account is sending. The mail type can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>MARKETING</code> – Most of your sending traffic is to keep your customers informed
        /// of your latest offering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRANSACTIONAL</code> – Most of your sending traffic is to communicate during
        /// a transaction with a customer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MailType MailType
        {
            get { return this._mailType; }
            set { this._mailType = value; }
        }

        // Check to see if MailType property is set
        internal bool IsSetMailType()
        {
            return this._mailType != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewDetails. 
        /// <para>
        /// Information about the review of the latest details you submitted.
        /// </para>
        /// </summary>
        public ReviewDetails ReviewDetails
        {
            get { return this._reviewDetails; }
            set { this._reviewDetails = value; }
        }

        // Check to see if ReviewDetails property is set
        internal bool IsSetReviewDetails()
        {
            return this._reviewDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UseCaseDescription. 
        /// <para>
        /// A description of the types of email that you plan to send.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=5000)]
        public string UseCaseDescription
        {
            get { return this._useCaseDescription; }
            set { this._useCaseDescription = value; }
        }

        // Check to see if UseCaseDescription property is set
        internal bool IsSetUseCaseDescription()
        {
            return this._useCaseDescription != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteURL. 
        /// <para>
        /// The URL of your website. This information helps us better understand the type of content
        /// that you plan to send.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string WebsiteURL
        {
            get { return this._websiteURL; }
            set { this._websiteURL = value; }
        }

        // Check to see if WebsiteURL property is set
        internal bool IsSetWebsiteURL()
        {
            return this._websiteURL != null;
        }

    }
}