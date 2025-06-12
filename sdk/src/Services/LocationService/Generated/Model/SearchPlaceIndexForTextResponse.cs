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
    /// This is the response object from the SearchPlaceIndexForText operation.
    /// </summary>
    public partial class SearchPlaceIndexForTextResponse : AmazonWebServiceResponse
    {
        private List<SearchForTextResult> _results = AWSConfigs.InitializeCollections ? new List<SearchForTextResult>() : null;
        private SearchPlaceIndexForTextSummary _summary;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// A list of Places matching the input text. Each result contains additional information
        /// about the specific point of interest. 
        /// </para>
        ///  
        /// <para>
        /// Not all response properties are included with all responses. Some properties may only
        /// be returned by specific data partners.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SearchForTextResult> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && (this._results.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Contains a summary of the request. Echoes the input values for <c>BiasPosition</c>,
        /// <c>FilterBBox</c>, <c>FilterCountries</c>, <c>Language</c>, <c>MaxResults</c>, and
        /// <c>Text</c>. Also includes the <c>DataSource</c> of the place index and the bounding
        /// box, <c>ResultBBox</c>, which surrounds the search results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchPlaceIndexForTextSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}