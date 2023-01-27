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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the GetTranscript operation.
    /// Retrieves a transcript of the session, including details about any attachments. For
    /// information about accessing past chat contact transcripts for a persistent chat, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
    /// persistent chat</a>. 
    /// 
    ///  <note> 
    /// <para>
    ///  <code>ConnectionToken</code> is used for invoking this API instead of <code>ParticipantToken</code>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>.
    /// </para>
    /// </summary>
    public partial class GetTranscriptRequest : AmazonConnectParticipantRequest
    {
        private string _connectionToken;
        private string _contactId;
        private int? _maxResults;
        private string _nextToken;
        private ScanDirection _scanDirection;
        private SortKey _sortOrder;
        private StartPosition _startPosition;

        /// <summary>
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The authentication token associated with the participant's connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string ConnectionToken
        {
            get { return this._connectionToken; }
            set { this._connectionToken = value; }
        }

        // Check to see if ConnectionToken property is set
        internal bool IsSetConnectionToken()
        {
            return this._connectionToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The contactId from the current contact chain for which transcript is needed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the page. Default: 10. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// The pagination token. Use the value returned previously in the next subsequent request
        /// to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property ScanDirection. 
        /// <para>
        /// The direction from StartPosition from which to retrieve message. Default: BACKWARD
        /// when no StartPosition is provided, FORWARD with StartPosition. 
        /// </para>
        /// </summary>
        public ScanDirection ScanDirection
        {
            get { return this._scanDirection; }
            set { this._scanDirection = value; }
        }

        // Check to see if ScanDirection property is set
        internal bool IsSetScanDirection()
        {
            return this._scanDirection != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the records. Default: DESCENDING.
        /// </para>
        /// </summary>
        public SortKey SortOrder
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
        /// Gets and sets the property StartPosition. 
        /// <para>
        /// A filtering option for where to start.
        /// </para>
        /// </summary>
        public StartPosition StartPosition
        {
            get { return this._startPosition; }
            set { this._startPosition = value; }
        }

        // Check to see if StartPosition property is set
        internal bool IsSetStartPosition()
        {
            return this._startPosition != null;
        }

    }
}