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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the details for an Amazon RDS DB security group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBSecurityGroups</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBSecurityGroup
    {
        private string _dbSecurityGroupArn;
        private string _dbSecurityGroupDescription;
        private string _dbSecurityGroupName;
        private List<EC2SecurityGroup> _ec2SecurityGroups = AWSConfigs.InitializeCollections ? new List<EC2SecurityGroup>() : null;
        private List<IPRange> _ipRanges = AWSConfigs.InitializeCollections ? new List<IPRange>() : null;
        private string _ownerId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DBSecurityGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB security group.
        /// </para>
        /// </summary>
        public string DBSecurityGroupArn
        {
            get { return this._dbSecurityGroupArn; }
            set { this._dbSecurityGroupArn = value; }
        }

        // Check to see if DBSecurityGroupArn property is set
        internal bool IsSetDBSecurityGroupArn()
        {
            return this._dbSecurityGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupDescription. 
        /// <para>
        /// Provides the description of the DB security group.
        /// </para>
        /// </summary>
        public string DBSecurityGroupDescription
        {
            get { return this._dbSecurityGroupDescription; }
            set { this._dbSecurityGroupDescription = value; }
        }

        // Check to see if DBSecurityGroupDescription property is set
        internal bool IsSetDBSecurityGroupDescription()
        {
            return this._dbSecurityGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupName. 
        /// <para>
        /// Specifies the name of the DB security group.
        /// </para>
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this._dbSecurityGroupName; }
            set { this._dbSecurityGroupName = value; }
        }

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this._dbSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroups. 
        /// <para>
        /// Contains a list of <c>EC2SecurityGroup</c> elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this._ec2SecurityGroups; }
            set { this._ec2SecurityGroups = value; }
        }

        // Check to see if EC2SecurityGroups property is set
        internal bool IsSetEC2SecurityGroups()
        {
            return this._ec2SecurityGroups != null && (this._ec2SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IPRanges. 
        /// <para>
        /// Contains a list of <c>IPRange</c> elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IPRange> IPRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IPRanges property is set
        internal bool IsSetIPRanges()
        {
            return this._ipRanges != null && (this._ipRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// Provides the Amazon Web Services ID of the owner of a specific DB security group.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the VpcId of the DB security group.
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