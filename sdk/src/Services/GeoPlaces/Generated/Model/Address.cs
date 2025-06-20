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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// The place address.
    /// </summary>
    public partial class Address
    {
        private string _addressNumber;
        private string _block;
        private string _building;
        private Country _country;
        private string _district;
        private List<string> _intersection = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _label;
        private string _locality;
        private string _postalCode;
        private Region _region;
        private List<SecondaryAddressComponent> _secondaryAddressComponents = AWSConfigs.InitializeCollections ? new List<SecondaryAddressComponent>() : null;
        private string _street;
        private List<StreetComponents> _streetComponents = AWSConfigs.InitializeCollections ? new List<StreetComponents>() : null;
        private string _subBlock;
        private string _subDistrict;
        private SubRegion _subRegion;

        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The number that identifies an address within a street.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=10)]
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
        /// Gets and sets the property Block. 
        /// <para>
        /// Name of the block. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Sunny Mansion 203 block: 2 Chome</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block != null;
        }

        /// <summary>
        /// Gets and sets the property Building. 
        /// <para>
        /// The name of the building at the address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string Building
        {
            get { return this._building; }
            set { this._building = value; }
        }

        // Check to see if Building property is set
        internal bool IsSetBuilding()
        {
            return this._building != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country component of the address.
        /// </para>
        /// </summary>
        public Country Country
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
        /// Gets and sets the property District. 
        /// <para>
        /// The district or division of a locality associated with this address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string District
        {
            get { return this._district; }
            set { this._district = value; }
        }

        // Check to see if District property is set
        internal bool IsSetDistrict()
        {
            return this._district != null;
        }

        /// <summary>
        /// Gets and sets the property Intersection. 
        /// <para>
        /// Name of the streets in the intersection. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>["Friedrichstraße","Unter den Linden"]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Intersection
        {
            get { return this._intersection; }
            set { this._intersection = value; }
        }

        // Check to see if Intersection property is set
        internal bool IsSetIntersection()
        {
            return this._intersection != null && (this._intersection.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Assembled address value built out of the address components, according to the regional
        /// postal rules. This is the correctly formatted address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
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
        /// Gets and sets the property Locality. 
        /// <para>
        /// The city or locality of the address.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Vancouver</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string Locality
        {
            get { return this._locality; }
            set { this._locality = value; }
        }

        // Check to see if Locality property is set
        internal bool IsSetLocality()
        {
            return this._locality != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code, for which the result should possess. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
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
        /// The region or state results should be present in. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>North Rhine-Westphalia</c>.
        /// </para>
        /// </summary>
        public Region Region
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
        /// Gets and sets the property SecondaryAddressComponents. 
        /// <para>
        /// Components that correspond to secondary identifiers on an Address. Secondary address
        /// components include information such as Suite or Unit Number, Building, or Floor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<SecondaryAddressComponent> SecondaryAddressComponents
        {
            get { return this._secondaryAddressComponents; }
            set { this._secondaryAddressComponents = value; }
        }

        // Check to see if SecondaryAddressComponents property is set
        internal bool IsSetSecondaryAddressComponents()
        {
            return this._secondaryAddressComponents != null && (this._secondaryAddressComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// The name of the street results should be present in.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
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
        /// Gets and sets the property StreetComponents. 
        /// <para>
        /// Components of the street. 
        /// </para>
        ///  
        /// <para>
        /// Example: Younge from the "Younge street".
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<StreetComponents> StreetComponents
        {
            get { return this._streetComponents; }
            set { this._streetComponents = value; }
        }

        // Check to see if StreetComponents property is set
        internal bool IsSetStreetComponents()
        {
            return this._streetComponents != null && (this._streetComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubBlock. 
        /// <para>
        /// Name of sub-block. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Sunny Mansion 203 sub-block: 4</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string SubBlock
        {
            get { return this._subBlock; }
            set { this._subBlock = value; }
        }

        // Check to see if SubBlock property is set
        internal bool IsSetSubBlock()
        {
            return this._subBlock != null;
        }

        /// <summary>
        /// Gets and sets the property SubDistrict. 
        /// <para>
        /// A subdivision of a district. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Minden-Lübbecke</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string SubDistrict
        {
            get { return this._subDistrict; }
            set { this._subDistrict = value; }
        }

        // Check to see if SubDistrict property is set
        internal bool IsSetSubDistrict()
        {
            return this._subDistrict != null;
        }

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The sub-region or county for which results should be present in. 
        /// </para>
        /// </summary>
        public SubRegion SubRegion
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