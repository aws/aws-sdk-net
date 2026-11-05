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
    /// </summary>
    public partial class FunctionEventInvokeConfig
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
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the configuration was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

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
    }
}
