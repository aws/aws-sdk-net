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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains information about an instance that is part of a DB cluster.
    /// </summary>
    public partial class DBClusterMember
    {
        private string _dbClusterParameterGroupStatus;
        private string _dbInstanceIdentifier;
        private bool? _isClusterWriter;
        private int? _promotionTier;

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupStatus. 
        /// <para>
        /// Specifies the status of the DB cluster parameter group for this member of the DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterParameterGroupStatus
        {
            get { return this._dbClusterParameterGroupStatus; }
            set { this._dbClusterParameterGroupStatus = value; }
        }

        // Check to see if DBClusterParameterGroupStatus property is set
        internal bool IsSetDBClusterParameterGroupStatus()
        {
            return this._dbClusterParameterGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// Specifies the instance identifier for this member of the DB cluster.
        /// </para>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IsClusterWriter. 
        /// <para>
        /// Value that is <code>true</code> if the cluster member is the primary instance for
        /// the DB cluster and <code>false</code> otherwise.
        /// </para>
        /// </summary>
        public bool IsClusterWriter
        {
            get { return this._isClusterWriter.GetValueOrDefault(); }
            set { this._isClusterWriter = value; }
        }

        // Check to see if IsClusterWriter property is set
        internal bool IsSetIsClusterWriter()
        {
            return this._isClusterWriter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PromotionTier. 
        /// <para>
        /// A value that specifies the order in which an Aurora Replica is promoted to the primary
        /// instance after a failure of the existing primary instance. For more information, see
        /// <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Aurora.Managing.html#Aurora.Managing.FaultTolerance">
        /// Fault Tolerance for an Aurora DB Cluster</a>. 
        /// </para>
        /// </summary>
        public int PromotionTier
        {
            get { return this._promotionTier.GetValueOrDefault(); }
            set { this._promotionTier = value; }
        }

        // Check to see if PromotionTier property is set
        internal bool IsSetPromotionTier()
        {
            return this._promotionTier.HasValue; 
        }

    }
}