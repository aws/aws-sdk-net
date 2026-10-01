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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// A representation of a linked account.
    /// </summary>
    public partial class AccountAssociationsListElement
    {
        /// <summary>
        /// Gets and sets the property AccountEmail. 
        /// <para>
        /// The Amazon Web Services account email.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AccountEmail { get; set; }

        /// <summary>
        /// Checks to see if the AccountEmail property is set.
        /// </summary>
        internal bool IsSetAccountEmail() => this.AccountEmail != null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The associating array of account IDs.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The Amazon Web Services account name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        /// The Billing Group Arn that the linked account is associated to.
        /// </para>
        /// </summary>
        public string BillingGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingGroupArn property is set.
        /// </summary>
        internal bool IsSetBillingGroupArn() => this.BillingGroupArn != null;
    }
}
