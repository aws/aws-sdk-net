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
    /// Describes how the parts of the response element matched the input query by returning
    /// the sections of the response which matched to input query terms.
    /// </summary>
    public partial class AutocompleteAddressHighlights
    {
        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The house number or address results should have. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Highlight> AddressNumber { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

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
        public List<Highlight> Block { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

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
        public List<Highlight> Building { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

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
        /// </summary>
        public CountryHighlights Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

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
        public List<Highlight> District { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

        /// <summary>
        /// Checks to see if the District property is set.
        /// </summary>
        internal bool IsSetDistrict() => this.District != null && (this.District.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Intersection. 
        /// <para>
        /// Name of the streets in the intersection. For example: e.g. ["Friedrichstraße","Unter
        /// den Linden"]
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<List<Highlight>> Intersection { get; set; } = AWSConfigs.InitializeCollections ? new List<List<Highlight>>() : null;

        /// <summary>
        /// Checks to see if the Intersection property is set.
        /// </summary>
        internal bool IsSetIntersection() => this.Intersection != null && (this.Intersection.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Indicates the starting and ending indexes for result items where they are identified
        /// to match the input query. This should be used to provide emphasis to output display
        /// to make selecting the correct result from a list easier for end users.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Highlight> Label { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null && (this.Label.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Highlight> Locality { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

        /// <summary>
        /// Checks to see if the Locality property is set.
        /// </summary>
        internal bool IsSetLocality() => this.Locality != null && (this.Locality.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code for which the result should possess. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Highlight> PostalCode { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null && (this.PostalCode.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public RegionHighlights Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

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
        public List<Highlight> Street { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

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
        public List<Highlight> SubBlock { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

        /// <summary>
        /// Checks to see if the SubBlock property is set.
        /// </summary>
        internal bool IsSetSubBlock() => this.SubBlock != null && (this.SubBlock.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubDistrict. 
        /// <para>
        /// Indicates the starting and ending index of the title in the text query that match
        /// the found title. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Highlight> SubDistrict { get; set; } = AWSConfigs.InitializeCollections ? new List<Highlight>() : null;

        /// <summary>
        /// Checks to see if the SubDistrict property is set.
        /// </summary>
        internal bool IsSetSubDistrict() => this.SubDistrict != null && (this.SubDistrict.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The sub-region or county for which results should be present in. 
        /// </para>
        /// </summary>
        public SubRegionHighlights SubRegion { get; set; }

        /// <summary>
        /// Checks to see if the SubRegion property is set.
        /// </summary>
        internal bool IsSetSubRegion() => this.SubRegion != null;
    }
}
