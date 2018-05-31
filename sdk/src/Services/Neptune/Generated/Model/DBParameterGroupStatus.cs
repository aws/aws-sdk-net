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
    /// The status of the DB parameter group.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateDBInstance</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateDBInstanceReadReplica</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteDBInstance</a> 
    /// </para>
    ///  </li> <li> 
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
    ///  </li> </ul>
    /// </summary>
    public partial class DBParameterGroupStatus
    {
        private string _dbParameterGroupName;
        private string _parameterApplyStatus;

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DP parameter group.
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
        /// The status of parameter updates.
        /// </para>
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