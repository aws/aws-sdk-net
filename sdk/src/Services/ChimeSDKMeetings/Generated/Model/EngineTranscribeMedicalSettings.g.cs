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

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// Settings specific to the Amazon Transcribe Medical engine.
    /// </summary>
    public partial class EngineTranscribeMedicalSettings
    {
        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Set this field to <c>PHI</c> to identify personal health information in the transcription
        /// output.
        /// </para>
        /// </summary>
        public TranscribeMedicalContentIdentificationType ContentIdentificationType { get; set; }

        /// <summary>
        /// Checks to see if the ContentIdentificationType property is set.
        /// </summary>
        internal bool IsSetContentIdentificationType() => this.ContentIdentificationType != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code specified for the Amazon Transcribe Medical engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TranscribeMedicalLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region passed to Amazon Transcribe Medical. If you don't specify
        /// a Region, Amazon Chime uses the meeting's Region. 
        /// </para>
        /// </summary>
        public TranscribeMedicalRegion Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Specialty. 
        /// <para>
        /// The specialty specified for the Amazon Transcribe Medical engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TranscribeMedicalSpecialty Specialty { get; set; }

        /// <summary>
        /// Checks to see if the Specialty property is set.
        /// </summary>
        internal bool IsSetSpecialty() => this.Specialty != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TranscribeMedicalType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the vocabulary passed to Amazon Transcribe Medical.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string VocabularyName { get; set; }

        /// <summary>
        /// Checks to see if the VocabularyName property is set.
        /// </summary>
        internal bool IsSetVocabularyName() => this.VocabularyName != null;
    }
}
