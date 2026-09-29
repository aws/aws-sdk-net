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
    /// This is the response object from the CreateGraphUsingImportTask operation.
    /// </summary>
    public partial class CreateGraphUsingImportTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the format of S3 data to be imported. Valid values are <c>CSV</c>, which
        /// identifies the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
        /// CSV format</a>, <c>OPENCYPHER</c>, which identifies the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
        /// load format</a>, or <c>ntriples</c>, which identifies the <a href="https://docs.aws.amazon.com/neptune-analytics/latest/userguide/using-rdf-data.html">RDF
        /// n-triples</a> format.
        /// </para>
        /// </summary>
        public Format Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property GraphId. 
        /// <para>
        /// The unique identifier of the Neptune Analytics graph.
        /// </para>
        /// </summary>
        public string GraphId { get; set; }

        /// <summary>
        /// Checks to see if the GraphId property is set.
        /// </summary>
        internal bool IsSetGraphId() => this.GraphId != null;

        /// <summary>
        /// Gets and sets the property ImportOptions. 
        /// <para>
        /// Contains options for controlling the import process. For example, if the <c>failOnError</c>
        /// key is set to <c>false</c>, the import skips problem data and attempts to continue
        /// (whereas if set to <c>true</c>, the default, or if omitted, the import operation halts
        /// immediately when an error is encountered.
        /// </para>
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
        /// A URL identifying to the location of the data to be imported. This can be an Amazon
        /// S3 path, or can point to a Neptune database endpoint or snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
