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
    /// Container for the parameters to the CreateDBShardGroup operation.
    /// Creates a new DB shard group for Aurora Limitless Database. You must enable Aurora
    /// Limitless Database to create a DB shard group.
    /// 
    ///  
    /// <para>
    /// Valid for: Aurora DB clusters only
    /// </para>
    /// </summary>
    public partial class CreateDBShardGroupRequest : AmazonRDSRequest
    {
        private int? _computeRedundancy;
        private string _dbClusterIdentifier;
        private string _dbShardGroupIdentifier;
        private double? _maxACU;
        private double? _minACU;
        private bool? _publiclyAccessible;

        /// <summary>
        /// Gets and sets the property ComputeRedundancy. 
        /// <para>
        /// Specifies whether to create standby instances for the DB shard group. Valid values
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0 - Creates a single, primary DB instance for each physical shard. This is the default
        /// value, and the only one supported for the preview.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1 - Creates a primary DB instance and a standby instance in a different Availability
        /// Zone (AZ) for each physical shard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2 - Creates a primary DB instance and two standby instances in different AZs for each
        /// physical shard.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? ComputeRedundancy
        {
            get { return this._computeRedundancy; }
            set { this._computeRedundancy = value; }
        }

        // Check to see if ComputeRedundancy property is set
        internal bool IsSetComputeRedundancy()
        {
            return this._computeRedundancy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The name of the primary DB cluster for the DB shard group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBShardGroupIdentifier. 
        /// <para>
        /// The name of the DB shard group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBShardGroupIdentifier
        {
            get { return this._dbShardGroupIdentifier; }
            set { this._dbShardGroupIdentifier = value; }
        }

        // Check to see if DBShardGroupIdentifier property is set
        internal bool IsSetDBShardGroupIdentifier()
        {
            return this._dbShardGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxACU. 
        /// <para>
        /// The maximum capacity of the DB shard group in Aurora capacity units (ACUs).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? MaxACU
        {
            get { return this._maxACU; }
            set { this._maxACU = value; }
        }

        // Check to see if MaxACU property is set
        internal bool IsSetMaxACU()
        {
            return this._maxACU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinACU. 
        /// <para>
        /// The minimum capacity of the DB shard group in Aurora capacity units (ACUs).
        /// </para>
        /// </summary>
        public double? MinACU
        {
            get { return this._minACU; }
            set { this._minACU = value; }
        }

        // Check to see if MinACU property is set
        internal bool IsSetMinACU()
        {
            return this._minACU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the DB shard group is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB shard group is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB shard group's virtual private
        /// cloud (VPC). It resolves to the public IP address from outside of the DB shard group's
        /// VPC. Access to the DB shard group is ultimately controlled by the security group it
        /// uses. That public access is not permitted if the security group assigned to the DB
        /// shard group doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB shard group isn't publicly accessible, it is an internal DB shard group
        /// with a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// Default: The default behavior varies depending on whether <c>DBSubnetGroupName</c>
        /// is specified.
        /// </para>
        ///  
        /// <para>
        /// If <c>DBSubnetGroupName</c> isn't specified, and <c>PubliclyAccessible</c> isn't specified,
        /// the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the default VPC in the target Region doesn’t have an internet gateway attached
        /// to it, the DB shard group is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the default VPC in the target Region has an internet gateway attached to it, the
        /// DB shard group is public.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <c>DBSubnetGroupName</c> is specified, and <c>PubliclyAccessible</c> isn't specified,
        /// the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the subnets are part of a VPC that doesn’t have an internet gateway attached to
        /// it, the DB shard group is private.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the subnets are part of a VPC that has an internet gateway attached to it, the
        /// DB shard group is public.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

    }
}