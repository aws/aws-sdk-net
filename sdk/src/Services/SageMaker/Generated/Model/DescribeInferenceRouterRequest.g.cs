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
    /// Container for the parameters to the DescribeInferenceRouter operation. Returns information
    /// about an inference router, including the routing status of each destination. <para>
    /// SageMaker AI checks each destination with your permissions when you call this operation,
    /// so callers with different permissions can see a different <c>RoutingStatus</c>. To
    /// get the router's tags, use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListTags.html">ListTags</a>.
    /// </para>
    /// </summary>
    public partial class DescribeInferenceRouterRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property InferenceRouterName. 
        /// <para>
        /// The name of the inference router to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InferenceRouterName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceRouterName property is set.
        /// </summary>
        internal bool IsSetInferenceRouterName() => this.InferenceRouterName != null;
    }
}
