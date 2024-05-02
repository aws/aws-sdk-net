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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
        private string _documentsAdded;
        private string _documentsDeleted;
        private string _documentsFailed;
        private string _documentsModified;
        private string _documentsScanned;

        /// <summary>
        /// Gets and sets the property DocumentsAdded. 
        /// <para>
        /// The current count of documents added from the data source during the data source sync.
        /// </para>
        /// </summary>
        public string DocumentsAdded
        {
            get { return this._documentsAdded; }
            set { this._documentsAdded = value; }
        }

        // Check to see if DocumentsAdded property is set
        internal bool IsSetDocumentsAdded()
        {
            return this._documentsAdded != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentsDeleted. 
        /// <para>
        /// The current count of documents deleted from the data source during the data source
        /// sync.
        /// </para>
        /// </summary>
        public string DocumentsDeleted
        {
            get { return this._documentsDeleted; }
            set { this._documentsDeleted = value; }
        }

        // Check to see if DocumentsDeleted property is set
        internal bool IsSetDocumentsDeleted()
        {
            return this._documentsDeleted != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentsFailed. 
        /// <para>
        /// The current count of documents that failed to sync from the data source during the
        /// data source sync.
        /// </para>
        /// </summary>
        public string DocumentsFailed
        {
            get { return this._documentsFailed; }
            set { this._documentsFailed = value; }
        }

        // Check to see if DocumentsFailed property is set
        internal bool IsSetDocumentsFailed()
        {
            return this._documentsFailed != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentsModified. 
        /// <para>
        /// The current count of documents modified in the data source during the data source
        /// sync.
        /// </para>
        /// </summary>
        public string DocumentsModified
        {
            get { return this._documentsModified; }
            set { this._documentsModified = value; }
        }

        // Check to see if DocumentsModified property is set
        internal bool IsSetDocumentsModified()
        {
            return this._documentsModified != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentsScanned. 
        /// <para>
        /// The current count of documents crawled by the ongoing sync job in the data source.
        /// </para>
        /// </summary>
        public string DocumentsScanned
        {
            get { return this._documentsScanned; }
            set { this._documentsScanned = value; }
        }

        // Check to see if DocumentsScanned property is set
        internal bool IsSetDocumentsScanned()
        {
            return this._documentsScanned != null;
        }

    }
}