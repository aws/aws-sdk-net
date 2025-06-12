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
    /// Contains the details of an Amazon RDS DB subnet group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBSubnetGroups</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DBSubnetGroup
    {
        private string _dbSubnetGroupArn;
        private string _dbSubnetGroupDescription;
        private string _dbSubnetGroupName;
        private string _subnetGroupStatus;
        private List<Subnet> _subnets = AWSConfigs.InitializeCollections ? new List<Subnet>() : null;
        private List<string> _supportedNetworkTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroupArn
        {
            get { return this._dbSubnetGroupArn; }
            set { this._dbSubnetGroupArn = value; }
        }

        // Check to see if DBSubnetGroupArn property is set
        internal bool IsSetDBSubnetGroupArn()
        {
            return this._dbSubnetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupDescription. 
        /// <para>
        /// Provides the description of the DB subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroupDescription
        {
            get { return this._dbSubnetGroupDescription; }
            set { this._dbSubnetGroupDescription = value; }
        }

        // Check to see if DBSubnetGroupDescription property is set
        internal bool IsSetDBSubnetGroupDescription()
        {
            return this._dbSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The name of the DB subnet group.
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupStatus. 
        /// <para>
        /// Provides the status of the DB subnet group.
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
        /// Contains a list of <c>Subnet</c> elements. The list of subnets shown here might not
        /// reflect the current state of your VPC. For the most up-to-date information, we recommend
        /// checking your VPC configuration directly.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Subnet> Subnets
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
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// The network type of the DB subnet group.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <c>DBSubnetGroup</c> can support only the IPv4 protocol or the IPv4 and the IPv6
        /// protocols (<c>DUAL</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html">
        /// Working with a DB instance in a VPC</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes
        {
            get { return this._supportedNetworkTypes; }
            set { this._supportedNetworkTypes = value; }
        }

        // Check to see if SupportedNetworkTypes property is set
        internal bool IsSetSupportedNetworkTypes()
        {
            return this._supportedNetworkTypes != null && (this._supportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the VpcId of the DB subnet group.
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