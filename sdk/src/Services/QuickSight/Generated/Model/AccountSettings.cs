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
    /// The QuickSight settings associated with your Amazon Web Services account.
    /// </summary>
    public partial class AccountSettings
    {
        private string _accountName;
        private string _defaultNamespace;
        private Edition _edition;
        private string _notificationEmail;
        private bool? _publicSharingEnabled;
        private bool? _terminationProtectionEnabled;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The "account name" you provided for the QuickSight subscription in your Amazon Web
        /// Services account. You create this name when you sign up for QuickSight. It is unique
        /// in all of Amazon Web Services and it appears only when users sign in.
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
        /// Gets and sets the property DefaultNamespace. 
        /// <para>
        /// The default QuickSight namespace for your Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string DefaultNamespace
        {
            get { return this._defaultNamespace; }
            set { this._defaultNamespace = value; }
        }

        // Check to see if DefaultNamespace property is set
        internal bool IsSetDefaultNamespace()
        {
            return this._defaultNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition of QuickSight that you're currently subscribed to: Enterprise edition
        /// or Standard edition.
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
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The main notification email for your QuickSight subscription.
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

        /// <summary>
        /// Gets and sets the property PublicSharingEnabled. 
        /// <para>
        /// A Boolean value that indicates whether public sharing is turned on for an QuickSight
        /// account. For more information about turning on public sharing, see <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdatePublicSharingSettings.html">UpdatePublicSharingSettings</a>.
        /// </para>
        /// </summary>
        public bool? PublicSharingEnabled
        {
            get { return this._publicSharingEnabled; }
            set { this._publicSharingEnabled = value; }
        }

        // Check to see if PublicSharingEnabled property is set
        internal bool IsSetPublicSharingEnabled()
        {
            return this._publicSharingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// A boolean value that determines whether or not an QuickSight account can be deleted.
        /// A <c>True</c> value doesn't allow the account to be deleted and results in an error
        /// message if a user tries to make a <c>DeleteAccountSubsctiption</c> request. A <c>False</c>
        /// value will allow the ccount to be deleted. 
        /// </para>
        /// </summary>
        public bool? TerminationProtectionEnabled
        {
            get { return this._terminationProtectionEnabled; }
            set { this._terminationProtectionEnabled = value; }
        }

        // Check to see if TerminationProtectionEnabled property is set
        internal bool IsSetTerminationProtectionEnabled()
        {
            return this._terminationProtectionEnabled.HasValue; 
        }

    }
}