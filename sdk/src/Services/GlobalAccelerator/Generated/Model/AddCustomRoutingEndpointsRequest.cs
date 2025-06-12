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
    /// Container for the parameters to the AddCustomRoutingEndpoints operation.
    /// Associate a virtual private cloud (VPC) subnet endpoint with your custom routing accelerator.
    /// 
    ///  
    /// <para>
    /// The listener port range must be large enough to support the number of IP addresses
    /// that can be specified in your subnet. The number of ports required is: subnet size
    /// times the number of ports per destination EC2 instances. For example, a subnet defined
    /// as /24 requires a listener port range of at least 255 ports. 
    /// </para>
    ///  
    /// <para>
    /// Note: You must have enough remaining listener ports available to map to the subnet
    /// ports, or the call will fail with a LimitExceededException.
    /// </para>
    ///  
    /// <para>
    /// By default, all destinations in a subnet in a custom routing accelerator cannot receive
    /// traffic. To enable all destinations to receive traffic, or to specify individual port
    /// mappings that can receive traffic, see the <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_AllowCustomRoutingTraffic.html">
    /// AllowCustomRoutingTraffic</a> operation.
    /// </para>
    /// </summary>
    public partial class AddCustomRoutingEndpointsRequest : AmazonGlobalAcceleratorRequest
    {
        private List<CustomRoutingEndpointConfiguration> _endpointConfigurations = AWSConfigs.InitializeCollections ? new List<CustomRoutingEndpointConfiguration>() : null;
        private string _endpointGroupArn;

        /// <summary>
        /// Gets and sets the property EndpointConfigurations. 
        /// <para>
        /// The list of endpoint objects to add to a custom routing accelerator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<CustomRoutingEndpointConfiguration> EndpointConfigurations
        {
            get { return this._endpointConfigurations; }
            set { this._endpointConfigurations = value; }
        }

        // Check to see if EndpointConfigurations property is set
        internal bool IsSetEndpointConfigurations()
        {
            return this._endpointConfigurations != null && (this._endpointConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group for the custom routing endpoint.
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

    }
}