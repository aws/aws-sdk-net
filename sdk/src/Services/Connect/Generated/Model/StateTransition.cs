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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the state transition of a supervisor.
    /// </summary>
    public partial class StateTransition
    {
        private ParticipantState _state;
        private DateTime? _stateEndTimestamp;
        private DateTime? _stateStartTimestamp;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transition.
        /// </para>
        /// </summary>
        public ParticipantState State
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
        /// Gets and sets the property StateEndTimestamp. 
        /// <para>
        /// The date and time when the state ended in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StateEndTimestamp
        {
            get { return this._stateEndTimestamp; }
            set { this._stateEndTimestamp = value; }
        }

        // Check to see if StateEndTimestamp property is set
        internal bool IsSetStateEndTimestamp()
        {
            return this._stateEndTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateStartTimestamp. 
        /// <para>
        /// The date and time when the state started in UTC time.
        /// </para>
        /// </summary>
        public DateTime? StateStartTimestamp
        {
            get { return this._stateStartTimestamp; }
            set { this._stateStartTimestamp = value; }
        }

        // Check to see if StateStartTimestamp property is set
        internal bool IsSetStateStartTimestamp()
        {
            return this._stateStartTimestamp.HasValue; 
        }

    }
}