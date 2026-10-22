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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type that contains a <c>Message</c> and a <c>Timestamp</c> value for changes
    /// that you make in the status of an IP address range that you bring to Global Accelerator
    /// through bring your own IP address (BYOIP).
    /// </summary>
    public partial class ByoipCidrEvent
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A string that contains an <c>Event</c> message describing changes that you make in
        /// the status of an IP address range that you bring to Global Accelerator through bring
        /// your own IP address (BYOIP).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// A timestamp for when you make a status change for an IP address range that you bring
        /// to Global Accelerator through bring your own IP address (BYOIP).
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
