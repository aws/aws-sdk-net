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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the ListEventDataStores operation.
    /// </summary>
    public partial class ListEventDataStoresResponse : AmazonWebServiceResponse
    {
        private List<EventDataStore> _eventDataStores = new List<EventDataStore>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EventDataStores. 
        /// <para>
        /// Contains information about event data stores in the account, in the current Region.
        /// </para>
        /// </summary>
        public List<EventDataStore> EventDataStores
        {
            get { return this._eventDataStores; }
            set { this._eventDataStores = value; }
        }

        // Check to see if EventDataStores property is set
        internal bool IsSetEventDataStores()
        {
            return this._eventDataStores != null && this._eventDataStores.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token you can use to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1000)]
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