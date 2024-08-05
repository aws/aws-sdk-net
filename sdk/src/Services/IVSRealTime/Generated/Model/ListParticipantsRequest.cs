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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the ListParticipants operation.
    /// Lists all participants in a specified stage session.
    /// </summary>
    public partial class ListParticipantsRequest : AmazonIVSRealTimeRequest
    {
        private bool? _filterByPublished;
        private ParticipantRecordingFilterByRecordingState _filterByRecordingState;
        private ParticipantState _filterByState;
        private string _filterByUserId;
        private int? _maxResults;
        private string _nextToken;
        private string _sessionId;
        private string _stageArn;

        /// <summary>
        /// Gets and sets the property FilterByPublished. 
        /// <para>
        /// Filters the response list to only show participants who published during the stage
        /// session. Only one of <c>filterByUserId</c>, <c>filterByPublished</c>, <c>filterByState</c>,
        /// or <c>filterByRecordingState</c> can be provided per request.
        /// </para>
        /// </summary>
        public bool? FilterByPublished
        {
            get { return this._filterByPublished; }
            set { this._filterByPublished = value; }
        }

        // Check to see if FilterByPublished property is set
        internal bool IsSetFilterByPublished()
        {
            return this._filterByPublished.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilterByRecordingState. 
        /// <para>
        /// Filters the response list to only show participants with the specified recording state.
        /// Only one of <c>filterByUserId</c>, <c>filterByPublished</c>, <c>filterByState</c>,
        /// or <c>filterByRecordingState</c> can be provided per request.
        /// </para>
        /// </summary>
        public ParticipantRecordingFilterByRecordingState FilterByRecordingState
        {
            get { return this._filterByRecordingState; }
            set { this._filterByRecordingState = value; }
        }

        // Check to see if FilterByRecordingState property is set
        internal bool IsSetFilterByRecordingState()
        {
            return this._filterByRecordingState != null;
        }

        /// <summary>
        /// Gets and sets the property FilterByState. 
        /// <para>
        /// Filters the response list to only show participants in the specified state. Only one
        /// of <c>filterByUserId</c>, <c>filterByPublished</c>, <c>filterByState</c>, or <c>filterByRecordingState</c>
        /// can be provided per request.
        /// </para>
        /// </summary>
        public ParticipantState FilterByState
        {
            get { return this._filterByState; }
            set { this._filterByState = value; }
        }

        // Check to see if FilterByState property is set
        internal bool IsSetFilterByState()
        {
            return this._filterByState != null;
        }

        /// <summary>
        /// Gets and sets the property FilterByUserId. 
        /// <para>
        /// Filters the response list to match the specified user ID. Only one of <c>filterByUserId</c>,
        /// <c>filterByPublished</c>, <c>filterByState</c>, or <c>filterByRecordingState</c> can
        /// be provided per request. A <c>userId</c> is a customer-assigned name to help identify
        /// the token; this can be used to link a participant to a user in the customer’s own
        /// systems.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string FilterByUserId
        {
            get { return this._filterByUserId; }
            set { this._filterByUserId = value; }
        }

        // Check to see if FilterByUserId property is set
        internal bool IsSetFilterByUserId()
        {
            return this._filterByUserId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return. Default: 50.
        /// </para>
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The first participant to retrieve. This is used for pagination; see the <c>nextToken</c>
        /// response field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property SessionId. 
        /// <para>
        /// ID of the session within the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=16)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StageArn. 
        /// <para>
        /// Stage ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StageArn
        {
            get { return this._stageArn; }
            set { this._stageArn = value; }
        }

        // Check to see if StageArn property is set
        internal bool IsSetStageArn()
        {
            return this._stageArn != null;
        }

    }
}