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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateOrganizationalUnit operation. Removes
    /// the association between an organizational unit and a notification configuration.
    /// </summary>
    public partial class DisassociateOrganizationalUnitRequest : AmazonNotificationsRequest
    {
        /// <summary>
        /// Gets and sets the property NotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notification configuration to disassociate from
        /// the organizational unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetNotificationConfigurationArn() => this.NotificationConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The unique identifier of the organizational unit to disassociate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;
    }
}
