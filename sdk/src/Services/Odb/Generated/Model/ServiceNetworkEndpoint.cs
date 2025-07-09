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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The configuration for a service network endpoint.
    /// </summary>
    public partial class ServiceNetworkEndpoint
    {
        private string _vpcEndpointId;
        private VpcEndpointType _vpcEndpointType;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The identifier of the VPC endpoint.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointType. 
        /// <para>
        /// The type of the VPC endpoint.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>Interface | Gateway</c> 
        /// </para>
        /// </summary>
        public VpcEndpointType VpcEndpointType
        {
            get { return this._vpcEndpointType; }
            set { this._vpcEndpointType = value; }
        }

        // Check to see if VpcEndpointType property is set
        internal bool IsSetVpcEndpointType()
        {
            return this._vpcEndpointType != null;
        }

    }
}