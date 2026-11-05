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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the ListTableMigrations operation. Lists the migrations
    /// whose destination is in a table bucket, a namespace or a table. Specify a <c>tableBucketARN</c>
    /// to list the migrations into a table bucket, and add a <c>namespace</c>, or a <c>namespace</c>
    /// and a <c>name</c>, to narrow the list. Or specify a <c>tableARN</c> to list the migrations
    /// into a table. <para> Migrations are listed newest first. Results are paginated: use
    /// <c>maxResults</c> to set the page size, and pass the <c>nextToken</c> from a response
    /// to retrieve the next page of results. A page can contain fewer migrations than <c>maxResults</c>,
    /// or none, and still return a <c>nextToken</c>. Continue until a response has no <c>nextToken</c>.
    /// </para> <dl> <dt>Permissions</dt> <dd> <ul> <li> <para> You must have the <c>s3tables:ListTableMigrations</c>
    /// permission to use this operation. </para> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class ListTableMigrationsRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property HasValidPlan. 
        /// <para>
        /// The <c>hasValidPlan</c> value to filter the list by. Migrations that are still planning
        /// aren't listed, whichever value you specify.
        /// </para>
        /// </summary>
        public bool? HasValidPlan { get; set; }

        /// <summary>
        /// Checks to see if the HasValidPlan property is set.
        /// </summary>
        internal bool IsSetHasValidPlan() => this.HasValidPlan.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of migrations to return, from 1 to 1,000. If you don't specify
        /// a value, the default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table to list migrations for. Requires <c>tableBucketARN</c> and <c>namespace</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to list migrations for. Requires <c>tableBucketARN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> from a previous response, to get the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state to filter the list by. For the valid values, see the <c>state</c> member
        /// of <c>GetTableMigration</c>.
        /// </para>
        /// </summary>
        public MigrationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table to list migrations for. The list includes
        /// the migrations into this table. To also list migrations into an earlier table of the
        /// same name, specify <c>tableBucketARN</c>, <c>namespace</c> and <c>name</c> instead.
        /// Specify either <c>tableARN</c> or <c>tableBucketARN</c>, not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TableARN { get; set; }

        /// <summary>
        /// Checks to see if the TableARN property is set.
        /// </summary>
        internal bool IsSetTableARN() => this.TableARN != null;

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket to list migrations for.
        /// </para>
        /// </summary>
        public string TableBucketARN { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketARN property is set.
        /// </summary>
        internal bool IsSetTableBucketARN() => this.TableBucketARN != null;
    }
}
