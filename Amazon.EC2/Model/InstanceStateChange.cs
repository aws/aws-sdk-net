/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Instance state change
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceStateChange
    {    
        private string instanceIdField;
        private InstanceState currentStateField;
        private InstanceState previousStateField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// Instance ID
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">Instance ID</param>
        /// <returns>this instance</returns>
        public InstanceStateChange WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Gets and sets the CurrentState property.
        /// Current state
        /// </summary>
        [XmlElementAttribute(ElementName = "CurrentState")]
        public InstanceState CurrentState
        {
            get { return this.currentStateField; }
            set { this.currentStateField = value; }
        }

        /// <summary>
        /// Sets the CurrentState property
        /// </summary>
        /// <param name="currentState">Current state</param>
        /// <returns>this instance</returns>
        public InstanceStateChange WithCurrentState(InstanceState currentState)
        {
            this.currentStateField = currentState;
            return this;
        }

        /// <summary>
        /// Checks if CurrentState property is set
        /// </summary>
        /// <returns>true if CurrentState property is set</returns>
        public bool IsSetCurrentState()
        {
            return this.currentStateField != null;
        }

        /// <summary>
        /// Gets and sets the PreviousState property.
        /// Previous state
        /// </summary>
        [XmlElementAttribute(ElementName = "PreviousState")]
        public InstanceState PreviousState
        {
            get { return this.previousStateField; }
            set { this.previousStateField = value; }
        }

        /// <summary>
        /// Sets the PreviousState property
        /// </summary>
        /// <param name="previousState">Previous state</param>
        /// <returns>this instance</returns>
        public InstanceStateChange WithPreviousState(InstanceState previousState)
        {
            this.previousStateField = previousState;
            return this;
        }

        /// <summary>
        /// Checks if PreviousState property is set
        /// </summary>
        /// <returns>true if PreviousState property is set</returns>
        public bool IsSetPreviousState()
        {
            return this.previousStateField != null;
        }

    }
}
