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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The action to publish the email content to an Amazon SNS topic. When executed, this
    /// action will send the email as a notification to the specified SNS topic.
    /// </summary>
    public partial class SnsAction
    {
        private ActionFailurePolicy _actionFailurePolicy;
        private SnsNotificationEncoding _encoding;
        private SnsNotificationPayloadType _payloadType;
        private string _roleArn;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property ActionFailurePolicy. 
        /// <para>
        /// A policy that states what to do in the case of failure. The action will fail if there
        /// are configuration errors. For example, specified SNS topic has been deleted or the
        /// role lacks necessary permissions to call the <c>sns:Publish</c> API.
        /// </para>
        /// </summary>
        public ActionFailurePolicy ActionFailurePolicy
        {
            get { return this._actionFailurePolicy; }
            set { this._actionFailurePolicy = value; }
        }

        // Check to see if ActionFailurePolicy property is set
        internal bool IsSetActionFailurePolicy()
        {
            return this._actionFailurePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// The encoding to use for the email within the Amazon SNS notification. The default
        /// value is <c>UTF-8</c>. Use <c>BASE64</c> if you need to preserve all special characters,
        /// especially when the original message uses a different encoding format.
        /// </para>
        /// </summary>
        public SnsNotificationEncoding Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// The expected payload type within the Amazon SNS notification. <c>CONTENT</c> attempts
        /// to publish the full email content with 20KB of headers content. <c>HEADERS</c> extracts
        /// up to 100KB of header content to include in the notification, email content will not
        /// be included to the notification. The default value is <c>CONTENT</c>.
        /// </para>
        /// </summary>
        public SnsNotificationPayloadType PayloadType
        {
            get { return this._payloadType; }
            set { this._payloadType = value; }
        }

        // Check to see if PayloadType property is set
        internal bool IsSetPayloadType()
        {
            return this._payloadType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Role to use while writing to Amazon SNS.
        /// This role must have access to the <c>sns:Publish</c> API for the given topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS Topic to which notification for the
        /// email received will be published.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}