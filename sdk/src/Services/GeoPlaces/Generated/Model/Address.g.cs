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
    /// The place address.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Gets and sets the property AddressNumber. 
        /// <para>
        /// The number that identifies an address within a street.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 10)]
        public string AddressNumber { get; set; }

        /// <summary>
        /// Checks to see if the AddressNumber property is set.
        /// </summary>
        internal bool IsSetAddressNumber() => this.AddressNumber != null;

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        ///  Name of the block. Not available in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Sunny Mansion 203 block: 2 Chome</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string Block { get; set; }

        /// <summary>
        /// Checks to see if the Block property is set.
        /// </summary>
        internal bool IsSetBlock() => this.Block != null;

        /// <summary>
        /// Gets and sets the property Building. 
        /// <para>
        ///  The name of the building at the address. Not available in <c>ap-southeast-1</c> and
        /// <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string Building { get; set; }

        /// <summary>
        /// Checks to see if the Building property is set.
        /// </summary>
        internal bool IsSetBuilding() => this.Building != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country component of the address.
        /// </para>
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property District. 
        /// <para>
        /// The district or division of a locality associated with this address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string District { get; set; }

        /// <summary>
        /// Checks to see if the District property is set.
        /// </summary>
        internal bool IsSetDistrict() => this.District != null;

        /// <summary>
        /// Gets and sets the property Intersection. 
        /// <para>
        ///  Name of the streets in the intersection. Not available in <c>ap-southeast-1</c> and
        /// <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
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
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> Intersection { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Intersection property is set.
        /// </summary>
        internal bool IsSetIntersection() => this.Intersection != null && (this.Intersection.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Assembled address value built out of the address components, according to the regional
        /// postal rules. This is the correctly formatted address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string Locality { get; set; }

        /// <summary>
        /// Checks to see if the Locality property is set.
        /// </summary>
        internal bool IsSetLocality() => this.Locality != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// An alphanumeric string included in a postal address to facilitate mail sorting, such
        /// as post code, postcode, or ZIP code, for which the result should possess. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

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
        public Region Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SecondaryAddressComponents. 
        /// <para>
        ///  Components that correspond to secondary identifiers on an Address. Secondary address
        /// components include information such as Suite or Unit Number, Building, or Floor. Not
        /// available in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Coverage for <c>Address.SecondaryAddressComponents</c> is available in the following
        /// countries:
        /// </para>
        ///  
        /// <para>
        /// AUS, CAN, NZL, USA, PRI
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<SecondaryAddressComponent> SecondaryAddressComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<SecondaryAddressComponent>() : null;

        /// <summary>
        /// Checks to see if the SecondaryAddressComponents property is set.
        /// </summary>
        internal bool IsSetSecondaryAddressComponents() => this.SecondaryAddressComponents != null && (this.SecondaryAddressComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// The name of the street results should be present in.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string Street { get; set; }

        /// <summary>
        /// Checks to see if the Street property is set.
        /// </summary>
        internal bool IsSetStreet() => this.Street != null;

        /// <summary>
        /// Gets and sets the property StreetComponents. 
        /// <para>
        ///  Components of the street. Not available in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  
        /// <para>
        /// Example: Yonge from "Yonge street".
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<StreetComponents> StreetComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<StreetComponents>() : null;

        /// <summary>
        /// Checks to see if the StreetComponents property is set.
        /// </summary>
        internal bool IsSetStreetComponents() => this.StreetComponents != null && (this.StreetComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubBlock. 
        /// <para>
        ///  Name of sub-block. Not available in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Sunny Mansion 203 sub-block: 4</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string SubBlock { get; set; }

        /// <summary>
        /// Checks to see if the SubBlock property is set.
        /// </summary>
        internal bool IsSetSubBlock() => this.SubBlock != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string SubDistrict { get; set; }

        /// <summary>
        /// Checks to see if the SubDistrict property is set.
        /// </summary>
        internal bool IsSetSubDistrict() => this.SubDistrict != null;

        /// <summary>
        /// Gets and sets the property SubRegion. 
        /// <para>
        /// The sub-region or county for which results should be present in. 
        /// </para>
        /// </summary>
        public SubRegion SubRegion { get; set; }

        /// <summary>
        /// Checks to see if the SubRegion property is set.
        /// </summary>
        internal bool IsSetSubRegion() => this.SubRegion != null;
    }
}
