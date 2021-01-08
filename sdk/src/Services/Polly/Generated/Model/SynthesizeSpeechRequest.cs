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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Polly.Model
{
    /// <summary>
    /// Container for the parameters to the SynthesizeSpeech operation.
    /// Synthesizes UTF-8 input, plain text or SSML, to a stream of bytes. SSML input must
    /// be valid, well-formed SSML. Some alphabets might not be available with all the voices
    /// (for example, Cyrillic might not be read at all by English voices) unless phoneme
    /// mapping is used. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/how-text-to-speech-works.html">How
    /// it Works</a>.
    /// </summary>
    public partial class SynthesizeSpeechRequest : AmazonPollyRequest
    {
        private Engine _engine;
        private LanguageCode _languageCode;
        private List<string> _lexiconNames = new List<string>();
        private OutputFormat _outputFormat;
        private string _sampleRate;
        private List<string> _speechMarkTypes = new List<string>();
        private string _text;
        private TextType _textType;
        private VoiceId _voiceId;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Specifies the engine (<code>standard</code> or <code>neural</code>) for Amazon Polly
        /// to use when processing input text for speech synthesis. For information on Amazon
        /// Polly voices and which voices are available in standard-only, NTTS-only, and both
        /// standard and NTTS formats, see <a href="https://docs.aws.amazon.com/polly/latest/dg/voicelist.html">Available
        /// Voices</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>NTTS-only voices</b> 
        /// </para>
        ///  
        /// <para>
        /// When using NTTS-only voices such as Kevin (en-US), this parameter is required and
        /// must be set to <code>neural</code>. If the engine is not specified, or is set to <code>standard</code>,
        /// this will result in an error. 
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>standard</code> | <code>neural</code> 
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        ///  
        /// <para>
        ///  <b>Standard voices</b> 
        /// </para>
        ///  
        /// <para>
        /// For standard voices, this is not required; the engine parameter defaults to <code>standard</code>.
        /// If the engine is not specified, or is set to <code>standard</code> and an NTTS-only
        /// voice is selected, this will result in an error. 
        /// </para>
        /// </summary>
        public Engine Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Optional language code for the Synthesize Speech request. This is only necessary if
        /// using a bilingual voice, such as Aditi, which can be used for either Indian English
        /// (en-IN) or Hindi (hi-IN). 
        /// </para>
        ///  
        /// <para>
        /// If a bilingual voice is used and no language code is specified, Amazon Polly will
        /// use the default language of the bilingual voice. The default language for any voice
        /// is the one returned by the <a href="https://docs.aws.amazon.com/polly/latest/dg/API_DescribeVoices.html">DescribeVoices</a>
        /// operation for the <code>LanguageCode</code> parameter. For example, if no language
        /// code is specified, Aditi will use Indian English rather than Hindi.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property LexiconNames. 
        /// <para>
        /// List of one or more pronunciation lexicon names you want the service to apply during
        /// synthesis. Lexicons are applied only if the language of the lexicon is the same as
        /// the language of the voice. For information about storing lexicons, see <a href="https://docs.aws.amazon.com/polly/latest/dg/API_PutLexicon.html">PutLexicon</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
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
        ///  The format in which the returned output will be encoded. For audio stream, this will
        /// be mp3, ogg_vorbis, or pcm. For speech marks, this will be json. 
        /// </para>
        ///  
        /// <para>
        /// When pcm is used, the content returned is audio/pcm in a signed 16-bit, 1 channel
        /// (mono), little-endian format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SampleRate. 
        /// <para>
        /// The audio frequency specified in Hz.
        /// </para>
        ///  
        /// <para>
        /// The valid values for mp3 and ogg_vorbis are "8000", "16000", "22050", and "24000".
        /// The default value for standard voices is "22050". The default value for neural voices
        /// is "24000".
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
        /// Gets and sets the property SpeechMarkTypes. 
        /// <para>
        /// The type of speech marks returned for the input text.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4)]
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
        /// Gets and sets the property Text. 
        /// <para>
        ///  Input text to synthesize. If you specify <code>ssml</code> as the <code>TextType</code>,
        /// follow the SSML format for the input text. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property TextType. 
        /// <para>
        ///  Specifies whether the input text is plain text or SSML. The default value is plain
        /// text. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/ssml.html">Using
        /// SSML</a>.
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
        ///  Voice ID to use for the synthesis. You can get a list of available voice IDs by calling
        /// the <a href="https://docs.aws.amazon.com/polly/latest/dg/API_DescribeVoices.html">DescribeVoices</a>
        /// operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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