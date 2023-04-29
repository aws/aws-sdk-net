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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Configuration about the custom classifier associated with the flywheel.
    /// </summary>
    public partial class TaskConfig
    {
        private DocumentClassificationConfig _documentClassificationConfig;
        private EntityRecognitionConfig _entityRecognitionConfig;
        private LanguageCode _languageCode;

        /// <summary>
        /// Gets and sets the property DocumentClassificationConfig. 
        /// <para>
        /// Configuration required for a classification model.
        /// </para>
        /// </summary>
        public DocumentClassificationConfig DocumentClassificationConfig
        {
            get { return this._documentClassificationConfig; }
            set { this._documentClassificationConfig = value; }
        }

        // Check to see if DocumentClassificationConfig property is set
        internal bool IsSetDocumentClassificationConfig()
        {
            return this._documentClassificationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EntityRecognitionConfig. 
        /// <para>
        /// Configuration required for an entity recognition model.
        /// </para>
        /// </summary>
        public EntityRecognitionConfig EntityRecognitionConfig
        {
            get { return this._entityRecognitionConfig; }
            set { this._entityRecognitionConfig = value; }
        }

        // Check to see if EntityRecognitionConfig property is set
        internal bool IsSetEntityRecognitionConfig()
        {
            return this._entityRecognitionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Language code for the language that the model supports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

    }
}