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
    /// Container for the parameters to the RemoveCustomRoutingEndpoints operation.
    /// Remove endpoints from a custom routing accelerator.
    /// </summary>
    public partial class RemoveCustomRoutingEndpointsRequest : AmazonGlobalAcceleratorRequest
    {
        private string _endpointGroupArn;
        private List<string> _endpointIds = new List<string>();

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group to remove endpoints from.
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
        /// Gets and sets the property EndpointIds. 
        /// <para>
        /// The IDs for the endpoints. For custom routing accelerators, endpoint IDs are the virtual
        /// private cloud (VPC) subnet IDs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> EndpointIds
        {
            get { return this._endpointIds; }
            set { this._endpointIds = value; }
        }

        // Check to see if EndpointIds property is set
        internal bool IsSetEndpointIds()
        {
            return this._endpointIds != null && this._endpointIds.Count > 0; 
        }

    }
}