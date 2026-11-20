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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Container for the parameters to the ListManagedApiEvents operation. Lists API-security
    /// events for a single managed API, most recent first. Returns up to 20 of the most recent
    /// events (not paginated).
    /// </summary>
    public partial class ListManagedApiEventsRequest : AmazonAPIPortalRequest
    {
        /// <summary>
        /// Gets and sets the property ManagedApiId. The identifier of the Managed API.
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 30)]
        public string ManagedApiId { get; set; }

        /// <summary>
        /// Checks to see if the ManagedApiId property is set.
        /// </summary>
        internal bool IsSetManagedApiId() => this.ManagedApiId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of results to return in
        /// one page, from 1 to 20.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. The pagination token returned by a previous
        /// call. Omit it to get the first page.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartedAfter. Inclusive lower bound on each event's start
        /// time; only events that started at or after this time are returned. Optional; defaults
        /// to 30 days before the current time.
        /// </summary>
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartedAfter property is set.
        /// </summary>
        internal bool IsSetStartedAfter() => this.StartedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBefore. Exclusive upper bound on each event's start
        /// time; only events that started before this time are returned. Optional; defaults to
        /// the current time.
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartedBefore property is set.
        /// </summary>
        internal bool IsSetStartedBefore() => this.StartedBefore.HasValue;
    }
}
