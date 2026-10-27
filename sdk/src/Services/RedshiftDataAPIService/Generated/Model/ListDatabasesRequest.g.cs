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

namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatabases operation. List the databases in
    /// a cluster. A token is returned to page through the database list. Depending on the
    /// authorization method, use one of the following combinations of request parameters:
    /// <ul> <li> <para> Secrets Manager - when connecting to a cluster, provide the <c>secret-arn</c>
    /// of a secret stored in Secrets Manager which has <c>username</c> and <c>password</c>.
    /// The specified secret contains credentials to connect to the <c>database</c> you specify.
    /// When you are connecting to a cluster, you also supply the database name, If you provide
    /// a cluster identifier (<c>dbClusterIdentifier</c>), it must match the cluster identifier
    /// stored in the secret. When you are connecting to a serverless workgroup, you also
    /// supply the database name. </para> </li> <li> <para> Temporary credentials - when connecting
    /// to your data warehouse, choose one of the following options: </para> <ul> <li> <para>
    /// When connecting to a serverless workgroup, specify the workgroup name and database
    /// name. The database user name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
    /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift-serverless:GetCredentials</c>
    /// operation is required. </para> </li> <li> <para> When connecting to a cluster as an
    /// IAM identity, specify the cluster identifier and the database name. The database user
    /// name is derived from the IAM identity. For example, <c>arn:iam::123456789012:user:foo</c>
    /// has the database user name <c>IAM:foo</c>. Also, permission to call the <c>redshift:GetClusterCredentialsWithIAM</c>
    /// operation is required. </para> </li> <li> <para> When connecting to a cluster as a
    /// database user, specify the cluster identifier, the database name, and the database
    /// user name. Also, permission to call the <c>redshift:GetClusterCredentials</c> operation
    /// is required. </para> </li> </ul> </li> </ul> <para> For more information about the
    /// Amazon Redshift Data API and CLI usage examples, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using
    /// the Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. </para>
    /// </summary>
    public partial class ListDatabasesRequest : AmazonRedshiftDataAPIServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. This parameter is required when connecting to a cluster and
        /// authenticating using either Secrets Manager or temporary credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. This parameter is required when authenticating using either
        /// Secrets Manager or temporary credentials. 
        /// </para>
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database user name. This parameter is required when connecting to a cluster as
        /// a database user and authenticating using temporary credentials. 
        /// </para>
        /// </summary>
        public string DbUser { get; set; }

        /// <summary>
        /// Checks to see if the DbUser property is set.
        /// </summary>
        internal bool IsSetDbUser() => this.DbUser != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of databases to return in the response. If more databases exist
        /// than fit in one response, then <c>NextToken</c> is returned to page through the results.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned NextToken value in the next NextToken parameter
        /// and retrying the command. If the NextToken field is empty, all response records have
        /// been retrieved for the request. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. This parameter
        /// is required when authenticating using Secrets Manager. 
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The serverless workgroup name or Amazon Resource Name (ARN). This parameter is required
        /// when connecting to a serverless workgroup and authenticating using either Secrets
        /// Manager or temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;
    }
}
