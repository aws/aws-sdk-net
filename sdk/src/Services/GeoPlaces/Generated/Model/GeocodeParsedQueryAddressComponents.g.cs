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
    /// Parsed address components in the provided QueryText.
    /// </summary>
    public partial class GeocodeParsedQueryAddressComponents
    {
        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The number that identifies an address within a street.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> AddressNumber { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the AddressNumber property is set.
        /// </summary>
        internal bool IsSetAddressNumber() => this.AddressNumber != null && (this.AddressNumber.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> Block { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the Block property is set.
        /// </summary>
        internal bool IsSetBlock() => this.Block != null && (this.Block.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Building. 
        /// <para>
        /// The name of the building at the address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> Building { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the Building property is set.
        /// </summary>
        internal bool IsSetBuilding() => this.Building != null && (this.Building.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the country that the results will be present
        /// in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> Country { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null && (this.Country.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property District. 
        /// <para>
        /// The district or division of a city the results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> District { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the District property is set.
        /// </summary>
        internal bool IsSetDistrict() => this.District != null && (this.District.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> Locality { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the Locality property is set.
        /// </summary>
        internal bool IsSetLocality() => this.Locality != null && (this.Locality.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OtherComponents. 
        /// <para>
        /// Additional information extracted from the query that does not correspond to standard
        /// address components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> OtherComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the OtherComponents property is set.
        /// </summary>
        internal bool IsSetOtherComponents() => this.OtherComponents != null && (this.OtherComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code, for which the result should possess. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> PostalCode { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null && (this.PostalCode.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> Region { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null && (this.Region.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondaryAddressComponents. 
        /// <para>
        /// Parsed secondary address components from the provided query text.
        /// </para>
        ///  <note> 
        /// <para>
        /// Coverage for <c>ParsedQuery.Address.SecondaryAddressComponents</c> is available in
        /// the following countries:
        /// </para>
        ///  
        /// <para>
        /// AUS, AUT, BRA, CAN, ESP, FRA, GBR, HKG, IDN, IND, NZL, TUR, TWN, USA
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQuerySecondaryAddressComponent> SecondaryAddressComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQuerySecondaryAddressComponent>() : null;

        /// <summary>
        /// Checks to see if the SecondaryAddressComponents property is set.
        /// </summary>
        internal bool IsSetSecondaryAddressComponents() => this.SecondaryAddressComponents != null && (this.SecondaryAddressComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// The name of the street results should be present in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> Street { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the Street property is set.
        /// </summary>
        internal bool IsSetStreet() => this.Street != null && (this.Street.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> SubBlock { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the SubBlock property is set.
        /// </summary>
        internal bool IsSetSubBlock() => this.SubBlock != null && (this.SubBlock.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> SubDistrict { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the SubDistrict property is set.
        /// </summary>
        internal bool IsSetSubDistrict() => this.SubDistrict != null && (this.SubDistrict.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The sub-region or county for which results should be present in. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ParsedQueryComponent> SubRegion { get; set; } = AWSConfigs.InitializeCollections ? new List<ParsedQueryComponent>() : null;

        /// <summary>
        /// Checks to see if the SubRegion property is set.
        /// </summary>
        internal bool IsSetSubRegion() => this.SubRegion != null && (this.SubRegion.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
