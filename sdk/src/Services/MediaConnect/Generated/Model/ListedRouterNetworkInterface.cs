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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A summary of a router network interface, including its name, type, ARN, ID, associated
    /// input/output counts, state, and other key details. This structure is used in the response
    /// of the ListRouterNetworkInterfaces operation.
    /// </summary>
    public partial class ListedRouterNetworkInterface
    {
        private string _arn;
        private int? _associatedInputCount;
        private int? _associatedOutputCount;
        private DateTime? _createdAt;
        private string _id;
        private string _name;
        private RouterNetworkInterfaceType _networkInterfaceType;
        private string _regionName;
        private RouterNetworkInterfaceState _state;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AssociatedInputCount. 
        /// <para>
        /// The number of router inputs associated with the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int AssociatedInputCount
        {
            get { return this._associatedInputCount.GetValueOrDefault(); }
            set { this._associatedInputCount = value; }
        }

        // Check to see if AssociatedInputCount property is set
        internal bool IsSetAssociatedInputCount()
        {
            return this._associatedInputCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociatedOutputCount. 
        /// <para>
        /// The number of router outputs associated with the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int AssociatedOutputCount
        {
            get { return this._associatedOutputCount.GetValueOrDefault(); }
            set { this._associatedOutputCount = value; }
        }

        // Check to see if AssociatedOutputCount property is set
        internal bool IsSetAssociatedOutputCount()
        {
            return this._associatedOutputCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the network interface was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceType. 
        /// <para>
        /// The type of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterNetworkInterfaceType NetworkInterfaceType
        {
            get { return this._networkInterfaceType; }
            set { this._networkInterfaceType = value; }
        }

        // Check to see if NetworkInterfaceType property is set
        internal bool IsSetNetworkInterfaceType()
        {
            return this._networkInterfaceType != null;
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The AWS Region where the router network interface is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the router network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterNetworkInterfaceState State
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the router network interface was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}