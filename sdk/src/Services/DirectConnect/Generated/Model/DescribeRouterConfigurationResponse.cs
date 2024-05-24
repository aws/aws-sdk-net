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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
        private string _customerRouterConfig;
        private RouterType _router;
        private string _virtualInterfaceId;
        private string _virtualInterfaceName;

        /// <summary>
        /// Gets and sets the property CustomerRouterConfig. 
        /// <para>
        /// The customer router configuration.
        /// </para>
        /// </summary>
        public string CustomerRouterConfig
        {
            get { return this._customerRouterConfig; }
            set { this._customerRouterConfig = value; }
        }

        // Check to see if CustomerRouterConfig property is set
        internal bool IsSetCustomerRouterConfig()
        {
            return this._customerRouterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Router. 
        /// <para>
        /// The details about the router.
        /// </para>
        /// </summary>
        public RouterType Router
        {
            get { return this._router; }
            set { this._router = value; }
        }

        // Check to see if Router property is set
        internal bool IsSetRouter()
        {
            return this._router != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID assigned to the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceName. 
        /// <para>
        /// Provides the details about a virtual interface's router.
        /// </para>
        /// </summary>
        public string VirtualInterfaceName
        {
            get { return this._virtualInterfaceName; }
            set { this._virtualInterfaceName = value; }
        }

        // Check to see if VirtualInterfaceName property is set
        internal bool IsSetVirtualInterfaceName()
        {
            return this._virtualInterfaceName != null;
        }

    }
}