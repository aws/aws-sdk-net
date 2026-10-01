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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the names of the fields to which to map information about the vector store.
    /// </summary>
    public partial class RdsFieldMapping
    {
        /// <summary>
        /// Gets and sets the property CustomMetadataField. 
        /// <para>
        /// Provide a name for the universal metadata field where Amazon Bedrock will store any
        /// custom metadata from your data source.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 63)]
        public string CustomMetadataField { get; set; }

        /// <summary>
        /// Checks to see if the CustomMetadataField property is set.
        /// </summary>
        internal bool IsSetCustomMetadataField() => this.CustomMetadataField != null;

        /// <summary>
        /// Gets and sets the property MetadataField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores metadata about the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string MetadataField { get; set; }

        /// <summary>
        /// Checks to see if the MetadataField property is set.
        /// </summary>
        internal bool IsSetMetadataField() => this.MetadataField != null;

        /// <summary>
        /// Gets and sets the property PrimaryKeyField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores the ID for each entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string PrimaryKeyField { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryKeyField property is set.
        /// </summary>
        internal bool IsSetPrimaryKeyField() => this.PrimaryKeyField != null;

        /// <summary>
        /// Gets and sets the property TextField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores the raw text from your data.
        /// The text is split according to the chunking strategy you choose.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string TextField { get; set; }

        /// <summary>
        /// Checks to see if the TextField property is set.
        /// </summary>
        internal bool IsSetTextField() => this.TextField != null;

        /// <summary>
        /// Gets and sets the property VectorField. 
        /// <para>
        /// The name of the field in which Amazon Bedrock stores the vector embeddings for your
        /// data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string VectorField { get; set; }

        /// <summary>
        /// Checks to see if the VectorField property is set.
        /// </summary>
        internal bool IsSetVectorField() => this.VectorField != null;
    }
}
