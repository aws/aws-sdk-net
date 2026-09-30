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
    /// Container for the parameters to the ListNamespaces operation. Lists the namespaces
    /// within a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
    /// namespaces</a> in the <i>Amazon Simple Storage Service User Guide</i>. <dl> <dt>Permissions</dt>
    /// <dd> <para> You must have the <c>s3tables:ListNamespaces</c> permission to use this
    /// operation. </para> </dd> </dl>
    /// </summary>
    public partial class ListNamespacesRequest : AmazonS3TablesRequest
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
        /// Gets and sets the property MaxNamespaces. 
        /// <para>
        /// The maximum number of namespaces to return in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxNamespaces { get; set; }

        /// <summary>
        /// Checks to see if the MaxNamespaces property is set.
        /// </summary>
        internal bool IsSetMaxNamespaces() => this.MaxNamespaces.HasValue;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix of the namespaces.
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
        /// The Amazon Resource Name (ARN) of the table bucket.
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
