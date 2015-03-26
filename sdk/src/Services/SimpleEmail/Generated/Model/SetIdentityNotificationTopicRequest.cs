/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SetIdentityNotificationTopic operation.
    /// Given an identity (email address or domain), sets the Amazon Simple Notification Service
    /// (Amazon SNS) topic to which Amazon SES will publish        bounce, complaint, and/or
    /// delivery notifications for emails sent with that identity as the <code>Source</code>.
    /// 
    ///         <note>Unless feedback forwarding is enabled, you must specify Amazon SNS topics
    /// for bounce and complaint notifications.            For more information, see <code>SetIdentityFeedbackForwardingEnabled</code>.
    ///        </note>        
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    ///         
    /// <para>
    /// For more information about feedback notification, see the            <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/notifications.html">Amazon
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
        /// The identity for which the Amazon SNS topic will be set.  Examples: <code>user@example.com</code>,
        /// <code>example.com</code>.
        /// </para>
        /// </summary>
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
        /// The type of notifications that will be published to the specified Amazon SNS topic.
        /// </para>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic.        If the parameter is
        /// omitted from the request or a null value is passed, <code>SnsTopic</code> is cleared
        /// and publishing is disabled.
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