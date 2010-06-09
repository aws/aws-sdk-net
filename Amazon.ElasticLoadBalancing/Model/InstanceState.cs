/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    ///<summary>
    ///Describes whether the LoadBalancer is forwarding requests to an instance.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class InstanceState
    {
        private string instanceIdField;
        private string stateField;
        private string reasonCodeField;
        private string descriptionField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// EC2 instance ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField ; }
            set { this.instanceIdField= value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">EC2 instance ID of the instance.</param>
        /// <returns>this instance</returns>
        public InstanceState WithInstanceId(string instanceId)
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
            return  this.instanceIdField != null;
        }

        /// <summary>
        /// Gets and sets the State property.
        /// Current status of the instance. The state can be InService, when traffic is being routed to the instance by the
        /// LoadBalancer or the state can be OutOfService, when traffic is not being routed to the instance by the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField ; }
            set { this.stateField= value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">Current status of the instance. The state can be InService, when traffic is being routed to the instance by the
        /// LoadBalancer or the state can be OutOfService, when traffic is not being routed to the instance by the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public InstanceState WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return  this.stateField != null;
        }

        /// <summary>
        /// Gets and sets the ReasonCode property.
        /// ReasonCode returns a string that provides more information about the cause of OutOfService instances. Specifically, it
        /// indicates whether the cause is Elastic Load Balancing or the instance behind the Load Balancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReasonCode")]
        public string ReasonCode
        {
            get { return this.reasonCodeField ; }
            set { this.reasonCodeField= value; }
        }

        /// <summary>
        /// Sets the ReasonCode property
        /// </summary>
        /// <param name="reasonCode">ReasonCode returns a string that provides more information about the cause of OutOfService instances. Specifically, it
        /// indicates whether the cause is Elastic Load Balancing or the instance behind the Load Balancer.</param>
        /// <returns>this instance</returns>
        public InstanceState WithReasonCode(string reasonCode)
        {
            this.reasonCodeField = reasonCode;
            return this;
        }

        /// <summary>
        /// Checks if ReasonCode property is set
        /// </summary>
        /// <returns>true if ReasonCode property is set</returns>
        public bool IsSetReasonCode()
        {
            return  this.reasonCodeField != null;
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// Possible reasons for an OutOfService state include the following: 1. Health checks to the instance are failing, or at a minimum have consecutively failed the UnhealthyThreshold number of health checks, and therefore is not considered healthy
        /// 2. The registered instance has not consecutively passed the configured HealthyThreshold number of health checks, and therefore is still not yet considered healthy
        /// 3. The LoadBalancer (of the given LoadBalancer name) is not available
        /// 4. The instance has terminated
        /// 5. The instance is in an EC2 Availability Zone that the LoadBalancer has not been configured to route traffic to
        ///
        /// For more information about health checks, please see the HealthCheck data type and the API, ConfigureHealthCheck.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField ; }
            set { this.descriptionField= value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">Possible reasons for an OutOfService state include the following: 1. Health checks to the instance are failing, or at a minimum have consecutively failed the UnhealthyThreshold number of health checks, and therefore is not considered healthy
        /// 2. The registered instance has not consecutively passed the configured HealthyThreshold number of health checks, and therefore is still not yet considered healthy
        /// 3. The LoadBalancer (of the given LoadBalancer name) is not available
        /// 4. The instance has terminated
        /// 5. The instance is in an EC2 Availability Zone that the LoadBalancer has not been configured to route traffic to
        ///
        /// For more information about health checks, please see the HealthCheck data type and the API, ConfigureHealthCheck.</param>
        /// <returns>this instance</returns>
        public InstanceState WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return  this.descriptionField != null;
        }

    }
}
