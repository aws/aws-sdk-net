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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about your account details.
    /// </summary>
    public partial class AccountDetails
    {
        /// <summary>
        /// Gets and sets the property AdditionalContactEmailAddresses. 
        /// <para>
        /// Additional email addresses where updates are sent about your account review process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4)]
        public List<string> AdditionalContactEmailAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalContactEmailAddresses property is set.
        /// </summary>
        internal bool IsSetAdditionalContactEmailAddresses() => this.AdditionalContactEmailAddresses != null && (this.AdditionalContactEmailAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContactLanguage. 
        /// <para>
        /// The language you would prefer for the case. The contact language can be one of <c>ENGLISH</c>
        /// or <c>JAPANESE</c>.
        /// </para>
        /// </summary>
        public ContactLanguage ContactLanguage { get; set; }

        /// <summary>
        /// Checks to see if the ContactLanguage property is set.
        /// </summary>
        internal bool IsSetContactLanguage() => this.ContactLanguage != null;

        /// <summary>
        /// Gets and sets the property MailType. 
        /// <para>
        /// The type of email your account is sending. The mail type can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MARKETING</c> – Most of your sending traffic is to keep your customers informed
        /// of your latest offering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSACTIONAL</c> – Most of your sending traffic is to communicate during a transaction
        /// with a customer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MailType MailType { get; set; }

        /// <summary>
        /// Checks to see if the MailType property is set.
        /// </summary>
        internal bool IsSetMailType() => this.MailType != null;

        /// <summary>
        /// Gets and sets the property ReviewDetails. 
        /// <para>
        /// Information about the review of the latest details you submitted.
        /// </para>
        /// </summary>
        public ReviewDetails ReviewDetails { get; set; }

        /// <summary>
        /// Checks to see if the ReviewDetails property is set.
        /// </summary>
        internal bool IsSetReviewDetails() => this.ReviewDetails != null;

        /// <summary>
        /// Gets and sets the property UseCaseDescription. 
        /// <para>
        /// A description of the types of email that you plan to send.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 5000)]
        public string UseCaseDescription { get; set; }

        /// <summary>
        /// Checks to see if the UseCaseDescription property is set.
        /// </summary>
        internal bool IsSetUseCaseDescription() => this.UseCaseDescription != null;

        /// <summary>
        /// Gets and sets the property WebsiteURL. 
        /// <para>
        /// The URL of your website. This information helps us better understand the type of content
        /// that you plan to send.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string WebsiteURL { get; set; }

        /// <summary>
        /// Checks to see if the WebsiteURL property is set.
        /// </summary>
        internal bool IsSetWebsiteURL() => this.WebsiteURL != null;
    }
}
