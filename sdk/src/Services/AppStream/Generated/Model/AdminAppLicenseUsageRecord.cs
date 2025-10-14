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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
        private string _billingPeriod;
        private string _licenseType;
        private string _ownerAWSAccountId;
        private DateTime? _subscriptionFirstUsedDate;
        private DateTime? _subscriptionLastUsedDate;
        private string _userArn;
        private string _userId;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period for the license usage record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string BillingPeriod
        {
            get { return this._billingPeriod; }
            set { this._billingPeriod = value; }
        }

        // Check to see if BillingPeriod property is set
        internal bool IsSetBillingPeriod()
        {
            return this._billingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The type of license (for example, Microsoft Office).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAWSAccountId. 
        /// <para>
        /// The account ID of the owner of the license.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwnerAWSAccountId
        {
            get { return this._ownerAWSAccountId; }
            set { this._ownerAWSAccountId = value; }
        }

        // Check to see if OwnerAWSAccountId property is set
        internal bool IsSetOwnerAWSAccountId()
        {
            return this._ownerAWSAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionFirstUsedDate. 
        /// <para>
        /// The date and time when the license was first used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubscriptionFirstUsedDate
        {
            get { return this._subscriptionFirstUsedDate; }
            set { this._subscriptionFirstUsedDate = value; }
        }

        // Check to see if SubscriptionFirstUsedDate property is set
        internal bool IsSetSubscriptionFirstUsedDate()
        {
            return this._subscriptionFirstUsedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubscriptionLastUsedDate. 
        /// <para>
        /// The date and time when the license was last used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubscriptionLastUsedDate
        {
            get { return this._subscriptionLastUsedDate; }
            set { this._subscriptionLastUsedDate = value; }
        }

        // Check to see if SubscriptionLastUsedDate property is set
        internal bool IsSetSubscriptionLastUsedDate()
        {
            return this._subscriptionLastUsedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The ARN of the user who used the license-included application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user who used the license-included application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}