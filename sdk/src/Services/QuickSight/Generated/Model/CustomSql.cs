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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A physical table type built from the results of the custom SQL query.
    /// </summary>
    public partial class CustomSql
    {
        private List<InputColumn> _columns = new List<InputColumn>();
        private string _dataSourceArn;
        private string _name;
        private string _sqlQuery;

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// The column schema from the SQL query result set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public List<InputColumn> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null && this._columns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the SQL query result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property SqlQuery. 
        /// <para>
        /// The SQL query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public string SqlQuery
        {
            get { return this._sqlQuery; }
            set { this._sqlQuery = value; }
        }

        // Check to see if SqlQuery property is set
        internal bool IsSetSqlQuery()
        {
            return this._sqlQuery != null;
        }

    }
}