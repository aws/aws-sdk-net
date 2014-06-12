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
    /// Container for the parameters to the EnableSnapshotCopy operation.
    /// Enables the automatic copy of snapshots from one region to another region for a specified
    /// cluster.
    /// </summary>
    public partial class EnableSnapshotCopyRequest : AmazonWebServiceRequest
    {
        private string _clusterIdentifier;
        private string _destinationRegion;
        private int? _retentionPeriod;


        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        ///             The unique identifier of the source cluster to copy snapshots from.  
        ///      
        /// </para>
        ///         
        /// <para>
        ///             Constraints: Must be the valid name of an existing cluster that does not
        /// already have cross-region snapshot copy enabled.        
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }


        /// <summary>
        /// Sets the ClusterIdentifier property
        /// </summary>
        /// <param name="clusterIdentifier">The value to set for the ClusterIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableSnapshotCopyRequest WithClusterIdentifier(string clusterIdentifier)
        {
            this._clusterIdentifier = clusterIdentifier;
            return this;
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        ///             The destination region that you want to copy snapshots to.        
        /// </para>
        ///         
        /// <para>
        ///             Constraints: Must be the name of a valid region. For more information,
        /// see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#redshift_region">Regions
        /// and Endpoints</a> in the Amazon Web Services General Reference.                
        /// </para>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }


        /// <summary>
        /// Sets the DestinationRegion property
        /// </summary>
        /// <param name="destinationRegion">The value to set for the DestinationRegion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableSnapshotCopyRequest WithDestinationRegion(string destinationRegion)
        {
            this._destinationRegion = destinationRegion;
            return this;
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }


        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        ///             The number of days to retain automated snapshots in the destination region
        /// after they are copied from the source region.        
        /// </para>
        ///         
        /// <para>
        ///             Default: 7.        
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


        /// <summary>
        /// Sets the RetentionPeriod property
        /// </summary>
        /// <param name="retentionPeriod">The value to set for the RetentionPeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableSnapshotCopyRequest WithRetentionPeriod(int retentionPeriod)
        {
            this._retentionPeriod = retentionPeriod;
            return this;
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

    }
}