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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// If your simulation job accesses resources in a VPC, you provide this parameter identifying
    /// the list of security group IDs and subnet IDs. These must belong to the same VPC.
    /// You must provide at least one security group and two subnet IDs.
    /// </summary>
    public partial class VPCConfig
    {
        private bool? _assignPublicIp;
        private List<string> _securityGroups = new List<string>();
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property AssignPublicIp. 
        /// <para>
        /// A boolean indicating whether to assign a public IP address.
        /// </para>
        /// </summary>
        public bool AssignPublicIp
        {
            get { return this._assignPublicIp.GetValueOrDefault(); }
            set { this._assignPublicIp = value; }
        }

        // Check to see if AssignPublicIp property is set
        internal bool IsSetAssignPublicIp()
        {
            return this._assignPublicIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of one or more security groups IDs in your VPC.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// A list of one or more subnet IDs in your VPC.
        /// </para>
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

    }
}