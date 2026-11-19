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
    /// Container for the parameters to the CreateVoice operation. Creates a custom voice
    /// from recordings of a speaker and returns it in <c>pending</c> status. Use <c>GetVoice</c>
    /// to check the status. When the status is <c>active</c>, you can use the voice ID in
    /// <c>SynthesizeSpeech</c>, <c>StartSpeechSynthesisTask</c>, and <c>StartSpeechSynthesisStream</c>.
    /// <para> The <c>custom-voice-max-count</c> service quota limits the number of custom
    /// voices in your account in each Region. If you reach the quota, the request fails with
    /// <c>ServiceQuotaExceededException</c>. </para> <para> This operation requires permissions
    /// to perform the <c>polly:CreateVoice</c> action. You also need <c>s3:GetObject</c>
    /// permission on each recording that you specify by <c>S3Url</c>. If you specify a customer
    /// managed key, you also need <c>kms:DescribeKey</c>, <c>kms:GenerateDataKey</c>, and
    /// <c>kms:Decrypt</c> permissions on the key. If you specify <c>Tags</c>, you also need
    /// the <c>polly:TagResource</c> permission. </para>
    /// </summary>
    public partial class CreateVoiceRequest : AmazonPollyRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDKs generate
        /// one for you. If you retry a request that succeeded with the same client token and
        /// the same parameters, Amazon Polly returns the voice that the first request created
        /// and doesn't create a second voice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CustomerManagedEncryption. 
        /// <para>
        /// The customer managed key that you want Amazon Polly to encrypt the voice with. If
        /// you omit this parameter, Amazon Polly encrypts the voice with an Amazon Web Services
        /// owned key.
        /// </para>
        /// </summary>
        public CustomerManagedEncryption CustomerManagedEncryption { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedEncryption property is set.
        /// </summary>
        internal bool IsSetCustomerManagedEncryption() => this.CustomerManagedEncryption != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the recordings, for example, <c>en-US</c>. Amazon Polly doesn't detect
        /// the language from the recordings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomVoiceLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the voice. Use the name to identify the voice in your application. The
        /// name can contain letters, digits, hyphens, and underscores, and can be up to 64 characters
        /// long. The name doesn't have to be unique. The name isn't the voice ID, which Amazon
        /// Polly assigns.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the voice to help you categorize and organize it. Each
        /// tag consists of a key and an optional value, both of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TermsAccepted. 
        /// <para>
        /// Confirms the following two statements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "I confirm that I have obtained all necessary consents required under any applicable
        /// laws and regulations, including biometric privacy laws, from the owner of this voice
        /// to clone these voice samples."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "I confirm that I will not use the generated content for any illegal, fraudulent,
        /// or harmful purpose and reaffirm my obligation to abide by the AWS Service Terms, Biometric
        /// Notice and Consent Terms, AWS Responsible AI Policy, and AWS Acceptable Use Policy."
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can read the <a href="https://aws.amazon.com/service-terms/">AWS Service Terms</a>,
        /// the <a href="https://aws.amazon.com/legal/biometric-notice-and-consent-terms/">Biometric
        /// Notice and Consent Terms</a>, the <a href="https://aws.amazon.com/ai/responsible-ai/policy/">AWS
        /// Responsible AI Policy</a>, and the <a href="https://aws.amazon.com/aup/">AWS Acceptable
        /// Use Policy</a> on the Amazon Web Services website.
        /// </para>
        ///  
        /// <para>
        /// You must set this parameter to <c>true</c> to create a voice. Otherwise, the request
        /// fails with <c>ValidationException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? TermsAccepted { get; set; }

        /// <summary>
        /// Checks to see if the TermsAccepted property is set.
        /// </summary>
        internal bool IsSetTermsAccepted() => this.TermsAccepted.HasValue;

        /// <summary>
        /// Gets and sets the property VoiceCreationData. 
        /// <para>
        /// The recordings that Amazon Polly uses to create the voice.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VoiceCreationData VoiceCreationData { get; set; }

        /// <summary>
        /// Checks to see if the VoiceCreationData property is set.
        /// </summary>
        internal bool IsSetVoiceCreationData() => this.VoiceCreationData != null;
    }
}
