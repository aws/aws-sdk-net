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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the SearchPlaceIndexForPosition operation. <important>
    /// <para> This operation is no longer current and may be deprecated in the future. We
    /// recommend you upgrade to <a href="/location/latest/APIReference/API_geoplaces_ReverseGeocode.html">
    /// <c>ReverseGeocode</c> </a> or <a href="/location/latest/APIReference/API_geoplaces_SearchNearby.html">
    /// <c>SearchNearby</c> </a> unless you require Grab data. </para> <ul> <li> <para> <c>SearchPlaceIndexForPosition</c>
    /// is part of a previous Amazon Location Service Places API (version 1) which has been
    /// superseded by a more intuitive, powerful, and complete API (version 2). </para> </li>
    /// <li> <para> The version 2 <c>ReverseGeocode</c> operation gives better results in
    /// the address reverse-geocoding use case, while the version 2 <c>SearchNearby</c> operation
    /// gives better results when searching for businesses and points of interest near a specific
    /// location. </para> </li> <li> <para> If you are using an Amazon Web Services SDK or
    /// the Amazon Web Services CLI, note that the Places API version 2 is found under <c>geo-places</c>
    /// or <c>geo_places</c>, not under <c>location</c>. </para> </li> <li> <para> Since Grab
    /// is not yet fully supported in Places API version 2, we recommend you continue using
    /// API version 1 when using Grab. </para> </li> </ul> </important> <para> Reverse geocodes
    /// a given coordinate and returns a legible address. Allows you to search for Places
    /// or points of interest near a given position. </para>
    /// </summary>
    public partial class SearchPlaceIndexForPositionRequest : AmazonLocationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the place index resource you want to use for the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The optional <a href="https://docs.aws.amazon.com/location/previous/developerguide/using-apikeys.html">API
        /// key</a> to authorize the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1000)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

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
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter. The maximum number of results returned per request.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>50</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

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
        /// For example, <c>[-123.1174, 49.2847]</c> represents a position with longitude <c>-123.1174</c>
        /// and latitude <c>49.2847</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
