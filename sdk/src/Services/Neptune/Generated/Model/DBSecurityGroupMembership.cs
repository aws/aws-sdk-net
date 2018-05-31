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
    /// This data type is used as a response element in the following actions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a>ModifyDBInstance</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RebootDBInstance</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RestoreDBInstanceFromDBSnapshot</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>RestoreDBInstanceToPointInTime</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DBSecurityGroupMembership
    {
        private string _dbSecurityGroupName;
        private string _status;

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