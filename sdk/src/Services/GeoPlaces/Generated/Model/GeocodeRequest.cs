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
    /// Container for the parameters to the Geocode operation.
    /// <c>Geocode</c> converts a textual address or place into geographic coordinates. You
    /// can obtain geographic coordinates, address component, and other related information.
    /// It supports flexible queries, including free-form text or structured queries with
    /// components like street names, postal codes, and regions. The Geocode API can also
    /// provide additional features such as time zone information and the inclusion of political
    /// views. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for
    /// <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
    /// customers.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/geocode.html">Geocode</a>
    /// in the <i>Amazon Location Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GeocodeRequest : AmazonGeoPlacesRequest
    {
        private List<string> _additionalFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GeocodeAddressNamesMode _addressNamesMode;
        private List<string> _addressTranslations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<double> _biasPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private GeocodeFilter _filter;
        private GeocodeIntendedUse _intendedUse;
        private string _key;
        private string _language;
        private int? _maxResults;
        private string _politicalView;
        private PostalCodeMode _postalCodeMode;
        private GeocodeQueryComponents _queryComponents;
        private string _queryText;

        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        /// A list of optional additional parameters, such as time zone, that can be requested
        /// for each result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AdditionalFeatures
        {
            get { return this._additionalFeatures; }
            set { this._additionalFeatures = value; }
        }

        // Check to see if AdditionalFeatures property is set
        internal bool IsSetAdditionalFeatures()
        {
            return this._additionalFeatures != null && (this._additionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AddressNamesMode. 
        /// <para>
        /// Specifies how address names are returned. If not set, the service returns normalized
        /// (official) names by default. When set to <c>Matched</c>, address names in the response
        /// are based on the input query rather than official names. When set to <c>Administrative</c>,
        /// the service returns the official administrative names for address components. <c>Administrative</c>
        /// currently applies only to addresses in the United States.
        /// </para>
        /// </summary>
        public GeocodeAddressNamesMode AddressNamesMode
        {
            get { return this._addressNamesMode; }
            set { this._addressNamesMode = value; }
        }

        // Check to see if AddressNamesMode property is set
        internal bool IsSetAddressNamesMode()
        {
            return this._addressNamesMode != null;
        }

        /// <summary>
        /// Gets and sets the property AddressTranslations. 
        /// <para>
        /// Specifies which address components to include translations for. Translations include
        /// all name variants and alternative names for the requested fields in all available
        /// languages. Valid values are <c>District</c>, <c>Locality</c>, <c>Region</c>, and <c>SubRegion</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AddressTranslations
        {
            get { return this._addressTranslations; }
            set { this._addressTranslations = value; }
        }

        // Check to see if AddressTranslations property is set
        internal bool IsSetAddressTranslations()
        {
            return this._addressTranslations != null && (this._addressTranslations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// The position, in longitude and latitude, that the results should be close to. Typically,
        /// place results returned are ranked higher the closer they are to this position. Stored
        /// in <c>[lng, lat]</c> and in the WGS 84 format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=2)]
        public List<double> BiasPosition
        {
            get { return this._biasPosition; }
            set { this._biasPosition = value; }
        }

        // Check to see if BiasPosition property is set
        internal bool IsSetBiasPosition()
        {
            return this._biasPosition != null && (this._biasPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A structure which contains a set of inclusion/exclusion properties that results must
        /// possess in order to be returned as a result.
        /// </para>
        /// </summary>
        public GeocodeFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property IntendedUse. 
        /// <para>
        ///  Indicates if the query results will be persisted in customer infrastructure. Defaults
        /// to <c>SingleUse</c> (not stored). Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When storing <c>Geocode</c> responses, you <i>must</i> set this field to <c>Storage</c>
        /// to comply with the terms of service. These requests will be charged at a higher rate.
        /// Please review the <a href="https://aws.amazon.com/location/sla/">user agreement</a>
        /// and <a href="https://aws.amazon.com/location/pricing/">service pricing structure</a>
        /// to determine the correct setting for your use case.
        /// </para>
        ///  </note>
        /// </summary>
        public GeocodeIntendedUse IntendedUse
        {
            get { return this._intendedUse; }
            set { this._intendedUse = value; }
        }

        // Check to see if IntendedUse property is set
        internal bool IsSetIntendedUse()
        {
            return this._intendedUse != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// A list of <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language codes for the results to be rendered in. If there is no
        /// data for the result in the requested language, data will be returned in the default
        /// language for the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=35)]
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional limit for the number of results returned in a single call.
        /// </para>
        ///  
        /// <para>
        /// Default value: 20
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=3)]
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
        /// Gets and sets the property PostalCodeMode. 
        /// <para>
        /// The <c>PostalCodeMode</c> affects how postal code results are returned. If a postal
        /// code spans multiple localities and this value is empty, partial district or locality
        /// information may be returned under a single postal code result entry. If it's populated
        /// with the value <c>EnumerateSpannedLocalities</c>, all cities in that postal code are
        /// returned. If it's populated with the value <c>EnumerateSpannedDistricts</c>, all combinations
        /// of the postal code with the corresponding district and city names are returned.
        /// </para>
        /// </summary>
        public PostalCodeMode PostalCodeMode
        {
            get { return this._postalCodeMode; }
            set { this._postalCodeMode = value; }
        }

        // Check to see if PostalCodeMode property is set
        internal bool IsSetPostalCodeMode()
        {
            return this._postalCodeMode != null;
        }

        /// <summary>
        /// Gets and sets the property QueryComponents.
        /// </summary>
        public GeocodeQueryComponents QueryComponents
        {
            get { return this._queryComponents; }
            set { this._queryComponents = value; }
        }

        // Check to see if QueryComponents property is set
        internal bool IsSetQueryComponents()
        {
            return this._queryComponents != null;
        }

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The free-form text query to match addresses against. This is usually a partially typed
        /// address from an end user in an address box or form.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string QueryText
        {
            get { return this._queryText; }
            set { this._queryText = value; }
        }

        // Check to see if QueryText property is set
        internal bool IsSetQueryText()
        {
            return this._queryText != null;
        }

    }
}