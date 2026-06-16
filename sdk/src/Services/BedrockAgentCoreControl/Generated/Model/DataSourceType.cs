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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Source of examples to add to the dataset.
    /// </summary>
    public partial class DataSourceType
    {
        private InlineExamplesSource _inlineExamples;
        private S3Source _s3Source;

        /// <summary>
        /// Gets and sets the property InlineExamples. 
        /// <para>
        ///  Inline examples provided directly in the request body. 
        /// </para>
        /// </summary>
        public InlineExamplesSource InlineExamples
        {
            get { return this._inlineExamples; }
            set { this._inlineExamples = value; }
        }

        // Check to see if InlineExamples property is set
        internal bool IsSetInlineExamples()
        {
            return this._inlineExamples != null;
        }

        /// <summary>
        /// Gets and sets the property S3Source. 
        /// <para>
        ///  Amazon S3 URI pointing to a JSONL file in the customer's bucket. 
        /// </para>
        /// </summary>
        public S3Source S3Source
        {
            get { return this._s3Source; }
            set { this._s3Source = value; }
        }

        // Check to see if S3Source property is set
        internal bool IsSetS3Source()
        {
            return this._s3Source != null;
        }

    }
}