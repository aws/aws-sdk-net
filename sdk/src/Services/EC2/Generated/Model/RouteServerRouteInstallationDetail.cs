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
    /// Describes the installation status of a route in a route table.
    /// </summary>
    public partial class RouteServerRouteInstallationDetail
    {
        private RouteServerRouteInstallationStatus _routeInstallationStatus;
        private string _routeInstallationStatusReason;
        private string _routeTableId;

        /// <summary>
        /// Gets and sets the property RouteInstallationStatus. 
        /// <para>
        /// The current installation status of the route in the route table.
        /// </para>
        /// </summary>
        public RouteServerRouteInstallationStatus RouteInstallationStatus
        {
            get { return this._routeInstallationStatus; }
            set { this._routeInstallationStatus = value; }
        }

        // Check to see if RouteInstallationStatus property is set
        internal bool IsSetRouteInstallationStatus()
        {
            return this._routeInstallationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RouteInstallationStatusReason. 
        /// <para>
        /// The reason for the current installation status of the route.
        /// </para>
        /// </summary>
        public string RouteInstallationStatusReason
        {
            get { return this._routeInstallationStatusReason; }
            set { this._routeInstallationStatusReason = value; }
        }

        // Check to see if RouteInstallationStatusReason property is set
        internal bool IsSetRouteInstallationStatusReason()
        {
            return this._routeInstallationStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table where the route is being installed.
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

    }
}