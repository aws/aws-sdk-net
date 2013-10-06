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
    /// <para> This data type is used as a response element in the following actions: </para>
    /// <ul>
    /// <li> ModifyDBInstance </li>
    /// <li> RebootDBInstance </li>
    /// <li> RestoreDBInstanceFromDBSnapshot </li>
    /// <li> RestoreDBInstanceToPointInTime </li>
    /// 
    /// </ul>
    /// </summary>
    public class DBSecurityGroupMembership
    {
        
        private string dBSecurityGroupName;
        private string status;

        /// <summary>
        /// The name of the DB Security Group.
        ///  
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this.dBSecurityGroupName; }
            set { this.dBSecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSecurityGroupName property
        /// </summary>
        /// <param name="dBSecurityGroupName">The value to set for the DBSecurityGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBSecurityGroupMembership WithDBSecurityGroupName(string dBSecurityGroupName)
        {
            this.dBSecurityGroupName = dBSecurityGroupName;
            return this;
        }
            

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this.dBSecurityGroupName != null;
        }

        /// <summary>
        /// The status of the DB Security Group.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBSecurityGroupMembership WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
