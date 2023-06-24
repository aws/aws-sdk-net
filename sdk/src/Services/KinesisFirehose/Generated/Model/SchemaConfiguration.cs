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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Specifies the schema to which you want Kinesis Data Firehose to configure your data
    /// before it writes it to Amazon S3. This parameter is required if <code>Enabled</code>
    /// is set to true.
    /// </summary>
    public partial class SchemaConfiguration
    {
        private string _catalogId;
        private string _databaseName;
        private string _region;
        private string _roleARN;
        private string _tableName;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Amazon Web Services Glue Data Catalog. If you don't supply this, the
        /// Amazon Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Specifies the name of the Amazon Web Services Glue database that contains the schema
        /// for the output data.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the <code>SchemaConfiguration</code> request parameter is used as part of invoking
        /// the <code>CreateDeliveryStream</code> API, then the <code>DatabaseName</code> property
        /// is required and its value must be specified.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Region. 
        /// <para>
        /// If you don't specify an Amazon Web Services Region, the default is the current Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The role that Kinesis Data Firehose can use to access Amazon Web Services Glue. This
        /// role must be in the same account you use for Kinesis Data Firehose. Cross-account
        /// roles aren't allowed.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the <code>SchemaConfiguration</code> request parameter is used as part of invoking
        /// the <code>CreateDeliveryStream</code> API, then the <code>RoleARN</code> property
        /// is required and its value must be specified.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Specifies the Amazon Web Services Glue table that contains the column information
        /// that constitutes your data schema.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the <code>SchemaConfiguration</code> request parameter is used as part of invoking
        /// the <code>CreateDeliveryStream</code> API, then the <code>TableName</code> property
        /// is required and its value must be specified.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Specifies the table version for the output data schema. If you don't specify this
        /// version ID, or if you set it to <code>LATEST</code>, Kinesis Data Firehose uses the
        /// most recent version. This means that any updates to the table are automatically picked
        /// up.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}