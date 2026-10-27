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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the login attempts.
    /// </summary>
    public partial class LoginAttribute
    {
        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// Indicates the application name used to attempt log in.
        /// </para>
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// Checks to see if the Application property is set.
        /// </summary>
        internal bool IsSetApplication() => this.Application != null;

        /// <summary>
        /// Gets and sets the property FailedLoginAttempts. 
        /// <para>
        /// Represents the sum of failed (unsuccessful) login attempts made to establish a connection
        /// to the database instance.
        /// </para>
        /// </summary>
        public int? FailedLoginAttempts { get; set; }

        /// <summary>
        /// Checks to see if the FailedLoginAttempts property is set.
        /// </summary>
        internal bool IsSetFailedLoginAttempts() => this.FailedLoginAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property SuccessfulLoginAttempts. 
        /// <para>
        /// Represents the sum of successful connections (a correct combination of login attributes)
        /// made to the database instance by the actor.
        /// </para>
        /// </summary>
        public int? SuccessfulLoginAttempts { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulLoginAttempts property is set.
        /// </summary>
        internal bool IsSetSuccessfulLoginAttempts() => this.SuccessfulLoginAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Indicates the user name which attempted to log in.
        /// </para>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
