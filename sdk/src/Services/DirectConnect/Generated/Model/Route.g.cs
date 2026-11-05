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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about a route for a virtual interface.
    /// </summary>
    public partial class Route
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family of the route.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>ipv4</c> and <c>ipv6</c>.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property AsPath. 
        /// <para>
        /// The autonomous system (AS) path of the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AsPathSegment> AsPath { get; set; } = AWSConfigs.InitializeCollections ? new List<AsPathSegment>() : null;

        /// <summary>
        /// Checks to see if the AsPath property is set.
        /// </summary>
        internal bool IsSetAsPath() => this.AsPath != null && (this.AsPath.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsLogicalDeviceId. 
        /// <para>
        /// The Direct Connect endpoint that terminates the logical connection. This device might
        /// be different than the device that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsLogicalDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the AwsLogicalDeviceId property is set.
        /// </summary>
        internal bool IsSetAwsLogicalDeviceId() => this.AwsLogicalDeviceId != null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR (prefix) of the route.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property Communities. 
        /// <para>
        /// The BGP communities associated with the route.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Communities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Communities property is set.
        /// </summary>
        internal bool IsSetCommunities() => this.Communities != null && (this.Communities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteDirection. 
        /// <para>
        /// The direction of the route.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>accepted</c> (received from the customer network) and <c>advertised</c>
        /// (advertised to the customer network).
        /// </para>
        /// </summary>
        public RouteDirection RouteDirection { get; set; }

        /// <summary>
        /// Checks to see if the RouteDirection property is set.
        /// </summary>
        internal bool IsSetRouteDirection() => this.RouteDirection != null;

        /// <summary>
        /// Gets and sets the property RouteInstalledAt. 
        /// <para>
        /// The time when the route was installed. The value is displayed in UTC format.
        /// </para>
        /// </summary>
        public DateTime? RouteInstalledAt { get; set; }

        /// <summary>
        /// Checks to see if the RouteInstalledAt property is set.
        /// </summary>
        internal bool IsSetRouteInstalledAt() => this.RouteInstalledAt.HasValue;
    }
}
