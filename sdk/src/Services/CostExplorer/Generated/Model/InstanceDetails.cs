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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details about the reservations that Amazon Web Services recommends that you purchase.
    /// </summary>
    public partial class InstanceDetails
    {
        private EC2InstanceDetails _ec2InstanceDetails;
        private ElastiCacheInstanceDetails _elastiCacheInstanceDetails;
        private ESInstanceDetails _esInstanceDetails;
        private MemoryDBInstanceDetails _memoryDBInstanceDetails;
        private RDSInstanceDetails _rdsInstanceDetails;
        private RedshiftInstanceDetails _redshiftInstanceDetails;

        /// <summary>
        /// Gets and sets the property EC2InstanceDetails. 
        /// <para>
        /// The Amazon EC2 reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public EC2InstanceDetails EC2InstanceDetails
        {
            get { return this._ec2InstanceDetails; }
            set { this._ec2InstanceDetails = value; }
        }

        // Check to see if EC2InstanceDetails property is set
        internal bool IsSetEC2InstanceDetails()
        {
            return this._ec2InstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ElastiCacheInstanceDetails. 
        /// <para>
        /// The ElastiCache reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public ElastiCacheInstanceDetails ElastiCacheInstanceDetails
        {
            get { return this._elastiCacheInstanceDetails; }
            set { this._elastiCacheInstanceDetails = value; }
        }

        // Check to see if ElastiCacheInstanceDetails property is set
        internal bool IsSetElastiCacheInstanceDetails()
        {
            return this._elastiCacheInstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ESInstanceDetails. 
        /// <para>
        /// The Amazon OpenSearch Service reservations that Amazon Web Services recommends that
        /// you purchase.
        /// </para>
        /// </summary>
        public ESInstanceDetails ESInstanceDetails
        {
            get { return this._esInstanceDetails; }
            set { this._esInstanceDetails = value; }
        }

        // Check to see if ESInstanceDetails property is set
        internal bool IsSetESInstanceDetails()
        {
            return this._esInstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryDBInstanceDetails. 
        /// <para>
        /// The MemoryDB reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public MemoryDBInstanceDetails MemoryDBInstanceDetails
        {
            get { return this._memoryDBInstanceDetails; }
            set { this._memoryDBInstanceDetails = value; }
        }

        // Check to see if MemoryDBInstanceDetails property is set
        internal bool IsSetMemoryDBInstanceDetails()
        {
            return this._memoryDBInstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RDSInstanceDetails. 
        /// <para>
        /// The Amazon RDS reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public RDSInstanceDetails RDSInstanceDetails
        {
            get { return this._rdsInstanceDetails; }
            set { this._rdsInstanceDetails = value; }
        }

        // Check to see if RDSInstanceDetails property is set
        internal bool IsSetRDSInstanceDetails()
        {
            return this._rdsInstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftInstanceDetails. 
        /// <para>
        /// The Amazon Redshift reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public RedshiftInstanceDetails RedshiftInstanceDetails
        {
            get { return this._redshiftInstanceDetails; }
            set { this._redshiftInstanceDetails = value; }
        }

        // Check to see if RedshiftInstanceDetails property is set
        internal bool IsSetRedshiftInstanceDetails()
        {
            return this._redshiftInstanceDetails != null;
        }

    }
}