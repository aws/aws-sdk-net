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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The InstanceState data type. </para>
    /// </summary>
    public class InstanceState
    {
        
        private string instanceId;
        private string state;
        private string reasonCode;
        private string description;

        /// <summary>
        /// Default constructor for a new InstanceState object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public InstanceState() {}
    

        /// <summary>
        /// Provides an EC2 instance ID.
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
        /// Specifies the current state of the instance. Valid value: <c>InService</c>|<c>OutOfService</c>
        ///  
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// Provides information about the cause of <i>OutOfService</i> instances. Specifically, it indicates whether the cause is Elastic Load
        /// Balancing or the instance behind the load balancer. Valid value: <c>ELB</c>|<c>Instance</c>|<c>N/A</c>
        ///  
        /// </summary>
        public string ReasonCode
        {
            get { return this.reasonCode; }
            set { this.reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this.reasonCode != null;
        }

        /// <summary>
        /// Provides a description of the instance state.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
