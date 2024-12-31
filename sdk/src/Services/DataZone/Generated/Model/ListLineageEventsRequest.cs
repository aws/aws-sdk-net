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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the ListLineageEvents operation.
    /// Lists lineage events.
    /// </summary>
    public partial class ListLineageEventsRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private LineageEventProcessingStatus _processingStatus;
        private SortOrder _sortOrder;
        private DateTime? _timestampAfter;
        private DateTime? _timestampBefore;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where you want to list lineage events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of lineage events to return in a single call to ListLineageEvents.
        /// When the number of lineage events to be listed is greater than the value of MaxResults,
        /// the response contains a NextToken value that you can use in a subsequent call to ListLineageEvents
        /// to list the next set of lineage events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of lineage events is greater than the default value for the MaxResults
        /// parameter, or if you explicitly specify a value for MaxResults that is less than the
        /// number of lineage events, the response includes a pagination token named NextToken.
        /// You can specify this NextToken value in a subsequent call to ListLineageEvents to
        /// list the next set of lineage events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property ProcessingStatus. 
        /// <para>
        /// The processing status of a lineage event.
        /// </para>
        /// </summary>
        public LineageEventProcessingStatus ProcessingStatus
        {
            get { return this._processingStatus; }
            set { this._processingStatus = value; }
        }

        // Check to see if ProcessingStatus property is set
        internal bool IsSetProcessingStatus()
        {
            return this._processingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order of the lineage events.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampAfter. 
        /// <para>
        /// The after timestamp of a lineage event.
        /// </para>
        /// </summary>
        public DateTime? TimestampAfter
        {
            get { return this._timestampAfter; }
            set { this._timestampAfter = value; }
        }

        // Check to see if TimestampAfter property is set
        internal bool IsSetTimestampAfter()
        {
            return this._timestampAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimestampBefore. 
        /// <para>
        /// The before timestamp of a lineage event.
        /// </para>
        /// </summary>
        public DateTime? TimestampBefore
        {
            get { return this._timestampBefore; }
            set { this._timestampBefore = value; }
        }

        // Check to see if TimestampBefore property is set
        internal bool IsSetTimestampBefore()
        {
            return this._timestampBefore.HasValue; 
        }

    }
}