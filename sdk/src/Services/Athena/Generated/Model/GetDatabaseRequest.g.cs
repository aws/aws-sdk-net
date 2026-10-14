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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the GetDatabase operation. Returns a database object
    /// for the specified database and data catalog.
    /// </summary>
    public partial class GetDatabaseRequest : AmazonAthenaRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The name of the data catalog that contains the database to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string CatalogName { get; set; }

        /// <summary>
        /// Checks to see if the CatalogName property is set.
        /// </summary>
        internal bool IsSetCatalogName() => this.CatalogName != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The name of the workgroup for which the metadata is being fetched. Required if requesting
        /// an IAM Identity Center enabled Glue Data Catalog.
        /// </para>
        /// </summary>
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
