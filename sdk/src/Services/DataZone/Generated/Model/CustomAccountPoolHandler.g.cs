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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The custom Amazon Web Services Lambda handler within an account pool.
    /// </summary>
    public partial class CustomAccountPoolHandler
    {
        /// <summary>
        /// Gets and sets the property LambdaExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that enables Amazon SageMaker Unified Studio to invoke the
        /// Amazon Web Services Lambda funtion if the account source is the custom account pool
        /// handler.
        /// </para>
        /// </summary>
        public string LambdaExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetLambdaExecutionRoleArn() => this.LambdaExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property LambdaFunctionArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Lambda function for the custom Amazon Web Services
        /// Lambda handler.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LambdaFunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunctionArn property is set.
        /// </summary>
        internal bool IsSetLambdaFunctionArn() => this.LambdaFunctionArn != null;
    }
}
