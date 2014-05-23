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
    /// </summary>
    public partial class RegisterRdsDbInstanceRequest : AmazonWebServiceRequest
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


        /// <summary>
        /// Sets the DbPassword property
        /// </summary>
        /// <param name="dbPassword">The value to set for the DbPassword property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterRdsDbInstanceRequest WithDbPassword(string dbPassword)
        {
            this._dbPassword = dbPassword;
            return this;
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


        /// <summary>
        /// Sets the DbUser property
        /// </summary>
        /// <param name="dbUser">The value to set for the DbUser property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterRdsDbInstanceRequest WithDbUser(string dbUser)
        {
            this._dbUser = dbUser;
            return this;
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


        /// <summary>
        /// Sets the RdsDbInstanceArn property
        /// </summary>
        /// <param name="rdsDbInstanceArn">The value to set for the RdsDbInstanceArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterRdsDbInstanceRequest WithRdsDbInstanceArn(string rdsDbInstanceArn)
        {
            this._rdsDbInstanceArn = rdsDbInstanceArn;
            return this;
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


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterRdsDbInstanceRequest WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}