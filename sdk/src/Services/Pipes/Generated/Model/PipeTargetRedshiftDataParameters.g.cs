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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// These are custom parameters to be used when the target is a Amazon Redshift cluster
    /// to invoke the Amazon Redshift Data API BatchExecuteStatement.
    /// </summary>
    public partial class PipeTargetRedshiftDataParameters
    {
        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database. Required when authenticating using temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property DbUser. 
        /// <para>
        /// The database user name. Required when authenticating using temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string DbUser { get; set; }

        /// <summary>
        /// Checks to see if the DbUser property is set.
        /// </summary>
        internal bool IsSetDbUser() => this.DbUser != null;

        /// <summary>
        /// Gets and sets the property SecretManagerArn. 
        /// <para>
        /// The name or ARN of the secret that enables access to the database. Required when authenticating
        /// using Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string SecretManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretManagerArn property is set.
        /// </summary>
        internal bool IsSetSecretManagerArn() => this.SecretManagerArn != null;

        /// <summary>
        /// Gets and sets the property Sqls. 
        /// <para>
        /// The SQL statement text to run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public List<string> Sqls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sqls property is set.
        /// </summary>
        internal bool IsSetSqls() => this.Sqls != null && (this.Sqls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the SQL statement. You can name the SQL statement when you create it to
        /// identify the query.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string StatementName { get; set; }

        /// <summary>
        /// Checks to see if the StatementName property is set.
        /// </summary>
        internal bool IsSetStatementName() => this.StatementName != null;

        /// <summary>
        /// Gets and sets the property WithEvent. 
        /// <para>
        /// Indicates whether to send an event back to EventBridge after the SQL statement runs.
        /// </para>
        /// </summary>
        public bool? WithEvent { get; set; }

        /// <summary>
        /// Checks to see if the WithEvent property is set.
        /// </summary>
        internal bool IsSetWithEvent() => this.WithEvent.HasValue;
    }
}
