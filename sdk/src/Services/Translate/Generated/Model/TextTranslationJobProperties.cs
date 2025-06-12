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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// Provides information about a translation job.
    /// </summary>
    public partial class TextTranslationJobProperties
    {
        private string _dataAccessRoleArn;
        private DateTime? _endTime;
        private InputDataConfig _inputDataConfig;
        private JobDetails _jobDetails;
        private string _jobId;
        private string _jobName;
        private JobStatus _jobStatus;
        private string _message;
        private OutputDataConfig _outputDataConfig;
        private List<string> _parallelDataNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TranslationSettings _settings;
        private string _sourceLanguageCode;
        private DateTime? _submittedTime;
        private List<string> _targetLanguageCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _terminologyNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Identity Access and Management (IAM) role
        /// that granted Amazon Translate read access to the job's input data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The time at which the translation job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input configuration properties that were specified when the job was requested.
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
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// The number of documents successfully and unsuccessfully processed during the translation
        /// job.
        /// </para>
        /// </summary>
        public JobDetails JobDetails
        {
            get { return this._jobDetails; }
            set { this._jobDetails = value; }
        }

        // Check to see if JobDetails property is set
        internal bool IsSetJobDetails()
        {
            return this._jobDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the translation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The user-defined name of the translation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the translation job.
        /// </para>
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An explanation of any errors that may have occurred during the translation job.
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
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The output configuration properties that were specified when the job was requested.
        /// </para>
        /// </summary>
        public OutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelDataNames. 
        /// <para>
        /// A list containing the names of the parallel data resources applied to the translation
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParallelDataNames
        {
            get { return this._parallelDataNames; }
            set { this._parallelDataNames = value; }
        }

        // Check to see if ParallelDataNames property is set
        internal bool IsSetParallelDataNames()
        {
            return this._parallelDataNames != null && (this._parallelDataNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Settings that modify the translation output.
        /// </para>
        /// </summary>
        public TranslationSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code of the language of the source text. The language must be a language
        /// supported by Amazon Translate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public string SourceLanguageCode
        {
            get { return this._sourceLanguageCode; }
            set { this._sourceLanguageCode = value; }
        }

        // Check to see if SourceLanguageCode property is set
        internal bool IsSetSourceLanguageCode()
        {
            return this._sourceLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property SubmittedTime. 
        /// <para>
        /// The time at which the translation job was submitted.
        /// </para>
        /// </summary>
        public DateTime? SubmittedTime
        {
            get { return this._submittedTime; }
            set { this._submittedTime = value; }
        }

        // Check to see if SubmittedTime property is set
        internal bool IsSetSubmittedTime()
        {
            return this._submittedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetLanguageCodes. 
        /// <para>
        /// The language code of the language of the target text. The language must be a language
        /// supported by Amazon Translate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> TargetLanguageCodes
        {
            get { return this._targetLanguageCodes; }
            set { this._targetLanguageCodes = value; }
        }

        // Check to see if TargetLanguageCodes property is set
        internal bool IsSetTargetLanguageCodes()
        {
            return this._targetLanguageCodes != null && (this._targetLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TerminologyNames. 
        /// <para>
        /// A list containing the names of the terminologies applied to a translation job. Only
        /// one terminology can be applied per <a>StartTextTranslationJob</a> request at this
        /// time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerminologyNames
        {
            get { return this._terminologyNames; }
            set { this._terminologyNames = value; }
        }

        // Check to see if TerminologyNames property is set
        internal bool IsSetTerminologyNames()
        {
            return this._terminologyNames != null && (this._terminologyNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}