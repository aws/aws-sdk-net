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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The free trial status of each Security Hub feature for an account.
    /// </summary>
    public partial class AccountFreeTrialStatus
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account identifier that the free trial statuses apply to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property EvaluatedAt. 
        /// <para>
        /// The date and time at which Security Hub evaluated the free trial statuses for this
        /// account. Every status in <c>FreeTrialStatuses</c> reflects this point in time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EvaluatedAt { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatedAt property is set.
        /// </summary>
        internal bool IsSetEvaluatedAt() => this.EvaluatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FreeTrialStatuses. 
        /// <para>
        /// An array of free trial statuses, one for each feature that has a free trial period
        /// for the account. The array is empty if the account has no free trial to report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<FreeTrialStatus> FreeTrialStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<FreeTrialStatus>() : null;

        /// <summary>
        /// Checks to see if the FreeTrialStatuses property is set.
        /// </summary>
        internal bool IsSetFreeTrialStatuses() => this.FreeTrialStatuses != null && (this.FreeTrialStatuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
