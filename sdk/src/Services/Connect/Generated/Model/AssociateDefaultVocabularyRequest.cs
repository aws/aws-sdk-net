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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateDefaultVocabulary operation.
    /// Associates an existing vocabulary as the default. Contact Lens for Amazon Connect
    /// uses the vocabulary in post-call and real-time analysis sessions for the given language.
    /// </summary>
    public partial class AssociateDefaultVocabularyRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private VocabularyLanguageCode _languageCode;
        private string _vocabularyId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code of the vocabulary entries. For a list of languages and their corresponding
        /// language codes, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/transcribe-whatis.html">What
        /// is Amazon Transcribe?</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VocabularyLanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property VocabularyId. 
        /// <para>
        /// The identifier of the custom vocabulary. If this is empty, the default is set to none.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string VocabularyId
        {
            get { return this._vocabularyId; }
            set { this._vocabularyId = value; }
        }

        // Check to see if VocabularyId property is set
        internal bool IsSetVocabularyId()
        {
            return this._vocabularyId != null;
        }

    }
}