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
    /// Container for the parameters to the CreateDBClusterParameterGroup operation.
    /// Creates a new DB cluster parameter group.
    /// 
    ///  
    /// <para>
    /// Parameters in a DB cluster parameter group apply to all of the instances in a DB cluster.
    /// </para>
    ///  
    /// <para>
    ///  A DB cluster parameter group is initially created with the default parameters for
    /// the database engine used by instances in the DB cluster. To provide custom values
    /// for any of the parameters, you must modify the group after creating it using <a>ModifyDBClusterParameterGroup</a>.
    /// Once you've created a DB cluster parameter group, you need to associate it with your
    /// DB cluster using <a>ModifyDBCluster</a>. When you associate a new DB cluster parameter
    /// group with a running DB cluster, you need to reboot the DB instances in the DB cluster
    /// without failover for the new DB cluster parameter group and associated settings to
    /// take effect. 
    /// </para>
    ///  <important> 
    /// <para>
    /// After you create a DB cluster parameter group, you should wait at least 5 minutes
    /// before creating your first DB cluster that uses that DB cluster parameter group as
    /// the default parameter group. This allows Amazon Neptune to fully complete the create
    /// action before the DB cluster parameter group is used as the default for a new DB cluster.
    /// This is especially important for parameters that are critical when creating the default
    /// database for a DB cluster, such as the character set for the default database defined
    /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
    /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon Neptune
    /// console</a> or the <a>DescribeDBClusterParameters</a> command to verify that your
    /// DB cluster parameter group has been created or modified.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
    /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class CreateDBClusterParameterGroupRequest : AmazonNeptuneRequest
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
        /// Must match the name of an existing DBClusterParameterGroup.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This value is stored as a lowercase string.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Example: <code>aurora5.6</code>, <code>aurora-mysql5.7</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Aurora PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Example: <code>aurora-postgresql9.6</code> 
        /// </para>
        /// </summary>
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