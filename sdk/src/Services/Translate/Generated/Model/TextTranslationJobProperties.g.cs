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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Provides information about a translation job.
    /// </summary>
    public partial class TextTranslationJobProperties
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Identity Access and Management (IAM) role
        /// that granted Amazon Translate read access to the job's input data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the translation job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input configuration properties that were specified when the job was requested.
        /// </para>
        /// </summary>
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// The number of documents successfully and unsuccessfully processed during the translation
        /// job.
        /// </para>
        /// </summary>
        public JobDetails JobDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobDetails property is set.
        /// </summary>
        internal bool IsSetJobDetails() => this.JobDetails != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the translation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The user-defined name of the translation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the translation job.
        /// </para>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An explanation of any errors that may have occurred during the translation job.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The output configuration properties that were specified when the job was requested.
        /// </para>
        /// </summary>
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property ParallelDataNames. 
        /// <para>
        /// A list containing the names of the parallel data resources applied to the translation
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParallelDataNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ParallelDataNames property is set.
        /// </summary>
        internal bool IsSetParallelDataNames() => this.ParallelDataNames != null && (this.ParallelDataNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Settings that modify the translation output.
        /// </para>
        /// </summary>
        public TranslationSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code of the language of the source text. The language must be a language
        /// supported by Amazon Translate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string SourceLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the SourceLanguageCode property is set.
        /// </summary>
        internal bool IsSetSourceLanguageCode() => this.SourceLanguageCode != null;

        /// <summary>
        /// Gets and sets the property SubmittedTime. 
        /// <para>
        /// The time at which the translation job was submitted.
        /// </para>
        /// </summary>
        public DateTime? SubmittedTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedTime property is set.
        /// </summary>
        internal bool IsSetSubmittedTime() => this.SubmittedTime.HasValue;

        /// <summary>
        /// Gets and sets the property TargetLanguageCodes. 
        /// <para>
        /// The language code of the language of the target text. The language must be a language
        /// supported by Amazon Translate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> TargetLanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetLanguageCodes property is set.
        /// </summary>
        internal bool IsSetTargetLanguageCodes() => this.TargetLanguageCodes != null && (this.TargetLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminologyNames. 
        /// <para>
        /// A list containing the names of the terminologies applied to a translation job. Only
        /// one terminology can be applied per <a>StartTextTranslationJob</a> request at this
        /// time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerminologyNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TerminologyNames property is set.
        /// </summary>
        internal bool IsSetTerminologyNames() => this.TerminologyNames != null && (this.TerminologyNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
