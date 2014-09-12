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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
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
    /// Container for the parameters to the CreateDBParameterGroup operation.
    /// Creates a new DB parameter group. 
    /// 
    ///  
    /// <para>
    ///  A DB parameter group is initially created with the default parameters for the database
    /// engine used by the DB instance. To provide custom values for any of the parameters,
    /// you must modify the group after creating it using <i>ModifyDBParameterGroup</i>. Once
    /// you've created a DB parameter group, you need to associate it with your DB instance
    /// using <i>ModifyDBInstance</i>. When you associate a new DB parameter group with a
    /// running DB instance, you need to reboot the DB Instance for the new DB parameter group
    /// and associated settings to take effect. 
    /// </para>
    /// </summary>
    public partial class CreateDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _dBParameterGroupFamily;
        private string _dBParameterGroupName;
        private string _description;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDBParameterGroupRequest() { }

        /// <summary>
        /// Instantiates CreateDBParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupName"> The name of the DB parameter group.   Constraints:  <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        /// <param name="dbParameterGroupFamily"> The DB parameter group family name. A DB parameter group can be associated with one and only one DB parameter group family, and can be applied only to a DB instance running a database engine and engine version compatible with that DB parameter group family. </param>
        /// <param name="description"> The description for the DB parameter group. </param>
        public CreateDBParameterGroupRequest(string dbParameterGroupName, string dbParameterGroupFamily, string description)
        {
            _dBParameterGroupName = dbParameterGroupName;
            _dBParameterGroupFamily = dbParameterGroupFamily;
            _description = description;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupFamily. 
        /// <para>
        ///  The DB parameter group family name. A DB parameter group can be associated with one
        /// and only one DB parameter group family, and can be applied only to a DB instance running
        /// a database engine and engine version compatible with that DB parameter group family.
        /// 
        /// </para>
        /// </summary>
        public string DBParameterGroupFamily
        {
            get { return this._dBParameterGroupFamily; }
            set { this._dBParameterGroupFamily = value; }
        }

        // Check to see if DBParameterGroupFamily property is set
        internal bool IsSetDBParameterGroupFamily()
        {
            return this._dBParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        ///  The name of the DB parameter group. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: 
        /// </para>
        ///  <ul> <li>Must be 1 to 255 alphanumeric characters</li> <li>First character must be
        /// a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul>
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this._dBParameterGroupName; }
            set { this._dBParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dBParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the DB parameter group. 
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