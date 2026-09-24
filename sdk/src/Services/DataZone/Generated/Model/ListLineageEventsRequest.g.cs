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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListLineageEvents operation. Lists lineage events.
    /// </summary>
    public partial class ListLineageEventsRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where you want to list lineage events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of lineage events to return in a single call to ListLineageEvents.
        /// When the number of lineage events to be listed is greater than the value of MaxResults,
        /// the response contains a NextToken value that you can use in a subsequent call to ListLineageEvents
        /// to list the next set of lineage events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of lineage events is greater than the default value for the MaxResults
        /// parameter, or if you explicitly specify a value for MaxResults that is less than the
        /// number of lineage events, the response includes a pagination token named NextToken.
        /// You can specify this NextToken value in a subsequent call to ListLineageEvents to
        /// list the next set of lineage events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProcessingStatus. 
        /// <para>
        /// The processing status of a lineage event.
        /// </para>
        /// </summary>
        public LineageEventProcessingStatus ProcessingStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingStatus property is set.
        /// </summary>
        internal bool IsSetProcessingStatus() => this.ProcessingStatus != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order of the lineage events.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property TimestampAfter. 
        /// <para>
        /// The after timestamp of a lineage event.
        /// </para>
        /// </summary>
        public DateTime? TimestampAfter { get; set; }

        /// <summary>
        /// Checks to see if the TimestampAfter property is set.
        /// </summary>
        internal bool IsSetTimestampAfter() => this.TimestampAfter.HasValue;

        /// <summary>
        /// Gets and sets the property TimestampBefore. 
        /// <para>
        /// The before timestamp of a lineage event.
        /// </para>
        /// </summary>
        public DateTime? TimestampBefore { get; set; }

        /// <summary>
        /// Checks to see if the TimestampBefore property is set.
        /// </summary>
        internal bool IsSetTimestampBefore() => this.TimestampBefore.HasValue;
    }
}
