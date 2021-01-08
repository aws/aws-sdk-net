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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information that defines how a detector operates.
    /// </summary>
    public partial class DetectorModelDefinition
    {
        private string _initialStateName;
        private List<State> _states = new List<State>();

        /// <summary>
        /// Gets and sets the property InitialStateName. 
        /// <para>
        /// The state that is entered at the creation of each detector (instance).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string InitialStateName
        {
            get { return this._initialStateName; }
            set { this._initialStateName = value; }
        }

        // Check to see if InitialStateName property is set
        internal bool IsSetInitialStateName()
        {
            return this._initialStateName != null;
        }

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// Information about the states of the detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<State> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && this._states.Count > 0; 
        }

    }
}