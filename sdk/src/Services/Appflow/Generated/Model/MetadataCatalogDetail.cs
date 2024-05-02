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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Describes the metadata catalog, metadata table, and data partitions that Amazon AppFlow
    /// used for the associated flow run.
    /// </summary>
    public partial class MetadataCatalogDetail
    {
        private CatalogType _catalogType;
        private RegistrationOutput _partitionRegistrationOutput;
        private string _tableName;
        private RegistrationOutput _tableRegistrationOutput;

        /// <summary>
        /// Gets and sets the property CatalogType. 
        /// <para>
        /// The type of metadata catalog that Amazon AppFlow used for the associated flow run.
        /// This parameter returns the following value:
        /// </para>
        ///  <dl> <dt>GLUE</dt> <dd> 
        /// <para>
        /// The metadata catalog is provided by the Glue Data Catalog. Glue includes the Glue
        /// Data Catalog as a component.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public CatalogType CatalogType
        {
            get { return this._catalogType; }
            set { this._catalogType = value; }
        }

        // Check to see if CatalogType property is set
        internal bool IsSetCatalogType()
        {
            return this._catalogType != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionRegistrationOutput. 
        /// <para>
        /// Describes the status of the attempt from Amazon AppFlow to register the data partitions
        /// with the metadata catalog. The data partitions organize the flow output into a hierarchical
        /// path, such as a folder path in an S3 bucket. Amazon AppFlow creates the partitions
        /// (if they don't already exist) based on your flow configuration.
        /// </para>
        /// </summary>
        public RegistrationOutput PartitionRegistrationOutput
        {
            get { return this._partitionRegistrationOutput; }
            set { this._partitionRegistrationOutput = value; }
        }

        // Check to see if PartitionRegistrationOutput property is set
        internal bool IsSetPartitionRegistrationOutput()
        {
            return this._partitionRegistrationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table that stores the metadata for the associated flow run. The table
        /// stores metadata that represents the data that the flow transferred. Amazon AppFlow
        /// stores the table in the metadata catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TableRegistrationOutput. 
        /// <para>
        /// Describes the status of the attempt from Amazon AppFlow to register the metadata table
        /// with the metadata catalog. Amazon AppFlow creates or updates this table for the associated
        /// flow run.
        /// </para>
        /// </summary>
        public RegistrationOutput TableRegistrationOutput
        {
            get { return this._tableRegistrationOutput; }
            set { this._tableRegistrationOutput = value; }
        }

        // Check to see if TableRegistrationOutput property is set
        internal bool IsSetTableRegistrationOutput()
        {
            return this._tableRegistrationOutput != null;
        }

    }
}