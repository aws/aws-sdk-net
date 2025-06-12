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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
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
namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// A list of messages in the session.
    /// </summary>
    public partial class Transcript
    {
        private int? _beginOffsetMillis;
        private string _content;
        private int? _endOffsetMillis;
        private string _id;
        private List<IssueDetected> _issuesDetected = AWSConfigs.InitializeCollections ? new List<IssueDetected>() : null;
        private string _participantId;
        private string _participantRole;
        private SentimentValue _sentiment;

        /// <summary>
        /// Gets and sets the property BeginOffsetMillis. 
        /// <para>
        /// The beginning offset in the contact for this transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? BeginOffsetMillis
        {
            get { return this._beginOffsetMillis; }
            set { this._beginOffsetMillis = value; }
        }

        // Check to see if BeginOffsetMillis property is set
        internal bool IsSetBeginOffsetMillis()
        {
            return this._beginOffsetMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The end offset in the contact for this transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? EndOffsetMillis
        {
            get { return this._endOffsetMillis; }
            set { this._endOffsetMillis = value; }
        }

        // Check to see if EndOffsetMillis property is set
        internal bool IsSetEndOffsetMillis()
        {
            return this._endOffsetMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IssuesDetected. 
        /// <para>
        /// List of positions where issues were detected on the transcript.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<IssueDetected> IssuesDetected
        {
            get { return this._issuesDetected; }
            set { this._issuesDetected = value; }
        }

        // Check to see if IssuesDetected property is set
        internal bool IsSetIssuesDetected()
        {
            return this._issuesDetected != null && (this._issuesDetected.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier of the participant. Valid values are CUSTOMER or AGENT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ParticipantId
        {
            get { return this._participantId; }
            set { this._participantId = value; }
        }

        // Check to see if ParticipantId property is set
        internal bool IsSetParticipantId()
        {
            return this._participantId != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of participant. For example, is it a customer, agent, or system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ParticipantRole
        {
            get { return this._participantRole; }
            set { this._participantRole = value; }
        }

        // Check to see if ParticipantRole property is set
        internal bool IsSetParticipantRole()
        {
            return this._participantRole != null;
        }

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// The sentiment detected for this piece of transcript.
        /// </para>
        /// </summary>
        public SentimentValue Sentiment
        {
            get { return this._sentiment; }
            set { this._sentiment = value; }
        }

        // Check to see if Sentiment property is set
        internal bool IsSetSentiment()
        {
            return this._sentiment != null;
        }

    }
}