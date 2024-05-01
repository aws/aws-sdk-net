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
    /// Container for the parameters to the GetPlace operation.
    /// Finds a place by its unique ID. A <c>PlaceId</c> is returned by other search operations.
    /// 
    ///  <note> 
    /// <para>
    /// A PlaceId is valid only if all of the following are the same in the original search
    /// request and the call to <c>GetPlace</c>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Customer Amazon Web Services account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Web Services Region
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data provider specified in the place index resource
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class GetPlaceRequest : AmazonLocationServiceRequest
    {
        private string _indexName;
        private string _key;
        private string _language;
        private string _placeId;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the place index resource that you want to use for the search.
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
        /// The optional <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">API
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
        /// This setting affects the languages used in the results, but not the results themselves.
        /// If no language is specified, or not supported for a particular result, the partner
        /// automatically chooses a language for the result.
        /// </para>
        ///  
        /// <para>
        /// For an example, we'll use the Greek language. You search for a location around Athens,
        /// Greece, with the <c>language</c> parameter set to <c>en</c>. The <c>city</c> in the
        /// results will most likely be returned as <c>Athens</c>.
        /// </para>
        ///  
        /// <para>
        /// If you set the <c>language</c> parameter to <c>el</c>, for Greek, then the <c>city</c>
        /// in the results will more likely be returned as <c>Αθήνα</c>.
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
        /// Gets and sets the property PlaceId. 
        /// <para>
        /// The identifier of the place to find.
        /// </para>
        ///  
        /// <para>
        /// While you can use PlaceID in subsequent requests, PlaceID is not intended to be a
        /// permanent identifier and the ID can change between consecutive API calls. Please see
        /// the following PlaceID behaviour for each data provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Esri: Place IDs will change every quarter at a minimum. The typical time period for
        /// these changes would be March, June, September, and December. Place IDs might also
        /// change between the typical quarterly change but that will be much less frequent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HERE: We recommend that you cache data for no longer than a week to keep your data
        /// data fresh. You can assume that less than 1% ID shifts will release over release which
        /// is approximately 1 - 2 times per week.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grab: Place IDs can expire or become invalid in the following situations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data operations: The POI may be removed from Grab POI database by Grab Map Ops based
        /// on the ground-truth, such as being closed in the real world, being detected as a duplicate
        /// POI, or having incorrect information. Grab will synchronize data to the Waypoint environment
        /// on weekly basis.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Interpolated POI: Interpolated POI is a temporary POI generated in real time when
        /// serving a request, and it will be marked as derived in the <c>place.result_type</c>
        /// field in the response. The information of interpolated POIs will be retained for at
        /// least 30 days, which means that within 30 days, you are able to obtain POI details
        /// by Place ID from Place Details API. After 30 days, the interpolated POIs(both Place
        /// ID and details) may expire and inaccessible from the Places Details API.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}