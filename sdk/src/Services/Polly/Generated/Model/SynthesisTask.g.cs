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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// SynthesisTask object that provides information about a speech synthesis task.
    /// </summary>
    public partial class SynthesisTask
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Timestamp for the time the synthesis task was started.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Specifies the engine (<c>standard</c>, <c>neural</c>, <c>long-form</c> or <c>generative</c>)
        /// for Amazon Polly to use when processing input text for speech synthesis. Using a voice
        /// that is not supported for the engine selected will result in an error.
        /// </para>
        /// </summary>
        public Engine Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Optional language code for a synthesis task. This is only necessary if using a bilingual
        /// voice, such as Aditi, which can be used for either Indian English (en-IN) or Hindi
        /// (hi-IN). 
        /// </para>
        ///  
        /// <para>
        /// If a bilingual voice is used and no language code is specified, Amazon Polly uses
        /// the default language of the bilingual voice. The default language for any voice is
        /// the one returned by the <a href="https://docs.aws.amazon.com/polly/latest/dg/API_DescribeVoices.html">DescribeVoices</a>
        /// operation for the <c>LanguageCode</c> parameter. For example, if no language code
        /// is specified, Aditi will use Indian English rather than Hindi.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LexiconNames. 
        /// <para>
        /// List of one or more pronunciation lexicon names you want the service to apply during
        /// synthesis. Lexicons are applied only if the language of the lexicon is the same as
        /// the language of the voice. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> LexiconNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LexiconNames property is set.
        /// </summary>
        internal bool IsSetLexiconNames() => this.LexiconNames != null && (this.LexiconNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The format in which the returned output will be encoded. For audio stream, this will
        /// be mp3, ogg_vorbis, ogg_opus, mu-law, a-law, or pcm. For speech marks, this will be
        /// json. 
        /// </para>
        /// </summary>
        public OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        /// Pathway for the output speech file.
        /// </para>
        /// </summary>
        public string OutputUri { get; set; }

        /// <summary>
        /// Checks to see if the OutputUri property is set.
        /// </summary>
        internal bool IsSetOutputUri() => this.OutputUri != null;

        /// <summary>
        /// Gets and sets the property RequestCharacters. 
        /// <para>
        /// Number of billable characters synthesized.
        /// </para>
        /// </summary>
        public int? RequestCharacters { get; set; }

        /// <summary>
        /// Checks to see if the RequestCharacters property is set.
        /// </summary>
        internal bool IsSetRequestCharacters() => this.RequestCharacters.HasValue;

        /// <summary>
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The audio frequency specified in Hz.
        /// </para>
        ///  
        /// <para>
        /// The valid values for mp3 and ogg_vorbis are "8000", "16000", "22050", and "24000".
        /// The default value for standard voices is "22050". The default value for neural voices
        /// is "24000". The default value for long-form voices is "24000". The default value for
        /// generative voices is "24000".
        /// </para>
        ///  
        /// <para>
        /// Valid values for pcm are "8000" and "16000" The default value is "16000". 
        /// </para>
        ///  
        /// <para>
        /// Valid value for ogg_opus is "48000". 
        /// </para>
        ///  
        /// <para>
        /// Valid value for mu-law and a-law is "8000". 
        /// </para>
        /// </summary>
        public string SampleRate { get; set; }

        /// <summary>
        /// Checks to see if the SampleRate property is set.
        /// </summary>
        internal bool IsSetSampleRate() => this.SampleRate != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// ARN for the SNS topic optionally used for providing status notification for a speech
        /// synthesis task.
        /// </para>
        /// </summary>
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;

        /// <summary>
        /// Gets and sets the property SpeechMarkTypes. 
        /// <para>
        /// The type of speech marks returned for the input text.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<string> SpeechMarkTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SpeechMarkTypes property is set.
        /// </summary>
        internal bool IsSetSpeechMarkTypes() => this.SpeechMarkTypes != null && (this.SpeechMarkTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The Amazon Polly generated identifier for a speech synthesis task.
        /// </para>
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// Current status of the individual speech synthesis task.
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;

        /// <summary>
        /// Gets and sets the property TaskStatusReason. 
        /// <para>
        /// Reason for the current status of a specific speech synthesis task, including errors
        /// if the task has failed.
        /// </para>
        /// </summary>
        public string TaskStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatusReason property is set.
        /// </summary>
        internal bool IsSetTaskStatusReason() => this.TaskStatusReason != null;

        /// <summary>
        /// Gets and sets the property TextType. 
        /// <para>
        /// Specifies whether the input text is plain text or SSML. The default value is plain
        /// text. 
        /// </para>
        /// </summary>
        public TextType TextType { get; set; }

        /// <summary>
        /// Checks to see if the TextType property is set.
        /// </summary>
        internal bool IsSetTextType() => this.TextType != null;

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// Voice ID to use for the synthesis. 
        /// </para>
        /// </summary>
        public VoiceId VoiceId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceId property is set.
        /// </summary>
        internal bool IsSetVoiceId() => this.VoiceId != null;
    }
}
