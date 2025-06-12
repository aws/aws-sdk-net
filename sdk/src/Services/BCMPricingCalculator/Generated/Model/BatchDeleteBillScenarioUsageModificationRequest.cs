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
    /// Container for the parameters to the BatchDeleteBillScenarioUsageModification operation.
    /// Delete usage that you have created in a Bill Scenario. You can only delete usage
    /// that you had added and cannot model deletion (or removal) of a existing usage. If
    /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateBillScenarioUsageModification.html">
    /// BatchUpdateBillScenarioUsageModification</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// The <c>BatchDeleteBillScenarioUsageModification</c> operation doesn't have its own
    /// IAM permission. To authorize this operation for Amazon Web Services principals, include
    /// the permission <c>bcm-pricing-calculator:DeleteBillScenarioUsageModification</c> in
    /// your policies.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchDeleteBillScenarioUsageModificationRequest : AmazonBCMPricingCalculatorRequest
    {
        private string _billScenarioId;
        private List<string> _ids = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BillScenarioId. 
        /// <para>
        ///  The ID of the Bill Scenario for which you want to delete the modeled usage. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string BillScenarioId
        {
            get { return this._billScenarioId; }
            set { this._billScenarioId = value; }
        }

        // Check to see if BillScenarioId property is set
        internal bool IsSetBillScenarioId()
        {
            return this._billScenarioId != null;
        }

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        ///  List of usage that you want to delete from the Bill Scenario. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

    }
}