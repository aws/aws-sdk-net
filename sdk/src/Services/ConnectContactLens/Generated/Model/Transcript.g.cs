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

namespace Amazon.ConnectContactLens.Model
{
    /// <summary>
    /// A list of messages in the session.
    /// </summary>
    public partial class Transcript
    {
        /// <summary>
        /// Gets and sets the property BeginOffsetMillis. 
        /// <para>
        /// The beginning offset in the contact for this transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? BeginOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffsetMillis property is set.
        /// </summary>
        internal bool IsSetBeginOffsetMillis() => this.BeginOffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property EndOffsetMillis. 
        /// <para>
        /// The end offset in the contact for this transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? EndOffsetMillis { get; set; }

        /// <summary>
        /// Checks to see if the EndOffsetMillis property is set.
        /// </summary>
        internal bool IsSetEndOffsetMillis() => this.EndOffsetMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the transcript.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IssuesDetected. 
        /// <para>
        /// List of positions where issues were detected on the transcript.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<IssueDetected> IssuesDetected { get; set; } = AWSConfigs.InitializeCollections ? new List<IssueDetected>() : null;

        /// <summary>
        /// Checks to see if the IssuesDetected property is set.
        /// </summary>
        internal bool IsSetIssuesDetected() => this.IssuesDetected != null && (this.IssuesDetected.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier of the participant. Valid values are CUSTOMER or AGENT.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property ParticipantRole. 
        /// <para>
        /// The role of participant. For example, is it a customer, agent, or system.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ParticipantRole { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantRole property is set.
        /// </summary>
        internal bool IsSetParticipantRole() => this.ParticipantRole != null;

        /// <summary>
        /// Gets and sets the property Sentiment. 
        /// <para>
        /// The sentiment detected for this piece of transcript.
        /// </para>
        /// </summary>
        public SentimentValue Sentiment { get; set; }

        /// <summary>
        /// Checks to see if the Sentiment property is set.
        /// </summary>
        internal bool IsSetSentiment() => this.Sentiment != null;
    }
}
