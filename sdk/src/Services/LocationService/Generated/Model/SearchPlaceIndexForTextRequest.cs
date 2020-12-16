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
    /// Includes the option to apply additional parameters to narrow your list of results.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can search for places near a given position using <code>BiasPosition</code>, or
    /// filter results within a bounding box using <code>FilterBBox</code>. Providing both
    /// parameters simultaneously returns an error.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// By using Places, you agree that AWS may transmit your API queries to your selected
    /// third party provider for processing, which may be outside the AWS region you are currently
    /// using. 
    /// </para>
    ///  
    /// <para>
    /// Also, when using HERE as your data provider, you may not (a) use HERE Places for Asset
    /// Management, or (b) select the <code>Storage</code> option for the <code>IntendedUse</code>
    /// parameter when requesting Places in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
    /// Service Terms</a> for Amazon Location Service.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchPlaceIndexForTextRequest : AmazonLocationServiceRequest
    {
        private List<double> _biasPosition = new List<double>();
        private List<double> _filterBBox = new List<double>();
        private List<string> _filterCountries = new List<string>();
        private string _indexName;
        private int? _maxResults;
        private string _text;

        /// <summary>
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// Searches for results closest to the given position. An optional parameter defined
        /// by longitude, and latitude.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first <code>bias</code> position is the X coordinate, or longitude.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second <code>bias</code> position is the Y coordinate, or latitude. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <code>bias=xLongitude&amp;bias=yLatitude</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
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
        /// Filters the results by returning only Places within the provided bounding box. An
        /// optional parameter.
        /// </para>
        ///  
        /// <para>
        /// The first 2 <code>bbox</code> parameters describe the lower southwest corner:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first <code>bbox</code> position is the X coordinate or longitude of the lower
        /// southwest corner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second <code>bbox</code> position is the Y coordinate or latitude of the lower
        /// southwest corner.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <code>bbox=xLongitudeSW&amp;bbox=yLatitudeSW</code>.
        /// </para>
        ///  
        /// <para>
        /// The next <code>bbox</code> parameters describe the upper northeast corner:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The third <code>bbox</code> position is the X coordinate, or longitude of the upper
        /// northeast corner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The fourth <code>bbox</code> position is the Y coordinate, or longitude of the upper
        /// northeast corner.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <code>bbox=xLongitudeNE&amp;bbox=yLatitudeNE</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=6)]
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
        /// Limits the search to the given a list of countries/regions. An optional parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <a href="https://www.iso.org/iso-3166-country-codes.html">ISO 3166</a> 3-digit
        /// country code. For example, Australia uses three upper-case characters: <code>AUS</code>.
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
        /// The name of the Place index resource you want to use for the search.
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
        /// The address, name, city, or region to be used in the search. In free-form text format.
        /// For example, <code>123 Any Street</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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