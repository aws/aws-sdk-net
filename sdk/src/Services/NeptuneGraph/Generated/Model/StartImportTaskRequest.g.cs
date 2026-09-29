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
    /// Container for the parameters to the StartImportTask operation. Import data into existing
    /// Neptune Analytics graph from Amazon Simple Storage Service (S3). The graph needs to
    /// be empty and in the AVAILABLE state.
    /// </summary>
    public partial class StartImportTaskRequest : AmazonNeptuneGraphRequest
    {
        /// <summary>
        /// Gets and sets the property BlankNodeHandling. 
        /// <para>
        /// The method to handle blank nodes in the dataset. Currently, only <c>convertToIri</c>
        /// is supported, meaning blank nodes are converted to unique IRIs at load time. Must
        /// be provided when format is <c>ntriples</c>. For more information, see <a href="https://docs.aws.amazon.com/neptune-analytics/latest/userguide/using-rdf-data.html#rdf-handling">Handling
        /// RDF values</a>.
        /// </para>
        /// </summary>
        public BlankNodeHandling BlankNodeHandling { get; set; }

        /// <summary>
        /// Checks to see if the BlankNodeHandling property is set.
        /// </summary>
        internal bool IsSetBlankNodeHandling() => this.BlankNodeHandling != null;

        /// <summary>
        /// Gets and sets the property FailOnError. 
        /// <para>
        /// If set to true, the task halts when an import error is encountered. If set to false,
        /// the task skips the data that caused the error and continues if possible.
        /// </para>
        /// </summary>
        public bool? FailOnError { get; set; }

        /// <summary>
        /// Checks to see if the FailOnError property is set.
        /// </summary>
        internal bool IsSetFailOnError() => this.FailOnError.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the format of Amazon S3 data to be imported. Valid values are CSV, which
        /// identifies the Gremlin CSV format or OPENCYPHER, which identifies the openCypher load
        /// format.
        /// </para>
        /// </summary>
        public Format Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property GraphIdentifier. 
        /// <para>
        /// The unique identifier of the Neptune Analytics graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GraphIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GraphIdentifier property is set.
        /// </summary>
        internal bool IsSetGraphIdentifier() => this.GraphIdentifier != null;

        /// <summary>
        /// Gets and sets the property ImportOptions.
        /// </summary>
        public ImportOptions ImportOptions { get; set; }

        /// <summary>
        /// Checks to see if the ImportOptions property is set.
        /// </summary>
        internal bool IsSetImportOptions() => this.ImportOptions != null;

        /// <summary>
        /// Gets and sets the property ParquetType. 
        /// <para>
        /// The parquet type of the import task.
        /// </para>
        /// </summary>
        public ParquetType ParquetType { get; set; }

        /// <summary>
        /// Checks to see if the ParquetType property is set.
        /// </summary>
        internal bool IsSetParquetType() => this.ParquetType != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that will allow access to the data that is to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// A URL identifying the location of the data to be imported. This can be an Amazon S3
        /// path, or can point to a Neptune database endpoint or snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
