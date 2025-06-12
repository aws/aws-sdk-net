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
    /// Cost impact of the resource recommendation.
    /// </summary>
    public partial class ResourceCostCalculation
    {
        private ResourcePricing _pricing;
        private List<Usage> _usages = AWSConfigs.InitializeCollections ? new List<Usage>() : null;

        /// <summary>
        /// Gets and sets the property Pricing. 
        /// <para>
        /// Pricing details of the resource recommendation.
        /// </para>
        /// </summary>
        public ResourcePricing Pricing
        {
            get { return this._pricing; }
            set { this._pricing = value; }
        }

        // Check to see if Pricing property is set
        internal bool IsSetPricing()
        {
            return this._pricing != null;
        }

        /// <summary>
        /// Gets and sets the property Usages. 
        /// <para>
        /// Usage details of the resource recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Usage> Usages
        {
            get { return this._usages; }
            set { this._usages = value; }
        }

        // Check to see if Usages property is set
        internal bool IsSetUsages()
        {
            return this._usages != null && (this._usages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}