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
    /// Contains information about the user and authentication details for a database instance
    /// involved in the finding.
    /// </summary>
    public partial class RdsDbUserDetails
    {
        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The application name used in the anomalous login attempt.
        /// </para>
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// Checks to see if the Application property is set.
        /// </summary>
        internal bool IsSetApplication() => this.Application != null;

        /// <summary>
        /// Gets and sets the property AuthMethod. 
        /// <para>
        /// The authentication method used by the user involved in the finding.
        /// </para>
        /// </summary>
        public string AuthMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthMethod property is set.
        /// </summary>
        internal bool IsSetAuthMethod() => this.AuthMethod != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database instance involved in the anomalous login attempt.
        /// </para>
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property Ssl. 
        /// <para>
        /// The version of the Secure Socket Layer (SSL) used for the network.
        /// </para>
        /// </summary>
        public string Ssl { get; set; }

        /// <summary>
        /// Checks to see if the Ssl property is set.
        /// </summary>
        internal bool IsSetSsl() => this.Ssl != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user name used in the anomalous login attempt.
        /// </para>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
