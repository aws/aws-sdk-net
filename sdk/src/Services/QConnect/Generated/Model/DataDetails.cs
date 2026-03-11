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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private CaseSummarizationChunkDataDetails _caseSummarizationChunkData;
        private ContentDataDetails _contentData;
        private EmailGenerativeAnswerChunkDataDetails _emailGenerativeAnswerChunkData;
        private EmailOverviewChunkDataDetails _emailOverviewChunkData;
        private EmailResponseChunkDataDetails _emailResponseChunkData;
        private GenerativeChunkDataDetails _generativeChunkData;
        private GenerativeDataDetails _generativeData;
        private IntentDetectedDataDetails _intentDetectedData;
        private NotesChunkDataDetails _notesChunkData;
        private NotesDataDetails _notesData;
        private SourceContentDataDetails _sourceContentData;
        private SuggestedMessageDataDetails _suggestedMessageData;

        /// <summary>
        /// Gets and sets the property CaseSummarizationChunkData. 
        /// <para>
        /// Details about case summarization chunk data.
        /// </para>
        /// </summary>
        public CaseSummarizationChunkDataDetails CaseSummarizationChunkData
        {
            get { return this._caseSummarizationChunkData; }
            set { this._caseSummarizationChunkData = value; }
        }

        // Check to see if CaseSummarizationChunkData property is set
        internal bool IsSetCaseSummarizationChunkData()
        {
            return this._caseSummarizationChunkData != null;
        }

        /// <summary>
        /// Gets and sets the property ContentData. 
        /// <para>
        /// Details about the content data.
        /// </para>
        /// </summary>
        public ContentDataDetails ContentData
        {
            get { return this._contentData; }
            set { this._contentData = value; }
        }

        // Check to see if ContentData property is set
        internal bool IsSetContentData()
        {
            return this._contentData != null;
        }

        /// <summary>
        /// Gets and sets the property EmailGenerativeAnswerChunkData. 
        /// <para>
        /// Streaming chunk data for email generative answers containing partial knowledge-based
        /// response content.
        /// </para>
        /// </summary>
        public EmailGenerativeAnswerChunkDataDetails EmailGenerativeAnswerChunkData
        {
            get { return this._emailGenerativeAnswerChunkData; }
            set { this._emailGenerativeAnswerChunkData = value; }
        }

        // Check to see if EmailGenerativeAnswerChunkData property is set
        internal bool IsSetEmailGenerativeAnswerChunkData()
        {
            return this._emailGenerativeAnswerChunkData != null;
        }

        /// <summary>
        /// Gets and sets the property EmailOverviewChunkData. 
        /// <para>
        /// Streaming chunk data for email overview containing partial overview content.
        /// </para>
        /// </summary>
        public EmailOverviewChunkDataDetails EmailOverviewChunkData
        {
            get { return this._emailOverviewChunkData; }
            set { this._emailOverviewChunkData = value; }
        }

        // Check to see if EmailOverviewChunkData property is set
        internal bool IsSetEmailOverviewChunkData()
        {
            return this._emailOverviewChunkData != null;
        }

        /// <summary>
        /// Gets and sets the property EmailResponseChunkData. 
        /// <para>
        /// Streaming chunk data for email response generation containing partial response content.
        /// </para>
        /// </summary>
        public EmailResponseChunkDataDetails EmailResponseChunkData
        {
            get { return this._emailResponseChunkData; }
            set { this._emailResponseChunkData = value; }
        }

        // Check to see if EmailResponseChunkData property is set
        internal bool IsSetEmailResponseChunkData()
        {
            return this._emailResponseChunkData != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeChunkData. 
        /// <para>
        /// Details about the generative chunk data.
        /// </para>
        /// </summary>
        public GenerativeChunkDataDetails GenerativeChunkData
        {
            get { return this._generativeChunkData; }
            set { this._generativeChunkData = value; }
        }

        // Check to see if GenerativeChunkData property is set
        internal bool IsSetGenerativeChunkData()
        {
            return this._generativeChunkData != null;
        }

        /// <summary>
        /// Gets and sets the property GenerativeData. 
        /// <para>
        ///  Details about the generative data.
        /// </para>
        /// </summary>
        public GenerativeDataDetails GenerativeData
        {
            get { return this._generativeData; }
            set { this._generativeData = value; }
        }

        // Check to see if GenerativeData property is set
        internal bool IsSetGenerativeData()
        {
            return this._generativeData != null;
        }

        /// <summary>
        /// Gets and sets the property IntentDetectedData. 
        /// <para>
        /// Details about the intent data.
        /// </para>
        /// </summary>
        public IntentDetectedDataDetails IntentDetectedData
        {
            get { return this._intentDetectedData; }
            set { this._intentDetectedData = value; }
        }

        // Check to see if IntentDetectedData property is set
        internal bool IsSetIntentDetectedData()
        {
            return this._intentDetectedData != null;
        }

        /// <summary>
        /// Gets and sets the property NotesChunkData. 
        /// <para>
        /// Details about notes chunk data.
        /// </para>
        /// </summary>
        public NotesChunkDataDetails NotesChunkData
        {
            get { return this._notesChunkData; }
            set { this._notesChunkData = value; }
        }

        // Check to see if NotesChunkData property is set
        internal bool IsSetNotesChunkData()
        {
            return this._notesChunkData != null;
        }

        /// <summary>
        /// Gets and sets the property NotesData. 
        /// <para>
        /// Details about notes data.
        /// </para>
        /// </summary>
        public NotesDataDetails NotesData
        {
            get { return this._notesData; }
            set { this._notesData = value; }
        }

        // Check to see if NotesData property is set
        internal bool IsSetNotesData()
        {
            return this._notesData != null;
        }

        /// <summary>
        /// Gets and sets the property SourceContentData. 
        /// <para>
        /// Details about the content data.
        /// </para>
        /// </summary>
        public SourceContentDataDetails SourceContentData
        {
            get { return this._sourceContentData; }
            set { this._sourceContentData = value; }
        }

        // Check to see if SourceContentData property is set
        internal bool IsSetSourceContentData()
        {
            return this._sourceContentData != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestedMessageData. 
        /// <para>
        /// Details about suggested message data.
        /// </para>
        /// </summary>
        public SuggestedMessageDataDetails SuggestedMessageData
        {
            get { return this._suggestedMessageData; }
            set { this._suggestedMessageData = value; }
        }

        // Check to see if SuggestedMessageData property is set
        internal bool IsSetSuggestedMessageData()
        {
            return this._suggestedMessageData != null;
        }

    }
}