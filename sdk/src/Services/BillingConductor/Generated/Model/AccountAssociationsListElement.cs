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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of a linked account.
    /// </summary>
    public partial class AccountAssociationsListElement
    {
        private string _accountEmail;
        private string _accountId;
        private string _accountName;
        private string _billingGroupArn;

        /// <summary>
        /// Gets and sets the property AccountEmail. 
        /// <para>
        ///  The Amazon Web Services account email. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AccountEmail
        {
            get { return this._accountEmail; }
            set { this._accountEmail = value; }
        }

        // Check to see if AccountEmail property is set
        internal bool IsSetAccountEmail()
        {
            return this._accountEmail != null;
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The associating array of account IDs. 
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
        /// Gets and sets the property AccountName. 
        /// <para>
        ///  The Amazon Web Services account name. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        ///  The Billing Group Arn that the linked account is associated to. 
        /// </para>
        /// </summary>
        public string BillingGroupArn
        {
            get { return this._billingGroupArn; }
            set { this._billingGroupArn = value; }
        }

        // Check to see if BillingGroupArn property is set
        internal bool IsSetBillingGroupArn()
        {
            return this._billingGroupArn != null;
        }

    }
}