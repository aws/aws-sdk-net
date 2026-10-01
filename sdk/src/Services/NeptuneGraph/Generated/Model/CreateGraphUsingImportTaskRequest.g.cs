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
    /// Container for the parameters to the CreateGraphUsingImportTask operation. Creates
    /// a new Neptune Analytics graph and imports data into it, either from Amazon Simple
    /// Storage Service (S3) or from a Neptune database or a Neptune database snapshot. <para>
    /// The data can be loaded from files in S3 that in either the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
    /// CSV format</a> or the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
    /// load format</a>. </para>
    /// </summary>
    public partial class CreateGraphUsingImportTaskRequest : AmazonNeptuneGraphRequest
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
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether or not to enable deletion protection on the graph. The graph can’t
        /// be deleted when deletion protection is enabled. (<c>true</c> or <c>false</c>).
        /// </para>
        /// </summary>
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection.HasValue;

        /// <summary>
        /// Gets and sets the property FailOnError. 
        /// <para>
        /// If set to <c>true</c>, the task halts when an import error is encountered. If set
        /// to <c>false</c>, the task skips the data that caused the error and continues if possible.
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
        /// Specifies the format of S3 data to be imported. Valid values are <c>CSV</c>, which
        /// identifies the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
        /// CSV format</a>, <c>OPEN_CYPHER</c>, which identifies the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
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
        /// Gets and sets the property GraphName. 
        /// <para>
        /// A name for the new Neptune Analytics graph to be created.
        /// </para>
        ///  
        /// <para>
        /// The name must contain from 1 to 63 letters, numbers, or hyphens, and its first character
        /// must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
        /// Only lowercase letters are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string GraphName { get; set; }

        /// <summary>
        /// Checks to see if the GraphName property is set.
        /// </summary>
        internal bool IsSetGraphName() => this.GraphName != null;

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
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// Specifies a KMS key to use to encrypt data imported into the new graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxProvisionedMemory. 
        /// <para>
        /// The maximum provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for
        /// the graph. Default: 1024, or the approved upper limit for your account.
        /// </para>
        ///  
        /// <para>
        ///  If both the minimum and maximum values are specified, the final <c>provisioned-memory</c>
        /// will be chosen per the actual size of your imported data. If neither value is specified,
        /// 128 m-NCUs are used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 24576)]
        public int? MaxProvisionedMemory { get; set; }

        /// <summary>
        /// Checks to see if the MaxProvisionedMemory property is set.
        /// </summary>
        internal bool IsSetMaxProvisionedMemory() => this.MaxProvisionedMemory.HasValue;

        /// <summary>
        /// Gets and sets the property MinProvisionedMemory. 
        /// <para>
        /// The minimum provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for
        /// the graph. Default: 16
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 24576)]
        public int? MinProvisionedMemory { get; set; }

        /// <summary>
        /// Checks to see if the MinProvisionedMemory property is set.
        /// </summary>
        internal bool IsSetMinProvisionedMemory() => this.MinProvisionedMemory.HasValue;

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
        /// Gets and sets the property PublicConnectivity. 
        /// <para>
        /// Specifies whether or not the graph can be reachable over the internet. All access
        /// to graphs is IAM authenticated. (<c>true</c> to enable, or <c>false</c> to disable).
        /// </para>
        /// </summary>
        public bool? PublicConnectivity { get; set; }

        /// <summary>
        /// Checks to see if the PublicConnectivity property is set.
        /// </summary>
        internal bool IsSetPublicConnectivity() => this.PublicConnectivity.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicaCount. 
        /// <para>
        /// The number of replicas in other AZs to provision on the new graph after import. Default
        /// = 1, Min = 0, Max = 2.
        /// </para>
        ///  <important> 
        /// <para>
        ///  Additional charges equivalent to the m-NCUs selected for the graph apply for each
        /// replica. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Checks to see if the ReplicaCount property is set.
        /// </summary>
        internal bool IsSetReplicaCount() => this.ReplicaCount.HasValue;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds metadata tags to the new graph. These tags can also be used with cost allocation
        /// reporting, or used in a Condition statement in an IAM policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VectorSearchConfiguration. 
        /// <para>
        /// Specifies the number of dimensions for vector embeddings that will be loaded into
        /// the graph. The value is specified as <c>dimension=</c>value. Max = 65,535 
        /// </para>
        /// </summary>
        public VectorSearchConfiguration VectorSearchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VectorSearchConfiguration property is set.
        /// </summary>
        internal bool IsSetVectorSearchConfiguration() => this.VectorSearchConfiguration != null;
    }
}
