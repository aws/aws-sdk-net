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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the FilterLogEvents operation.
    /// </summary>
    public partial class FilterLogEventsResponse : AmazonWebServiceResponse
    {
        private List<FilteredLogEvent> _events = AWSConfigs.InitializeCollections ? new List<FilteredLogEvent>() : null;
        private string _nextToken;
        private List<SearchedLogStream> _searchedLogStreams = AWSConfigs.InitializeCollections ? new List<SearchedLogStream>() : null;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The matched events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FilteredLogEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items. The token expires after 24
        /// hours.
        /// </para>
        ///  
        /// <para>
        /// If the results don't include a <c>nextToken</c>, then pagination is finished. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SearchedLogStreams. 
        /// <para>
        ///  <b>Important</b> As of May 15, 2020, this parameter is no longer supported. This
        /// parameter returns an empty list.
        /// </para>
        ///  
        /// <para>
        /// Indicates which log streams have been searched and whether each has been searched
        /// completely.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SearchedLogStream> SearchedLogStreams
        {
            get { return this._searchedLogStreams; }
            set { this._searchedLogStreams = value; }
        }

        // Check to see if SearchedLogStreams property is set
        internal bool IsSetSearchedLogStreams()
        {
            return this._searchedLogStreams != null && (this._searchedLogStreams.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}