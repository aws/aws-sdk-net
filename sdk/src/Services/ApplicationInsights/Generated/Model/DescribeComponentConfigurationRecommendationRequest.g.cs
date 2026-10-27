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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeComponentConfigurationRecommendation operation.
    /// Describes the recommended monitoring configuration of the component.
    /// </summary>
    public partial class DescribeComponentConfigurationRecommendationRequest : AmazonApplicationInsightsRequest
    {
        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property RecommendationType. 
        /// <para>
        /// The recommended configuration type.
        /// </para>
        /// </summary>
        public RecommendationType RecommendationType { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationType property is set.
        /// </summary>
        internal bool IsSetRecommendationType() => this.RecommendationType != null;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the application component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public Tier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property WorkloadName. 
        /// <para>
        /// The name of the workload. The name of the workload is required when the tier of the
        /// application component is <c>SAP_ASE_SINGLE_NODE</c> or <c>SAP_ASE_HIGH_AVAILABILITY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
