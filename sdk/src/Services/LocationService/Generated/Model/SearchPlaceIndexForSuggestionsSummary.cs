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
    /// A summary of the request sent by using <c>SearchPlaceIndexForSuggestions</c>.
    /// </summary>
    public partial class SearchPlaceIndexForSuggestionsSummary
    {
        private List<double> _biasPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private string _dataSource;
        private List<double> _filterBBox = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<string> _filterCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _filterCountries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _language;
        private int? _maxResults;
        private string _text;

        /// <summary>
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// Contains the coordinates for the optional bias position specified in the request.
        /// </para>
        ///  
        /// <para>
        /// This parameter contains a pair of numbers. The first number represents the X coordinate,
        /// or longitude; the second number represents the Y coordinate, or latitude.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>[-123.1174, 49.2847]</c> represents the position with longitude <c>-123.1174</c>
        /// and latitude <c>49.2847</c>.
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
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The geospatial data provider attached to the place index resource specified in the
        /// request. Values can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Esri
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grab
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Here
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about data providers, see <a href="https://docs.aws.amazon.com/location/previous/developerguide/what-is-data-provider.html">Amazon
        /// Location Service data providers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property FilterBBox. 
        /// <para>
        /// Contains the coordinates for the optional bounding box specified in the request.
        /// </para>
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
        /// The optional category filter specified in the request.
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
        /// Contains the optional country filter specified in the request.
        /// </para>
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
        /// Gets and sets the property Language. 
        /// <para>
        /// The preferred language used to return results. Matches the language in the request.
        /// The value is a valid <a href="https://tools.ietf.org/search/bcp47">BCP 47</a> language
        /// tag, for example, <c>en</c> for English.
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
        /// Contains the optional result count limit specified in the request.
        /// </para>
        /// </summary>
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
        /// The free-form partial text input specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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