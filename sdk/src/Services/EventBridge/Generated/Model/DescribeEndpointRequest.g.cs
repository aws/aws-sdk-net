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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEndpoint operation. Get the information
    /// about an existing global endpoint. For more information about global endpoints, see
    /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-global-endpoints.html">Making
    /// applications Regional-fault tolerant with global endpoints and event replication</a>
    /// in the <i> <i>Amazon EventBridge User Guide</i> </i>.
    /// </summary>
    public partial class DescribeEndpointRequest : AmazonEventBridgeRequest
    {
        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// The primary Region of the endpoint you want to get information about. For example
        /// <c>"HomeRegion": "us-east-1"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 20)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the endpoint you want to get information about. For example, <c>"Name":"us-east-2-custom_bus_A-endpoint"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
