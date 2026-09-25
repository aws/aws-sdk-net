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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Describes a condition that was detected in the Face Liveness video and that contributed
    /// to the confidence score returned for the session.
    /// </summary>
    public partial class FeedbackItem
    {
        private FeedbackCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A code identifying the condition that was detected during the Face Liveness session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeedbackCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable description of the detected condition, suitable for displaying to
        /// an end user before they retry a Face Liveness check. Use <c>Code</c> rather than this
        /// message for programmatic decisions, because the message text can change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}