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
    /// Information about the login attempts.
    /// </summary>
    public partial class LoginAttribute
    {
        private string _application;
        private int? _failedLoginAttempts;
        private int? _successfulLoginAttempts;
        private string _user;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// Indicates the application name used to attempt log in.
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
        /// Gets and sets the property FailedLoginAttempts. 
        /// <para>
        /// Represents the sum of failed (unsuccessful) login attempts made to establish a connection
        /// to the database instance.
        /// </para>
        /// </summary>
        public int FailedLoginAttempts
        {
            get { return this._failedLoginAttempts.GetValueOrDefault(); }
            set { this._failedLoginAttempts = value; }
        }

        // Check to see if FailedLoginAttempts property is set
        internal bool IsSetFailedLoginAttempts()
        {
            return this._failedLoginAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulLoginAttempts. 
        /// <para>
        /// Represents the sum of successful connections (a correct combination of login attributes)
        /// made to the database instance by the actor.
        /// </para>
        /// </summary>
        public int SuccessfulLoginAttempts
        {
            get { return this._successfulLoginAttempts.GetValueOrDefault(); }
            set { this._successfulLoginAttempts = value; }
        }

        // Check to see if SuccessfulLoginAttempts property is set
        internal bool IsSetSuccessfulLoginAttempts()
        {
            return this._successfulLoginAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Indicates the user name which attempted to log in.
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