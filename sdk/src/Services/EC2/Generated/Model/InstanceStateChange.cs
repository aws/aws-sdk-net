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
    /// Describes an instance state change.
    /// </summary>
    public partial class InstanceStateChange
    {
        private InstanceState _currentState;
        private string _instanceId;
        private InstanceState _previousState;

        /// <summary>
        /// Gets and sets the property CurrentState. 
        /// <para>
        /// The current state of the instance.
        /// </para>
        /// </summary>
        public InstanceState CurrentState
        {
            get { return this._currentState; }
            set { this._currentState = value; }
        }

        // Check to see if CurrentState property is set
        internal bool IsSetCurrentState()
        {
            return this._currentState != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousState. 
        /// <para>
        /// The previous state of the instance.
        /// </para>
        /// </summary>
        public InstanceState PreviousState
        {
            get { return this._previousState; }
            set { this._previousState = value; }
        }

        // Check to see if PreviousState property is set
        internal bool IsSetPreviousState()
        {
            return this._previousState != null;
        }

    }
}