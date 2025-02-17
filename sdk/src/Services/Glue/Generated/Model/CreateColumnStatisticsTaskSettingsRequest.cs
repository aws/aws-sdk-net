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
    /// Container for the parameters to the CreateColumnStatisticsTaskSettings operation.
    /// Creates settings for a column statistics task.
    /// </summary>
    public partial class CreateColumnStatisticsTaskSettingsRequest : AmazonGlueRequest
    {
        private string _catalogID;
        private List<string> _columnNameList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _databaseName;
        private string _role;
        private double? _sampleSize;
        private string _schedule;
        private string _securityConfiguration;
        private string _tableName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CatalogID. 
        /// <para>
        /// The ID of the Data Catalog in which the database resides.
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
        /// A list of column names for which to run statistics.
        /// </para>
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
        /// The role used for running the column statistics.
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
        /// The percentage of data to sample.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double SampleSize
        {
            get { return this._sampleSize.GetValueOrDefault(); }
            set { this._sampleSize = value; }
        }

        // Check to see if SampleSize property is set
        internal bool IsSetSampleSize()
        {
            return this._sampleSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A schedule for running the column statistics, specified in CRON syntax.
        /// </para>
        /// </summary>
        public string Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// Name of the security configuration that is used to encrypt CloudWatch logs.
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
        /// The name of the table for which to generate column statistics.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}