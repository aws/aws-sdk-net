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
    /// Container for the parameters to the CreateDBParameterGroup operation.
    /// Creates a new DB parameter group.
    /// 
    ///  
    /// <para>
    /// A DB parameter group is initially created with the default parameters for the database
    /// engine used by the DB instance. To provide custom values for any of the parameters,
    /// you must modify the group after creating it using <c>ModifyDBParameterGroup</c>. Once
    /// you've created a DB parameter group, you need to associate it with your DB instance
    /// using <c>ModifyDBInstance</c>. When you associate a new DB parameter group with a
    /// running DB instance, you need to reboot the DB instance without failover for the new
    /// DB parameter group and associated settings to take effect.
    /// </para>
    ///  
    /// <para>
    /// This command doesn't apply to RDS Custom.
    /// </para>
    /// </summary>
    public partial class CreateDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupFamily;
        private string _dbParameterGroupName;
        private string _description;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBParameterGroupRequest() { }

        /// <summary>
        /// Instantiates CreateDBParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupName">The name of the DB parameter group. Constraints: <ul> <li> Must be 1 to 255 letters, numbers, or hyphens. </li> <li> First character must be a letter </li> <li> Can't end with a hyphen or contain two consecutive hyphens </li> </ul> <note> This value is stored as a lowercase string. </note></param>
        /// <param name="dbParameterGroupFamily">The DB parameter group family name. A DB parameter group can be associated with one and only one DB parameter group family, and can be applied only to a DB instance running a database engine and engine version compatible with that DB parameter group family. To list all of the available parameter group families for a DB engine, use the following command:  <c>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily" --engine &lt;engine&gt;</c>  For example, to list all of the available parameter group families for the MySQL DB engine, use the following command:  <c>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily" --engine mysql</c>  <note> The output contains duplicates. </note> The following are the valid DB engine values: <ul> <li>  <c>aurora-mysql</c>  </li> <li>  <c>aurora-postgresql</c>  </li> <li>  <c>db2-ae</c>  </li> <li>  <c>db2-se</c>  </li> <li>  <c>mysql</c>  </li> <li>  <c>oracle-ee</c>  </li> <li>  <c>oracle-ee-cdb</c>  </li> <li>  <c>oracle-se2</c>  </li> <li>  <c>oracle-se2-cdb</c>  </li> <li>  <c>postgres</c>  </li> <li>  <c>sqlserver-ee</c>  </li> <li>  <c>sqlserver-se</c>  </li> <li>  <c>sqlserver-ex</c>  </li> <li>  <c>sqlserver-web</c>  </li> </ul></param>
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
        ///  <c>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily"
        /// --engine &lt;engine&gt;</c> 
        /// </para>
        ///  
        /// <para>
        /// For example, to list all of the available parameter group families for the MySQL DB
        /// engine, use the following command:
        /// </para>
        ///  
        /// <para>
        ///  <c>aws rds describe-db-engine-versions --query "DBEngineVersions[].DBParameterGroupFamily"
        /// --engine mysql</c> 
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
        ///  <c>aurora-mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-ae</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db2-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2-cdb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>postgres</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web</c> 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}