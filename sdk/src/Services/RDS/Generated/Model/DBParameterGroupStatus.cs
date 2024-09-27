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
    /// The status of the DB parameter group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateDBInstance</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateDBInstanceReadReplica</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteDBInstance</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ModifyDBInstance</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RebootDBInstance</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RestoreDBInstanceFromDBSnapshot</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DBParameterGroupStatus
    {
        private string _dbParameterGroupName;
        private string _parameterApplyStatus;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DBParameterGroupStatus() { }

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of parameter updates. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>applying</c>: The parameter group change is being applied to the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-to-apply</c>: The parameter group is in an invalid state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>in-sync</c>: The parameter group change is synchronized with the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-database-upgrade</c>: The parameter group change will be applied after
        /// the DB instance is upgraded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending-reboot</c>: The parameter group change will be applied after the DB instance
        /// reboots.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ParameterApplyStatus
        {
            get { return this._parameterApplyStatus; }
            set { this._parameterApplyStatus = value; }
        }

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this._parameterApplyStatus != null;
        }

    }
}