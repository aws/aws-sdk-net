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
    /// Information about a site.
    /// </summary>
    public partial class Site
    {
        private string _accountId;
        private string _description;
        private string _name;
        private string _notes;
        private string _operatingAddressCity;
        private string _operatingAddressCountryCode;
        private string _operatingAddressStateOrRegion;
        private RackPhysicalProperties _rackPhysicalProperties;
        private string _siteArn;
        private string _siteId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

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
        [AWSProperty(Min=1, Max=1000)]
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
        ///  Notes about a site. 
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
        /// Gets and sets the property OperatingAddressCity. 
        /// <para>
        ///  City where the hardware is installed and powered on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string OperatingAddressCity
        {
            get { return this._operatingAddressCity; }
            set { this._operatingAddressCity = value; }
        }

        // Check to see if OperatingAddressCity property is set
        internal bool IsSetOperatingAddressCity()
        {
            return this._operatingAddressCity != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingAddressCountryCode. 
        /// <para>
        ///  The ISO-3166 two-letter country code where the hardware is installed and powered
        /// on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string OperatingAddressCountryCode
        {
            get { return this._operatingAddressCountryCode; }
            set { this._operatingAddressCountryCode = value; }
        }

        // Check to see if OperatingAddressCountryCode property is set
        internal bool IsSetOperatingAddressCountryCode()
        {
            return this._operatingAddressCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingAddressStateOrRegion. 
        /// <para>
        ///  State or region where the hardware is installed and powered on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string OperatingAddressStateOrRegion
        {
            get { return this._operatingAddressStateOrRegion; }
            set { this._operatingAddressStateOrRegion = value; }
        }

        // Check to see if OperatingAddressStateOrRegion property is set
        internal bool IsSetOperatingAddressStateOrRegion()
        {
            return this._operatingAddressStateOrRegion != null;
        }

        /// <summary>
        /// Gets and sets the property RackPhysicalProperties. 
        /// <para>
        ///  Information about the physical and logistical details for a rack at the site. 
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
        /// Gets and sets the property SiteArn.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SiteArn
        {
            get { return this._siteArn; }
            set { this._siteArn = value; }
        }

        // Check to see if SiteArn property is set
        internal bool IsSetSiteArn()
        {
            return this._siteArn != null;
        }

        /// <summary>
        /// Gets and sets the property SiteId.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SiteId
        {
            get { return this._siteId; }
            set { this._siteId = value; }
        }

        // Check to see if SiteId property is set
        internal bool IsSetSiteId()
        {
            return this._siteId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The site tags.
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