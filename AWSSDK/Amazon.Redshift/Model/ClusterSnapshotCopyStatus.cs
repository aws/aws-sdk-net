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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Returns the destination region and retention period that are configured for cross-region snapshot copy. </para>
    /// </summary>
    public partial class ClusterSnapshotCopyStatus
    {
        
        private string destinationRegion;
        private long? retentionPeriod;

        /// <summary>
        /// The destination region that snapshots are automatically copied to when cross-region snapshot copy is enabled.
        ///  
        /// </summary>
        public string DestinationRegion
        {
            get { return this.destinationRegion; }
            set { this.destinationRegion = value; }
        }

        /// <summary>
        /// Sets the DestinationRegion property
        /// </summary>
        /// <param name="destinationRegion">The value to set for the DestinationRegion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSnapshotCopyStatus WithDestinationRegion(string destinationRegion)
        {
            this.destinationRegion = destinationRegion;
            return this;
        }
            

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this.destinationRegion != null;
        }

        /// <summary>
        /// The number of days that automated snapshots are retained in the destination region after they are copied from a source region.
        ///  
        /// </summary>
        public long RetentionPeriod
        {
            get { return this.retentionPeriod ?? default(long); }
            set { this.retentionPeriod = value; }
        }

        /// <summary>
        /// Sets the RetentionPeriod property
        /// </summary>
        /// <param name="retentionPeriod">The value to set for the RetentionPeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSnapshotCopyStatus WithRetentionPeriod(long retentionPeriod)
        {
            this.retentionPeriod = retentionPeriod;
            return this;
        }
            

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this.retentionPeriod.HasValue;
        }
    }
}
