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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the DescribeLanguageModel operation.
    /// </summary>
    public partial class DescribeLanguageModelResponse : AmazonWebServiceResponse
    {
        private LanguageModel _languageModel;

        /// <summary>
        /// Gets and sets the property LanguageModel. 
        /// <para>
        /// Provides information about the specified custom language model.
        /// </para>
        ///  
        /// <para>
        /// This parameter also shows if the base language model you used to create your custom
        /// language model has been updated. If Amazon Transcribe has updated the base model,
        /// you can create a new custom language model using the updated base model.
        /// </para>
        ///  
        /// <para>
        /// If you tried to create a new custom language model and the request wasn't successful,
        /// you can use this <c>DescribeLanguageModel</c> to help identify the reason for this
        /// failure.
        /// </para>
        /// </summary>
        public LanguageModel LanguageModel
        {
            get { return this._languageModel; }
            set { this._languageModel = value; }
        }

        // Check to see if LanguageModel property is set
        internal bool IsSetLanguageModel()
        {
            return this._languageModel != null;
        }

    }
}