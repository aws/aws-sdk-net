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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the PutFunctionRecursionConfig operation.
    /// Sets your function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-recursion.html">recursive
    /// loop detection</a> configuration.
    /// 
    ///  
    /// <para>
    /// When you configure a Lambda function to output to the same service or resource that
    /// invokes the function, it's possible to create an infinite recursive loop. For example,
    /// a Lambda function might write a message to an Amazon Simple Queue Service (Amazon
    /// SQS) queue, which then invokes the same function. This invocation causes the function
    /// to write another message to the queue, which in turn invokes the function again.
    /// </para>
    ///  
    /// <para>
    /// Lambda can detect certain types of recursive loops shortly after they occur. When
    /// Lambda detects a recursive loop and your function's recursive loop detection configuration
    /// is set to <c>Terminate</c>, it stops your function being invoked and notifies you.
    /// </para>
    /// </summary>
    public partial class PutFunctionRecursionConfigRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private RecursiveLoop _recursiveLoop;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <c>my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <c>arn:aws:lambda:us-west-2:123456789012:function:my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <c>123456789012:function:my-function</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property RecursiveLoop. 
        /// <para>
        /// If you set your function's recursive loop detection configuration to <c>Allow</c>,
        /// Lambda doesn't take any action when it detects your function being invoked as part
        /// of a recursive loop. We recommend that you only use this setting if your design intentionally
        /// uses a Lambda function to write data back to the same Amazon Web Services resource
        /// that invokes it.
        /// </para>
        ///  
        /// <para>
        /// If you set your function's recursive loop detection configuration to <c>Terminate</c>,
        /// Lambda stops your function being invoked and notifies you when it detects your function
        /// being invoked as part of a recursive loop.
        /// </para>
        ///  
        /// <para>
        /// By default, Lambda sets your function's configuration to <c>Terminate</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your design intentionally uses a Lambda function to write data back to the same
        /// Amazon Web Services resource that invokes the function, then use caution and implement
        /// suitable guard rails to prevent unexpected charges being billed to your Amazon Web
        /// Services account. To learn more about best practices for using recursive invocation
        /// patterns, see <a href="https://serverlessland.com/content/service/lambda/guides/aws-lambda-operator-guide/recursive-runaway">Recursive
        /// patterns that cause run-away Lambda functions</a> in Serverless Land.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecursiveLoop RecursiveLoop
        {
            get { return this._recursiveLoop; }
            set { this._recursiveLoop = value; }
        }

        // Check to see if RecursiveLoop property is set
        internal bool IsSetRecursiveLoop()
        {
            return this._recursiveLoop != null;
        }

    }
}