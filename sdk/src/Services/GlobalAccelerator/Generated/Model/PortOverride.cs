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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Override specific listener ports used to route traffic to endpoints that are part
    /// of an endpoint group. For example, you can create a port override in which the listener
    /// receives user traffic on ports 80 and 443, but your accelerator routes that traffic
    /// to ports 1080 and 1443, respectively, on the endpoints.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/about-endpoint-groups-port-override.html">
    /// Overriding listener ports</a> in the <i>Global Accelerator Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PortOverride
    {
        private int? _endpointPort;
        private int? _listenerPort;

        /// <summary>
        /// Gets and sets the property EndpointPort. 
        /// <para>
        /// The endpoint port that you want a listener port to be mapped to. This is the port
        /// on the endpoint, such as the Application Load Balancer or Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? EndpointPort
        {
            get { return this._endpointPort; }
            set { this._endpointPort = value; }
        }

        // Check to see if EndpointPort property is set
        internal bool IsSetEndpointPort()
        {
            return this._endpointPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListenerPort. 
        /// <para>
        /// The listener port that you want to map to a specific endpoint port. This is the port
        /// that user traffic arrives to the Global Accelerator on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? ListenerPort
        {
            get { return this._listenerPort; }
            set { this._listenerPort = value; }
        }

        // Check to see if ListenerPort property is set
        internal bool IsSetListenerPort()
        {
            return this._listenerPort.HasValue; 
        }

    }
}