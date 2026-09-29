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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the CreateSession operation.
    /// </summary>
    public partial class CreateSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp for when the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionArn property is set.
        /// </summary>
        internal bool IsSetSessionArn() => this.SessionArn != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionStatus. 
        /// <para>
        /// The current status of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionStatus SessionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SessionStatus property is set.
        /// </summary>
        internal bool IsSetSessionStatus() => this.SessionStatus != null;
    }
}
