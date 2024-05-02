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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
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
namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// Configuration information for optional message review.
    /// </summary>
    public partial class MessageReviewHandler
    {
        private FallbackResult _fallbackResult;
        private string _uri;

        /// <summary>
        /// Gets and sets the property FallbackResult. 
        /// <para>
        /// Specifies the fallback behavior (whether the message is allowed or denied) if the
        /// handler does not return a valid response, encounters an error, or times out. (For
        /// the timeout period, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/service-quotas.html">
        /// Service Quotas</a>.) If allowed, the message is delivered with returned content to
        /// all users connected to the room. If denied, the message is not delivered to any user.
        /// Default: <c>ALLOW</c>.
        /// </para>
        /// </summary>
        public FallbackResult FallbackResult
        {
            get { return this._fallbackResult; }
            set { this._fallbackResult = value; }
        }

        // Check to see if FallbackResult property is set
        internal bool IsSetFallbackResult()
        {
            return this._fallbackResult != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// Identifier of the message review handler. Currently this must be an ARN of a lambda
        /// function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=170)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}