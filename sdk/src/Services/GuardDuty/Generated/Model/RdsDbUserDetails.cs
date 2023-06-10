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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the user and authentication details for a database instance
    /// involved in the finding.
    /// </summary>
    public partial class RdsDbUserDetails
    {
        private string _application;
        private string _authMethod;
        private string _database;
        private string _ssl;
        private string _user;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The application name used in the anomalous login attempt.
        /// </para>
        /// </summary>
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property AuthMethod. 
        /// <para>
        /// The authentication method used by the user involved in the finding.
        /// </para>
        /// </summary>
        public string AuthMethod
        {
            get { return this._authMethod; }
            set { this._authMethod = value; }
        }

        // Check to see if AuthMethod property is set
        internal bool IsSetAuthMethod()
        {
            return this._authMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database instance involved in the anomalous login attempt.
        /// </para>
        /// </summary>
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property Ssl. 
        /// <para>
        /// The version of the Secure Socket Layer (SSL) used for the network.
        /// </para>
        /// </summary>
        public string Ssl
        {
            get { return this._ssl; }
            set { this._ssl = value; }
        }

        // Check to see if Ssl property is set
        internal bool IsSetSsl()
        {
            return this._ssl != null;
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user name used in the anomalous login attempt.
        /// </para>
        /// </summary>
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}