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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountSettings operation.
    /// Updates the Amazon QuickSight settings in your Amazon Web Services account.
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _defaultNamespace;
        private string _notificationEmail;
        private bool? _terminationProtectionEnabled;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that contains the Amazon QuickSight settings
        /// that you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultNamespace. 
        /// <para>
        /// The default namespace for this Amazon Web Services account. Currently, the default
        /// is <code>default</code>. IAM users that register for the first time with Amazon QuickSight
        /// provide an email address that becomes associated with the default namespace. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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
        /// Gets and sets the property NotificationEmail. 
        /// <para>
        /// The email address that you want Amazon QuickSight to send notifications to regarding
        /// your Amazon Web Services account or Amazon QuickSight subscription.
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
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// A boolean value that determines whether or not an Amazon QuickSight account can be
        /// deleted. A <code>True</code> value doesn't allow the account to be deleted and results
        /// in an error message if a user tries to make a <code>DeleteAccountSubscription</code>
        /// request. A <code>False</code> value will allow the account to be deleted.
        /// </para>
        /// </summary>
        public bool TerminationProtectionEnabled
        {
            get { return this._terminationProtectionEnabled.GetValueOrDefault(); }
            set { this._terminationProtectionEnabled = value; }
        }

        // Check to see if TerminationProtectionEnabled property is set
        internal bool IsSetTerminationProtectionEnabled()
        {
            return this._terminationProtectionEnabled.HasValue; 
        }

    }
}