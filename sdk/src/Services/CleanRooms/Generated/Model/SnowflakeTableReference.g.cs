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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A reference to a table within Snowflake.
    /// </summary>
    public partial class SnowflakeTableReference
    {
        /// <summary>
        /// Gets and sets the property AccountIdentifier. 
        /// <para>
        ///  The account identifier for the Snowflake table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 256)]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AccountIdentifier property is set.
        /// </summary>
        internal bool IsSetAccountIdentifier() => this.AccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        ///  The name of the database the Snowflake table belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        ///  The schema name of the Snowflake table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        ///  The secret ARN of the Snowflake table reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        ///  The name of the Snowflake table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TableSchema. 
        /// <para>
        ///  The schema of the Snowflake table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SnowflakeTableSchema TableSchema { get; set; }

        /// <summary>
        /// Checks to see if the TableSchema property is set.
        /// </summary>
        internal bool IsSetTableSchema() => this.TableSchema != null;
    }
}
