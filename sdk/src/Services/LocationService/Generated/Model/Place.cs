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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains details about addresses or points of interest that match the search criteria.
    /// </summary>
    public partial class Place
    {
        private string _addressNumber;
        private string _country;
        private PlaceGeometry _geometry;
        private string _label;
        private string _municipality;
        private string _neighborhood;
        private string _postalCode;
        private string _region;
        private string _street;
        private string _subRegion;

        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The numerical portion of an address, such as a building number. 
        /// </para>
        /// </summary>
        public string AddressNumber
        {
            get { return this._addressNumber; }
            set { this._addressNumber = value; }
        }

        // Check to see if AddressNumber property is set
        internal bool IsSetAddressNumber()
        {
            return this._addressNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// A country/region specified using <a href="https://www.iso.org/iso-3166-country-codes.html">ISO
        /// 3166</a> 3-digit country/region code. For example, <code>CAN</code>.
        /// </para>
        /// </summary>
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property Geometry.
        /// </summary>
        [AWSProperty(Required=true)]
        public PlaceGeometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The full name and address of the point of interest such as a city, region, or country.
        /// For example, <code>123 Any Street, Any Town, USA</code>.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property Municipality. 
        /// <para>
        /// A name for a local area, such as a city or town name. For example, <code>Toronto</code>.
        /// </para>
        /// </summary>
        public string Municipality
        {
            get { return this._municipality; }
            set { this._municipality = value; }
        }

        // Check to see if Municipality property is set
        internal bool IsSetMunicipality()
        {
            return this._municipality != null;
        }

        /// <summary>
        /// Gets and sets the property Neighborhood. 
        /// <para>
        /// The name of a community district. For example, <code>Downtown</code>.
        /// </para>
        /// </summary>
        public string Neighborhood
        {
            get { return this._neighborhood; }
            set { this._neighborhood = value; }
        }

        // Check to see if Neighborhood property is set
        internal bool IsSetNeighborhood()
        {
            return this._neighborhood != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// A group of numbers and letters in a country-specific format, which accompanies the
        /// address for the purpose of identifying a location. 
        /// </para>
        /// </summary>
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// A name for an area or geographical division, such as a province or state name. For
        /// example, <code>British Columbia</code>.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// The name for a street or a road to identify a location. For example, <code>Main Street</code>.
        /// </para>
        /// </summary>
        public string Street
        {
            get { return this._street; }
            set { this._street = value; }
        }

        // Check to see if Street property is set
        internal bool IsSetStreet()
        {
            return this._street != null;
        }

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// A country, or an area that's part of a larger region . For example, <code>Metro Vancouver</code>.
        /// </para>
        /// </summary>
        public string SubRegion
        {
            get { return this._subRegion; }
            set { this._subRegion = value; }
        }

        // Check to see if SubRegion property is set
        internal bool IsSetSubRegion()
        {
            return this._subRegion != null;
        }

    }
}