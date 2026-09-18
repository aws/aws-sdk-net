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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a load balancer listener.
    /// </summary>
    public partial class AwsElbLoadBalancerListener
    {
        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        /// The port on which the instance is listening.
        /// </para>
        /// </summary>
        public int? InstancePort { get; set; }

        /// <summary>
        /// Checks to see if the InstancePort property is set.
        /// </summary>
        internal bool IsSetInstancePort() => this.InstancePort.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceProtocol. 
        /// <para>
        /// The protocol to use to route traffic to instances.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>HTTP</c> | <c>HTTPS</c> | <c>TCP</c> | <c>SSL</c> 
        /// </para>
        /// </summary>
        public string InstanceProtocol { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProtocol property is set.
        /// </summary>
        internal bool IsSetInstanceProtocol() => this.InstanceProtocol != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerPort. 
        /// <para>
        /// The port on which the load balancer is listening.
        /// </para>
        ///  
        /// <para>
        /// On EC2-VPC, you can specify any port from the range 1-65535.
        /// </para>
        ///  
        /// <para>
        /// On EC2-Classic, you can specify any port from the following list: 25, 80, 443, 465,
        /// 587, 1024-65535.
        /// </para>
        /// </summary>
        public int? LoadBalancerPort { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerPort property is set.
        /// </summary>
        internal bool IsSetLoadBalancerPort() => this.LoadBalancerPort.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The load balancer transport protocol to use for routing.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>HTTP</c> | <c>HTTPS</c> | <c>TCP</c> | <c>SSL</c> 
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SslCertificateId. 
        /// <para>
        /// The ARN of the server certificate.
        /// </para>
        /// </summary>
        public string SslCertificateId { get; set; }

        /// <summary>
        /// Checks to see if the SslCertificateId property is set.
        /// </summary>
        internal bool IsSetSslCertificateId() => this.SslCertificateId != null;
    }
}
