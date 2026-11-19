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

namespace Amazon.SageMakerInferenceRouterRuntime.Model
{
    /// <summary>
    /// This is the response object from the InvokeInferenceRouter operation.
    /// </summary>
    public partial class InvokeInferenceRouterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The inference that the model returned.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 6291456)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the inference returned in the response body.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property CustomAttributes. 
        /// <para>
        /// Provides additional information in the response about the inference. This is the value
        /// that the model container of the destination returned, unchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string CustomAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CustomAttributes property is set.
        /// </summary>
        internal bool IsSetCustomAttributes() => this.CustomAttributes != null;

        /// <summary>
        /// Gets and sets the property InvokedProductionVariant. 
        /// <para>
        /// The production variant of the destination endpoint that served the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string InvokedProductionVariant { get; set; }

        /// <summary>
        /// Checks to see if the InvokedProductionVariant property is set.
        /// </summary>
        internal bool IsSetInvokedProductionVariant() => this.InvokedProductionVariant != null;

        /// <summary>
        /// Gets and sets the property InvokedRoutedResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint or inference component that served
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string InvokedRoutedResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the InvokedRoutedResourceArn property is set.
        /// </summary>
        internal bool IsSetInvokedRoutedResourceArn() => this.InvokedRoutedResourceArn != null;

        /// <summary>
        /// Gets and sets the property RoutingReason. 
        /// <para>
        /// The reason that the router chose the destination that served the request. Possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>local-preferred</c> – The destination is a healthy destination in the router's
        /// Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capacity-available</c> – No destination in the router's Region could take the
        /// request, and two or more destinations in other Regions could.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>only-healthy</c> – No destination in the router's Region could take the request,
        /// and exactly one destination in another Region could.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failover</c> – The router moved the request away from destinations in its Region
        /// because they were overloaded or returning errors. You also see this value when the
        /// router can't assess destination health, and when no destination is healthy and the
        /// router tries one anyway.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string RoutingReason { get; set; }

        /// <summary>
        /// Checks to see if the RoutingReason property is set.
        /// </summary>
        internal bool IsSetRoutingReason() => this.RoutingReason != null;
    }
}
