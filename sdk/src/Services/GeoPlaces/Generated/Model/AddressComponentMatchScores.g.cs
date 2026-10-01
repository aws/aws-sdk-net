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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The house number or address results should have. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? AddressNumber { get; set; }

        /// <summary>
        /// Checks to see if the AddressNumber property is set.
        /// </summary>
        internal bool IsSetAddressNumber() => this.AddressNumber.HasValue;

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
        [AWSProperty(Min = 0, Max = 1)]
        public double? Block { get; set; }

        /// <summary>
        /// Checks to see if the Block property is set.
        /// </summary>
        internal bool IsSetBlock() => this.Block.HasValue;

        /// <summary>
        /// Gets and sets the property Building. 
        /// <para>
        /// The name of the building at the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? Building { get; set; }

        /// <summary>
        /// Checks to see if the Building property is set.
        /// </summary>
        internal bool IsSetBuilding() => this.Building.HasValue;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country that the results will be present
        /// in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country.HasValue;

        /// <summary>
        /// Gets and sets the property District. 
        /// <para>
        /// The district or division of a city the results should be present in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? District { get; set; }

        /// <summary>
        /// Checks to see if the District property is set.
        /// </summary>
        internal bool IsSetDistrict() => this.District.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<double> Intersection { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Intersection property is set.
        /// </summary>
        internal bool IsSetIntersection() => this.Intersection != null && (this.Intersection.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 0, Max = 1)]
        public double? Locality { get; set; }

        /// <summary>
        /// Checks to see if the Locality property is set.
        /// </summary>
        internal bool IsSetLocality() => this.Locality.HasValue;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code, for which the result should possess. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode.HasValue;

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
        [AWSProperty(Min = 0, Max = 1)]
        public double? Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region.HasValue;

        /// <summary>
        /// Gets and sets the property SecondaryAddressComponents. 
        /// <para>
        /// Match scores for the secondary address components in the result.
        /// </para>
        ///  <note> 
        /// <para>
        /// Coverage for this functionality is available in the following countries: AUS, AUT,
        /// BRA, CAN, ESP, FRA, GBR, IDN, IND, NZL, TUR, TWN, USA.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecondaryAddressComponentMatchScore> SecondaryAddressComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<SecondaryAddressComponentMatchScore>() : null;

        /// <summary>
        /// Checks to see if the SecondaryAddressComponents property is set.
        /// </summary>
        internal bool IsSetSecondaryAddressComponents() => this.SecondaryAddressComponents != null && (this.SecondaryAddressComponents.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 0, Max = 1)]
        public double? SubBlock { get; set; }

        /// <summary>
        /// Checks to see if the SubBlock property is set.
        /// </summary>
        internal bool IsSetSubBlock() => this.SubBlock.HasValue;

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
        [AWSProperty(Min = 0, Max = 1)]
        public double? SubDistrict { get; set; }

        /// <summary>
        /// Checks to see if the SubDistrict property is set.
        /// </summary>
        internal bool IsSetSubDistrict() => this.SubDistrict.HasValue;

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The sub-region or county for which results should be present in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? SubRegion { get; set; }

        /// <summary>
        /// Checks to see if the SubRegion property is set.
        /// </summary>
        internal bool IsSetSubRegion() => this.SubRegion.HasValue;
    }
}
