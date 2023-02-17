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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a Delta Lake data source that is registered in the Glue Data Catalog. The
    /// data source must be stored in Amazon S3.
    /// </summary>
    public partial class S3CatalogDeltaSource
    {
        private Dictionary<string, string> _additionalDeltaOptions = new Dictionary<string, string>();
        private string _database;
        private string _name;
        private List<GlueSchema> _outputSchemas = new List<GlueSchema>();
        private string _table;

        /// <summary>
        /// Gets and sets the property AdditionalDeltaOptions. 
        /// <para>
        /// Specifies additional connection options.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalDeltaOptions
        {
            get { return this._additionalDeltaOptions; }
            set { this._additionalDeltaOptions = value; }
        }

        // Check to see if AdditionalDeltaOptions property is set
        internal bool IsSetAdditionalDeltaOptions()
        {
            return this._additionalDeltaOptions != null && this._additionalDeltaOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database to read from.
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
        /// The name of the Delta Lake data source.
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
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the Delta Lake source.
        /// </para>
        /// </summary>
        public List<GlueSchema> OutputSchemas
        {
            get { return this._outputSchemas; }
            set { this._outputSchemas = value; }
        }

        // Check to see if OutputSchemas property is set
        internal bool IsSetOutputSchemas()
        {
            return this._outputSchemas != null && this._outputSchemas.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The name of the table in the database to read from.
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