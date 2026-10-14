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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The action to invoke an Amazon Web Services Lambda function for processing the email.
    /// </summary>
    public partial class InvokeLambdaAction
    {
        /// <summary>
        /// Gets and sets the property ActionFailurePolicy. 
        /// <para>
        /// A policy that states what to do in the case of failure. The action will fail if there
        /// are configuration errors. For example, the Amazon Web Services Lambda function no
        /// longer exists.
        /// </para>
        /// </summary>
        public ActionFailurePolicy ActionFailurePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ActionFailurePolicy property is set.
        /// </summary>
        internal bool IsSetActionFailurePolicy() => this.ActionFailurePolicy != null;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lambda function to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// The invocation type of the Lambda function. Use EVENT for asynchronous invocation
        /// or REQUEST_RESPONSE for synchronous invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LambdaInvocationType InvocationType { get; set; }

        /// <summary>
        /// Checks to see if the InvocationType property is set.
        /// </summary>
        internal bool IsSetInvocationType() => this.InvocationType != null;

        /// <summary>
        /// Gets and sets the property RetryTimeMinutes. 
        /// <para>
        /// The maximum time in minutes that the email processing can be retried if the Lambda
        /// invocation fails. The maximum value is 2160 minutes (36 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2160)]
        public int? RetryTimeMinutes { get; set; }

        /// <summary>
        /// Checks to see if the RetryTimeMinutes property is set.
        /// </summary>
        internal bool IsSetRetryTimeMinutes() => this.RetryTimeMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to use to invoke the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
