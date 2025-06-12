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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for a one-time voice message that's sent directly to an endpoint
    /// through the voice channel.
    /// </summary>
    public partial class VoiceMessage
    {
        private string _body;
        private string _languageCode;
        private string _originationNumber;
        private Dictionary<string, List<string>> _substitutions = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _voiceId;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The text of the script to use for the voice message.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The code for the language to use when synthesizing the text of the message script.
        /// For a list of supported languages and the code for each one, see the <a href="https://docs.aws.amazon.com/polly/latest/dg/what-is.html">Amazon
        /// Polly Developer Guide</a>.
        /// </para>
        /// </summary>
        public string LanguageCode
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
        /// Gets and sets the property OriginationNumber. 
        /// <para>
        /// The long code to send the voice message from. This value should be one of the dedicated
        /// long codes that's assigned to your AWS account. Although it isn't required, we recommend
        /// that you specify the long code in E.164 format, for example +12065550100, to ensure
        /// prompt and accurate delivery of the message.
        /// </para>
        /// </summary>
        public string OriginationNumber
        {
            get { return this._originationNumber; }
            set { this._originationNumber = value; }
        }

        // Check to see if OriginationNumber property is set
        internal bool IsSetOriginationNumber()
        {
            return this._originationNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The default message variables to use in the voice message. You can override the default
        /// variables with individual address variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && (this._substitutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The name of the voice to use when delivering the message. For a list of supported
        /// voices, see the <a href="https://docs.aws.amazon.com/polly/latest/dg/what-is.html">Amazon
        /// Polly Developer Guide</a>.
        /// </para>
        /// </summary>
        public string VoiceId
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