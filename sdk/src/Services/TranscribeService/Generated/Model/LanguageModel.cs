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
    /// The structure used to describe a custom language model.
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
        /// The Amazon Transcribe standard language model, or base model used to create the custom
        /// language model.
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
        /// The time the custom language model was created.
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
        /// The reason why the custom language model couldn't be created.
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
        /// The data access role and Amazon S3 prefixes for the input files used to train the
        /// custom language model.
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
        /// The language code you used to create your custom language model.
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
        /// The most recent time the custom language model was modified.
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
        /// The name of the custom language model.
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
        /// The creation status of a custom language model. When the status is <code>COMPLETED</code>
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
        /// Whether the base model used for the custom language model is up to date. If this field
        /// is <code>true</code> then you are running the most up-to-date version of the base
        /// model in your custom language model.
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