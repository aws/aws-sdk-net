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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the access type and endpoint for a WorkSpace.
    /// </summary>
    public partial class AccessEndpoint
    {
        private AccessEndpointType _accessEndpointType;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property AccessEndpointType. 
        /// <para>
        /// Indicates the type of access endpoint.
        /// </para>
        /// </summary>
        public AccessEndpointType AccessEndpointType
        {
            get { return this._accessEndpointType; }
            set { this._accessEndpointType = value; }
        }

        // Check to see if AccessEndpointType property is set
        internal bool IsSetAccessEndpointType()
        {
            return this._accessEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// Indicates the VPC endpoint to use for access.
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

    }
}