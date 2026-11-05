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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFunctionEventInvokeConfig operation. Updates
    /// the configuration for asynchronous invocation for a function, version, or alias. <para>
    /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
    /// </para>
    /// </summary>
    public partial class UpdateFunctionEventInvokeConfigRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// A destination for events after they have been sent to a function for processing.
        /// </para>
        ///  
        /// <para>
        ///  <b>Destinations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function</b> - The Amazon Resource Name (ARN) of a Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Queue</b> - The ARN of a standard SQS queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Bucket</b> - The ARN of an Amazon S3 bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Topic</b> - The ARN of a standard SNS topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Event Bus</b> - The ARN of an Amazon EventBridge event bus.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// S3 buckets are supported only for on-failure destinations. To retain records of successful
        /// invocations, use another destination type.
        /// </para>
        ///  </note>
        /// </summary>
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfig property is set.
        /// </summary>
        internal bool IsSetDestinationConfig() => this.DestinationConfig != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function, version, or alias.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> - <c>my-function</c> (name-only), <c>my-function:v1</c> (with
        /// alias).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> - <c>arn:aws:lambda:us-west-2:123456789012:function:my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> - <c>123456789012:function:my-function</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can append a version number or alias to any of the formats. The length constraint
        /// applies only to the full ARN. If you specify only the function name, it is limited
        /// to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property MaximumEventAgeInSeconds. 
        /// <para>
        /// The maximum age of a request that Lambda sends to a function for processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 21600)]
        public int? MaximumEventAgeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaximumEventAgeInSeconds property is set.
        /// </summary>
        internal bool IsSetMaximumEventAgeInSeconds() => this.MaximumEventAgeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumRetryAttempts. 
        /// <para>
        /// The maximum number of times to retry when the function returns an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public int? MaximumRetryAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaximumRetryAttempts property is set.
        /// </summary>
        internal bool IsSetMaximumRetryAttempts() => this.MaximumRetryAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// A version number or alias name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;
    }
}
