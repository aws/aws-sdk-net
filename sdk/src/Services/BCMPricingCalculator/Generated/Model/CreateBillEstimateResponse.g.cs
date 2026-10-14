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
    /// This is the response object from the CreateBillEstimate operation.
    /// </summary>
    public partial class CreateBillEstimateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BillInterval. 
        /// <para>
        ///  The bill month start and end timestamp that was used to create the Bill estimate.
        /// This is set to the last complete anniversary bill month start and end timestamp. 
        /// </para>
        /// </summary>
        public BillInterval BillInterval { get; set; }

        /// <summary>
        /// Checks to see if the BillInterval property is set.
        /// </summary>
        internal bool IsSetBillInterval() => this.BillInterval != null;

        /// <summary>
        /// Gets and sets the property CostCategoryGroupSharingPreferenceArn. 
        /// <para>
        /// The arn of the cost category used in the reserved and prioritized group sharing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CostCategoryGroupSharingPreferenceArn { get; set; }

        /// <summary>
        /// Checks to see if the CostCategoryGroupSharingPreferenceArn property is set.
        /// </summary>
        internal bool IsSetCostCategoryGroupSharingPreferenceArn() => this.CostCategoryGroupSharingPreferenceArn != null;

        /// <summary>
        /// Gets and sets the property CostCategoryGroupSharingPreferenceEffectiveDate. 
        /// <para>
        /// Timestamp of the effective date of the cost category used in the group sharing settings.
        /// </para>
        /// </summary>
        public DateTime? CostCategoryGroupSharingPreferenceEffectiveDate { get; set; }

        /// <summary>
        /// Checks to see if the CostCategoryGroupSharingPreferenceEffectiveDate property is set.
        /// </summary>
        internal bool IsSetCostCategoryGroupSharingPreferenceEffectiveDate() => this.CostCategoryGroupSharingPreferenceEffectiveDate.HasValue;

        /// <summary>
        /// Gets and sets the property CostSummary. 
        /// <para>
        ///  Returns summary-level cost information once a Bill estimate is successfully generated.
        /// This summary includes: 1) the total cost difference, showing the pre-tax cost change
        /// for the consolidated billing family between the completed anniversary bill and the
        /// estimated bill, and 2) total cost differences per service, detailing the pre-tax cost
        /// of each service, comparing the completed anniversary bill to the estimated bill on
        /// a per-service basis. 
        /// </para>
        /// </summary>
        public BillEstimateCostSummary CostSummary { get; set; }

        /// <summary>
        /// Checks to see if the CostSummary property is set.
        /// </summary>
        internal bool IsSetCostSummary() => this.CostSummary != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp of when the Bill estimate create process was started (not when it successfully
        /// completed or failed). 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        ///  The timestamp of when the Bill estimate will expire. A Bill estimate becomes inaccessible
        /// after expiration. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        ///  This attribute provides the reason if a Bill estimate result generation fails. 
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property GroupSharingPreference. 
        /// <para>
        /// The setting for the reserved instance and savings plan group sharing used in this
        /// estimate.
        /// </para>
        /// </summary>
        public GroupSharingPreferenceEnum GroupSharingPreference { get; set; }

        /// <summary>
        /// Checks to see if the GroupSharingPreference property is set.
        /// </summary>
        internal bool IsSetGroupSharingPreference() => this.GroupSharingPreference != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of your newly created Bill estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of your newly created Bill estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of your newly created Bill estimate. Bill estimate creation can take anywhere
        /// between 8 to 12 hours. The status will allow you to identify when the Bill estimate
        /// is complete or has failed. 
        /// </para>
        /// </summary>
        public BillEstimateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
