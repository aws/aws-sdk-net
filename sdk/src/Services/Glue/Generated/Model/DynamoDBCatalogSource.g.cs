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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a DynamoDB data source in the Glue Data Catalog.
    /// </summary>
    public partial class DynamoDBCatalogSource
    {
        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Specifies additional connection options for the DynamoDB data source.
        /// </para>
        /// </summary>
        public DDBELTCatalogAdditionalOptions AdditionalOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalOptions property is set.
        /// </summary>
        internal bool IsSetAdditionalOptions() => this.AdditionalOptions != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PitrEnabled. 
        /// <para>
        /// Specifies whether Point-in-Time Recovery (PITR) is enabled for the DynamoDB table.
        /// When set to <c>true</c>, allows reading from a specific point in time. The default
        /// value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PitrEnabled { get; set; }

        /// <summary>
        /// Checks to see if the PitrEnabled property is set.
        /// </summary>
        internal bool IsSetPitrEnabled() => this.PitrEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The name of the table in the database to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;
    }
}
