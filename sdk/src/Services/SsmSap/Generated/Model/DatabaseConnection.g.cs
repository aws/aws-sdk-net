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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// The connection specifications for the database.
    /// </summary>
    public partial class DatabaseConnection
    {
        /// <summary>
        /// Gets and sets the property ConnectionIp. 
        /// <para>
        /// The IP address for connection.
        /// </para>
        /// </summary>
        public string ConnectionIp { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionIp property is set.
        /// </summary>
        internal bool IsSetConnectionIp() => this.ConnectionIp != null;

        /// <summary>
        /// Gets and sets the property DatabaseArn. 
        /// <para>
        /// The Amazon Resource Name of the connected SAP HANA database.
        /// </para>
        /// </summary>
        public string DatabaseArn { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseArn property is set.
        /// </summary>
        internal bool IsSetDatabaseArn() => this.DatabaseArn != null;

        /// <summary>
        /// Gets and sets the property DatabaseConnectionMethod. 
        /// <para>
        /// The method of connection.
        /// </para>
        /// </summary>
        public DatabaseConnectionMethod DatabaseConnectionMethod { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseConnectionMethod property is set.
        /// </summary>
        internal bool IsSetDatabaseConnectionMethod() => this.DatabaseConnectionMethod != null;
    }
}
