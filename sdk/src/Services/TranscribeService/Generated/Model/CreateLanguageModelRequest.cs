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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLanguageModel operation.
    /// Creates a new custom language model. When creating a new language model, you must
    /// specify if you want a Wideband (audio sample rates over 16,000 Hz) or Narrowband (audio
    /// sample rates under 16,000 Hz) base model. You then include the S3 URI location of
    /// your training and tuning files, the language for the model, a unique name, and any
    /// tags you want associated with your model.
    /// </summary>
    public partial class CreateLanguageModelRequest : AmazonTranscribeServiceRequest
    {
        private BaseModelName _baseModelName;
        private InputDataConfig _inputDataConfig;
        private CLMLanguageCode _languageCode;
        private string _modelName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property BaseModelName. 
        /// <para>
        /// The Amazon Transcribe standard language model, or base model, used to create your
        /// custom language model. Amazon Transcribe offers two options for base models: Wideband
        /// and Narrowband.
        /// </para>
        ///  
        /// <para>
        /// If the audio you want to transcribe has a sample rate of 16,000 Hz or greater, choose
        /// <code>WideBand</code>. To transcribe audio with a sample rate less than 16,000 Hz,
        /// choose <code>NarrowBand</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BaseModelName BaseModelName
        {
            get { return this._baseModelName; }
            set { this._baseModelName = value; }
        }

        // Check to see if BaseModelName property is set
        internal bool IsSetBaseModelName()
        {
            return this._baseModelName != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Contains your data access role ARN (Amazon Resource Name) and the Amazon S3 locations
        /// of your training (<code>S3Uri</code>) and tuning (<code>TuningDataS3Uri</code>) data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of your custom language model; note that the language code you select
        /// must match the language of your training and tuning data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CLMLanguageCode LanguageCode
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
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of your new custom language model.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a language model with the same name as
        /// a previous language model, you get a <code>ConflictException</code> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optionally add tags, each in the form of a key:value pair, to your new language model.
        /// See also: .
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}