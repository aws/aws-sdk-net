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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Details about the data.
    /// </summary>
    public partial class DataDetails
    {
        /// <summary>
        /// Gets and sets the property CaseSummarizationChunkData. 
        /// <para>
        /// Details about case summarization chunk data.
        /// </para>
        /// </summary>
        public CaseSummarizationChunkDataDetails CaseSummarizationChunkData { get; set; }

        /// <summary>
        /// Checks to see if the CaseSummarizationChunkData property is set.
        /// </summary>
        internal bool IsSetCaseSummarizationChunkData() => this.CaseSummarizationChunkData != null;

        /// <summary>
        /// Gets and sets the property ContentData. 
        /// <para>
        /// Details about the content data.
        /// </para>
        /// </summary>
        public ContentDataDetails ContentData { get; set; }

        /// <summary>
        /// Checks to see if the ContentData property is set.
        /// </summary>
        internal bool IsSetContentData() => this.ContentData != null;

        /// <summary>
        /// Gets and sets the property EmailGenerativeAnswerChunkData. 
        /// <para>
        /// Streaming chunk data for email generative answers containing partial knowledge-based
        /// response content.
        /// </para>
        /// </summary>
        public EmailGenerativeAnswerChunkDataDetails EmailGenerativeAnswerChunkData { get; set; }

        /// <summary>
        /// Checks to see if the EmailGenerativeAnswerChunkData property is set.
        /// </summary>
        internal bool IsSetEmailGenerativeAnswerChunkData() => this.EmailGenerativeAnswerChunkData != null;

        /// <summary>
        /// Gets and sets the property EmailOverviewChunkData. 
        /// <para>
        /// Streaming chunk data for email overview containing partial overview content.
        /// </para>
        /// </summary>
        public EmailOverviewChunkDataDetails EmailOverviewChunkData { get; set; }

        /// <summary>
        /// Checks to see if the EmailOverviewChunkData property is set.
        /// </summary>
        internal bool IsSetEmailOverviewChunkData() => this.EmailOverviewChunkData != null;

        /// <summary>
        /// Gets and sets the property EmailResponseChunkData. 
        /// <para>
        /// Streaming chunk data for email response generation containing partial response content.
        /// </para>
        /// </summary>
        public EmailResponseChunkDataDetails EmailResponseChunkData { get; set; }

        /// <summary>
        /// Checks to see if the EmailResponseChunkData property is set.
        /// </summary>
        internal bool IsSetEmailResponseChunkData() => this.EmailResponseChunkData != null;

        /// <summary>
        /// Gets and sets the property GenerativeChunkData. 
        /// <para>
        /// Details about the generative chunk data.
        /// </para>
        /// </summary>
        public GenerativeChunkDataDetails GenerativeChunkData { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeChunkData property is set.
        /// </summary>
        internal bool IsSetGenerativeChunkData() => this.GenerativeChunkData != null;

        /// <summary>
        /// Gets and sets the property GenerativeData. 
        /// <para>
        ///  Details about the generative data.
        /// </para>
        /// </summary>
        public GenerativeDataDetails GenerativeData { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeData property is set.
        /// </summary>
        internal bool IsSetGenerativeData() => this.GenerativeData != null;

        /// <summary>
        /// Gets and sets the property IntentDetectedData. 
        /// <para>
        /// Details about the intent data.
        /// </para>
        /// </summary>
        public IntentDetectedDataDetails IntentDetectedData { get; set; }

        /// <summary>
        /// Checks to see if the IntentDetectedData property is set.
        /// </summary>
        internal bool IsSetIntentDetectedData() => this.IntentDetectedData != null;

        /// <summary>
        /// Gets and sets the property NotesChunkData. 
        /// <para>
        /// Details about notes chunk data.
        /// </para>
        /// </summary>
        public NotesChunkDataDetails NotesChunkData { get; set; }

        /// <summary>
        /// Checks to see if the NotesChunkData property is set.
        /// </summary>
        internal bool IsSetNotesChunkData() => this.NotesChunkData != null;

        /// <summary>
        /// Gets and sets the property NotesData. 
        /// <para>
        /// Details about notes data.
        /// </para>
        /// </summary>
        public NotesDataDetails NotesData { get; set; }

        /// <summary>
        /// Checks to see if the NotesData property is set.
        /// </summary>
        internal bool IsSetNotesData() => this.NotesData != null;

        /// <summary>
        /// Gets and sets the property ProactiveRecommendationData. 
        /// <para>
        /// Details about a proactive recommendation, including the token used to retrieve its
        /// chunked response with <c>GetNextMessage</c>.
        /// </para>
        /// </summary>
        public ProactiveRecommendationDataDetails ProactiveRecommendationData { get; set; }

        /// <summary>
        /// Checks to see if the ProactiveRecommendationData property is set.
        /// </summary>
        internal bool IsSetProactiveRecommendationData() => this.ProactiveRecommendationData != null;

        /// <summary>
        /// Gets and sets the property SourceContentData. 
        /// <para>
        /// Details about the content data.
        /// </para>
        /// </summary>
        public SourceContentDataDetails SourceContentData { get; set; }

        /// <summary>
        /// Checks to see if the SourceContentData property is set.
        /// </summary>
        internal bool IsSetSourceContentData() => this.SourceContentData != null;

        /// <summary>
        /// Gets and sets the property SuggestedMessageData. 
        /// <para>
        /// Details about suggested message data.
        /// </para>
        /// </summary>
        public SuggestedMessageDataDetails SuggestedMessageData { get; set; }

        /// <summary>
        /// Checks to see if the SuggestedMessageData property is set.
        /// </summary>
        internal bool IsSetSuggestedMessageData() => this.SuggestedMessageData != null;
    }
}
