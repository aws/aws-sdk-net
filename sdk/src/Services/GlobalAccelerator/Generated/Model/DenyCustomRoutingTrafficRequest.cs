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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the DenyCustomRoutingTraffic operation.
    /// Specify the Amazon EC2 instance (destination) IP addresses and ports for a VPC subnet
    /// endpoint that cannot receive traffic for a custom routing accelerator. You can deny
    /// traffic to all destinations in the VPC endpoint, or deny traffic to a specified list
    /// of destination IP addresses and ports. Note that you cannot specify IP addresses or
    /// ports outside of the range that you configured for the endpoint group.
    /// 
    ///  
    /// <para>
    /// After you make changes, you can verify that the updates are complete by checking the
    /// status of your accelerator: the status changes from IN_PROGRESS to DEPLOYED.
    /// </para>
    /// </summary>
    public partial class DenyCustomRoutingTrafficRequest : AmazonGlobalAcceleratorRequest
    {
        private bool? _denyAllTrafficToEndpoint;
        private List<string> _destinationAddresses = new List<string>();
        private List<int> _destinationPorts = new List<int>();
        private string _endpointGroupArn;
        private string _endpointId;

        /// <summary>
        /// Gets and sets the property DenyAllTrafficToEndpoint. 
        /// <para>
        /// Indicates whether all destination IP addresses and ports for a specified VPC subnet
        /// endpoint <i>cannot</i> receive traffic from a custom routing accelerator. The value
        /// is TRUE or FALSE. 
        /// </para>
        ///  
        /// <para>
        /// When set to TRUE, <i>no</i> destinations in the custom routing VPC subnet can receive
        /// traffic. Note that you cannot specify destination IP addresses and ports when the
        /// value is set to TRUE.
        /// </para>
        ///  
        /// <para>
        /// When set to FALSE (or not specified), you <i>must</i> specify a list of destination
        /// IP addresses that cannot receive traffic. A list of ports is optional. If you don't
        /// specify a list of ports, the ports that can accept traffic is the same as the ports
        /// configured for the endpoint group.
        /// </para>
        ///  
        /// <para>
        /// The default value is FALSE.
        /// </para>
        /// </summary>
        public bool DenyAllTrafficToEndpoint
        {
            get { return this._denyAllTrafficToEndpoint.GetValueOrDefault(); }
            set { this._denyAllTrafficToEndpoint = value; }
        }

        // Check to see if DenyAllTrafficToEndpoint property is set
        internal bool IsSetDenyAllTrafficToEndpoint()
        {
            return this._denyAllTrafficToEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationAddresses. 
        /// <para>
        /// A list of specific Amazon EC2 instance IP addresses (destination addresses) in a subnet
        /// that you want to prevent from receiving traffic. The IP addresses must be a subset
        /// of the IP addresses allowed for the VPC subnet associated with the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> DestinationAddresses
        {
            get { return this._destinationAddresses; }
            set { this._destinationAddresses = value; }
        }

        // Check to see if DestinationAddresses property is set
        internal bool IsSetDestinationAddresses()
        {
            return this._destinationAddresses != null && this._destinationAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// A list of specific Amazon EC2 instance ports (destination ports) in a subnet endpoint
        /// that you want to prevent from receiving traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<int> DestinationPorts
        {
            get { return this._destinationPorts; }
            set { this._destinationPorts = value; }
        }

        // Check to see if DestinationPorts property is set
        internal bool IsSetDestinationPorts()
        {
            return this._destinationPorts != null && this._destinationPorts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string EndpointGroupArn
        {
            get { return this._endpointGroupArn; }
            set { this._endpointGroupArn = value; }
        }

        // Check to see if EndpointGroupArn property is set
        internal bool IsSetEndpointGroupArn()
        {
            return this._endpointGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// An ID for the endpoint. For custom routing accelerators, this is the virtual private
        /// cloud (VPC) subnet ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

    }
}