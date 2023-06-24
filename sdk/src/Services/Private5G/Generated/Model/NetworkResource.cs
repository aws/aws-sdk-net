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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about a network resource.
    /// </summary>
    public partial class NetworkResource
    {
        private List<NameValuePair> _attributes = new List<NameValuePair>();
        private DateTime? _createdAt;
        private string _description;
        private HealthStatus _health;
        private string _model;
        private string _networkArn;
        private string _networkResourceArn;
        private string _networkSiteArn;
        private string _orderArn;
        private Position _position;
        private ReturnInformation _returnInformation;
        private string _serialNumber;
        private NetworkResourceStatus _status;
        private string _statusReason;
        private NetworkResourceType _type;
        private string _vendor;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the network resource.
        /// </para>
        /// </summary>
        public List<NameValuePair> Attributes
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The creation time of the network resource.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the network resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The health of the network resource.
        /// </para>
        /// </summary>
        public HealthStatus Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of the network resource.
        /// </para>
        /// </summary>
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network on which this network resource appears.
        /// </para>
        /// </summary>
        public string NetworkArn
        {
            get { return this._networkArn; }
            set { this._networkArn = value; }
        }

        // Check to see if NetworkArn property is set
        internal bool IsSetNetworkArn()
        {
            return this._networkArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network resource.
        /// </para>
        /// </summary>
        public string NetworkResourceArn
        {
            get { return this._networkResourceArn; }
            set { this._networkResourceArn = value; }
        }

        // Check to see if NetworkResourceArn property is set
        internal bool IsSetNetworkResourceArn()
        {
            return this._networkResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkSiteArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network site on which this network resource
        /// appears.
        /// </para>
        /// </summary>
        public string NetworkSiteArn
        {
            get { return this._networkSiteArn; }
            set { this._networkSiteArn = value; }
        }

        // Check to see if NetworkSiteArn property is set
        internal bool IsSetNetworkSiteArn()
        {
            return this._networkSiteArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the order used to purchase this network resource.
        /// </para>
        /// </summary>
        public string OrderArn
        {
            get { return this._orderArn; }
            set { this._orderArn = value; }
        }

        // Check to see if OrderArn property is set
        internal bool IsSetOrderArn()
        {
            return this._orderArn != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position of the network resource.
        /// </para>
        /// </summary>
        public Position Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnInformation. 
        /// <para>
        /// Information about a request to return the network resource.
        /// </para>
        /// </summary>
        public ReturnInformation ReturnInformation
        {
            get { return this._returnInformation; }
            set { this._returnInformation = value; }
        }

        // Check to see if ReturnInformation property is set
        internal bool IsSetReturnInformation()
        {
            return this._returnInformation != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the network resource.
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the network resource.
        /// </para>
        /// </summary>
        public NetworkResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status reason of the network resource.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the network resource.
        /// </para>
        /// </summary>
        public NetworkResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The vendor of the network resource.
        /// </para>
        /// </summary>
        public string Vendor
        {
            get { return this._vendor; }
            set { this._vendor = value; }
        }

        // Check to see if Vendor property is set
        internal bool IsSetVendor()
        {
            return this._vendor != null;
        }

    }
}