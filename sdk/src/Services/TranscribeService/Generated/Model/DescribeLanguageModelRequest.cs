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
    /// Container for the parameters to the DescribeLanguageModel operation.
    /// Provides information about the specified custom language model.
    /// 
    ///  
    /// <para>
    /// This operation also shows if the base language model that you used to create your
    /// custom language model has been updated. If Amazon Transcribe has updated the base
    /// model, you can create a new custom language model using the updated base model.
    /// </para>
    ///  
    /// <para>
    /// If you tried to create a new custom language model and the request wasn't successful,
    /// you can use <code>DescribeLanguageModel</code> to help identify the reason for this
    /// failure.
    /// </para>
    /// </summary>
    public partial class DescribeLanguageModelRequest : AmazonTranscribeServiceRequest
    {
        private string _modelName;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the custom language model you want information about. Model names are
        /// case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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

    }
}