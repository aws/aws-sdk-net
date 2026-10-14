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
    /// Container for the parameters to the StartTextTranslationJob operation. Starts an asynchronous
    /// batch translation job. Use batch translation jobs to translate large volumes of text
    /// across multiple documents at once. For batch translation, you can input documents
    /// with different source languages (specify <c>auto</c> as the source language). You
    /// can specify one or more target languages. Batch translation translates each input
    /// document into each of the target languages. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/async.html">Asynchronous
    /// batch processing</a>. <para> Batch translation jobs can be described with the <a>DescribeTextTranslationJob</a>
    /// operation, listed with the <a>ListTextTranslationJobs</a> operation, and stopped with
    /// the <a>StopTextTranslationJob</a> operation. </para>
    /// </summary>
    public partial class StartTextTranslationJobRequest : AmazonTranslateRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. This token is generated for you when using the
        /// Amazon Translate SDK.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an AWS Identity Access and Management (IAM) role
        /// that grants Amazon Translate read access to your input data. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/identity-and-access-management.html">Identity
        /// and access management </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Specifies the format and location of the input documents for the translation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch translation job to be performed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies the S3 folder to which your job output will be saved. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

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
        /// Settings to configure your translation output. You can configure the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Brevity: not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Formality: sets the formality level of the output text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Profanity: masks profane words and phrases in your translation output.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TranslationSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code of the input language. Specify the language if all input documents
        /// share the same language. If you don't know the language of the source files, or your
        /// input documents contains different source languages, select <c>auto</c>. Amazon Translate
        /// auto detects the source language for each input document. For a list of supported
        /// language codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 5)]
        public string SourceLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the SourceLanguageCode property is set.
        /// </summary>
        internal bool IsSetSourceLanguageCode() => this.SourceLanguageCode != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> TargetLanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetLanguageCodes property is set.
        /// </summary>
        internal bool IsSetTargetLanguageCodes() => this.TargetLanguageCodes != null && (this.TargetLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);

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
