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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Information about the expected route in the route table.
    /// </summary>
    public partial class ExpectedRoute
    {
        private List<string> _allowedTargets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _contributingSubnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ipV4Cidr;
        private string _ipV6Cidr;
        private string _prefixListId;
        private string _routeTableId;

        /// <summary>
        /// Gets and sets the property AllowedTargets. 
        /// <para>
        /// Information about the allowed targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedTargets
        {
            get { return this._allowedTargets; }
            set { this._allowedTargets = value; }
        }

        // Check to see if AllowedTargets property is set
        internal bool IsSetAllowedTargets()
        {
            return this._allowedTargets != null && (this._allowedTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContributingSubnets. 
        /// <para>
        /// Information about the contributing subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContributingSubnets
        {
            get { return this._contributingSubnets; }
            set { this._contributingSubnets = value; }
        }

        // Check to see if ContributingSubnets property is set
        internal bool IsSetContributingSubnets()
        {
            return this._contributingSubnets != null && (this._contributingSubnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpV4Cidr. 
        /// <para>
        /// Information about the IPv4 CIDR block.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IpV4Cidr
        {
            get { return this._ipV4Cidr; }
            set { this._ipV4Cidr = value; }
        }

        // Check to see if IpV4Cidr property is set
        internal bool IsSetIpV4Cidr()
        {
            return this._ipV4Cidr != null;
        }

        /// <summary>
        /// Gets and sets the property IpV6Cidr. 
        /// <para>
        /// Information about the IPv6 CIDR block.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IpV6Cidr
        {
            get { return this._ipV6Cidr; }
            set { this._ipV6Cidr = value; }
        }

        // Check to see if IpV6Cidr property is set
        internal bool IsSetIpV6Cidr()
        {
            return this._ipV6Cidr != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// Information about the ID of the prefix list for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// Information about the route table ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}