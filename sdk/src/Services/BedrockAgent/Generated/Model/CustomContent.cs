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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about the content to ingest into a knowledge base connected to
    /// a custom data source. Choose a <c>sourceType</c> and include the field that corresponds
    /// to it.
    /// </summary>
    public partial class CustomContent
    {
        private CustomDocumentIdentifier _customDocumentIdentifier;
        private InlineContent _inlineContent;
        private CustomS3Location _s3Location;
        private CustomSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property CustomDocumentIdentifier. 
        /// <para>
        /// A unique identifier for the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomDocumentIdentifier CustomDocumentIdentifier
        {
            get { return this._customDocumentIdentifier; }
            set { this._customDocumentIdentifier = value; }
        }

        // Check to see if CustomDocumentIdentifier property is set
        internal bool IsSetCustomDocumentIdentifier()
        {
            return this._customDocumentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property InlineContent. 
        /// <para>
        /// Contains information about content defined inline to ingest into a knowledge base.
        /// </para>
        /// </summary>
        public InlineContent InlineContent
        {
            get { return this._inlineContent; }
            set { this._inlineContent = value; }
        }

        // Check to see if InlineContent property is set
        internal bool IsSetInlineContent()
        {
            return this._inlineContent != null;
        }

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// Contains information about the Amazon S3 location of the file from which to ingest
        /// data.
        /// </para>
        /// </summary>
        public CustomS3Location S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source of the data to ingest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}