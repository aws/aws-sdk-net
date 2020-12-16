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
    /// A summary of the geocoding request sent using <code>SearchPlaceIndexForText</code>.
    /// </summary>
    public partial class SearchPlaceIndexForTextSummary
    {
        private List<double> _biasPosition = new List<double>();
        private string _dataSource;
        private List<double> _filterBBox = new List<double>();
        private List<string> _filterCountries = new List<string>();
        private int? _maxResults;
        private List<double> _resultBBox = new List<double>();
        private string _text;

        /// <summary>
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// Contains the coordinates for the bias position entered in the geocoding request.
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
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data provider of geospatial data for the Place index resource.
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
        /// Contains the coordinates for the optional bounding box coordinated entered in the
        /// geocoding request.
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
        /// Contains the country filter entered in the geocoding request.
        /// </para>
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Contains the maximum number of results indicated for the request.
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
        /// Gets and sets the property ResultBBox. 
        /// <para>
        /// A bounding box that contains the search results within the specified area indicated
        /// by <code>FilterBBox</code>. A subset of bounding box specified using <code>FilterBBox</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=6)]
        public List<double> ResultBBox
        {
            get { return this._resultBBox; }
            set { this._resultBBox = value; }
        }

        // Check to see if ResultBBox property is set
        internal bool IsSetResultBBox()
        {
            return this._resultBBox != null && this._resultBBox.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The address, name, city or region to be used in the geocoding request. In free-form
        /// text format. For example, <code>Vancouver</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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