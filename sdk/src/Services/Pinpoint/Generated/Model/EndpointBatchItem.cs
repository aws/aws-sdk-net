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
    /// Specifies an endpoint to create or update and the settings and attributes to set or
    /// change for the endpoint.
    /// </summary>
    public partial class EndpointBatchItem
    {
        private string _address;
        private Dictionary<string, List<string>> _attributes = new Dictionary<string, List<string>>();
        private ChannelType _channelType;
        private EndpointDemographic _demographic;
        private string _effectiveDate;
        private string _endpointStatus;
        private string _id;
        private EndpointLocation _location;
        private Dictionary<string, double> _metrics = new Dictionary<string, double>();
        private string _optOut;
        private string _requestId;
        private EndpointUser _user;

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
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more custom attributes that describe the endpoint by associating a name with
        /// an array of values. For example, the value of a custom attribute named Interests might
        /// be: ["science", "music", "travel"]. You can use these attributes as filter criteria
        /// when you create segments.
        /// </para>
        ///  
        /// <para>
        /// When you define the name of a custom attribute, avoid using the following characters:
        /// number sign (#), colon (:), question mark (?), backslash (\), and slash (/). The Amazon
        /// Pinpoint console can't display attribute names that contain these characters. This
        /// limitation doesn't apply to attribute values.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// The channel to use when sending messages or push notifications to the endpoint.
        /// </para>
        /// </summary>
        public ChannelType ChannelType
        {
            get { return this._channelType; }
            set { this._channelType = value; }
        }

        // Check to see if ChannelType property is set
        internal bool IsSetChannelType()
        {
            return this._channelType != null;
        }

        /// <summary>
        /// Gets and sets the property Demographic. 
        /// <para>
        /// The demographic information for the endpoint, such as the time zone and platform.
        /// </para>
        /// </summary>
        public EndpointDemographic Demographic
        {
            get { return this._demographic; }
            set { this._demographic = value; }
        }

        // Check to see if Demographic property is set
        internal bool IsSetDemographic()
        {
            return this._demographic != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the endpoint was created or updated.
        /// </para>
        /// </summary>
        public string EffectiveDate
        {
            get { return this._effectiveDate; }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// Not used.
        /// </para>
        /// </summary>
        public string EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }

        // Check to see if EndpointStatus property is set
        internal bool IsSetEndpointStatus()
        {
            return this._endpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the endpoint in the context of the batch.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The geographic information for the endpoint.
        /// </para>
        /// </summary>
        public EndpointLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more custom metrics that your app reports to Amazon Pinpoint for the endpoint.
        /// </para>
        /// </summary>
        public Dictionary<string, double> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptOut. 
        /// <para>
        /// Specifies whether the user who's associated with the endpoint has opted out of receiving
        /// messages and push notifications from you. Possible values are: ALL, the user has opted
        /// out and doesn't want to receive any messages or push notifications; and, NONE, the
        /// user hasn't opted out and wants to receive all messages and push notifications.
        /// </para>
        /// </summary>
        public string OptOut
        {
            get { return this._optOut; }
            set { this._optOut = value; }
        }

        // Check to see if OptOut property is set
        internal bool IsSetOptOut()
        {
            return this._optOut != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique identifier for the request to create or update the endpoint.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// One or more custom user attributes that your app reports to Amazon Pinpoint for the
        /// user who's associated with the endpoint.
        /// </para>
        /// </summary>
        public EndpointUser User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}