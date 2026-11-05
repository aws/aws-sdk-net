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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Specifies the schema to which you want Firehose to configure your data before it writes
    /// it to Amazon S3. This parameter is required if <c>Enabled</c> is set to true.
    /// </summary>
    public partial class SchemaConfiguration
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Amazon Web Services Glue Data Catalog. If you don't supply this, the
        /// Amazon Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Specifies the name of the Amazon Web Services Glue database that contains the schema
        /// for the output data.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the <c>SchemaConfiguration</c> request parameter is used as part of invoking the
        /// <c>CreateDeliveryStream</c> API, then the <c>DatabaseName</c> property is required
        /// and its value must be specified.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// If you don't specify an Amazon Web Services Region, the default is the current Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The role that Firehose can use to access Amazon Web Services Glue. This role must
        /// be in the same account you use for Firehose. Cross-account roles aren't allowed.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the <c>SchemaConfiguration</c> request parameter is used as part of invoking the
        /// <c>CreateDeliveryStream</c> API, then the <c>RoleARN</c> property is required and
        /// its value must be specified.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Specifies the Amazon Web Services Glue table that contains the column information
        /// that constitutes your data schema.
        /// </para>
        ///  <important> 
        /// <para>
        /// If the <c>SchemaConfiguration</c> request parameter is used as part of invoking the
        /// <c>CreateDeliveryStream</c> API, then the <c>TableName</c> property is required and
        /// its value must be specified.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Specifies the table version for the output data schema. If you don't specify this
        /// version ID, or if you set it to <c>LATEST</c>, Firehose uses the most recent version.
        /// This means that any updates to the table are automatically picked up.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
