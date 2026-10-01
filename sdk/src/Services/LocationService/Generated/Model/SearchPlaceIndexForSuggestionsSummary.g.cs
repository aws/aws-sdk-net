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
    /// A summary of the request sent by using <c>SearchPlaceIndexForSuggestions</c>.
    /// </summary>
    public partial class SearchPlaceIndexForSuggestionsSummary
    {
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
        [AWSProperty(Required = true)]
        public string DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property FilterBBox. 
        /// <para>
        /// Contains the coordinates for the optional bounding box specified in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 4, Max = 4)]
        public List<double> FilterBBox { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the FilterBBox property is set.
        /// </summary>
        internal bool IsSetFilterBBox() => this.FilterBBox != null && (this.FilterBBox.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterCategories. 
        /// <para>
        /// The optional category filter specified in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> FilterCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterCategories property is set.
        /// </summary>
        internal bool IsSetFilterCategories() => this.FilterCategories != null && (this.FilterCategories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterCountries. 
        /// <para>
        /// Contains the optional country filter specified in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> FilterCountries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterCountries property is set.
        /// </summary>
        internal bool IsSetFilterCountries() => this.FilterCountries != null && (this.FilterCountries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The preferred language used to return results. Matches the language in the request.
        /// The value is a valid <a href="https://tools.ietf.org/search/bcp47">BCP 47</a> language
        /// tag, for example, <c>en</c> for English.
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
        /// Contains the optional result count limit specified in the request.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The free-form partial text input specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
