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
    /// Specifies an Glue Data Catalog target.
    /// </summary>
    public partial class CatalogTarget
    {
        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection for an Amazon S3-backed Data Catalog table to be a target
        /// of the crawl when using a <c>Catalog</c> connection type paired with a <c>NETWORK</c>
        /// Connection type.
        /// </para>
        /// </summary>
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database to be synchronized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property DlqEventQueueArn. 
        /// <para>
        /// A valid Amazon dead-letter SQS ARN. For example, <c>arn:aws:sqs:region:account:deadLetterQueue</c>.
        /// </para>
        /// </summary>
        public string DlqEventQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the DlqEventQueueArn property is set.
        /// </summary>
        internal bool IsSetDlqEventQueueArn() => this.DlqEventQueueArn != null;

        /// <summary>
        /// Gets and sets the property EventQueueArn. 
        /// <para>
        /// A valid Amazon SQS ARN. For example, <c>arn:aws:sqs:region:account:sqs</c>.
        /// </para>
        /// </summary>
        public string EventQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the EventQueueArn property is set.
        /// </summary>
        internal bool IsSetEventQueueArn() => this.EventQueueArn != null;

        /// <summary>
        /// Gets and sets the property Tables. 
        /// <para>
        /// A list of the tables to be synchronized.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> Tables { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Tables property is set.
        /// </summary>
        internal bool IsSetTables() => this.Tables != null && (this.Tables.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
