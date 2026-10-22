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
    /// Describes a database in a Fleet Advisor collector inventory.
    /// </summary>
    public partial class DatabaseResponse
    {
        /// <summary>
        /// Gets and sets the property Collectors. 
        /// <para>
        /// A list of collectors associated with the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CollectorShortInfoResponse> Collectors { get; set; } = AWSConfigs.InitializeCollections ? new List<CollectorShortInfoResponse>() : null;

        /// <summary>
        /// Checks to see if the Collectors property is set.
        /// </summary>
        internal bool IsSetCollectors() => this.Collectors != null && (this.Collectors.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of a database in a Fleet Advisor collector inventory. 
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property NumberOfSchemas. 
        /// <para>
        /// The number of schemas in a Fleet Advisor collector inventory database. 
        /// </para>
        /// </summary>
        public long? NumberOfSchemas { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfSchemas property is set.
        /// </summary>
        internal bool IsSetNumberOfSchemas() => this.NumberOfSchemas.HasValue;

        /// <summary>
        /// Gets and sets the property Server. 
        /// <para>
        /// The server name of a database in a Fleet Advisor collector inventory. 
        /// </para>
        /// </summary>
        public ServerShortInfoResponse Server { get; set; }

        /// <summary>
        /// Checks to see if the Server property is set.
        /// </summary>
        internal bool IsSetServer() => this.Server != null;

        /// <summary>
        /// Gets and sets the property SoftwareDetails. 
        /// <para>
        /// The software details of a database in a Fleet Advisor collector inventory, such as
        /// database engine and version.
        /// </para>
        /// </summary>
        public DatabaseInstanceSoftwareDetailsResponse SoftwareDetails { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareDetails property is set.
        /// </summary>
        internal bool IsSetSoftwareDetails() => this.SoftwareDetails != null;
    }
}
