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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
        private bool? _canStart11Call;
        private bool? _canVideoCall;
        private bool? _forceTcpCall;

        /// <summary>
        /// Gets and sets the property CanStart11Call. 
        /// <para>
        /// Specifies whether users can start one-to-one calls.
        /// </para>
        /// </summary>
        public bool CanStart11Call
        {
            get { return this._canStart11Call.GetValueOrDefault(); }
            set { this._canStart11Call = value; }
        }

        // Check to see if CanStart11Call property is set
        internal bool IsSetCanStart11Call()
        {
            return this._canStart11Call.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanVideoCall. 
        /// <para>
        /// Specifies whether users can make video calls (as opposed to audio-only calls). Valid
        /// only when audio call(canStart11Call) is enabled.
        /// </para>
        /// </summary>
        public bool CanVideoCall
        {
            get { return this._canVideoCall.GetValueOrDefault(); }
            set { this._canVideoCall = value; }
        }

        // Check to see if CanVideoCall property is set
        internal bool IsSetCanVideoCall()
        {
            return this._canVideoCall.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceTcpCall. 
        /// <para>
        /// When enabled, forces all calls to use TCP protocol instead of UDP for network traversal.
        /// </para>
        /// </summary>
        public bool ForceTcpCall
        {
            get { return this._forceTcpCall.GetValueOrDefault(); }
            set { this._forceTcpCall = value; }
        }

        // Check to see if ForceTcpCall property is set
        internal bool IsSetForceTcpCall()
        {
            return this._forceTcpCall.HasValue; 
        }

    }
}