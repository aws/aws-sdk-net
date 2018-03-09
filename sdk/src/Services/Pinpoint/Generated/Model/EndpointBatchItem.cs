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
    /// Endpoint update request
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
        /// Gets and sets the property Address. The address or token of the endpoint as provided
        /// by your push provider (e.g. DeviceToken or RegistrationId).
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
        /// Gets and sets the property Attributes. Custom attributes that describe the endpoint
        /// by associating a name with an array of values. For example, an attribute named "interests"
        /// might have the values ["science", "politics", "travel"]. You can use these attributes
        /// as selection criteria when you create a segment of users to engage with a messaging
        /// campaign.The following characters are not recommended in attribute names: # : ? \
        /// /. The Amazon Pinpoint console does not display attributes that include these characters
        /// in the name. This limitation does not apply to attribute values.
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
        /// Gets and sets the property ChannelType. The channel type.Valid values: GCM | APNS
        /// | APNS_SANDBOX | APNS_VOIP | APNS_VOIP_SANDBOX | ADM | SMS | EMAIL | BAIDU
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
        /// Gets and sets the property Demographic. The endpoint demographic attributes.
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
        /// Gets and sets the property EffectiveDate. The last time the endpoint was updated.
        /// Provided in ISO 8601 format.
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
        /// Gets and sets the property EndpointStatus. The endpoint status. Can be either ACTIVE
        /// or INACTIVE. Will be set to INACTIVE if a delivery fails. Will be set to ACTIVE if
        /// the address is updated.
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
        /// Gets and sets the property Id. The unique Id for the Endpoint in the batch.
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
        /// Gets and sets the property Location. The endpoint location attributes.
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
        /// Gets and sets the property Metrics. Custom metrics that your app reports to Amazon
        /// Pinpoint.
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
        /// Gets and sets the property OptOut. Indicates whether a user has opted out of receiving
        /// messages with one of the following values:ALL - User has opted out of all messages.NONE
        /// - Users has not opted out and receives all messages.
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
        /// Gets and sets the property RequestId. The unique ID for the most recent request to
        /// update the endpoint.
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
        /// Gets and sets the property User. Custom user-specific attributes that your app reports
        /// to Amazon Pinpoint.
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