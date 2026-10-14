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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about a Lambda function that successfully terminated during an execution.
    /// </summary>
    public partial class LambdaFunctionSucceededEventDetails
    {
        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The JSON data output by the Lambda function. Length constraints apply to the payload
        /// size, and are expressed as bytes in UTF-8 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 262144)]
        public string Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property OutputDetails. 
        /// <para>
        /// Contains details about the output of an execution history event.
        /// </para>
        /// </summary>
        public HistoryEventExecutionDataDetails OutputDetails { get; set; }

        /// <summary>
        /// Checks to see if the OutputDetails property is set.
        /// </summary>
        internal bool IsSetOutputDetails() => this.OutputDetails != null;
    }
}
