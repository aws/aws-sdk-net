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
    /// Describes an Amazon RDS instance.
    /// </summary>
    public partial class RdsDbInstance
    {
        private string _address;
        private string _dbInstanceIdentifier;
        private string _dbPassword;
        private string _dbUser;
        private string _engine;
        private bool? _missingOnRds;
        private string _rdsDbInstanceArn;
        private string _region;
        private string _stackId;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The instance's address.
        /// </para>
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// The DB instance identifier.
        /// </para>
        /// </summary>
        public string DbInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DbInstanceIdentifier property is set
        internal bool IsSetDbInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbPassword. 
        /// <para>
        /// AWS OpsWorks Stacks returns <code>*****FILTERED*****</code> instead of the actual
        /// value.
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
        /// The master user name.
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The instance's database engine.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property MissingOnRds. 
        /// <para>
        /// Set to <code>true</code> if AWS OpsWorks Stacks is unable to discover the Amazon RDS
        /// instance. AWS OpsWorks Stacks attempts to discover the instance only once. If this
        /// value is set to <code>true</code>, you must deregister the instance, and then register
        /// it again.
        /// </para>
        /// </summary>
        public bool MissingOnRds
        {
            get { return this._missingOnRds.GetValueOrDefault(); }
            set { this._missingOnRds = value; }
        }

        // Check to see if MissingOnRds property is set
        internal bool IsSetMissingOnRds()
        {
            return this._missingOnRds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RdsDbInstanceArn. 
        /// <para>
        /// The instance's ARN.
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The instance's AWS region.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack with which the instance is registered.
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