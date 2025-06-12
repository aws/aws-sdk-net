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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private string _connectionName;
        private string _databaseName;
        private string _dlqEventQueueArn;
        private string _eventQueueArn;
        private List<string> _tables = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection for an Amazon S3-backed Data Catalog table to be a target
        /// of the crawl when using a <c>Catalog</c> connection type paired with a <c>NETWORK</c>
        /// Connection type.
        /// </para>
        /// </summary>
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database to be synchronized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DlqEventQueueArn. 
        /// <para>
        /// A valid Amazon dead-letter SQS ARN. For example, <c>arn:aws:sqs:region:account:deadLetterQueue</c>.
        /// </para>
        /// </summary>
        public string DlqEventQueueArn
        {
            get { return this._dlqEventQueueArn; }
            set { this._dlqEventQueueArn = value; }
        }

        // Check to see if DlqEventQueueArn property is set
        internal bool IsSetDlqEventQueueArn()
        {
            return this._dlqEventQueueArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventQueueArn. 
        /// <para>
        /// A valid Amazon SQS ARN. For example, <c>arn:aws:sqs:region:account:sqs</c>.
        /// </para>
        /// </summary>
        public string EventQueueArn
        {
            get { return this._eventQueueArn; }
            set { this._eventQueueArn = value; }
        }

        // Check to see if EventQueueArn property is set
        internal bool IsSetEventQueueArn()
        {
            return this._eventQueueArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tables. 
        /// <para>
        /// A list of the tables to be synchronized.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Tables
        {
            get { return this._tables; }
            set { this._tables = value; }
        }

        // Check to see if Tables property is set
        internal bool IsSetTables()
        {
            return this._tables != null && (this._tables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}