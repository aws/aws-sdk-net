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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the StartContentUpload operation.
    /// Get a URL to upload content to a knowledge base. To upload content, first make a PUT
    /// request to the returned URL with your file, making sure to include the required headers.
    /// Then use <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_CreateContent.html">CreateContent</a>
    /// to finalize the content creation process or <a href="https://docs.aws.amazon.com/amazon-q-connect/latest/APIReference/API_UpdateContent.html">UpdateContent</a>
    /// to modify an existing resource. You can only upload content to a knowledge base of
    /// type CUSTOM.
    /// </summary>
    public partial class StartContentUploadRequest : AmazonQConnectRequest
    {
        private string _contentType;
        private string _knowledgeBaseId;
        private int? _presignedUrlTimeToLive;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The type of content to upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. Can be either the ID or the ARN. URLs cannot
        /// contain the ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrlTimeToLive. 
        /// <para>
        /// The expected expiration time of the generated presigned URL, specified in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public int? PresignedUrlTimeToLive
        {
            get { return this._presignedUrlTimeToLive; }
            set { this._presignedUrlTimeToLive = value; }
        }

        // Check to see if PresignedUrlTimeToLive property is set
        internal bool IsSetPresignedUrlTimeToLive()
        {
            return this._presignedUrlTimeToLive.HasValue; 
        }

    }
}