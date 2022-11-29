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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides quota and aggregated usage data for an Amazon Macie account.
    /// </summary>
    public partial class UsageRecord
    {
        private string _accountId;
        private DateTime? _automatedDiscoveryFreeTrialStartDate;
        private DateTime? _freeTrialStartDate;
        private List<UsageByAccount> _usage = new List<UsageByAccount>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account that the data applies to.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AutomatedDiscoveryFreeTrialStartDate. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the free trial of automated
        /// sensitive data discovery started for the account. If the account is a member account
        /// in an organization, this value is the same as the value for the organization's Amazon
        /// Macie administrator account.
        /// </para>
        /// </summary>
        public DateTime AutomatedDiscoveryFreeTrialStartDate
        {
            get { return this._automatedDiscoveryFreeTrialStartDate.GetValueOrDefault(); }
            set { this._automatedDiscoveryFreeTrialStartDate = value; }
        }

        // Check to see if AutomatedDiscoveryFreeTrialStartDate property is set
        internal bool IsSetAutomatedDiscoveryFreeTrialStartDate()
        {
            return this._automatedDiscoveryFreeTrialStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FreeTrialStartDate. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the Amazon Macie free
        /// trial started for the account.
        /// </para>
        /// </summary>
        public DateTime FreeTrialStartDate
        {
            get { return this._freeTrialStartDate.GetValueOrDefault(); }
            set { this._freeTrialStartDate = value; }
        }

        // Check to see if FreeTrialStartDate property is set
        internal bool IsSetFreeTrialStartDate()
        {
            return this._freeTrialStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// An array of objects that contains usage data and quotas for the account. Each object
        /// contains the data for a specific usage metric and the corresponding quota.
        /// </para>
        /// </summary>
        public List<UsageByAccount> Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null && this._usage.Count > 0; 
        }

    }
}