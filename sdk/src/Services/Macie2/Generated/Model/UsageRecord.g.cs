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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides quota and aggregated usage data for an Amazon Macie account.
    /// </summary>
    public partial class UsageRecord
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account that the data applies to.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AutomatedDiscoveryFreeTrialStartDate. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the free trial of automated
        /// sensitive data discovery started for the account. This value is null if automated
        /// sensitive data discovery hasn't been enabled for the account.
        /// </para>
        /// </summary>
        public DateTime? AutomatedDiscoveryFreeTrialStartDate { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedDiscoveryFreeTrialStartDate property is set.
        /// </summary>
        internal bool IsSetAutomatedDiscoveryFreeTrialStartDate() => this.AutomatedDiscoveryFreeTrialStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property FreeTrialStartDate. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the Amazon Macie free
        /// trial started for the account.
        /// </para>
        /// </summary>
        public DateTime? FreeTrialStartDate { get; set; }

        /// <summary>
        /// Checks to see if the FreeTrialStartDate property is set.
        /// </summary>
        internal bool IsSetFreeTrialStartDate() => this.FreeTrialStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// An array of objects that contains usage data and quotas for the account. Each object
        /// contains the data for a specific usage metric and the corresponding quota.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageByAccount> Usage { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageByAccount>() : null;

        /// <summary>
        /// Checks to see if the Usage property is set.
        /// </summary>
        internal bool IsSetUsage() => this.Usage != null && (this.Usage.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
