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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateManagedNotificationAccountContact operation.
    /// Disassociates an Account Contact with a particular <c>ManagedNotificationConfiguration</c>.
    /// </summary>
    public partial class DisassociateManagedNotificationAccountContactRequest : AmazonNotificationsRequest
    {
        private AccountContactType _contactIdentifier;
        private string _managedNotificationConfigurationArn;

        /// <summary>
        /// Gets and sets the property ContactIdentifier. 
        /// <para>
        /// The unique value of an Account Contact Type to associate with the <c>ManagedNotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountContactType ContactIdentifier
        {
            get { return this._contactIdentifier; }
            set { this._contactIdentifier = value; }
        }

        // Check to see if ContactIdentifier property is set
        internal bool IsSetContactIdentifier()
        {
            return this._contactIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedNotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationConfiguration</c> to associate
        /// with the Account Contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagedNotificationConfigurationArn
        {
            get { return this._managedNotificationConfigurationArn; }
            set { this._managedNotificationConfigurationArn = value; }
        }

        // Check to see if ManagedNotificationConfigurationArn property is set
        internal bool IsSetManagedNotificationConfigurationArn()
        {
            return this._managedNotificationConfigurationArn != null;
        }

    }
}