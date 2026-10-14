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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetUnfilteredPartitionMetadata operation. Retrieves
    /// partition metadata from the Data Catalog that contains unfiltered metadata. <para>
    /// For IAM authorization, the public IAM action associated with this API is <c>glue:GetPartition</c>.
    /// </para>
    /// </summary>
    public partial class GetUnfilteredPartitionMetadataRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AuditContext. 
        /// <para>
        /// A structure containing Lake Formation audit context information.
        /// </para>
        /// </summary>
        public AuditContext AuditContext { get; set; }

        /// <summary>
        /// Checks to see if the AuditContext property is set.
        /// </summary>
        internal bool IsSetAuditContext() => this.AuditContext != null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog ID where the partition resides.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// (Required) Specifies the name of a database that contains the partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property PartitionValues. 
        /// <para>
        /// (Required) A list of partition key values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> PartitionValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PartitionValues property is set.
        /// </summary>
        internal bool IsSetPartitionValues() => this.PartitionValues != null && (this.PartitionValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QuerySessionContext. 
        /// <para>
        /// A structure used as a protocol between query engines and Lake Formation or Glue. Contains
        /// both a Lake Formation generated authorization identifier and information from the
        /// request's authorization context.
        /// </para>
        /// </summary>
        public QuerySessionContext QuerySessionContext { get; set; }

        /// <summary>
        /// Checks to see if the QuerySessionContext property is set.
        /// </summary>
        internal bool IsSetQuerySessionContext() => this.QuerySessionContext != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Specified only if the base tables belong to a different Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SupportedPermissionTypes. 
        /// <para>
        /// (Required) A list of supported permission types. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public List<string> SupportedPermissionTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedPermissionTypes property is set.
        /// </summary>
        internal bool IsSetSupportedPermissionTypes() => this.SupportedPermissionTypes != null && (this.SupportedPermissionTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// (Required) Specifies the name of a table that contains the partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
