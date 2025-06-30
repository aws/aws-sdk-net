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
    /// Configuration for how metadata should be used during the reranking process in Knowledge
    /// Base vector searches. This determines which metadata fields are included or excluded
    /// when reordering search results.
    /// </summary>
    public partial class MetadataConfigurationForReranking
    {
        private RerankingMetadataSelectionMode _selectionMode;
        private RerankingMetadataSelectiveModeConfiguration _selectiveModeConfiguration;

        /// <summary>
        /// Gets and sets the property SelectionMode. 
        /// <para>
        /// The mode for selecting which metadata fields to include in the reranking process.
        /// Valid values are ALL (use all available metadata fields) or SELECTIVE (use only specified
        /// fields).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RerankingMetadataSelectionMode SelectionMode
        {
            get { return this._selectionMode; }
            set { this._selectionMode = value; }
        }

        // Check to see if SelectionMode property is set
        internal bool IsSetSelectionMode()
        {
            return this._selectionMode != null;
        }

        /// <summary>
        /// Gets and sets the property SelectiveModeConfiguration. 
        /// <para>
        /// Configuration for selective mode, which allows you to explicitly include or exclude
        /// specific metadata fields during reranking. This is only used when selectionMode is
        /// set to SELECTIVE.
        /// </para>
        /// </summary>
        public RerankingMetadataSelectiveModeConfiguration SelectiveModeConfiguration
        {
            get { return this._selectiveModeConfiguration; }
            set { this._selectiveModeConfiguration = value; }
        }

        // Check to see if SelectiveModeConfiguration property is set
        internal bool IsSetSelectiveModeConfiguration()
        {
            return this._selectiveModeConfiguration != null;
        }

    }
}