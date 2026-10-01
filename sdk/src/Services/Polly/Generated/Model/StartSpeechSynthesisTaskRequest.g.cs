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
    /// Container for the parameters to the StartSpeechSynthesisTask operation. Allows the
    /// creation of an asynchronous synthesis task, by starting a new <c>SpeechSynthesisTask</c>.
    /// This operation requires all the standard information needed for speech synthesis,
    /// plus the name of an Amazon S3 bucket for the service to store the output of the synthesis
    /// task and two optional parameters (<c>OutputS3KeyPrefix</c> and <c>SnsTopicArn</c>).
    /// Once the synthesis task is created, this operation will return a <c>SpeechSynthesisTask</c>
    /// object, which will include an identifier of this task as well as the current status.
    /// The <c>SpeechSynthesisTask</c> object is available for 72 hours after starting the
    /// asynchronous synthesis task.
    /// </summary>
    public partial class StartSpeechSynthesisTaskRequest : AmazonPollyRequest
    {
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
        /// Optional language code for the Speech Synthesis request. This is only necessary if
        /// using a bilingual voice, such as Aditi, which can be used for either Indian English
        /// (en-IN) or Hindi (hi-IN). 
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
        [AWSProperty(Required = true)]
        public OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// Amazon S3 bucket name to which the output file will be saved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutputS3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3BucketName property is set.
        /// </summary>
        internal bool IsSetOutputS3BucketName() => this.OutputS3BucketName != null;

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The Amazon S3 key prefix for the output speech file.
        /// </para>
        /// </summary>
        public string OutputS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetOutputS3KeyPrefix() => this.OutputS3KeyPrefix != null;

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
        /// Gets and sets the property Text. 
        /// <para>
        /// The input text to synthesize. If you specify ssml as the TextType, follow the SSML
        /// format for the input text. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

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
        [AWSProperty(Required = true)]
        public VoiceId VoiceId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceId property is set.
        /// </summary>
        internal bool IsSetVoiceId() => this.VoiceId != null;
    }
}
