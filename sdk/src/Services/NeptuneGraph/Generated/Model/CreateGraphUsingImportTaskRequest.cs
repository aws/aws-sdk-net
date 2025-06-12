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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
    /// Container for the parameters to the CreateGraphUsingImportTask operation.
    /// Creates a new Neptune Analytics graph and imports data into it, either from Amazon
    /// Simple Storage Service (S3) or from a Neptune database or a Neptune database snapshot.
    /// 
    ///  
    /// <para>
    /// The data can be loaded from files in S3 that in either the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
    /// CSV format</a> or the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
    /// load format</a>.
    /// </para>
    /// </summary>
    public partial class CreateGraphUsingImportTaskRequest : AmazonNeptuneGraphRequest
    {
        private BlankNodeHandling _blankNodeHandling;
        private bool? _deletionProtection;
        private bool? _failOnError;
        private Format _format;
        private string _graphName;
        private ImportOptions _importOptions;
        private string _kmsKeyIdentifier;
        private int? _maxProvisionedMemory;
        private int? _minProvisionedMemory;
        private ParquetType _parquetType;
        private bool? _publicConnectivity;
        private int? _replicaCount;
        private string _roleArn;
        private string _source;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VectorSearchConfiguration _vectorSearchConfiguration;

        /// <summary>
        /// Gets and sets the property BlankNodeHandling. 
        /// <para>
        /// The method to handle blank nodes in the dataset. Currently, only <c>convertToIri</c>
        /// is supported, meaning blank nodes are converted to unique IRIs at load time. Must
        /// be provided when format is <c>ntriples</c>. For more information, see <a href="https://docs.aws.amazon.com/neptune-analytics/latest/userguide/using-rdf-data.html#rdf-handling">Handling
        /// RDF values</a>.
        /// </para>
        /// </summary>
        public BlankNodeHandling BlankNodeHandling
        {
            get { return this._blankNodeHandling; }
            set { this._blankNodeHandling = value; }
        }

        // Check to see if BlankNodeHandling property is set
        internal bool IsSetBlankNodeHandling()
        {
            return this._blankNodeHandling != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Indicates whether or not to enable deletion protection on the graph. The graph can’t
        /// be deleted when deletion protection is enabled. (<c>true</c> or <c>false</c>).
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailOnError. 
        /// <para>
        /// If set to <c>true</c>, the task halts when an import error is encountered. If set
        /// to <c>false</c>, the task skips the data that caused the error and continues if possible.
        /// </para>
        /// </summary>
        public bool? FailOnError
        {
            get { return this._failOnError; }
            set { this._failOnError = value; }
        }

        // Check to see if FailOnError property is set
        internal bool IsSetFailOnError()
        {
            return this._failOnError.HasValue; 
        }

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
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string GraphName
        {
            get { return this._graphName; }
            set { this._graphName = value; }
        }

        // Check to see if GraphName property is set
        internal bool IsSetGraphName()
        {
            return this._graphName != null;
        }

        /// <summary>
        /// Gets and sets the property ImportOptions. 
        /// <para>
        /// Contains options for controlling the import process. For example, if the <c>failOnError</c>
        /// key is set to <c>false</c>, the import skips problem data and attempts to continue
        /// (whereas if set to <c>true</c>, the default, or if omitted, the import operation halts
        /// immediately when an error is encountered.
        /// </para>
        /// </summary>
        public ImportOptions ImportOptions
        {
            get { return this._importOptions; }
            set { this._importOptions = value; }
        }

        // Check to see if ImportOptions property is set
        internal bool IsSetImportOptions()
        {
            return this._importOptions != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// Specifies a KMS key to use to encrypt data imported into the new graph.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

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
        [AWSProperty(Min=16, Max=24576)]
        public int? MaxProvisionedMemory
        {
            get { return this._maxProvisionedMemory; }
            set { this._maxProvisionedMemory = value; }
        }

        // Check to see if MaxProvisionedMemory property is set
        internal bool IsSetMaxProvisionedMemory()
        {
            return this._maxProvisionedMemory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinProvisionedMemory. 
        /// <para>
        /// The minimum provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for
        /// the graph. Default: 16
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=24576)]
        public int? MinProvisionedMemory
        {
            get { return this._minProvisionedMemory; }
            set { this._minProvisionedMemory = value; }
        }

        // Check to see if MinProvisionedMemory property is set
        internal bool IsSetMinProvisionedMemory()
        {
            return this._minProvisionedMemory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParquetType. 
        /// <para>
        /// The parquet type of the import task.
        /// </para>
        /// </summary>
        public ParquetType ParquetType
        {
            get { return this._parquetType; }
            set { this._parquetType = value; }
        }

        // Check to see if ParquetType property is set
        internal bool IsSetParquetType()
        {
            return this._parquetType != null;
        }

        /// <summary>
        /// Gets and sets the property PublicConnectivity. 
        /// <para>
        /// Specifies whether or not the graph can be reachable over the internet. All access
        /// to graphs is IAM authenticated. (<c>true</c> to enable, or <c>false</c> to disable).
        /// </para>
        /// </summary>
        public bool? PublicConnectivity
        {
            get { return this._publicConnectivity; }
            set { this._publicConnectivity = value; }
        }

        // Check to see if PublicConnectivity property is set
        internal bool IsSetPublicConnectivity()
        {
            return this._publicConnectivity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicaCount. 
        /// <para>
        /// The number of replicas in other AZs to provision on the new graph after import. Default
        /// = 0, Min = 0, Max = 2.
        /// </para>
        ///  <important> 
        /// <para>
        ///  Additional charges equivalent to the m-NCUs selected for the graph apply for each
        /// replica. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public int? ReplicaCount
        {
            get { return this._replicaCount; }
            set { this._replicaCount = value; }
        }

        // Check to see if ReplicaCount property is set
        internal bool IsSetReplicaCount()
        {
            return this._replicaCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that will allow access to the data that is to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// A URL identifying to the location of the data to be imported. This can be an Amazon
        /// S3 path, or can point to a Neptune database endpoint or snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Adds metadata tags to the new graph. These tags can also be used with cost allocation
        /// reporting, or used in a Condition statement in an IAM policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VectorSearchConfiguration. 
        /// <para>
        /// Specifies the number of dimensions for vector embeddings that will be loaded into
        /// the graph. The value is specified as <c>dimension=</c>value. Max = 65,535 
        /// </para>
        /// </summary>
        public VectorSearchConfiguration VectorSearchConfiguration
        {
            get { return this._vectorSearchConfiguration; }
            set { this._vectorSearchConfiguration = value; }
        }

        // Check to see if VectorSearchConfiguration property is set
        internal bool IsSetVectorSearchConfiguration()
        {
            return this._vectorSearchConfiguration != null;
        }

    }
}