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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information that defines a state of a detector.
    /// </summary>
    public partial class State
    {
        private OnEnterLifecycle _onEnter;
        private OnExitLifecycle _onExit;
        private OnInputLifecycle _onInput;
        private string _stateName;

        /// <summary>
        /// Gets and sets the property OnEnter. 
        /// <para>
        /// When entering this state, perform these <c>actions</c> if the <c>condition</c> is
        /// TRUE.
        /// </para>
        /// </summary>
        public OnEnterLifecycle OnEnter
        {
            get { return this._onEnter; }
            set { this._onEnter = value; }
        }

        // Check to see if OnEnter property is set
        internal bool IsSetOnEnter()
        {
            return this._onEnter != null;
        }

        /// <summary>
        /// Gets and sets the property OnExit. 
        /// <para>
        /// When exiting this state, perform these <c>actions</c> if the specified <c>condition</c>
        /// is <c>TRUE</c>.
        /// </para>
        /// </summary>
        public OnExitLifecycle OnExit
        {
            get { return this._onExit; }
            set { this._onExit = value; }
        }

        // Check to see if OnExit property is set
        internal bool IsSetOnExit()
        {
            return this._onExit != null;
        }

        /// <summary>
        /// Gets and sets the property OnInput. 
        /// <para>
        /// When an input is received and the <c>condition</c> is TRUE, perform the specified
        /// <c>actions</c>.
        /// </para>
        /// </summary>
        public OnInputLifecycle OnInput
        {
            get { return this._onInput; }
            set { this._onInput = value; }
        }

        // Check to see if OnInput property is set
        internal bool IsSetOnInput()
        {
            return this._onInput != null;
        }

        /// <summary>
        /// Gets and sets the property StateName. 
        /// <para>
        /// The name of the state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StateName
        {
            get { return this._stateName; }
            set { this._stateName = value; }
        }

        // Check to see if StateName property is set
        internal bool IsSetStateName()
        {
            return this._stateName != null;
        }

    }
}