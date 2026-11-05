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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// The collection of license usage records.
    /// </summary>
    public partial class AdminAppLicenseUsageRecord
    {
        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period for the license usage record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The type of license (for example, Microsoft Office).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string LicenseType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseType property is set.
        /// </summary>
        internal bool IsSetLicenseType() => this.LicenseType != null;

        /// <summary>
        /// Gets and sets the property OwnerAWSAccountId. 
        /// <para>
        /// The account ID of the owner of the license.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwnerAWSAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAWSAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAWSAccountId() => this.OwnerAWSAccountId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionFirstUsedDate. 
        /// <para>
        /// The date and time when the license was first used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubscriptionFirstUsedDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionFirstUsedDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionFirstUsedDate() => this.SubscriptionFirstUsedDate.HasValue;

        /// <summary>
        /// Gets and sets the property SubscriptionLastUsedDate. 
        /// <para>
        /// The date and time when the license was last used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubscriptionLastUsedDate { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionLastUsedDate property is set.
        /// </summary>
        internal bool IsSetSubscriptionLastUsedDate() => this.SubscriptionLastUsedDate.HasValue;

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The ARN of the user who used the license-included application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string UserArn { get; set; }

        /// <summary>
        /// Checks to see if the UserArn property is set.
        /// </summary>
        internal bool IsSetUserArn() => this.UserArn != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user who used the license-included application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
