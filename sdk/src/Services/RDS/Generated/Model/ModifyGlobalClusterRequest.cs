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
    /// Container for the parameters to the ModifyGlobalCluster operation.
    /// Modify a setting for an Amazon Aurora global cluster. You can change one or more
    /// database configuration parameters by specifying these parameters and the new values
    /// in the request. For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i>
    /// </summary>
    public partial class ModifyGlobalClusterRequest : AmazonRDSRequest
    {
        private bool? _deletionProtection;
        private string _globalClusterIdentifier;
        private string _newGlobalClusterIdentifier;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        ///  Indicates if the global database cluster has deletion protection enabled. The global
        /// database cluster can't be deleted when this value is set to true. 
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        ///  The DB cluster identifier for the global cluster being modified. This parameter is
        /// not case-sensitive. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing global database cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string GlobalClusterIdentifier
        {
            get { return this._globalClusterIdentifier; }
            set { this._globalClusterIdentifier = value; }
        }

        // Check to see if GlobalClusterIdentifier property is set
        internal bool IsSetGlobalClusterIdentifier()
        {
            return this._globalClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property NewGlobalClusterIdentifier. 
        /// <para>
        ///  The new cluster identifier for the global database cluster when modifying a global
        /// database cluster. This value is stored as a lowercase string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>my-cluster2</code> 
        /// </para>
        /// </summary>
        public string NewGlobalClusterIdentifier
        {
            get { return this._newGlobalClusterIdentifier; }
            set { this._newGlobalClusterIdentifier = value; }
        }

        // Check to see if NewGlobalClusterIdentifier property is set
        internal bool IsSetNewGlobalClusterIdentifier()
        {
            return this._newGlobalClusterIdentifier != null;
        }

    }
}