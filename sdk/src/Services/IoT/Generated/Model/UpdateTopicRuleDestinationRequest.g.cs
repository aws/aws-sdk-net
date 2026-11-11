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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTopicRuleDestination operation. Updates
    /// a topic rule destination. You use this to change the status, endpoint URL, or confirmation
    /// URL of the destination. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateTopicRuleDestination</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateTopicRuleDestinationRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the topic rule destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the topic rule destination. Valid values are:
        /// </para>
        ///  <dl> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// A topic rule destination was created but has not been confirmed. You can set <c>status</c>
        /// to <c>IN_PROGRESS</c> by calling <c>UpdateTopicRuleDestination</c>. Calling <c>UpdateTopicRuleDestination</c>
        /// causes a new confirmation challenge to be sent to your confirmation endpoint.
        /// </para>
        ///  </dd> <dt>ENABLED</dt> <dd> 
        /// <para>
        /// Confirmation was completed, and traffic to this destination is allowed. You can set
        /// <c>status</c> to <c>DISABLED</c> by calling <c>UpdateTopicRuleDestination</c>.
        /// </para>
        ///  </dd> <dt>DISABLED</dt> <dd> 
        /// <para>
        /// Confirmation was completed, and traffic to this destination is not allowed. You can
        /// set <c>status</c> to <c>ENABLED</c> by calling <c>UpdateTopicRuleDestination</c>.
        /// </para>
        ///  </dd> <dt>ERROR</dt> <dd> 
        /// <para>
        /// Confirmation could not be completed, for example if the confirmation timed out. You
        /// can call <c>GetTopicRuleDestination</c> for details about the error. You can set <c>status</c>
        /// to <c>IN_PROGRESS</c> by calling <c>UpdateTopicRuleDestination</c>. Calling <c>UpdateTopicRuleDestination</c>
        /// causes a new confirmation challenge to be sent to your confirmation endpoint.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public TopicRuleDestinationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
