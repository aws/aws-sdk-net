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
    /// Specifies the format and location of the input data. You must provide either the <c>Annotations</c>
    /// parameter or the <c>EntityList</c> parameter.
    /// </summary>
    public partial class DatasetEntityRecognizerInputDataConfig
    {
        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// The S3 location of the annotation documents for your custom entity recognizer.
        /// </para>
        /// </summary>
        public DatasetEntityRecognizerAnnotations Annotations { get; set; }

        /// <summary>
        /// Checks to see if the Annotations property is set.
        /// </summary>
        internal bool IsSetAnnotations() => this.Annotations != null;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The format and location of the training documents for your custom entity recognizer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetEntityRecognizerDocuments Documents { get; set; }

        /// <summary>
        /// Checks to see if the Documents property is set.
        /// </summary>
        internal bool IsSetDocuments() => this.Documents != null;

        /// <summary>
        /// Gets and sets the property EntityList. 
        /// <para>
        /// The S3 location of the entity list for your custom entity recognizer.
        /// </para>
        /// </summary>
        public DatasetEntityRecognizerEntityList EntityList { get; set; }

        /// <summary>
        /// Checks to see if the EntityList property is set.
        /// </summary>
        internal bool IsSetEntityList() => this.EntityList != null;
    }
}
