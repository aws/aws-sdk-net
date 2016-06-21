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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterRdsDbInstance operation.
    /// Registers an Amazon RDS instance with a stack.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class RegisterRdsDbInstanceRequest : AmazonOpsWorksRequest
    {
        private string _dbPassword;
        private string _dbUser;
        private string _rdsDbInstanceArn;
        private string _stackId;

        /// <summary>
        /// Gets and sets the property DbPassword. 
        /// <para>
        /// The database password.
        /// </para>
        /// </summary>
        public string DbPassword
        {
            get { return this._dbPassword; }
            set { this._dbPassword = value; }
        }

        // Check to see if DbPassword property is set
        internal bool IsSetDbPassword()
        {
            return this._dbPassword != null;
        }

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database's master user name.
        /// </para>
        /// </summary>
        public string DbUser
        {
            get { return this._dbUser; }
            set { this._dbUser = value; }
        }

        // Check to see if DbUser property is set
        internal bool IsSetDbUser()
        {
            return this._dbUser != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbInstanceArn. 
        /// <para>
        /// The Amazon RDS instance's ARN.
        /// </para>
        /// </summary>
        public string RdsDbInstanceArn
        {
            get { return this._rdsDbInstanceArn; }
            set { this._rdsDbInstanceArn = value; }
        }

        // Check to see if RdsDbInstanceArn property is set
        internal bool IsSetRdsDbInstanceArn()
        {
            return this._rdsDbInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}