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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The details for the execute command session.
    /// </summary>
    public partial class Session
    {
        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the execute command session.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property StreamUrl. 
        /// <para>
        /// A URL to the managed agent on the container that the SSM Session Manager client uses
        /// to send commands and receive output from the container.
        /// </para>
        /// </summary>
        public string StreamUrl { get; set; }

        /// <summary>
        /// Checks to see if the StreamUrl property is set.
        /// </summary>
        internal bool IsSetStreamUrl() => this.StreamUrl != null;

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// An encrypted token value containing session and caller information. It's used to authenticate
        /// the connection to the container.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string TokenValue { get; set; }

        /// <summary>
        /// Checks to see if the TokenValue property is set.
        /// </summary>
        internal bool IsSetTokenValue() => this.TokenValue != null;
    }
}
