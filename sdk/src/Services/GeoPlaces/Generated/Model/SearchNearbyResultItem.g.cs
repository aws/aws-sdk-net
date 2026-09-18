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
    /// The search results of nearby places.
    /// </summary>
    public partial class SearchNearbyResultItem
    {
        /// <summary>
        /// Gets and sets the property AccessPoints. 
        /// <para>
        /// Position of the access point in World Geodetic System (WGS 84) format: [longitude,
        /// latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<AccessPoint> AccessPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessPoint>() : null;

        /// <summary>
        /// Checks to see if the AccessPoints property is set.
        /// </summary>
        internal bool IsSetAccessPoints() => this.AccessPoints != null && (this.AccessPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AccessRestrictions. 
        /// <para>
        /// Indicates known access restrictions on a vehicle access point. The index correlates
        /// to an access point and indicates if access through this point has some form of restriction.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<AccessRestriction> AccessRestrictions { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessRestriction>() : null;

        /// <summary>
        /// Checks to see if the AccessRestrictions property is set.
        /// </summary>
        internal bool IsSetAccessRestrictions() => this.AccessRestrictions != null && (this.AccessRestrictions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The place's address.
        /// </para>
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property AddressNumberCorrected. 
        /// <para>
        /// Boolean indicating if the address provided has been corrected.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? AddressNumberCorrected { get; set; }

        /// <summary>
        /// Checks to see if the AddressNumberCorrected property is set.
        /// </summary>
        internal bool IsSetAddressNumberCorrected() => this.AddressNumberCorrected.HasValue;

        /// <summary>
        /// Gets and sets the property BusinessChains. 
        /// <para>
        /// The Business Chains associated with the place.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<BusinessChain> BusinessChains { get; set; } = AWSConfigs.InitializeCollections ? new List<BusinessChain>() : null;

        /// <summary>
        /// Checks to see if the BusinessChains property is set.
        /// </summary>
        internal bool IsSetBusinessChains() => this.BusinessChains != null && (this.BusinessChains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// Categories of results that results must belong to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<Category> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<Category>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// List of potential contact methods for the result/place.
        /// </para>
        /// </summary>
        public Contacts Contacts { get; set; }

        /// <summary>
        /// Checks to see if the Contacts property is set.
        /// </summary>
        internal bool IsSetContacts() => this.Contacts != null;

        /// <summary>
        /// Gets and sets the property CrossReferences. 
        /// <para>
        /// The list of supplier references available for this place. Requires the <c>CrossReferences</c>
        /// additional feature to be enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<CrossReference> CrossReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<CrossReference>() : null;

        /// <summary>
        /// Checks to see if the CrossReferences property is set.
        /// </summary>
        internal bool IsSetCrossReferences() => this.CrossReferences != null && (this.CrossReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The distance in meters from the QueryPosition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property FoodTypes. 
        /// <para>
        /// List of food types offered by this result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<FoodType> FoodTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<FoodType>() : null;

        /// <summary>
        /// Checks to see if the FoodTypes property is set.
        /// </summary>
        internal bool IsSetFoodTypes() => this.FoodTypes != null && (this.FoodTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MapView. 
        /// <para>
        /// The bounding box enclosing the geometric shape (area or line) that an individual result
        /// covers.
        /// </para>
        ///  
        /// <para>
        /// The bounding box formed is defined as a set 4 coordinates: <c>[{westward lng}, {southern
        /// lat}, {eastward lng}, {northern lat}]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 4, Max = 4)]
        public List<double> MapView { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the MapView property is set.
        /// </summary>
        internal bool IsSetMapView() => this.MapView != null && (this.MapView.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OpeningHours. 
        /// <para>
        /// List of opening hours objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<OpeningHours> OpeningHours { get; set; } = AWSConfigs.InitializeCollections ? new List<OpeningHours>() : null;

        /// <summary>
        /// Checks to see if the OpeningHours property is set.
        /// </summary>
        internal bool IsSetOpeningHours() => this.OpeningHours != null && (this.OpeningHours.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phonemes. 
        /// <para>
        /// How the various components of the result's address are pronounced in various languages.
        /// </para>
        /// </summary>
        public PhonemeDetails Phonemes { get; set; }

        /// <summary>
        /// Checks to see if the Phonemes property is set.
        /// </summary>
        internal bool IsSetPhonemes() => this.Phonemes != null;

        /// <summary>
        /// Gets and sets the property PlaceAttributes. 
        /// <para>
        /// A list of place attributes for the result, such as whether the business offers drive-through
        /// service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<string> PlaceAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PlaceAttributes property is set.
        /// </summary>
        internal bool IsSetPlaceAttributes() => this.PlaceAttributes != null && (this.PlaceAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The <c>PlaceId</c> of the place you wish to receive the information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 500)]
        public string PlaceId { get; set; }

        /// <summary>
        /// Checks to see if the PlaceId property is set.
        /// </summary>
        internal bool IsSetPlaceId() => this.PlaceId != null;

        /// <summary>
        /// Gets and sets the property PlaceType. 
        /// <para>
        /// A <c>PlaceType</c> is a category that the result place must belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public PlaceType PlaceType { get; set; }

        /// <summary>
        /// Checks to see if the PlaceType property is set.
        /// </summary>
        internal bool IsSetPlaceType() => this.PlaceType != null;

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 3)]
        public string PoliticalView { get; set; }

        /// <summary>
        /// Checks to see if the PoliticalView property is set.
        /// </summary>
        internal bool IsSetPoliticalView() => this.PoliticalView != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position in World Geodetic System (WGS 84) format: [longitude, latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone in which the place is located.
        /// </para>
        /// </summary>
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The item's title.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
