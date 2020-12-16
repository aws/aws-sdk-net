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
    /// Container for the parameters to the SearchPlaceIndexForPosition operation.
    /// Reverse geocodes a given coordinate and returns a legible address. Allows you to search
    /// for Places or points of interest near a given position.
    /// 
    ///  <note> 
    /// <para>
    /// By using Places, you agree that AWS may transmit your API queries to your selected
    /// third party provider for processing, which may be outside the AWS region you are currently
    /// using. 
    /// </para>
    ///  
    /// <para>
    /// Because of licensing limitations, you may not use HERE to store results for locations
    /// in Japan. For more information, see the <a href="https://aws.amazon.com/service-terms/">AWS
    /// Service Terms</a> for Amazon Location Service.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchPlaceIndexForPositionRequest : AmazonLocationServiceRequest
    {
        private string _indexName;
        private int? _maxResults;
        private List<double> _position = new List<double>();

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
        /// An optional paramer. The maximum number of results returned per request. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <code>50</code> 
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
        /// Gets and sets the property Position. 
        /// <para>
        /// Specifies a coordinate for the query defined by a longitude, and latitude.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first position is the X coordinate, or longitude.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second position is the Y coordinate, or latitude. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <code>position=xLongitude&amp;position=yLatitude</code> .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && this._position.Count > 0; 
        }

    }
}