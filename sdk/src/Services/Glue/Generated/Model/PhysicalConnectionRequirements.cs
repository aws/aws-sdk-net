/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the physical requirements for a connection.
    /// </summary>
    public partial class PhysicalConnectionRequirements
    {
        private string _availabilityZone;
        private List<string> _securityGroupIdList = new List<string>();
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The connection's availability zone.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SecurityGroupIdList. 
        /// <para>
        /// The security group ID list used by the connection.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIdList
        {
            get { return this._securityGroupIdList; }
            set { this._securityGroupIdList = value; }
        }

        // Check to see if SecurityGroupIdList property is set
        internal bool IsSetSecurityGroupIdList()
        {
            return this._securityGroupIdList != null && this._securityGroupIdList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID used by the connection.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}