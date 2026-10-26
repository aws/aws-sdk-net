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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The Lambda configuration for a Model Context Protocol target. This structure defines
    /// how the gateway uses a Lambda function to communicate with the target.
    /// </summary>
    public partial class McpLambdaTargetConfiguration
    {
        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function. This function is invoked by
        /// the gateway to communicate with the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 170)]
        public string LambdaArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaArn property is set.
        /// </summary>
        internal bool IsSetLambdaArn() => this.LambdaArn != null;

        /// <summary>
        /// Gets and sets the property ToolSchema. 
        /// <para>
        /// The tool schema for the Lambda function. This schema defines the structure of the
        /// tools that the Lambda function provides.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ToolSchema ToolSchema { get; set; }

        /// <summary>
        /// Checks to see if the ToolSchema property is set.
        /// </summary>
        internal bool IsSetToolSchema() => this.ToolSchema != null;
    }
}
