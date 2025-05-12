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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains the current state of the canary.
    /// </summary>
    public partial class CanaryStatus
    {
        private CanaryState _state;
        private string _stateReason;
        private CanaryStateReasonCode _stateReasonCode;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the canary.
        /// </para>
        /// </summary>
        public CanaryState State
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
        /// If the canary creation or update failed, this field provides details on the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property StateReasonCode. 
        /// <para>
        /// If the canary creation or update failed, this field displays the reason code.
        /// </para>
        /// </summary>
        public CanaryStateReasonCode StateReasonCode
        {
            get { return this._stateReasonCode; }
            set { this._stateReasonCode = value; }
        }

        // Check to see if StateReasonCode property is set
        internal bool IsSetStateReasonCode()
        {
            return this._stateReasonCode != null;
        }

    }
}