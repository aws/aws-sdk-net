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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An endpoint or inference component that serves a routing target.
    /// </summary>
    public partial class Destination
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint or inference component. The destination
        /// can be in any account, and in any Amazon Web Services Region in the same partition
        /// as the inference router. To use a destination in another account, its owner must allow
        /// your account to invoke it through your router, in an endpoint policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property RoutingStatus. 
        /// <para>
        /// Whether the inference router can send requests to the destination, as checked when
        /// you called <c>DescribeInferenceRouter</c>. This value isn't the destination's own
        /// status. SageMaker AI ignores this field in <c>CreateInferenceRouter</c> and <c>UpdateInferenceRouter</c>
        /// requests.
        /// </para>
        ///  <dl> <dt>Routable</dt> <dd> 
        /// <para>
        /// The destination is serving and the router can send it requests. A routable destination
        /// can still be overloaded.
        /// </para>
        ///  </dd> <dt>Unroutable</dt> <dd> 
        /// <para>
        /// The destination can't serve requests. For example, it's being created or has failed,
        /// or it has no capacity and no way to get any. A destination in your account that doesn't
        /// exist is also <c>Unroutable</c>.
        /// </para>
        ///  </dd> <dt>Unknown</dt> <dd> 
        /// <para>
        /// SageMaker AI couldn't check the destination, for example because you aren't allowed
        /// to describe it or the check timed out. The destination might still be serving.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public RoutingStatus RoutingStatus { get; set; }

        /// <summary>
        /// Checks to see if the RoutingStatus property is set.
        /// </summary>
        internal bool IsSetRoutingStatus() => this.RoutingStatus != null;
    }
}
