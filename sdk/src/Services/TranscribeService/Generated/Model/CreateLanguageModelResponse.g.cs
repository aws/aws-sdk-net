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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the CreateLanguageModel operation.
    /// </summary>
    public partial class CreateLanguageModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BaseModelName. 
        /// <para>
        /// The Amazon Transcribe standard language model, or base model, you specified when creating
        /// your custom language model.
        /// </para>
        /// </summary>
        public BaseModelName BaseModelName { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelName property is set.
        /// </summary>
        internal bool IsSetBaseModelName() => this.BaseModelName != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Lists your data access role ARN (Amazon Resource Name) and the Amazon S3 locations
        /// you provided for your training (<c>S3Uri</c>) and tuning (<c>TuningDataS3Uri</c>)
        /// data.
        /// </para>
        /// </summary>
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code you selected for your custom language model.
        /// </para>
        /// </summary>
        public CLMLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of your custom language model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelStatus. 
        /// <para>
        /// The status of your custom language model. When the status displays as <c>COMPLETED</c>,
        /// your model is ready to use.
        /// </para>
        /// </summary>
        public ModelStatus ModelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelStatus property is set.
        /// </summary>
        internal bool IsSetModelStatus() => this.ModelStatus != null;
    }
}
