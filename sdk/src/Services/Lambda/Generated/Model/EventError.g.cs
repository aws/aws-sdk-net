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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Error information for an event.
    /// </summary>
    public partial class EventError
    {
        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The error payload.
        /// </para>
        /// </summary>
        public ErrorObject Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property Truncated. 
        /// <para>
        /// Indicates if the error payload was truncated due to size limits.
        /// </para>
        /// </summary>
        public bool? Truncated { get; set; }

        /// <summary>
        /// Checks to see if the Truncated property is set.
        /// </summary>
        internal bool IsSetTruncated() => this.Truncated.HasValue;
    }
}
