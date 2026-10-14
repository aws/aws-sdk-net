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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the SendNotifyVoiceMessage operation.
    /// </summary>
    public partial class SendNotifyVoiceMessageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique identifier for the message.
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property ResolvedMessageBody. 
        /// <para>
        /// The message body after template variable substitution has been applied.
        /// </para>
        /// </summary>
        public string ResolvedMessageBody { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedMessageBody property is set.
        /// </summary>
        internal bool IsSetResolvedMessageBody() => this.ResolvedMessageBody != null;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The unique identifier of the template used for the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;
    }
}
