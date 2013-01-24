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
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
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

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        public InstanceState WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
        }
            

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;       
        }

        /// <summary>
        /// Specifies the current status of the instance.
        ///  
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        public InstanceState WithState(string state)
        {
            this.state = state;
            return this;
        }
            

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;       
        }

        /// <summary>
        /// Provides information about the cause of <i>OutOfService</i> instances. Specifically, it indicates whether the cause is Elastic Load
        /// Balancing or the instance behind the LoadBalancer.
        ///  
        /// </summary>
        public string ReasonCode
        {
            get { return this.reasonCode; }
            set { this.reasonCode = value; }
        }

        /// <summary>
        /// Sets the ReasonCode property
        /// </summary>
        /// <param name="reasonCode">The value to set for the ReasonCode property </param>
        /// <returns>this instance</returns>
        public InstanceState WithReasonCode(string reasonCode)
        {
            this.reasonCode = reasonCode;
            return this;
        }
            

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this.reasonCode != null;       
        }

        /// <summary>
        /// Provides a description of the instance.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public InstanceState WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }
    }
}
