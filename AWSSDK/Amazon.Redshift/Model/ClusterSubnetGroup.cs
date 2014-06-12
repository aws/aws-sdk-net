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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a subnet group.
    /// </summary>
    public partial class ClusterSubnetGroup
    {
        private string _clusterSubnetGroupName;
        private string _description;
        private string _subnetGroupStatus;
        private List<Subnet> _subnets = new List<Subnet>();
        private string _vpcId;


        /// <summary>
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        ///         The name of the cluster subnet group.        
        /// </para>
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this._clusterSubnetGroupName; }
            set { this._clusterSubnetGroupName = value; }
        }


        /// <summary>
        /// Sets the ClusterSubnetGroupName property
        /// </summary>
        /// <param name="clusterSubnetGroupName">The value to set for the ClusterSubnetGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSubnetGroup WithClusterSubnetGroupName(string clusterSubnetGroupName)
        {
            this._clusterSubnetGroupName = clusterSubnetGroupName;
            return this;
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this._clusterSubnetGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///         The description of the cluster subnet group.        
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSubnetGroup WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property SubnetGroupStatus. 
        /// <para>
        ///             The status of the cluster subnet group.  Possible values are <code>Complete</code>,
        ///             <code>Incomplete</code> and <code>Invalid</code>.        
        /// </para>
        /// </summary>
        public string SubnetGroupStatus
        {
            get { return this._subnetGroupStatus; }
            set { this._subnetGroupStatus = value; }
        }


        /// <summary>
        /// Sets the SubnetGroupStatus property
        /// </summary>
        /// <param name="subnetGroupStatus">The value to set for the SubnetGroupStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSubnetGroup WithSubnetGroupStatus(string subnetGroupStatus)
        {
            this._subnetGroupStatus = subnetGroupStatus;
            return this;
        }

        // Check to see if SubnetGroupStatus property is set
        internal bool IsSetSubnetGroupStatus()
        {
            return this._subnetGroupStatus != null;
        }


        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        ///         A list of the VPC <a>Subnet</a> elements.        
        /// </para>
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        /// <summary>
        /// Sets the Subnets property
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSubnetGroup WithSubnets(params Subnet[] subnets)
        {
            foreach (var element in subnets)
            {
                this._subnets.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Subnets property
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSubnetGroup WithSubnets(IEnumerable<Subnet> subnets)
        {
            foreach (var element in subnets)
            {
                this._subnets.Add(element);
            }
            return this;
        }
        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        ///         The VPC ID of the cluster subnet group.        
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }


        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSubnetGroup WithVpcId(string vpcId)
        {
            this._vpcId = vpcId;
            return this;
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}