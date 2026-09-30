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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Defines the calling feature permissions and settings for users in a security group,
    /// controlling what types of calls users can initiate and participate in.
    /// </summary>
    public partial class CallingSettings
    {
        /// <summary>
        /// Gets and sets the property CanStart11Call. 
        /// <para>
        /// Specifies whether users can start one-to-one calls.
        /// </para>
        /// </summary>
        public bool? CanStart11Call { get; set; }

        /// <summary>
        /// Checks to see if the CanStart11Call property is set.
        /// </summary>
        internal bool IsSetCanStart11Call() => this.CanStart11Call.HasValue;

        /// <summary>
        /// Gets and sets the property CanVideoCall. 
        /// <para>
        /// Specifies whether users can make video calls (as opposed to audio-only calls). Valid
        /// only when audio call(canStart11Call) is enabled.
        /// </para>
        /// </summary>
        public bool? CanVideoCall { get; set; }

        /// <summary>
        /// Checks to see if the CanVideoCall property is set.
        /// </summary>
        internal bool IsSetCanVideoCall() => this.CanVideoCall.HasValue;

        /// <summary>
        /// Gets and sets the property ForceTcpCall. 
        /// <para>
        /// When enabled, forces all calls to use TCP protocol instead of UDP for network traversal.
        /// </para>
        /// </summary>
        public bool? ForceTcpCall { get; set; }

        /// <summary>
        /// Checks to see if the ForceTcpCall property is set.
        /// </summary>
        internal bool IsSetForceTcpCall() => this.ForceTcpCall.HasValue;
    }
}
