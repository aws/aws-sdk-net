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
    /// Contains the names of the fields to which to map information about the vector store.
    /// </summary>
    public partial class RdsFieldMapping
    {
        private string _customMetadataField;
        private string _metadataField;
        private string _primaryKeyField;
        private string _textField;
        private string _vectorField;

        /// <summary>
        /// Gets and sets the property CustomMetadataField. 
        /// <para>
        /// Provide a name for the universal metadata field where Amazon Bedrock will store any
        /// custom metadata from your data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string CustomMetadataField
        {
            get { return this._customMetadataField; }
            set { this._customMetadataField = value; }
        }

        // Check to see if CustomMetadataField property is set
        internal bool IsSetCustomMetadataField()
        {
            return this._customMetadataField != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores metadata about the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string MetadataField
        {
            get { return this._metadataField; }
            set { this._metadataField = value; }
        }

        // Check to see if MetadataField property is set
        internal bool IsSetMetadataField()
        {
            return this._metadataField != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryKeyField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores the ID for each entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string PrimaryKeyField
        {
            get { return this._primaryKeyField; }
            set { this._primaryKeyField = value; }
        }

        // Check to see if PrimaryKeyField property is set
        internal bool IsSetPrimaryKeyField()
        {
            return this._primaryKeyField != null;
        }

        /// <summary>
        /// Gets and sets the property TextField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores the raw text from your data.
        /// The text is split according to the chunking strategy you choose.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string TextField
        {
            get { return this._textField; }
            set { this._textField = value; }
        }

        // Check to see if TextField property is set
        internal bool IsSetTextField()
        {
            return this._textField != null;
        }

        /// <summary>
        /// Gets and sets the property VectorField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores the vector embeddings for your
        /// data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string VectorField
        {
            get { return this._vectorField; }
            set { this._vectorField = value; }
        }

        // Check to see if VectorField property is set
        internal bool IsSetVectorField()
        {
            return this._vectorField != null;
        }

    }
}