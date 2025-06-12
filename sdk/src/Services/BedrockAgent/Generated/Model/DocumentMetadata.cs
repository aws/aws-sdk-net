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
    /// Contains information about the metadata associate with the content to ingest into
    /// a knowledge base. Choose a <c>type</c> and include the field that corresponds to it.
    /// </summary>
    public partial class DocumentMetadata
    {
        private List<MetadataAttribute> _inlineAttributes = AWSConfigs.InitializeCollections ? new List<MetadataAttribute>() : null;
        private CustomS3Location _s3Location;
        private MetadataSourceType _type;

        /// <summary>
        /// Gets and sets the property InlineAttributes. 
        /// <para>
        /// An array of objects, each of which defines a metadata attribute to associate with
        /// the content to ingest. You define the attributes inline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<MetadataAttribute> InlineAttributes
        {
            get { return this._inlineAttributes; }
            set { this._inlineAttributes = value; }
        }

        // Check to see if InlineAttributes property is set
        internal bool IsSetInlineAttributes()
        {
            return this._inlineAttributes != null && (this._inlineAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The Amazon S3 location of the file containing metadata to associate with the content
        /// to ingest.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the source source from which to add metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataSourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}