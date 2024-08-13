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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
    /// Container for the parameters to the ListEngagements operation.
    /// Lists all engagements that have happened in an incident.
    /// </summary>
    public partial class ListEngagementsRequest : AmazonSSMContactsRequest
    {
        private string _incidentId;
        private int? _maxResults;
        private string _nextToken;
        private TimeRange _timeRangeValue;

        /// <summary>
        /// Gets and sets the property IncidentId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident you're listing engagements for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string IncidentId
        {
            get { return this._incidentId; }
            set { this._incidentId = value; }
        }

        // Check to see if IncidentId property is set
        internal bool IsSetIncidentId()
        {
            return this._incidentId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of engagements per page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The pagination token to continue to the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property TimeRangeValue. 
        /// <para>
        /// The time range to lists engagements for an incident.
        /// </para>
        /// </summary>
        public TimeRange TimeRangeValue
        {
            get { return this._timeRangeValue; }
            set { this._timeRangeValue = value; }
        }

        // Check to see if TimeRangeValue property is set
        internal bool IsSetTimeRangeValue()
        {
            return this._timeRangeValue != null;
        }

    }
}