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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Container for the parameters to the Suggest operation. <c>Suggest</c> provides intelligent
    /// predictions or recommendations based on the user's input or context, such as relevant
    /// places, points of interest, query terms or search category. It is designed to help
    /// users find places or point of interests candidates or identify a follow on query based
    /// on incomplete or misspelled queries. It returns a list of possible matches or refinements
    /// that can be used to formulate a more accurate query. Users can select the most appropriate
    /// suggestion and use it for further searching. The API provides options for filtering
    /// results by location and other attributes, and allows for additional features like
    /// phonemes and timezones. The response includes refined query terms and detailed place
    /// information. <para> For more information, see <a href="https://docs.aws.amazon.com/location/latest/developerguide/suggest.html">Suggest</a>
    /// in the <i>Amazon Location Service Developer Guide</i>. </para>
    /// </summary>
    public partial class SuggestRequest : AmazonGeoPlacesRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalFeatures. 
        /// <para>
        ///  A list of optional additional parameters, such as time zone, that can be requested
        /// for each result. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only the
        /// <c>Core</c> and <c>TimeZone</c> values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> AdditionalFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalFeatures property is set.
        /// </summary>
        internal bool IsSetAdditionalFeatures() => this.AdditionalFeatures != null && (this.AdditionalFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BiasPosition. 
        /// <para>
        /// The position, in longitude and latitude, that the results should be close to. Typically,
        /// place results returned are ranked higher the closer they are to this position. Stored
        /// in <c>[lng, lat]</c> and in the WGS 84 format.
        /// </para>
        ///  <note> 
        /// <para>
        /// The fields <c>BiasPosition</c>, <c>FilterBoundingBox</c>, and <c>FilterCircle</c>
        /// are mutually exclusive.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 2)]
        public List<double> BiasPosition { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the BiasPosition property is set.
        /// </summary>
        internal bool IsSetBiasPosition() => this.BiasPosition != null && (this.BiasPosition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A structure which contains a set of inclusion/exclusion properties that results must
        /// possess in order to be returned as a result.
        /// </para>
        /// </summary>
        public SuggestFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property IntendedUse. 
        /// <para>
        ///  Indicates if the query results will be persisted in customer infrastructure. Defaults
        /// to <c>SingleUse</c> (not stored). Currently, <c>Suggest</c> does not support storage
        /// of results. 
        /// </para>
        /// </summary>
        public SuggestIntendedUse IntendedUse { get; set; }

        /// <summary>
        /// Checks to see if the IntendedUse property is set.
        /// </summary>
        internal bool IsSetIntendedUse() => this.IntendedUse != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Optional: The API key to be used for authorization. Either an API key or valid SigV4
        /// signature must be provided when making a request.
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
        ///  A list of <a href="https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry">BCP
        /// 47</a> compliant language codes for the results to be rendered in. If there is no
        /// data for the result in the requested language, data will be returned in the default
        /// language for the entry. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only the
        /// following codes: <c>en, id, km, lo, ms, my, pt, th, tl, vi, zh</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 35)]
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property MaxQueryRefinements. 
        /// <para>
        ///  Maximum number of query terms to be returned for use with a search text query. Not
        /// supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxQueryRefinements { get; set; }

        /// <summary>
        /// Checks to see if the MaxQueryRefinements property is set.
        /// </summary>
        internal bool IsSetMaxQueryRefinements() => this.MaxQueryRefinements.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  An optional limit for the number of results returned in a single call. 
        /// </para>
        ///  
        /// <para>
        /// Default value: 20
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        ///  The alpha-2 or alpha-3 character code for the political view of a country. The political
        /// view applies to the results of the request to represent unresolved territorial claims
        /// through the point of view of the specified country. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 3)]
        public string PoliticalView { get; set; }

        /// <summary>
        /// Checks to see if the PoliticalView property is set.
        /// </summary>
        internal bool IsSetPoliticalView() => this.PoliticalView != null;

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The free-form text query to match addresses against. This is usually a partially typed
        /// address from an end user in an address box or form.
        /// </para>
        ///  <note> 
        /// <para>
        /// The fields <c>QueryText</c> and <c>QueryID</c> are mutually exclusive.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 200)]
        public string QueryText { get; set; }

        /// <summary>
        /// Checks to see if the QueryText property is set.
        /// </summary>
        internal bool IsSetQueryText() => this.QueryText != null;

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Indicates the mode of mobility used by the end user. This is used to improve the relevance
        /// of search results. Valid values are <c>Car</c>, <c>Scooter</c>, and <c>Truck</c>.
        /// </para>
        /// </summary>
        public SuggestTravelMode TravelMode { get; set; }

        /// <summary>
        /// Checks to see if the TravelMode property is set.
        /// </summary>
        internal bool IsSetTravelMode() => this.TravelMode != null;
    }
}
