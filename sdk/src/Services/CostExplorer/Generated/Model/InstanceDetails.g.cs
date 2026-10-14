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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EC2InstanceDetails. 
        /// <para>
        /// The Amazon EC2 reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public EC2InstanceDetails EC2InstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the EC2InstanceDetails property is set.
        /// </summary>
        internal bool IsSetEC2InstanceDetails() => this.EC2InstanceDetails != null;

        /// <summary>
        /// Gets and sets the property ESInstanceDetails. 
        /// <para>
        /// The Amazon OpenSearch Service reservations that Amazon Web Services recommends that
        /// you purchase.
        /// </para>
        /// </summary>
        public ESInstanceDetails ESInstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ESInstanceDetails property is set.
        /// </summary>
        internal bool IsSetESInstanceDetails() => this.ESInstanceDetails != null;

        /// <summary>
        /// Gets and sets the property ElastiCacheInstanceDetails. 
        /// <para>
        /// The ElastiCache reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public ElastiCacheInstanceDetails ElastiCacheInstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ElastiCacheInstanceDetails property is set.
        /// </summary>
        internal bool IsSetElastiCacheInstanceDetails() => this.ElastiCacheInstanceDetails != null;

        /// <summary>
        /// Gets and sets the property MemoryDBInstanceDetails. 
        /// <para>
        /// The MemoryDB reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public MemoryDBInstanceDetails MemoryDBInstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the MemoryDBInstanceDetails property is set.
        /// </summary>
        internal bool IsSetMemoryDBInstanceDetails() => this.MemoryDBInstanceDetails != null;

        /// <summary>
        /// Gets and sets the property RDSInstanceDetails. 
        /// <para>
        /// The Amazon RDS reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public RDSInstanceDetails RDSInstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the RDSInstanceDetails property is set.
        /// </summary>
        internal bool IsSetRDSInstanceDetails() => this.RDSInstanceDetails != null;

        /// <summary>
        /// Gets and sets the property RedshiftInstanceDetails. 
        /// <para>
        /// The Amazon Redshift reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public RedshiftInstanceDetails RedshiftInstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftInstanceDetails property is set.
        /// </summary>
        internal bool IsSetRedshiftInstanceDetails() => this.RedshiftInstanceDetails != null;
    }
}
