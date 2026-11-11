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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartContactMediaProcessing operation. Enables
    /// in-flight message processing for an ongoing chat session. Message processing will
    /// stay active for the rest of the chat, even if an individual contact segment ends.
    /// </summary>
    public partial class StartContactMediaProcessingRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        ///  The desired behavior for failed message processing. 
        /// </para>
        /// </summary>
        public ContactMediaProcessingFailureMode FailureMode { get; set; }

        /// <summary>
        /// Checks to see if the FailureMode property is set.
        /// </summary>
        internal bool IsSetFailureMode() => this.FailureMode != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ProcessorArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lambda processor. You can find the Amazon Resource
        /// Name of the lambda in the lambda console. 
        /// </para>
        /// </summary>
        public string ProcessorArn { get; set; }

        /// <summary>
        /// Checks to see if the ProcessorArn property is set.
        /// </summary>
        internal bool IsSetProcessorArn() => this.ProcessorArn != null;
    }
}
