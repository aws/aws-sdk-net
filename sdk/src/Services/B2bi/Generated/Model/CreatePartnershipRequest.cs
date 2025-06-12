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
    /// Container for the parameters to the CreatePartnership operation.
    /// Creates a partnership between a customer and a trading partner, based on the supplied
    /// parameters. A partnership represents the connection between you and your trading partner.
    /// It ties together a profile and one or more trading capabilities.
    /// </summary>
    public partial class CreatePartnershipRequest : AmazonB2biRequest
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CapabilityOptions _capabilityOptions;
        private string _clientToken;
        private string _email;
        private string _name;
        private string _phone;
        private string _profileId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Specifies a list of the capabilities associated with this partnership.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Specify the structure that contains the details for the associated capabilities.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Specifies the email address associated with this trading partner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=5, Max=254)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies a descriptive name for the partnership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=254)]
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
        /// Gets and sets the property Phone. 
        /// <para>
        /// Specifies the phone number associated with the partnership.
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
        /// Specifies the unique, system-generated identifier for the profile connected to this
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the key-value pairs assigned to ARNs that you can use to group and search
        /// for resources by type. You can attach this metadata to resources (capabilities, partnerships,
        /// and so on) for any purpose.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}