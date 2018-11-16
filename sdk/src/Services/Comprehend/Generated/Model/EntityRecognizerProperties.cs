/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes information about an entity recognizer.
    /// </summary>
    public partial class EntityRecognizerProperties
    {
        private string _dataAccessRoleArn;
        private DateTime? _endTime;
        private string _entityRecognizerArn;
        private EntityRecognizerInputDataConfig _inputDataConfig;
        private LanguageCode _languageCode;
        private string _message;
        private EntityRecognizerMetadata _recognizerMetadata;
        private ModelStatus _status;
        private DateTime? _submitTime;
        private DateTime? _trainingEndTime;
        private DateTime? _trainingStartTime;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the AWS Identity and Management (IAM) role that
        /// grants Amazon Comprehend read access to your input data.
        /// </para>
        /// </summary>
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the recognizer creation completed.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntityRecognizerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the entity recognizer.
        /// </para>
        /// </summary>
        public string EntityRecognizerArn
        {
            get { return this._entityRecognizerArn; }
            set { this._entityRecognizerArn = value; }
        }

        // Check to see if EntityRecognizerArn property is set
        internal bool IsSetEntityRecognizerArn()
        {
            return this._entityRecognizerArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input data properties of an entity recognizer.
        /// </para>
        /// </summary>
        public EntityRecognizerInputDataConfig InputDataConfig
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
        ///  The language of the input documents. All documents must be in the same language.
        /// Only English ("en") is currently supported.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
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
        /// Gets and sets the property Message. 
        /// <para>
        ///  A description of the status of the recognizer.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property RecognizerMetadata. 
        /// <para>
        ///  Provides information about an entity recognizer.
        /// </para>
        /// </summary>
        public EntityRecognizerMetadata RecognizerMetadata
        {
            get { return this._recognizerMetadata; }
            set { this._recognizerMetadata = value; }
        }

        // Check to see if RecognizerMetadata property is set
        internal bool IsSetRecognizerMetadata()
        {
            return this._recognizerMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Provides the status of the entity recognizer.
        /// </para>
        /// </summary>
        public ModelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The time that the recognizer was submitted for processing.
        /// </para>
        /// </summary>
        public DateTime SubmitTime
        {
            get { return this._submitTime.GetValueOrDefault(); }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// The time that training of the entity recognizer was completed.
        /// </para>
        /// </summary>
        public DateTime TrainingEndTime
        {
            get { return this._trainingEndTime.GetValueOrDefault(); }
            set { this._trainingEndTime = value; }
        }

        // Check to see if TrainingEndTime property is set
        internal bool IsSetTrainingEndTime()
        {
            return this._trainingEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingStartTime. 
        /// <para>
        /// The time that training of the entity recognizer started.
        /// </para>
        /// </summary>
        public DateTime TrainingStartTime
        {
            get { return this._trainingStartTime.GetValueOrDefault(); }
            set { this._trainingStartTime = value; }
        }

        // Check to see if TrainingStartTime property is set
        internal bool IsSetTrainingStartTime()
        {
            return this._trainingStartTime.HasValue; 
        }

    }
}