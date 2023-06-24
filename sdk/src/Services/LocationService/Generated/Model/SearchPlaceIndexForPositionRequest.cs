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
    /// </summary>
    public partial class SearchPlaceIndexForPositionRequest : AmazonLocationServiceRequest
    {
        private string _indexName;
        private string _language;
        private int? _maxResults;
        private List<double> _position = new List<double>();

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
        /// For an example, we'll use the Greek language. You search for a location around Athens,
        /// Greece, with the <code>language</code> parameter set to <code>en</code>. The <code>city</code>
        /// in the results will most likely be returned as <code>Athens</code>.
        /// </para>
        ///  
        /// <para>
        /// If you set the <code>language</code> parameter to <code>el</code>, for Greek, then
        /// the <code>city</code> in the results will more likely be returned as <code>Αθήνα</code>.
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
        /// Specifies the longitude and latitude of the position to query.
        /// </para>
        ///  
        /// <para>
        ///  This parameter must contain a pair of numbers. The first number represents the X
        /// coordinate, or longitude; the second number represents the Y coordinate, or latitude.
        /// </para>
        ///  
        /// <para>
        /// For example, <code>[-123.1174, 49.2847]</code> represents a position with longitude
        /// <code>-123.1174</code> and latitude <code>49.2847</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
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