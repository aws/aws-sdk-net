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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// This is the response object from the ListConfigurationHistory operation.
    /// </summary>
    public partial class ListConfigurationHistoryResponse : AmazonWebServiceResponse
    {
        private List<ConfigurationEvent> _eventList = new List<ConfigurationEvent>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EventList. 
        /// <para>
        ///  The list of configuration events and their corresponding details. 
        /// </para>
        /// </summary>
        public List<ConfigurationEvent> EventList
        {
            get { return this._eventList; }
            set { this._eventList = value; }
        }

        // Check to see if EventList property is set
        internal bool IsSetEventList()
        {
            return this._eventList != null && this._eventList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>NextToken</code> value to include in a future <code>ListConfigurationHistory</code>
        /// request. When the results of a <code>ListConfigurationHistory</code> request exceed
        /// <code>MaxResults</code>, this value can be used to retrieve the next page of results.
        /// This value is <code>null</code> when there are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}