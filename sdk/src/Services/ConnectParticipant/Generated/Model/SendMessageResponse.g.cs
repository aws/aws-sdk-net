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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// This is the response object from the SendMessage operation.
    /// </summary>
    public partial class SendMessageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AbsoluteTime. 
        /// <para>
        /// The time when the message was sent.
        /// </para>
        ///  
        /// <para>
        /// It's specified in ISO 8601 format: yyyy-MM-ddThh:mm:ss.SSSZ. For example, 2019-11-08T02:41:28.172Z.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AbsoluteTime { get; set; }

        /// <summary>
        /// Checks to see if the AbsoluteTime property is set.
        /// </summary>
        internal bool IsSetAbsoluteTime() => this.AbsoluteTime != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MessageMetadata. 
        /// <para>
        /// Contains metadata for the message.
        /// </para>
        /// </summary>
        public MessageProcessingMetadata MessageMetadata { get; set; }

        /// <summary>
        /// Checks to see if the MessageMetadata property is set.
        /// </summary>
        internal bool IsSetMessageMetadata() => this.MessageMetadata != null;
    }
}
