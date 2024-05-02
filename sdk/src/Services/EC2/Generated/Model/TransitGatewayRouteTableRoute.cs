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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a route in a transit gateway route table.
    /// </summary>
    public partial class TransitGatewayRouteTableRoute
    {
        private string _attachmentId;
        private string _destinationCidr;
        private string _prefixListId;
        private string _resourceId;
        private string _resourceType;
        private string _routeOrigin;
        private string _state;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the route attachment.
        /// </para>
        /// </summary>
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The CIDR block used for destination matches.
        /// </para>
        /// </summary>
        public string DestinationCidr
        {
            get { return this._destinationCidr; }
            set { this._destinationCidr = value; }
        }

        // Check to see if DestinationCidr property is set
        internal bool IsSetDestinationCidr()
        {
            return this._destinationCidr != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource for the route attachment.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type for the route attachment.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RouteOrigin. 
        /// <para>
        /// The route origin. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// static
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// propagated
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RouteOrigin
        {
            get { return this._routeOrigin; }
            set { this._routeOrigin = value; }
        }

        // Check to see if RouteOrigin property is set
        internal bool IsSetRouteOrigin()
        {
            return this._routeOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the route.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}