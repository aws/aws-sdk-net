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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the ListMultiplexAlerts operation.
    /// List the alerts for a multiplex with optional filtering based on alert state.
    /// </summary>
    public partial class ListMultiplexAlertsRequest : AmazonMediaLiveRequest
    {
        private int? _maxResults;
        private string _multiplexId;
        private string _nextToken;
        private string _stateFilter;

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of items to return
        /// </summary>
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
        /// Gets and sets the property MultiplexId. The unique ID of the multiplex
        /// </summary>
        [AWSProperty(Required=true)]
        public string MultiplexId
        {
            get { return this._multiplexId; }
            set { this._multiplexId = value; }
        }

        // Check to see if MultiplexId property is set
        internal bool IsSetMultiplexId()
        {
            return this._multiplexId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. The next pagination token
        /// </summary>
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
        /// Gets and sets the property StateFilter. Specifies the set of alerts to return based
        /// on their state. SET - Return only alerts with SET state. CLEARED - Return only alerts
        /// with CLEARED state. ALL - Return all alerts.
        /// </summary>
        public string StateFilter
        {
            get { return this._stateFilter; }
            set { this._stateFilter = value; }
        }

        // Check to see if StateFilter property is set
        internal bool IsSetStateFilter()
        {
            return this._stateFilter != null;
        }

    }
}