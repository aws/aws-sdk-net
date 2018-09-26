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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the StopDBCluster operation.
    /// Stops an Amazon Aurora DB cluster. When you stop a DB cluster, Aurora retains the
    /// DB cluster's metadata, including its endpoints and DB parameter groups. Aurora also
    /// retains the transaction logs so you can do a point-in-time restore if necessary. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-cluster-stop-start.html">
    /// Stopping and Starting an Aurora Cluster</a> in the <i>Amazon Aurora User Guide.</i>
    /// 
    /// </para>
    /// </summary>
    public partial class StopDBClusterRequest : AmazonRDSRequest
    {
        private string _dbClusterIdentifier;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier of the Amazon Aurora DB cluster to be stopped. This parameter
        /// is stored as a lowercase string.
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

    }
}