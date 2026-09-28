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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains details about addresses or points of interest that match the search criteria.
    /// 
    ///  
    /// <para>
    /// Not all details are included with all responses. Some details may only be returned
    /// by specific data partners.
    /// </para>
    /// </summary>
    public partial class Place
    {
        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The numerical portion of an address, such as a building number. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AddressNumber { get; set; }

        /// <summary>
        /// Checks to see if the AddressNumber property is set.
        /// </summary>
        internal bool IsSetAddressNumber() => this.AddressNumber != null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The Amazon Location categories that describe this Place.
        /// </para>
        ///  
        /// <para>
        /// For more information about using categories, including a list of Amazon Location categories,
        /// see <a href="https://docs.aws.amazon.com/location/previous/developerguide/category-filtering.html">Categories
        /// and filtering</a>, in the <i>Amazon Location Service developer guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// A country/region specified using <a href="https://www.iso.org/iso-3166-country-codes.html">ISO
        /// 3166</a> 3-digit country/region code. For example, <c>CAN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property Geometry.
        /// </summary>
        [AWSProperty(Required = true)]
        public PlaceGeometry Geometry { get; set; }

        /// <summary>
        /// Checks to see if the Geometry property is set.
        /// </summary>
        internal bool IsSetGeometry() => this.Geometry != null;

        /// <summary>
        /// Gets and sets the property Interpolated. 
        /// <para>
        ///  <c>True</c> if the result is interpolated from other known places.
        /// </para>
        ///  
        /// <para>
        ///  <c>False</c> if the Place is a known place.
        /// </para>
        ///  
        /// <para>
        /// Not returned when the partner does not provide the information.
        /// </para>
        ///  
        /// <para>
        /// For example, returns <c>False</c> for an address location that is found in the partner
        /// data, but returns <c>True</c> if an address does not exist in the partner data and
        /// its location is calculated by interpolating between other known addresses. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Interpolated { get; set; }

        /// <summary>
        /// Checks to see if the Interpolated property is set.
        /// </summary>
        internal bool IsSetInterpolated() => this.Interpolated.HasValue;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The full name and address of the point of interest such as a city, region, or country.
        /// For example, <c>123 Any Street, Any Town, USA</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Municipality. 
        /// <para>
        /// A name for a local area, such as a city or town name. For example, <c>Toronto</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Municipality { get; set; }

        /// <summary>
        /// Checks to see if the Municipality property is set.
        /// </summary>
        internal bool IsSetMunicipality() => this.Municipality != null;

        /// <summary>
        /// Gets and sets the property Neighborhood. 
        /// <para>
        /// The name of a community district. For example, <c>Downtown</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Checks to see if the Neighborhood property is set.
        /// </summary>
        internal bool IsSetNeighborhood() => this.Neighborhood != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// A group of numbers and letters in a country-specific format, which accompanies the
        /// address for the purpose of identifying a location. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// A name for an area or geographical division, such as a province or state name. For
        /// example, <c>British Columbia</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// The name for a street or a road to identify a location. For example, <c>Main Street</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Street { get; set; }

        /// <summary>
        /// Checks to see if the Street property is set.
        /// </summary>
        internal bool IsSetStreet() => this.Street != null;

        /// <summary>
        /// Gets and sets the property SubMunicipality. 
        /// <para>
        /// An area that's part of a larger municipality. For example, <c>Blissville </c> is a
        /// submunicipality in the Queen County in New York.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property supported by Esri and OpenData. The Esri property is <c>district</c>,
        /// and the OpenData property is <c>borough</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SubMunicipality { get; set; }

        /// <summary>
        /// Checks to see if the SubMunicipality property is set.
        /// </summary>
        internal bool IsSetSubMunicipality() => this.SubMunicipality != null;

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// A county, or an area that's part of a larger region. For example, <c>Metro Vancouver</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SubRegion { get; set; }

        /// <summary>
        /// Checks to see if the SubRegion property is set.
        /// </summary>
        internal bool IsSetSubRegion() => this.SubRegion != null;

        /// <summary>
        /// Gets and sets the property SupplementalCategories. 
        /// <para>
        /// Categories from the data provider that describe the Place that are not mapped to any
        /// Amazon Location categories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> SupplementalCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupplementalCategories property is set.
        /// </summary>
        internal bool IsSetSupplementalCategories() => this.SupplementalCategories != null && (this.SupplementalCategories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone in which the <c>Place</c> is located. Returned only when using HERE
        /// or Grab as the selected partner.
        /// </para>
        /// </summary>
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property UnitNumber. 
        /// <para>
        /// For addresses with multiple units, the unit identifier. Can include numbers and letters,
        /// for example <c>3B</c> or <c>Unit 123</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Returned only for a place index that uses Esri or Grab as a data provider. Is not
        /// returned for <c>SearchPlaceIndexForPosition</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string UnitNumber { get; set; }

        /// <summary>
        /// Checks to see if the UnitNumber property is set.
        /// </summary>
        internal bool IsSetUnitNumber() => this.UnitNumber != null;

        /// <summary>
        /// Gets and sets the property UnitType. 
        /// <para>
        /// For addresses with a <c>UnitNumber</c>, the type of unit. For example, <c>Apartment</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Returned only for a place index that uses Esri as a data provider.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string UnitType { get; set; }

        /// <summary>
        /// Checks to see if the UnitType property is set.
        /// </summary>
        internal bool IsSetUnitType() => this.UnitType != null;
    }
}
