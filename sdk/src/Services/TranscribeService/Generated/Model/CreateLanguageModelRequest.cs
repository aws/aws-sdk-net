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
    /// Creates a new custom language model.
    /// 
    ///  
    /// <para>
    /// When creating a new custom language model, you must specify:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you want a Wideband (audio sample rates over 16,000 Hz) or Narrowband (audio sample
    /// rates under 16,000 Hz) base model
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The location of your training and tuning files (this must be an Amazon S3 URI)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The language of your model
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A unique name for your model
    /// </para>
    ///  </li> </ul>
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
        /// Contains the Amazon S3 location of the training data you want to use to create a new
        /// custom language model, and permissions to access this location.
        /// </para>
        ///  
        /// <para>
        /// When using <code>InputDataConfig</code>, you must include these sub-parameters: <code>S3Uri</code>,
        /// which is the Amazon S3 location of your training data, and <code>DataAccessRoleArn</code>,
        /// which is the Amazon Resource Name (ARN) of the role that has permission to access
        /// your specified Amazon S3 location. You can optionally include <code>TuningDataS3Uri</code>,
        /// which is the Amazon S3 location of your tuning data. If you specify different Amazon
        /// S3 locations for training and tuning data, the ARN you use must have permissions to
        /// access both locations.
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
        /// The language code that represents the language of your model. Each custom language
        /// model must contain terms in only one language, and the language you select for your
        /// custom language model must match the language of your training and tuning data.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported languages and their associated language codes, refer to the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table. Note that US English (<code>en-US</code>) is the only language
        /// supported with Amazon Transcribe Medical.
        /// </para>
        ///  
        /// <para>
        /// A custom language model can only be used to transcribe files in the same language
        /// as the model. For example, if you create a custom language model using US English
        /// (<code>en-US</code>), you can only apply this model to files that contain English
        /// audio.
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
        /// A unique name, chosen by you, for your custom language model.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account. If you try to create a new custom language model with the same
        /// name as an existing custom language model, you get a <code>ConflictException</code>
        /// error.
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
        /// Adds one or more custom tags, each in the form of a key:value pair, to a new custom
        /// language model at the time you create this new model.
        /// </para>
        ///  
        /// <para>
        /// To learn more about using tags with Amazon Transcribe, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tagging.html">Tagging
        /// resources</a>.
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