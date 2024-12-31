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
    /// Container for the parameters to the BatchDeleteWorkloadEstimateUsage operation.
    /// Delete usage that you have created in a Workload estimate. You can only delete usage
    /// that you had added and cannot model deletion (or removal) of a existing usage. If
    /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateWorkloadEstimateUsage.html">
    /// BatchUpdateWorkloadEstimateUsage</a>.
    /// </summary>
    public partial class BatchDeleteWorkloadEstimateUsageRequest : AmazonBCMPricingCalculatorRequest
    {
        private List<string> _ids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workloadEstimateId;

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        ///  List of usage that you want to delete from the Workload estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && (this._ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadEstimateId. 
        /// <para>
        ///  The ID of the Workload estimate for which you want to delete the modeled usage. 
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