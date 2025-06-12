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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSite operation.
    /// Creates a site for an Outpost.
    /// </summary>
    public partial class CreateSiteRequest : AmazonOutpostsRequest
    {
        private string _description;
        private string _name;
        private string _notes;
        private Address _operatingAddress;
        private RackPhysicalProperties _rackPhysicalProperties;
        private Address _shippingAddress;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=1, Max=1001)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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
        /// Gets and sets the property Notes. 
        /// <para>
        /// Additional information that you provide about site access requirements, electrician
        /// scheduling, personal protective equipment, or regulation of equipment materials that
        /// could affect your installation process. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingAddress. 
        /// <para>
        ///  The location to install and power on the hardware. This address might be different
        /// from the shipping address. 
        /// </para>
        /// </summary>
        public Address OperatingAddress
        {
            get { return this._operatingAddress; }
            set { this._operatingAddress = value; }
        }

        // Check to see if OperatingAddress property is set
        internal bool IsSetOperatingAddress()
        {
            return this._operatingAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RackPhysicalProperties. 
        /// <para>
        ///  Information about the physical and logistical details for the rack at this site.
        /// For more information about hardware requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#checklist">Network
        /// readiness checklist</a> in the Amazon Web Services Outposts User Guide. 
        /// </para>
        /// </summary>
        public RackPhysicalProperties RackPhysicalProperties
        {
            get { return this._rackPhysicalProperties; }
            set { this._rackPhysicalProperties = value; }
        }

        // Check to see if RackPhysicalProperties property is set
        internal bool IsSetRackPhysicalProperties()
        {
            return this._rackPhysicalProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        ///  The location to ship the hardware. This address might be different from the operating
        /// address. 
        /// </para>
        /// </summary>
        public Address ShippingAddress
        {
            get { return this._shippingAddress; }
            set { this._shippingAddress = value; }
        }

        // Check to see if ShippingAddress property is set
        internal bool IsSetShippingAddress()
        {
            return this._shippingAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags to apply to a site. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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