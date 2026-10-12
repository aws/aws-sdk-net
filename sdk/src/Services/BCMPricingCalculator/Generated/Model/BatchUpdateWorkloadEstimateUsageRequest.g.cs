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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateWorkloadEstimateUsage operation. Update
    /// a newly added or existing usage lines. You can update the usage amounts and usage
    /// group based on a usage ID and a Workload estimate ID. <note> <para> The <c>BatchUpdateWorkloadEstimateUsage</c>
    /// operation doesn't have its own IAM permission. To authorize this operation for Amazon
    /// Web Services principals, include the permission <c>bcm-pricing-calculator:UpdateWorkloadEstimateUsage</c>
    /// in your policies. </para> </note>
    /// </summary>
    public partial class BatchUpdateWorkloadEstimateUsageRequest : AmazonBCMPricingCalculatorRequest
    {
        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        ///  List of usage line amounts and usage group that you want to update in a Workload
        /// estimate identified by the usage ID. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public List<BatchUpdateWorkloadEstimateUsageEntry> Usage { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchUpdateWorkloadEstimateUsageEntry>() : null;

        /// <summary>
        /// Checks to see if the Usage property is set.
        /// </summary>
        internal bool IsSetUsage() => this.Usage != null && (this.Usage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkloadEstimateId. 
        /// <para>
        ///  The ID of the Workload estimate for which you want to modify the usage lines. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string WorkloadEstimateId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadEstimateId property is set.
        /// </summary>
        internal bool IsSetWorkloadEstimateId() => this.WorkloadEstimateId != null;
    }
}
