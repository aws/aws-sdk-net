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
    /// Container for the parameters to the DescribeVoices operation. Returns the list of
    /// voices: the voices that Amazon Polly provides and the custom voices in your account.
    /// Each voice speaks a specified language and is identified by an ID. A voice that Amazon
    /// Polly provides is either male or female, and its ID is the ASCII version of the voice
    /// name. <para> When synthesizing speech (<c>SynthesizeSpeech</c>), you provide the voice
    /// ID for the voice you want from the list of voices returned by <c>DescribeVoices</c>.
    /// </para> <para> For example, your news reader application reads news in a specific
    /// language, and you want to give users the option to choose the voice. With the <c>DescribeVoices</c>
    /// operation, you can provide a list of available voices for users to choose from. </para>
    /// <para> You can optionally specify a language code to filter the available voices.
    /// For example, if you specify <c>en-US</c>, the operation returns a list of all available
    /// US English voices. </para> <para> The list includes custom voices in every status.
    /// For each voice, <c>Origin</c> indicates whether Amazon Polly provides the voice or
    /// you created it. You can use a custom voice for synthesis only when its status is <c>active</c>.
    /// A voice in <c>failed</c> status stays in the list until you delete it. </para> <para>
    /// For a custom voice, <c>DescribeVoices</c> returns <c>Origin</c>, <c>Id</c>, <c>Name</c>,
    /// <c>Status</c>, <c>LanguageCode</c>, <c>LanguageName</c>, <c>SupportedEngines</c>,
    /// and <c>CreationTime</c>. To get <c>Arn</c>, <c>StatusReason</c>, <c>VoiceCreationData</c>,
    /// and <c>CustomerManagedEncryption</c>, use <c>GetVoice</c>. </para> <para> The <c>LanguageCode</c>
    /// and <c>Engine</c> filters apply to custom voices in the same way as to voices that
    /// Amazon Polly provides. </para> <para> This operation requires permissions to perform
    /// the <c>polly:DescribeVoices</c> action. </para>
    /// </summary>
    public partial class DescribeVoicesRequest : AmazonPollyRequest
    {
        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Specifies the engine (<c>standard</c>, <c>neural</c>, <c>long-form</c> or <c>generative</c>)
        /// used by Amazon Polly when processing input text for speech synthesis. 
        /// </para>
        /// </summary>
        public Engine Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property IncludeAdditionalLanguageCodes. 
        /// <para>
        /// Boolean value indicating whether to return any bilingual voices that use the specified
        /// language as an additional language. For instance, if you request all languages that
        /// use US English (es-US), and there is an Italian voice that speaks both Italian (it-IT)
        /// and US English, that voice will be included if you specify <c>yes</c> but not if you
        /// specify <c>no</c>.
        /// </para>
        /// </summary>
        public bool? IncludeAdditionalLanguageCodes { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAdditionalLanguageCodes property is set.
        /// </summary>
        internal bool IsSetIncludeAdditionalLanguageCodes() => this.IncludeAdditionalLanguageCodes.HasValue;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        ///  The language identification tag (ISO 639 code for the language name-ISO 3166 country
        /// code) for filtering the list of voices returned. If you don't specify this optional
        /// parameter, all available voices are returned. 
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An opaque pagination token returned from the previous <c>DescribeVoices</c> operation.
        /// If present, this indicates where to continue the listing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
