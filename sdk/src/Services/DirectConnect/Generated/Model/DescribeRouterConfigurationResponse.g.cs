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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeRouterConfiguration operation.
    /// </summary>
    public partial class DescribeRouterConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CustomerRouterConfig. 
        /// <para>
        /// The customer router configuration.
        /// </para>
        /// </summary>
        public string CustomerRouterConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomerRouterConfig property is set.
        /// </summary>
        internal bool IsSetCustomerRouterConfig() => this.CustomerRouterConfig != null;

        /// <summary>
        /// Gets and sets the property Router. 
        /// <para>
        /// The details about the router.
        /// </para>
        /// </summary>
        public RouterType Router { get; set; }

        /// <summary>
        /// Checks to see if the Router property is set.
        /// </summary>
        internal bool IsSetRouter() => this.Router != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID assigned to the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceId property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceId() => this.VirtualInterfaceId != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceName. 
        /// <para>
        /// Provides the details about a virtual interface's router.
        /// </para>
        /// </summary>
        public string VirtualInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceName property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceName() => this.VirtualInterfaceName != null;
    }
}
