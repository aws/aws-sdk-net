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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
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
        private TranscribeMedicalContentIdentificationType _contentIdentificationType;
        private TranscribeMedicalLanguageCode _languageCode;
        private TranscribeMedicalRegion _region;
        private TranscribeMedicalSpecialty _specialty;
        private TranscribeMedicalType _type;
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property ContentIdentificationType. 
        /// <para>
        /// Set this field to <c>PHI</c> to identify personal health information in the transcription
        /// output.
        /// </para>
        /// </summary>
        public TranscribeMedicalContentIdentificationType ContentIdentificationType
        {
            get { return this._contentIdentificationType; }
            set { this._contentIdentificationType = value; }
        }

        // Check to see if ContentIdentificationType property is set
        internal bool IsSetContentIdentificationType()
        {
            return this._contentIdentificationType != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code specified for the Amazon Transcribe Medical engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranscribeMedicalLanguageCode LanguageCode
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region passed to Amazon Transcribe Medical. If you don't specify
        /// a Region, Amazon Chime uses the meeting's Region. 
        /// </para>
        /// </summary>
        public TranscribeMedicalRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Specialty. 
        /// <para>
        /// The specialty specified for the Amazon Transcribe Medical engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranscribeMedicalSpecialty Specialty
        {
            get { return this._specialty; }
            set { this._specialty = value; }
        }

        // Check to see if Specialty property is set
        internal bool IsSetSpecialty()
        {
            return this._specialty != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of transcription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranscribeMedicalType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the vocabulary passed to Amazon Transcribe Medical.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string VocabularyName
        {
            get { return this._vocabularyName; }
            set { this._vocabularyName = value; }
        }

        // Check to see if VocabularyName property is set
        internal bool IsSetVocabularyName()
        {
            return this._vocabularyName != null;
        }

    }
}