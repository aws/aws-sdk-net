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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Indicates the method for setting up document ID. The supported methods are Firehose
    /// generated document ID and OpenSearch Service generated document ID.
    /// </summary>
    public partial class DocumentIdOptions
    {
        private DefaultDocumentIdFormat _defaultDocumentIdFormat;

        /// <summary>
        /// Gets and sets the property DefaultDocumentIdFormat. 
        /// <para>
        /// When the <c>FIREHOSE_DEFAULT</c> option is chosen, Firehose generates a unique document
        /// ID for each record based on a unique internal identifier. The generated document ID
        /// is stable across multiple delivery attempts, which helps prevent the same record from
        /// being indexed multiple times with different document IDs.
        /// </para>
        ///  
        /// <para>
        /// When the <c>NO_DOCUMENT_ID</c> option is chosen, Firehose does not include any document
        /// IDs in the requests it sends to the Amazon OpenSearch Service. This causes the Amazon
        /// OpenSearch Service domain to generate document IDs. In case of multiple delivery attempts,
        /// this may cause the same record to be indexed more than once with different document
        /// IDs. This option enables write-heavy operations, such as the ingestion of logs and
        /// observability data, to consume less resources in the Amazon OpenSearch Service domain,
        /// resulting in improved performance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DefaultDocumentIdFormat DefaultDocumentIdFormat
        {
            get { return this._defaultDocumentIdFormat; }
            set { this._defaultDocumentIdFormat = value; }
        }

        // Check to see if DefaultDocumentIdFormat property is set
        internal bool IsSetDefaultDocumentIdFormat()
        {
            return this._defaultDocumentIdFormat != null;
        }

    }
}