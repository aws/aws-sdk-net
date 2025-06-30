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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Configuration for implicit filtering in Knowledge Base vector searches. Implicit filtering
    /// allows you to automatically filter search results based on metadata attributes without
    /// requiring explicit filter expressions in each query.
    /// </summary>
    public partial class ImplicitFilterConfiguration
    {
        private List<MetadataAttributeSchema> _metadataAttributes = AWSConfigs.InitializeCollections ? new List<MetadataAttributeSchema>() : null;
        private string _modelArn;

        /// <summary>
        /// Gets and sets the property MetadataAttributes. 
        /// <para>
        /// A list of metadata attribute schemas that define the structure and properties of metadata
        /// fields used for implicit filtering. Each attribute defines a key, type, and optional
        /// description.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<MetadataAttributeSchema> MetadataAttributes
        {
            get { return this._metadataAttributes; }
            set { this._metadataAttributes = value; }
        }

        // Check to see if MetadataAttributes property is set
        internal bool IsSetMetadataAttributes()
        {
            return this._metadataAttributes != null && (this._metadataAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the foundation model used for implicit filtering.
        /// This model processes the query to extract relevant filtering criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

    }
}