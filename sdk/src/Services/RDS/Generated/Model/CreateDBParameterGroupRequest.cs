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
    /// Container for the parameters to the CreateDBParameterGroup operation.
    /// Creates a new DB parameter group.
    /// 
    ///  
    /// <para>
    /// A DB parameter group is initially created with the default parameters for the database
    /// engine used by the DB instance. To provide custom values for any of the parameters,
    /// you must modify the group after creating it using <code>ModifyDBParameterGroup</code>.
    /// Once you've created a DB parameter group, you need to associate it with your DB instance
    /// using <code>ModifyDBInstance</code>. When you associate a new DB parameter group with
    /// a running DB instance, you need to reboot the DB instance without failover for the
    /// new DB parameter group and associated settings to take effect.
    /// </para>
    ///  
    /// <para>
    /// This command doesn't apply to RDS Custom.
    /// </para>
    ///  <important> 
    /// <para>
    /// After you create a DB parameter group, you should wait at least 5 minutes before creating
    /// your first DB instance that uses that DB parameter group as the default parameter
    /// group. This allows Amazon RDS to fully complete the create action before the parameter
    /// group is used as the default for a new DB instance. This is especially important for
    /// parameters that are critical when creating the default database for a DB instance,
    /// such as the character set for the default database defined by the <code>character_set_database</code>
    /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
    /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
    /// parameter group has been created or modified.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupFamily;
        private string _dbParameterGroupName;
        private string _description;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBParameterGroupRequest() { }

        /// <summary>
        /// Instantiates CreateDBParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupName">The name of the DB parameter group. Constraints: <ul> <li> Must be 1 to 255 letters, numbers, or hyphens. </li> <li> First character must be a letter </li> <li> Can't end with a hyphen or contain two consecutive hyphens </li> </ul> <note> This value is stored as a lowercase string. </note></param>
        /// <param name="dbParameterGroupFamily">The DB parameter group family name. A DB parameter group can be associated with one and only one DB parameter group family, and can be applied only to a DB instance running a database engine and engine version compatible with that DB parameter group family. To list all of the available parameter group families for a DB engine, use the following command:  <code>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily" --engine &lt;engine&gt;</code>  For example, to list all of the available parameter group families for the MySQL DB engine, use the following command:  <code>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily" --engine mysql</code>  <note> The output contains duplicates. </note> The following are the valid DB engine values: <ul> <li>  <code>aurora-mysql</code>  </li> <li>  <code>aurora-postgresql</code>  </li> <li>  <code>mariadb</code>  </li> <li>  <code>mysql</code>  </li> <li>  <code>oracle-ee</code>  </li> <li>  <code>oracle-ee-cdb</code>  </li> <li>  <code>oracle-se2</code>  </li> <li>  <code>oracle-se2-cdb</code>  </li> <li>  <code>postgres</code>  </li> <li>  <code>sqlserver-ee</code>  </li> <li>  <code>sqlserver-se</code>  </li> <li>  <code>sqlserver-ex</code>  </li> <li>  <code>sqlserver-web</code>  </li> </ul></param>
        /// <param name="description">The description for the DB parameter group.</param>
        public CreateDBParameterGroupRequest(string dbParameterGroupName, string dbParameterGroupFamily, string description)
        {
            _dbParameterGroupName = dbParameterGroupName;
            _dbParameterGroupFamily = dbParameterGroupFamily;
            _description = description;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        /// The DB parameter group family name. A DB parameter group can be associated with one
        /// and only one DB parameter group family, and can be applied only to a DB instance running
        /// a database engine and engine version compatible with that DB parameter group family.
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
        /// For example, to list all of the available parameter group families for the MySQL DB
        /// engine, use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <code>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily"
        /// --engine mysql</code> 
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
        ///  <code>aurora-mysql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>aurora-postgresql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mariadb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mysql</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-ee-cdb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>oracle-se2-cdb</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>postgres</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ee</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-se</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-ex</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sqlserver-web</code> 
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
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be 1 to 255 letters, numbers, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't end with a hyphen or contain two consecutive hyphens
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This value is stored as a lowercase string.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBParameterGroupName
        {
            get { return this._dbParameterGroupName; }
            set { this._dbParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dbParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the DB parameter group.
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
        /// Tags to assign to the DB parameter group.
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