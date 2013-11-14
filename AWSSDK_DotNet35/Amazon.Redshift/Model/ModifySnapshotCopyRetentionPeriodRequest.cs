/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ModifySnapshotCopyRetentionPeriod operation.
    /// <para> Modifies the number of days to retain automated snapshots in the destination region after they are copied from the source region.
    /// </para>
    /// </summary>
    public partial class ModifySnapshotCopyRetentionPeriodRequest : AmazonRedshiftRequest
    {
        private string clusterIdentifier;
        private int? retentionPeriod;


        /// <summary>
        /// The unique identifier of the cluster for which you want to change the retention period for automated snapshots that are copied to a
        /// destination region. Constraints: Must be the valid name of an existing cluster that has cross-region snapshot copy enabled.
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The number of days to retain automated snapshots in the destination region after they are copied from the source region. If you decrease the
        /// retention period for automated snapshots that are copied to a destination region, Amazon Redshift will delete any existing automated
        /// snapshots that were copied to the destination region and that fall outside of the new retention period. Constraints: Must be at least 1 and
        /// no more than 35.
        ///  
        /// </summary>
        public int RetentionPeriod
        {
            get { return this.retentionPeriod ?? default(int); }
            set { this.retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this.retentionPeriod.HasValue;
        }

    }
}
    
