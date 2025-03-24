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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Configures settings for the <c>FrozenFrames</c> metric.
    /// </summary>
    public partial class FrozenFrames
    {
        private State _state;
        private int? _thresholdSeconds;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether the <c>FrozenFrames</c> metric is enabled or disabled.
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property ThresholdSeconds. 
        /// <para>
        ///  Specifies the number of consecutive seconds of a static image that triggers an event
        /// or alert.
        /// </para>
        /// </summary>
        public int? ThresholdSeconds
        {
            get { return this._thresholdSeconds; }
            set { this._thresholdSeconds = value; }
        }

        // Check to see if ThresholdSeconds property is set
        internal bool IsSetThresholdSeconds()
        {
            return this._thresholdSeconds.HasValue; 
        }

    }
}