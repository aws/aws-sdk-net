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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Provides a description of a processor that is used to preprocess the records in the
    /// stream before being processed by your application code. Currently, the only input
    /// processor available is <a href="https://docs.aws.amazon.com/lambda/">AWS Lambda</a>.
    /// </summary>
    public partial class InputProcessingConfiguration
    {
        /// <summary>
        /// Gets and sets the property InputLambdaProcessor. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputLambdaProcessor.html">InputLambdaProcessor</a>
        /// that is used to preprocess the records in the stream before being processed by your
        /// application code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputLambdaProcessor InputLambdaProcessor { get; set; }

        /// <summary>
        /// Checks to see if the InputLambdaProcessor property is set.
        /// </summary>
        internal bool IsSetInputLambdaProcessor() => this.InputLambdaProcessor != null;
    }
}
