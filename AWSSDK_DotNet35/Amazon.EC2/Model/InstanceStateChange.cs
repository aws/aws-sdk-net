/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Represents a state change for a specific EC2 instance. </para>
    /// </summary>
    public class InstanceStateChange
    {
        
        private string instanceId;
        private InstanceState currentState;
        private InstanceState previousState;


        /// <summary>
        /// The ID of the instance whose state changed.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The current state of the specified instance.
        ///  
        /// </summary>
        public InstanceState CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }

        // Check to see if CurrentState property is set
        internal bool IsSetCurrentState()
        {
            return this.currentState != null;
        }

        /// <summary>
        /// The previous state of the specified instance.
        ///  
        /// </summary>
        public InstanceState PreviousState
        {
            get { return this.previousState; }
            set { this.previousState = value; }
        }

        // Check to see if PreviousState property is set
        internal bool IsSetPreviousState()
        {
            return this.previousState != null;
        }
    }
}
