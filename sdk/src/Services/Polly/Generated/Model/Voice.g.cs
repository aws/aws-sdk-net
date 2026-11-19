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
    /// Describes a voice. Amazon Polly provides voices, and you can create custom voices
    /// with <c>CreateVoice</c>. <c>Origin</c> indicates whether Amazon Polly provides the
    /// voice or you created it. <c>DescribeVoices</c> returns a subset of the fields for
    /// each voice. <c>GetVoice</c> returns all fields of a custom voice.
    /// </summary>
    public partial class Voice
    {
        /// <summary>
        /// Gets and sets the property AdditionalLanguageCodes. 
        /// <para>
        /// Additional codes for languages available for the specified voice in addition to its
        /// default language. 
        /// </para>
        ///  
        /// <para>
        /// For example, the default language for Aditi is Indian English (en-IN) because it was
        /// first used for that language. Since Aditi is bilingual and fluent in both Indian English
        /// and Hindi, this parameter would show the code <c>hi-IN</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalLanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalLanguageCodes property is set.
        /// </summary>
        internal bool IsSetAdditionalLanguageCodes() => this.AdditionalLanguageCodes != null && (this.AdditionalLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a custom voice, in the form <c>arn:partition:polly:region:account-id:voice/voice-id</c>.
        /// <c>CreateVoice</c> and <c>GetVoice</c> return this field. Voices that Amazon Polly
        /// provides don't have an ARN.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when you created the custom voice. Voices that Amazon Polly provides
        /// don't include this field.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerManagedEncryption. 
        /// <para>
        /// The customer managed key that encrypts your custom voice. <c>CreateVoice</c> and <c>GetVoice</c>
        /// return this field if you specified a key in <c>CreateVoice</c>.
        /// </para>
        /// </summary>
        public CustomerManagedEncryption CustomerManagedEncryption { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedEncryption property is set.
        /// </summary>
        internal bool IsSetCustomerManagedEncryption() => this.CustomerManagedEncryption != null;

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// The gender of the voice. Custom voices don't include this field.
        /// </para>
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Checks to see if the Gender property is set.
        /// </summary>
        internal bool IsSetGender() => this.Gender != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The voice ID that Amazon Polly assigns. You specify this ID when you call the <c>SynthesizeSpeech</c>
        /// operation. For a custom voice, Amazon Polly assigns an ID that consists of <c>vc-</c>
        /// followed by hexadecimal characters, for example, <c>vc-9a8fa85dd3</c>.
        /// </para>
        /// </summary>
        public VoiceId Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Language code of the voice.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageName. 
        /// <para>
        /// Human readable name of the language in English.
        /// </para>
        /// </summary>
        public string LanguageName { get; set; }

        /// <summary>
        /// Checks to see if the LanguageName property is set.
        /// </summary>
        internal bool IsSetLanguageName() => this.LanguageName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the voice, for example, Salli or Kendra. The name is human-readable, and
        /// you might display it in your application. For a custom voice, this is the <c>Name</c>
        /// that you specified in <c>CreateVoice</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// Indicates who provides the voice. The origin is one of the following:
        /// </para>
        ///  <dl> <dt>aws</dt> <dd> 
        /// <para>
        /// A voice that Amazon Polly provides.
        /// </para>
        ///  </dd> <dt>customer</dt> <dd> 
        /// <para>
        /// A custom voice that you created with <c>CreateVoice</c>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public VoiceOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a custom voice. Voices that Amazon Polly provides don't include this
        /// field. The status is one of the following:
        /// </para>
        ///  <dl> <dt>pending</dt> <dd> 
        /// <para>
        /// Amazon Polly is creating the voice.
        /// </para>
        ///  </dd> <dt>active</dt> <dd> 
        /// <para>
        /// The voice is ready for speech synthesis.
        /// </para>
        ///  </dd> <dt>failed</dt> <dd> 
        /// <para>
        /// Amazon Polly couldn't create the voice. <c>StatusReason</c> describes why.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public VoiceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of a custom voice. When the status is <c>failed</c>,
        /// this field describes why Amazon Polly couldn't create the voice.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property SupportedEngines. 
        /// <para>
        /// Specifies which engines (<c>standard</c>, <c>neural</c>, <c>long-form</c> or <c>generative</c>)
        /// are supported by a given voice.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedEngines { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedEngines property is set.
        /// </summary>
        internal bool IsSetSupportedEngines() => this.SupportedEngines != null && (this.SupportedEngines.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VoiceCreationData. 
        /// <para>
        /// The data from which you created the custom voice. <c>CreateVoice</c> and <c>GetVoice</c>
        /// return this field. The response doesn't include the audio: a recording that Amazon
        /// Polly read from Amazon S3 includes its <c>S3Url</c>, and a recording that you passed
        /// as <c>Bytes</c> has no fields in <c>Data</c>.
        /// </para>
        /// </summary>
        public VoiceCreationData VoiceCreationData { get; set; }

        /// <summary>
        /// Checks to see if the VoiceCreationData property is set.
        /// </summary>
        internal bool IsSetVoiceCreationData() => this.VoiceCreationData != null;
    }
}
