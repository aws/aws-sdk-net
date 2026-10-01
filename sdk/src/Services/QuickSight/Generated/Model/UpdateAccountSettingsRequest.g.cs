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
    /// Container for the parameters to the UpdateAccountSettings operation. Updates the Amazon
    /// Quick Sight settings in your Amazon Web Services account.
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that contains the Quick Sight settings
        /// that you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property DefaultNamespace. 
        /// <para>
        /// The default namespace for this Amazon Web Services account. Currently, the default
        /// is <c>default</c>. IAM users that register for the first time with Amazon Quick Sight
        /// provide an email address that becomes associated with the default namespace. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string DefaultNamespace { get; set; }

        /// <summary>
        /// Checks to see if the DefaultNamespace property is set.
        /// </summary>
        internal bool IsSetDefaultNamespace() => this.DefaultNamespace != null;

        /// <summary>
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The email address that you want Quick Sight to send notifications to regarding your
        /// Amazon Web Services account or Quick Sight subscription.
        /// </para>
        /// </summary>
        public string NotificationEmail { get; set; }

        /// <summary>
        /// Checks to see if the NotificationEmail property is set.
        /// </summary>
        internal bool IsSetNotificationEmail() => this.NotificationEmail != null;

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// A boolean value that determines whether or not an Quick Sight account can be deleted.
        /// A <c>True</c> value doesn't allow the account to be deleted and results in an error
        /// message if a user tries to make a <c>DeleteAccountSubscription</c> request. A <c>False</c>
        /// value will allow the account to be deleted.
        /// </para>
        /// </summary>
        public bool? TerminationProtectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TerminationProtectionEnabled property is set.
        /// </summary>
        internal bool IsSetTerminationProtectionEnabled() => this.TerminationProtectionEnabled.HasValue;
    }
}
