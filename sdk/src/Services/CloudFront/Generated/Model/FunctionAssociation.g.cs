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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A CloudFront function that is associated with a cache behavior in a CloudFront distribution.
    /// </summary>
    public partial class FunctionAssociation
    {
        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The event type of the function, either <c>viewer-request</c> or <c>viewer-response</c>.
        /// You cannot use origin-facing event types (<c>origin-request</c> and <c>origin-response</c>)
        /// with a CloudFront function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property FunctionARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 108)]
        public string FunctionARN { get; set; }

        /// <summary>
        /// Checks to see if the FunctionARN property is set.
        /// </summary>
        internal bool IsSetFunctionARN() => this.FunctionARN != null;
    }
}
