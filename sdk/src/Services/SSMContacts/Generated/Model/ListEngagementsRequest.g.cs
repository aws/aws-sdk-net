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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the ListEngagements operation. Lists all engagements
    /// that have happened in an incident.
    /// </summary>
    public partial class ListEngagementsRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property IncidentId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident you're listing engagements for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string IncidentId { get; set; }

        /// <summary>
        /// Checks to see if the IncidentId property is set.
        /// </summary>
        internal bool IsSetIncidentId() => this.IncidentId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of engagements per page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to continue to the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TimeRangeValue. 
        /// <para>
        /// The time range to lists engagements for an incident.
        /// </para>
        /// </summary>
        public TimeRange TimeRangeValue { get; set; }

        /// <summary>
        /// Checks to see if the TimeRangeValue property is set.
        /// </summary>
        internal bool IsSetTimeRangeValue() => this.TimeRangeValue != null;
    }
}
