/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Polly.Model
{
    /// <summary>
    /// SynthesisTask object that provides information about a speech synthesis task.
    /// </summary>
    public partial class SynthesisTask
    {
        private DateTime? _creationTime;
        private List<string> _lexiconNames = new List<string>();
        private OutputFormat _outputFormat;
        private string _outputUri;
        private int? _requestCharacters;
        private string _sampleRate;
        private string _snsTopicArn;
        private List<string> _speechMarkTypes = new List<string>();
        private string _taskId;
        private TaskStatus _taskStatus;
        private string _taskStatusReason;
        private TextType _textType;
        private VoiceId _voiceId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Timestamp for the time the synthesis task was started.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LexiconNames. 
        /// <para>
        /// List of one or more pronunciation lexicon names you want the service to apply during
        /// synthesis. Lexicons are applied only if the language of the lexicon is the same as
        /// the language of the voice. 
        /// </para>
        /// </summary>
        public List<string> LexiconNames
        {
            get { return this._lexiconNames; }
            set { this._lexiconNames = value; }
        }

        // Check to see if LexiconNames property is set
        internal bool IsSetLexiconNames()
        {
            return this._lexiconNames != null && this._lexiconNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The format in which the returned output will be encoded. For audio stream, this will
        /// be mp3, ogg_vorbis, or pcm. For speech marks, this will be json. 
        /// </para>
        /// </summary>
        public OutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// Pathway for the output speech file.
        /// </para>
        /// </summary>
        public string OutputUri
        {
            get { return this._outputUri; }
            set { this._outputUri = value; }
        }

        // Check to see if OutputUri property is set
        internal bool IsSetOutputUri()
        {
            return this._outputUri != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharacters. 
        /// <para>
        /// Number of billable characters synthesized.
        /// </para>
        /// </summary>
        public int RequestCharacters
        {
            get { return this._requestCharacters.GetValueOrDefault(); }
            set { this._requestCharacters = value; }
        }

        // Check to see if RequestCharacters property is set
        internal bool IsSetRequestCharacters()
        {
            return this._requestCharacters.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The audio frequency specified in Hz.
        /// </para>
        ///  
        /// <para>
        /// The valid values for mp3 and ogg_vorbis are "8000", "16000", and "22050". The default
        /// value is "22050".
        /// </para>
        ///  
        /// <para>
        /// Valid values for pcm are "8000" and "16000" The default value is "16000". 
        /// </para>
        /// </summary>
        public string SampleRate
        {
            get { return this._sampleRate; }
            set { this._sampleRate = value; }
        }

        // Check to see if SampleRate property is set
        internal bool IsSetSampleRate()
        {
            return this._sampleRate != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// ARN for the SNS topic optionally used for providing status notification for a speech
        /// synthesis task.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SpeechMarkTypes. 
        /// <para>
        /// The type of speech marks returned for the input text.
        /// </para>
        /// </summary>
        public List<string> SpeechMarkTypes
        {
            get { return this._speechMarkTypes; }
            set { this._speechMarkTypes = value; }
        }

        // Check to see if SpeechMarkTypes property is set
        internal bool IsSetSpeechMarkTypes()
        {
            return this._speechMarkTypes != null && this._speechMarkTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The Amazon Polly generated identifier for a speech synthesis task.
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// Current status of the individual speech synthesis task.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStatusReason. 
        /// <para>
        /// Reason for the current status of a specific speech synthesis task, including errors
        /// if the task has failed.
        /// </para>
        /// </summary>
        public string TaskStatusReason
        {
            get { return this._taskStatusReason; }
            set { this._taskStatusReason = value; }
        }

        // Check to see if TaskStatusReason property is set
        internal bool IsSetTaskStatusReason()
        {
            return this._taskStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TextType. 
        /// <para>
        /// Specifies whether the input text is plain text or SSML. The default value is plain
        /// text. 
        /// </para>
        /// </summary>
        public TextType TextType
        {
            get { return this._textType; }
            set { this._textType = value; }
        }

        // Check to see if TextType property is set
        internal bool IsSetTextType()
        {
            return this._textType != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// Voice ID to use for the synthesis. 
        /// </para>
        /// </summary>
        public VoiceId VoiceId
        {
            get { return this._voiceId; }
            set { this._voiceId = value; }
        }

        // Check to see if VoiceId property is set
        internal bool IsSetVoiceId()
        {
            return this._voiceId != null;
        }

    }
}