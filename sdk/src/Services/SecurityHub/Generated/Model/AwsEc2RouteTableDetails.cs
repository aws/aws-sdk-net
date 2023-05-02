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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a route table for the specified VPC.
    /// </summary>
    public partial class AwsEc2RouteTableDetails
    {
        private List<AssociationSetDetails> _associationSet = new List<AssociationSetDetails>();
        private string _ownerId;
        private List<PropagatingVgwSetDetails> _propagatingVgwSet = new List<PropagatingVgwSetDetails>();
        private List<RouteSetDetails> _routeSet = new List<RouteSetDetails>();
        private string _routeTableId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AssociationSet. 
        /// <para>
        ///  The associations between a route table and one or more subnets or a gateway. 
        /// </para>
        /// </summary>
        public List<AssociationSetDetails> AssociationSet
        {
            get { return this._associationSet; }
            set { this._associationSet = value; }
        }

        // Check to see if AssociationSet property is set
        internal bool IsSetAssociationSet()
        {
            return this._associationSet != null && this._associationSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        ///  The ID of the Amazon Web Services account that owns the route table. 
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PropagatingVgwSet. 
        /// <para>
        ///  Describes a virtual private gateway propagating route. 
        /// </para>
        /// </summary>
        public List<PropagatingVgwSetDetails> PropagatingVgwSet
        {
            get { return this._propagatingVgwSet; }
            set { this._propagatingVgwSet = value; }
        }

        // Check to see if PropagatingVgwSet property is set
        internal bool IsSetPropagatingVgwSet()
        {
            return this._propagatingVgwSet != null && this._propagatingVgwSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RouteSet. 
        /// <para>
        ///  The routes in the route table. 
        /// </para>
        /// </summary>
        public List<RouteSetDetails> RouteSet
        {
            get { return this._routeSet; }
            set { this._routeSet = value; }
        }

        // Check to see if RouteSet property is set
        internal bool IsSetRouteSet()
        {
            return this._routeSet != null && this._routeSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        ///  The ID of the route table. 
        /// </para>
        /// </summary>
        public string RouteTableId
        {
            get { return this._routeTableId; }
            set { this._routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this._routeTableId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        ///  The ID of the virtual private cloud (VPC). 
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}