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
    /// Violation detail for Network Firewall for a subnet that's not associated to the expected
    /// Firewall Manager managed route table.
    /// </summary>
    public partial class NetworkFirewallMissingExpectedRTViolation
    {
        private string _availabilityZone;
        private string _currentRouteTable;
        private string _expectedRouteTable;
        private string _violationTarget;
        private string _vpc;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of a violating subnet. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentRouteTable. 
        /// <para>
        /// The resource ID of the current route table that's associated with the subnet, if one
        /// is available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CurrentRouteTable
        {
            get { return this._currentRouteTable; }
            set { this._currentRouteTable = value; }
        }

        // Check to see if CurrentRouteTable property is set
        internal bool IsSetCurrentRouteTable()
        {
            return this._currentRouteTable != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedRouteTable. 
        /// <para>
        /// The resource ID of the route table that should be associated with the subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ExpectedRouteTable
        {
            get { return this._expectedRouteTable; }
            set { this._expectedRouteTable = value; }
        }

        // Check to see if ExpectedRouteTable property is set
        internal bool IsSetExpectedRouteTable()
        {
            return this._expectedRouteTable != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// The ID of the Network Firewall or VPC resource that's in violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ViolationTarget
        {
            get { return this._violationTarget; }
            set { this._violationTarget = value; }
        }

        // Check to see if ViolationTarget property is set
        internal bool IsSetViolationTarget()
        {
            return this._violationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// The resource ID of the VPC associated with a violating subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VPC
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if VPC property is set
        internal bool IsSetVPC()
        {
            return this._vpc != null;
        }

    }
}