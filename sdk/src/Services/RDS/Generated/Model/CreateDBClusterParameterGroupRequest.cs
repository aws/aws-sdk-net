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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBClusterParameterGroup operation.
    /// Creates a new DB cluster parameter group.
    /// 
    ///  
    /// <para>
    /// Parameters in a DB cluster parameter group apply to all of the instances in a DB cluster.
    /// </para>
    ///  
    /// <para>
    /// A DB cluster parameter group is initially created with the default parameters for
    /// the database engine used by instances in the DB cluster. To provide custom values
    /// for any of the parameters, you must modify the group after creating it using <code>ModifyDBClusterParameterGroup</code>.
    /// Once you've created a DB cluster parameter group, you need to associate it with your
    /// DB cluster using <code>ModifyDBCluster</code>.
    /// </para>
    ///  
    /// <para>
    /// When you associate a new DB cluster parameter group with a running Aurora DB cluster,
    /// reboot the DB instances in the DB cluster without failover for the new DB cluster
    /// parameter group and associated settings to take effect.
    /// </para>
    ///  
    /// <para>
    /// When you associate a new DB cluster parameter group with a running Multi-AZ DB cluster,
    /// reboot the DB cluster without failover for the new DB cluster parameter group and
    /// associated settings to take effect.
    /// </para>
    ///  <important> 
    /// <para>
    /// After you create a DB cluster parameter group, you should wait at least 5 minutes
    /// before creating your first DB cluster that uses that DB cluster parameter group as
    /// the default parameter group. This allows Amazon RDS to fully complete the create action
    /// before the DB cluster parameter group is used as the default for a new DB cluster.
    /// This is especially important for parameters that are critical when creating the default
    /// database for a DB cluster, such as the character set for the default database defined
    /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
    /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon RDS
    /// console</a> or the <code>DescribeDBClusterParameters</code> operation to verify that
    /// your DB cluster parameter group has been created or modified.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDBClusterParameterGroupRequest : AmazonRDSRequest
    {
        private string _dbClusterParameterGroupName;
        private string _dbParameterGroupFamily;
        private string _description;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must not match the name of an existing DB cluster parameter group.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This value is stored as a lowercase string.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterParameterGroupName
        {
            get { return this._dbClusterParameterGroupName; }
            set { this._dbClusterParameterGroupName = value; }
        }

        // Check to see if DBClusterParameterGroupName property is set
        internal bool IsSetDBClusterParameterGroupName()
        {
            return this._dbClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The DB cluster parameter group family name. A DB cluster parameter group can be associated
        /// with one and only one DB cluster parameter group family, and can be applied only to
        /// a DB cluster running a database engine and engine version compatible with that DB
        /// cluster parameter group family.
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>aurora5.6</code>, <code>aurora-mysql5.7</code>, <code>aurora-mysql8.0</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>aurora-postgresql9.6</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>RDS for MySQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>mysql8.0</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>RDS for PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>postgres12</code> 
        /// </para>
        ///  
        /// <para>
        /// To list all of the available parameter group families for a DB engine, use the following
        /// command:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily"
        /// --engine &lt;engine&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// For example, to list all of the available parameter group families for the Aurora
        /// PostgreSQL DB engine, use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily"
        /// --engine aurora-postgresql</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The output contains duplicates.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following are the valid DB engine values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aurora</code> (for MySQL 5.6-compatible Aurora)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-mysql</code> (for MySQL 5.7-compatible and MySQL 8.0-compatible Aurora)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mysql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBParameterGroupFamily
        {
            get { return this._dbParameterGroupFamily; }
            set { this._dbParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this._dbParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the DB cluster parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the DB cluster parameter group.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}