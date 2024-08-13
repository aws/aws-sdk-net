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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// A custom processing step for documents moving through a data source ingestion pipeline.
    /// To process documents after they have been converted into chunks, set the step to apply
    /// to <c>POST_CHUNKING</c>.
    /// </summary>
    public partial class Transformation
    {
        private StepType _stepToApply;
        private TransformationFunction _transformationFunction;

        /// <summary>
        /// Gets and sets the property StepToApply. 
        /// <para>
        /// When the service applies the transformation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StepType StepToApply
        {
            get { return this._stepToApply; }
            set { this._stepToApply = value; }
        }

        // Check to see if StepToApply property is set
        internal bool IsSetStepToApply()
        {
            return this._stepToApply != null;
        }

        /// <summary>
        /// Gets and sets the property TransformationFunction. 
        /// <para>
        /// A Lambda function that processes documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationFunction TransformationFunction
        {
            get { return this._transformationFunction; }
            set { this._transformationFunction = value; }
        }

        // Check to see if TransformationFunction property is set
        internal bool IsSetTransformationFunction()
        {
            return this._transformationFunction != null;
        }

    }
}