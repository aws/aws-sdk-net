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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a schema in a Fleet Advisor collector inventory.
    /// </summary>
    public partial class SchemaShortInfoResponse
    {
        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The ID of a database in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string DatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseId property is set.
        /// </summary>
        internal bool IsSetDatabaseId() => this.DatabaseId != null;

        /// <summary>
        /// Gets and sets the property DatabaseIpAddress. 
        /// <para>
        /// The IP address of a database in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string DatabaseIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseIpAddress property is set.
        /// </summary>
        internal bool IsSetDatabaseIpAddress() => this.DatabaseIpAddress != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of a database in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The ID of a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId != null;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of a schema in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;
    }
}
