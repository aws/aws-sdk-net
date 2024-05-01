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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The ECS service recommendation details.
    /// </summary>
    public partial class EcsService
    {
        private EcsServiceConfiguration _configuration;
        private ResourceCostCalculation _costCalculation;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The ECS service configuration used for recommendations.
        /// </para>
        /// </summary>
        public EcsServiceConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CostCalculation. 
        /// <para>
        /// Cost impact of the recommendation.
        /// </para>
        /// </summary>
        public ResourceCostCalculation CostCalculation
        {
            get { return this._costCalculation; }
            set { this._costCalculation = value; }
        }

        // Check to see if CostCalculation property is set
        internal bool IsSetCostCalculation()
        {
            return this._costCalculation != null;
        }

    }
}