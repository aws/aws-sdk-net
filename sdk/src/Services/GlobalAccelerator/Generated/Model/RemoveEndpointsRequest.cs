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
    /// Container for the parameters to the RemoveEndpoints operation.
    /// Remove endpoints from an endpoint group. 
    /// 
    ///  
    /// <para>
    /// The <c>RemoveEndpoints</c> API operation is the recommended option for removing endpoints.
    /// The alternative is to remove endpoints by updating an endpoint group by using the
    /// <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_UpdateEndpointGroup.html">UpdateEndpointGroup</a>
    /// API operation. There are two advantages to using <c>AddEndpoints</c> to remove endpoints
    /// instead:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It's more convenient, because you only need to specify the endpoints that you want
    /// to remove. With the <c>UpdateEndpointGroup</c> API operation, you must specify all
    /// of the endpoints in the endpoint group except the ones that you want to remove from
    /// the group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It's faster, because Global Accelerator doesn't need to resolve any endpoints. With
    /// the <c>UpdateEndpointGroup</c> API operation, Global Accelerator must resolve all
    /// of the endpoints that remain in the group.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RemoveEndpointsRequest : AmazonGlobalAcceleratorRequest
    {
        private string _endpointGroupArn;
        private List<EndpointIdentifier> _endpointIdentifiers = AWSConfigs.InitializeCollections ? new List<EndpointIdentifier>() : null;

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

        /// <summary>
        /// Gets and sets the property EndpointIdentifiers. 
        /// <para>
        /// The identifiers of the endpoints that you want to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<EndpointIdentifier> EndpointIdentifiers
        {
            get { return this._endpointIdentifiers; }
            set { this._endpointIdentifiers = value; }
        }

        // Check to see if EndpointIdentifiers property is set
        internal bool IsSetEndpointIdentifiers()
        {
            return this._endpointIdentifiers != null && (this._endpointIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}