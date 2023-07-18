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
    /// Information about an order.
    /// </summary>
    public partial class Order
    {
        private AcknowledgmentStatus _acknowledgmentStatus;
        private DateTime? _createdAt;
        private string _networkArn;
        private string _networkSiteArn;
        private string _orderArn;
        private List<OrderedResourceDefinition> _orderedResources = new List<OrderedResourceDefinition>();
        private Address _shippingAddress;
        private List<TrackingInformation> _trackingInformation = new List<TrackingInformation>();

        /// <summary>
        /// Gets and sets the property AcknowledgmentStatus. 
        /// <para>
        /// The acknowledgement status of the order.
        /// </para>
        /// </summary>
        public AcknowledgmentStatus AcknowledgmentStatus
        {
            get { return this._acknowledgmentStatus; }
            set { this._acknowledgmentStatus = value; }
        }

        // Check to see if AcknowledgmentStatus property is set
        internal bool IsSetAcknowledgmentStatus()
        {
            return this._acknowledgmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The creation time of the order.
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
        /// Gets and sets the property NetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network associated with this order.
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
        /// Gets and sets the property NetworkSiteArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network site associated with this order.
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
        /// The Amazon Resource Name (ARN) of the order.
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
        /// Gets and sets the property OrderedResources. 
        /// <para>
        /// A list of the network resources placed in the order.
        /// </para>
        /// </summary>
        public List<OrderedResourceDefinition> OrderedResources
        {
            get { return this._orderedResources; }
            set { this._orderedResources = value; }
        }

        // Check to see if OrderedResources property is set
        internal bool IsSetOrderedResources()
        {
            return this._orderedResources != null && this._orderedResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// The shipping address of the order.
        /// </para>
        /// </summary>
        public Address ShippingAddress
        {
            get { return this._shippingAddress; }
            set { this._shippingAddress = value; }
        }

        // Check to see if ShippingAddress property is set
        internal bool IsSetShippingAddress()
        {
            return this._shippingAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingInformation. 
        /// <para>
        /// The tracking information of the order.
        /// </para>
        /// </summary>
        public List<TrackingInformation> TrackingInformation
        {
            get { return this._trackingInformation; }
            set { this._trackingInformation = value; }
        }

        // Check to see if TrackingInformation property is set
        internal bool IsSetTrackingInformation()
        {
            return this._trackingInformation != null && this._trackingInformation.Count > 0; 
        }

    }
}