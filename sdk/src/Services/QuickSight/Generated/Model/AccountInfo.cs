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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Your QuickSight account name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The edition of QuickSight that your account is using.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The notification email address that is associated with the QuickSight account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The authentication type of the QuickSight account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The status of the QuickSight account's subscription.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AccountInfo
    {
        private string _accountName;
        private string _accountSubscriptionStatus;
        private string _authenticationType;
        private Edition _edition;
        private string _iamIdentityCenterInstanceArn;
        private string _notificationEmail;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The account name that you provided for the QuickSight subscription in your Amazon
        /// Web Services account. You create this name when you sign up for QuickSight. It's unique
        /// over all of Amazon Web Services, and it appears only when users sign in.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AccountSubscriptionStatus. 
        /// <para>
        /// The status of your account subscription.
        /// </para>
        /// </summary>
        public string AccountSubscriptionStatus
        {
            get { return this._accountSubscriptionStatus; }
            set { this._accountSubscriptionStatus = value; }
        }

        // Check to see if AccountSubscriptionStatus property is set
        internal bool IsSetAccountSubscriptionStatus()
        {
            return this._accountSubscriptionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The way that your QuickSight account is authenticated.
        /// </para>
        /// </summary>
        public string AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition of your QuickSight account.
        /// </para>
        /// </summary>
        public Edition Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }

        // Check to see if Edition property is set
        internal bool IsSetEdition()
        {
            return this._edition != null;
        }

        /// <summary>
        /// Gets and sets the property IAMIdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string IAMIdentityCenterInstanceArn
        {
            get { return this._iamIdentityCenterInstanceArn; }
            set { this._iamIdentityCenterInstanceArn = value; }
        }

        // Check to see if IAMIdentityCenterInstanceArn property is set
        internal bool IsSetIAMIdentityCenterInstanceArn()
        {
            return this._iamIdentityCenterInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The email address that will be used for QuickSight to send notifications regarding
        /// your Amazon Web Services account or QuickSight subscription.
        /// </para>
        /// </summary>
        public string NotificationEmail
        {
            get { return this._notificationEmail; }
            set { this._notificationEmail = value; }
        }

        // Check to see if NotificationEmail property is set
        internal bool IsSetNotificationEmail()
        {
            return this._notificationEmail != null;
        }

    }
}