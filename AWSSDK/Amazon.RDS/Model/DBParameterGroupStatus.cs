/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> The status of the DB Parameter Group. </para> <para>This data type is used as a response element in the following actions:</para>
    /// <ul>
    /// <li> CreateDBInstance </li>
    /// <li> CreateDBInstanceReadReplica </li>
    /// <li> DeleteDBInstance </li>
    /// <li> ModifyDBInstance </li>
    /// <li> RebootDBInstance </li>
    /// <li> RestoreDBInstanceFromDBSnapshot </li>
    /// 
    /// </ul>
    /// </summary>
    public class DBParameterGroupStatus
    {
        
        private string dBParameterGroupName;
        private string parameterApplyStatus;

        /// <summary>
        /// The name of the DP Parameter Group.
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="dBParameterGroupName">The value to set for the DBParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBParameterGroupStatus WithDBParameterGroupName(string dBParameterGroupName)
        {
            this.dBParameterGroupName = dBParameterGroupName;
            return this;
        }
            

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;
        }

        /// <summary>
        /// The status of parameter updates.
        ///  
        /// </summary>
        public string ParameterApplyStatus
        {
            get { return this.parameterApplyStatus; }
            set { this.parameterApplyStatus = value; }
        }

        /// <summary>
        /// Sets the ParameterApplyStatus property
        /// </summary>
        /// <param name="parameterApplyStatus">The value to set for the ParameterApplyStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBParameterGroupStatus WithParameterApplyStatus(string parameterApplyStatus)
        {
            this.parameterApplyStatus = parameterApplyStatus;
            return this;
        }
            

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this.parameterApplyStatus != null;
        }
    }
}
