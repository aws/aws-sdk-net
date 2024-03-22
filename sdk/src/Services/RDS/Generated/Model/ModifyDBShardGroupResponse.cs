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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the ModifyDBShardGroup operation.
    /// </summary>
    public partial class ModifyDBShardGroupResponse : AmazonWebServiceResponse
    {
        private int? _computeRedundancy;
        private string _dbClusterIdentifier;
        private string _dbShardGroupIdentifier;
        private string _dbShardGroupResourceId;
        private string _endpoint;
        private double? _maxACU;
        private bool? _publiclyAccessible;
        private string _status;

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
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property DBShardGroupResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the DB shard group.
        /// </para>
        /// </summary>
        public string DBShardGroupResourceId
        {
            get { return this._dbShardGroupResourceId; }
            set { this._dbShardGroupResourceId = value; }
        }

        // Check to see if DBShardGroupResourceId property is set
        internal bool IsSetDBShardGroupResourceId()
        {
            return this._dbShardGroupResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint for the DB shard group.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property MaxACU. 
        /// <para>
        /// The maximum capacity of the DB shard group in Aurora capacity units (ACUs).
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Indicates whether the DB shard group is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB shard group is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB shard group's virtual private
        /// cloud (VPC). It resolves to the public IP address from outside of the DB shard group's
        /// VPC. Access to the DB shard group is ultimately controlled by the security group it
        /// uses. That public access isn't permitted if the security group assigned to the DB
        /// shard group doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB shard group isn't publicly accessible, it is an internal DB shard group
        /// with a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBShardGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora Limitless Database.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB shard group.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}