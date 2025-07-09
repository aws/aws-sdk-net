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
    /// Parsed address components in the provided QueryText.
    /// </summary>
    public partial class GeocodeParsedQueryAddressComponents
    {
        private List<ParsedQueryComponent> _addressNumber = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _block = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _building = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _country = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _district = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _locality = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _postalCode = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _region = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQuerySecondaryAddressComponent> _secondaryAddressComponents = AWSConfigs.InitializeCollections ? new List<ParsedQuerySecondaryAddressComponent>() : null;
        private List<ParsedQueryComponent> _street = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _subBlock = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _subDistrict = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;
        private List<ParsedQueryComponent> _subRegion = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The number that identifies an address within a street.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> AddressNumber
        {
            get { return this._addressNumber; }
            set { this._addressNumber = value; }
        }

        // Check to see if AddressNumber property is set
        internal bool IsSetAddressNumber()
        {
            return this._addressNumber != null && (this._addressNumber.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block != null && (this._block.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Building. 
        /// <para>
        /// The name of the building at the address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> Building
        {
            get { return this._building; }
            set { this._building = value; }
        }

        // Check to see if Building property is set
        internal bool IsSetBuilding()
        {
            return this._building != null && (this._building.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country that the results will be present
        /// in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null && (this._country.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property District. 
        /// <para>
        /// The district or division of a city the results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> District
        {
            get { return this._district; }
            set { this._district = value; }
        }

        // Check to see if District property is set
        internal bool IsSetDistrict()
        {
            return this._district != null && (this._district.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> Locality
        {
            get { return this._locality; }
            set { this._locality = value; }
        }

        // Check to see if Locality property is set
        internal bool IsSetLocality()
        {
            return this._locality != null && (this._locality.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code, for which the result should possess. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null && (this._postalCode.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null && (this._region.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondaryAddressComponents. 
        /// <para>
        /// Parsed secondary address components from the provided query text.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQuerySecondaryAddressComponent> SecondaryAddressComponents
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> Street
        {
            get { return this._street; }
            set { this._street = value; }
        }

        // Check to see if Street property is set
        internal bool IsSetStreet()
        {
            return this._street != null && (this._street.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> SubBlock
        {
            get { return this._subBlock; }
            set { this._subBlock = value; }
        }

        // Check to see if SubBlock property is set
        internal bool IsSetSubBlock()
        {
            return this._subBlock != null && (this._subBlock.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> SubDistrict
        {
            get { return this._subDistrict; }
            set { this._subDistrict = value; }
        }

        // Check to see if SubDistrict property is set
        internal bool IsSetSubDistrict()
        {
            return this._subDistrict != null && (this._subDistrict.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The sub-region or county for which results should be present in. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ParsedQueryComponent> SubRegion
        {
            get { return this._subRegion; }
            set { this._subRegion = value; }
        }

        // Check to see if SubRegion property is set
        internal bool IsSetSubRegion()
        {
            return this._subRegion != null && (this._subRegion.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}