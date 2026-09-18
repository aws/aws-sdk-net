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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about the storage configuration of the knowledge base in Amazon RDS.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-rds.html">Create
    /// a vector index in Amazon RDS</a>.
    /// </summary>
    public partial class RdsConfiguration
    {
        /// <summary>
        /// Gets and sets the property CredentialsSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret that you created in Secrets Manager that
        /// is linked to your Amazon RDS database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CredentialsSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsSecretArn property is set.
        /// </summary>
        internal bool IsSetCredentialsSecretArn() => this.CredentialsSecretArn != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of your Amazon RDS database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property FieldMapping. 
        /// <para>
        /// Contains the names of the fields to which to map information about the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RdsFieldMapping FieldMapping { get; set; }

        /// <summary>
        /// Checks to see if the FieldMapping property is set.
        /// </summary>
        internal bool IsSetFieldMapping() => this.FieldMapping != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table in the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
