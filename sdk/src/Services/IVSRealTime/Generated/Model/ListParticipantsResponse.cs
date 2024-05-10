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
    /// This is the response object from the ListParticipants operation.
    /// </summary>
    public partial class ListParticipantsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ParticipantSummary> _participants = AWSConfigs.InitializeCollections ? new List<ParticipantSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more participants than <c>maxResults</c>, use <c>nextToken</c> in the
        /// request to get the next set.
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
        /// Gets and sets the property Participants. 
        /// <para>
        /// List of the matching participants (summary information only).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ParticipantSummary> Participants
        {
            get { return this._participants; }
            set { this._participants = value; }
        }

        // Check to see if Participants property is set
        internal bool IsSetParticipants()
        {
            return this._participants != null && (this._participants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}