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
    /// Specifies the format and location of the input data. You must provide either the <code>Annotations</code>
    /// parameter or the <code>EntityList</code> parameter.
    /// </summary>
    public partial class DatasetEntityRecognizerInputDataConfig
    {
        private DatasetEntityRecognizerAnnotations _annotations;
        private DatasetEntityRecognizerDocuments _documents;
        private DatasetEntityRecognizerEntityList _entityList;

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// The S3 location of the annotation documents for your custom entity recognizer.
        /// </para>
        /// </summary>
        public DatasetEntityRecognizerAnnotations Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null;
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The format and location of the training documents for your custom entity recognizer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetEntityRecognizerDocuments Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null;
        }

        /// <summary>
        /// Gets and sets the property EntityList. 
        /// <para>
        /// The S3 location of the entity list for your custom entity recognizer.
        /// </para>
        /// </summary>
        public DatasetEntityRecognizerEntityList EntityList
        {
            get { return this._entityList; }
            set { this._entityList = value; }
        }

        // Check to see if EntityList property is set
        internal bool IsSetEntityList()
        {
            return this._entityList != null;
        }

    }
}