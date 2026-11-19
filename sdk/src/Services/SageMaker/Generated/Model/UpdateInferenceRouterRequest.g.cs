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
    /// Container for the parameters to the UpdateInferenceRouter operation. Updates the routing
    /// targets of an inference router. The routing targets that you specify replace all of
    /// the router's existing routing targets. To change one routing target, call <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeInferenceRouter.html">DescribeInferenceRouter</a>,
    /// edit the routing targets, and send all of them. <para> The update is applied in full
    /// or not at all, and each request uses either the previous configuration or the new
    /// one. Updates typically take effect within about 2 minutes. </para> <para> If the router
    /// is being created, updated, or deleted, or another request changes it at the same time,
    /// you get a <c>ConflictException</c>. Describe the router, and then send your update
    /// again. </para>
    /// </summary>
    public partial class UpdateInferenceRouterRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property InferenceRouterName. 
        /// <para>
        /// The name of the inference router to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InferenceRouterName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceRouterName property is set.
        /// </summary>
        internal bool IsSetInferenceRouterName() => this.InferenceRouterName != null;

        /// <summary>
        /// Gets and sets the property RoutingTargets. 
        /// <para>
        /// The complete list of routing targets for the inference router. To remove the last
        /// routing target, delete the router.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<RoutingTarget> RoutingTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingTarget>() : null;

        /// <summary>
        /// Checks to see if the RoutingTargets property is set.
        /// </summary>
        internal bool IsSetRoutingTargets() => this.RoutingTargets != null && (this.RoutingTargets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
