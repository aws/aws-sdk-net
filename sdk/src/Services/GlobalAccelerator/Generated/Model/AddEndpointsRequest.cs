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
    /// Container for the parameters to the AddEndpoints operation.
    /// Add endpoints to an endpoint group. The <code>AddEndpoints</code> API operation is
    /// the recommended option for adding endpoints. The alternative options are to add endpoints
    /// when you create an endpoint group (with the <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_CreateEndpointGroup.html">CreateEndpointGroup</a>
    /// API) or when you update an endpoint group (with the <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_UpdateEndpointGroup.html">UpdateEndpointGroup</a>
    /// API). 
    /// 
    ///  
    /// <para>
    /// There are two advantages to using <code>AddEndpoints</code> to add endpoints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It's faster, because Global Accelerator only has to resolve the new endpoints that
    /// you're adding.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It's more convenient, because you don't need to specify all of the current endpoints
    /// that are already in the endpoint group in addition to the new endpoints that you want
    /// to add.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AddEndpointsRequest : AmazonGlobalAcceleratorRequest
    {
        private List<EndpointConfiguration> _endpointConfigurations = new List<EndpointConfiguration>();
        private string _endpointGroupArn;

        /// <summary>
        /// Gets and sets the property EndpointConfigurations. 
        /// <para>
        /// The list of endpoint objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<EndpointConfiguration> EndpointConfigurations
        {
            get { return this._endpointConfigurations; }
            set { this._endpointConfigurations = value; }
        }

        // Check to see if EndpointConfigurations property is set
        internal bool IsSetEndpointConfigurations()
        {
            return this._endpointConfigurations != null && this._endpointConfigurations.Count > 0; 
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

    }
}