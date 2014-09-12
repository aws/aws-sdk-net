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

/*
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Modifies the number of days to retain automated snapshots in the destination
    /// region after they are copied from the source region.
    /// </summary>
    public partial class ModifySnapshotCopyRetentionPeriodRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private int? _retentionPeriod;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///            The unique identifier of the cluster for which you want to change the retention
        /// period for automated snapshots that are copied to a destination region.        
        /// </para>
        ///         
        /// <para>
        ///             Constraints: Must be the valid name of an existing cluster that has cross-region
        /// snapshot copy enabled.        
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        ///             The number of days to retain automated snapshots in the destination region
        /// after they are copied from the source region.        
        /// </para>
        ///         
        /// <para>
        ///             If you decrease the retention period for automated snapshots that are
        /// copied to a destination region, Amazon Redshift will delete any existing automated
        /// snapshots that were copied to the destination region and that fall outside of the
        /// new retention period.        
        /// </para>
        ///         
        /// <para>
        ///             Constraints: Must be at least 1 and no more than 35.        
        /// </para>
        /// </summary>
        public int RetentionPeriod
        {
            get { return this._retentionPeriod.GetValueOrDefault(); }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

    }
}