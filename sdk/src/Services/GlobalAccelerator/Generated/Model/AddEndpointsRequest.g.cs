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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the AddEndpoints operation. Add endpoints to an endpoint
    /// group. The <c>AddEndpoints</c> API operation is the recommended option for adding
    /// endpoints. The alternative options are to add endpoints when you create an endpoint
    /// group (with the <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_CreateEndpointGroup.html">CreateEndpointGroup</a>
    /// API) or when you update an endpoint group (with the <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/API_UpdateEndpointGroup.html">UpdateEndpointGroup</a>
    /// API). <para> There are two advantages to using <c>AddEndpoints</c> to add endpoints
    /// in Global Accelerator: </para> <ul> <li> <para> It's faster, because Global Accelerator
    /// only has to resolve the new endpoints that you're adding, rather than resolving new
    /// and existing endpoints. </para> </li> <li> <para> It's more convenient, because you
    /// don't need to specify the current endpoints that are already in the endpoint group,
    /// in addition to the new endpoints that you want to add. </para> </li> </ul> <para>
    /// For information about endpoint types and requirements for endpoints that you can add
    /// to Global Accelerator, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/about-endpoints.html">
    /// Endpoints for standard accelerators</a> in the <i>Global Accelerator Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AddEndpointsRequest : AmazonGlobalAcceleratorRequest
    {
        /// <summary>
        /// Gets and sets the property EndpointConfigurations. 
        /// <para>
        /// The list of endpoint objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<EndpointConfiguration> EndpointConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<EndpointConfiguration>() : null;

        /// <summary>
        /// Checks to see if the EndpointConfigurations property is set.
        /// </summary>
        internal bool IsSetEndpointConfigurations() => this.EndpointConfigurations != null && (this.EndpointConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string EndpointGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointGroupArn property is set.
        /// </summary>
        internal bool IsSetEndpointGroupArn() => this.EndpointGroupArn != null;
    }
}
