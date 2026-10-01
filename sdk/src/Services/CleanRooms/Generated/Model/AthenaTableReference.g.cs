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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A reference to a table within Athena.
    /// </summary>
    public partial class AthenaTableReference
    {
        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        ///  The catalog name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CatalogName { get; set; }

        /// <summary>
        /// Checks to see if the CatalogName property is set.
        /// </summary>
        internal bool IsSetCatalogName() => this.CatalogName != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The database name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        ///  The output location for the Athena table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 1024)]
        public string OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the Athena table is located. This parameter is
        /// required to uniquely identify and access tables across different Regions.
        /// </para>
        /// </summary>
        public CommercialRegion Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        ///  The table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        ///  The workgroup of the Athena table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
