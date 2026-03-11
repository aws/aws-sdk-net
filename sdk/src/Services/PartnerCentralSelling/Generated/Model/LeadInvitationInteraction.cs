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
    /// Represents interaction details included in a lead invitation payload. This structure
    /// provides context about how the lead was generated and the customer's engagement history
    /// to help partners assess the opportunity quality.
    /// </summary>
    public partial class LeadInvitationInteraction
    {
        private string _contactBusinessTitle;
        private string _sourceId;
        private string _sourceName;
        private string _sourceType;
        private string _usecase;

        /// <summary>
        /// Gets and sets the property ContactBusinessTitle. 
        /// <para>
        /// The business title or job role of the customer contact involved in the lead interaction.
        /// This helps partners identify the decision-making level and engagement approach for
        /// the lead.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string ContactBusinessTitle
        {
            get { return this._contactBusinessTitle; }
            set { this._contactBusinessTitle = value; }
        }

        // Check to see if ContactBusinessTitle property is set
        internal bool IsSetContactBusinessTitle()
        {
            return this._contactBusinessTitle != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The unique identifier of the specific source that generated the lead interaction.
        /// This provides traceability to the original lead generation activity for reference
        /// and follow-up purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The descriptive name of the source that generated the lead interaction. This human-readable
        /// identifier helps partners understand the specific lead generation channel or campaign
        /// that created the opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies the type of source that generated the lead interaction, such as "Event",
        /// "Website", or "Campaign". This helps partners understand the lead generation channel
        /// and assess lead quality based on the source type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Usecase. 
        /// <para>
        /// Describes the specific use case or business scenario associated with the lead interaction.
        /// This information helps partners understand the customer's interests and potential
        /// solution requirements.
        /// </para>
        /// </summary>
        public string Usecase
        {
            get { return this._usecase; }
            set { this._usecase = value; }
        }

        // Check to see if Usecase property is set
        internal bool IsSetUsecase()
        {
            return this._usecase != null;
        }

    }
}