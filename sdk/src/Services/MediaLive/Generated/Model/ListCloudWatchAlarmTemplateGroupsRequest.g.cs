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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the ListCloudWatchAlarmTemplateGroups operation. Lists
    /// cloudwatch alarm template groups.
    /// </summary>
    public partial class ListCloudWatchAlarmTemplateGroupsRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. A token used to retrieve the next set of results
        /// in paginated list responses.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Scope. Represents the scope of a resource, with options
        /// for all scopes, AWS provided resources, or local resources.
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SignalMapIdentifier. A signal map's identifier. Can be
        /// either be its id or current name.
        /// </summary>
        public string SignalMapIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SignalMapIdentifier property is set.
        /// </summary>
        internal bool IsSetSignalMapIdentifier() => this.SignalMapIdentifier != null;
    }
}
