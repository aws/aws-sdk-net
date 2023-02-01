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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the SearchPlaceIndexForText operation.
    /// Geocodes free-form text, such as an address, name, city, or region to allow you to
    /// search for Places or points of interest. 
    /// 
    ///  
    /// <para>
    /// Optional parameters let you narrow your search results by bounding box or country,
    /// or bias your search toward a specific position on the globe.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can search for places near a given position using <code>BiasPosition</code>, or
    /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
    /// parameters simultaneously returns an error.
    /// </para>
    ///  </note> 
    /// <para>
    /// Search results are returned in order of highest to lowest relevance.
    /// </para>
    /// </summary>
    public partial class SearchPlaceIndexForTextRequest : AmazonLocationServiceRequest
    {
        private List<double> _biasPosition = new List<double>();
        private List<double> _filterBBox = new List<double>();
        private List<string> _filterCountries = new List<string>();
        private string _indexName;
        private string _language;
        private int? _maxResults;
        private string _text;

        /// <summary>
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// An optional parameter that indicates a preference for places that are closer to a
        /// specified position.
        /// </para>
        ///  
        /// <para>
        ///  If provided, this parameter must contain a pair of numbers. The first number represents
        /// the X coordinate, or longitude; the second number represents the Y coordinate, or
        /// latitude.
        /// </para>
        ///  
        /// <para>
        /// For example, <code>[-123.1174, 49.2847]</code> represents the position with longitude
        /// <code>-123.1174</code> and latitude <code>49.2847</code>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>BiasPosition</code> and <code>FilterBBox</code> are mutually exclusive. Specifying
        /// both options results in an error. 
        /// </para>
        ///  </note>
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
            return this._biasPosition != null && this._biasPosition.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterBBox. 
        /// <para>
        /// An optional parameter that limits the search results by returning only places that
        /// are within the provided bounding box.
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
        /// For example, <code>[-12.7935, -37.4835, -12.0684, -36.9542]</code> represents a bounding
        /// box where the southwest corner has longitude <code>-12.7935</code> and latitude <code>-37.4835</code>,
        /// and the northeast corner has longitude <code>-12.0684</code> and latitude <code>-36.9542</code>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>FilterBBox</code> and <code>BiasPosition</code> are mutually exclusive. Specifying
        /// both options results in an error. 
        /// </para>
        ///  </note>
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
            return this._filterBBox != null && this._filterBBox.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterCountries. 
        /// <para>
        /// An optional parameter that limits the search results by returning only places that
        /// are in a specified list of countries.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid values include <a href="https://www.iso.org/iso-3166-country-codes.html">ISO
        /// 3166</a> 3-digit country codes. For example, Australia uses three upper-case characters:
        /// <code>AUS</code>.
        /// </para>
        ///  </li> </ul>
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
            return this._filterCountries != null && this._filterCountries.Count > 0; 
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
        /// Gets and sets the property Language. 
        /// <para>
        /// The preferred language used to return results. The value must be a valid <a href="https://tools.ietf.org/search/bcp47">BCP
        /// 47</a> language tag, for example, <code>en</code> for English.
        /// </para>
        ///  
        /// <para>
        /// This setting affects the languages used in the results, but not the results themselves.
        /// If no language is specified, or not supported for a particular result, the partner
        /// automatically chooses a language for the result.
        /// </para>
        ///  
        /// <para>
        /// For an example, we'll use the Greek language. You search for <code>Athens, Greece</code>,
        /// with the <code>language</code> parameter set to <code>en</code>. The result found
        /// will most likely be returned as <code>Athens</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set the <code>language</code> parameter to <code>el</code>, for Greek, then
        /// the result found will more likely be returned as <code>Αθήνα</code>.
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
        /// The default: <code>50</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The address, name, city, or region to be used in the search in free-form text format.
        /// For example, <code>123 Any Street</code>.
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