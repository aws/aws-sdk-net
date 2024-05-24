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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Container for the parameters to the DeleteDatabase operation.
    /// Removes a specified database from a Data Catalog.
    /// 
    ///  <note> 
    /// <para>
    /// After completing this operation, you no longer have access to the tables (and all
    /// table versions and partitions that might belong to the tables) and the user-defined
    /// functions in the deleted database. Glue deletes these "orphaned" resources asynchronously
    /// in a timely manner, at the discretion of the service.
    /// </para>
    ///  
    /// <para>
    /// To ensure the immediate deletion of all related resources, before calling <c>DeleteDatabase</c>,
    /// use <c>DeleteTableVersion</c> or <c>BatchDeleteTableVersion</c>, <c>DeletePartition</c>
    /// or <c>BatchDeletePartition</c>, <c>DeleteUserDefinedFunction</c>, and <c>DeleteTable</c>
    /// or <c>BatchDeleteTable</c>, to delete any resources that belong to the database.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDatabaseRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _name;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the database resides. If none is provided, the
        /// Amazon Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the database to delete. For Hive compatibility, this must be all lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}