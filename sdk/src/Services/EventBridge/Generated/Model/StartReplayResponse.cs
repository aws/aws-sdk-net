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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the StartReplay operation.
    /// </summary>
    public partial class StartReplayResponse : AmazonWebServiceResponse
    {
        private string _replayArn;
        private DateTime? _replayStartTime;
        private ReplayState _state;
        private string _stateReason;

        /// <summary>
        /// Gets and sets the property ReplayArn. 
        /// <para>
        /// The ARN of the replay.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ReplayArn
        {
            get { return this._replayArn; }
            set { this._replayArn = value; }
        }

        // Check to see if ReplayArn property is set
        internal bool IsSetReplayArn()
        {
            return this._replayArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplayStartTime. 
        /// <para>
        /// The time at which the replay started.
        /// </para>
        /// </summary>
        public DateTime ReplayStartTime
        {
            get { return this._replayStartTime.GetValueOrDefault(); }
            set { this._replayStartTime = value; }
        }

        // Check to see if ReplayStartTime property is set
        internal bool IsSetReplayStartTime()
        {
            return this._replayStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the replay.
        /// </para>
        /// </summary>
        public ReplayState State
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
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason that the replay is in the state.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

    }
}