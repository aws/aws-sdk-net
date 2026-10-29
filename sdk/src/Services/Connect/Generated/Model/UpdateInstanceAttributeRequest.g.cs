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
    /// Container for the parameters to the UpdateInstanceAttribute operation. This API is
    /// in preview release for Connect Customer and is subject to change. <para> Updates the
    /// value for the specified attribute type. </para>
    /// </summary>
    public partial class UpdateInstanceAttributeRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The type of attribute.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only allowlisted customers can consume USE_CUSTOM_TTS_VOICES. To access this feature,
        /// contact Amazon Web Services Support for allowlisting.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If you set the attribute type as <c>MESSAGE_STREAMING</c>, you need to update the
        /// Lex bot alias resource based policy to include the <c>lex:RecognizeMessageAsync</c>
        /// action for the connect instance ARN resource.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If you set the attribute type <c>AUTO_MUTE_AGENT_ON_HOLD</c> to <c>true</c>, the system
        /// automatically mutes agents while they're on hold and unmutes them when they resume
        /// the contact. Agents can't change their mute state while on hold.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceAttributeType AttributeType { get; set; }

        /// <summary>
        /// Checks to see if the AttributeType property is set.
        /// </summary>
        internal bool IsSetAttributeType() => this.AttributeType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the attribute. Maximum character limit is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
