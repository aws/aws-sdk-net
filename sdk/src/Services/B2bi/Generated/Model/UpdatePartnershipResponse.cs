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
    /// This is the response object from the UpdatePartnership operation.
    /// </summary>
    public partial class UpdatePartnershipResponse : AmazonWebServiceResponse
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CapabilityOptions _capabilityOptions;
        private DateTime? _createdAt;
        private string _email;
        private DateTime? _modifiedAt;
        private string _name;
        private string _partnershipArn;
        private string _partnershipId;
        private string _phone;
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
        /// <para>
        /// Returns the structure that contains the details for the associated capabilities.
        /// </para>
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
        /// Returns a timestamp that identifies the most recent date and time that the partnership
        /// was modified.
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
        /// Gets and sets the property Email. 
        /// <para>
        /// Returns the email address associated with this trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=5, Max=254)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
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
        /// The name of the partnership, used to identify it.
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
        /// Gets and sets the property PartnershipArn. 
        /// <para>
        /// Returns an Amazon Resource Name (ARN) for a specific Amazon Web Services resource,
        /// such as a capability, partnership, profile, or transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PartnershipArn
        {
            get { return this._partnershipArn; }
            set { this._partnershipArn = value; }
        }

        // Check to see if PartnershipArn property is set
        internal bool IsSetPartnershipArn()
        {
            return this._partnershipArn != null;
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
        /// Gets and sets the property Phone. 
        /// <para>
        /// Returns the phone number associated with the partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=7, Max=22)]
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        // Check to see if Phone property is set
        internal bool IsSetPhone()
        {
            return this._phone != null;
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