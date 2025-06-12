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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountDetails operation.
    /// Update your Amazon SES account details.
    /// </summary>
    public partial class PutAccountDetailsRequest : AmazonSimpleEmailServiceV2Request
    {
        private List<string> _additionalContactEmailAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ContactLanguage _contactLanguage;
        private MailType _mailType;
        private bool? _productionAccessEnabled;
        private string _useCaseDescription;
        private string _websiteURL;

        /// <summary>
        /// Gets and sets the property AdditionalContactEmailAddresses. 
        /// <para>
        /// Additional email addresses that you would like to be notified regarding Amazon SES
        /// matters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._additionalContactEmailAddresses != null && (this._additionalContactEmailAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContactLanguage. 
        /// <para>
        /// The language you would prefer to be contacted with.
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
        /// The type of email your account will send.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ProductionAccessEnabled. 
        /// <para>
        /// Indicates whether or not your account should have production access in the current
        /// Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>false</c>, then your account is in the <i>sandbox</i>. When your
        /// account is in the sandbox, you can only send email to verified identities. 
        /// </para>
        ///  
        /// <para>
        /// If the value is <c>true</c>, then your account has production access. When your account
        /// has production access, you can send email to any address. The sending quota and maximum
        /// sending rate for your account vary based on your specific use case.
        /// </para>
        /// </summary>
        public bool? ProductionAccessEnabled
        {
            get { return this._productionAccessEnabled; }
            set { this._productionAccessEnabled = value; }
        }

        // Check to see if ProductionAccessEnabled property is set
        internal bool IsSetProductionAccessEnabled()
        {
            return this._productionAccessEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UseCaseDescription. 
        /// <para>
        /// A description of the types of email that you plan to send.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=5000)]
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
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1000)]
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