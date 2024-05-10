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
    /// Specifies the data store in the governed Glue Data Catalog.
    /// </summary>
    public partial class GovernedCatalogSource
    {
        private S3SourceAdditionalOptions _additionalOptions;
        private string _database;
        private string _name;
        private string _partitionPredicate;
        private string _table;

        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Specifies additional connection options.
        /// </para>
        /// </summary>
        public S3SourceAdditionalOptions AdditionalOptions
        {
            get { return this._additionalOptions; }
            set { this._additionalOptions = value; }
        }

        // Check to see if AdditionalOptions property is set
        internal bool IsSetAdditionalOptions()
        {
            return this._additionalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property PartitionPredicate. 
        /// <para>
        /// Partitions satisfying this predicate are deleted. Files within the retention period
        /// in these partitions are not deleted. Set to <c>""</c> – empty by default.
        /// </para>
        /// </summary>
        public string PartitionPredicate
        {
            get { return this._partitionPredicate; }
            set { this._partitionPredicate = value; }
        }

        // Check to see if PartitionPredicate property is set
        internal bool IsSetPartitionPredicate()
        {
            return this._partitionPredicate != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The database table to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

    }
}