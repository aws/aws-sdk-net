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
    /// A destination for events that were processed successfully.
    /// 
    ///  
    /// <para>
    /// To retain records of successful <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations">asynchronous
    /// invocations</a>, you can configure an Amazon SNS topic, Amazon SQS queue, Lambda function,
    /// or Amazon EventBridge event bus as the destination.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>OnSuccess</c> is not supported in <c>CreateEventSourceMapping</c> or <c>UpdateEventSourceMapping</c>
    /// requests.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class OnSuccess
    {
        private string _destination;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=350)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

    }
}