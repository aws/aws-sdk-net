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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the StartTextTranslationJob operation.
    /// Starts an asynchronous batch translation job. Batch translation jobs can be used to
    /// translate large volumes of text across multiple documents at once. For more information,
    /// see <a>async</a>.
    /// 
    ///  
    /// <para>
    /// Batch translation jobs can be described with the <a>DescribeTextTranslationJob</a>
    /// operation, listed with the <a>ListTextTranslationJobs</a> operation, and stopped with
    /// the <a>StopTextTranslationJob</a> operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Translate does not support batch translation of multiple source languages at
    /// once.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartTextTranslationJobRequest : AmazonTranslateRequest
    {
        private string _clientToken;
        private string _dataAccessRoleArn;
        private InputDataConfig _inputDataConfig;
        private string _jobName;
        private OutputDataConfig _outputDataConfig;
        private List<string> _parallelDataNames = new List<string>();
        private string _sourceLanguageCode;
        private List<string> _targetLanguageCodes = new List<string>();
        private List<string> _terminologyNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. This token is auto-generated when using the Amazon
        /// Translate SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Identity Access and Management (IAM) role
        /// that grants Amazon Translate read access to your input data. For more nformation,
        /// see <a>identity-and-access-management</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Specifies the format and S3 location of the input documents for the translation job.
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch translation job to be performed.
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
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies the S3 folder to which your job output will be saved. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The names of the parallel data resources to use in the batch translation job. For
        /// a list of available parallel data resources, use the <a>ListParallelData</a> operation.
        /// </para>
        /// </summary>
        public List<string> ParallelDataNames
        {
            get { return this._parallelDataNames; }
            set { this._parallelDataNames = value; }
        }

        // Check to see if ParallelDataNames property is set
        internal bool IsSetParallelDataNames()
        {
            return this._parallelDataNames != null && this._parallelDataNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code of the input language. For a list of language codes, see <a>what-is-languages</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Translate does not automatically detect a source language during batch translation
        /// jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=5)]
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
        /// Gets and sets the property TargetLanguageCodes. 
        /// <para>
        /// The language code of the output language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> TargetLanguageCodes
        {
            get { return this._targetLanguageCodes; }
            set { this._targetLanguageCodes = value; }
        }

        // Check to see if TargetLanguageCodes property is set
        internal bool IsSetTargetLanguageCodes()
        {
            return this._targetLanguageCodes != null && this._targetLanguageCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminologyNames. 
        /// <para>
        /// The name of the terminology to use in the batch translation job. For a list of available
        /// terminologies, use the <a>ListTerminologies</a> operation.
        /// </para>
        /// </summary>
        public List<string> TerminologyNames
        {
            get { return this._terminologyNames; }
            set { this._terminologyNames = value; }
        }

        // Check to see if TerminologyNames property is set
        internal bool IsSetTerminologyNames()
        {
            return this._terminologyNames != null && this._terminologyNames.Count > 0; 
        }

    }
}