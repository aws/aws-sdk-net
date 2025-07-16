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
    /// The Lambda configuration for a Model Context Protocol target. This structure defines
    /// how the gateway uses a Lambda function to communicate with the target.
    /// </summary>
    public partial class McpLambdaTargetConfiguration
    {
        private string _lambdaArn;
        private ToolSchema _toolSchema;

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function. This function is invoked by
        /// the gateway to communicate with the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=170)]
        public string LambdaArn
        {
            get { return this._lambdaArn; }
            set { this._lambdaArn = value; }
        }

        // Check to see if LambdaArn property is set
        internal bool IsSetLambdaArn()
        {
            return this._lambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property ToolSchema. 
        /// <para>
        /// The tool schema for the Lambda function. This schema defines the structure of the
        /// tools that the Lambda function provides.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ToolSchema ToolSchema
        {
            get { return this._toolSchema; }
            set { this._toolSchema = value; }
        }

        // Check to see if ToolSchema property is set
        internal bool IsSetToolSchema()
        {
            return this._toolSchema != null;
        }

    }
}