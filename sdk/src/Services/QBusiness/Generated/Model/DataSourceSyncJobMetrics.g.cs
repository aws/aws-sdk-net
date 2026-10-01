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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Maps a batch delete document request to a specific Amazon Q Business data source connector
    /// sync job.
    /// </summary>
    public partial class DataSourceSyncJobMetrics
    {
        /// <summary>
        /// Gets and sets the property DocumentsAdded. 
        /// <para>
        /// The current count of documents added from the data source during the data source sync.
        /// </para>
        /// </summary>
        public string DocumentsAdded { get; set; }

        /// <summary>
        /// Checks to see if the DocumentsAdded property is set.
        /// </summary>
        internal bool IsSetDocumentsAdded() => this.DocumentsAdded != null;

        /// <summary>
        /// Gets and sets the property DocumentsDeleted. 
        /// <para>
        /// The current count of documents deleted from the data source during the data source
        /// sync.
        /// </para>
        /// </summary>
        public string DocumentsDeleted { get; set; }

        /// <summary>
        /// Checks to see if the DocumentsDeleted property is set.
        /// </summary>
        internal bool IsSetDocumentsDeleted() => this.DocumentsDeleted != null;

        /// <summary>
        /// Gets and sets the property DocumentsFailed. 
        /// <para>
        /// The current count of documents that failed to sync from the data source during the
        /// data source sync.
        /// </para>
        /// </summary>
        public string DocumentsFailed { get; set; }

        /// <summary>
        /// Checks to see if the DocumentsFailed property is set.
        /// </summary>
        internal bool IsSetDocumentsFailed() => this.DocumentsFailed != null;

        /// <summary>
        /// Gets and sets the property DocumentsModified. 
        /// <para>
        /// The current count of documents modified in the data source during the data source
        /// sync.
        /// </para>
        /// </summary>
        public string DocumentsModified { get; set; }

        /// <summary>
        /// Checks to see if the DocumentsModified property is set.
        /// </summary>
        internal bool IsSetDocumentsModified() => this.DocumentsModified != null;

        /// <summary>
        /// Gets and sets the property DocumentsScanned. 
        /// <para>
        /// The current count of documents crawled by the ongoing sync job in the data source.
        /// </para>
        /// </summary>
        public string DocumentsScanned { get; set; }

        /// <summary>
        /// Checks to see if the DocumentsScanned property is set.
        /// </summary>
        internal bool IsSetDocumentsScanned() => this.DocumentsScanned != null;
    }
}
