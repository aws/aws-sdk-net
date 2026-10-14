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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Configuration about the model associated with a flywheel.
    /// </summary>
    public partial class TaskConfig
    {
        /// <summary>
        /// Gets and sets the property DocumentClassificationConfig. 
        /// <para>
        /// Configuration required for a document classification model.
        /// </para>
        /// </summary>
        public DocumentClassificationConfig DocumentClassificationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DocumentClassificationConfig property is set.
        /// </summary>
        internal bool IsSetDocumentClassificationConfig() => this.DocumentClassificationConfig != null;

        /// <summary>
        /// Gets and sets the property EntityRecognitionConfig. 
        /// <para>
        /// Configuration required for an entity recognition model.
        /// </para>
        /// </summary>
        public EntityRecognitionConfig EntityRecognitionConfig { get; set; }

        /// <summary>
        /// Checks to see if the EntityRecognitionConfig property is set.
        /// </summary>
        internal bool IsSetEntityRecognitionConfig() => this.EntityRecognitionConfig != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// Language code for the language that the model supports.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;
    }
}
