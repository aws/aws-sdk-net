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

namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// A full-text search configuration for a single metadata key.
    /// </summary>
    public partial class TextSearchConfiguration
    {
        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language that the text search analyzer uses. Valid values are <c>en</c> (English),
        /// <c>fr</c> (French), <c>es</c> (Spanish), <c>pt</c> (Portuguese), <c>it</c> (Italian),
        /// <c>de</c> (German), <c>nl</c> (Dutch), <c>zh</c> (Chinese), <c>ja</c> (Japanese),
        /// and <c>ko</c> (Korean). If you don't specify a language, Amazon S3 Vectors uses the
        /// default standard analyzer.
        /// </para>
        /// </summary>
        public LanguageCode Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property MetadataKey. 
        /// <para>
        /// The metadata key to make full-text searchable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string MetadataKey { get; set; }

        /// <summary>
        /// Checks to see if the MetadataKey property is set.
        /// </summary>
        internal bool IsSetMetadataKey() => this.MetadataKey != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The backfill status of the text search configuration. Valid values are <c>ACTIVE</c>,
        /// which indicates that the analyzer is built and serving queries, and <c>BUILDING</c>,
        /// which indicates that the analyzer is being backfilled and isn't yet serving queries.
        /// This field is returned by <c>GetIndex</c>.
        /// </para>
        /// </summary>
        public AnalyzerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
