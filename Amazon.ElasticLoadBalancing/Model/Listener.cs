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
    ///A listener is a set of protocol, load balancer port, and instance port to which requests are forwarded.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class Listener
    {
        private string protocolField;
        private Decimal? loadBalancerPortField;
        private Decimal? instancePortField;

        /// <summary>
        /// Gets and sets the Protocol property.
        /// The external TCP port of the LoadBalancer. Valid LoadBalancer ports are - 80, 443 and 1024 through 65535.
        /// This property cannot be modified for the life of the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "Protocol")]
        public string Protocol
        {
            get { return this.protocolField; }
            set { this.protocolField = value; }
        }

        /// <summary>
        /// Sets the Protocol property
        /// </summary>
        /// <param name="protocol">The external TCP port of the LoadBalancer. Valid LoadBalancer ports are - 80, 443 and 1024 through 65535.
        /// This property cannot be modified for the life of the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public Listener WithProtocol(string protocol)
        {
            this.protocolField = protocol;
            return this;
        }

        /// <summary>
        /// Checks if Protocol property is set
        /// </summary>
        /// <returns>true if Protocol property is set</returns>
        public bool IsSetProtocol()
        {
            return this.protocolField != null;
        }

        /// <summary>
        /// Gets and sets the LoadBalancerPort property.
        /// The external TCP port of the LoadBalancer. Valid LoadBalancer ports are - 80, 443 and 1024 through 65535.
        /// This property cannot be modified for the life of the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerPort")]
        public Decimal LoadBalancerPort
        {
            get { return this.loadBalancerPortField.GetValueOrDefault(); }
            set { this.loadBalancerPortField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerPort property
        /// </summary>
        /// <param name="loadBalancerPort">The external TCP port of the LoadBalancer. Valid LoadBalancer ports are - 80, 443 and 1024 through 65535.
        /// This property cannot be modified for the life of the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public Listener WithLoadBalancerPort(Decimal loadBalancerPort)
        {
            this.loadBalancerPortField = loadBalancerPort;
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerPort property is set
        /// </summary>
        /// <returns>true if LoadBalancerPort property is set</returns>
        public bool IsSetLoadBalancerPort()
        {
            return this.loadBalancerPortField.HasValue;
        }

        /// <summary>
        /// Gets and sets the InstancePort property.
        /// The InstancePort data type is simple type of type: integer. It is the TCP port on which the server on the
        /// instance is listening. Valid instance ports are one (1) through 65535. This property cannot be modified for
        /// the life of the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstancePort")]
        public Decimal InstancePort
        {
            get { return this.instancePortField.GetValueOrDefault(); }
            set { this.instancePortField = value; }
        }

        /// <summary>
        /// Sets the InstancePort property
        /// </summary>
        /// <param name="instancePort">The InstancePort data type is simple type of type: integer. It is the TCP port on which the server on the
        /// instance is listening. Valid instance ports are one (1) through 65535. This property cannot be modified for
        /// the life of the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public Listener WithInstancePort(Decimal instancePort)
        {
            this.instancePortField = instancePort;
            return this;
        }

        /// <summary>
        /// Checks if InstancePort property is set
        /// </summary>
        /// <returns>true if InstancePort property is set</returns>
        public bool IsSetInstancePort()
        {
            return this.instancePortField.HasValue;
        }

    }
}
