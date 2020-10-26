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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Specifies the attachment settings for the Confluence data source. Attachment settings
    /// are optional, if you don't specify settings attachments, Amazon Kendra won't index
    /// them.
    /// </summary>
    public partial class ConfluenceAttachmentConfiguration
    {
        private List<ConfluenceAttachmentToIndexFieldMapping> _attachmentFieldMappings = new List<ConfluenceAttachmentToIndexFieldMapping>();
        private bool? _crawlAttachments;

        /// <summary>
        /// Gets and sets the property AttachmentFieldMappings. 
        /// <para>
        /// Defines how attachment metadata fields should be mapped to index fields. Before you
        /// can map a field, you must first create an index field with a matching type using the
        /// console or the <code>UpdateIndex</code> operation.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>AttachentFieldMappings</code> parameter, you must specify
        /// at least one field mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=11)]
        public List<ConfluenceAttachmentToIndexFieldMapping> AttachmentFieldMappings
        {
            get { return this._attachmentFieldMappings; }
            set { this._attachmentFieldMappings = value; }
        }

        // Check to see if AttachmentFieldMappings property is set
        internal bool IsSetAttachmentFieldMappings()
        {
            return this._attachmentFieldMappings != null && this._attachmentFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        /// Indicates whether Amazon Kendra indexes attachments to the pages and blogs in the
        /// Confluence data source. 
        /// </para>
        /// </summary>
        public bool CrawlAttachments
        {
            get { return this._crawlAttachments.GetValueOrDefault(); }
            set { this._crawlAttachments = value; }
        }

        // Check to see if CrawlAttachments property is set
        internal bool IsSetCrawlAttachments()
        {
            return this._crawlAttachments.HasValue; 
        }

    }
}