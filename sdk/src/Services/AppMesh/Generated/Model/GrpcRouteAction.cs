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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the action to take if a match is determined.
    /// </summary>
    public partial class GrpcRouteAction
    {
        private List<WeightedTarget> _weightedTargets = new List<WeightedTarget>();

        /// <summary>
        /// Gets and sets the property WeightedTargets. 
        /// <para>
        /// An object that represents the targets that traffic is routed to when a request matches
        /// the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<WeightedTarget> WeightedTargets
        {
            get { return this._weightedTargets; }
            set { this._weightedTargets = value; }
        }

        // Check to see if WeightedTargets property is set
        internal bool IsSetWeightedTargets()
        {
            return this._weightedTargets != null && this._weightedTargets.Count > 0; 
        }

    }
}