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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a relational database data source configuration.
    /// </summary>
    public partial class RelationalDatabaseDataSourceConfig
    {
        /// <summary>
        /// Gets and sets the property RdsHttpEndpointConfig. 
        /// <para>
        /// Amazon RDS HTTP endpoint settings.
        /// </para>
        /// </summary>
        public RdsHttpEndpointConfig RdsHttpEndpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the RdsHttpEndpointConfig property is set.
        /// </summary>
        internal bool IsSetRdsHttpEndpointConfig() => this.RdsHttpEndpointConfig != null;

        /// <summary>
        /// Gets and sets the property RelationalDatabaseSourceType. 
        /// <para>
        /// Source type for the relational database.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RDS_HTTP_ENDPOINT</b>: The relational database source type is an Amazon Relational
        /// Database Service (Amazon RDS) HTTP endpoint.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RelationalDatabaseSourceType RelationalDatabaseSourceType { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseSourceType property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseSourceType() => this.RelationalDatabaseSourceType != null;
    }
}
