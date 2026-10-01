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
    /// The Quick Sight settings associated with your Amazon Web Services account.
    /// </summary>
    public partial class AccountSettings
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The "account name" you provided for the Quick Sight subscription in your Amazon Web
        /// Services account. You create this name when you sign up for Quick Sight. It is unique
        /// in all of Amazon Web Services and it appears only when users sign in.
        /// </para>
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property DefaultNamespace. 
        /// <para>
        /// The default Quick Sight namespace for your Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string DefaultNamespace { get; set; }

        /// <summary>
        /// Checks to see if the DefaultNamespace property is set.
        /// </summary>
        internal bool IsSetDefaultNamespace() => this.DefaultNamespace != null;

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition of Quick Sight that you're currently subscribed to: Enterprise edition
        /// or Standard edition.
        /// </para>
        /// </summary>
        public Edition Edition { get; set; }

        /// <summary>
        /// Checks to see if the Edition property is set.
        /// </summary>
        internal bool IsSetEdition() => this.Edition != null;

        /// <summary>
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The main notification email for your Quick Sight subscription.
        /// </para>
        /// </summary>
        public string NotificationEmail { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEmail property is set.
        /// </summary>
        internal bool IsSetNotificationEmail() => this.NotificationEmail != null;

        /// <summary>
        /// Gets and sets the property PublicSharingEnabled. 
        /// <para>
        /// A Boolean value that indicates whether public sharing is turned on for an Quick account.
        /// For more information about turning on public sharing, see <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdatePublicSharingSettings.html">UpdatePublicSharingSettings</a>.
        /// </para>
        /// </summary>
        public bool? PublicSharingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PublicSharingEnabled property is set.
        /// </summary>
        internal bool IsSetPublicSharingEnabled() => this.PublicSharingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// A boolean value that determines whether or not an Quick Sight account can be deleted.
        /// A <c>True</c> value doesn't allow the account to be deleted and results in an error
        /// message if a user tries to make a <c>DeleteAccountSubsctiption</c> request. A <c>False</c>
        /// value will allow the ccount to be deleted. 
        /// </para>
        /// </summary>
        public bool? TerminationProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TerminationProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetTerminationProtectionEnabled() => this.TerminationProtectionEnabled.HasValue;
    }
}
