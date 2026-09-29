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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that contains the following account information elements: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Your Quick Sight account name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The edition of Quick Sight that your account is using.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The notification email address that is associated with the Quick Sight account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The authentication type of the Quick Sight account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The status of the Quick Sight account's subscription.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AccountInfo
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The account name that you provided for the Amazon Quick Sight subscription in your
        /// Amazon Web Services account. You create this name when you sign up for Quick. It's
        /// unique over all of Amazon Web Services, and it appears only when users sign in.
        /// </para>
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property AccountSubscriptionStatus. 
        /// <para>
        /// The status of your account subscription.
        /// </para>
        /// </summary>
        public string AccountSubscriptionStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountSubscriptionStatus property is set.
        /// </summary>
        internal bool IsSetAccountSubscriptionStatus() => this.AccountSubscriptionStatus != null;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The way that your Amazon Quick Sight account is authenticated.
        /// </para>
        /// </summary>
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition of your Quick Sight account.
        /// </para>
        /// </summary>
        public Edition Edition { get; set; }

        /// <summary>
        /// Checks to see if the Edition property is set.
        /// </summary>
        internal bool IsSetEdition() => this.Edition != null;

        /// <summary>
        /// Gets and sets the property IAMIdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string IAMIdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IAMIdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIAMIdentityCenterInstanceArn() => this.IAMIdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The email address that will be used for Quick Sight to send notifications regarding
        /// your Amazon Web Services account or Quick Sight subscription.
        /// </para>
        /// </summary>
        public string NotificationEmail { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEmail property is set.
        /// </summary>
        internal bool IsSetNotificationEmail() => this.NotificationEmail != null;
    }
}
