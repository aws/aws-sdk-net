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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
    /// Container for the parameters to the BatchUpdateWorkloadEstimateUsage operation.
    /// Update a newly added or existing usage lines. You can update the usage amounts and
    /// usage group based on a usage ID and a Workload estimate ID. 
    /// 
    ///  <note> 
    /// <para>
    /// The <c>BatchUpdateWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
    /// To authorize this operation for Amazon Web Services principals, include the permission
    /// <c>bcm-pricing-calculator:UpdateWorkloadEstimateUsage</c> in your policies.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchUpdateWorkloadEstimateUsageRequest : AmazonBCMPricingCalculatorRequest
    {
        private List<BatchUpdateWorkloadEstimateUsageEntry> _usage = AWSConfigs.InitializeCollections ? new List<BatchUpdateWorkloadEstimateUsageEntry>() : null;
        private string _workloadEstimateId;

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        ///  List of usage line amounts and usage group that you want to update in a Workload
        /// estimate identified by the usage ID. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<BatchUpdateWorkloadEstimateUsageEntry> Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null && (this._usage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadEstimateId. 
        /// <para>
        ///  The ID of the Workload estimate for which you want to modify the usage lines. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WorkloadEstimateId
        {
            get { return this._workloadEstimateId; }
            set { this._workloadEstimateId = value; }
        }

        // Check to see if WorkloadEstimateId property is set
        internal bool IsSetWorkloadEstimateId()
        {
            return this._workloadEstimateId != null;
        }

    }
}