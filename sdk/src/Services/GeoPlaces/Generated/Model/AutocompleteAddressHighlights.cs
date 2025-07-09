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
    /// Describes how the parts of the response element matched the input query by returning
    /// the sections of the response which matched to input query terms.
    /// </summary>
    public partial class AutocompleteAddressHighlights
    {
        private List<Highlight> _addressNumber = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private List<Highlight> _block = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private List<Highlight> _building = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private CountryHighlights _country;
        private List<Highlight> _district = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private List<List<Highlight>> _intersection = AWSConfigs.InitializeCollections ? new List<List<Highlight>>() : null;
        private List<Highlight> _label = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private List<Highlight> _locality = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private List<Highlight> _postalCode = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private RegionHighlights _region;
        private List<Highlight> _street = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private List<Highlight> _subBlock = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private List<Highlight> _subDistrict = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;
        private SubRegionHighlights _subRegion;

        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The house number or address results should have. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Highlight> AddressNumber
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
        public List<Highlight> Block
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
        public List<Highlight> Building
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
        /// </summary>
        public CountryHighlights Country
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
        /// The district or division of a city the results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Highlight> District
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
        /// Gets and sets the property Intersection. 
        /// <para>
        /// Name of the streets in the intersection. For example: e.g. ["Friedrichstraße","Unter
        /// den Linden"]
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<List<Highlight>> Intersection
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
        /// Indicates the starting and ending indexes for result items where they are identified
        /// to match the input query. This should be used to provide emphasis to output display
        /// to make selecting the correct result from a list easier for end users.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Highlight> Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null && (this._label.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Locality. 
        /// <para>
        /// The city or locality results should be present in. 
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
        public List<Highlight> Locality
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
        /// as post code, postcode, or ZIP code for which the result should possess. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Highlight> PostalCode
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
        /// The region or state results should be to be present in. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>North Rhine-Westphalia</c>.
        /// </para>
        /// </summary>
        public RegionHighlights Region
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
        /// The name of the street results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Highlight> Street
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
        public List<Highlight> SubBlock
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
        /// Indicates the starting and ending index of the title in the text query that match
        /// the found title. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Highlight> SubDistrict
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
        /// </summary>
        public SubRegionHighlights SubRegion
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