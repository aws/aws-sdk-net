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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
    /// Container for the parameters to the SearchPlaceIndexForSuggestions operation.
    /// Generates suggestions for addresses and points of interest based on partial or misspelled
    /// free-form text. This operation is also known as autocomplete, autosuggest, or fuzzy
    /// matching.
    /// 
    ///  
    /// <para>
    /// Optional parameters let you narrow your search results by bounding box or country,
    /// or bias your search toward a specific position on the globe.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can search for suggested place names near a specified position by using <c>BiasPosition</c>,
    /// or filter results within a bounding box by using <c>FilterBBox</c>. These parameters
    /// are mutually exclusive; using both <c>BiasPosition</c> and <c>FilterBBox</c> in the
    /// same command returns an error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchPlaceIndexForSuggestionsRequest : AmazonLocationServiceRequest
    {
        private List<double> _biasPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<double> _filterBBox = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<string> _filterCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _filterCountries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _indexName;
        private string _key;
        private string _language;
        private int? _maxResults;
        private string _text;

        /// <summary>
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// An optional parameter that indicates a preference for place suggestions that are closer
        /// to a specified position.
        /// </para>
        ///  
        /// <para>
        ///  If provided, this parameter must contain a pair of numbers. The first number represents
        /// the X coordinate, or longitude; the second number represents the Y coordinate, or
        /// latitude.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>[-123.1174, 49.2847]</c> represents the position with longitude <c>-123.1174</c>
        /// and latitude <c>49.2847</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BiasPosition</c> and <c>FilterBBox</c> are mutually exclusive. Specifying both
        /// options results in an error. 
        /// </para>
        ///  </note>
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
        /// Gets and sets the property FilterBBox. 
        /// <para>
        /// An optional parameter that limits the search results by returning only suggestions
        /// within a specified bounding box.
        /// </para>
        ///  
        /// <para>
        ///  If provided, this parameter must contain a total of four consecutive numbers in two
        /// pairs. The first pair of numbers represents the X and Y coordinates (longitude and
        /// latitude, respectively) of the southwest corner of the bounding box; the second pair
        /// of numbers represents the X and Y coordinates (longitude and latitude, respectively)
        /// of the northeast corner of the bounding box.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>[-12.7935, -37.4835, -12.0684, -36.9542]</c> represents a bounding
        /// box where the southwest corner has longitude <c>-12.7935</c> and latitude <c>-37.4835</c>,
        /// and the northeast corner has longitude <c>-12.0684</c> and latitude <c>-36.9542</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>FilterBBox</c> and <c>BiasPosition</c> are mutually exclusive. Specifying both
        /// options results in an error. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=4)]
        public List<double> FilterBBox
        {
            get { return this._filterBBox; }
            set { this._filterBBox = value; }
        }

        // Check to see if FilterBBox property is set
        internal bool IsSetFilterBBox()
        {
            return this._filterBBox != null && (this._filterBBox.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterCategories. 
        /// <para>
        /// A list of one or more Amazon Location categories to filter the returned places. If
        /// you include more than one category, the results will include results that match <i>any</i>
        /// of the categories listed.
        /// </para>
        ///  
        /// <para>
        /// For more information about using categories, including a list of Amazon Location categories,
        /// see <a href="https://docs.aws.amazon.com/location/previous/developerguide/category-filtering.html">Categories
        /// and filtering</a>, in the <i>Amazon Location Service developer guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> FilterCategories
        {
            get { return this._filterCategories; }
            set { this._filterCategories = value; }
        }

        // Check to see if FilterCategories property is set
        internal bool IsSetFilterCategories()
        {
            return this._filterCategories != null && (this._filterCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterCountries. 
        /// <para>
        /// An optional parameter that limits the search results by returning only suggestions
        /// within the provided list of countries.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <a href="https://www.iso.org/iso-3166-country-codes.html">ISO 3166</a> 3-digit
        /// country code. For example, Australia uses three upper-case characters: <c>AUS</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> FilterCountries
        {
            get { return this._filterCountries; }
            set { this._filterCountries = value; }
        }

        // Check to see if FilterCountries property is set
        internal bool IsSetFilterCountries()
        {
            return this._filterCountries != null && (this._filterCountries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the place index resource you want to use for the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The optional <a href="https://docs.aws.amazon.com/location/previous/developerguide/using-apikeys.html">API
        /// key</a> to authorize the request.
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
        /// The preferred language used to return results. The value must be a valid <a href="https://tools.ietf.org/search/bcp47">BCP
        /// 47</a> language tag, for example, <c>en</c> for English.
        /// </para>
        ///  
        /// <para>
        /// This setting affects the languages used in the results. If no language is specified,
        /// or not supported for a particular result, the partner automatically chooses a language
        /// for the result.
        /// </para>
        ///  
        /// <para>
        /// For an example, we'll use the Greek language. You search for <c>Athens, Gr</c> to
        /// get suggestions with the <c>language</c> parameter set to <c>en</c>. The results found
        /// will most likely be returned as <c>Athens, Greece</c>.
        /// </para>
        ///  
        /// <para>
        /// If you set the <c>language</c> parameter to <c>el</c>, for Greek, then the result
        /// found will more likely be returned as <c>Αθήνα, Ελλάδα</c>.
        /// </para>
        ///  
        /// <para>
        /// If the data provider does not have a value for Greek, the result will be in a language
        /// that the provider does support.
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
        /// An optional parameter. The maximum number of results returned per request. 
        /// </para>
        ///  
        /// <para>
        /// The default: <c>5</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
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
        /// Gets and sets the property Text. 
        /// <para>
        /// The free-form partial text to use to generate place suggestions. For example, <c>eiffel
        /// tow</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}