/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Information about the state of an EC2 instance.
    /// </summary>
    public partial class InstanceState
    {
        private string _description;
        private string _instanceId;
        private string _reasonCode;
        private string _state;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InstanceState() { }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the instance state. This string can contain one or more of the following
        /// messages.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>N/A</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>A transient error occurred. Please try again later.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance has failed at least the UnhealthyThreshold number of health checks
        /// consecutively.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance has not passed the configured HealthyThreshold number of health checks
        /// consecutively.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance registration is still in progress.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance is in the EC2 Availability Zone for which LoadBalancer is not configured
        /// to route traffic to.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance is not currently registered with the LoadBalancer.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance deregistration currently in progress.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Disable Availability Zone is currently in progress.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance is in pending state.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance is in stopped state.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Instance is in terminated state.</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
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
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// Information about the cause of <code>OutOfService</code> instances. Specifically,
        /// whether the cause is Elastic Load Balancing or the instance.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>ELB</code> | <code>Instance</code> | <code>N/A</code> 
        /// </para>
        /// </summary>
        public string ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the instance.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>InService</code> | <code>OutOfService</code> | <code>Unknown</code>
        /// 
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}