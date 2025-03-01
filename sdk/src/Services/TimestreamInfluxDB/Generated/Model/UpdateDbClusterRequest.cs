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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDbCluster operation.
    /// Updates a Timestream for InfluxDB cluster.
    /// </summary>
    public partial class UpdateDbClusterRequest : AmazonTimestreamInfluxDBRequest
    {
        private string _dbClusterId;
        private DbInstanceType _dbInstanceType;
        private string _dbParameterGroupIdentifier;
        private FailoverMode _failoverMode;
        private LogDeliveryConfiguration _logDeliveryConfiguration;
        private int? _port;

        /// <summary>
        /// Gets and sets the property DbClusterId. 
        /// <para>
        /// Service-generated unique identifier of the DB cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string DbClusterId
        {
            get { return this._dbClusterId; }
            set { this._dbClusterId = value; }
        }

        // Check to see if DbClusterId property is set
        internal bool IsSetDbClusterId()
        {
            return this._dbClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// Update the DB cluster to use the specified DB instance Type.
        /// </para>
        /// </summary>
        public DbInstanceType DbInstanceType
        {
            get { return this._dbInstanceType; }
            set { this._dbInstanceType = value; }
        }

        // Check to see if DbInstanceType property is set
        internal bool IsSetDbInstanceType()
        {
            return this._dbInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property DbParameterGroupIdentifier. 
        /// <para>
        /// Update the DB cluster to use the specified DB parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string DbParameterGroupIdentifier
        {
            get { return this._dbParameterGroupIdentifier; }
            set { this._dbParameterGroupIdentifier = value; }
        }

        // Check to see if DbParameterGroupIdentifier property is set
        internal bool IsSetDbParameterGroupIdentifier()
        {
            return this._dbParameterGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// Update the DB cluster's failover behavior.
        /// </para>
        /// </summary>
        public FailoverMode FailoverMode
        {
            get { return this._failoverMode; }
            set { this._failoverMode = value; }
        }

        // Check to see if FailoverMode property is set
        internal bool IsSetFailoverMode()
        {
            return this._failoverMode != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// The log delivery configuration to apply to the DB cluster.
        /// </para>
        /// </summary>
        public LogDeliveryConfiguration LogDeliveryConfiguration
        {
            get { return this._logDeliveryConfiguration; }
            set { this._logDeliveryConfiguration = value; }
        }

        // Check to see if LogDeliveryConfiguration property is set
        internal bool IsSetLogDeliveryConfiguration()
        {
            return this._logDeliveryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Update the DB cluster to use the specified port.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}