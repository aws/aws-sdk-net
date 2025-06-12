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
    /// Container for the parameters to the AllowCustomRoutingTraffic operation.
    /// Specify the Amazon EC2 instance (destination) IP addresses and ports for a VPC subnet
    /// endpoint that can receive traffic for a custom routing accelerator. You can allow
    /// traffic to all destinations in the subnet endpoint, or allow traffic to a specified
    /// list of destination IP addresses and ports in the subnet. Note that you cannot specify
    /// IP addresses or ports outside of the range that you configured for the endpoint group.
    /// 
    ///  
    /// <para>
    /// After you make changes, you can verify that the updates are complete by checking the
    /// status of your accelerator: the status changes from IN_PROGRESS to DEPLOYED.
    /// </para>
    /// </summary>
    public partial class AllowCustomRoutingTrafficRequest : AmazonGlobalAcceleratorRequest
    {
        private bool? _allowAllTrafficToEndpoint;
        private List<string> _destinationAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<int> _destinationPorts = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _endpointGroupArn;
        private string _endpointId;

        /// <summary>
        /// Gets and sets the property AllowAllTrafficToEndpoint. 
        /// <para>
        /// Indicates whether all destination IP addresses and ports for a specified VPC subnet
        /// endpoint can receive traffic from a custom routing accelerator. The value is TRUE
        /// or FALSE. 
        /// </para>
        ///  
        /// <para>
        /// When set to TRUE, <i>all</i> destinations in the custom routing VPC subnet can receive
        /// traffic. Note that you cannot specify destination IP addresses and ports when the
        /// value is set to TRUE.
        /// </para>
        ///  
        /// <para>
        /// When set to FALSE (or not specified), you <i>must</i> specify a list of destination
        /// IP addresses that are allowed to receive traffic. A list of ports is optional. If
        /// you don't specify a list of ports, the ports that can accept traffic is the same as
        /// the ports configured for the endpoint group.
        /// </para>
        ///  
        /// <para>
        /// The default value is FALSE.
        /// </para>
        /// </summary>
        public bool? AllowAllTrafficToEndpoint
        {
            get { return this._allowAllTrafficToEndpoint; }
            set { this._allowAllTrafficToEndpoint = value; }
        }

        // Check to see if AllowAllTrafficToEndpoint property is set
        internal bool IsSetAllowAllTrafficToEndpoint()
        {
            return this._allowAllTrafficToEndpoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationAddresses. 
        /// <para>
        /// A list of specific Amazon EC2 instance IP addresses (destination addresses) in a subnet
        /// that you want to allow to receive traffic. The IP addresses must be a subset of the
        /// IP addresses that you specified for the endpoint group.
        /// </para>
        ///  
        /// <para>
        ///  <c>DestinationAddresses</c> is required if <c>AllowAllTrafficToEndpoint</c> is <c>FALSE</c>
        /// or is not specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._destinationAddresses != null && (this._destinationAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// A list of specific Amazon EC2 instance ports (destination ports) that you want to
        /// allow to receive traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._destinationPorts != null && (this._destinationPorts.Count > 0 || !AWSConfigs.InitializeCollections); 
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