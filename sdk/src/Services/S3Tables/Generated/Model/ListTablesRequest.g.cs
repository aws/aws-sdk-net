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
    /// Container for the parameters to the ListTables operation. List tables in the given
    /// table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
    /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>. <dl> <dt>Permissions</dt>
    /// <dd> <para> You must have the <c>s3tables:ListTables</c> permission to use this operation.
    /// </para> </dd> </dl>
    /// </summary>
    public partial class ListTablesRequest : AmazonS3TablesRequest
    {
        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        ///  <c>ContinuationToken</c> indicates to Amazon S3 that the list is being continued
        /// on this bucket with a token. <c>ContinuationToken</c> is obfuscated and is not a real
        /// key. You can use this <c>ContinuationToken</c> for pagination of the list results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// Checks to see if the ContinuationToken property is set.
        /// </summary>
        internal bool IsSetContinuationToken() => this.ContinuationToken != null;

        /// <summary>
        /// Gets and sets the property MaxTables. 
        /// <para>
        /// The maximum number of tables to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxTables { get; set; }

        /// <summary>
        /// Checks to see if the MaxTables property is set.
        /// </summary>
        internal bool IsSetMaxTables() => this.MaxTables.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the tables.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the tables.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon resource Name (ARN) of the table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableBucketARN { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketARN property is set.
        /// </summary>
        internal bool IsSetTableBucketARN() => this.TableBucketARN != null;
    }
}
