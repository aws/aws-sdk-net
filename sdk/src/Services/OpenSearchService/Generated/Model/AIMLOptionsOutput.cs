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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for parameters representing the state of machine learning features on the
    /// specified domain.
    /// </summary>
    public partial class AIMLOptionsOutput
    {
        private NaturalLanguageQueryGenerationOptionsOutput _naturalLanguageQueryGenerationOptions;
        private S3VectorsEngine _s3VectorsEngine;

        /// <summary>
        /// Gets and sets the property NaturalLanguageQueryGenerationOptions. 
        /// <para>
        /// Container for parameters required for natural language query generation on the specified
        /// domain.
        /// </para>
        /// </summary>
        public NaturalLanguageQueryGenerationOptionsOutput NaturalLanguageQueryGenerationOptions
        {
            get { return this._naturalLanguageQueryGenerationOptions; }
            set { this._naturalLanguageQueryGenerationOptions = value; }
        }

        // Check to see if NaturalLanguageQueryGenerationOptions property is set
        internal bool IsSetNaturalLanguageQueryGenerationOptions()
        {
            return this._naturalLanguageQueryGenerationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property S3VectorsEngine. 
        /// <para>
        /// Container for parameters representing the state of S3 vectors engine features on the
        /// specified domain.
        /// </para>
        /// </summary>
        public S3VectorsEngine S3VectorsEngine
        {
            get { return this._s3VectorsEngine; }
            set { this._s3VectorsEngine = value; }
        }

        // Check to see if S3VectorsEngine property is set
        internal bool IsSetS3VectorsEngine()
        {
            return this._s3VectorsEngine != null;
        }

    }
}