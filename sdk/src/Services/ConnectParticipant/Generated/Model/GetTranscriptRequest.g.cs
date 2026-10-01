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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the GetTranscript operation. Retrieves a transcript
    /// of the session, including details about any attachments. For information about accessing
    /// past chat contact transcripts for a persistent chat, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
    /// persistent chat</a>. <para> For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Connect
    /// Customer Chat security best practices</a>. </para> <para> If you have a process that
    /// consumes events in the transcript of an chat that has ended, note that chat transcripts
    /// contain the following event content types if the event has occurred during the chat
    /// session: </para> <ul> <li> <para> <c>application/vnd.amazonaws.connect.event.participant.invited</c>
    /// </para> </li> <li> <para> <c>application/vnd.amazonaws.connect.event.participant.joined</c>
    /// </para> </li> <li> <para> <c>application/vnd.amazonaws.connect.event.participant.left</c>
    /// </para> </li> <li> <para> <c>application/vnd.amazonaws.connect.event.chat.ended</c>
    /// </para> </li> <li> <para> <c>application/vnd.amazonaws.connect.event.transfer.succeeded</c>
    /// </para> </li> <li> <para> <c>application/vnd.amazonaws.connect.event.transfer.failed</c>
    /// </para> </li> </ul> <note> <para> <c>ConnectionToken</c> is used for invoking this
    /// API instead of <c>ParticipantToken</c>. </para> </note> <para> The Amazon Connect
    /// Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>. </para>
    /// </summary>
    public partial class GetTranscriptRequest : AmazonConnectParticipantRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The authentication token associated with the participant's connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string ConnectionToken { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionToken property is set.
        /// </summary>
        internal bool IsSetConnectionToken() => this.ConnectionToken != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The contactId from the current contact chain for which transcript is needed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the page. Default: 10. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token. Use the value returned previously in the next subsequent request
        /// to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ScanDirection. 
        /// <para>
        /// The direction from StartPosition from which to retrieve message. Default: BACKWARD
        /// when no StartPosition is provided, FORWARD with StartPosition. 
        /// </para>
        /// </summary>
        public ScanDirection ScanDirection { get; set; }

        /// <summary>
        /// Checks to see if the ScanDirection property is set.
        /// </summary>
        internal bool IsSetScanDirection() => this.ScanDirection != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the records. Default: DESCENDING.
        /// </para>
        /// </summary>
        public SortKey SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StartPosition. 
        /// <para>
        /// A filtering option for where to start.
        /// </para>
        /// </summary>
        public StartPosition StartPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartPosition property is set.
        /// </summary>
        internal bool IsSetStartPosition() => this.StartPosition != null;
    }
}
