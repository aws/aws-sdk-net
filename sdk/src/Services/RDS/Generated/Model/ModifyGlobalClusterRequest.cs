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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    /// Container for the parameters to the ModifyGlobalCluster operation.
    /// Modifies a setting for an Amazon Aurora global database cluster. You can change one
    /// or more database configuration parameters by specifying these parameters and the new
    /// values in the request. For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// This operation only applies to Aurora global database clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyGlobalClusterRequest : AmazonRDSRequest
    {
        private bool? _allowMajorVersionUpgrade;
        private bool? _deletionProtection;
        private string _engineVersion;
        private string _globalClusterIdentifier;
        private string _newGlobalClusterIdentifier;

        /// <summary>
        /// Gets and sets the property AllowMajorVersionUpgrade. 
        /// <para>
        /// Specifies whether to allow major version upgrades.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must be enabled if you specify a value for the <c>EngineVersion</c> parameter
        /// that's a different major version than the global cluster's current version.
        /// </para>
        ///  
        /// <para>
        /// If you upgrade the major version of a global database, the cluster and DB instance
        /// parameter groups are set to the default parameter groups for the new version. Apply
        /// any custom parameter groups after completing the upgrade.
        /// </para>
        /// </summary>
        public bool? AllowMajorVersionUpgrade
        {
            get { return this._allowMajorVersionUpgrade; }
            set { this._allowMajorVersionUpgrade = value; }
        }

        // Check to see if AllowMajorVersionUpgrade property is set
        internal bool IsSetAllowMajorVersionUpgrade()
        {
            return this._allowMajorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether to enable deletion protection for the global database cluster. The
        /// global database cluster can't be deleted when deletion protection is enabled.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version number of the database engine to which you want to upgrade. 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for <c>aurora-mysql</c> (for MySQL-based
        /// Aurora global databases), use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine aurora-mysql --query '*[]|[?SupportsGlobalDatabases
        /// == `true`].[EngineVersion]'</c> 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available engine versions for <c>aurora-postgresql</c> (for PostgreSQL-based
        /// Aurora global databases), use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --engine aurora-postgresql --query '*[]|[?SupportsGlobalDatabases
        /// == `true`].[EngineVersion]'</c> 
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalClusterIdentifier. 
        /// <para>
        /// The cluster identifier for the global cluster to modify. This parameter isn't case-sensitive.
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The new cluster identifier for the global database cluster. This value is stored as
        /// a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 1 to 63 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first character must be a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>my-cluster2</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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