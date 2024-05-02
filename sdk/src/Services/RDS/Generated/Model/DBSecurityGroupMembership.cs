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
    /// This data type is used as a response element in the following actions:
    /// 
    ///  <ul> <li> 
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
    ///  </li> <li> 
    /// <para>
    ///  <c>RestoreDBInstanceToPointInTime</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DBSecurityGroupMembership
    {
        private string _dbSecurityGroupName;
        private string _status;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DBSecurityGroupMembership() { }

        /// <summary>
        /// Gets and sets the property DBSecurityGroupName. 
        /// <para>
        /// The name of the DB security group.
        /// </para>
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this._dbSecurityGroupName; }
            set { this._dbSecurityGroupName = value; }
        }

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this._dbSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB security group.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}