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
    /// Container for the parameters to the GetVocabularyFilter operation.
    /// Provides information about the specified custom vocabulary filter.
    /// 
    ///  
    /// <para>
    /// To view the status of the specified vocabulary filter, check the <code>VocabularyState</code>
    /// field. If the status is <code>READY</code>, your vocabulary is available to use. If
    /// the status is <code>FAILED</code>, <code>FailureReason</code> provides details on
    /// why your vocabulary filter failed.
    /// </para>
    ///  
    /// <para>
    /// To get a list of your custom vocabulary filters, use the operation.
    /// </para>
    /// </summary>
    public partial class GetVocabularyFilterRequest : AmazonTranscribeServiceRequest
    {
        private string _vocabularyFilterName;

        /// <summary>
        /// Gets and sets the property VocabularyFilterName. 
        /// <para>
        /// The name of the custom vocabulary filter you want information about. Vocabulary filter
        /// names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string VocabularyFilterName
        {
            get { return this._vocabularyFilterName; }
            set { this._vocabularyFilterName = value; }
        }

        // Check to see if VocabularyFilterName property is set
        internal bool IsSetVocabularyFilterName()
        {
            return this._vocabularyFilterName != null;
        }

    }
}