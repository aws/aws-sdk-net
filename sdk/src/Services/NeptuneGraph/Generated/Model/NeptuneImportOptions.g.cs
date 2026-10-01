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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Options for how to import Neptune data.
    /// </summary>
    public partial class NeptuneImportOptions
    {
        /// <summary>
        /// Gets and sets the property PreserveDefaultVertexLabels. 
        /// <para>
        /// Neptune Analytics supports label-less vertices and no labels are assigned unless one
        /// is explicitly provided. Neptune assigns default labels when none is explicitly provided.
        /// When importing the data into Neptune Analytics, the default vertex labels can be omitted
        /// by setting <i>preserveDefaultVertexLabels</i> to false. Note that if the vertex only
        /// has default labels, and has no other properties or edges, then the vertex will effectively
        /// not get imported into Neptune Analytics when preserveDefaultVertexLabels is set to
        /// false.
        /// </para>
        /// </summary>
        public bool? PreserveDefaultVertexLabels { get; set; }

        /// <summary>
        /// Checks to see if the PreserveDefaultVertexLabels property is set.
        /// </summary>
        internal bool IsSetPreserveDefaultVertexLabels() => this.PreserveDefaultVertexLabels.HasValue;

        /// <summary>
        /// Gets and sets the property PreserveEdgeIds. 
        /// <para>
        /// Neptune Analytics currently does not support user defined edge ids. The edge ids are
        /// not imported by default. They are imported if <i>preserveEdgeIds</i> is set to true,
        /// and ids are stored as properties on the relationships with the property name <i>neptuneEdgeId</i>.
        /// </para>
        /// </summary>
        public bool? PreserveEdgeIds { get; set; }

        /// <summary>
        /// Checks to see if the PreserveEdgeIds property is set.
        /// </summary>
        internal bool IsSetPreserveEdgeIds() => this.PreserveEdgeIds.HasValue;

        /// <summary>
        /// Gets and sets the property S3ExportKmsKeyId. 
        /// <para>
        /// The KMS key to use to encrypt data in the S3 bucket where the graph data is exported
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string S3ExportKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3ExportKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3ExportKmsKeyId() => this.S3ExportKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property S3ExportPath. 
        /// <para>
        /// The path to an S3 bucket from which to import data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string S3ExportPath { get; set; }

        /// <summary>
        /// Checks to see if the S3ExportPath property is set.
        /// </summary>
        internal bool IsSetS3ExportPath() => this.S3ExportPath != null;
    }
}
