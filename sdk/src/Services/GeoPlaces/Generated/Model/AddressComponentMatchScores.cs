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
    /// Indicates how well the entire input matches the returned. It is equal to 1 if all
    /// input tokens are recognized and matched.
    /// </summary>
    public partial class AddressComponentMatchScores
    {
        private double? _addressNumber;
        private double? _block;
        private double? _building;
        private double? _country;
        private double? _district;
        private List<double> _intersection = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private double? _locality;
        private double? _postalCode;
        private double? _region;
        private List<SecondaryAddressComponentMatchScore> _secondaryAddressComponents = AWSConfigs.InitializeCollections ? new List<SecondaryAddressComponentMatchScore>() : null;
        private double? _subBlock;
        private double? _subDistrict;
        private double? _subRegion;

        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The house number or address results should have. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? AddressNumber
        {
            get { return this._addressNumber; }
            set { this._addressNumber = value; }
        }

        // Check to see if AddressNumber property is set
        internal bool IsSetAddressNumber()
        {
            return this._addressNumber.HasValue; 
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
        [AWSProperty(Min=0, Max=1)]
        public double? Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Building. 
        /// <para>
        /// The name of the building at the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Building
        {
            get { return this._building; }
            set { this._building = value; }
        }

        // Check to see if Building property is set
        internal bool IsSetBuilding()
        {
            return this._building.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country that the results will be present
        /// in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property District. 
        /// <para>
        /// The district or division of a city the results should be present in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? District
        {
            get { return this._district; }
            set { this._district = value; }
        }

        // Check to see if District property is set
        internal bool IsSetDistrict()
        {
            return this._district.HasValue; 
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
        [AWSProperty(Min=1, Max=2)]
        public List<double> Intersection
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
        /// Gets and sets the property Locality. 
        /// <para>
        /// The city or locality results should be present in. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Vancouver</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? Locality
        {
            get { return this._locality; }
            set { this._locality = value; }
        }

        // Check to see if Locality property is set
        internal bool IsSetLocality()
        {
            return this._locality.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code, for which the result should possess. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode.HasValue; 
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
        [AWSProperty(Min=0, Max=1)]
        public double? Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryAddressComponents. 
        /// <para>
        /// Match scores for the secondary address components in the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryAddressComponentMatchScore> SecondaryAddressComponents
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
        /// Gets and sets the property SubBlock. 
        /// <para>
        /// Name of sub-block. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Sunny Mansion 203 sub-block: 4</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? SubBlock
        {
            get { return this._subBlock; }
            set { this._subBlock = value; }
        }

        // Check to see if SubBlock property is set
        internal bool IsSetSubBlock()
        {
            return this._subBlock.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubDistrict. 
        /// <para>
        /// A subdivision of a district. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Minden-Lübbecke</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? SubDistrict
        {
            get { return this._subDistrict; }
            set { this._subDistrict = value; }
        }

        // Check to see if SubDistrict property is set
        internal bool IsSetSubDistrict()
        {
            return this._subDistrict.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The sub-region or county for which results should be present in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? SubRegion
        {
            get { return this._subRegion; }
            set { this._subRegion = value; }
        }

        // Check to see if SubRegion property is set
        internal bool IsSetSubRegion()
        {
            return this._subRegion.HasValue; 
        }

    }
}