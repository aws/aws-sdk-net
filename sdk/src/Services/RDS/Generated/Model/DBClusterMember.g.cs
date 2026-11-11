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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains information about an instance that is part of a DB cluster.
    /// </summary>
    public partial class DBClusterMember
    {
        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupStatus. 
        /// <para>
        /// Specifies the status of the DB cluster parameter group for this member of the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterParameterGroupStatus { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterParameterGroupStatus property is set.
        /// </summary>
        internal bool IsSetDBClusterParameterGroupStatus() => this.DBClusterParameterGroupStatus != null;

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// Specifies the instance identifier for this member of the DB cluster.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property IsClusterWriter. 
        /// <para>
        /// Indicates whether the cluster member is the primary DB instance for the DB cluster.
        /// </para>
        /// </summary>
        public bool? IsClusterWriter { get; set; }

        /// <summary>
        /// Checks to see if the IsClusterWriter property is set.
        /// </summary>
        internal bool IsSetIsClusterWriter() => this.IsClusterWriter.HasValue;

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which an Aurora Replica is promoted to the primary
        /// instance after a failure of the existing primary instance. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.Managing.Backups.html#Aurora.Managing.FaultTolerance">
        /// Fault Tolerance for an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        public int? PromotionTier { get; set; }

        /// <summary>
        /// Checks to see if the PromotionTier property is set.
        /// </summary>
        internal bool IsSetPromotionTier() => this.PromotionTier.HasValue;
    }
}
