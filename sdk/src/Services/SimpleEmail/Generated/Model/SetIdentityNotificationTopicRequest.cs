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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
    /// Container for the parameters to the SetIdentityNotificationTopic operation.
    /// Sets an Amazon Simple Notification Service (Amazon SNS) topic to use when delivering
    /// notifications. When you use this operation, you specify a verified identity, such
    /// as an email address or domain. When you send an email that uses the chosen identity
    /// in the Source field, Amazon SES sends notifications to the topic you specified. You
    /// can send bounce, complaint, or delivery notifications (or any combination of the three)
    /// to the Amazon SNS topic that you specify.
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    ///  
    /// <para>
    /// For more information about feedback notification, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity-using-notifications.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class SetIdentityNotificationTopicRequest : AmazonSimpleEmailServiceRequest
    {
        private string _identity;
        private NotificationType _notificationType;
        private string _snsTopic;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// The identity (email address or domain) for the Amazon SNS topic.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can only specify a verified identity for this parameter.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can specify an identity by using its name or by using its Amazon Resource Name
        /// (ARN). The following examples are all valid identities: <c>sender@example.com</c>,
        /// <c>example.com</c>, <c>arn:aws:ses:us-east-1:123456789012:identity/example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// The type of notifications that are published to the specified Amazon SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationType NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic. If the parameter is omitted
        /// from the request or a null value is passed, <c>SnsTopic</c> is cleared and publishing
        /// is disabled.
        /// </para>
        /// </summary>
        public string SnsTopic
        {
            get { return this._snsTopic; }
            set { this._snsTopic = value; }
        }

        // Check to see if SnsTopic property is set
        internal bool IsSetSnsTopic()
        {
            return this._snsTopic != null;
        }

    }
}