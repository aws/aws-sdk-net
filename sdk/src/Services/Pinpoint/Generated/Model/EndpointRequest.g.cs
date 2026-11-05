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
    /// Specifies the channel type and other settings for an endpoint.
    /// </summary>
    public partial class EndpointRequest
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The destination address for messages or push notifications that you send to the endpoint.
        /// The address varies by channel. For a push-notification channel, use the token provided
        /// by the push notification service, such as an Apple Push Notification service (APNs)
        /// device token or a Firebase Cloud Messaging (FCM) registration token. For the SMS channel,
        /// use a phone number in E.164 format, such as +12065550100. For the email channel, use
        /// an email address.
        /// </para>
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more custom attributes that describe the endpoint by associating a name with
        /// an array of values. For example, the value of a custom attribute named Interests might
        /// be: ["Science", "Music", "Travel"]. You can use these attributes as filter criteria
        /// when you create segments. Attribute names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// An attribute name can contain up to 50 characters. An attribute value can contain
        /// up to 100 characters. When you define the name of a custom attribute, avoid using
        /// the following characters: number sign (#), colon (:), question mark (?), backslash
        /// (\), and slash (/). The Amazon Pinpoint console can't display attribute names that
        /// contain these characters. This restriction doesn't apply to attribute values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// The channel to use when sending messages or push notifications to the endpoint.
        /// </para>
        /// </summary>
        public ChannelType ChannelType { get; set; }

        /// <summary>
        /// Checks to see if the ChannelType property is set.
        /// </summary>
        internal bool IsSetChannelType() => this.ChannelType != null;

        /// <summary>
        /// Gets and sets the property Demographic. 
        /// <para>
        /// The demographic information for the endpoint, such as the time zone and platform.
        /// </para>
        /// </summary>
        public EndpointDemographic Demographic { get; set; }

        /// <summary>
        /// Checks to see if the Demographic property is set.
        /// </summary>
        internal bool IsSetDemographic() => this.Demographic != null;

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the endpoint is updated.
        /// </para>
        /// </summary>
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDate property is set.
        /// </summary>
        internal bool IsSetEffectiveDate() => this.EffectiveDate != null;

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// Specifies whether to send messages or push notifications to the endpoint. Valid values
        /// are: ACTIVE, messages are sent to the endpoint; and, INACTIVE, messages aren’t sent
        /// to the endpoint.
        /// </para>
        ///  
        /// <para>
        /// Amazon Pinpoint automatically sets this value to ACTIVE when you create an endpoint
        /// or update an existing endpoint. Amazon Pinpoint automatically sets this value to INACTIVE
        /// if you update another endpoint that has the same address specified by the Address
        /// property.
        /// </para>
        /// </summary>
        public string EndpointStatus { get; set; }

        /// <summary>
        /// Checks to see if the EndpointStatus property is set.
        /// </summary>
        internal bool IsSetEndpointStatus() => this.EndpointStatus != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The geographic information for the endpoint.
        /// </para>
        /// </summary>
        public EndpointLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more custom metrics that your app reports to Amazon Pinpoint for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptOut. 
        /// <para>
        /// Specifies whether the user who's associated with the endpoint has opted out of receiving
        /// messages and push notifications from you. Possible values are: ALL, the user has opted
        /// out and doesn't want to receive any messages or push notifications; and, NONE, the
        /// user hasn't opted out and wants to receive all messages and push notifications.
        /// </para>
        /// </summary>
        public string OptOut { get; set; }

        /// <summary>
        /// Checks to see if the OptOut property is set.
        /// </summary>
        internal bool IsSetOptOut() => this.OptOut != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique identifier for the most recent request to update the endpoint.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// One or more custom attributes that describe the user who's associated with the endpoint.
        /// </para>
        /// </summary>
        public EndpointUser User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
