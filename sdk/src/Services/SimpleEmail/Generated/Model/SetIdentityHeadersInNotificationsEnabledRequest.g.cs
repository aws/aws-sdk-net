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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SetIdentityHeadersInNotificationsEnabled operation.
    /// Given an identity (an email address or a domain), sets whether Amazon SES includes
    /// the original email headers in the Amazon Simple Notification Service (Amazon SNS)
    /// notifications of a specified type. <para> You can execute this operation no more than
    /// once per second. </para> <para> For more information about using notifications with
    /// Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
    /// SES Developer Guide</a>. </para>
    /// </summary>
    public partial class SetIdentityHeadersInNotificationsEnabledRequest : AmazonSimpleEmailServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Sets whether Amazon SES includes the original email headers in Amazon SNS notifications
        /// of the specified notification type. A value of <c>true</c> specifies that Amazon SES
        /// includes headers in notifications, and a value of <c>false</c> specifies that Amazon
        /// SES does not include headers in notifications.
        /// </para>
        ///  
        /// <para>
        /// This value can only be set when <c>NotificationType</c> is already set to use a particular
        /// Amazon SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity for which to enable or disable headers in notifications. Examples: <c>user@example.com</c>,
        /// <c>example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identity { get; set; }

        /// <summary>
        /// Checks to see if the Identity property is set.
        /// </summary>
        internal bool IsSetIdentity() => this.Identity != null;

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// The notification type for which to enable or disable headers in notifications. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationType NotificationType { get; set; }

        /// <summary>
        /// Checks to see if the NotificationType property is set.
        /// </summary>
        internal bool IsSetNotificationType() => this.NotificationType != null;
    }
}
