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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// The approval plan to start an agreement approval for, and an optional note for the
    /// approvers.
    /// </summary>
    public partial class BuyerAgreementApprovalPlanInput
    {
        /// <summary>
        /// Gets and sets the property PlanReference. 
        /// <para>
        /// The identifier of the approval plan. Use <c>GetAgreementRequestApprovalPlans</c> to
        /// retrieve the approval plans of the agreement request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PlanReference { get; set; }

        /// <summary>
        /// Checks to see if the PlanReference property is set.
        /// </summary>
        internal bool IsSetPlanReference() => this.PlanReference != null;

        /// <summary>
        /// Gets and sets the property RequesterNote. 
        /// <para>
        /// An optional note for the approvers, such as the business reason for the purchase (1-1000
        /// characters).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string RequesterNote { get; set; }

        /// <summary>
        /// Checks to see if the RequesterNote property is set.
        /// </summary>
        internal bool IsSetRequesterNote() => this.RequesterNote != null;
    }
}
