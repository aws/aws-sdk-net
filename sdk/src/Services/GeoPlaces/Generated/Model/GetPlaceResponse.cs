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
    /// This is the response object from the GetPlace operation.
    /// </summary>
    public partial class GetPlaceResponse : AmazonWebServiceResponse
    {
        private List<AccessPoint> _accessPoints = AWSConfigs.InitializeCollections ? new List<AccessPoint>() : null;
        private List<AccessRestriction> _accessRestrictions = AWSConfigs.InitializeCollections ? new List<AccessRestriction>() : null;
        private Address _address;
        private bool? _addressNumberCorrected;
        private List<BusinessChain> _businessChains = AWSConfigs.InitializeCollections ? new List<BusinessChain>() : null;
        private List<Category> _categories = AWSConfigs.InitializeCollections ? new List<Category>() : null;
        private Contacts _contacts;
        private List<FoodType> _foodTypes = AWSConfigs.InitializeCollections ? new List<FoodType>() : null;
        private RelatedPlace _mainAddress;
        private List<double> _mapView = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<OpeningHours> _openingHours = AWSConfigs.InitializeCollections ? new List<OpeningHours>() : null;
        private PhonemeDetails _phonemes;
        private string _placeId;
        private PlaceType _placeType;
        private string _politicalView;
        private List<double> _position = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<PostalCodeDetails> _postalCodeDetails = AWSConfigs.InitializeCollections ? new List<PostalCodeDetails>() : null;
        private string _pricingBucket;
        private List<RelatedPlace> _secondaryAddresses = AWSConfigs.InitializeCollections ? new List<RelatedPlace>() : null;
        private TimeZone _timeZone;
        private string _title;

        /// <summary>
        /// Gets and sets the property AccessPoints. 
        /// <para>
        /// Position of the access point in <c>(lng,lat)</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AccessPoint> AccessPoints
        {
            get { return this._accessPoints; }
            set { this._accessPoints = value; }
        }

        // Check to see if AccessPoints property is set
        internal bool IsSetAccessPoints()
        {
            return this._accessPoints != null && (this._accessPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AccessRestrictions. 
        /// <para>
        /// Indicates known access restrictions on a vehicle access point. The index correlates
        /// to an access point and indicates if access through this point has some form of restriction.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<AccessRestriction> AccessRestrictions
        {
            get { return this._accessRestrictions; }
            set { this._accessRestrictions = value; }
        }

        // Check to see if AccessRestrictions property is set
        internal bool IsSetAccessRestrictions()
        {
            return this._accessRestrictions != null && (this._accessRestrictions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The place's address.
        /// </para>
        /// </summary>
        public Address Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property AddressNumberCorrected. 
        /// <para>
        /// Boolean indicating if the address provided has been corrected.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? AddressNumberCorrected
        {
            get { return this._addressNumberCorrected; }
            set { this._addressNumberCorrected = value; }
        }

        // Check to see if AddressNumberCorrected property is set
        internal bool IsSetAddressNumberCorrected()
        {
            return this._addressNumberCorrected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BusinessChains. 
        /// <para>
        /// The Business Chains associated with the place.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<BusinessChain> BusinessChains
        {
            get { return this._businessChains; }
            set { this._businessChains = value; }
        }

        // Check to see if BusinessChains property is set
        internal bool IsSetBusinessChains()
        {
            return this._businessChains != null && (this._businessChains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// Categories of results that results must belong to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<Category> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Contacts. 
        /// <para>
        /// List of potential contact methods for the result/place.
        /// </para>
        /// </summary>
        public Contacts Contacts
        {
            get { return this._contacts; }
            set { this._contacts = value; }
        }

        // Check to see if Contacts property is set
        internal bool IsSetContacts()
        {
            return this._contacts != null;
        }

        /// <summary>
        /// Gets and sets the property FoodTypes. 
        /// <para>
        /// List of food types offered by this result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<FoodType> FoodTypes
        {
            get { return this._foodTypes; }
            set { this._foodTypes = value; }
        }

        // Check to see if FoodTypes property is set
        internal bool IsSetFoodTypes()
        {
            return this._foodTypes != null && (this._foodTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MainAddress. 
        /// <para>
        /// The main address corresponding to a place of type Secondary Address.
        /// </para>
        /// </summary>
        public RelatedPlace MainAddress
        {
            get { return this._mainAddress; }
            set { this._mainAddress = value; }
        }

        // Check to see if MainAddress property is set
        internal bool IsSetMainAddress()
        {
            return this._mainAddress != null;
        }

        /// <summary>
        /// Gets and sets the property MapView. 
        /// <para>
        /// The bounding box enclosing the geometric shape (area or line) that an individual result
        /// covers.
        /// </para>
        ///  
        /// <para>
        /// The bounding box formed is defined as a set of four coordinates: <c>[{westward lng},
        /// {southern lat}, {eastward lng}, {northern lat}]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=4)]
        public List<double> MapView
        {
            get { return this._mapView; }
            set { this._mapView = value; }
        }

        // Check to see if MapView property is set
        internal bool IsSetMapView()
        {
            return this._mapView != null && (this._mapView.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OpeningHours. 
        /// <para>
        /// List of opening hours objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<OpeningHours> OpeningHours
        {
            get { return this._openingHours; }
            set { this._openingHours = value; }
        }

        // Check to see if OpeningHours property is set
        internal bool IsSetOpeningHours()
        {
            return this._openingHours != null && (this._openingHours.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Phonemes. 
        /// <para>
        /// How the various components of the result's address are pronounced in various languages.
        /// </para>
        /// </summary>
        public PhonemeDetails Phonemes
        {
            get { return this._phonemes; }
            set { this._phonemes = value; }
        }

        // Check to see if Phonemes property is set
        internal bool IsSetPhonemes()
        {
            return this._phonemes != null;
        }

        /// <summary>
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The <c>PlaceId</c> of the place you wish to receive the information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=500)]
        public string PlaceId
        {
            get { return this._placeId; }
            set { this._placeId = value; }
        }

        // Check to see if PlaceId property is set
        internal bool IsSetPlaceId()
        {
            return this._placeId != null;
        }

        /// <summary>
        /// Gets and sets the property PlaceType. 
        /// <para>
        /// A <c>PlaceType</c> is a category that the result place must belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public PlaceType PlaceType
        {
            get { return this._placeType; }
            set { this._placeType = value; }
        }

        // Check to see if PlaceType property is set
        internal bool IsSetPlaceType()
        {
            return this._placeType != null;
        }

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=3)]
        public string PoliticalView
        {
            get { return this._politicalView; }
            set { this._politicalView = value; }
        }

        // Check to see if PoliticalView property is set
        internal bool IsSetPoliticalView()
        {
            return this._politicalView != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position, in longitude and latitude.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && (this._position.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PostalCodeDetails. 
        /// <para>
        /// Contains details about the postal code of the place/result. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<PostalCodeDetails> PostalCodeDetails
        {
            get { return this._postalCodeDetails; }
            set { this._postalCodeDetails = value; }
        }

        // Check to see if PostalCodeDetails property is set
        internal bool IsSetPostalCodeDetails()
        {
            return this._postalCodeDetails != null && (this._postalCodeDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PricingBucket. 
        /// <para>
        /// The pricing bucket for which the query is charged at.
        /// </para>
        ///  
        /// <para>
        /// For more information on pricing, please visit <a href="https://aws.amazon.com/location/pricing/">Amazon
        /// Location Service Pricing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PricingBucket
        {
            get { return this._pricingBucket; }
            set { this._pricingBucket = value; }
        }

        // Check to see if PricingBucket property is set
        internal bool IsSetPricingBucket()
        {
            return this._pricingBucket != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryAddresses. 
        /// <para>
        /// All secondary addresses that are associated with a main address. A secondary address
        /// is one that includes secondary designators, such as a Suite or Unit Number, Building,
        /// or Floor information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<RelatedPlace> SecondaryAddresses
        {
            get { return this._secondaryAddresses; }
            set { this._secondaryAddresses = value; }
        }

        // Check to see if SecondaryAddresses property is set
        internal bool IsSetSecondaryAddresses()
        {
            return this._secondaryAddresses != null && (this._secondaryAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone in which the place is located.
        /// </para>
        /// </summary>
        public TimeZone TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The localized display name of this result item based on request parameter <c>language</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}