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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListEventBuses operation. Lists the event buses
    /// visible to the caller: buses the account owns and buses shared with it through AWS
    /// RAM. Shared entries carry identity fields only (Name, EventBusArn, EventBusAccountId);
    /// owned entries carry every summary field. Set EventBusAccountId to scope the list to
    /// one owner account.
    /// </summary>
    public partial class ListEventBusesRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property EventBusAccountId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string EventBusAccountId { get; set; }

        /// <summary>
        /// Checks to see if the EventBusAccountId property is set.
        /// </summary>
        internal bool IsSetEventBusAccountId() => this.EventBusAccountId != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NamePrefix.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefix property is set.
        /// </summary>
        internal bool IsSetNamePrefix() => this.NamePrefix != null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
