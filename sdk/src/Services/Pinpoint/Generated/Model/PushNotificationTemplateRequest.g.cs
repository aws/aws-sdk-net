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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the content and settings for a message template that can be used in messages
    /// that are sent through a push notification channel.
    /// </summary>
    public partial class PushNotificationTemplateRequest
    {
        /// <summary>
        /// Gets and sets the property ADM. 
        /// <para>
        /// The message template to use for the ADM (Amazon Device Messaging) channel. This message
        /// template overrides the default template for push notification channels (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public AndroidPushNotificationTemplate ADM { get; set; }

        /// <summary>
        /// Checks to see if the ADM property is set.
        /// </summary>
        internal bool IsSetADM() => this.ADM != null;

        /// <summary>
        /// Gets and sets the property APNS. 
        /// <para>
        /// The message template to use for the APNs (Apple Push Notification service) channel.
        /// This message template overrides the default template for push notification channels
        /// (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public APNSPushNotificationTemplate APNS { get; set; }

        /// <summary>
        /// Checks to see if the APNS property is set.
        /// </summary>
        internal bool IsSetAPNS() => this.APNS != null;

        /// <summary>
        /// Gets and sets the property Baidu. 
        /// <para>
        /// The message template to use for the Baidu (Baidu Cloud Push) channel. This message
        /// template overrides the default template for push notification channels (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public AndroidPushNotificationTemplate Baidu { get; set; }

        /// <summary>
        /// Checks to see if the Baidu property is set.
        /// </summary>
        internal bool IsSetBaidu() => this.Baidu != null;

        /// <summary>
        /// Gets and sets the property Default. 
        /// <para>
        /// The default message template to use for push notification channels.
        /// </para>
        /// </summary>
        public DefaultPushNotificationTemplate Default { get; set; }

        /// <summary>
        /// Checks to see if the Default property is set.
        /// </summary>
        internal bool IsSetDefault() => this.Default != null;

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
        public string DefaultSubstitutions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSubstitutions property is set.
        /// </summary>
        internal bool IsSetDefaultSubstitutions() => this.DefaultSubstitutions != null;

        /// <summary>
        /// Gets and sets the property GCM. 
        /// <para>
        /// The message template to use for the GCM channel, which is used to send notifications
        /// through the Firebase Cloud Messaging (FCM), formerly Google Cloud Messaging (GCM),
        /// service. This message template overrides the default template for push notification
        /// channels (DefaultPushNotificationTemplate).
        /// </para>
        /// </summary>
        public AndroidPushNotificationTemplate GCM { get; set; }

        /// <summary>
        /// Checks to see if the GCM property is set.
        /// </summary>
        internal bool IsSetGCM() => this.GCM != null;

        /// <summary>
        /// Gets and sets the property RecommenderId. 
        /// <para>
        /// The unique identifier for the recommender model to use for the message template. Amazon
        /// Pinpoint uses this value to determine how to retrieve and process data from a recommender
        /// model when it sends messages that use the template, if the template contains message
        /// variables for recommendation data.
        /// </para>
        /// </summary>
        public string RecommenderId { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderId property is set.
        /// </summary>
        internal bool IsSetRecommenderId() => this.RecommenderId != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// A custom description of the message template.
        /// </para>
        /// </summary>
        public string TemplateDescription { get; set; }

        /// <summary>
        /// Checks to see if the TemplateDescription property is set.
        /// </summary>
        internal bool IsSetTemplateDescription() => this.TemplateDescription != null;
    }
}
