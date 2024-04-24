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
    /// A resource is one of the following: the ARN for an Amazon Web Services resource that
    /// is supported by Global Accelerator to be added as an endpoint, or a CIDR range that
    /// specifies a bring your own IP (BYOIP) address pool.
    /// </summary>
    public partial class Resource
    {
        private string _cidr;
        private string _endpointId;
        private string _region;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// An IP address range, in CIDR format, that is specified as resource. The address must
        /// be provisioned and advertised in Global Accelerator by following the bring your own
        /// IP address (BYOIP) process for Global Accelerator
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// your own IP addresses (BYOIP)</a> in the Global Accelerator Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The endpoint ID for the endpoint that is specified as a Amazon Web Services resource.
        /// 
        /// </para>
        ///  
        /// <para>
        /// An endpoint ID for the cross-account feature is the ARN of an Amazon Web Services
        /// resource, such as a Network Load Balancer, that Global Accelerator supports as an
        /// endpoint for an accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where a shared endpoint resource is located.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}