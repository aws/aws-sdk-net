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
    /// Container for the parameters to the GetVocabulary operation.
    /// Provides information about the specified custom vocabulary.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified custom vocabulary, check the <code>VocabularyState</code>
    /// field. If the status is <code>READY</code>, your custom vocabulary is available to
    /// use. If the status is <code>FAILED</code>, <code>FailureReason</code> provides details
    /// on why your custom vocabulary failed.
    /// </para>
    ///  
    /// <para>
    /// To get a list of your custom vocabularies, use the operation.
    /// </para>
    /// </summary>
    public partial class GetVocabularyRequest : AmazonTranscribeServiceRequest
    {
        private string _vocabularyName;

        /// <summary>
        /// Gets and sets the property VocabularyName. 
        /// <para>
        /// The name of the custom vocabulary you want information about. Custom vocabulary names
        /// are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string VocabularyName
        {
            get { return this._vocabularyName; }
            set { this._vocabularyName = value; }
        }

        // Check to see if VocabularyName property is set
        internal bool IsSetVocabularyName()
        {
            return this._vocabularyName != null;
        }

    }
}