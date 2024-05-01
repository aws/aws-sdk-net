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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Settings that control how the endpoint routes incoming traffic to the instances that
    /// the endpoint hosts.
    /// </summary>
    public partial class ProductionVariantRoutingConfig
    {
        private RoutingStrategy _routingStrategy;

        /// <summary>
        /// Gets and sets the property RoutingStrategy. 
        /// <para>
        /// Sets how the endpoint routes incoming traffic:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LEAST_OUTSTANDING_REQUESTS</c>: The endpoint routes requests to the specific instances
        /// that have more capacity to process them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANDOM</c>: The endpoint routes each request to a randomly chosen instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingStrategy RoutingStrategy
        {
            get { return this._routingStrategy; }
            set { this._routingStrategy = value; }
        }

        // Check to see if RoutingStrategy property is set
        internal bool IsSetRoutingStrategy()
        {
            return this._routingStrategy != null;
        }

    }
}