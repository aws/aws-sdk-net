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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the ListEventPredictions operation.
    /// Gets a list of past predictions. The list can be filtered by detector ID, detector
    /// version ID, event ID, event type, or by specifying a time period. If filter is not
    /// specified, the most recent prediction is returned.
    /// 
    ///  
    /// <para>
    /// For example, the following filter lists all past predictions for <c>xyz</c> event
    /// type - <c>{ "eventType":{ "value": "xyz" }” } </c> 
    /// </para>
    ///  
    /// <para>
    /// This is a paginated API. If you provide a null <c>maxResults</c>, this action will
    /// retrieve a maximum of 10 records per page. If you provide a <c>maxResults</c>, the
    /// value must be between 50 and 100. To get the next page results, provide the <c>nextToken</c>
    /// from the response as part of your request. A null <c>nextToken</c> fetches the records
    /// from the beginning. 
    /// </para>
    /// </summary>
    public partial class ListEventPredictionsRequest : AmazonFraudDetectorRequest
    {
        private FilterCondition _detectorId;
        private FilterCondition _detectorVersionId;
        private FilterCondition _eventId;
        private FilterCondition _eventType;
        private int? _maxResults;
        private string _nextToken;
        private PredictionTimeRange _predictionTimeRange;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        ///  The detector ID. 
        /// </para>
        /// </summary>
        public FilterCondition DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        ///  The detector version ID. 
        /// </para>
        /// </summary>
        public FilterCondition DetectorVersionId
        {
            get { return this._detectorVersionId; }
            set { this._detectorVersionId = value; }
        }

        // Check to see if DetectorVersionId property is set
        internal bool IsSetDetectorVersionId()
        {
            return this._detectorVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        ///  The event ID. 
        /// </para>
        /// </summary>
        public FilterCondition EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        ///  The event type associated with the detector. 
        /// </para>
        /// </summary>
        public FilterCondition EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of predictions to return for the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=100)]
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
        ///  Identifies the next page of results to return. Use the token to make the call again
        /// to retrieve the next page. Keep all other arguments unchanged. Each pagination token
        /// expires after 24 hours. 
        /// </para>
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
        /// Gets and sets the property PredictionTimeRange. 
        /// <para>
        ///  The time period for when the predictions were generated. 
        /// </para>
        /// </summary>
        public PredictionTimeRange PredictionTimeRange
        {
            get { return this._predictionTimeRange; }
            set { this._predictionTimeRange = value; }
        }

        // Check to see if PredictionTimeRange property is set
        internal bool IsSetPredictionTimeRange()
        {
            return this._predictionTimeRange != null;
        }

    }
}