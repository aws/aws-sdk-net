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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the content and settings for a message template that can
    /// be used in messages that are sent through a push notification channel.
    /// </summary>
    public partial class PushNotificationTemplateResponse
    {
        private AndroidPushNotificationTemplate _adm;
        private APNSPushNotificationTemplate _apns;
        private string _arn;
        private AndroidPushNotificationTemplate _baidu;
        private string _creationDate;
        private DefaultPushNotificationTemplate _default;
        private AndroidPushNotificationTemplate _gcm;
        private string _lastModifiedDate;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _templateName;
        private TemplateType _templateType;

        /// <summary>
        /// Gets and sets the property ADM. 
        /// <para>
        /// The message template that's used for the ADM (Amazon Device Messaging) channel. This
        /// message template overrides the default template for push notification channels (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public AndroidPushNotificationTemplate ADM
        {
            get { return this._adm; }
            set { this._adm = value; }
        }

        // Check to see if ADM property is set
        internal bool IsSetADM()
        {
            return this._adm != null;
        }

        /// <summary>
        /// Gets and sets the property APNS. 
        /// <para>
        /// The message template that's used for the APNs (Apple Push Notification service) channel.
        /// This message template overrides the default template for push notification channels
        /// (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public APNSPushNotificationTemplate APNS
        {
            get { return this._apns; }
            set { this._apns = value; }
        }

        // Check to see if APNS property is set
        internal bool IsSetAPNS()
        {
            return this._apns != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the message template.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Baidu. 
        /// <para>
        /// The message template that's used for the Baidu (Baidu Cloud Push) channel. This message
        /// template overrides the default template for push notification channels (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public AndroidPushNotificationTemplate Baidu
        {
            get { return this._baidu; }
            set { this._baidu = value; }
        }

        // Check to see if Baidu property is set
        internal bool IsSetBaidu()
        {
            return this._baidu != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the message template was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Default. 
        /// <para>
        /// The default message template that's used for push notification channels.
        /// </para>
        /// </summary>
        public DefaultPushNotificationTemplate Default
        {
            get { return this._default; }
            set { this._default = value; }
        }

        // Check to see if Default property is set
        internal bool IsSetDefault()
        {
            return this._default != null;
        }

        /// <summary>
        /// Gets and sets the property GCM. 
        /// <para>
        /// The message template that's used for the GCM channel, which is used to send notifications
        /// through the Firebase Cloud Messaging (FCM), formerly Google Cloud Messaging (GCM),
        /// service. This message template overrides the default template for push notification
        /// channels (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public AndroidPushNotificationTemplate GCM
        {
            get { return this._gcm; }
            set { this._gcm = value; }
        }

        // Check to see if GCM property is set
        internal bool IsSetGCM()
        {
            return this._gcm != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the message template was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that identifies the tags that are associated
        /// with the message template. Each tag consists of a required tag key and an associated
        /// tag value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of channel that the message template is designed for. For a push notification
        /// template, this value is PUSH.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateType TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

    }
}