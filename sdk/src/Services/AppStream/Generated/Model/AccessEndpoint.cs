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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes an interface VPC endpoint (interface endpoint) that lets you create a private
    /// connection between the virtual private cloud (VPC) that you specify and AppStream
    /// 2.0. When you specify an interface endpoint for a stack, users of the stack can connect
    /// to AppStream 2.0 only through that endpoint. When you specify an interface endpoint
    /// for an image builder, administrators can connect to the image builder only through
    /// that endpoint.
    /// </summary>
    public partial class AccessEndpoint
    {
        private AccessEndpointType _endpointType;
        private string _vpceId;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of interface endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessEndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property VpceId. 
        /// <para>
        /// The identifier (ID) of the VPC in which the interface endpoint is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string VpceId
        {
            get { return this._vpceId; }
            set { this._vpceId = value; }
        }

        // Check to see if VpceId property is set
        internal bool IsSetVpceId()
        {
            return this._vpceId != null;
        }

    }
}