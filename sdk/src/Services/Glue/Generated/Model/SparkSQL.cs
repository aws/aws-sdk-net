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
    /// Specifies a transform where you enter a SQL query using Spark SQL syntax to transform
    /// the data. The output is a single <c>DynamicFrame</c>.
    /// </summary>
    public partial class SparkSQL
    {
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<GlueSchema> _outputSchemas = AWSConfigs.InitializeCollections ? new List<GlueSchema>() : null;
        private List<SqlAlias> _sqlAliases = AWSConfigs.InitializeCollections ? new List<SqlAlias>() : null;
        private string _sqlQuery;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The data inputs identified by their node names. You can associate a table name with
        /// each input node to use in the SQL query. The name you choose must meet the Spark SQL
        /// naming restrictions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the transform node.
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
        /// Specifies the data schema for the SparkSQL transform.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlueSchema> OutputSchemas
        {
            get { return this._outputSchemas; }
            set { this._outputSchemas = value; }
        }

        // Check to see if OutputSchemas property is set
        internal bool IsSetOutputSchemas()
        {
            return this._outputSchemas != null && (this._outputSchemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SqlAliases. 
        /// <para>
        /// A list of aliases. An alias allows you to specify what name to use in the SQL for
        /// a given input. For example, you have a datasource named "MyDataSource". If you specify
        /// <c>From</c> as MyDataSource, and <c>Alias</c> as SqlName, then in your SQL you can
        /// do:
        /// </para>
        ///  
        /// <para>
        ///  <c>select * from SqlName</c> 
        /// </para>
        ///  
        /// <para>
        /// and that gets data from MyDataSource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SqlAlias> SqlAliases
        {
            get { return this._sqlAliases; }
            set { this._sqlAliases = value; }
        }

        // Check to see if SqlAliases property is set
        internal bool IsSetSqlAliases()
        {
            return this._sqlAliases != null && (this._sqlAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SqlQuery. 
        /// <para>
        /// A SQL query that must use Spark SQL syntax and return a single data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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