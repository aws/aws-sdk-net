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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the StartLoaderJob operation.
    /// Starts a Neptune bulk loader job to load data from an Amazon S3 bucket into a Neptune
    /// DB instance. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load.html">Using
    /// the Amazon Neptune Bulk Loader to Ingest Data</a>.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startloaderjob">neptune-db:StartLoaderJob</a>
    /// IAM action in that cluster.
    /// </para>
    /// </summary>
    public partial class StartLoaderJobRequest : AmazonNeptunedataRequest
    {
        private List<string> _dependencies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _failOnError;
        private Format _format;
        private string _iamRoleArn;
        private Mode _mode;
        private Parallelism _parallelism;
        private Dictionary<string, string> _parserConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _queueRequest;
        private S3BucketRegion _s3BucketRegion;
        private string _source;
        private bool? _updateSingleCardinalityProperties;
        private bool? _userProvidedEdgeIds;

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// This is an optional parameter that can make a queued load request contingent on the
        /// successful completion of one or more previous jobs in the queue.
        /// </para>
        ///  
        /// <para>
        /// Neptune can queue up as many as 64 load requests at a time, if their <c>queueRequest</c>
        /// parameters are set to <c>"TRUE"</c>. The <c>dependencies</c> parameter lets you make
        /// execution of such a queued request dependent on the successful completion of one or
        /// more specified previous requests in the queue.
        /// </para>
        ///  
        /// <para>
        /// For example, if load <c>Job-A</c> and <c>Job-B</c> are independent of each other,
        /// but load <c>Job-C</c> needs <c>Job-A</c> and <c>Job-B</c> to be finished before it
        /// begins, proceed as follows:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit <c>load-job-A</c> and <c>load-job-B</c> one after another in any order, and
        /// save their load-ids.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit <c>load-job-C</c> with the load-ids of the two jobs in its <c>dependencies</c>
        /// field:
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Because of the <c>dependencies</c> parameter, the bulk loader will not start <c>Job-C</c>
        /// until <c>Job-A</c> and <c>Job-B</c> have completed successfully. If either one of
        /// them fails, Job-C will not be executed, and its status will be set to <c>LOAD_FAILED_BECAUSE_DEPENDENCY_NOT_SATISFIED</c>.
        /// </para>
        ///  
        /// <para>
        /// You can set up multiple levels of dependency in this way, so that the failure of one
        /// job will cause all requests that are directly or indirectly dependent on it to be
        /// cancelled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Dependencies
        {
            get { return this._dependencies; }
            set { this._dependencies = value; }
        }

        // Check to see if Dependencies property is set
        internal bool IsSetDependencies()
        {
            return this._dependencies != null && (this._dependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailOnError. 
        /// <para>
        ///  <b> <c>failOnError</c> </b>   –   A flag to toggle a complete stop on an error.
        /// </para>
        ///  
        /// <para>
        ///  <i>Allowed values</i>: <c>"TRUE"</c>, <c>"FALSE"</c>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Default value</i>: <c>"TRUE"</c>.
        /// </para>
        ///  
        /// <para>
        /// When this parameter is set to <c>"FALSE"</c>, the loader tries to load all the data
        /// in the location specified, skipping any entries with errors.
        /// </para>
        ///  
        /// <para>
        /// When this parameter is set to <c>"TRUE"</c>, the loader stops as soon as it encounters
        /// an error. Data loaded up to that point persists.
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
        /// The format of the data. For more information about data formats for the Neptune <c>Loader</c>
        /// command, see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format.html">Load
        /// Data Formats</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Allowed values</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>csv</c> </b> for the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
        /// CSV data format</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>opencypher</c> </b> for the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
        /// CSV data format</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>ntriples</c> </b> for the <a href="https://www.w3.org/TR/n-triples/">N-Triples
        /// RDF data format</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>nquads</c> </b> for the <a href="https://www.w3.org/TR/n-quads/">N-Quads RDF
        /// data format</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>rdfxml</c> </b> for the <a href="https://www.w3.org/TR/rdf-syntax-grammar/">RDF\XML
        /// RDF data format</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>turtle</c> </b> for the <a href="https://www.w3.org/TR/turtle/">Turtle RDF
        /// data format</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for an IAM role to be assumed by the Neptune DB instance
        /// for access to the S3 bucket. The IAM role ARN provided here should be attached to
        /// the DB cluster (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-IAM-add-role-cluster.html">Adding
        /// the IAM Role to an Amazon Neptune Cluster</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The load job mode.
        /// </para>
        ///  
        /// <para>
        ///  <i>Allowed values</i>: <c>RESUME</c>, <c>NEW</c>, <c>AUTO</c>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Default value</i>: <c>AUTO</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RESUME</c>   –   In RESUME mode, the loader looks for a previous load from this
        /// source, and if it finds one, resumes that load job. If no previous load job is found,
        /// the loader stops.
        /// </para>
        ///  
        /// <para>
        /// The loader avoids reloading files that were successfully loaded in a previous job.
        /// It only tries to process failed files. If you dropped previously loaded data from
        /// your Neptune cluster, that data is not reloaded in this mode. If a previous load job
        /// loaded all files from the same source successfully, nothing is reloaded, and the loader
        /// returns success.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW</c>   –   In NEW mode, the creates a new load request regardless of any previous
        /// loads. You can use this mode to reload all the data from a source after dropping previously
        /// loaded data from your Neptune cluster, or to load new data available at the same source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO</c>   –   In AUTO mode, the loader looks for a previous load job from the
        /// same source, and if it finds one, resumes that job, just as in <c>RESUME</c> mode.
        /// </para>
        ///  
        /// <para>
        /// If the loader doesn't find a previous load job from the same source, it loads all
        /// data from the source, just as in <c>NEW</c> mode.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Mode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Parallelism. 
        /// <para>
        /// The optional <c>parallelism</c> parameter can be set to reduce the number of threads
        /// used by the bulk load process.
        /// </para>
        ///  
        /// <para>
        ///  <i>Allowed values</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LOW</c> –   The number of threads used is the number of available vCPUs divided
        /// by 8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c> –   The number of threads used is the number of available vCPUs divided
        /// by 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HIGH</c> –   The number of threads used is the same as the number of available
        /// vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OVERSUBSCRIBE</c> –   The number of threads used is the number of available vCPUs
        /// multiplied by 2. If this value is used, the bulk loader takes up all available resources.
        /// </para>
        ///  
        /// <para>
        /// This does not mean, however, that the <c>OVERSUBSCRIBE</c> setting results in 100%
        /// CPU utilization. Because the load operation is I/O bound, the highest CPU utilization
        /// to expect is in the 60% to 70% range.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <i>Default value</i>: <c>HIGH</c> 
        /// </para>
        ///  
        /// <para>
        /// The <c>parallelism</c> setting can sometimes result in a deadlock between threads
        /// when loading openCypher data. When this happens, Neptune returns the <c>LOAD_DATA_DEADLOCK</c>
        /// error. You can generally fix the issue by setting <c>parallelism</c> to a lower setting
        /// and retrying the load command.
        /// </para>
        /// </summary>
        public Parallelism Parallelism
        {
            get { return this._parallelism; }
            set { this._parallelism = value; }
        }

        // Check to see if Parallelism property is set
        internal bool IsSetParallelism()
        {
            return this._parallelism != null;
        }

        /// <summary>
        /// Gets and sets the property ParserConfiguration. 
        /// <para>
        ///  <b> <c>parserConfiguration</c> </b>   –   An optional object with additional parser
        /// configuration values. Each of the child parameters is also optional:
        /// </para>
        ///  
        /// <para>
        ///  <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>namedGraphUri</c> </b>   –   The default graph for all RDF formats when no
        /// graph is specified (for non-quads formats and NQUAD entries with no graph).
        /// </para>
        ///  
        /// <para>
        /// The default is <c>https://aws.amazon.com/neptune/vocab/v01/DefaultNamedGraph</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>baseUri</c> </b>   –   The base URI for RDF/XML and Turtle formats.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>https://aws.amazon.com/neptune/default</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>allowEmptyStrings</c> </b>   –   Gremlin users need to be able to pass empty
        /// string values("") as node and edge properties when loading CSV data. If <c>allowEmptyStrings</c>
        /// is set to <c>false</c> (the default), such empty strings are treated as nulls and
        /// are not loaded.
        /// </para>
        ///  
        /// <para>
        /// If <c>allowEmptyStrings</c> is set to <c>true</c>, the loader treats empty strings
        /// as valid property values and loads them accordingly.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ParserConfiguration
        {
            get { return this._parserConfiguration; }
            set { this._parserConfiguration = value; }
        }

        // Check to see if ParserConfiguration property is set
        internal bool IsSetParserConfiguration()
        {
            return this._parserConfiguration != null && (this._parserConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueRequest. 
        /// <para>
        /// This is an optional flag parameter that indicates whether the load request can be
        /// queued up or not. 
        /// </para>
        ///  
        /// <para>
        /// You don't have to wait for one load job to complete before issuing the next one, because
        /// Neptune can queue up as many as 64 jobs at a time, provided that their <c>queueRequest</c>
        /// parameters are all set to <c>"TRUE"</c>. The queue order of the jobs will be first-in-first-out
        /// (FIFO).
        /// </para>
        ///  
        /// <para>
        /// If the <c>queueRequest</c> parameter is omitted or set to <c>"FALSE"</c>, the load
        /// request will fail if another load job is already running.
        /// </para>
        ///  
        /// <para>
        ///  <i>Allowed values</i>: <c>"TRUE"</c>, <c>"FALSE"</c>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Default value</i>: <c>"FALSE"</c>.
        /// </para>
        /// </summary>
        public bool? QueueRequest
        {
            get { return this._queueRequest; }
            set { this._queueRequest = value; }
        }

        // Check to see if QueueRequest property is set
        internal bool IsSetQueueRequest()
        {
            return this._queueRequest.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketRegion. 
        /// <para>
        /// The Amazon region of the S3 bucket. This must match the Amazon Region of the DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3BucketRegion S3BucketRegion
        {
            get { return this._s3BucketRegion; }
            set { this._s3BucketRegion = value; }
        }

        // Check to see if S3BucketRegion property is set
        internal bool IsSetS3BucketRegion()
        {
            return this._s3BucketRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The <c>source</c> parameter accepts an S3 URI that identifies a single file, multiple
        /// files, a folder, or multiple folders. Neptune loads every data file in any folder
        /// that is specified.
        /// </para>
        ///  
        /// <para>
        /// The URI can be in any of the following formats.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3://(bucket_name)/(object-key-name)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>https://s3.amazonaws.com/(bucket_name)/(object-key-name)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>https://s3.us-east-1.amazonaws.com/(bucket_name)/(object-key-name)</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <c>object-key-name</c> element of the URI is equivalent to the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html#API_ListObjects_RequestParameters">prefix</a>
        /// parameter in an S3 <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>
        /// API call. It identifies all the objects in the specified S3 bucket whose names begin
        /// with that prefix. That can be a single file or folder, or multiple files and/or folders.
        /// </para>
        ///  
        /// <para>
        /// The specified folder or folders can contain multiple vertex files and multiple edge
        /// files.
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
        /// Gets and sets the property UpdateSingleCardinalityProperties. 
        /// <para>
        ///  <c>updateSingleCardinalityProperties</c> is an optional parameter that controls how
        /// the bulk loader treats a new value for single-cardinality vertex or edge properties.
        /// This is not supported for loading openCypher data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Allowed values</i>: <c>"TRUE"</c>, <c>"FALSE"</c>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Default value</i>: <c>"FALSE"</c>.
        /// </para>
        ///  
        /// <para>
        /// By default, or when <c>updateSingleCardinalityProperties</c> is explicitly set to
        /// <c>"FALSE"</c>, the loader treats a new value as an error, because it violates single
        /// cardinality.
        /// </para>
        ///  
        /// <para>
        /// When <c>updateSingleCardinalityProperties</c> is set to <c>"TRUE"</c>, on the other
        /// hand, the bulk loader replaces the existing value with the new one. If multiple edge
        /// or single-cardinality vertex property values are provided in the source file(s) being
        /// loaded, the final value at the end of the bulk load could be any one of those new
        /// values. The loader only guarantees that the existing value has been replaced by one
        /// of the new ones.
        /// </para>
        /// </summary>
        public bool? UpdateSingleCardinalityProperties
        {
            get { return this._updateSingleCardinalityProperties; }
            set { this._updateSingleCardinalityProperties = value; }
        }

        // Check to see if UpdateSingleCardinalityProperties property is set
        internal bool IsSetUpdateSingleCardinalityProperties()
        {
            return this._updateSingleCardinalityProperties.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserProvidedEdgeIds. 
        /// <para>
        /// This parameter is required only when loading openCypher data that contains relationship
        /// IDs. It must be included and set to <c>True</c> when openCypher relationship IDs are
        /// explicitly provided in the load data (recommended).
        /// </para>
        ///  
        /// <para>
        /// When <c>userProvidedEdgeIds</c> is absent or set to <c>True</c>, an <c>:ID</c> column
        /// must be present in every relationship file in the load.
        /// </para>
        ///  
        /// <para>
        /// When <c>userProvidedEdgeIds</c> is present and set to <c>False</c>, relationship files
        /// in the load <b>must not</b> contain an <c>:ID</c> column. Instead, the Neptune loader
        /// automatically generates an ID for each relationship.
        /// </para>
        ///  
        /// <para>
        /// It's useful to provide relationship IDs explicitly so that the loader can resume loading
        /// after error in the CSV data have been fixed, without having to reload any relationships
        /// that have already been loaded. If relationship IDs have not been explicitly assigned,
        /// the loader cannot resume a failed load if any relationship file has had to be corrected,
        /// and must instead reload all the relationships.
        /// </para>
        /// </summary>
        public bool? UserProvidedEdgeIds
        {
            get { return this._userProvidedEdgeIds; }
            set { this._userProvidedEdgeIds = value; }
        }

        // Check to see if UserProvidedEdgeIds property is set
        internal bool IsSetUserProvidedEdgeIds()
        {
            return this._userProvidedEdgeIds.HasValue; 
        }

    }
}