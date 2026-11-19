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
    /// A model that an inference router serves, and the destinations that can serve it. When
    /// you invoke the router, you name the routing target, and the router sends the request
    /// to one of its destinations.
    /// 
    ///  
    /// <para>
    /// Every destination in a routing target must serve the same model, with the same request
    /// and response format.
    /// </para>
    /// </summary>
    public partial class RoutingTarget
    {
        /// <summary>
        /// Gets and sets the property AsyncInferenceConfig. 
        /// <para>
        /// The asynchronous inference settings of the routing target. Specify this setting to
        /// make the routing target asynchronous. If you omit it, the routing target serves real-time
        /// requests.
        /// </para>
        ///  
        /// <para>
        /// Asynchronous routing targets aren't available in all Amazon Web Services Regions.
        /// For information about asynchronous routing targets and Region availability, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router-async.html">Send
        /// asynchronous requests through an inference router</a>.
        /// </para>
        ///  
        /// <para>
        /// Because <c>UpdateInferenceRouter</c> replaces all routing targets, include this setting
        /// in every update of an asynchronous routing target.
        /// </para>
        ///  
        /// <para>
        /// For information about asynchronous routing targets, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/inference-router-async.html">Send
        /// asynchronous requests through an inference router</a>.
        /// </para>
        /// </summary>
        public RoutingTargetAsyncInferenceConfig AsyncInferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the AsyncInferenceConfig property is set.
        /// </summary>
        internal bool IsSetAsyncInferenceConfig() => this.AsyncInferenceConfig != null;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The endpoints and inference components that serve the routing target. Each destination
        /// can appear only once in a routing target.
        /// </para>
        ///  
        /// <para>
        /// In an asynchronous routing target, every destination must be an asynchronous inference
        /// endpoint. In a real-time routing target, no destination can be one. SageMaker AI checks
        /// an endpoint in another account with your credentials, so both your IAM policy and
        /// the endpoint policy must allow <c>sagemaker:DescribeEndpoint</c>. If an endpoint can't
        /// be checked, for example because it isn't found or can't be read in time, it's accepted,
        /// and requests to it fail if it's the wrong mode.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<Destination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<Destination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the routing target. Callers specify this name in the <c>RoutingTargetName</c>
        /// parameter when they invoke the inference router. The name must be unique within the
        /// router.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoutingPreference. 
        /// <para>
        /// How the inference router chooses among the routing target's destinations. The default
        /// is <c>LocalRegionFirst</c>.
        /// </para>
        ///  <dl> <dt>LocalRegionFirst</dt> <dd> 
        /// <para>
        /// The router uses destinations in its own Region first. When the request leaves the
        /// Region, the router spreads it across healthy destinations in other Regions.
        /// </para>
        ///  </dd> <dt>InstancePoolOrder</dt> <dd> 
        /// <para>
        /// The router prefers destinations by instance type first and by Region second. Every
        /// destination must be an endpoint that lists the same two or more instance types, each
        /// with a different priority, in the same priority order. This value is supported only
        /// for asynchronous routing targets.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// With either value, the router uses destinations whose health or capacity is reduced
        /// after the others, but doesn't exclude them.
        /// </para>
        /// </summary>
        public InferenceRouterRoutingPreference RoutingPreference { get; set; }

        /// <summary>
        /// Checks to see if the RoutingPreference property is set.
        /// </summary>
        internal bool IsSetRoutingPreference() => this.RoutingPreference != null;
    }
}
