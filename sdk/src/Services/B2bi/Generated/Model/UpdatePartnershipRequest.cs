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
    /// Container for the parameters to the UpdatePartnership operation.
    /// Updates some of the parameters for a partnership between a customer and trading partner.
    /// A partnership represents the connection between you and your trading partner. It ties
    /// together a profile and one or more trading capabilities.
    /// </summary>
    public partial class UpdatePartnershipRequest : AmazonB2biRequest
    {
        private List<string> _capabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CapabilityOptions _capabilityOptions;
        private string _name;
        private string _partnershipId;

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// List of the capabilities associated with this partnership.
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
        /// To update, specify the structure that contains the details for the associated capabilities.
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
        /// Gets and sets the property PartnershipId. 
        /// <para>
        /// Specifies the unique, system-generated identifier for a partnership.
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

    }
}