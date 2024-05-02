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
    /// Container for the parameters to the ListTimeSeriesDataPoints operation.
    /// Lists time series data points.
    /// </summary>
    public partial class ListTimeSeriesDataPointsRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private DateTime? _endedAt;
        private string _entityIdentifier;
        private TimeSeriesEntityType _entityType;
        private string _formName;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startedAt;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain that houses the assets for which you want to
        /// list time series data points.
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
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp at which the data points that you wanted to list ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// The ID of the asset for which you want to list data points.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EntityIdentifier
        {
            get { return this._entityIdentifier; }
            set { this._entityIdentifier = value; }
        }

        // Check to see if EntityIdentifier property is set
        internal bool IsSetEntityIdentifier()
        {
            return this._entityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the asset for which you want to list data points.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeSeriesEntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property FormName. 
        /// <para>
        /// The name of the time series data points form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string FormName
        {
            get { return this._formName; }
            set { this._formName = value; }
        }

        // Check to see if FormName property is set
        internal bool IsSetFormName()
        {
            return this._formName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of data points to return in a single call to ListTimeSeriesDataPoints.
        /// When the number of data points to be listed is greater than the value of MaxResults,
        /// the response contains a NextToken value that you can use in a subsequent call to ListTimeSeriesDataPoints
        /// to list the next set of data points.
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
        /// When the number of data points is greater than the default value for the MaxResults
        /// parameter, or if you explicitly specify a value for MaxResults that is less than the
        /// number of data points, the response includes a pagination token named NextToken. You
        /// can specify this NextToken value in a subsequent call to ListTimeSeriesDataPoints
        /// to list the next set of data points.
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
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp at which the data points that you want to list started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

    }
}