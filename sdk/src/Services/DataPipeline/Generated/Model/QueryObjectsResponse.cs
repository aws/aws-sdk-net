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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output of QueryObjects.
    /// </summary>
    public partial class QueryObjectsResponse : AmazonWebServiceResponse
    {
        private bool? _hasMoreResults;
        private List<string> _ids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property HasMoreResults. 
        /// <para>
        /// Indicates whether there are more results that can be obtained by a subsequent call.
        /// </para>
        /// </summary>
        public bool? HasMoreResults
        {
            get { return this._hasMoreResults; }
            set { this._hasMoreResults = value; }
        }

        // Check to see if HasMoreResults property is set
        internal bool IsSetHasMoreResults()
        {
            return this._hasMoreResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// The identifiers that match the query selectors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && (this._ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The starting point for the next page of results. To view the next page of results,
        /// call <c>QueryObjects</c> again with this marker value. If the value is null, there
        /// are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}