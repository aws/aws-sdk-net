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
    /// A complex type for an endpoint. Specifies information about the endpoint to remove
    /// from the endpoint group.
    /// </summary>
    public partial class EndpointIdentifier
    {
        private bool? _clientIPPreservationEnabled;
        private string _endpointId;

        /// <summary>
        /// Gets and sets the property ClientIPPreservationEnabled. 
        /// <para>
        /// Indicates whether client IP address preservation is enabled for an endpoint. The value
        /// is true or false. 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to true, the client's IP address is preserved in the <c>X-Forwarded-For</c>
        /// request header as traffic travels to applications on the endpoint fronted by the accelerator.
        /// </para>
        /// </summary>
        public bool? ClientIPPreservationEnabled
        {
            get { return this._clientIPPreservationEnabled; }
            set { this._clientIPPreservationEnabled = value; }
        }

        // Check to see if ClientIPPreservationEnabled property is set
        internal bool IsSetClientIPPreservationEnabled()
        {
            return this._clientIPPreservationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// An ID for the endpoint. If the endpoint is a Network Load Balancer or Application
        /// Load Balancer, this is the Amazon Resource Name (ARN) of the resource. If the endpoint
        /// is an Elastic IP address, this is the Elastic IP address allocation ID. For Amazon
        /// EC2 instances, this is the EC2 instance ID. 
        /// </para>
        ///  
        /// <para>
        /// An Application Load Balancer can be either internal or internet-facing.
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