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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the content and settings for a message template that can be used in messages
    /// that are sent through a push notification channel.
    /// </summary>
    public partial class PushNotificationTemplateRequest
    {
        private AndroidPushNotificationTemplate _adm;
        private APNSPushNotificationTemplate _apns;
        private AndroidPushNotificationTemplate _baidu;
        private DefaultPushNotificationTemplate _default;
        private string _defaultSubstitutions;
        private AndroidPushNotificationTemplate _gcm;
        private string _recommenderId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _templateDescription;

        /// <summary>
        /// Gets and sets the property ADM. 
        /// <para>
        /// The message template to use for the ADM (Amazon Device Messaging) channel. This message
        /// template overrides the default template for push notification channels (DefaultPushNotificationTemplate).
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
        /// The message template to use for the APNs (Apple Push Notification service) channel.
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
        /// Gets and sets the property Baidu. 
        /// <para>
        /// The message template to use for the Baidu (Baidu Cloud Push) channel. This message
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
        /// Gets and sets the property Default. 
        /// <para>
        /// The default message template to use for push notification channels.
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
        /// Gets and sets the property DefaultSubstitutions. 
        /// <para>
        /// A JSON object that specifies the default values to use for message variables in the
        /// message template. This object is a set of key-value pairs. Each key defines a message
        /// variable in the template. The corresponding value defines the default value for that
        /// variable. When you create a message that's based on the template, you can override
        /// these defaults with message-specific and address-specific variables and values.
        /// </para>
        /// </summary>
        public string DefaultSubstitutions
        {
            get { return this._defaultSubstitutions; }
            set { this._defaultSubstitutions = value; }
        }

        // Check to see if DefaultSubstitutions property is set
        internal bool IsSetDefaultSubstitutions()
        {
            return this._defaultSubstitutions != null;
        }

        /// <summary>
        /// Gets and sets the property GCM. 
        /// <para>
        /// The message template to use for the GCM channel, which is used to send notifications
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
        /// Gets and sets the property RecommenderId. 
        /// <para>
        /// The unique identifier for the recommender model to use for the message template. Amazon
        /// Pinpoint uses this value to determine how to retrieve and process data from a recommender
        /// model when it sends messages that use the template, if the template contains message
        /// variables for recommendation data.
        /// </para>
        /// </summary>
        public string RecommenderId
        {
            get { return this._recommenderId; }
            set { this._recommenderId = value; }
        }

        // Check to see if RecommenderId property is set
        internal bool IsSetRecommenderId()
        {
            return this._recommenderId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. <note>
        /// <para>
        /// As of <b>22-05-2023</b> tags has been deprecated for update operations. After this
        /// date any value in tags is not processed and an error code is not returned. To manage
        /// tags we recommend using either <a href="https://docs.aws.amazon.com/pinpoint/latest/apireference/tags-resource-arn.html">Tags</a>
        /// in the <i>API Reference for Amazon Pinpoint</i>, <a href="https://docs.aws.amazon.com/cli/latest/reference/resourcegroupstaggingapi/index.html">resourcegroupstaggingapi</a>
        /// commands in the <i>AWS Command Line Interface Documentation</i> or <a href="https://sdk.amazonaws.com/java/api/latest/software/amazon/awssdk/services/resourcegroupstaggingapi/package-summary.html">resourcegroupstaggingapi</a>
        /// in the <i>AWS SDK</i>.
        /// </para>
        /// </note> 
        /// <para>
        /// (Deprecated) A string-to-string map of key-value pairs that defines the tags to associate
        /// with the message template. Each tag consists of a required tag key and an associated
        /// tag value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// A custom description of the message template.
        /// </para>
        /// </summary>
        public string TemplateDescription
        {
            get { return this._templateDescription; }
            set { this._templateDescription = value; }
        }

        // Check to see if TemplateDescription property is set
        internal bool IsSetTemplateDescription()
        {
            return this._templateDescription != null;
        }

    }
}