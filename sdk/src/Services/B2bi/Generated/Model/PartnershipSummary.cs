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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// A structure that contains the details for a partnership. A partnership represents
    /// the connection between you and your trading partner. It ties together a profile and
    /// one or more trading capabilities.
    /// </summary>
    public partial class PartnershipSummary
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CapabilityOptions _capabilityOptions;
        private DateTime? _createdAt;
        private DateTime? _modifiedAt;
        private string _name;
        private string _partnershipId;
        private string _profileId;
        private string _tradingPartnerId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Returns one or more capabilities associated with this partnership.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && (this._capabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapabilityOptions.
        /// </summary>
        public CapabilityOptions CapabilityOptions
        {
            get { return this._capabilityOptions; }
            set { this._capabilityOptions = value; }
        }

        // Check to see if CapabilityOptions property is set
        internal bool IsSetCapabilityOptions()
        {
            return this._capabilityOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Returns a timestamp for creation date and time of the partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// Returns a timestamp that identifies the most recent date and time that the partnership
        /// was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Returns the name of the partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PartnershipId. 
        /// <para>
        /// Returns the unique, system-generated identifier for a partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PartnershipId
        {
            get { return this._partnershipId; }
            set { this._partnershipId = value; }
        }

        // Check to see if PartnershipId property is set
        internal bool IsSetPartnershipId()
        {
            return this._partnershipId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// Returns the unique, system-generated identifier for the profile connected to this
        /// partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property TradingPartnerId. 
        /// <para>
        /// Returns the unique, system-generated identifier for a trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TradingPartnerId
        {
            get { return this._tradingPartnerId; }
            set { this._tradingPartnerId = value; }
        }

        // Check to see if TradingPartnerId property is set
        internal bool IsSetTradingPartnerId()
        {
            return this._tradingPartnerId != null;
        }

    }
}