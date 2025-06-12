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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the subnet group for the database instance.
    /// </summary>
    public partial class AwsRdsDbSubnetGroup
    {
        private string _dbSubnetGroupArn;
        private string _dbSubnetGroupDescription;
        private string _dbSubnetGroupName;
        private string _subnetGroupStatus;
        private List<AwsRdsDbSubnetGroupSubnet> _subnets = AWSConfigs.InitializeCollections ? new List<AwsRdsDbSubnetGroupSubnet>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DbSubnetGroupArn. 
        /// <para>
        /// The ARN of the subnet group.
        /// </para>
        /// </summary>
        public string DbSubnetGroupArn
        {
            get { return this._dbSubnetGroupArn; }
            set { this._dbSubnetGroupArn = value; }
        }

        // Check to see if DbSubnetGroupArn property is set
        internal bool IsSetDbSubnetGroupArn()
        {
            return this._dbSubnetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DbSubnetGroupDescription. 
        /// <para>
        /// The description of the subnet group.
        /// </para>
        /// </summary>
        public string DbSubnetGroupDescription
        {
            get { return this._dbSubnetGroupDescription; }
            set { this._dbSubnetGroupDescription = value; }
        }

        // Check to see if DbSubnetGroupDescription property is set
        internal bool IsSetDbSubnetGroupDescription()
        {
            return this._dbSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DbSubnetGroupName. 
        /// <para>
        /// The name of the subnet group.
        /// </para>
        /// </summary>
        public string DbSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DbSubnetGroupName property is set
        internal bool IsSetDbSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupStatus. 
        /// <para>
        /// The status of the subnet group.
        /// </para>
        /// </summary>
        public string SubnetGroupStatus
        {
            get { return this._subnetGroupStatus; }
            set { this._subnetGroupStatus = value; }
        }

        // Check to see if SubnetGroupStatus property is set
        internal bool IsSetSubnetGroupStatus()
        {
            return this._subnetGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// A list of subnets in the subnet group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbSubnetGroupSubnet> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID of the subnet group.
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