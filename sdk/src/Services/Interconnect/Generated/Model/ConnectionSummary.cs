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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
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
namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Summarized view of a Connection object.
    /// </summary>
    public partial class ConnectionSummary
    {
        private string _arn;
        private AttachPoint _attachPoint;
        private string _bandwidth;
        private int? _billingTier;
        private string _description;
        private string _environmentId;
        private string _id;
        private string _location;
        private Provider _provider;
        private string _sharedId;
        private ConnectionState _state;
        private string _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=59, Max=150)]
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
        /// Gets and sets the property AttachPoint. 
        /// <para>
        /// The Attach Point to which the connection should be associated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttachPoint AttachPoint
        {
            get { return this._attachPoint; }
            set { this._attachPoint = value; }
        }

        // Check to see if AttachPoint property is set
        internal bool IsSetAttachPoint()
        {
            return this._attachPoint != null;
        }

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The bandwidth of the <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public string Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this._bandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property BillingTier. 
        /// <para>
        /// The billing tier this connection is currently assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8)]
        public int? BillingTier
        {
            get { return this._billingTier; }
            set { this._billingTier = value; }
        }

        // Check to see if BillingTier property is set
        internal bool IsSetBillingTier()
        {
            return this._billingTier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A descriptive name of the <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The <a>Environment</a> that this <a>Connection</a> is created on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the requested <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// The provider specific location at the remote end of this <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string Location
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
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider on the remote end of this <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Provider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property SharedId. 
        /// <para>
        /// An identifier used by both AWS and the remote partner to identify the specific connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SharedId
        {
            get { return this._sharedId; }
            set { this._sharedId = value; }
        }

        // Check to see if SharedId property is set
        internal bool IsSetSharedId()
        {
            return this._sharedId != null;
        }

        /// <summary>
        /// Gets and sets the property State. <ul> <li> 
        /// <para>
        ///  <c>requested</c>: The initial state of a connection. The state will remain here until
        /// the Connection is accepted on the Partner portal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The connection has been accepted and is being provisioned between
        /// AWS and the Partner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The connection has been fully provisioned between AWS and the Partner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The connection is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The connection has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c>: The connection has failed to be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>updating</c>: The connection is being updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The product variant supplied by this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=32)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}