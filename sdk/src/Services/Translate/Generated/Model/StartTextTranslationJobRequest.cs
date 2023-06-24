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
    /// Starts an asynchronous batch translation job. Use batch translation jobs to translate
    /// large volumes of text across multiple documents at once. For batch translation, you
    /// can input documents with different source languages (specify <code>auto</code> as
    /// the source language). You can specify one or more target languages. Batch translation
    /// translates each input document into each of the target languages. For more information,
    /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/async.html">Asynchronous
    /// batch processing</a>.
    /// 
    ///  
    /// <para>
    /// Batch translation jobs can be described with the <a>DescribeTextTranslationJob</a>
    /// operation, listed with the <a>ListTextTranslationJobs</a> operation, and stopped with
    /// the <a>StopTextTranslationJob</a> operation.
    /// </para>
    /// </summary>
    public partial class StartTextTranslationJobRequest : AmazonTranslateRequest
    {
        private string _clientToken;
        private string _dataAccessRoleArn;
        private InputDataConfig _inputDataConfig;
        private string _jobName;
        private OutputDataConfig _outputDataConfig;
        private List<string> _parallelDataNames = new List<string>();
        private TranslationSettings _settings;
        private string _sourceLanguageCode;
        private List<string> _targetLanguageCodes = new List<string>();
        private List<string> _terminologyNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. This token is generated for you when using the
        /// Amazon Translate SDK.
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
        /// that grants Amazon Translate read access to your input data. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/identity-and-access-management.html">Identity
        /// and access management </a>.
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
        /// Specifies the format and location of the input documents for the translation job.
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
        /// The name of a parallel data resource to add to the translation job. This resource
        /// consists of examples that show how you want segments of text to be translated. If
        /// you specify multiple target languages for the job, the parallel data file must include
        /// translations for all the target languages.
        /// </para>
        ///  
        /// <para>
        /// When you add parallel data to a translation job, you create an <i>Active Custom Translation</i>
        /// job. 
        /// </para>
        ///  
        /// <para>
        /// This parameter accepts only one parallel data resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// Active Custom Translation jobs are priced at a higher rate than other jobs that don't
        /// use parallel data. For more information, see <a href="http://aws.amazon.com/translate/pricing/">Amazon
        /// Translate pricing</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For a list of available parallel data resources, use the <a>ListParallelData</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/customizing-translations-parallel-data.html">
        /// Customizing your translations with parallel data</a>.
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// Settings to configure your translation output, including the option to set the formality
        /// level of the output text and the option to mask profane words and phrases.
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
        /// The language code of the input language. Specify the language if all input documents
        /// share the same language. If you don't know the language of the source files, or your
        /// input documents contains different source languages, select <code>auto</code>. Amazon
        /// Translate auto detects the source language for each input document. For a list of
        /// supported language codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
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
        /// The target languages of the translation job. Enter up to 10 language codes. Each input
        /// file is translated into each target language.
        /// </para>
        ///  
        /// <para>
        /// Each language code is 2 or 5 characters long. For a list of language codes, see <a
        /// href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The name of a custom terminology resource to add to the translation job. This resource
        /// lists examples source terms and the desired translation for each term.
        /// </para>
        ///  
        /// <para>
        /// This parameter accepts only one custom terminology resource.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple target languages for the job, translate uses the designated
        /// terminology for each requested target language that has an entry for the source term
        /// in the terminology file.
        /// </para>
        ///  
        /// <para>
        /// For a list of available custom terminology resources, use the <a>ListTerminologies</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/how-custom-terminology.html">Custom
        /// terminology</a>.
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