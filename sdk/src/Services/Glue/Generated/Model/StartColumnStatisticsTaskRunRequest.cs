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
    /// Container for the parameters to the StartColumnStatisticsTaskRun operation.
    /// Starts a column statistics task run, for a specified table and columns.
    /// </summary>
    public partial class StartColumnStatisticsTaskRunRequest : AmazonGlueRequest
    {
        private string _catalogID;
        private List<string> _columnNameList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _databaseName;
        private string _role;
        private double? _sampleSize;
        private string _securityConfiguration;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogID. 
        /// <para>
        /// The ID of the Data Catalog where the table reside. If none is supplied, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogID
        {
            get { return this._catalogID; }
            set { this._catalogID = value; }
        }

        // Check to see if CatalogID property is set
        internal bool IsSetCatalogID()
        {
            return this._catalogID != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnNameList. 
        /// <para>
        /// A list of the column names to generate statistics. If none is supplied, all column
        /// names for the table will be used by default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnNameList
        {
            get { return this._columnNameList; }
            set { this._columnNameList = value; }
        }

        // Check to see if ColumnNameList property is set
        internal bool IsSetColumnNameList()
        {
            return this._columnNameList != null && (this._columnNameList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database where the table resides.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that the service assumes to generate statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The percentage of rows used to generate statistics. If none is supplied, the entire
        /// table will be used to generate stats.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? SampleSize
        {
            get { return this._sampleSize; }
            set { this._sampleSize = value; }
        }

        // Check to see if SampleSize property is set
        internal bool IsSetSampleSize()
        {
            return this._sampleSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// Name of the security configuration that is used to encrypt CloudWatch logs for the
        /// column stats task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SecurityConfiguration
        {
            get { return this._securityConfiguration; }
            set { this._securityConfiguration = value; }
        }

        // Check to see if SecurityConfiguration property is set
        internal bool IsSetSecurityConfiguration()
        {
            return this._securityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to generate statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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

    }
}