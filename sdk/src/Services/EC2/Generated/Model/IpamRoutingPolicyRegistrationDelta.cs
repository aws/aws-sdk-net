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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains information about a routing policy registration change, including the changes
    /// applied and their publication state.
    /// </summary>
    public partial class IpamRoutingPolicyRegistrationDelta
    {
        private string _deltaId;
        private string _deltaJson;
        private IpamRoutingPolicyRegistrationDeltaState _state;
        private string _stateMessage;

        /// <summary>
        /// Gets and sets the property DeltaId. 
        /// <para>
        /// The unique identifier of the delta.
        /// </para>
        /// </summary>
        public string DeltaId
        {
            get { return this._deltaId; }
            set { this._deltaId = value; }
        }

        // Check to see if DeltaId property is set
        internal bool IsSetDeltaId()
        {
            return this._deltaId != null;
        }

        /// <summary>
        /// Gets and sets the property DeltaJson. 
        /// <para>
        /// The JSON specification describing the changes applied in this delta.
        /// </para>
        /// </summary>
        public string DeltaJson
        {
            get { return this._deltaJson; }
            set { this._deltaJson = value; }
        }

        // Check to see if DeltaJson property is set
        internal bool IsSetDeltaJson()
        {
            return this._deltaJson != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the delta. Valid values: <c>pending</c> | <c>published</c> | <c>failed</c>.
        /// </para>
        /// </summary>
        public IpamRoutingPolicyRegistrationDeltaState State
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
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message describing the current state, including error information if the delta failed.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

    }
}