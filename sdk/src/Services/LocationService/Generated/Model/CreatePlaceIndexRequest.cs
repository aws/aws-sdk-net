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
    /// Container for the parameters to the CreatePlaceIndex operation.
    /// Creates a place index resource in your Amazon Web Services account. Use a place index
    /// resource to geocode addresses and other text queries by using the <code>SearchPlaceIndexForText</code>
    /// operation, and reverse geocode coordinates by using the <code>SearchPlaceIndexForPosition</code>
    /// operation, and enable autosuggestions by using the <code>SearchPlaceIndexForSuggestions</code>
    /// operation.
    /// 
    ///  <note> 
    /// <para>
    /// If your application is tracking or routing assets you use in your business, such as
    /// delivery vehicles or employees, you must not use Esri as your geolocation provider.
    /// See section 82 of the <a href="http://aws.amazon.com/service-terms">Amazon Web Services
    /// service terms</a> for more details.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePlaceIndexRequest : AmazonLocationServiceRequest
    {
        private string _dataSource;
        private DataSourceConfiguration _dataSourceConfiguration;
        private string _description;
        private string _indexName;
        private PricingPlan _pricingPlan;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// Specifies the geospatial data provider for the new place index.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is case-sensitive. Enter the valid values as shown. For example, entering
        /// <code>HERE</code> returns an error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Esri</code> – For additional information about <a href="https://docs.aws.amazon.com/location/latest/developerguide/esri.html">Esri</a>'s
        /// coverage in your region of interest, see <a href="https://developers.arcgis.com/rest/geocode/api-reference/geocode-coverage.htm">Esri
        /// details on geocoding coverage</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Grab</code> – Grab provides place index functionality for Southeast Asia. For
        /// additional information about <a href="https://docs.aws.amazon.com/location/latest/developerguide/grab.html">GrabMaps</a>'
        /// coverage, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/grab.html#grab-coverage-area">GrabMaps
        /// countries and areas covered</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Here</code> – For additional information about <a href="https://docs.aws.amazon.com/location/latest/developerguide/HERE.html">HERE
        /// Technologies</a>' coverage in your region of interest, see <a href="https://developer.here.com/documentation/geocoder/dev_guide/topics/coverage-geocoder.html">HERE
        /// details on goecoding coverage</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify HERE Technologies (<code>Here</code>) as the data provider, you may
        /// not <a href="https://docs.aws.amazon.com/location-places/latest/APIReference/API_DataSourceConfiguration.html">store
        /// results</a> for locations in Japan. For more information, see the <a href="http://aws.amazon.com/service-terms/">Amazon
        /// Web Services Service Terms</a> for Amazon Location Service.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// For additional information , see <a href="https://docs.aws.amazon.com/location/latest/developerguide/what-is-data-provider.html">Data
        /// providers</a> on the <i>Amazon Location Service Developer Guide</i>.
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
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Specifies the data storage option requesting Places.
        /// </para>
        /// </summary>
        public DataSourceConfiguration DataSourceConfiguration
        {
            get { return this._dataSourceConfiguration; }
            set { this._dataSourceConfiguration = value; }
        }

        // Check to see if DataSourceConfiguration property is set
        internal bool IsSetDataSourceConfiguration()
        {
            return this._dataSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for the place index resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the place index resource. 
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only alphanumeric characters (A–Z, a–z, 0–9), hyphens (-), periods (.), and
        /// underscores (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be a unique place index resource name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>ExamplePlaceIndex</code>.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// No longer used. If included, the only allowed value is <code>RequestBasedUsage</code>.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. If included, the only allowed value is RequestBasedUsage.")]
        public PricingPlan PricingPlan
        {
            get { return this._pricingPlan; }
            set { this._pricingPlan = value; }
        }

        // Check to see if PricingPlan property is set
        internal bool IsSetPricingPlan()
        {
            return this._pricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Applies one or more tags to the place index resource. A tag is a key-value pair that
        /// helps you manage, identify, search, and filter your resources.
        /// </para>
        ///  
        /// <para>
        /// Format: <code>"key" : "value"</code> 
        /// </para>
        ///  
        /// <para>
        /// Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum 50 tags per resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each tag key must be unique and must have exactly one associated value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can use alphanumeric characters (A–Z, a–z, 0–9), and the following characters: + -
        /// = . _ : / @
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot use "aws:" as a prefix for a key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}