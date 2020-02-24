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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBClusterParameterGroup operation.
    /// Creates a new cluster parameter group.
    /// 
    ///  
    /// <para>
    /// Parameters in a cluster parameter group apply to all of the instances in a DB cluster.
    /// </para>
    ///  
    /// <para>
    /// A cluster parameter group is initially created with the default parameters for the
    /// database engine used by instances in the cluster. To provide custom values for any
    /// of the parameters, you must modify the group after you create it. After you create
    /// a DB cluster parameter group, you must associate it with your cluster. For the new
    /// DB cluster parameter group and associated settings to take effect, you must then reboot
    /// the instances in the cluster without failover.
    /// </para>
    ///  <important> 
    /// <para>
    /// After you create a cluster parameter group, you should wait at least 5 minutes before
    /// creating your first cluster that uses that cluster parameter group as the default
    /// parameter group. This allows Amazon DocumentDB to fully complete the create action
    /// before the cluster parameter group is used as the default for a new cluster. This
    /// step is especially important for parameters that are critical when creating the default
    /// database for a cluster, such as the character set for the default database defined
    /// by the <code>character_set_database</code> parameter.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateDBClusterParameterGroupRequest : AmazonDocDBRequest
    {
        private string _dbClusterParameterGroupName;
        private string _dbParameterGroupFamily;
        private string _description;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the cluster parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must not match the name of an existing <code>DBClusterParameterGroup</code>.
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
        /// The cluster parameter group family name.
        /// </para>
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
        /// The description for the cluster parameter group.
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
        /// The tags to be assigned to the cluster parameter group.
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