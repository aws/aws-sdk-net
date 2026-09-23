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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the ListParticipants operation. Lists all participants
    /// in a specified stage session.
    /// </summary>
    public partial class ListParticipantsRequest : AmazonIVSRealTimeRequest
    {
        /// <summary>
        /// Gets and sets the property FilterByPublished. 
        /// <para>
        /// Filters the response list to only show participants who published during the stage
        /// session. Only one of <c>filterByUserId</c>, <c>filterByPublished</c>, <c>filterByState</c>,
        /// or <c>filterByRecordingState</c> can be provided per request.
        /// </para>
        /// </summary>
        public bool? FilterByPublished { get; set; }

        /// <summary>
        /// Checks to see if the FilterByPublished property is set.
        /// </summary>
        internal bool IsSetFilterByPublished() => this.FilterByPublished.HasValue;

        /// <summary>
        /// Gets and sets the property FilterByRecordingState. 
        /// <para>
        /// Filters the response list to only show participants with the specified recording state.
        /// Only one of <c>filterByUserId</c>, <c>filterByPublished</c>, <c>filterByState</c>,
        /// or <c>filterByRecordingState</c> can be provided per request.
        /// </para>
        /// </summary>
        public ParticipantRecordingFilterByRecordingState FilterByRecordingState { get; set; }

        /// <summary>
        /// Checks to see if the FilterByRecordingState property is set.
        /// </summary>
        internal bool IsSetFilterByRecordingState() => this.FilterByRecordingState != null;

        /// <summary>
        /// Gets and sets the property FilterByState. 
        /// <para>
        /// Filters the response list to only show participants in the specified state. Only one
        /// of <c>filterByUserId</c>, <c>filterByPublished</c>, <c>filterByState</c>, or <c>filterByRecordingState</c>
        /// can be provided per request.
        /// </para>
        /// </summary>
        public ParticipantState FilterByState { get; set; }

        /// <summary>
        /// Checks to see if the FilterByState property is set.
        /// </summary>
        internal bool IsSetFilterByState() => this.FilterByState != null;

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
        [AWSProperty(Min = 0, Max = 128)]
        public string FilterByUserId { get; set; }

        /// <summary>
        /// Checks to see if the FilterByUserId property is set.
        /// </summary>
        internal bool IsSetFilterByUserId() => this.FilterByUserId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return. Default: 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The first participant to retrieve. This is used for pagination; see the <c>nextToken</c>
        /// response field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// ID of the session within the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 16)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StageArn. 
        /// <para>
        /// Stage ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string StageArn { get; set; }

        /// <summary>
        /// Checks to see if the StageArn property is set.
        /// </summary>
        internal bool IsSetStageArn() => this.StageArn != null;
    }
}
