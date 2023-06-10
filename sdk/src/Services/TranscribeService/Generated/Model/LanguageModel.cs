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
    /// Provides information about a custom language model, including:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The base model name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the model was created
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The location of the files used to train the model
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the model was last modified
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The name you chose for the model
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The model's language
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The model's processing state
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any available upgrades for the base model
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LanguageModel
    {
        private BaseModelName _baseModelName;
        private DateTime? _createTime;
        private string _failureReason;
        private InputDataConfig _inputDataConfig;
        private CLMLanguageCode _languageCode;
        private DateTime? _lastModifiedTime;
        private string _modelName;
        private ModelStatus _modelStatus;
        private bool? _upgradeAvailability;

        /// <summary>
        /// Gets and sets the property BaseModelName. 
        /// <para>
        /// The Amazon Transcribe standard language model, or base model, used to create your
        /// custom language model.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the specified custom language model was created.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <code>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</code>. For example,
        /// <code>2022-05-04T12:32:58.761000-07:00</code> represents 12:32 PM UTC-7 on May 4,
        /// 2022.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <code>ModelStatus</code> is <code>FAILED</code>, <code>FailureReason</code> contains
        /// information about why the custom language model request failed. See also: <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/CommonErrors.html">Common
        /// Errors</a>.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The Amazon S3 location of the input files used to train and tune your custom language
        /// model, in addition to the data access role ARN (Amazon Resource Name) that has permissions
        /// to access these data.
        /// </para>
        /// </summary>
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
        /// The language code used to create your custom language model. Each custom language
        /// model must contain terms in only one language, and the language you select for your
        /// custom language model must match the language of your training and tuning data.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported languages and their associated language codes, refer to the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table. Note that U.S. English (<code>en-US</code>) is the only language
        /// supported with Amazon Transcribe Medical.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the specified custom language model was last modified.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <code>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</code>. For example,
        /// <code>2022-05-04T12:32:58.761000-07:00</code> represents 12:32 PM UTC-7 on May 4,
        /// 2022.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// A unique name, chosen by you, for your custom language model.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property ModelStatus. 
        /// <para>
        /// The status of the specified custom language model. When the status displays as <code>COMPLETED</code>
        /// the model is ready for use.
        /// </para>
        /// </summary>
        public ModelStatus ModelStatus
        {
            get { return this._modelStatus; }
            set { this._modelStatus = value; }
        }

        // Check to see if ModelStatus property is set
        internal bool IsSetModelStatus()
        {
            return this._modelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeAvailability. 
        /// <para>
        /// Shows if a more current base model is available for use with the specified custom
        /// language model.
        /// </para>
        ///  
        /// <para>
        /// If <code>false</code>, your custom language model is using the most up-to-date base
        /// model.
        /// </para>
        ///  
        /// <para>
        /// If <code>true</code>, there is a newer base model available than the one your language
        /// model is using.
        /// </para>
        ///  
        /// <para>
        /// Note that to update a base model, you must recreate the custom language model using
        /// the new base model. Base model upgrades for existing custom language models are not
        /// supported.
        /// </para>
        /// </summary>
        public bool UpgradeAvailability
        {
            get { return this._upgradeAvailability.GetValueOrDefault(); }
            set { this._upgradeAvailability = value; }
        }

        // Check to see if UpgradeAvailability property is set
        internal bool IsSetUpgradeAvailability()
        {
            return this._upgradeAvailability.HasValue; 
        }

    }
}