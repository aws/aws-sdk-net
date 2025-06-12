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
    /// An object that contains marketing details for the <c>Opportunity</c>.
    /// </summary>
    public partial class Marketing
    {
        private AwsFundingUsed _awsFundingUsed;
        private string _campaignName;
        private List<string> _channels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MarketingSource _source;
        private List<string> _useCases = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AwsFundingUsed. 
        /// <para>
        /// Indicates if the <c>Opportunity</c> is a marketing development fund (MDF) funded activity.
        /// </para>
        /// </summary>
        public AwsFundingUsed AwsFundingUsed
        {
            get { return this._awsFundingUsed; }
            set { this._awsFundingUsed = value; }
        }

        // Check to see if AwsFundingUsed property is set
        internal bool IsSetAwsFundingUsed()
        {
            return this._awsFundingUsed != null;
        }

        /// <summary>
        /// Gets and sets the property CampaignName. 
        /// <para>
        /// Specifies the <c>Opportunity</c> marketing campaign code. The Amazon Web Services
        /// campaign code is a reference to specific marketing initiatives, promotions, or activities.
        /// This field captures the identifier used to track and categorize the <c>Opportunity</c>
        /// within marketing campaigns. If you don't have a campaign code, contact your Amazon
        /// Web Services point of contact to obtain one.
        /// </para>
        /// </summary>
        public string CampaignName
        {
            get { return this._campaignName; }
            set { this._campaignName = value; }
        }

        // Check to see if CampaignName property is set
        internal bool IsSetCampaignName()
        {
            return this._campaignName != null;
        }

        /// <summary>
        /// Gets and sets the property Channels. 
        /// <para>
        /// Specifies the <c>Opportunity</c>'s channel that the marketing activity is associated
        /// with or was contacted through. This field provides information about the specific
        /// marketing channel that contributed to the generation of the lead or contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Channels
        {
            get { return this._channels; }
            set { this._channels = value; }
        }

        // Check to see if Channels property is set
        internal bool IsSetChannels()
        {
            return this._channels != null && (this._channels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Indicates if the <c>Opportunity</c> was sourced from an Amazon Web Services marketing
        /// activity. Use the value <c>Marketing Activity</c>. Use <c>None</c> if it's not associated
        /// with an Amazon Web Services marketing activity. This field helps Amazon Web Services
        /// track the return on marketing investments and enables better distribution of marketing
        /// budgets among partners.
        /// </para>
        /// </summary>
        public MarketingSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property UseCases. 
        /// <para>
        /// Specifies the marketing activity use case or purpose that led to the <c>Opportunity</c>'s
        /// creation or contact. This field captures the context or marketing activity's execution's
        /// intention and the direct correlation to the generated opportunity or contact. Must
        /// be empty when <c>Marketing.AWSFundingUsed = No</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>AI/ML | Analytics | Application Integration | Blockchain | Business
        /// Applications | Cloud Financial Management | Compute | Containers | Customer Engagement
        /// | Databases | Developer Tools | End User Computing | Front End Web &amp; Mobile |
        /// Game Tech | IoT | Management &amp; Governance | Media Services | Migration &amp; Transfer
        /// | Networking &amp; Content Delivery | Quantum Technologies | Robotics | Satellite
        /// | Security | Serverless | Storage | VR &amp; AR</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UseCases
        {
            get { return this._useCases; }
            set { this._useCases = value; }
        }

        // Check to see if UseCases property is set
        internal bool IsSetUseCases()
        {
            return this._useCases != null && (this._useCases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}