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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListEventBuses operation.
    /// Lists the event buses visible to the caller: buses the account owns and buses shared
    /// with it through AWS RAM. Shared entries carry identity fields only (Name, EventBusArn,
    /// EventBusAccountId); owned entries carry every summary field. Set EventBusAccountId
    /// to scope the list to one owner account.
    /// </summary>
    public partial class ListEventBusesRequest : AmazonEventBridgeV2Request
    {
        private string _eventBusAccountId;
        private int? _maxResults;
        private string _namePrefix;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EventBusAccountId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string EventBusAccountId
        {
            get { return this._eventBusAccountId; }
            set { this._eventBusAccountId = value; }
        }

        // Check to see if EventBusAccountId property is set
        internal bool IsSetEventBusAccountId()
        {
            return this._eventBusAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamePrefix.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NamePrefix
        {
            get { return this._namePrefix; }
            set { this._namePrefix = value; }
        }

        // Check to see if NamePrefix property is set
        internal bool IsSetNamePrefix()
        {
            return this._namePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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