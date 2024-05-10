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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Describes the <c>DataSource</c> details specific to Amazon Redshift.
    /// </summary>
    public partial class RedshiftMetadata
    {
        private string _databaseUserName;
        private RedshiftDatabase _redshiftDatabase;
        private string _selectSqlQuery;

        /// <summary>
        /// Gets and sets the property DatabaseUserName.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DatabaseUserName
        {
            get { return this._databaseUserName; }
            set { this._databaseUserName = value; }
        }

        // Check to see if DatabaseUserName property is set
        internal bool IsSetDatabaseUserName()
        {
            return this._databaseUserName != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDatabase.
        /// </summary>
        public RedshiftDatabase RedshiftDatabase
        {
            get { return this._redshiftDatabase; }
            set { this._redshiftDatabase = value; }
        }

        // Check to see if RedshiftDatabase property is set
        internal bool IsSetRedshiftDatabase()
        {
            return this._redshiftDatabase != null;
        }

        /// <summary>
        /// Gets and sets the property SelectSqlQuery. 
        /// <para>
        ///  The SQL query that is specified during <a>CreateDataSourceFromRedshift</a>. Returns
        /// only if <c>Verbose</c> is true in GetDataSourceInput. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16777216)]
        public string SelectSqlQuery
        {
            get { return this._selectSqlQuery; }
            set { this._selectSqlQuery = value; }
        }

        // Check to see if SelectSqlQuery property is set
        internal bool IsSetSelectSqlQuery()
        {
            return this._selectSqlQuery != null;
        }

    }
}